<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColaborador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmColaborador))
        Me.PanelSALIR = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PanelRegColab = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.BtnEmail = New System.Windows.Forms.Button()
        Me.DgvColaboradores = New System.Windows.Forms.DataGridView()
        Me.BtnPassword = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtRolID = New System.Windows.Forms.TextBox()
        Me.txtPassColab = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCorreoColab = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelefonoColab = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreColab = New System.Windows.Forms.TextBox()
        Me.txtApellidoColab = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDireccionColab = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnRegistrarColab = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.PanelSALIR.SuspendLayout()
        Me.PanelRegColab.SuspendLayout()
        CType(Me.DgvColaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSALIR
        '
        Me.PanelSALIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelSALIR.Controls.Add(Me.BtnCerrar)
        Me.PanelSALIR.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSALIR.Location = New System.Drawing.Point(0, 0)
        Me.PanelSALIR.Name = "PanelSALIR"
        Me.PanelSALIR.Size = New System.Drawing.Size(1131, 37)
        Me.PanelSALIR.TabIndex = 12
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BtnCerrar.BackgroundImage = CType(resources.GetObject("BtnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(120, 37)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'PanelRegColab
        '
        Me.PanelRegColab.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelRegColab.Controls.Add(Me.Label5)
        Me.PanelRegColab.Controls.Add(Me.BtnMostrar)
        Me.PanelRegColab.Controls.Add(Me.BtnEmail)
        Me.PanelRegColab.Controls.Add(Me.DgvColaboradores)
        Me.PanelRegColab.Controls.Add(Me.BtnPassword)
        Me.PanelRegColab.Controls.Add(Me.txtID)
        Me.PanelRegColab.Controls.Add(Me.txtRolID)
        Me.PanelRegColab.Controls.Add(Me.txtPassColab)
        Me.PanelRegColab.Controls.Add(Me.Label10)
        Me.PanelRegColab.Controls.Add(Me.txtUserName)
        Me.PanelRegColab.Controls.Add(Me.Label7)
        Me.PanelRegColab.Controls.Add(Me.Label6)
        Me.PanelRegColab.Controls.Add(Me.txtCorreoColab)
        Me.PanelRegColab.Controls.Add(Me.Label2)
        Me.PanelRegColab.Controls.Add(Me.txtTelefonoColab)
        Me.PanelRegColab.Controls.Add(Me.Label1)
        Me.PanelRegColab.Controls.Add(Me.Label3)
        Me.PanelRegColab.Controls.Add(Me.txtNombreColab)
        Me.PanelRegColab.Controls.Add(Me.txtApellidoColab)
        Me.PanelRegColab.Controls.Add(Me.Label4)
        Me.PanelRegColab.Controls.Add(Me.Label9)
        Me.PanelRegColab.Controls.Add(Me.txtDireccionColab)
        Me.PanelRegColab.Controls.Add(Me.Label8)
        Me.PanelRegColab.Location = New System.Drawing.Point(40, 60)
        Me.PanelRegColab.Name = "PanelRegColab"
        Me.PanelRegColab.Size = New System.Drawing.Size(1051, 573)
        Me.PanelRegColab.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(722, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "ID"
        '
        'BtnMostrar
        '
        Me.BtnMostrar.FlatAppearance.BorderSize = 0
        Me.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrar.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnMostrar.Image = CType(resources.GetObject("BtnMostrar.Image"), System.Drawing.Image)
        Me.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMostrar.Location = New System.Drawing.Point(809, 477)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(166, 56)
        Me.BtnMostrar.TabIndex = 31
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'BtnEmail
        '
        Me.BtnEmail.FlatAppearance.BorderSize = 0
        Me.BtnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmail.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnEmail.Image = CType(resources.GetObject("BtnEmail.Image"), System.Drawing.Image)
        Me.BtnEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmail.Location = New System.Drawing.Point(758, 419)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(217, 52)
        Me.BtnEmail.TabIndex = 30
        Me.BtnEmail.Text = "Generar Correo"
        Me.BtnEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEmail.UseVisualStyleBackColor = True
        '
        'DgvColaboradores
        '
        Me.DgvColaboradores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.DgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvColaboradores.Location = New System.Drawing.Point(38, 332)
        Me.DgvColaboradores.Name = "DgvColaboradores"
        Me.DgvColaboradores.RowHeadersWidth = 51
        Me.DgvColaboradores.RowTemplate.Height = 24
        Me.DgvColaboradores.Size = New System.Drawing.Size(648, 201)
        Me.DgvColaboradores.TabIndex = 28
        '
        'BtnPassword
        '
        Me.BtnPassword.FlatAppearance.BorderSize = 0
        Me.BtnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPassword.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnPassword.Image = CType(resources.GetObject("BtnPassword.Image"), System.Drawing.Image)
        Me.BtnPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPassword.Location = New System.Drawing.Point(726, 332)
        Me.BtnPassword.Name = "BtnPassword"
        Me.BtnPassword.Size = New System.Drawing.Size(290, 52)
        Me.BtnPassword.TabIndex = 29
        Me.BtnPassword.Text = "Generar Contraseña y UserName"
        Me.BtnPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPassword.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(726, 279)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtID.Size = New System.Drawing.Size(291, 22)
        Me.txtID.TabIndex = 26
        '
        'txtRolID
        '
        Me.txtRolID.Enabled = False
        Me.txtRolID.Location = New System.Drawing.Point(394, 279)
        Me.txtRolID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRolID.Name = "txtRolID"
        Me.txtRolID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRolID.Size = New System.Drawing.Size(291, 22)
        Me.txtRolID.TabIndex = 26
        '
        'txtPassColab
        '
        Me.txtPassColab.Location = New System.Drawing.Point(38, 279)
        Me.txtPassColab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassColab.Name = "txtPassColab"
        Me.txtPassColab.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassColab.Size = New System.Drawing.Size(291, 22)
        Me.txtPassColab.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(391, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Rol ID"
        '
        'txtUserName
        '
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(725, 204)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(291, 22)
        Me.txtUserName.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(35, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "CONTRASEÑA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(723, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "NOMBRE DE USUARIO"
        '
        'txtCorreoColab
        '
        Me.txtCorreoColab.Location = New System.Drawing.Point(395, 204)
        Me.txtCorreoColab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCorreoColab.Name = "txtCorreoColab"
        Me.txtCorreoColab.Size = New System.Drawing.Size(291, 22)
        Me.txtCorreoColab.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(391, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "CORREO"
        '
        'txtTelefonoColab
        '
        Me.txtTelefonoColab.Location = New System.Drawing.Point(38, 204)
        Me.txtTelefonoColab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefonoColab.Name = "txtTelefonoColab"
        Me.txtTelefonoColab.Size = New System.Drawing.Size(291, 22)
        Me.txtTelefonoColab.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(352, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Crear Cuenta Colabotador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(35, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "NOMBRE"
        '
        'txtNombreColab
        '
        Me.txtNombreColab.Location = New System.Drawing.Point(38, 132)
        Me.txtNombreColab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreColab.Name = "txtNombreColab"
        Me.txtNombreColab.Size = New System.Drawing.Size(291, 22)
        Me.txtNombreColab.TabIndex = 21
        '
        'txtApellidoColab
        '
        Me.txtApellidoColab.Location = New System.Drawing.Point(395, 132)
        Me.txtApellidoColab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellidoColab.Name = "txtApellidoColab"
        Me.txtApellidoColab.Size = New System.Drawing.Size(291, 22)
        Me.txtApellidoColab.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(392, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "APELLIDO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(35, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "TELEFONO"
        '
        'txtDireccionColab
        '
        Me.txtDireccionColab.Location = New System.Drawing.Point(725, 132)
        Me.txtDireccionColab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDireccionColab.Name = "txtDireccionColab"
        Me.txtDireccionColab.Size = New System.Drawing.Size(291, 22)
        Me.txtDireccionColab.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(721, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "DIRECCION"
        '
        'BtnRegistrarColab
        '
        Me.BtnRegistrarColab.FlatAppearance.BorderSize = 0
        Me.BtnRegistrarColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrarColab.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarColab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnRegistrarColab.Image = CType(resources.GetObject("BtnRegistrarColab.Image"), System.Drawing.Image)
        Me.BtnRegistrarColab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistrarColab.Location = New System.Drawing.Point(222, 639)
        Me.BtnRegistrarColab.Name = "BtnRegistrarColab"
        Me.BtnRegistrarColab.Size = New System.Drawing.Size(193, 52)
        Me.BtnRegistrarColab.TabIndex = 28
        Me.BtnRegistrarColab.Text = "Registrar"
        Me.BtnRegistrarColab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegistrarColab.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1131, 703)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'BtnModificar
        '
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(530, 639)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(171, 52)
        Me.BtnModificar.TabIndex = 30
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(798, 639)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(183, 52)
        Me.BtnEliminar.TabIndex = 31
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'FrmColaborador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1131, 703)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.PanelRegColab)
        Me.Controls.Add(Me.BtnRegistrarColab)
        Me.Controls.Add(Me.PanelSALIR)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmColaborador"
        Me.Text = "FrmColaborador"
        Me.PanelSALIR.ResumeLayout(False)
        Me.PanelRegColab.ResumeLayout(False)
        Me.PanelRegColab.PerformLayout()
        CType(Me.DgvColaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSALIR As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PanelRegColab As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreColab As TextBox
    Friend WithEvents txtApellidoColab As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDireccionColab As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelefonoColab As TextBox
    Friend WithEvents txtCorreoColab As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEmail As Button
    Friend WithEvents BtnPassword As Button
    Friend WithEvents BtnRegistrarColab As Button
    Friend WithEvents txtPassColab As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DgvColaboradores As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtRolID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
End Class
