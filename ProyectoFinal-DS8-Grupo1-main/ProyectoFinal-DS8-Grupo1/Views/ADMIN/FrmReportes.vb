Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports com.itextpdf.text.pdf
Imports ProyectoFinal_DS8_Grupo1.clsReportes

Public Class FrmReportes
    'Variables
    Public Property ReporteId As Integer

    Private Sub ButtonGenerarReporteRolesYUsuarios(sender As Object, e As EventArgs)
        clsReportes.GenerarReporteRolesYUsuarios()
    End Sub

    Private Sub ButtonGenerarReportePedidosProcesadosYNoProcesados(sender As Object, e As EventArgs) Handles Button3.Click
        clsReportes.GenerarReportePedidosProcesadosYNoProcesados()
    End Sub

    Private Sub ButtonGenerarReporteMovimientoInventario(sender As Object, e As EventArgs) Handles Button2.Click
        clsReportes.GenerarReporteMovimientoInventario()
    End Sub

    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case ReporteId
            Case 1
                Label4.Text = "Reporte de Usuario"
                grupoInventario.Visible = False
                listProducto.Visible = False
                grupoPedidos.Visible = False
                listPedidos.Visible = False
                listDatos.Items.Clear()
                Dim datos As List(Of RolColaborador) = clsReportes.FetchRolesUsuarios()
                For Each dato In datos
                    With listDatos.Items.Add($"{dato.Usuario}")
                        .SubItems.Add($"{dato.Correo}")
                        .SubItems.Add($"{dato.Rol}")
                    End With
                Next
            Case 2
                Label4.Text = "Reporte de Producto"
                grupoUsuarios.Visible = False
                listDatos.Visible = False
                grupoPedidos.Visible = False
                listPedidos.Visible = False
                listProducto.Items.Clear()
                Dim datos As List(Of Productos) = clsReportes.FetchProducto()
                For Each dato In datos
                    With listProducto.Items.Add($"{dato.Producto}")
                        .SubItems.Add($"{dato.Stock}")
                        .SubItems.Add($"{dato.FechaIngreso}")
                        .SubItems.Add($"{dato.PrecioUni}")
                    End With
                Next
            Case 3
                Label4.Text = "Reporte de Pedidos Proveedor"
                grupoUsuarios.Visible = False
                grupoInventario.Visible = False
                listDatos.Visible = False
                listProducto.Visible = False
                listProducto.Items.Clear()
                Dim datos As List(Of PedidosProveedores) = clsReportes.FetchPedidosProveedor()
                For Each dato In datos
                    With listPedidos.Items.Add($"{dato.PedidoID}")
                        .SubItems.Add($"{dato.NombreProveedor}")
                        .SubItems.Add($"{dato.FechaPedido}")
                        .SubItems.Add($"{dato.EstadoPedido}")
                        .SubItems.Add($"{dato.TotalPedido}")
                    End With
                Next
        End Select
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class