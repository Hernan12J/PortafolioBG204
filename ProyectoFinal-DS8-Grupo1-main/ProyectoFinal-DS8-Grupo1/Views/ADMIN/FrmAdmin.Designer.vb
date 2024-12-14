<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmin))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelSubColab = New System.Windows.Forms.Panel()
        Me.BtnRol = New System.Windows.Forms.Button()
        Me.BtnCrearColab = New System.Windows.Forms.Button()
        Me.BtnColab = New System.Windows.Forms.Button()
        Me.PanelSubReportes = New System.Windows.Forms.Panel()
        Me.BtnReportePedidos = New System.Windows.Forms.Button()
        Me.BtnReporteVenta = New System.Windows.Forms.Button()
        Me.BtnReporte1 = New System.Windows.Forms.Button()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.BtnPedidos = New System.Windows.Forms.Button()
        Me.PanelSubInvent = New System.Windows.Forms.Panel()
        Me.BynProducto = New System.Windows.Forms.Button()
        Me.BtnProveedor = New System.Windows.Forms.Button()
        Me.BtnCategoria = New System.Windows.Forms.Button()
        Me.BtnInventario = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelFormsAdm = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMenu.SuspendLayout()
        Me.PanelSubColab.SuspendLayout()
        Me.PanelSubReportes.SuspendLayout()
        Me.PanelSubInvent.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFormsAdm.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.PanelSubColab)
        Me.PanelMenu.Controls.Add(Me.BtnColab)
        Me.PanelMenu.Controls.Add(Me.PanelSubReportes)
        Me.PanelMenu.Controls.Add(Me.BtnReportes)
        Me.PanelMenu.Controls.Add(Me.BtnPedidos)
        Me.PanelMenu.Controls.Add(Me.PanelSubInvent)
        Me.PanelMenu.Controls.Add(Me.BtnInventario)
        Me.PanelMenu.Controls.Add(Me.BtnRegresar)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(260, 703)
        Me.PanelMenu.TabIndex = 0
        '
        'PanelSubColab
        '
        Me.PanelSubColab.Controls.Add(Me.BtnRol)
        Me.PanelSubColab.Controls.Add(Me.BtnCrearColab)
        Me.PanelSubColab.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubColab.Location = New System.Drawing.Point(0, 596)
        Me.PanelSubColab.Name = "PanelSubColab"
        Me.PanelSubColab.Size = New System.Drawing.Size(260, 100)
        Me.PanelSubColab.TabIndex = 4
        '
        'BtnRol
        '
        Me.BtnRol.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRol.FlatAppearance.BorderSize = 0
        Me.BtnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRol.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnRol.Location = New System.Drawing.Point(0, 40)
        Me.BtnRol.Name = "BtnRol"
        Me.BtnRol.Size = New System.Drawing.Size(260, 40)
        Me.BtnRol.TabIndex = 4
        Me.BtnRol.Text = "Agregar Rol"
        Me.BtnRol.UseVisualStyleBackColor = True
        '
        'BtnCrearColab
        '
        Me.BtnCrearColab.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCrearColab.FlatAppearance.BorderSize = 0
        Me.BtnCrearColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearColab.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearColab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnCrearColab.Location = New System.Drawing.Point(0, 0)
        Me.BtnCrearColab.Name = "BtnCrearColab"
        Me.BtnCrearColab.Size = New System.Drawing.Size(260, 40)
        Me.BtnCrearColab.TabIndex = 4
        Me.BtnCrearColab.Text = "Agregar Colaborador"
        Me.BtnCrearColab.UseVisualStyleBackColor = True
        '
        'BtnColab
        '
        Me.BtnColab.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnColab.FlatAppearance.BorderSize = 0
        Me.BtnColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnColab.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnColab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnColab.Location = New System.Drawing.Point(0, 556)
        Me.BtnColab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnColab.Name = "BtnColab"
        Me.BtnColab.Size = New System.Drawing.Size(260, 40)
        Me.BtnColab.TabIndex = 8
        Me.BtnColab.Text = "Administar Colaboradores"
        Me.BtnColab.UseVisualStyleBackColor = True
        '
        'PanelSubReportes
        '
        Me.PanelSubReportes.Controls.Add(Me.BtnReportePedidos)
        Me.PanelSubReportes.Controls.Add(Me.BtnReporteVenta)
        Me.PanelSubReportes.Controls.Add(Me.BtnReporte1)
        Me.PanelSubReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubReportes.Location = New System.Drawing.Point(0, 392)
        Me.PanelSubReportes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelSubReportes.Name = "PanelSubReportes"
        Me.PanelSubReportes.Size = New System.Drawing.Size(260, 164)
        Me.PanelSubReportes.TabIndex = 4
        '
        'BtnReportePedidos
        '
        Me.BtnReportePedidos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReportePedidos.FlatAppearance.BorderSize = 0
        Me.BtnReportePedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportePedidos.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportePedidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnReportePedidos.Location = New System.Drawing.Point(0, 78)
        Me.BtnReportePedidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReportePedidos.Name = "BtnReportePedidos"
        Me.BtnReportePedidos.Size = New System.Drawing.Size(260, 58)
        Me.BtnReportePedidos.TabIndex = 7
        Me.BtnReportePedidos.Text = "Ped. Procesados y No Procesados"
        Me.BtnReportePedidos.UseVisualStyleBackColor = True
        '
        'BtnReporteVenta
        '
        Me.BtnReporteVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReporteVenta.FlatAppearance.BorderSize = 0
        Me.BtnReporteVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReporteVenta.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporteVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnReporteVenta.Location = New System.Drawing.Point(0, 39)
        Me.BtnReporteVenta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReporteVenta.Name = "BtnReporteVenta"
        Me.BtnReporteVenta.Size = New System.Drawing.Size(260, 39)
        Me.BtnReporteVenta.TabIndex = 6
        Me.BtnReporteVenta.Text = "Productos"
        Me.BtnReporteVenta.UseVisualStyleBackColor = True
        '
        'BtnReporte1
        '
        Me.BtnReporte1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReporte1.FlatAppearance.BorderSize = 0
        Me.BtnReporte1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReporte1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporte1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnReporte1.Location = New System.Drawing.Point(0, 0)
        Me.BtnReporte1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReporte1.Name = "BtnReporte1"
        Me.BtnReporte1.Size = New System.Drawing.Size(260, 39)
        Me.BtnReporte1.TabIndex = 5
        Me.BtnReporte1.Text = "Roles y Usuarios"
        Me.BtnReporte1.UseVisualStyleBackColor = True
        '
        'BtnReportes
        '
        Me.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReportes.FlatAppearance.BorderSize = 0
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnReportes.Location = New System.Drawing.Point(0, 353)
        Me.BtnReportes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(260, 39)
        Me.BtnReportes.TabIndex = 7
        Me.BtnReportes.Text = "Reportes"
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'BtnPedidos
        '
        Me.BtnPedidos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPedidos.FlatAppearance.BorderSize = 0
        Me.BtnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPedidos.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPedidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnPedidos.Location = New System.Drawing.Point(0, 313)
        Me.BtnPedidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPedidos.Name = "BtnPedidos"
        Me.BtnPedidos.Size = New System.Drawing.Size(260, 40)
        Me.BtnPedidos.TabIndex = 6
        Me.BtnPedidos.Text = "PEDIDOS"
        Me.BtnPedidos.UseVisualStyleBackColor = True
        '
        'PanelSubInvent
        '
        Me.PanelSubInvent.Controls.Add(Me.BynProducto)
        Me.PanelSubInvent.Controls.Add(Me.BtnProveedor)
        Me.PanelSubInvent.Controls.Add(Me.BtnCategoria)
        Me.PanelSubInvent.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubInvent.Location = New System.Drawing.Point(0, 178)
        Me.PanelSubInvent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelSubInvent.Name = "PanelSubInvent"
        Me.PanelSubInvent.Size = New System.Drawing.Size(260, 135)
        Me.PanelSubInvent.TabIndex = 4
        '
        'BynProducto
        '
        Me.BynProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.BynProducto.FlatAppearance.BorderSize = 0
        Me.BynProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BynProducto.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BynProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BynProducto.Location = New System.Drawing.Point(0, 78)
        Me.BynProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BynProducto.Name = "BynProducto"
        Me.BynProducto.Size = New System.Drawing.Size(260, 39)
        Me.BynProducto.TabIndex = 6
        Me.BynProducto.Text = "Agregar Producto"
        Me.BynProducto.UseVisualStyleBackColor = True
        '
        'BtnProveedor
        '
        Me.BtnProveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProveedor.FlatAppearance.BorderSize = 0
        Me.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProveedor.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnProveedor.Location = New System.Drawing.Point(0, 39)
        Me.BtnProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Size = New System.Drawing.Size(260, 39)
        Me.BtnProveedor.TabIndex = 5
        Me.BtnProveedor.Text = "Agregar Proveedor"
        Me.BtnProveedor.UseVisualStyleBackColor = True
        '
        'BtnCategoria
        '
        Me.BtnCategoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCategoria.FlatAppearance.BorderSize = 0
        Me.BtnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCategoria.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnCategoria.Location = New System.Drawing.Point(0, 0)
        Me.BtnCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCategoria.Name = "BtnCategoria"
        Me.BtnCategoria.Size = New System.Drawing.Size(260, 39)
        Me.BtnCategoria.TabIndex = 4
        Me.BtnCategoria.Text = "Agregar Categoria"
        Me.BtnCategoria.UseVisualStyleBackColor = True
        '
        'BtnInventario
        '
        Me.BtnInventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInventario.FlatAppearance.BorderSize = 0
        Me.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInventario.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnInventario.Location = New System.Drawing.Point(0, 138)
        Me.BtnInventario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnInventario.Name = "BtnInventario"
        Me.BtnInventario.Size = New System.Drawing.Size(260, 40)
        Me.BtnInventario.TabIndex = 4
        Me.BtnInventario.Text = "Administrar Inventario"
        Me.BtnInventario.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnRegresar.FlatAppearance.BorderSize = 0
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnRegresar.Location = New System.Drawing.Point(0, 659)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(260, 44)
        Me.BtnRegresar.TabIndex = 5
        Me.BtnRegresar.Text = "Cerrar Seccion"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(260, 138)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(75, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelFormsAdm
        '
        Me.PanelFormsAdm.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.PanelFormsAdm.Controls.Add(Me.Label1)
        Me.PanelFormsAdm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormsAdm.Location = New System.Drawing.Point(260, 0)
        Me.PanelFormsAdm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelFormsAdm.Name = "PanelFormsAdm"
        Me.PanelFormsAdm.Size = New System.Drawing.Size(1131, 703)
        Me.PanelFormsAdm.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(431, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 43)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Smart Inventory"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1391, 703)
        Me.Controls.Add(Me.PanelFormsAdm)
        Me.Controls.Add(Me.PanelMenu)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmAdmin"
        Me.Text = "FrmAdmin"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelSubColab.ResumeLayout(False)
        Me.PanelSubReportes.ResumeLayout(False)
        Me.PanelSubInvent.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFormsAdm.ResumeLayout(False)
        Me.PanelFormsAdm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents PanelFormsAdm As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnReportes As Button
    Friend WithEvents BtnPedidos As Button
    Friend WithEvents PanelSubInvent As Panel
    Friend WithEvents BynProducto As Button
    Friend WithEvents BtnProveedor As Button
    Friend WithEvents BtnCategoria As Button
    Friend WithEvents BtnInventario As Button
    Friend WithEvents BtnColab As Button
    Friend WithEvents PanelSubReportes As Panel
    Friend WithEvents BtnReportePedidos As Button
    Friend WithEvents BtnReporteVenta As Button
    Friend WithEvents BtnReporte1 As Button
    Friend WithEvents PanelSubColab As Panel
    Friend WithEvents BtnRol As Button
    Friend WithEvents BtnCrearColab As Button
End Class
