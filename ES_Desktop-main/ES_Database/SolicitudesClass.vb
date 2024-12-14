Imports MySql.Data.MySqlClient
Imports System.Data

Public Class SolicitudesClass
    Public Shared Function InsertarSolicitud(id_profesor As String, id_inventario As String, cboequipo As String, txtcantidad As String, textsalon As String) As Boolean
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim sw As Boolean = False
        Dim myConnectionString As String


        'TRY CATCH PARA VALIDAR CONEXION Y CONSULTAS'
        Try
            'SE REALIZA LA CONEXION CON LA BASE DE DATOS'
            myConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=;" _
            & "database=asistenciautp"

            oConexion.ConnectionString = myConnectionString


            'PROCEDEMOS A HACER EL INSERT EN LA TABLA DE SOLICITUDES'

            sSql = "INSERT INTO solicitudes (id_profesor, id_inventario, equipo_solicitado , fecha_solicitud_pedido, estado_solicitud,  salon, cantidad) VALUES ( '" & id_profesor & "','" & id_inventario & "','" & cboequipo & "', NOW() , 'Solicitado', '" & textsalon & "', '" & txtcantidad & "')"



            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "inventario")


            ' MsgBox("La solicitud fue enviada correctamente")


            ' End If

        Catch ex As Exception
            MsgBox(ex.Message)
            ' MsgBox("ERROR CANTIDAD INSUFICIENTE")
        End Try


        Return sw

    End Function
    Public Shared Function ValidarSolicitud(txtcantidad As String, cboequipo As String) As Boolean
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim sw As Boolean = False
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

            sSql = "SELECT cantidad FROM inventario WHERE equipo = '" & cboequipo & "' "



            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "inventario")


            'IF PARA VALIDAR LA CANTIDAD DEL INVENTARIO'

            If oDataSet.Tables("inventario").Rows(0).Item(0) <= txtcantidad Then
                Return sw = True
            Else
                Return sw = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return sw

    End Function
    Public Shared Function VerProducto(cboequipo As String) As String
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim sw As String
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

            sSql = "SELECT id FROM inventario WHERE equipo = '" & cboequipo & "'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "inventario")


            'IF PARA VALIDAR LA CANTIDAD DEL INVENTARIO'

            sw = oDataSet.Tables("inventario").Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return sw

    End Function

    Public Shared Function VerSalon(id_profesor As String) As List(Of String)
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String
        Dim salones As New List(Of String)
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

            sSql = "SELECT DISTINCT salon FROM horario where id_profesor='" & id_profesor & "' and salon != '-'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "salon")

            For i = 0 To oDataSet.Tables("salon").Rows.Count - 1 Step 1
                salones.Add(oDataSet.Tables("salon").Rows(i).Item(0))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return salones

    End Function

    Public Shared Function VerEquipo() As List(Of EquiposModel)
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String
        Dim equipo As New List(Of EquiposModel)
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

            sSql = "SELECT id, equipo FROM inventario"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "inventario")

            For i = 0 To oDataSet.Tables("inventario").Rows.Count - 1 Step 1
                equipo.Add(New EquiposModel(oDataSet.Tables("inventario").Rows(i).Item(0), oDataSet.Tables("inventario").Rows(i).Item(1)))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return equipo

    End Function
End Class
