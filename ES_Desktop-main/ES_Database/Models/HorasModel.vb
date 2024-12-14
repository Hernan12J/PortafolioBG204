Public Class HorasModel
    Public Property hora_entrada As String
    Public Property hora_salida As String

    Public Sub New(ByVal hora_entrada As String, ByVal hora_salida As String)
        Me.hora_entrada = hora_entrada
        Me.hora_salida = hora_salida
    End Sub
End Class
