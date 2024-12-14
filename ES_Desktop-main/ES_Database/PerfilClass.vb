Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Runtime.ConstrainedExecution

Public Class PerfilClass
    Public Shared Function DatosUserPerfil(id As String) As List(Of String)
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
            sSql = "SELECT * FROM profesor AS P JOIN credenciales AS C on P.id= C.id_profesor WHERE P.id ='" & id & "'"

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

        'RECIBO LOS DATOS DEL USUARIO'
        Dim idP = oDataSet.Tables("profesor").Rows(0).Item(0).ToString
        Dim ced = oDataSet.Tables("profesor").Rows(0).Item(1).ToString
        Dim nom = oDataSet.Tables("profesor").Rows(0).Item(2).ToString
        Dim ape = oDataSet.Tables("profesor").Rows(0).Item(3).ToString
        Dim facu = oDataSet.Tables("profesor").Rows(0).Item(4).ToString
        Dim direc = oDataSet.Tables("profesor").Rows(0).Item(5).ToString
        Dim tel = oDataSet.Tables("profesor").Rows(0).Item(6).ToString
        Dim correo = oDataSet.Tables("profesor").Rows(0).Item("correo").ToString
        Dim pass = oDataSet.Tables("profesor").Rows(0).Item("contrasena").ToString
        'ASIGNO LOS DATOS DEL USUARIO A UNA LISTA'
        Dim ListaData As New List(Of String)
        ListaData.Add(id)
        ListaData.Add(ced)
        ListaData.Add(nom)
        ListaData.Add(ape)
        ListaData.Add(facu)
        ListaData.Add(direc)
        ListaData.Add(tel)
        ListaData.Add(correo)
        ListaData.Add(pass)
        Return ListaData

    End Function

    Public Shared Function ActualizarDatos(id As String, txtced As String, txtnom As String, txtape As String, txtfacu As String, txtdirec As String, txttel As String, txtcorreo As String) As Boolean

        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As MySqlDataAdapter
        Dim oDataSet As New DataSet
        Dim sw As Boolean = False
        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim uSql As String
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
            uSql = "UPDATE profesor SET nombre ='" & txtnom & "', apellido ='" & txtape & "', facultad = '" & txtfacu & "', direccion = '" & txtdirec & "', telefono = '" & txttel & "'  WHERE id = '" & id & "' "

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(uSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "profesor")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return sw

    End Function


    Public Shared Function ValidarContraseña(txtpass As String, id_profesor As String) As Boolean
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
            sSql = "SELECT * FROM credenciales WHERE contrasena = '" & txtpass & "' and id_profesor = '" & id_profesor & "' "

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "credenciales")

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

    Public Shared Function ActualizarPass(id_profesor As String, txtpassnew2 As String) As Boolean

        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As MySqlDataAdapter
        Dim oDataSet As New DataSet
        Dim sw As Boolean = False
        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim uSql As String
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
            uSql = "UPDATE credenciales SET contrasena ='" & txtpassnew2 & "' WHERE id_profesor = '" & id_profesor & "' "

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(uSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "credenciales")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return sw

    End Function

End Class
