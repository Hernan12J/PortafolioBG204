Imports ES_Database

Public Class PerfilPage
    'RECIBO EL ID DE LA PAGINA DE LOGIN'
    Dim id_profesor = LoginPage.id_profesor

    Private Sub PerfilPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RECIBO UNA LISTA CON TODOS LOS DATOS DEL USUARIO'
        Dim ListaData = PerfilClass.DatosUserPerfil(id_profesor)

        'USO LA LISTA PARA ASIGAR LOS DATOS A LOS TXT'
        txtced.Text = ListaData(1)
        txtnom.Text = ListaData(2)
        txtape.Text = ListaData(3)
        txtfacu.Text = ListaData(4)
        txtdirec.Text = ListaData(5)
        txttel.Text = ListaData(6)
        txtcorreo.Text = ListaData(7)
    End Sub

    Private Sub UpdatePerfil_Click(sender As Object, e As EventArgs) Handles UpdatePerfil.Click

        If txtnom.Text = "" Then
            MsgBox("El campo nombre esta vacio", Nothing, "Error")
        ElseIf txtape.Text = "" Then
            MsgBox("El campo apellido esta vacio", Nothing, "Error")
        ElseIf txtfacu.Text = "" Then
            MsgBox("El campo facultad esta vacio", Nothing, "Error")
        ElseIf txtdirec.Text = "" Then
            MsgBox("El campo direccion esta vacio", Nothing, "Error")
        ElseIf txttel.Text = "" Then
            MsgBox("El campo telefono esta vacio", Nothing, "Error")
        Else
            PerfilClass.ActualizarDatos(id_profesor, txtced.Text, txtnom.Text, txtape.Text, txtfacu.Text, txtdirec.Text, txttel.Text, txtcorreo.Text)
            MsgBox("Los datos fueron actualizados", Nothing, "Actualizado")


            Dim usuario = LoginClass.DatosProfesor(id_profesor)
            'ASIGNO EL NOMBRE DE USUARIO AL HEADER'
            PrincipalPage.nombre.Text = usuario
            'ASIGNO EL NOMBRE DE USUARIO A LA PANTALLA BIENVENIDA'
            BienvenidoPage.bienvenidauser.Text = "Bienvenido " + usuario
        End If

    End Sub

    Private Sub UpdatePass_Click(sender As Object, e As EventArgs) Handles UpdatePass.Click

        If txtpass.Text = "" Then
            MsgBox("El campo contraseña actual esta vacio", Nothing, "Error")
        ElseIf txtpassnew.Text = "" Then
            MsgBox("El campo contraseña nueva esta vacio", Nothing, "Error")
        ElseIf txtpassnew2.Text = "" Then
            MsgBox("El campo repetir contraseña nueva esta vacio", Nothing, "Error")
        Else
            If txtpassnew.Text = txtpassnew2.Text Then
                If PerfilClass.ValidarContraseña(txtpass.Text, id_profesor) = True Then
                    PerfilClass.ActualizarPass(id_profesor, txtpassnew2.Text)
                    MsgBox("La contraseña fue modificada correctamente", Nothing, "Correcto")

                    txtpass.Text = ""
                    txtpassnew.Text = ""
                    txtpassnew2.Text = ""
                Else
                    MsgBox("La contraseña actual es incorrecta", Nothing, "Verificar")
                End If
            Else
                MsgBox("Las contraseña nueva no coiniciden", Nothing, "Verificar")
            End If
        End If
    End Sub
End Class