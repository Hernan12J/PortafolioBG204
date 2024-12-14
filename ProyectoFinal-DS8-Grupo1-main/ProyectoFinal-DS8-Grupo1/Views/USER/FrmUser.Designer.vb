<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUser))
        Me.PanelManuPrinc = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnFactura = New System.Windows.Forms.Button()
        Me.BtnCompra = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelForms = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureFondo = New System.Windows.Forms.PictureBox()
        Me.PanelManuPrinc.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelForms.SuspendLayout()
        CType(Me.PictureFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelManuPrinc
        '
        Me.PanelManuPrinc.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelManuPrinc.Controls.Add(Me.BtnSalir)
        Me.PanelManuPrinc.Controls.Add(Me.BtnFactura)
        Me.PanelManuPrinc.Controls.Add(Me.BtnCompra)
        Me.PanelManuPrinc.Controls.Add(Me.PanelLogo)
        Me.PanelManuPrinc.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelManuPrinc.Location = New System.Drawing.Point(0, 0)
        Me.PanelManuPrinc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelManuPrinc.Name = "PanelManuPrinc"
        Me.PanelManuPrinc.Size = New System.Drawing.Size(260, 670)
        Me.PanelManuPrinc.TabIndex = 0
        '
        'BtnSalir
        '
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnSalir.Location = New System.Drawing.Point(0, 620)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(260, 50)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Cerrar Session"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnFactura
        '
        Me.BtnFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnFactura.FlatAppearance.BorderSize = 0
        Me.BtnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFactura.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnFactura.Location = New System.Drawing.Point(0, 223)
        Me.BtnFactura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFactura.Name = "BtnFactura"
        Me.BtnFactura.Size = New System.Drawing.Size(260, 80)
        Me.BtnFactura.TabIndex = 0
        Me.BtnFactura.Text = "FACTURA"
        Me.BtnFactura.UseVisualStyleBackColor = True
        '
        'BtnCompra
        '
        Me.BtnCompra.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCompra.FlatAppearance.BorderSize = 0
        Me.BtnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompra.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnCompra.Location = New System.Drawing.Point(0, 143)
        Me.BtnCompra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCompra.Name = "BtnCompra"
        Me.BtnCompra.Size = New System.Drawing.Size(260, 80)
        Me.BtnCompra.TabIndex = 0
        Me.BtnCompra.Text = "COMPRAR"
        Me.BtnCompra.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(260, 143)
        Me.PanelLogo.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(53, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelForms
        '
        Me.PanelForms.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.PanelForms.Controls.Add(Me.Label1)
        Me.PanelForms.Controls.Add(Me.PictureFondo)
        Me.PanelForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForms.Location = New System.Drawing.Point(260, 0)
        Me.PanelForms.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelForms.Name = "PanelForms"
        Me.PanelForms.Size = New System.Drawing.Size(1093, 670)
        Me.PanelForms.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(412, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Smart Inventory"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureFondo
        '
        Me.PictureFondo.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.PictureFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureFondo.Location = New System.Drawing.Point(0, 0)
        Me.PictureFondo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureFondo.Name = "PictureFondo"
        Me.PictureFondo.Size = New System.Drawing.Size(1093, 670)
        Me.PictureFondo.TabIndex = 0
        Me.PictureFondo.TabStop = False
        '
        'FrmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1353, 670)
        Me.Controls.Add(Me.PanelForms)
        Me.Controls.Add(Me.PanelManuPrinc)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmUser"
        Me.Text = "USUARIO"
        Me.PanelManuPrinc.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelForms.ResumeLayout(False)
        Me.PanelForms.PerformLayout()
        CType(Me.PictureFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelManuPrinc As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelForms As Panel
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnFactura As Button
    Friend WithEvents BtnCompra As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureFondo As PictureBox
    Friend WithEvents Label1 As Label
End Class
