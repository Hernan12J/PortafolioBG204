<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpcionesPage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbogrupo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbosalon = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbofecha = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(147, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(450, 33)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "INFORMACION DE ASISTENCIA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(29, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Seleccione el grupo de clases"
        '
        'cbogrupo
        '
        Me.cbogrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbogrupo.FormattingEnabled = True
        Me.cbogrupo.Location = New System.Drawing.Point(29, 112)
        Me.cbogrupo.Name = "cbogrupo"
        Me.cbogrupo.Size = New System.Drawing.Size(332, 23)
        Me.cbogrupo.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(29, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 19)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Seleccione el salon y la hora de clases"
        '
        'cbosalon
        '
        Me.cbosalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosalon.FormattingEnabled = True
        Me.cbosalon.Location = New System.Drawing.Point(29, 185)
        Me.cbosalon.Name = "cbosalon"
        Me.cbosalon.Size = New System.Drawing.Size(332, 23)
        Me.cbosalon.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(29, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Seleccione la fecha"
        '
        'cbofecha
        '
        Me.cbofecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofecha.FormattingEnabled = True
        Me.cbofecha.Location = New System.Drawing.Point(29, 261)
        Me.cbofecha.Name = "cbofecha"
        Me.cbofecha.Size = New System.Drawing.Size(332, 23)
        Me.cbofecha.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(29, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(665, 32)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Ir a la asistencia"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpcionesPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(720, 412)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbofecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbosalon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbogrupo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OpcionesPage"
        Me.Text = "OpcionesPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbogrupo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbosalon As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbofecha As ComboBox
    Friend WithEvents Button1 As Button
End Class
