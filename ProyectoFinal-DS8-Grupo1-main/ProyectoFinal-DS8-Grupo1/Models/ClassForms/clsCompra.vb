Imports System.Data.SqlClient

Public Class clsCompra
    Dim connectionString As String = My.Settings.ConexionBD
    Public Function InsertarFactura(folio As String, numeroFactura As Integer, fecha As DateTime, usuario As Integer, total As String, metodoPago As String) As Integer
        Dim facturaID As Integer = 0  ' Variable para almacenar el FacturaID
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                ' Llamada al procedimiento almacenado
                Dim cmd As New SqlCommand("InsertarFactura", conn)
                cmd.CommandType = CommandType.StoredProcedure

                ' Agregar los parámetros
                With cmd.Parameters
                    cmd.Parameters.AddWithValue("@Folio", folio)
                    cmd.Parameters.AddWithValue("@NumeroFactura", numeroFactura)
                    cmd.Parameters.AddWithValue("@FechaFactura", fecha)
                    cmd.Parameters.AddWithValue("@Usuario", usuario)
                    cmd.Parameters.AddWithValue("@TotalFactura", total)
                    cmd.Parameters.AddWithValue("@MetodoPago", metodoPago)

                    ' Parámetro de salida para obtener el FacturaID
                    Dim outputParam As New SqlParameter("@FacturaID", SqlDbType.Int)
                    outputParam.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(outputParam)
                End With

                cmd.ExecuteNonQuery()

                ' Obtener el FacturaID del parámetro de salida
                facturaID = Convert.ToInt32(cmd.Parameters("@FacturaID").Value)

            Catch ex As Exception
                MessageBox.Show("Error al insertar la factura: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
        Return facturaID  ' Retorna el FacturaID generado
    End Function

    Public Function MostrarProductos() As DataTable
        Dim dtProductos As New DataTable()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand("MostrarProductos2", conn)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dtProductos)
                End Using
            End Using
        End Using
        Return dtProductos
    End Function

    Public Function ObtenerPrecioProducto(productoID As Integer) As Decimal
        Dim precio As Decimal
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand("ObtenerPrecioProducto", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ProductoID", productoID)
                precio = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
        End Using
        Return precio
    End Function
    Public Function ObtenerIDdecliente(UserName As String) As Integer
        Dim Clienteid As Integer = 0 ' Inicializa la variable Clienteid como Integer
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand("ObtenerIDdecliente", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@UserName", UserName) ' Cambié @ClienteID por @UserName
                ' Ejecutar el procedimiento y obtener el valor de la primera columna
                Clienteid = Convert.ToInt32(cmd.ExecuteScalar()) ' Ejecutar el procedimiento y convertir el valor a Integer
            End Using
        End Using
        Return Clienteid
    End Function

    Public Function InsertardetalleFactura(facturaid As String, productoid As String, cantidad As String, preciounitario As String, subtotal As String) As String
        Dim mensaje As String = ""
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                ' Llamada al procedimiento almacenado
                Dim cmd As New SqlCommand("InsertarDetalleFactura", conn)
                cmd.CommandType = CommandType.StoredProcedure

                ' Agregar los parámetros
                With cmd.Parameters
                    cmd.Parameters.AddWithValue("@FacturaID", CInt(facturaid))
                    cmd.Parameters.AddWithValue("@ProductoID", CInt(productoid))
                    cmd.Parameters.AddWithValue("@cantidad", cantidad)
                    cmd.Parameters.AddWithValue("@PrecioUnitario", CDec(preciounitario))
                    cmd.Parameters.AddWithValue("@subtotal", CDec(subtotal))


                    ' Ejecutar el comando
                    cmd.ExecuteNonQuery()
                End With

                mensaje = "Detalle de Factura insertada correctamente"
            Catch ex As Exception
                mensaje = "Error: " & ex.Message
            Finally
                conn.Close()
            End Try
        End Using
        Return mensaje
    End Function
    Public Function ActualizarStock(productoId As Integer, cantidadVendida As Integer) As String
        Using conn As New SqlConnection(My.Settings.ConexionBD)
            conn.Open()
            Using cmd As New SqlCommand("ActualizarStock", conn)
                cmd.CommandType = CommandType.StoredProcedure

                ' Añadir los parámetros necesarios
                cmd.Parameters.AddWithValue("@ProductoId", productoId)
                cmd.Parameters.AddWithValue("@CantidadVendida", cantidadVendida)

                ' Crear un parámetro de salida para el mensaje
                Dim mensajeParam As New SqlParameter("@Mensaje", SqlDbType.NVarChar, 100)
                mensajeParam.Direction = ParameterDirection.Output
                cmd.Parameters.Add(mensajeParam)

                ' Ejecutar el procedimiento almacenado
                cmd.ExecuteNonQuery()

                ' Obtener el mensaje de salida
                Return mensajeParam.Value.ToString()
            End Using
        End Using
    End Function
    Public Function LeerDetallefactura() As DataTable
        Dim dtProveedores As New DataTable()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand("Mostrardetallefactura", conn)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dtProveedores)
                End Using
            End Using
        End Using
        Return dtProveedores
    End Function
    Public Function Obtenerdatosdecliente(UserName As String) As DataTable
        Dim clienteData As New DataTable()

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand("Obtenerdatosdecliente", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@UserName", UserName)

                ' Usa un DataAdapter para llenar el DataTable con los datos del cliente
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(clienteData)
                End Using
            End Using
        End Using

        Return clienteData
    End Function

    Public Function ObtenerDetalleFactura(FacturaId As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using cmd As New SqlCommand("MostrarFacturaDetalle", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@FacturaId", FacturaId)
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener los detalles de la factura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function


End Class
