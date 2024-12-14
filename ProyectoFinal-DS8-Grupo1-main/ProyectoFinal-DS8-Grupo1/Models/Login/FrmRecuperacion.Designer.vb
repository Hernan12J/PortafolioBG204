<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecuperacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecuperacion))
        Me.PanelSalida = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBoxFondo = New System.Windows.Forms.PictureBox()
        Me.PanelSalida.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSalida
        '
        Me.PanelSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelSalida.Controls.Add(Me.Label1)
        Me.PanelSalida.Controls.Add(Me.BtnSalir)
        Me.PanelSalida.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSalida.Location = New System.Drawing.Point(0, 0)
        Me.PanelSalida.Name = "PanelSalida"
        Me.PanelSalida.Size = New System.Drawing.Size(1006, 37)
        Me.PanelSalida.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Smart Inventory"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Location = New System.Drawing.Point(905, 0)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(101, 37)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnEnviar)
        Me.Panel1.Controls.Add(Me.txtCorreo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(288, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 332)
        Me.Panel1.TabIndex = 1
        '
        'BtnEnviar
        '
        Me.BtnEnviar.FlatAppearance.BorderSize = 0
        Me.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviar.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BtnEnviar.Location = New System.Drawing.Point(125, 247)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(181, 44)
        Me.BtnEnviar.TabIndex = 3
        Me.BtnEnviar.Text = "Enviar Solicitud"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(40, 173)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(351, 22)
        Me.txtCorreo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(32, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ingrese El Correo De Recuperación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(106, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Recuperación De Contraseña"
        '
        'PictureBoxFondo
        '
        Me.PictureBoxFondo.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PictureBoxFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxFondo.Image = CType(resources.GetObject("PictureBoxFondo.Image"), System.Drawing.Image)
        Me.PictureBoxFondo.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxFondo.Name = "PictureBoxFondo"
        Me.PictureBoxFondo.Size = New System.Drawing.Size(1006, 531)
        Me.PictureBoxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFondo.TabIndex = 2
        Me.PictureBoxFondo.TabStop = False
        '
        'FrmRecuperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 531)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelSalida)
        Me.Controls.Add(Me.PictureBoxFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRecuperacion"
        Me.Text = "FrmRecuperacion"
        Me.PanelSalida.ResumeLayout(False)
        Me.PanelSalida.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSalida As Panel
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents PictureBoxFondo As PictureBox
End Class
