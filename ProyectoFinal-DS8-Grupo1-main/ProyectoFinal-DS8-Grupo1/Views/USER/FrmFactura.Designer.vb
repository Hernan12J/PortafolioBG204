<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFactura))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtitbms = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNumeroFactura = New System.Windows.Forms.TextBox()
        Me.PanelSalir = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.dgvFactura = New System.Windows.Forms.DataGridView()
        Me.txtMetododePago = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.PanelSalir.SuspendLayout()
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(344, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detalles De La Factura"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de Cliente: "
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(199, 111)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(240, 22)
        Me.txtNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(27, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Correo:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorreo.Location = New System.Drawing.Point(128, 191)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(305, 22)
        Me.txtCorreo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(24, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefono.Location = New System.Drawing.Point(128, 228)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(305, 22)
        Me.txtTelefono.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(25, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Direccion:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.Location = New System.Drawing.Point(128, 265)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(305, 22)
        Me.txtDireccion.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(791, 495)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Sub Total"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotal.Location = New System.Drawing.Point(915, 489)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(167, 22)
        Me.txtSubTotal.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(794, 530)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "I.T.B.M.S 7%"
        '
        'txtitbms
        '
        Me.txtitbms.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtitbms.Location = New System.Drawing.Point(915, 528)
        Me.txtitbms.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtitbms.Name = "txtitbms"
        Me.txtitbms.Size = New System.Drawing.Size(167, 22)
        Me.txtitbms.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(794, 569)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Location = New System.Drawing.Point(915, 569)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(167, 22)
        Me.txtTotal.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(568, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 19)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Folio:"
        '
        'txtFolio
        '
        Me.txtFolio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFolio.Location = New System.Drawing.Point(637, 110)
        Me.txtFolio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(161, 22)
        Me.txtFolio.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(568, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "FAC#."
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroFactura.Location = New System.Drawing.Point(637, 155)
        Me.txtNumeroFactura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.Size = New System.Drawing.Size(161, 22)
        Me.txtNumeroFactura.TabIndex = 20
        '
        'PanelSalir
        '
        Me.PanelSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelSalir.Controls.Add(Me.BtnCerrar)
        Me.PanelSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSalir.Location = New System.Drawing.Point(0, 0)
        Me.PanelSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelSalir.Name = "PanelSalir"
        Me.PanelSalir.Size = New System.Drawing.Size(1093, 37)
        Me.PanelSalir.TabIndex = 21
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackgroundImage = CType(resources.GetObject("BtnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 0)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(101, 37)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'dgvFactura
        '
        Me.dgvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvFactura.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.dgvFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFactura.ColumnHeadersHeight = 30
        Me.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvFactura.EnableHeadersVisualStyles = False
        Me.dgvFactura.GridColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dgvFactura.Location = New System.Drawing.Point(19, 321)
        Me.dgvFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvFactura.Name = "dgvFactura"
        Me.dgvFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFactura.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFactura.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvFactura.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFactura.Size = New System.Drawing.Size(719, 334)
        Me.dgvFactura.TabIndex = 22
        Me.dgvFactura.VirtualMode = True
        '
        'txtMetododePago
        '
        Me.txtMetododePago.Location = New System.Drawing.Point(637, 193)
        Me.txtMetododePago.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMetododePago.Name = "txtMetododePago"
        Me.txtMetododePago.Size = New System.Drawing.Size(132, 22)
        Me.txtMetododePago.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(501, 196)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 19)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Metodo de Pago"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(15, 155)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(174, 22)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Apellido de Cliente: "
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(199, 151)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(240, 22)
        Me.txtApellido.TabIndex = 26
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.Color.Transparent
        Me.btnMostrar.FlatAppearance.BorderSize = 0
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnMostrar.Location = New System.Drawing.Point(845, 412)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(232, 44)
        Me.btnMostrar.TabIndex = 27
        Me.btnMostrar.Text = "Detalle de Factura"
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'FrmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1093, 670)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMetododePago)
        Me.Controls.Add(Me.dgvFactura)
        Me.Controls.Add(Me.PanelSalir)
        Me.Controls.Add(Me.txtNumeroFactura)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtitbms)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmFactura"
        Me.Text = "Factura"
        Me.PanelSalir.ResumeLayout(False)
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtitbms As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFolio As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNumeroFactura As TextBox
    Friend WithEvents PanelSalir As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents dgvFactura As DataGridView
    Friend WithEvents txtMetododePago As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents btnMostrar As Button
End Class
