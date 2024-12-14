Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class clsCreateUser
    Dim connectionString As String = My.Settings.ConexionBD
    Public Function InsertarCliente(userName As String, password As String, nombreCliente As String, apellidoCliente As String, correo As String, telefono As String, direccionCli As String) As String
        Dim mensaje As String = ""
        Dim rolID As Integer = 1
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                ' Llamada al procedimiento almacenado
                Dim Command As New SqlCommand("CrearCliente", conn)
                Command.CommandType = CommandType.StoredProcedure

                ' Agregar los parámetros
                With Command.Parameters
                    Command.Parameters.AddWithValue("@UserName", userName)
                    Command.Parameters.AddWithValue("@Password", password)
                    Command.Parameters.AddWithValue("@NombreCliente", nombreCliente)
                    Command.Parameters.AddWithValue("@ApellidoCliente", apellidoCliente)
                    Command.Parameters.AddWithValue("@Correo", correo)
                    Command.Parameters.AddWithValue("@Telefono", telefono)
                    Command.Parameters.AddWithValue("@DireccionCli", direccionCli)
                    Command.Parameters.AddWithValue("@RolID", rolID)
                    ' Ejecutar el comando
                    Command.ExecuteNonQuery()
                End With

                mensaje = "Registro Exitoso"
            Catch ex As Exception
                mensaje = "Error: " & ex.Message
            Finally
                conn.Close()
            End Try
        End Using
        Return mensaje
    End Function
    Public Function LeerClientes() As DataTable
        Dim connectionString As String = My.Settings.ConexionBD
        Dim dtClientes As New DataTable()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand("LeerClientes", connection)
                    command.CommandType = CommandType.StoredProcedure
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dtClientes)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Manejo de errores
            Console.WriteLine("Error al leer clientes: " & ex.Message)
        End Try
        Return dtClientes
    End Function
    Public Function LeerClientePorID(clienteID As Integer) As DataRow
        Dim connectionString As String = My.Settings.ConexionBD
        Dim dtCliente As New DataTable()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand("LeerClientePorID", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@ClienteID", clienteID)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dtCliente)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Manejo de errores
            Console.WriteLine("Error al leer cliente por ID: " & ex.Message)
        End Try
        Return If(dtCliente.Rows.Count > 0, dtCliente.Rows(0), Nothing)
    End Function
    Public Function ActualizarCliente(clienteID As Integer, userName As String, password As String, nombreCliente As String, apellidoCliente As String, correo As String, telefono As String, direccionCli As String, rolID As Integer) As String
        Dim connectionString As String = My.Settings.ConexionBD
        Dim mensaje As String = ""
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand("ActualizarCliente", connection)
                    command.CommandType = CommandType.StoredProcedure
                    With command.Parameters
                        .AddWithValue("@ClienteID", clienteID)
                        .AddWithValue("@UserName", userName)
                        .AddWithValue("@Password", password)
                        .AddWithValue("@NombreCliente", nombreCliente)
                        .AddWithValue("@ApellidoCliente", apellidoCliente)
                        .AddWithValue("@Correo", correo)
                        .AddWithValue("@Telefono", telefono)
                        .AddWithValue("@DireccionCli", direccionCli)
                        .AddWithValue("@RolID", rolID)
                    End With
                    command.ExecuteNonQuery()
                End Using
            End Using
            mensaje = "Actualización exitosa"
        Catch ex As Exception
            mensaje = "Error: " & ex.Message
        End Try
        Return mensaje
    End Function
    Public Function EliminarCliente(clienteID As Integer) As String
        Dim connectionString As String = My.Settings.ConexionBD
        Dim mensaje As String = ""
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand("EliminarCliente", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@ClienteID", clienteID)
                    command.ExecuteNonQuery()
                End Using
            End Using
            mensaje = "Eliminación exitosa"
        Catch ex As Exception
            mensaje = "Error: " & ex.Message
        End Try
        Return mensaje
    End Function
    Public Function ValidarUsername(userName As String) As Boolean
        Dim connectionString As String = My.Settings.ConexionBD
        Dim existe As Boolean = False
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim command As New SqlCommand("ValidarUsername", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@UserName", userName)
                command.Parameters.Add("@Existe", SqlDbType.Bit).Direction = ParameterDirection.Output
                command.ExecuteNonQuery()
                existe = Convert.ToBoolean(command.Parameters("@Existe").Value)
            Catch ex As Exception
                Console.WriteLine("Error al validar username: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
        Return existe
    End Function
    Public Function ValidarInsercionCliente(nombreCliente As String, apellidoCliente As String, correo As String, telefono As String) As Boolean
        Dim connectionString As String = My.Settings.ConexionBD
        Dim existe As Boolean = False
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim command As New SqlCommand("ValidarInsercionCliente", connection)
                command.CommandType = CommandType.StoredProcedure
                With command.Parameters
                    .AddWithValue("@NombreCliente", nombreCliente)
                    .AddWithValue("@ApellidoCliente", apellidoCliente)
                    .AddWithValue("@Correo", correo)
                    .AddWithValue("@Telefono", telefono)
                    .Add("@Existe", SqlDbType.Bit).Direction = ParameterDirection.Output
                End With
                command.ExecuteNonQuery()
                existe = Convert.ToBoolean(command.Parameters("@Existe").Value)
            Catch ex As Exception
                Console.WriteLine("Error al validar inserción de cliente: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
        Return existe
    End Function
End Class
