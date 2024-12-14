Imports ES_Database

Public Class OpcionesPage
    Dim id_profesor = LoginPage.id_profesor
    Dim grupo = AsistenciaClass.VerGrupo(id_profesor)
    Public id_horario, id_grupo, fechatxt As String
    Dim salon As List(Of SalonModel)
    Private Sub OpcionesPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To grupo.Count - 1
            cbogrupo.Items.Add(grupo(i).grupo)
        Next

        cbogrupo.SelectedIndex = 0
    End Sub

    Sub UnirPantallas(ByVal panel As Form)
        PrincipalPage.PanelPrincipal.Controls.Clear()
        panel.TopLevel = False
        PrincipalPage.PanelPrincipal.Controls.Add(panel)

        fechatxt = cbofecha.Text

        panel.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cbofecha.Text = "" Or
                cbogrupo.Text = "" Or
                cbosalon.Text = "" Then
            MsgBox("Debe llenar todos los campos", Nothing, "Error")
        Else
            id_horario = salon(cbosalon.SelectedIndex).id
            UnirPantallas(AsistenciaPage)
        End If
    End Sub

    Private Sub cbogrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbogrupo.SelectedIndexChanged
        cbosalon.Items.Clear()
        cbofecha.Items.Clear()

        id_grupo = grupo(cbogrupo.SelectedIndex).id

        salon = AsistenciaClass.VerSalon(id_profesor, id_grupo)
        Dim fecha = AsistenciaClass.VerFecha(id_profesor, id_grupo)

        For i As Integer = 0 To salon.Count - 1
            cbosalon.Items.Add(salon(i).salon)
        Next

        For i As Integer = 0 To fecha.Count - 1
            cbofecha.Items.Add(fecha(i))
        Next

        cbosalon.SelectedIndex = 0

        'id_horario = salon(cbosalon.SelectedIndex).id

        If fecha.Count - 1 <> -1 Then
            cbofecha.SelectedIndex = 0
        End If
    End Sub
End Class