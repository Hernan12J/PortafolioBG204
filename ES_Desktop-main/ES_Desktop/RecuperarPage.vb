Public Class RecuperarPage
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        LoginPage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If correotxt.Text = "" Then
            MsgBox("Debe llenar todos los campos", Nothing, "Error")
        Else
            MsgBox("Correo electronico de recuperacion enviado", Nothing, "Bien")
        End If
    End Sub
End Class