<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SolicitudPage
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboequipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textcantidad = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textdia = New System.Windows.Forms.DateTimePicker()
        Me.cbosalon = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(251, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 33)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "SOLICITUDES"
        '
        'cboequipo
        '
        Me.cboequipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboequipo.FormattingEnabled = True
        Me.cboequipo.Location = New System.Drawing.Point(30, 93)
        Me.cboequipo.Name = "cboequipo"
        Me.cboequipo.Size = New System.Drawing.Size(266, 23)
        Me.cboequipo.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(30, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Seleccione lo que desea solicitar"
        '
        'textcantidad
        '
        Me.textcantidad.Location = New System.Drawing.Point(30, 167)
        Me.textcantidad.Name = "textcantidad"
        Me.textcantidad.Size = New System.Drawing.Size(664, 23)
        Me.textcantidad.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(28, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(665, 32)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Enviar solicitud"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(30, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 19)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Ingrese la cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(30, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 19)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Ingrese el salon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(29, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 19)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Dia de solicitud"
        '
        'textdia
        '
        Me.textdia.Enabled = False
        Me.textdia.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textdia.Location = New System.Drawing.Point(30, 283)
        Me.textdia.Name = "textdia"
        Me.textdia.Size = New System.Drawing.Size(664, 22)
        Me.textdia.TabIndex = 46
        '
        'cbosalon
        '
        Me.cbosalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosalon.FormattingEnabled = True
        Me.cbosalon.Location = New System.Drawing.Point(30, 220)
        Me.cbosalon.Name = "cbosalon"
        Me.cbosalon.Size = New System.Drawing.Size(663, 23)
        Me.cbosalon.TabIndex = 47
        '
        'SolicitudPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(720, 412)
        Me.Controls.Add(Me.cbosalon)
        Me.Controls.Add(Me.textdia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textcantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboequipo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SolicitudPage"
        Me.Text = "SolicitudPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboequipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textcantidad As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents textdia As DateTimePicker
    Friend WithEvents cbosalon As ComboBox
End Class
