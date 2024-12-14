Imports System.Data.SqlClient

Public Class clsCategorias
    Dim connectionString As String = My.Settings.ConexionBD

    Public Function InsertarCategoria(nombreCategoria As String, ByRef mensaje As String) As String
        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("InsertarCategoria", conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    ' Parámetro de entrada
                    cmd.Parameters.AddWithValue("@NombreCategoria", nombreCategoria)

                    ' Parámetro de salida
                    Dim paramMensaje As New SqlParameter("@Mensaje", SqlDbType.NVarChar, 50)
                    paramMensaje.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(paramMensaje)

                    conn.Open()
                    cmd.ExecuteNonQuery()

                    ' Capturar y devolver el mensaje de confirmación
                    mensaje = paramMensaje.Value.ToString()
                End Using
            End Using
        Catch ex As Exception
            mensaje = "Error: " & ex.Message
        End Try

        Return mensaje
    End Function

    Public Function ActualizarCategoria(categoriaID As Integer, nombreCategoria As String, ByRef mensaje As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("ActualizarCategoria", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@CategoriaID", categoriaID)
                command.Parameters.AddWithValue("@NombreCategoria", nombreCategoria)

                ' Parámetro de salida
                Dim outputParam As New SqlParameter("@Mensaje", SqlDbType.NVarChar, 50) With {
                .Direction = ParameterDirection.Output
                }
                command.Parameters.Add(outputParam)

                connection.Open()
                command.ExecuteNonQuery()
                mensaje = outputParam.Value.ToString()
                Return Not mensaje.StartsWith("Error")
            End Using
        End Using
    End Function
    Public Function EliminarCategoria(categoriaID As Integer, ByRef mensaje As String) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand("EliminarCategoria", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@CategoriaID", categoriaID)

                    ' Parámetro de salida
                    Dim outputParam As New SqlParameter("@Mensaje", SqlDbType.NVarChar, 50) With {
                    .Direction = ParameterDirection.Output
                }
                    command.Parameters.Add(outputParam)

                    connection.Open()
                    command.ExecuteNonQuery()
                    mensaje = outputParam.Value.ToString()
                    Return Not mensaje.StartsWith("Error")
                End Using
            End Using
        Catch ex As Exception
            mensaje = "Error: " & ex.Message
            Return False
        End Try
    End Function

    ' Función para seleccionar todas las categorías
    Public Function SeleccionarCategorias() As DataTable
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("MostrarCategorias", connection)
                command.CommandType = CommandType.StoredProcedure

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    Dim table As New DataTable()
                    table.Load(reader)
                    Return table
                End Using
            End Using
        End Using
    End Function
    ' Función para buscar una categoría por ID
    Public Function BuscarCategoriaPorID(categoriaID As Integer) As DataRow
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("BuscarCategoriaPorID", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@CategoriaID", categoriaID)

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    Dim table As New DataTable()
                    table.Load(reader)
                    If table.Rows.Count > 0 Then
                        Return table.Rows(0)
                    Else
                        Return Nothing
                    End If
                End Using
            End Using
        End Using
    End Function
End Class
