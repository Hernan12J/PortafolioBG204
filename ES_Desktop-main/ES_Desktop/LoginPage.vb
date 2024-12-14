Imports System.Diagnostics.Eventing.Reader
Imports System.Security.Cryptography.X509Certificates
Imports ES_Database

Public Class LoginPage

    Public id_profesor As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LoginClass.ValidarUsuario(txtcorreo.Text, txtpass.Text) Then
            Me.Hide()
            'RECIBO EL ID DEL PROFESOR DE ESTE METODO'
            id_profesor = LoginClass.VerID(txtcorreo.Text, txtpass.Text)
            PrincipalPage.Show()
        Else
            MsgBox("El usuario y contraseña son incorrectos", Nothing, "Error")
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        RecuperarPage.Show()
    End Sub
End Class
