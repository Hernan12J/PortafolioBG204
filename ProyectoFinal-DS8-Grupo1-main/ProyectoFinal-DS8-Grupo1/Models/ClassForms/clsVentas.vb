Imports System.Data.SqlClient

Public Class clsVentas
    Dim connectionString As String = My.Settings.ConexionBD
    Public Function InsertarVenta(fechaVenta As Date, totalVenta As Decimal, clienteID As Integer) As String
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("InsertarVenta", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@FechaVenta", fechaVenta)
                command.Parameters.AddWithValue("@TotalVenta", totalVenta)
                command.Parameters.AddWithValue("@ClienteID", clienteID)

                Dim mensajeParam As New SqlParameter("@Mensaje", SqlDbType.NVarChar, 250)
                mensajeParam.Direction = ParameterDirection.Output
                command.Parameters.Add(mensajeParam)

                connection.Open()
                command.ExecuteNonQuery()
                Return mensajeParam.Value.ToString()
            End Using
        End Using
    End Function
    Public Function ActualizarVenta(ventaID As Integer, fechaVenta As Date, totalVenta As Decimal, clienteID As Integer) As String
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("ActualizarVenta", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@VentaID", ventaID)
                command.Parameters.AddWithValue("@FechaVenta", fechaVenta)
                command.Parameters.AddWithValue("@TotalVenta", totalVenta)
                command.Parameters.AddWithValue("@ClienteID", clienteID)

                Dim mensajeParam As New SqlParameter("@Mensaje", SqlDbType.NVarChar, 250)
                mensajeParam.Direction = ParameterDirection.Output
                command.Parameters.Add(mensajeParam)

                connection.Open()
                command.ExecuteNonQuery()
                Return mensajeParam.Value.ToString()
            End Using
        End Using
    End Function
    Public Function EliminarVenta(ventaID As Integer) As String
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("EliminarVenta", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@VentaID", ventaID)

                Dim mensajeParam As New SqlParameter("@Mensaje", SqlDbType.NVarChar, 250)
                mensajeParam.Direction = ParameterDirection.Output
                command.Parameters.Add(mensajeParam)

                connection.Open()
                command.ExecuteNonQuery()
                Return mensajeParam.Value.ToString()
            End Using
        End Using
    End Function
    Public Function MostrarTodasLasVentas() As DataTable
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("MostrarVentas", connection)
                command.CommandType = CommandType.StoredProcedure

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    Dim table As New DataTable()
                    table.Load(reader)
                    Return table
                End Using
            End Using
        End Using
    End Function

End Class
