Imports System.Text.RegularExpressions

Public Class FrmCreateUser
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BntRegistrar_Click(sender As Object, e As EventArgs) Handles BntRegistrar.Click
        Dim objCliente As New clsCreateUser
        Dim mensaje As String

        If Not ValidarCampos() Then
            Return
        End If

        ' Validar formato del correo electrónico
        If Not EsCorreoValido(txtCorreo.Text) Then
            MessageBox.Show("El formato del correo electrónico no es válido.")
            Return
        End If

        ' Verificar si ya existe un cliente con el mismo nombre de usuario
        If objCliente.ValidarUsername(txtUserName.Text) Then
            MessageBox.Show("El nombre de usuario ya existe. Por favor, elige otro.")
            Return
        End If

        ' Verificar si ya existe un cliente con los mismos datos (nombre, apellido, correo, teléfono)
        If objCliente.ValidarInsercionCliente(txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text) Then
            MessageBox.Show("Ya existe un cliente con los mismos datos.")
            Return
        End If

        ' Insertar el cliente
        mensaje = objCliente.InsertarCliente(txtUserName.Text, txtPass.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text, txtDireccion.Text)
        MessageBox.Show(mensaje, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Limpiar los campos
        LimpiarCampos()

        ' Si la inserción fue exitosa, redirigir a la página principal
        If mensaje = "Registro Exitoso" Then
            Me.Hide()
            Dim mainForm As New FrmPrincipal()
            mainForm.Show()
        End If
    End Sub

    Private Function ValidarCampos() As Boolean
        ' Verificar si alguno de los TextBox está vacío
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtApellido.Text) Then
            MessageBox.Show("El campo Apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtApellido.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtTelefono.Text) Then
            MessageBox.Show("El campo Telefono es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTelefono.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtDireccion.Text) Then
            MessageBox.Show("El campo Direccion es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDireccion.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtUserName.Text) Then
            MessageBox.Show("El campo UserName es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserName.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtPass.Text) Then
            MessageBox.Show("El campo Contraseña es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Focus()
            Return False
        End If

        ' Validar longitud de la contraseña
        Dim password As String = txtPass.Text
        If password.Length < 8 OrElse password.Length > 13 Then
            MessageBox.Show("La contraseña debe tener entre 8 y 13 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Focus()
            Return False
        End If

        ' Validar caracteres especiales permitidos
        Dim permitido As String = "_*-.abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        If Not password.All(Function(c) permitido.Contains(c)) Then
            MessageBox.Show("La contraseña contiene caracteres no permitidos. Solo se permiten: _*-.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Focus()
            Return False
        End If

        ' Validar que tenga al menos una letra mayúscula
        If Not password.Any(AddressOf Char.IsUpper) Then
            MessageBox.Show("La contraseña debe contener al menos una letra mayúscula.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Focus()
            Return False
        End If

        ' Validar que tenga al menos un número
        If Not password.Any(AddressOf Char.IsDigit) Then
            MessageBox.Show("La contraseña debe contener al menos un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Focus()
            Return False
        End If

        ' Si todas las validaciones pasan
        Return True
    End Function

    Public Function EsCorreoValido(correo As String) As Boolean
        Dim regex As New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Return regex.IsMatch(correo)
    End Function

    Private Sub LimpiarCampos()
        txtUserName.Clear()
        txtPass.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCorreo.Clear()
        txtDireccion.Clear()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub
End Class