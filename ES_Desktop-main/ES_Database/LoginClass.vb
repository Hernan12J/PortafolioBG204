Imports System.Buffers
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI

Public Class LoginClass

    Public Shared Function ValidarUsuario(txtcorreo As String, txtpass As String) As Boolean
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

            'SE REALIZA LA CONSULTA SQL'
            sSql = "SELECT * FROM credenciales WHERE correo = '" & txtcorreo & "' AND contrasena = '" & txtpass & "'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "credenciales")

            'VALIDAMOS NUESTRO DATASET DONDE SI ES DISTINTO A CERO ENCONTRO EL DATO'
            If oDataSet.Tables("credenciales").Rows.Count <> 0 Then
                sw = True
            Else
                sw = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return sw

    End Function

    Public Shared Function VerID(txtcorreo As String, txtpass As String) As String
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As MySqlDataAdapter
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

            'SE REALIZA LA CONSULTA SQL'
            sSql = "SELECT * FROM credenciales WHERE correo = '" & txtcorreo & "' AND contrasena = '" & txtpass & "'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "credenciales")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return oDataSet.Tables("credenciales").Rows(0).Item(1).ToString

    End Function

    Public Shared Function DatosProfesor(id As String) As String
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As MySqlDataAdapter
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

            'SE REALIZA LA CONSULTA SQL'
            sSql = "SELECT * FROM profesor WHERE id = '" & id & "'"

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "profesor")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'RECIBO LOS DATOS DEL PROFESOR ELIGIENDO LA COLUMNA 0 Y EL ITEM 2 SIENDO LA COLUMNA DE NOMBRE Y EL ITEM 3 LA COLUMNA APELLIDO'
        Dim usuario = oDataSet.Tables("profesor").Rows(0).Item(2).ToString + " " + oDataSet.Tables("profesor").Rows(0).Item(3).ToString

        Return usuario

    End Function
End Class
