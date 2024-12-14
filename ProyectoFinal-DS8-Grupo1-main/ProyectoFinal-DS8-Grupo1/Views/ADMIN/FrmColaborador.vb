Imports System.Text.RegularExpressions

Public Class FrmColaborador
    Dim objColab As New clsColaborador
    Private Sub BtnRegistrarColab_Click(sender As Object, e As EventArgs) Handles BtnRegistrarColab.Click
        If Not ValidarCampos() Then
            Return
        End If

        ' Obtener los valores de los campos
        Dim nombre As String = txtNombreColab.Text
        Dim apellido As String = txtApellidoColab.Text
        Dim telefono As String = txtTelefonoColab.Text
        Dim direccion As String = txtDireccionColab.Text
        Dim username As String = txtUserName.Text
        Dim password As String = txtPassColab.Text
        Dim email As String = txtCorreoColab.Text
        Dim rolID As Integer = 2

        ' Llamar a la función para crear el colaborador
        Dim mensaje As String = String.Empty
        If objColab.CrearColaborador(username, password, nombre, apellido, email, direccion, telefono, rolID, mensaje) Then
            MessageBox.Show("Colaborador registrado exitosamente. " & mensaje, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Limpiar los campos
        LimpiarCampos()
    End Sub

    Private Sub BtnPassword_Click(sender As Object, e As EventArgs) Handles BtnPassword.Click
        ' Obtiene el nombre y apellido de los TextBox correspondientes
        Dim nombre As String = txtNombreColab.Text
        Dim apellido As String = txtApellidoColab.Text

        ' Genera el username
        Dim username As String = GenerarUsername(nombre, apellido)

        ' Genera la contraseña
        Dim password As String = GenerarPassword(apellido)

        ' Validar la contraseña
        If Not ValidarPassword(password) Then
            ' Si la contraseña no es válida, detener el proceso
            Return
        End If

        ' Muestra el username y password en TextBoxes o MessageBox
        txtUserName.Text = username
        txtPassColab.Text = password
        MessageBox.Show("El nombre de usuario generado es: " & username & vbCrLf & "La contraseña generada es: " & password, "Credenciales Generadas", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnEmail_Click(sender As Object, e As EventArgs) Handles BtnEmail.Click
        ' Obtiene el nombre y apellido de los TextBox correspondientes
        Dim nombre As String = txtNombreColab.Text
        Dim apellido As String = txtApellidoColab.Text

        ' Genera el correo electrónico
        Dim email As String = GenerarEmail(nombre, apellido)

        ' Validar el correo electrónico
        If Not EsCorreoValido(email) Then
            MessageBox.Show("El correo generado no es válido. Por favor, inténtelo de nuevo.", "Validación de Correo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Muestra el correo en un TextBox o MessageBox
        txtCorreoColab.Text = email
        MessageBox.Show("El correo generado es: " & email, "Correo Generado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub FrmColaborador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCorreoColab.Enabled = False
        txtPassColab.Enabled = False
    End Sub

    Private Function ValidarCampos() As Boolean
        ' Verificar si alguno de los TextBox está vacío
        If String.IsNullOrWhiteSpace(txtNombreColab.Text) Then
            MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombreColab.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtApellidoColab.Text) Then
            MessageBox.Show("El campo Apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtApellidoColab.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtTelefonoColab.Text) Then
            MessageBox.Show("El campo Telefono es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTelefonoColab.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtDireccionColab.Text) Then
            MessageBox.Show("El campo Direccion es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDireccionColab.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtUserName.Text) Then
            MessageBox.Show("El campo UserName es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserName.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtPassColab.Text) Then
            MessageBox.Show("El campo Contraseña es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassColab.Focus()
            Return False
        End If
        ' Si todas las validaciones pasan
        Return True
    End Function

    Private Function ValidarPassword(password As String) As Boolean
        ' Validar longitud de la contraseña
        If password.Length < 8 OrElse password.Length > 13 Then
            MessageBox.Show("La contraseña debe tener entre 8 y 13 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassColab.Focus()
            Return False
        End If

        ' Validar caracteres especiales permitidos
        Dim permitido As String = "_*-.abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        If Not password.All(Function(c) permitido.Contains(c)) Then
            MessageBox.Show("La contraseña contiene caracteres no permitidos. Solo se permiten: _*-.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassColab.Focus()
            Return False
        End If

        ' Validar que tenga al menos una letra mayúscula
        If Not password.Any(AddressOf Char.IsUpper) Then
            MessageBox.Show("La contraseña debe contener al menos una letra mayúscula.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassColab.Focus()
            Return False
        End If

        ' Validar que tenga al menos un número
        If Not password.Any(AddressOf Char.IsDigit) Then
            MessageBox.Show("La contraseña debe contener al menos un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassColab.Focus()
            Return False
        End If
        Return True
    End Function


    Public Function EsCorreoValido(correo As String) As Boolean
        Dim regex As New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Return regex.IsMatch(correo)
    End Function

    Private Sub LimpiarCampos()
        txtUserName.Clear()
        txtPassColab.Clear()
        txtNombreColab.Clear()
        txtApellidoColab.Clear()
        txtCorreoColab.Clear()
        txtDireccionColab.Clear()
        txtTelefonoColab.Clear()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If DgvColaboradores.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar un registro para modificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If Not ValidarCampos() Then
            Return
        End If

        ' Obtener los valores de los campos
        Dim colabID As Integer = Integer.Parse(txtID.Text) ' Asegúrate de que el ID del colaborador se captura adecuadamente
        Dim nombre As String = txtNombreColab.Text
        Dim apellido As String = txtApellidoColab.Text
        Dim telefono As String = txtTelefonoColab.Text
        Dim direccion As String = txtDireccionColab.Text
        Dim username As String = txtUserName.Text
        Dim password As String = txtPassColab.Text
        Dim email As String = txtCorreoColab.Text
        Dim rolID As Integer = 2

        ' Llamar a la función para actualizar el colaborador
        Dim mensaje As String = String.Empty
        If objColab.ActualizarColaborador(colabID, username, password, nombre, apellido, email, direccion, telefono, rolID, mensaje) Then
            MessageBox.Show("Colaborador actualizado exitosamente. " & mensaje, "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Limpiar los campos
        LimpiarCampos()
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If DgvColaboradores.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar un registro para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        ' Obtener el ID del colaborador a eliminar
        Dim colabID As Integer = Integer.Parse(txtID.Text) ' Asegúrate de que el ID del colaborador se captura adecuadamente

        ' Mostrar mensaje de confirmación
        Dim confirmResult As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            ' Llamar a la función para eliminar el colaborador
            Dim mensaje As String = String.Empty
            If objColab.EliminarColaborador(colabID, mensaje) Then
                MessageBox.Show("Colaborador eliminado exitosamente. " & mensaje, "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Limpiar los campos
            LimpiarCampos()


        Else
            ' Cancelar la operación de eliminación
            MessageBox.Show("Operación cancelada.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        ' Obtener los datos de los colaboradores
        Dim dt As DataTable = objColab.LeerColaboradores()

        ' Mostrar los datos en el DataGridView
        dgvColaboradores.DataSource = dt
    End Sub
    Private Function GenerarUsername(nombre As String, apellido As String) As String
        ' Obtener las primeras tres letras del nombre y el apellido completo
        Dim primerasLetrasNombre As String = nombre.Substring(0, Math.Min(3, nombre.Length)).ToLower()
        Dim apellidoCompleto As String = apellido.ToLower()

        ' Generar dos números aleatorios
        Dim random As New Random()
        Dim numero As Integer = random.Next(10, 100) ' Número aleatorio entre 10 y 99

        ' Crear el nombre de usuario
        Dim username As String = primerasLetrasNombre & apellidoCompleto & numero.ToString()

        ' Capitalizar la primera letra del nombre y apellido
        username = Char.ToUpper(username(0)) & username.Substring(1, 2) & Char.ToUpper(username(3)) & username.Substring(4)

        Return username
    End Function
    Private Function ReplaceCharAt(str As String, index As Integer, newChar As Char) As String
        Dim chars As Char() = str.ToCharArray()
        chars(index) = newChar
        Return New String(chars)
    End Function
    Private Function GenerarPassword(apellido As String) As String
        Dim random As New Random()
        Dim characters As String = "_*-.abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim password As String = New String(Enumerable.Repeat(characters, 8).Select(Function(s) s(random.Next(s.Length))).ToArray())

        ' Asegurarse de que tiene al menos una letra mayúscula y un número
        If Not password.Any(AddressOf Char.IsUpper) Then
            password = ReplaceCharAt(password, random.Next(0, password.Length), "ABCDEFGHIJKLMNOPQRSTUVWXYZ"(random.Next(26)))
        End If
        If Not password.Any(AddressOf Char.IsDigit) Then
            password = ReplaceCharAt(password, random.Next(0, password.Length), "0123456789"(random.Next(10)))
        End If

        ' Añadir el apellido
        password &= apellido.Substring(0, Math.Min(5, apellido.Length)).ToLower()

        ' Asegurar la longitud entre 8 y 13 caracteres
        If password.Length < 8 Then
            password &= New String(Enumerable.Repeat(characters, 8 - password.Length).Select(Function(s) s(random.Next(s.Length))).ToArray())
        ElseIf password.Length > 13 Then
            password = password.Substring(0, 13)
        End If

        Return password
    End Function
    Private Function GenerarEmail(nombre As String, apellido As String) As String
        ' Convertir a minúsculas y eliminar espacios
        Dim nombreLimpio As String = nombre.ToLower().Replace(" ", "")
        Dim apellidoLimpio As String = apellido.ToLower().Replace(" ", "")

        ' Generar números aleatorios
        Dim random As New Random()
        Dim numero As Integer = random.Next(100, 999) ' Número aleatorio entre 100 y 999

        ' Crear el correo electrónico
        Dim email As String = $"{nombreLimpio}.{apellidoLimpio}{numero}@ejemplo.com"

        Return email
    End Function
    Private Sub dgvColaboradores_SelectionChanged(sender As Object, e As EventArgs) Handles DgvColaboradores.SelectionChanged
        If DgvColaboradores.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DgvColaboradores.SelectedRows(0)
            txtID.Text = selectedRow.Cells("ColabID").Value.ToString()
            txtNombreColab.Text = selectedRow.Cells("Nombre").Value.ToString()
            txtApellidoColab.Text = selectedRow.Cells("Apellido").Value.ToString()
            txtTelefonoColab.Text = selectedRow.Cells("TelefonoColab").Value.ToString()
            txtDireccionColab.Text = selectedRow.Cells("DireccionColab").Value.ToString()
            txtUserName.Text = selectedRow.Cells("ColabName").Value.ToString()
            txtPassColab.Text = selectedRow.Cells("PasswordColab").Value.ToString()
            txtCorreoColab.Text = selectedRow.Cells("Correo").Value.ToString()
            txtRolID.Text = selectedRow.Cells("RolID").Value
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class