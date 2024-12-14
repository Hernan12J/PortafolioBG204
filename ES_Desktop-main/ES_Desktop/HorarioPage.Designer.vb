<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HorarioPage
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
        Me.Horariodgv = New System.Windows.Forms.DataGridView()
        Me.HoraColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LunesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MartesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiercolesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JuevesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViernesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SabadoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Horariodgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(204, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 33)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "HORARIO DE CLASES"
        '
        'Horariodgv
        '
        Me.Horariodgv.AllowUserToAddRows = False
        Me.Horariodgv.AllowUserToDeleteRows = False
        Me.Horariodgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Horariodgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HoraColumn, Me.LunesColumn, Me.MartesColumn, Me.MiercolesColumn, Me.JuevesColumn, Me.ViernesColumn, Me.SabadoColumn})
        Me.Horariodgv.Location = New System.Drawing.Point(17, 92)
        Me.Horariodgv.Name = "Horariodgv"
        Me.Horariodgv.ReadOnly = True
        Me.Horariodgv.RowHeadersVisible = False
        Me.Horariodgv.RowTemplate.Height = 25
        Me.Horariodgv.Size = New System.Drawing.Size(680, 294)
        Me.Horariodgv.TabIndex = 24
        '
        'HoraColumn
        '
        Me.HoraColumn.HeaderText = "Hora"
        Me.HoraColumn.Name = "HoraColumn"
        Me.HoraColumn.ReadOnly = True
        '
        'LunesColumn
        '
        Me.LunesColumn.HeaderText = "Lunes"
        Me.LunesColumn.Name = "LunesColumn"
        Me.LunesColumn.ReadOnly = True
        '
        'MartesColumn
        '
        Me.MartesColumn.HeaderText = "Martes"
        Me.MartesColumn.Name = "MartesColumn"
        Me.MartesColumn.ReadOnly = True
        '
        'MiercolesColumn
        '
        Me.MiercolesColumn.HeaderText = "Miercoles"
        Me.MiercolesColumn.Name = "MiercolesColumn"
        Me.MiercolesColumn.ReadOnly = True
        '
        'JuevesColumn
        '
        Me.JuevesColumn.HeaderText = "Jueves"
        Me.JuevesColumn.Name = "JuevesColumn"
        Me.JuevesColumn.ReadOnly = True
        '
        'ViernesColumn
        '
        Me.ViernesColumn.HeaderText = "Viernes"
        Me.ViernesColumn.Name = "ViernesColumn"
        Me.ViernesColumn.ReadOnly = True
        '
        'SabadoColumn
        '
        Me.SabadoColumn.HeaderText = "Sabado"
        Me.SabadoColumn.Name = "SabadoColumn"
        Me.SabadoColumn.ReadOnly = True
        '
        'HorarioPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(720, 412)
        Me.Controls.Add(Me.Horariodgv)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HorarioPage"
        Me.Text = "HorarioPage"
        CType(Me.Horariodgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Horariodgv As DataGridView
    Friend WithEvents HoraColumn As DataGridViewTextBoxColumn
    Friend WithEvents LunesColumn As DataGridViewTextBoxColumn
    Friend WithEvents MartesColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiercolesColumn As DataGridViewTextBoxColumn
    Friend WithEvents JuevesColumn As DataGridViewTextBoxColumn
    Friend WithEvents ViernesColumn As DataGridViewTextBoxColumn
    Friend WithEvents SabadoColumn As DataGridViewTextBoxColumn
End Class
