Imports System.Data.SqlClient

Public Class clsRoles
    Dim connectionString As String = My.Settings.ConexionBD
    Public Function CrearRol(nombreRol As String, ByRef mensaje As String) As Boolean
        Try
            Using con As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("CrearRol", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@NombreRol", nombreRol)
                Dim outputMsg As New SqlParameter("@Mensaje", SqlDbType.NVarChar, -1)
                outputMsg.Direction = ParameterDirection.Output
                cmd.Parameters.Add(outputMsg)

                con.Open()
                cmd.ExecuteNonQuery()
                mensaje = outputMsg.Value.ToString()
                Return True
            End Using
        Catch ex As Exception
            mensaje = "Error: " & ex.Message
            Return False
        End Try
    End Function
    Public Function ActualizarRol(rolID As Integer, nombreRol As String, ByRef mensaje As String) As Boolean
        Try
            Using con As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("ActualizarRol", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@RolID", rolID)
                cmd.Parameters.AddWithValue("@NombreRol", nombreRol)
                Dim outputMsg As New SqlParameter("@Mensaje", SqlDbType.NVarChar, -1)
                outputMsg.Direction = ParameterDirection.Output
                cmd.Parameters.Add(outputMsg)

                con.Open()
                cmd.ExecuteNonQuery()
                mensaje = outputMsg.Value.ToString()
                Return True
            End Using
        Catch ex As Exception
            mensaje = "Error: " & ex.Message
            Return False
        End Try
    End Function
    Public Function EliminarRol(rolID As Integer, ByRef mensaje As String) As Boolean
        Try
            Using con As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("EliminarRol", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@RolID", rolID)
                Dim outputMsg As New SqlParameter("@Mensaje", SqlDbType.NVarChar, -1)
                outputMsg.Direction = ParameterDirection.Output
                cmd.Parameters.Add(outputMsg)

                con.Open()
                cmd.ExecuteNonQuery()
                mensaje = outputMsg.Value.ToString()
                Return True
            End Using
        Catch ex As Exception
            mensaje = "Error: " & ex.Message
            Return False
        End Try
    End Function
    Public Function LeerRoles() As DataTable
        Dim dt As New DataTable()
        Try
            Using con As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("LeerRoles", con)
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
