Public Class GrupoModel
    Public Property grupo As String
    Public Property id As String

    Public Sub New(ByVal id As String, ByVal grupo As String)
        Me.id = id
        Me.grupo = grupo
    End Sub
End Class
