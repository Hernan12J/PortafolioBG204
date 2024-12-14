Imports System.Data.SqlClient

Public Class clsLogin
    Dim connectionString As String = My.Settings.ConexionBD
    Public Function ValidarCredenciales(userName As String, password As String) As String
        Dim rolNombre As String = String.Empty

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Validar en la tabla Usuarios
                Using command As New SqlCommand("ValidarColaborador", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@UserName", userName)
                    command.Parameters.AddWithValue("@Password", password)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            rolNombre = reader("NombreRol").ToString()
                        End If
                    End Using
                End Using

                ' Si no se encontró en Usuarios, validar en Clientes
                If String.IsNullOrEmpty(rolNombre) Then
                    Using command As New SqlCommand("ValidarCliente", connection)
                        command.CommandType = CommandType.StoredProcedure
                        command.Parameters.AddWithValue("@UserName", userName)
                        command.Parameters.AddWithValue("@Password", password)

                        Using reader As SqlDataReader = command.ExecuteReader()
                            If reader.Read() Then
                                rolNombre = reader("NombreRol").ToString()
                            End If
                        End Using
                    End Using
                End If
            End Using

            ' Retornar el rol si se encontró
            If Not String.IsNullOrEmpty(rolNombre) Then
                Return rolNombre
            Else
                Return "NoExiste"
            End If
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function
End Class
