Public Class FrmPrincipal
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Dim objLogin As New clsLogin

        If Not ValidarCampos() Then
            Return
        End If

        Dim userName As String = txtUser.Text
        Dim password As String = txtPassword.Text
        Dim rol As String = objLogin.ValidarCredenciales(userName, password)

        Select Case rol
            Case "Admin"
                Dim formAdmin As New FrmAdmin()
                formAdmin.Show()
                Me.Hide()
            Case "Cliente"
                Dim formCliente As New FrmUser(userName)
                formCliente.Show()
                Me.Hide()
            Case "NoExiste"
                MessageBox.Show("El usuario no existe. Por favor, regístrese.", "Usuario no registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case Else
                MessageBox.Show("Contactar a la administración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
        'Limpiar Campos
        LimpiarCampos()
    End Sub


    Private Function ValidarCampos() As Boolean
        ' Verificar si alguno de los TextBox está vacío
        If String.IsNullOrWhiteSpace(txtUser.Text) Then
            MessageBox.Show("El campo Usuario es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUser.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("El campo Contraseña es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return False
        End If

        ' Validar longitud de la contraseña
        Dim password As String = txtPassword.Text
        If password.Length < 8 OrElse password.Length > 13 Then
            MessageBox.Show("La contraseña debe tener entre 8 y 13 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return False
        End If

        ' Validar caracteres especiales permitidos
        Dim permitido As String = "_*-.abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        If Not password.All(Function(c) permitido.Contains(c)) Then
            MessageBox.Show("La contraseña contiene caracteres no permitidos. Solo se permiten: _*-.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return False
        End If

        ' Validar que tenga al menos una letra mayúscula
        If Not password.Any(AddressOf Char.IsUpper) Then
            MessageBox.Show("La contraseña debe contener al menos una letra mayúscula.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return False
        End If

        ' Validar que tenga al menos un número
        If Not password.Any(AddressOf Char.IsDigit) Then
            MessageBox.Show("La contraseña debe contener al menos un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return False
        End If

        ' Si todas las validaciones pasan
        Return True
    End Function

    Private Sub LimpiarCampos()
        txtUser.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub LinkCrear_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkCrear.LinkClicked
        FrmCreateUser.Show()
        Me.Hide()
    End Sub

    Private Sub LinkPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkPass.LinkClicked
        FrmRecuperacion.Show()
        Me.Hide()
    End Sub
End Class
