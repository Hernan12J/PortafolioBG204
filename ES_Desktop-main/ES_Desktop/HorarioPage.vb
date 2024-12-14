Imports ES_Database

Public Class HorarioPage
    Private Sub HorarioPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id_profesor = LoginPage.id_profesor

        Horariodgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        Dim hora = HorarioClass.ObtenerHoras(id_profesor)
        Dim lunes = HorarioClass.ObtenerLunes(id_profesor)
        Dim martes = HorarioClass.ObtenerMartes(id_profesor)
        Dim miercoles = HorarioClass.ObtenerMiercoles(id_profesor)
        Dim jueves = HorarioClass.ObtenerJueves(id_profesor)
        Dim viernes = HorarioClass.ObtenerViernes(id_profesor)
        Dim sabado = HorarioClass.ObtenerSabado(id_profesor)

        For i As Integer = 0 To hora.Count - 1
            Horariodgv.Rows.Add(hora(i).hora_entrada + "-" + hora(i).hora_salida,
                                lunes(i), martes(i), miercoles(i), jueves(i),
                                viernes(i), sabado(i))
        Next

    End Sub
End Class