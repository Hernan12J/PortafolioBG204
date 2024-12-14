Imports System.Data.SqlClient

Public Class clsProveedores
    Dim connectionString As String = My.Settings.ConexionBD

    Public Function InsertarProveedor(nombreProveedor As String, telefono As String, ByRef mensaje As String) As String
        Try
            Using con As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("InsertarProveedor", con)
                cmd.CommandType = CommandType.StoredProcedure

                ' Parámetro de entrada
                cmd.Parameters.AddWithValue("@NombreProveedor", nombreProveedor)
                cmd.Parameters.AddWithValue("@Telefono", telefono)

                ' Parámetro de salida
                Dim paramMensaje As SqlParameter = cmd.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 50)
                paramMensaje.Direction = ParameterDirection.Output

                con.Open()
                cmd.ExecuteNonQuery()

                ' Capturar y devolver el mensaje de confirmación
                mensaje = paramMensaje.Value.ToString()
            End Using
        Catch ex As Exception
            ' Inicializar el mensaje en caso de error
            mensaje = "Error: " & ex.Message
        End Try

        Return mensaje
    End Function

    Public Function ActualizarProveedor(proveedorID As Integer, nombreProveedor As String, telefono As String, ByRef mensaje As String) As String
        Using connection As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("ActualizarProveedor", connection)
            cmd.CommandType = CommandType.StoredProcedure

            ' Parámetros del procedimiento almacenado
            cmd.Parameters.AddWithValue("@ProveedorID", proveedorID)
            cmd.Parameters.AddWithValue("@NombreProveedor", nombreProveedor)
            cmd.Parameters.AddWithValue("@Telefono", telefono)

            ' Parámetro de salida
            Dim outputParam As New SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) With {
            .Direction = ParameterDirection.Output
        }
            cmd.Parameters.Add(outputParam)

            connection.Open()
            cmd.ExecuteNonQuery()

            ' Asignar el mensaje de salida al parámetro ByRef
            mensaje = outputParam.Value.ToString()
        End Using

        Return mensaje
    End Function

    Public Function EliminarProveedor(proveedorID As Integer, ByRef mensaje As String) As String
        Try
            Using con As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("EliminarProveedor", con)
                cmd.CommandType = CommandType.StoredProcedure

                ' Parámetro de entrada
                cmd.Parameters.AddWithValue("@ProveedorID", proveedorID)

                ' Parámetro de salida
                Dim paramMensaje As SqlParameter = cmd.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 50)
                paramMensaje.Direction = ParameterDirection.Output

                con.Open()
                cmd.ExecuteNonQuery()

                ' Capturar y devolver el mensaje de confirmación
                mensaje = paramMensaje.Value.ToString()
            End Using
        Catch ex As Exception
            ' Inicializar el mensaje en caso de error
            mensaje = "Error: " & ex.Message
        End Try

        Return mensaje
    End Function
    Public Function MostrarProveedores() As DataTable
        Dim proveedores As New DataTable()
        Try
            Using con As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("MostrarProveedores", con)
                cmd.CommandType = CommandType.StoredProcedure

                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    proveedores.Load(reader)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Return proveedores
    End Function
    Public Function BuscarCategoriaPorID(proveedorID As Integer) As DataRow
        Dim proveedor As DataRow = Nothing
        Try
            Using con As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("BuscarProveedoresPorID", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@ProveedorID", proveedorID)

                con.Open()
                Dim table As New DataTable()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    table.Load(reader)
                End Using

                If table.Rows.Count > 0 Then
                    proveedor = table.Rows(0)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Return proveedor
    End Function
End Class
