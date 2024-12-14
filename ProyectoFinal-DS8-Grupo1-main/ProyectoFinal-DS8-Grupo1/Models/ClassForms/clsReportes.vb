Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports ProyectoFinal_DS8_Grupo1.clsReportes
Imports System.Data.SqlClient
Imports System.IO

Public Class clsReportes
    Public Shared Sub GenerarReporteRolesYUsuarios()
        Dim rutaPDF As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "RolesYUsuarios.pdf")
        Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
        Dim connectionString As String = My.Settings.ConexionBD

        Try
            ' Crear carpeta para guardar el PDF si no existe
            Dim rutaCarpeta As String = Path.GetDirectoryName(rutaPDF)
            If Not Directory.Exists(rutaCarpeta) Then
                Directory.CreateDirectory(rutaCarpeta)
            End If

            ' Inicializar el PDF
            PdfWriter.GetInstance(doc, New FileStream(rutaPDF, FileMode.Create))
            doc.Open()

            ' Agregar encabezado al PDF
            doc.Add(New Paragraph("Reporte de Roles y Usuarios"))
            doc.Add(New Paragraph("Fecha: " & DateTime.Now.ToString()))
            doc.Add(New Paragraph(" "))

            ' Crear tabla para el reporte
            Dim tabla As New PdfPTable(3)
            tabla.AddCell("Rol")
            tabla.AddCell("Usuario")
            tabla.AddCell("Correo")

            ' Conectar a la base de datos y ejecutar la consulta
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim storedProcedure As String = "ListarRolesYColaboradores"
                Using command As New SqlCommand(storedProcedure, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            tabla.AddCell(reader("Rol").ToString())
                            tabla.AddCell(reader("Usuario").ToString())
                            tabla.AddCell(reader("Correo").ToString())
                        End While
                    End Using
                End Using
            End Using

            ' Agregar la tabla al PDF
            doc.Add(tabla)

            ' Mensaje de confirmación y apertura del PDF
            MessageBox.Show("Reporte de roles y usuarios generado exitosamente en: " & rutaPDF)
            AbrirPDF(rutaPDF)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If doc.IsOpen Then doc.Close()
        End Try
    End Sub

    Public Shared Sub GenerarReporteMovimientoInventario()
        Dim rutaPDF As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "MovimientoInventario.pdf")
        Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
        Dim connectionString As String = My.Settings.ConexionBD

        Try
            ' Crear el directorio si no existe
            Dim rutaCarpeta As String = Path.GetDirectoryName(rutaPDF)
            If Not Directory.Exists(rutaCarpeta) Then
                Directory.CreateDirectory(rutaCarpeta)
            End If

            ' Crear el archivo PDF
            PdfWriter.GetInstance(doc, New FileStream(rutaPDF, FileMode.Create))
            doc.Open()

            ' Crear la conexión SQL
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Definir la consulta SQL
                Dim storedProcedure As String = "ObtenerProductos"
                ' Ejecutar la consulta
                Using command As New SqlCommand(storedProcedure, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Agregar el título y la fecha al documento
                        doc.Add(New Paragraph("Reporte de Movimiento de Inventario"))
                        doc.Add(New Paragraph("Fecha: " & DateTime.Now.ToString("yyyy-MM-dd")))
                        doc.Add(New Paragraph(" "))

                        ' Crear la tabla PDF
                        Dim tabla As New PdfPTable(4)
                        tabla.AddCell("Producto")
                        tabla.AddCell("Stock")
                        tabla.AddCell("Fecha Ingreso")
                        tabla.AddCell("Precio Unitario")

                        ' Agregar los datos de la consulta a la tabla
                        While reader.Read()
                            tabla.AddCell(reader("NombreProducto").ToString())
                            tabla.AddCell(reader("Stock").ToString())
                            tabla.AddCell(Convert.ToDateTime(reader("FechaIngreso")).ToString("yyyy-MM-dd"))
                            tabla.AddCell(Convert.ToDecimal(reader("PrecioUnitario")).ToString("C"))
                        End While

                        ' Agregar la tabla al documento PDF
                        doc.Add(tabla)
                    End Using
                End Using
            End Using

            ' Mostrar mensaje de éxito
            MessageBox.Show("Reporte de movimiento de inventario generado exitosamente en: " & rutaPDF)
            AbrirPDF(rutaPDF)

        Catch ex As Exception
            ' Manejo de errores
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Cerrar el documento PDF si está abierto
            If doc.IsOpen Then doc.Close()
        End Try
    End Sub

    Public Shared Sub GenerarReportePedidosProcesadosYNoProcesados()
        Dim rutaPDF As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "PedidosProcesadosYNoProcesados.pdf")
        Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
        Dim connectionString As String = My.Settings.ConexionBD

        Try
            ' Crear el directorio si no existe
            Dim rutaCarpeta As String = Path.GetDirectoryName(rutaPDF)
            If Not Directory.Exists(rutaCarpeta) Then
                Directory.CreateDirectory(rutaCarpeta)
            End If

            ' Crear el archivo PDF
            PdfWriter.GetInstance(doc, New FileStream(rutaPDF, FileMode.Create))
            doc.Open()

            ' Crear la conexión SQL
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Definir la consulta SQL
                Dim storedProcedure As String = "ObtenerPedidosConProveedores"

                ' Ejecutar la consulta
                Using command As New SqlCommand(storedProcedure, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Agregar el título y la fecha al documento
                        doc.Add(New Paragraph("Reporte de Pedidos Procesados y No Procesados"))
                        doc.Add(New Paragraph("Fecha: " & DateTime.Now.ToString("yyyy-MM-dd")))
                        doc.Add(New Paragraph(" "))

                        ' Crear la tabla PDF
                        Dim tabla As New PdfPTable(5)
                        tabla.AddCell("Pedido ID")
                        tabla.AddCell("Proveedor")
                        tabla.AddCell("Fecha Pedido")
                        tabla.AddCell("Estado")
                        tabla.AddCell("Total")

                        ' Agregar los datos de la consulta a la tabla
                        While reader.Read()
                            tabla.AddCell(reader("PedidoID").ToString())
                            tabla.AddCell(reader("NombreProveedor").ToString())
                            tabla.AddCell(Convert.ToDateTime(reader("FechaPedido")).ToString("yyyy-MM-dd"))
                            tabla.AddCell(reader("EstadoPedido").ToString())
                            tabla.AddCell(Convert.ToDecimal(reader("TotalPedido")).ToString("C"))
                        End While

                        ' Agregar la tabla al documento PDF
                        doc.Add(tabla)
                    End Using
                End Using
            End Using

            ' Mostrar mensaje de éxito
            MessageBox.Show("Reporte de pedidos procesados y no procesados generado exitosamente en: " & rutaPDF)
            AbrirPDF(rutaPDF)

        Catch ex As Exception
            ' Manejo de errores
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Cerrar el documento PDF si está abierto
            If doc.IsOpen Then doc.Close()
        End Try
    End Sub

    Public Shared Sub AbrirPDF(ByVal rutaPDF As String)
        Try
            If File.Exists(rutaPDF) Then
                Process.Start(New ProcessStartInfo With {
                    .FileName = rutaPDF,
                    .UseShellExecute = True ' Permite abrir el archivo con la aplicación predeterminada
                })
            Else
                MessageBox.Show("El archivo PDF no se encontró en la ruta especificada.")
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el PDF: " & ex.Message)
        End Try
    End Sub

    Public Class RolColaborador
        Public Property Rol As String
        Public Property Usuario As String
        Public Property Correo As String
    End Class


    Public Shared Function FetchRolesUsuarios() As List(Of RolColaborador)
        Dim listDatos As New List(Of RolColaborador)()
        Dim connectionString As String = My.Settings.ConexionBD

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim storedProcedure As String = "ListarRolesYColaboradores"
            Using command As New SqlCommand(storedProcedure, connection)
                command.CommandType = CommandType.StoredProcedure

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Llena la lista con los datos obtenidos
                        listDatos.Add(New RolColaborador() With {
                            .Rol = reader("Rol").ToString(),
                            .Usuario = reader("Usuario").ToString(),
                            .Correo = reader("Correo").ToString()
                        })
                    End While
                End Using
            End Using
        End Using

        Return listDatos
    End Function

    Public Class Productos
        Public Property Producto As String
        Public Property Stock As String
        Public Property FechaIngreso As String
        Public Property PrecioUni As String
    End Class

    Public Shared Function FetchProducto() As List(Of Productos)
        Dim listDatos As New List(Of Productos)()
        Dim connectionString As String = My.Settings.ConexionBD

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim storedProcedure As String = "ObtenerProductos"
            Using command As New SqlCommand(storedProcedure, connection)
                command.CommandType = CommandType.StoredProcedure

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Llena la lista con los datos obtenidos
                        listDatos.Add(New Productos() With {
                            .Producto = reader("NombreProducto").ToString(),
                            .Stock = reader("Stock").ToString(),
                            .FechaIngreso = reader("FechaIngreso").ToString(),
                            .PrecioUni = reader("PrecioUnitario").ToString()
                        })
                    End While
                End Using
            End Using
        End Using

        Return listDatos
    End Function

    Public Class PedidosProveedores
        Public Property PedidoID As String
        Public Property NombreProveedor As String
        Public Property FechaPedido As String
        Public Property EstadoPedido As String
        Public Property TotalPedido As String
    End Class

    Public Shared Function FetchPedidosProveedor() As List(Of PedidosProveedores)
        Dim listDatos As New List(Of PedidosProveedores)()
        Dim connectionString As String = My.Settings.ConexionBD

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim storedProcedure As String = "ObtenerPedidosConProveedores"
            Using command As New SqlCommand(storedProcedure, connection)
                command.CommandType = CommandType.StoredProcedure

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Llena la lista con los datos obtenidos
                        listDatos.Add(New PedidosProveedores() With {
                            .PedidoID = reader("PedidoID").ToString(),
                            .NombreProveedor = reader("NombreProveedor").ToString(),
                            .FechaPedido = reader("FechaPedido").ToString(),
                            .EstadoPedido = reader("EstadoPedido").ToString(),
                            .TotalPedido = reader("TotalPedido").ToString()
                        })
                    End While
                End Using
            End Using
        End Using

        Return listDatos
    End Function

End Class
