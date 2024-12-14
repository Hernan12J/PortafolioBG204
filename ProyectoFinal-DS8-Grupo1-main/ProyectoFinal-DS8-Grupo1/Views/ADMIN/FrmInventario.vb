Public Class FrmInventario
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim objConsulta As New clsInventario
        Dim mensaje As String

        ' Limpiar espacios en blanco
        txtNombreProducto.Text = txtNombreProducto.Text.Trim()
        txtPrecio.Text = txtPrecio.Text.Trim()
        txtStock.Text = txtStock.Text.Trim()
        txtDescripcion.Text = txtDescripcion.Text.Trim()

        If Not ValidarCampos() Then
            Return
        End If

        Dim categoriaID As Integer = CInt(cbxCategoria.SelectedValue)
        Dim proveedorID As Integer = CInt(cbxProveedor.SelectedValue)
        Dim fechaIngreso As Date = dtpIngreso.Value

        ' Verificar si ya existe un proveedor con los mismos datos
        If Not objConsulta.ValidarInsercionProducto(txtNombreProducto.Text, txtPrecio.Text, proveedorID) Then
            Return
        End If

        mensaje = objConsulta.InsertarProducto(txtNombreProducto.Text, txtDescripcion.Text, txtPrecio.Text, txtStock.Text, fechaIngreso, categoriaID, proveedorID)
        MessageBox.Show(mensaje)

        ' Limpiar los campos
        LimpiarCampos()
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim objConsulta As New clsInventario
        Dim mensaje As String
        txtProductoID.Visible = True
        txtProductoID.Enabled = False

        ' Validar los datos ingresados
        If String.IsNullOrWhiteSpace(txtProductoID.Text) Then
            MessageBox.Show("Seleccione un producto para modificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Limpiar espacios en blanco
        txtNombreProducto.Text = txtNombreProducto.Text.Trim()
        txtDescripcion.Text = txtDescripcion.Text.Trim()
        txtPrecio.Text = txtPrecio.Text.Trim()
        txtStock.Text = txtStock.Text.Trim()

        If Not ValidarCampos() Then
            Return
        End If

        Dim productoId As Integer = CInt(txtProductoID.Text)
        Dim nombreProducto As String = txtNombreProducto.Text
        Dim descripcion As String = txtDescripcion.Text
        Dim precio As Decimal = Convert.ToDecimal(txtPrecio.Text)
        Dim Stock As Integer = CInt(txtStock.Text)
        Dim fechaIngreso As Date = dtpIngreso.Value
        Dim categoriaID As Integer = CInt(cbxCategoria.SelectedValue)
        Dim proveedorID As Integer = CInt(cbxProveedor.SelectedValue)


        ' Verificar si ya existe un producto con los mismos datos
        If Not objConsulta.ValidarActualizacionProducto(productoId, nombreProducto, precio, proveedorID) Then
            Return
        End If

        mensaje = objConsulta.ActualizarProducto(productoId, nombreProducto, descripcion, precio, Stock, fechaIngreso, proveedorID, categoriaID)
        MessageBox.Show(mensaje)

        ' Actualiza el DataGridView
        leerInventario()

        ' Limpiar los campos
        LimpiarCampos()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim objConsulta As New clsInventario
        Dim mensaje As String

        ' Verificar que un producto haya sido seleccionado
        If dgvInventario.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un producto para eliminar.")
            Return
        End If

        ' Obtener el ProductoID desde el DataGridView o el control donde se muestre la lista de productos
        Dim productoID As Integer = CInt(dgvInventario.SelectedRows(0).Cells("ProductoID").Value)

        ' Confirmar la eliminación
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' Llamar al método de la clase clsInventario para eliminar el producto
            mensaje = objConsulta.EliminarProducto(productoID)
            MessageBox.Show(mensaje)
        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim objConsulta As New clsInventario
        Dim table As New DataTable
        table = objConsulta.LeerProductos()

        dgvInventario.DataSource = table
    End Sub

    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboBoxProveedores()
        LlenarComboBoxCategorias()

        dtpIngreso.Format = DateTimePickerFormat.Custom
        dtpIngreso.CustomFormat = "dd/MM/yyyy" ' Formato de fecha
        dtpIngreso.Value = DateTime.Now ' Establecer la fecha actual
        dtpIngreso.ShowUpDown = True
    End Sub
    Private Sub LlenarComboBoxProveedores()
        Dim objProductos As New clsInventario
        Dim tblProveedor As New DataTable

        tblProveedor = objProductos.ObtenerProveedores()
        cbxProveedor.DataSource = tblProveedor
        cbxProveedor.DisplayMember = "NombreProveedor"
        cbxProveedor.ValueMember = "ProveedorID"
    End Sub

    Private Sub LlenarComboBoxCategorias()
        Dim objCategoria As New clsInventario
        Dim tblCategorias As New DataTable

        tblCategorias = objCategoria.ObtenerCategorias()
        cbxCategoria.DataSource = tblCategorias
        cbxCategoria.ValueMember = "CategoriaID"
        cbxCategoria.DisplayMember = "NombreCategoria"
    End Sub
    Private Sub LimpiarCampos()
        txtProductoID.Clear()
        txtNombreProducto.Clear()
        txtDescripcion.Clear()
        txtPrecio.Clear()
        txtStock.Clear()
        cbxCategoria.SelectedIndex = -1
        cbxProveedor.SelectedIndex = -1
        dtpIngreso.Value = DateTime.Now
    End Sub

    Private Function ValidarCampos() As Boolean
        ' Verificar si alguno de los TextBox está vacío
        If String.IsNullOrWhiteSpace(txtNombreProducto.Text) Then
            MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombreProducto.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtPrecio.Text) Then
            MessageBox.Show("El campo Precio del Profesor es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrecio.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtStock.Text) Then
            MessageBox.Show("El campo Stock del Profesor es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStock.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtDescripcion.Text) Then
            MessageBox.Show("El campo Descripcion es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDescripcion.Focus()
            Return False
        ElseIf cbxCategoria.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una categoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbxCategoria.Focus()
            Return False
        ElseIf cbxProveedor.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbxProveedor.Focus()
            Return False
        End If

        ' Si todos los campos tienen datos válidos
        Return True
    End Function

    Public Sub leerInventario()
        Dim objConsulta As New clsInventario
        Dim table As New DataTable
        table = objConsulta.LeerProductos()

        dgvInventario.DataSource = table
    End Sub

    Private Sub dgvInventario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventario.CellClick
        ' Verificar que se ha hecho clic en una fila válida
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Obtener la fila seleccionada
            Dim row As DataGridViewRow = dgvInventario.Rows(e.RowIndex)

            ' Cargar los datos de la fila seleccionada en los TextBoxes
            txtProductoID.Text = row.Cells("ProductoID").Value.ToString()
            txtNombreProducto.Text = row.Cells("NombreProducto").Value.ToString()
            txtDescripcion.Text = row.Cells("descripcion").Value.ToString()
            txtPrecio.Text = row.Cells("PrecioUnitario").Value.ToString()
            txtStock.Text = row.Cells("Stock").Value.ToString()
            dtpIngreso.Value = DateTime.Parse(row.Cells("FechaIngreso").Value.ToString())
            cbxCategoria.SelectedValue = row.Cells("CategoriaID").Value
            cbxProveedor.SelectedValue = row.Cells("ProveedorID").Value
        End If
    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class