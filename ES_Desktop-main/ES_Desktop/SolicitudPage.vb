Imports ES_Database

Public Class SolicitudPage
    Public cant As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id_profesor = LoginPage.id_profesor
        Dim id_inventario As Integer

        If cboequipo.Text = "" Or
                textcantidad.Text = "" Or
                cbosalon.Text = "" Then
            MsgBox("ERROR: Debe llenar todos los campos", Nothing, "Error")
        Else
            If SolicitudesClass.ValidarSolicitud(textcantidad.Text, cboequipo.Text) = True Then
                id_inventario = SolicitudesClass.VerProducto(cboequipo.Text)
                SolicitudesClass.InsertarSolicitud(id_profesor, id_inventario, cboequipo.Text, textcantidad.Text, cbosalon.Text)
                MsgBox("La solicitud fue enviada correctamente", Nothing, "Excelente")
            Else
                MsgBox("la cantidad es insuficiente en el inventario", Nothing, "Verificar cantidad")
            End If
        End If
    End Sub

    Private Sub SolicitudPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id_profesor = LoginPage.id_profesor

        For Each salon As String In SolicitudesClass.VerSalon(id_profesor)
            cbosalon.Items.Add(salon)
        Next

        Dim lista = SolicitudesClass.VerEquipo()

        For i As Integer = 0 To lista.Count - 1
            cboequipo.Items.Add(lista(i).equipo)
        Next

        cbosalon.SelectedIndex = 0
        cboequipo.SelectedIndex = 0

    End Sub
End Class