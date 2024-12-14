Imports System.Text.RegularExpressions

Public Class FrmCategoria
    Dim objCategoria As New clsCategorias
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Validar el campo de Nombre de la Categoría
        Dim txtCategoriaNew As Control = TabControlCategoria.SelectedTab.Controls("txtCategoriaNew")

        If txtCategoriaNew Is Nothing OrElse Not TypeOf txtCategoriaNew Is TextBox Then
            MessageBox.Show("El campo 'Nombre de la categoría' no se encontró. Por favor, verifique la configuración del formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim nombreCategoria As String = CType(txtCategoriaNew, TextBox).Text

        ' Validar que el nombre de la categoría no esté vacío
        If String.IsNullOrWhiteSpace(nombreCategoria) Then
            MessageBox.Show("El nombre de la categoría no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CType(txtCategoriaNew, TextBox).Focus()
            Return
        End If

        ' Validar que el nombre de la categoría no contenga caracteres especiales
        Dim regex As New Regex("^[a-zA-Z0-9 ]+$")
        If Not regex.IsMatch(nombreCategoria) Then
            MessageBox.Show("El nombre de la categoría contiene caracteres no permitidos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CType(txtCategoriaNew, TextBox).Focus()
            Return
        End If

        ' Llamar al método para insertar la categoría
        Dim mensaje As String = String.Empty
        objCategoria.InsertarCategoria(nombreCategoria, mensaje)

        ' Mostrar el mensaje devuelto por el procedimiento almacenado
        MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Limpiar los datos
        LimpiarCampos()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ' Declarar la variable categoriaID
        Dim categoriaID As Integer

        ' Validar el campo ID
        If String.IsNullOrWhiteSpace(txtIdCategoria.Text) Then
            MessageBox.Show("El campo 'ID' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIdCategoria.Focus()
            Return
        End If

        ' Verificar si el ID ingresado es un entero válido
        If Not Integer.TryParse(txtIdCategoria.Text, categoriaID) Then
            MessageBox.Show("El ID de la categoría no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIdCategoria.Focus()
            Return
        End If

        ' Validar el campo Nombre de la Categoría
        Dim nombreCategoria As String = txtNombreCategoria.Text

        If String.IsNullOrWhiteSpace(nombreCategoria) Then
            MessageBox.Show("El nombre de la categoría no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombreCategoria.Focus()
            Return
        End If

        ' Validar que el nombre de la categoría no contenga caracteres especiales
        Dim regex As New Regex("^[a-zA-Z0-9 ]+$")
        If Not regex.IsMatch(nombreCategoria) Then
            MessageBox.Show("El nombre de la categoría contiene caracteres no permitidos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombreCategoria.Focus()
            Return
        End If

        ' Llamar al método para actualizar la categoría
        Dim mensaje As String = String.Empty

        ' Llamar al método para actualizar la categoría y capturar el mensaje
        If objCategoria.ActualizarCategoria(categoriaID, nombreCategoria, mensaje) Then
            ' Mostrar el mensaje devuelto por el procedimiento almacenado
            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Mostrar el mensaje de error devuelto por el procedimiento almacenado
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Limpiar los datos
        LimpiarCampos()
    End Sub
    Private Sub BtnBusqueda_Click(sender As Object, e As EventArgs) Handles BtnBusqueda.Click
        ' Validar el campo de búsqueda
        If String.IsNullOrWhiteSpace(txtBusqueda.Text) Then
            MessageBox.Show("Por favor ingrese un ID válido.", "Error Vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBusqueda.Focus()
            Return
        End If

        ' Intentar convertir el ID de cadena a entero
        Dim categoriaID As Integer
        If Not Integer.TryParse(txtBusqueda.Text, categoriaID) Then
            MessageBox.Show("Por favor ingrese un ID válido.", "Error Tipado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBusqueda.Focus()
            Return
        End If

        ' Llamar a la función para buscar la categoría y llenar el DataGridView
        LlenarDataGridViewPorID(categoriaID)

        'Limpiar los datos
        LimpiarCampos()
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        MostrarTodasLasCategorias()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Validar el campo ID
        If String.IsNullOrWhiteSpace(txtCateElimar.Text) Then
            MessageBox.Show("El campo 'ID' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIdCategoria.Focus()
            Return
        End If

        ' Verificar si el ID ingresado es un entero válido
        Dim categoriaID As Integer
        If Not Integer.TryParse(txtCateElimar.Text, categoriaID) Then
            MessageBox.Show("El ID de la categoría no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIdCategoria.Focus()
            Return
        End If

        ' Llamar al método para eliminar la categoría
        Dim mensaje As String = String.Empty

        If objCategoria.EliminarCategoria(categoriaID, mensaje) Then
            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Actualizar el DataGridView
            ActualizarDataGridView()
        Else
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Limpiar los datos
        LimpiarCampos()
    End Sub


    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
    Private Sub BtnBuscarAct_Click(sender As Object, e As EventArgs) Handles BtnBusAct.Click
        ' Validar el campo de búsqueda
        If String.IsNullOrWhiteSpace(txtCategoriaID.Text) Then
            MessageBox.Show("Por favor ingrese un ID válido.", "Error Vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBusqueda.Focus()
            Return
        End If

        ' Intentar convertir el ID de cadena a entero
        Dim categoriaIDAct As Integer
        If Not Integer.TryParse(txtCategoriaID.Text, categoriaIDAct) Then
            MessageBox.Show("Por favor ingrese un ID válido.", "Error Tipado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBusqueda.Focus()
            Return
        End If

        ' Llamar a la función para rellenar los TextBox con el ID proporcionado
        RellenarTextBoxesPorID(categoriaIDAct)
    End Sub
    Private Sub RellenarTextBoxesPorID(categoriaID As Integer)
        Dim categoria As DataRow = objCategoria.BuscarCategoriaPorID(categoriaID)
        If categoria IsNot Nothing Then
            ' Rellenar los TextBox con los datos validados
            txtIdCategoria.Text = categoria("CategoriaID").ToString()
            txtNombreCategoria.Text = categoria("NombreCategoria").ToString()
        Else
            MessageBox.Show("Categoría no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub LlenarDataGridViewPorID(categoriaID As Integer)
        Dim categoria As DataRow = objCategoria.BuscarCategoriaPorID(categoriaID)
        If categoria IsNot Nothing Then
            ' Crear un DataTable para llenar el DataGridView
            Dim dt As New DataTable()
            dt.Columns.Add("CategoriaID", GetType(Integer))
            dt.Columns.Add("NombreCategoria", GetType(String))

            ' Agregar la fila con los datos obtenidos
            dt.Rows.Add(categoria("CategoriaID"), categoria("NombreCategoria"))

            ' Llenar el DataGridView con el DataTable
            DgbCategorias.DataSource = dt
        Else
            MessageBox.Show("Categoría no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub MostrarTodasLasCategorias()
        Dim categorias As DataTable = objCategoria.SeleccionarCategorias()
        If categorias IsNot Nothing AndAlso categorias.Rows.Count > 0 Then
            DgbCategorias.DataSource = categorias
        Else
            MessageBox.Show("No se encontraron categorías.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ActualizarDataGridView()
        Dim categorias As DataTable = objCategoria.SeleccionarCategorias()
        If categorias IsNot Nothing Then
            DgvCategoriasE.DataSource = categorias
        Else
            MessageBox.Show("No se encontraron categorías.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub LimpiarCampos()
        txtBusqueda.Clear()
        txtCateElimar.Clear()
        txtNombreCategoria.Clear()
        txtCategoriaNew.Clear()
        txtIdCategoria.Clear()
        txtCategoriaID.Clear()
    End Sub
End Class