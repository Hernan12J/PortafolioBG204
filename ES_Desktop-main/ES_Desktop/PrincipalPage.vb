Imports ES_Database

Public Class PrincipalPage

    Sub UnirPantallas(ByVal panel As Form)
        PanelPrincipal.Controls.Clear()
        panel.TopLevel = False
        PanelPrincipal.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub perfilbutton_Click(sender As Object, e As EventArgs) Handles perfilbutton.Click
        UnirPantallas(PerfilPage)
    End Sub

    Private Sub PrincipalPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RECIBO EL ID DE LA PAGINA DE LOGIN'
        Dim id_profesor = LoginPage.id_profesor
        'RECIBO EL NOMBRE Y APELLIDO DEL USUARIO'
        Dim usuario = LoginClass.DatosProfesor(id_profesor)
        'ASIGNO EL NOMBRE DE USUARIO AL HEADER'
        nombre.Text = usuario
        'ASIGNO EL NOMBRE DE USUARIO A LA PANTALLA BIENVENIDA'
        BienvenidoPage.bienvenidauser.Text = "Bienvenido " + usuario
        UnirPantallas(BienvenidoPage)
    End Sub

    Private Sub principalbutton_Click(sender As Object, e As EventArgs) Handles principalbutton.Click
        UnirPantallas(BienvenidoPage)
    End Sub

    Private Sub asistenciabutton_Click(sender As Object, e As EventArgs) Handles asistenciabutton.Click
        AsistenciaPage.Close()

        UnirPantallas(OpcionesPage)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UnirPantallas(HorarioPage)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UnirPantallas(SolicitudPage)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        AsistenciaPage.Close()
        BienvenidoPage.Close()
        HorarioPage.Close()
        OpcionesPage.Close()
        PerfilPage.Close()
        SolicitudPage.Close()

        LoginPage.Show()

    End Sub
End Class