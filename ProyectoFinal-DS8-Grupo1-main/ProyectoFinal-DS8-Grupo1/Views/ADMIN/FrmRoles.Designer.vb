<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRoles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRoles))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelSALIR = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnRegistrarse = New System.Windows.Forms.Button()
        Me.DgvRoles = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreRol = New System.Windows.Forms.TextBox()
        Me.txtRolID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelSALIR.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvRoles, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelSALIR.TabIndex = 13
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnEliminar)
        Me.Panel1.Controls.Add(Me.BtnMostrar)
        Me.Panel1.Controls.Add(Me.BtnActualizar)
        Me.Panel1.Controls.Add(Me.BtnRegistrarse)
        Me.Panel1.Controls.Add(Me.DgvRoles)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNombreRol)
        Me.Panel1.Controls.Add(Me.txtRolID)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(170, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 579)
        Me.Panel1.TabIndex = 14
        '
        'BtnEliminar
        '
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(614, 494)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(146, 54)
        Me.BtnEliminar.TabIndex = 27
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnMostrar
        '
        Me.BtnMostrar.FlatAppearance.BorderSize = 0
        Me.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrar.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnMostrar.Image = CType(resources.GetObject("BtnMostrar.Image"), System.Drawing.Image)
        Me.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMostrar.Location = New System.Drawing.Point(419, 494)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(146, 54)
        Me.BtnMostrar.TabIndex = 27
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.FlatAppearance.BorderSize = 0
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(222, 494)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(146, 54)
        Me.BtnActualizar.TabIndex = 27
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnRegistrarse
        '
        Me.BtnRegistrarse.FlatAppearance.BorderSize = 0
        Me.BtnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrarse.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnRegistrarse.Image = CType(resources.GetObject("BtnRegistrarse.Image"), System.Drawing.Image)
        Me.BtnRegistrarse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistrarse.Location = New System.Drawing.Point(31, 494)
        Me.BtnRegistrarse.Name = "BtnRegistrarse"
        Me.BtnRegistrarse.Size = New System.Drawing.Size(146, 54)
        Me.BtnRegistrarse.TabIndex = 27
        Me.BtnRegistrarse.Text = "Registrarse"
        Me.BtnRegistrarse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegistrarse.UseVisualStyleBackColor = True
        '
        'DgvRoles
        '
        Me.DgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvRoles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DgvRoles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvRoles.ColumnHeadersHeight = 30
        Me.DgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvRoles.EnableHeadersVisualStyles = False
        Me.DgvRoles.GridColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DgvRoles.Location = New System.Drawing.Point(73, 196)
        Me.DgvRoles.Name = "DgvRoles"
        Me.DgvRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRoles.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvRoles.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvRoles.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvRoles.RowTemplate.Height = 24
        Me.DgvRoles.Size = New System.Drawing.Size(648, 253)
        Me.DgvRoles.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(70, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "NOMBRE"
        '
        'txtNombreRol
        '
        Me.txtNombreRol.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreRol.Location = New System.Drawing.Point(73, 116)
        Me.txtNombreRol.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreRol.Name = "txtNombreRol"
        Me.txtNombreRol.Size = New System.Drawing.Size(291, 27)
        Me.txtNombreRol.TabIndex = 25
        '
        'txtRolID
        '
        Me.txtRolID.Enabled = False
        Me.txtRolID.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRolID.Location = New System.Drawing.Point(430, 116)
        Me.txtRolID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRolID.Name = "txtRolID"
        Me.txtRolID.Size = New System.Drawing.Size(291, 27)
        Me.txtRolID.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(427, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Rol ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(326, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Crear Rol"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1131, 703)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'FrmRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1131, 703)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelSALIR)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRoles"
        Me.Text = "FrmRoles"
        Me.PanelSALIR.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSALIR As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreRol As TextBox
    Friend WithEvents txtRolID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnRegistrarse As Button
    Friend WithEvents DgvRoles As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
