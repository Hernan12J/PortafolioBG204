Public Class FrmRecuperacion
    Private Sub FrmRecuperacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        MessageBox.Show("Se envio la solicitud de cambio de contraseña.", "Cambio Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Hide()
        FrmPrincipal.Show()
    End Sub
End Class