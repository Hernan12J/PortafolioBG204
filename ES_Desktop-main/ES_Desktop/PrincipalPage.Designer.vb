<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrincipalPage
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
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.nombre = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.principalbutton = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.asistenciabutton = New System.Windows.Forms.Button()
        Me.perfilbutton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.White
        Me.PanelPrincipal.Location = New System.Drawing.Point(266, 110)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(720, 412)
        Me.PanelPrincipal.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.nombre)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(997, 100)
        Me.Panel2.TabIndex = 22
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nombre.Location = New System.Drawing.Point(817, 37)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(144, 19)
        Me.nombre.TabIndex = 19
        Me.nombre.Text = "Nombre Apellido"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ES_Desktop.My.Resources.Resources.user
        Me.PictureBox2.Location = New System.Drawing.Point(761, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(108, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 33)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ASISTENCIA UTP"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ES_Desktop.My.Resources.Resources.logo_utp
        Me.PictureBox1.Location = New System.Drawing.Point(21, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.principalbutton)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.asistenciabutton)
        Me.Panel3.Controls.Add(Me.perfilbutton)
        Me.Panel3.Location = New System.Drawing.Point(0, 97)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(260, 425)
        Me.Panel3.TabIndex = 23
        '
        'principalbutton
        '
        Me.principalbutton.BackColor = System.Drawing.Color.Gainsboro
        Me.principalbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.principalbutton.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.principalbutton.Location = New System.Drawing.Point(12, 44)
        Me.principalbutton.Name = "principalbutton"
        Me.principalbutton.Size = New System.Drawing.Size(239, 32)
        Me.principalbutton.TabIndex = 27
        Me.principalbutton.Text = "Pagina principal"
        Me.principalbutton.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gainsboro
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(12, 291)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(239, 32)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Salir del sistema"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gainsboro
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(12, 241)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(239, 32)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Solicitudes"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(12, 193)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(239, 32)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Horario de clases"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'asistenciabutton
        '
        Me.asistenciabutton.BackColor = System.Drawing.Color.Gainsboro
        Me.asistenciabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.asistenciabutton.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.asistenciabutton.Location = New System.Drawing.Point(12, 141)
        Me.asistenciabutton.Name = "asistenciabutton"
        Me.asistenciabutton.Size = New System.Drawing.Size(239, 32)
        Me.asistenciabutton.TabIndex = 23
        Me.asistenciabutton.Text = "Lista de asistencia"
        Me.asistenciabutton.UseVisualStyleBackColor = False
        '
        'perfilbutton
        '
        Me.perfilbutton.BackColor = System.Drawing.Color.Gainsboro
        Me.perfilbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.perfilbutton.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.perfilbutton.Location = New System.Drawing.Point(12, 91)
        Me.perfilbutton.Name = "perfilbutton"
        Me.perfilbutton.Size = New System.Drawing.Size(239, 32)
        Me.perfilbutton.TabIndex = 22
        Me.perfilbutton.Text = "Perfil de usuario"
        Me.perfilbutton.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.PictureBox3)
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Location = New System.Drawing.Point(0, 532)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(997, 100)
        Me.Panel4.TabIndex = 23
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ES_Desktop.My.Resources.Resources.descarga
        Me.PictureBox3.Location = New System.Drawing.Point(900, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(81, 81)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ES_Desktop.My.Resources.Resources.es_logo
        Me.PictureBox4.Location = New System.Drawing.Point(21, 10)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 81)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'PrincipalPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(996, 635)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.MaximizeBox = False
        Me.Name = "PrincipalPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de asistencia UTP"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents asistenciabutton As Button
    Friend WithEvents perfilbutton As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents principalbutton As Button
    Friend WithEvents nombre As Label
End Class
