Imports System.Data.SqlClient

Public Class FrmCompra

    ' Propiedad para almacenar el userName
    Private _userName As String

    ' Constructor que recibe el userName
    Public Sub New(userName As String)

        InitializeComponent()

        'Asigna el valor de userName a la propiedad
        _userName = userName
    End Sub

    Dim objFactura As New clsCompra
    Dim objVenta As New clsVentas
    Private Sub FrmCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el DataGridView con un ComboBox para seleccionar productos
        Dim comboCol As New DataGridViewComboBoxColumn
        comboCol.HeaderText = "Producto"
        comboCol.Name = "Producto"
        comboCol.DataSource = objFactura.MostrarProductos() ' Método para llenar los productos
        comboCol.DisplayMember = "NombreProducto"
        comboCol.ValueMember = "ProductoId"
        DgvProveedores.Columns.Add(comboCol)

        ' Agregar la columna de cantidad
        Dim cantidadCol As New DataGridViewTextBoxColumn
        cantidadCol.HeaderText = "Cantidad"
        cantidadCol.Name = "Cantidad"
        DgvProveedores.Columns.Add(cantidadCol)

        ' Agregar la columna de precio unitario
        Dim precioCol As New DataGridViewTextBoxColumn
        precioCol.HeaderText = "Precio Unitario"
        precioCol.Name = "PrecioUnitario"
        precioCol.ReadOnly = True ' Solo lectura
        DgvProveedores.Columns.Add(precioCol)

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If DgvProveedores.Rows.Count = 0 OrElse DgvProveedores.Rows(0).Cells("Producto").Value Is Nothing Then
            MessageBox.Show("Debe agregar al menos un producto a la factura.")
            Return
        End If

        ' Validar que se ha seleccionado un método de pago
        If cbxMetodopago.SelectedItem Is Nothing Then
            MessageBox.Show("Debe seleccionar un método de pago.")
            Return
        End If

        ' Obtener el valor de Método de Pago
        Dim metodoPago As String = cbxMetodopago.SelectedItem.ToString()

        ' Generar el folio
        Dim folio As String = $"F-{DateTime.Now:yyyyMMddHHmmss}" ' Formato: F-YYYYMMDDHHMMSS

        ' Generar el número de factura
        Dim numeroFactura As Integer
        Using conn As New SqlConnection(My.Settings.ConexionBD)
            conn.Open()
            Using cmd As New SqlCommand("SELECT ISNULL(MAX(NumeroFactura), 0) + 1 FROM FACTURAS", conn)
                numeroFactura = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using

        ' Calcular el total de la factura
        Dim totalFactura As Decimal = CalcularTotal()
        Dim Usuario As Integer = objFactura.ObtenerIDdecliente(_userName)

        ' Insertar la factura y obtener el FacturaID generado
        Dim facturaID As Integer = objFactura.InsertarFactura(folio, numeroFactura, DateTime.Now, Usuario, totalFactura, metodoPago)

        ' Verificar si la factura se insertó correctamente
        If facturaID > 0 Then
            ' Verificar stock antes de insertar los detalles
            Dim stockSuficiente As Boolean = True
            For Each row As DataGridViewRow In DgvProveedores.Rows
                If Not row.IsNewRow AndAlso row.Cells("Producto").Value IsNot Nothing Then
                    Dim productoId As Integer = CInt(row.Cells("Producto").Value)
                    Dim cantidad As Integer = CInt(row.Cells("Cantidad").Value)

                    ' Llamar al procedimiento almacenado para verificar stock
                    Dim mensaje As String = objFactura.ActualizarStock(productoId, cantidad)
                    If mensaje = "Stock agotado" Then
                        stockSuficiente = False
                        MessageBox.Show($"No hay suficiente stock para el producto: {row.Cells("Producto").Value.ToString()}.")
                        Exit For ' Salir del bucle si el stock es insuficiente
                    End If
                End If
            Next

            If stockSuficiente Then
                ' Insertar los detalles de la factura si hay suficiente stock
                For Each row As DataGridViewRow In DgvProveedores.Rows
                    If Not row.IsNewRow AndAlso row.Cells("Producto").Value IsNot Nothing Then
                        Dim subtotal As Decimal = 0
                        Dim productoId As Integer = CInt(row.Cells("Producto").Value)
                        Dim cantidad As Integer = CInt(row.Cells("Cantidad").Value)
                        Dim precioUnitario As Decimal = CDec(row.Cells("PrecioUnitario").Value)
                        subtotal += cantidad * precioUnitario
                        ' Llamar a la función para insertar el detalle de la factura
                        Dim detalleMensaje As String = objFactura.InsertardetalleFactura(facturaID, productoId, cantidad, precioUnitario, subtotal)
                    End If
                Next

                ' Insertar la venta en la tabla Ventas
                Dim mensajeVenta As String = objVenta.InsertarVenta(DateTime.Now, totalFactura, Usuario)
                MessageBox.Show($"Detalles de factura insertados correctamente. {mensajeVenta}")
            Else
                MessageBox.Show("No se puede continuar con la compra debido a falta de stock.")
            End If
        Else
            MessageBox.Show("Hubo un problema al insertar la factura.")
        End If
    End Sub

    Private Sub BntQuitar_Click(sender As Object, e As EventArgs) Handles BntQuitar.Click
        ' Verificar si se ha seleccionado una fila
        If DgvProveedores.SelectedRows.Count > 0 Then
            ' Confirmar si realmente se desea eliminar la fila
            Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas quitar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Eliminar la fila seleccionada
                DgvProveedores.Rows.RemoveAt(DgvProveedores.SelectedRows(0).Index)
            End If
        Else
            MessageBox.Show("Por favor, selecciona una fila para eliminar.")
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Function CalcularTotal() As Decimal
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In DgvProveedores.Rows
            If Not row.IsNewRow AndAlso row.Cells("Producto").Value IsNot Nothing Then
                ' Verificar que la cantidad sea válida antes de convertirla
                Dim cantidad As Integer = If(row.Cells("Cantidad").Value IsNot Nothing, CInt(row.Cells("Cantidad").Value), 0)

                ' Verificar que el precio sea válido antes de convertirlo
                Dim precio As Decimal = If(row.Cells("PrecioUnitario").Value IsNot Nothing, Convert.ToDecimal(row.Cells("PrecioUnitario").Value), 0D)

                ' Calcular el total
                total += cantidad * precio
            End If
        Next
        Return total
    End Function
    Private Sub dgvCompra_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DgvProveedores.EditingControlShowing
        If DgvProveedores.CurrentCell.ColumnIndex = DgvProveedores.Columns("Producto").Index Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)

            ' Eliminar cualquier controlador existente para evitar múltiples suscripciones
            RemoveHandler combo.SelectedIndexChanged, AddressOf ComboBox_SelectedIndexChanged
            AddHandler combo.SelectedIndexChanged, AddressOf ComboBox_SelectedIndexChanged
        End If
    End Sub
    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim combo As ComboBox = CType(sender, ComboBox)
        Dim rowIndex As Integer = DgvProveedores.CurrentCell.RowIndex
        Dim productoId As Integer

        ' Verificar si el valor seleccionado es válido
        If Integer.TryParse(combo.SelectedValue?.ToString(), productoId) Then
            ' Obtener el precio del producto desde la base de datos usando el método proporcionado
            Dim precio As Decimal = objFactura.ObtenerPrecioProducto(productoId)
            DgvProveedores.Rows(rowIndex).Cells("PrecioUnitario").Value = precio
        End If
    End Sub
End Class