Public Class SalonModel
    Public Property salon As String
    Public Property id As String

    Public Sub New(ByVal id As String, ByVal salon As String)
        Me.id = id
        Me.salon = salon
    End Sub
End Class
