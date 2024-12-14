Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class FrmFactura
    Dim objFactura As New clsCompra
    ' Propiedad para almacenar el userName
    Private _userName As String

    ' Constructor que recibe el userName
    Public Sub New(userName As String)

        InitializeComponent()

        'Asigna el valor de userName a la propiedad
        _userName = userName
    End Sub
    ' Cerrar formulario al hacer clic en el botón de cerrar
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    ' Al cargar el formulario
    Private Sub FrmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Crear un DataTable para obtener los datos de la factura
        Dim table As New DataTable
        table = objFactura.LeerDetallefactura()

        ' Asignar el DataTable al DataGridView para mostrar los datos
        dgvFactura.DataSource = table
    End Sub

    Private Sub dgvFactura_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFactura.CellClick
        ' Verificar que se ha hecho clic en una fila válida
        If e.RowIndex >= 0 Then


            ' Obtener la fila seleccionada
            Dim row As DataGridViewRow = dgvFactura.Rows(e.RowIndex)

            ' Cargar los datos de la fila seleccionada en los TextBoxes
            txtFolio.Text = row.Cells("Folio").Value.ToString()
            txtNumeroFactura.Text = row.Cells("NumeroFactura").Value.ToString()

            ' Validar y calcular los valores numéricos
            Dim subTotal As Decimal
            Dim itbms As Decimal
            Dim total As Decimal

            ' Intentar convertir el valor de Total a Decimal
            If Decimal.TryParse(row.Cells("Total").Value.ToString(), subTotal) Then
                ' Calcular el ITBMS y el Total
                itbms = subTotal * 0.07D
                total = subTotal + itbms

                ' Mostrar los valores calculados en los TextBoxes
                txtSubTotal.Text = subTotal.ToString("F2")
                txtitbms.Text = itbms.ToString("F2")
                txtTotal.Text = total.ToString("F2")
            Else
                ' Si la conversión falla, mostrar un mensaje de error
                MessageBox.Show("El valor de 'Total' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Asignar el método de pago
            txtMetododePago.Text = row.Cells("MetodoPago").Value.ToString()

            ' Llamar a la función para obtener los datos del cliente
            Dim clienteData As DataTable = objFactura.Obtenerdatosdecliente(_userName)

            ' Verificar que se obtuvieron datos
            If clienteData.Rows.Count > 0 Then
                Dim clienteRow As DataRow = clienteData.Rows(0)

                ' Asignar los valores del cliente a los TextBox correspondientes
                txtNombre.Text = clienteRow("NombreCliente").ToString()
                txtApellido.Text = clienteRow("ApellidoCliente").ToString()
                txtCorreo.Text = clienteRow("Correo").ToString()
                txtTelefono.Text = clienteRow("Telefono").ToString()
                txtDireccion.Text = clienteRow("DireccionCli").ToString()
            Else
                MessageBox.Show("No se encontraron datos del cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            ' Verificar que hay una fila seleccionada
            If dgvFactura.SelectedRows.Count > 0 Then
                ' Obtener el FacturaId de la columna correspondiente en la fila seleccionada
                Dim facturaId As Integer = Convert.ToInt32(dgvFactura.SelectedRows(0).Cells("FacturaId").Value)

                ' Llamar a la función con el FacturaId
                Dim detallesFactura As DataTable = objFactura.ObtenerDetalleFactura(facturaId)

                ' Verificar si se obtuvieron datos
                If detallesFactura.Rows.Count > 0 Then
                    ' Construir el mensaje con los detalles
                    Dim mensaje As String = "Detalles de la Factura:" & Environment.NewLine & Environment.NewLine

                    For Each row As DataRow In detallesFactura.Rows
                        mensaje &= "Producto: " & row("Producto").ToString() & Environment.NewLine
                        mensaje &= "Precio Unitario: " & Convert.ToDecimal(row("PrecioUnitario")).ToString("C2") & Environment.NewLine
                        mensaje &= "Cantidad: " & row("Cantidad").ToString() & Environment.NewLine
                        mensaje &= "Subtotal: " & Convert.ToDecimal(row("Subtotal")).ToString("C2") & Environment.NewLine
                        mensaje &= "-------------------------------------" & Environment.NewLine
                    Next

                    ' Mostrar los detalles en un MessageBox
                    MessageBox.Show(mensaje, "Detalle de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No hay detalles disponibles para la factura.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Por favor selecciona una factura.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al mostrar los detalles de la factura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
