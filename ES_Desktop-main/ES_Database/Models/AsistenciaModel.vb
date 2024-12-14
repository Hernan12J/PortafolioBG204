Public Class AsistenciaModel
    Public Sub New(ByVal id As String, ByVal nombre As String,
                   ByVal apellido As String,
                   ByVal correo As String, ByVal cedula As String,
                   ByVal asistencia As String, ByVal porcentaje As String,
                   ByVal observaciones As String)
        Me.id = id
        Me.nombre = nombre
        Me.apellido = apellido
        Me.correo = correo
        Me.cedula = cedula
        Me.asistencia = asistencia
        Me.porcentaje = porcentaje
        Me.observaciones = observaciones
    End Sub

    Public Property id As String
    Public Property nombre As String
    Public Property apellido As String
    Public Property correo As String
    Public Property cedula As String
    Public Property asistencia As String
    Public Property porcentaje As String
    Public Property observaciones As String

    
End Class
