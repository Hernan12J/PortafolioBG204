Imports MySql.Data.MySqlClient
Imports System.Data

Public Class HorarioClass

    Public Shared Function ObtenerHoras(id_profesor As String) As List(Of HorasModel)
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String
        Dim hora As New List(Of HorasModel)
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

            sSql = "SELECT DISTINCT hora_entrada, hora_salida FROM horario
            WHERE id_profesor = '" & id_profesor & "'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "horario")

            For i = 0 To oDataSet.Tables("horario").Rows.Count - 1 Step 1
                hora.Add(New HorasModel(oDataSet.Tables("horario").Rows(i).Item(0), (oDataSet.Tables("horario").Rows(i).Item(1))))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return hora

    End Function

    Public Shared Function ObtenerLunes(id_profesor As String) As List(Of String)
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String
        Dim dia As New List(Of String)
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

            sSql = "SELECT materia, salon FROM horario
            WHERE id_profesor = '" & id_profesor & "' and dia = 'Lunes'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "horario")

            For i = 0 To oDataSet.Tables("horario").Rows.Count - 1 Step 1
                dia.Add(oDataSet.Tables("horario").Rows(i).Item(0) + (oDataSet.Tables("horario").Rows(i).Item(1)))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dia

    End Function

    Public Shared Function ObtenerMartes(id_profesor As String) As List(Of String)
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String
        Dim dia As New List(Of String)
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

            sSql = "SELECT materia, salon FROM horario
            WHERE id_profesor = '" & id_profesor & "' and dia = 'Martes'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "horario")

            For i = 0 To oDataSet.Tables("horario").Rows.Count - 1 Step 1
                dia.Add(oDataSet.Tables("horario").Rows(i).Item(0) + (oDataSet.Tables("horario").Rows(i).Item(1)))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dia

    End Function

    Public Shared Function ObtenerMiercoles(id_profesor As String) As List(Of String)
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String
        Dim dia As New List(Of String)
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

            sSql = "SELECT materia, salon FROM horario
            WHERE id_profesor = '" & id_profesor & "' and dia = 'Miercoles'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "horario")

            For i = 0 To oDataSet.Tables("horario").Rows.Count - 1 Step 1
                dia.Add(oDataSet.Tables("horario").Rows(i).Item(0) + (oDataSet.Tables("horario").Rows(i).Item(1)))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dia

    End Function

    Public Shared Function ObtenerJueves(id_profesor As String) As List(Of String)
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String
        Dim dia As New List(Of String)
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

            sSql = "SELECT materia, salon FROM horario
            WHERE id_profesor = '" & id_profesor & "' and dia = 'Jueves'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "horario")

            For i = 0 To oDataSet.Tables("horario").Rows.Count - 1 Step 1
                dia.Add(oDataSet.Tables("horario").Rows(i).Item(0) + (oDataSet.Tables("horario").Rows(i).Item(1)))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dia

    End Function

    Public Shared Function ObtenerViernes(id_profesor As String) As List(Of String)
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String
        Dim dia As New List(Of String)
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

            sSql = "SELECT materia, salon FROM horario
            WHERE id_profesor = '" & id_profesor & "' and dia = 'Viernes'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "horario")

            For i = 0 To oDataSet.Tables("horario").Rows.Count - 1 Step 1
                dia.Add(oDataSet.Tables("horario").Rows(i).Item(0) + (oDataSet.Tables("horario").Rows(i).Item(1)))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dia

    End Function

    Public Shared Function ObtenerSabado(id_profesor As String) As List(Of String)
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String
        Dim dia As New List(Of String)
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

            sSql = "SELECT materia, salon FROM horario
            WHERE id_profesor = '" & id_profesor & "' and dia = 'Sabado'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "horario")

            For i = 0 To oDataSet.Tables("horario").Rows.Count - 1 Step 1
                dia.Add(oDataSet.Tables("horario").Rows(i).Item(0) + " " + (oDataSet.Tables("horario").Rows(i).Item(1)))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dia

    End Function

End Class
