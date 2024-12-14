Imports ES_Database

Public Class AsistenciaPage
    Dim asistio As New DataGridViewImageColumn
    Dim asistencia As List(Of AsistenciaModel)
    Private Sub AsistenciaPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Asistenciadgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        salon.Text = "SALON: " + OpcionesPage.cbogrupo.Text
        Dim id_horario = OpcionesPage.id_horario
        Dim id_grupo = OpcionesPage.id_grupo
        Dim id_profesor = LoginPage.id_profesor
        Dim fecha = OpcionesPage.fechatxt

        asistencia = AsistenciaClass.ListaAsistencia(id_horario, id_grupo, fecha, id_profesor)

        Dim imagen As Image = Nothing

        For i As Integer = 0 To asistencia.Count - 1
            If asistencia(i).asistencia = "asistio.png" Then
                imagen = My.Resources.asistio
            ElseIf asistencia(i).asistencia = "falto.png" Then
                imagen = My.Resources.falto
            ElseIf asistencia(i).asistencia = "tardanza.png" Then
                imagen = My.Resources.tardanza
            End If

            Asistenciadgv.Rows.Add(asistencia(i).nombre, asistencia(i).apellido, asistencia(i).correo,
            asistencia(i).cedula, asistencia(i).porcentaje, imagen,
            asistencia(i).observaciones, "Guardar cambios")
        Next
    End Sub

    Private Sub Asistenciadgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Asistenciadgv.CellContentClick
        Dim observacion As String
        Dim id_asist As String
        If e.ColumnIndex = 7 Then
            id_asist = asistencia(e.RowIndex).id.ToString()
            observacion = Asistenciadgv.CurrentRow.Cells(6).Value

            Dim asist = AsistenciaClass.GuardarObservaciones(observacion, id_asist)
            MsgBox(asist, Nothing, "Exito")
        End If
    End Sub
End Class