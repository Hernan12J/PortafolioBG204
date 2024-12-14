Public Class EquiposModel
    Public Property equipo As String
    Public Property id As String

    Public Sub New(ByVal id As String, ByVal equipo As String)
        Me.id = id
        Me.equipo = equipo
    End Sub
End Class
