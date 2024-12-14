Public Class FrmRoles
    Dim objRoles As New clsRoles
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnRegistrarse_Click(sender As Object, e As EventArgs) Handles BtnRegistrarse.Click
        ' Obtener el valor del campo
        Dim nombreRol As String = txtNombreRol.Text

        ' Llamar a la función para crear el rol
        Dim mensaje As String = String.Empty
        If objRoles.CrearRol(nombreRol, mensaje) Then
            MessageBox.Show(mensaje, "Crear Rol", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Limpiar el campo
        txtNombreRol.Clear()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If DgvRoles.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar un registro para modificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener los valores de los campos
        Dim rolID As Integer = Integer.Parse(txtRolID.Text)
        Dim nombreRol As String = txtNombreRol.Text

        ' Llamar a la función para actualizar el rol
        Dim mensaje As String = String.Empty
        If objRoles.ActualizarRol(rolID, nombreRol, mensaje) Then
            MessageBox.Show(mensaje, "Actualizar Rol", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Limpiar el campo
        txtNombreRol.Clear()
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        ' Obtener los datos de los roles
        Dim dt As DataTable = objRoles.LeerRoles()
        'Mostrar los datos en el DataGridView
        DgvRoles.DataSource = dt
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If DgvRoles.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar un registro para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener el ID del rol a eliminar
        Dim rolID As Integer = Integer.Parse(txtRolID.Text)

        ' Mostrar mensaje de confirmación
        Dim confirmResult As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            ' Llamar a la función para eliminar el rol
            Dim mensaje As String = String.Empty
            If objRoles.EliminarRol(rolID, mensaje) Then
                MessageBox.Show(mensaje, "Eliminar Rol", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Limpiar el campo
            txtNombreRol.Clear()
        Else
            ' Cancelar la operación de eliminación
            MessageBox.Show("Operación cancelada.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function ValidarCampos() As Boolean
        ' Verificar si alguno de los TextBox está vacío
        If String.IsNullOrWhiteSpace(txtNombreRol.Text) Then
            MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombreRol.Focus()
            Return False
        End If
        ' Si todas las validaciones pasan
        Return True
    End Function

    Private Sub dgvRoles_SelectionChanged(sender As Object, e As EventArgs) Handles DgvRoles.SelectionChanged
        If DgvRoles.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DgvRoles.SelectedRows(0)
            txtRolID.Text = selectedRow.Cells("RolID").Value.ToString()
            txtNombreRol.Text = selectedRow.Cells("NombreRol").Value.ToString()
        End If
    End Sub
End Class