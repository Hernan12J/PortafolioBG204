Imports System.Data.SqlClient

Public Class clsColaborador
    Dim connectionString As String = My.Settings.ConexionBD
    Public Function CrearColaborador(colabName As String, passwordColab As String, nombre As String, apellido As String, correo As String, direccionColab As String, telefonoColab As String, rolID As Integer, ByRef mensaje As String) As Boolean
        Try
            Using con As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("CrearColaborador", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@ColabName", colabName)
                cmd.Parameters.AddWithValue("@PasswordColab", passwordColab)
                cmd.Parameters.AddWithValue("@Nombre", nombre)
                cmd.Parameters.AddWithValue("@Apellido", apellido)
                cmd.Parameters.AddWithValue("@Correo", correo)
                cmd.Parameters.AddWithValue("@DireccionColab", direccionColab)
                cmd.Parameters.AddWithValue("@TelefonoColab", telefonoColab)
                cmd.Parameters.AddWithValue("@RolID", rolID)

                con.Open()
                cmd.ExecuteNonQuery()
                mensaje = "Colaborador creado correctamente."
                Return True
            End Using
        Catch ex As SqlException
            If ex.Number = 50000 Then ' Error específico del RAISERROR en SQL
                mensaje = ex.Message
            Else
                mensaje = "Error: " & ex.Message
            End If
            Return False
        End Try
    End Function

    Public Function ActualizarColaborador(colabID As Integer, colabName As String, passwordColab As String, nombre As String, apellido As String, correo As String, direccionColab As String, telefonoColab As String, rolID As Integer, ByRef mensaje As String) As Boolean
        Try
            Using con As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("ActualizarColaborador", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@ColabID", colabID)
                cmd.Parameters.AddWithValue("@ColabName", colabName)
                cmd.Parameters.AddWithValue("@PasswordColab", passwordColab)
                cmd.Parameters.AddWithValue("@Nombre", nombre)
                cmd.Parameters.AddWithValue("@Apellido", apellido)
                cmd.Parameters.AddWithValue("@Correo", correo)
                cmd.Parameters.AddWithValue("@DireccionColab", direccionColab)
                cmd.Parameters.AddWithValue("@TelefonoColab", telefonoColab)
                cmd.Parameters.AddWithValue("@RolID", rolID)

                con.Open()
                cmd.ExecuteNonQuery()
                mensaje = "Colaborador actualizado correctamente."
                Return True
            End Using
        Catch ex As SqlException
            If ex.Number = 50000 Then ' Error específico del RAISERROR en SQL
                mensaje = ex.Message
            Else
                mensaje = "Error: " & ex.Message
            End If
            Return False
        End Try
    End Function


    Public Function EliminarColaborador(colabID As Integer, ByRef mensaje As String) As Boolean
        Try
            Using con As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("EliminarColaborador", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@ColabID", colabID)

                con.Open()
                cmd.ExecuteNonQuery()
                mensaje = "Colaborador eliminado correctamente."
                Return True
            End Using
        Catch ex As SqlException
            If ex.Number = 50000 Then ' Error específico del RAISERROR en SQL
                mensaje = ex.Message
            Else
                mensaje = "Error: " & ex.Message
            End If
            Return False
        End Try
    End Function

    Public Function LeerColaboradores() As DataTable
        Dim dt As New DataTable()
        Try
            Using con As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("LeerColaboradores", con)
                cmd.CommandType = CommandType.StoredProcedure

                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

End Class
