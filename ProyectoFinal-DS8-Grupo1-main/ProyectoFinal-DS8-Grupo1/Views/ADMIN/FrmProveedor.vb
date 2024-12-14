Public Class FrmProveedor
    Dim objProveedor As New clsProveedores
    Private Sub FrmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombre.Visible = False
        txtNombre.Visible = False
        lblTelefono.Visible = False
        txtTelefono.Visible = False
        lblID.Visible = False
        txtID.Visible = False

        BtnCancelar.Enabled = False
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = False
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim proveedorID As Integer
        If Integer.TryParse(txtBusqueda.Text, proveedorID) Then
            Dim proveedor As DataRow = objProveedor.BuscarCategoriaPorID(proveedorID)
            If proveedor IsNot Nothing Then
                Dim table As New DataTable()
                table.ImportRow(proveedor)
                DgvProveedores.DataSource = table

                ' Habilitar y mostrar controles
                lblNombre.Visible = True
                lblTelefono.Visible = True
                txtNombre.Text = proveedor("NombreProveedor").ToString()
                txtTelefono.Text = proveedor("Telefono").ToString()
                txtID.Text = proveedor("ProveedorID").ToString()
                txtNombre.Visible = True
                txtID.Visible = True
                txtID.Enabled = False
                txtTelefono.Visible = True
                BtnGuardar.Enabled = True
                BtnCancelar.Enabled = True
                BtnEliminar.Enabled = True

                ' Habilitar el evento de selección del DataGridView
                AddHandler DgvProveedores.SelectionChanged, AddressOf DataGridViewProveedores_SelectionChanged
            Else
                MessageBox.Show("Proveedor no encontrado.")
                DgvProveedores.DataSource = Nothing
            End If
        Else
            MessageBox.Show("Por favor, ingrese un ID de proveedor válido.")
        End If
    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        DgvProveedores.DataSource = Nothing
        DgvProveedores.Columns.Clear()


        lblNombre.Visible = True
        txtNombre.Visible = True
        lblTelefono.Visible = True
        txtTelefono.Visible = True
        lblID.Visible = True
        txtID.Visible = True

        txtBusqueda.Enabled = False
        BtnBuscar.Enabled = False

        BtnCancelar.Enabled = True
        BtnEliminar.Enabled = True
        BtnGuardar.Enabled = True
        BtnNuevo.Enabled = False
        txtID.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim mensaje As String = ""

        ' Validar que los campos obligatorios no estén vacíos
        If String.IsNullOrEmpty(txtNombre.Text) OrElse String.IsNullOrWhiteSpace(txtTelefono.Text) Then
            MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim proveedorID As Integer
        If Integer.TryParse(txtID.Text, proveedorID) AndAlso proveedorID > 0 Then
            ' Actualizar proveedor existente
            objProveedor.ActualizarProveedor(proveedorID, txtNombre.Text, txtTelefono.Text, mensaje)

            If mensaje.Contains("actualizado correctamente") Then
                MessageBox.Show("¡Registro actualizado exitosamente!", "Actualización BD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf mensaje.Contains("existe") Then
                MessageBox.Show(mensaje, "Error de duplicados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Ocurrió un error al actualizar: " & mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' Insertar nuevo proveedor
            objProveedor.InsertarProveedor(txtNombre.Text, txtTelefono.Text, mensaje)

            If mensaje.Contains("insertado correctamente") Then
                MessageBox.Show("¡Registro exitoso!", "Registro BD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf mensaje.Contains("existe") Then
                MessageBox.Show(mensaje, "Error de duplicados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Ocurrió un error al insertar: " & mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        ' Refrescar DataGridView después de guardar
        DgvProveedores.DataSource = objProveedor.MostrarProveedores()

        ' Limpiar campos y deshabilitar controles
        LimpiarCampos()

        BtnCancelar.Enabled = False
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True

        lblNombre.Visible = False
        txtNombre.Visible = False
        lblTelefono.Visible = False
        txtTelefono.Visible = False
        lblID.Visible = False
        txtID.Visible = False
        txtBusqueda.Enabled = True
        BtnBuscar.Enabled = True
    End Sub



    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        lblNombre.Visible = False
        txtNombre.Visible = False
        lblTelefono.Visible = False
        txtTelefono.Visible = False
        lblID.Visible = False
        txtID.Visible = False

        txtBusqueda.Enabled = True
        BtnBuscar.Enabled = True

        LimpiarCampos()

        BtnCancelar.Enabled = False
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Validar que los campos obligatorios no estén vacíos
        If String.IsNullOrEmpty(txtNombre.Text) OrElse String.IsNullOrWhiteSpace(txtTelefono.Text) Then
            MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf String.IsNullOrWhiteSpace(txtTelefono.Text) Then
            MessageBox.Show("El campo Apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTelefono.Focus()
            Return
        End If

        ' Mostrar mensaje de confirmación
        Dim confirmResult As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            ' Proceder con la eliminación del registro
            Dim mensaje As String = String.Empty
            Dim proveedorID As Integer = Integer.Parse(txtID.Text) ' Asegúrate de capturar el ID del proveedor adecuadamente
            Dim resultado As String = objProveedor.EliminarProveedor(proveedorID, mensaje)

            If mensaje.StartsWith("Error") Then
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Registro eliminado. " & mensaje, "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ' Cancelar la operación de eliminación
            MessageBox.Show("Operación cancelada.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Refrescar DataGridView después de guardar
        DgvProveedores.DataSource = objProveedor.MostrarProveedores()
        'Limpia Los diferentes controles
        LimpiarCampos()

        BtnCancelar.Enabled = False
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True

        lblNombre.Visible = False
        txtNombre.Visible = False
        lblTelefono.Visible = False
        txtTelefono.Visible = False
        lblID.Visible = False
        txtID.Visible = False
    End Sub


    Private Sub DataGridViewProveedores_SelectionChanged(sender As Object, e As EventArgs) Handles DgvProveedores.SelectionChanged
        If DgvProveedores.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DgvProveedores.SelectedRows(0)
            txtID.Text = selectedRow.Cells("ProveedorID").Value.ToString()
            txtNombre.Text = selectedRow.Cells("NombreProveedor").Value.ToString()
            txtTelefono.Text = selectedRow.Cells("Telefono").Value.ToString()
        End If
    End Sub
    Private Sub LimpiarCampos()
        txtID.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtBusqueda.Text = ""
    End Sub
End Class