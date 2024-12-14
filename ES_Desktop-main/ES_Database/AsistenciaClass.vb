Imports MySql.Data.MySqlClient
Imports System.Data

Public Class AsistenciaClass
    Public Shared Function VerGrupo(id_profesor As String) As List(Of GrupoModel)
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String
        Dim grupo As New List(Of GrupoModel)
        Dim i As Integer


        'TRY CATCH PARA VALIDAR CONEXION Y CONSULTAS'
        Try
            'SE REALIZA LA CONEXION CON LA BASE DE DATOS'
            myConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=;" _
            & "database=asistenciautp"

            oConexion.ConnectionString = myConnectionString

            'HACEMOS EL SELECT PARA OBTENER LA CANTIDAD DEL INVENTARIO'

            sSql = "SELECT * FROM grupos where id_profesor='" & id_profesor & "'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "grupos")

            For i = 0 To oDataSet.Tables("grupos").Rows.Count - 1 Step 1
                grupo.Add(New GrupoModel(oDataSet.Tables("grupos").Rows(i).Item("id"), oDataSet.Tables("grupos").Rows(i).Item("grupo")))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return grupo
    End Function

    Public Shared Function VerSalon(id_profesor As String, id_grupo As String) As List(Of SalonModel)
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String
        Dim salon As New List(Of SalonModel)
        Dim i As Integer


        'TRY CATCH PARA VALIDAR CONEXION Y CONSULTAS'
        Try
            'SE REALIZA LA CONEXION CON LA BASE DE DATOS'
            myConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=;" _
            & "database=asistenciautp"

            oConexion.ConnectionString = myConnectionString

            'HACEMOS EL SELECT PARA OBTENER LA CANTIDAD DEL INVENTARIO'

            sSql = "SELECT DISTINCT h.id as 'id_horario', h.salon, h.id_grupo as 'id_grupo', h.hora_entrada, h.dia FROM horario as h
            join grupos as g WHERE h.id_profesor= '" & id_profesor & "' and h.salon != '-' and h.id_grupo = '" & id_grupo & "' group by h.dia ASC"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "horario")

            For i = 0 To oDataSet.Tables("horario").Rows.Count - 1 Step 1
                salon.Add(New SalonModel(oDataSet.Tables("horario").Rows(i).Item("id_horario"), oDataSet.Tables("horario").Rows(i).Item("salon") + " - " + oDataSet.Tables("horario").Rows(i).Item("hora_entrada") + " - " + oDataSet.Tables("horario").Rows(i).Item("dia")))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return salon
    End Function

    Public Shared Function VerFecha(id_profesor As String, id_grupo As String) As List(Of String)
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String
        Dim fecha As New List(Of String)
        Dim i As Integer


        'TRY CATCH PARA VALIDAR CONEXION Y CONSULTAS'
        Try
            'SE REALIZA LA CONEXION CON LA BASE DE DATOS'
            myConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=;" _
            & "database=asistenciautp"

            oConexion.ConnectionString = myConnectionString

            'HACEMOS EL SELECT PARA OBTENER LA CANTIDAD DEL INVENTARIO'

            sSql = "SELECT distinct date(create_at) as 'create_at' from lista_asist WHERE id_profesor = '" & id_profesor & "' and id_grupo = '" & id_grupo & "' ORDER BY date(create_at) DESC"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "lista_asist")

            For i = 0 To oDataSet.Tables("lista_asist").Rows.Count - 1 Step 1
                fecha.Add(Format(oDataSet.Tables("lista_asist").Rows(i).Item("create_at"), "yyyy-MM-dd"))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return fecha
    End Function

    Public Shared Function ListaAsistencia(id_horario As String, id_grupo As String, fecha As String, id_profesor As String) As List(Of AsistenciaModel)
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String
        Dim asistencia As New List(Of AsistenciaModel)
        Dim i As Integer


        'TRY CATCH PARA VALIDAR CONEXION Y CONSULTAS'
        Try
            'SE REALIZA LA CONEXION CON LA BASE DE DATOS'
            myConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=;" _
            & "database=asistenciautp"

            oConexion.ConnectionString = myConnectionString

            'HACEMOS EL SELECT PARA OBTENER LA CANTIDAD DEL INVENTARIO'

            sSql = "SELECT l.id as 'id_asist', l.id_profesor, l.id_estudiante, l.asistencia, l.porcentaje,
            l.observaciones, l.id_grupo, l.create_at, h.id as 'id_horario', h.hora_entrada, h.hora_salida,
            h.salon, h.id_grupo, e.nombre, e.apellido, e.cedula, e.facultad, e.carrera, e.correo, g.grupo FROM lista_asist AS l
            JOIN horario AS h ON l.id_horario = h.id
            JOIN estudiante AS e ON e.id = l.id_estudiante
            JOIN grupos AS g ON h.id_grupo = g.id WHERE h.id ='" & id_horario & "' and g.id ='" & id_grupo & "' and date(l.create_at) ='" & fecha & "' and l.id_profesor ='" & id_profesor & "'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "lista_asist")

            For i = 0 To oDataSet.Tables("lista_asist").Rows.Count - 1 Step 1
                asistencia.Add(New AsistenciaModel(oDataSet.Tables("lista_asist").Rows(i).Item("id_asist").ToString,
                                        oDataSet.Tables("lista_asist").Rows(i).Item("nombre").ToString,
                                        oDataSet.Tables("lista_asist").Rows(i).Item("apellido").ToString,
                                        oDataSet.Tables("lista_asist").Rows(i).Item("correo").ToString,
                                        oDataSet.Tables("lista_asist").Rows(i).Item("cedula").ToString,
                                        oDataSet.Tables("lista_asist").Rows(i).Item("asistencia").ToString,
                                        oDataSet.Tables("lista_asist").Rows(i).Item("porcentaje").ToString,
                                        oDataSet.Tables("lista_asist").Rows(i).Item("observaciones").ToString))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return asistencia
    End Function

    Public Shared Function GuardarObservaciones(observacion As String, id_asist As String) As String
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String


        'TRY CATCH PARA VALIDAR CONEXION Y CONSULTAS'
        Try
            'SE REALIZA LA CONEXION CON LA BASE DE DATOS'
            myConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=;" _
            & "database=asistenciautp"

            oConexion.ConnectionString = myConnectionString

            'HACEMOS EL SELECT PARA OBTENER LA CANTIDAD DEL INVENTARIO'

            sSql = "UPDATE lista_asist SET observaciones='" & observacion & "' WHERE id ='" & id_asist & "'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "lista_asist")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return "Observaciones guardadas con exito"
    End Function
End Class
