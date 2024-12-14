Public Class FrmUser
    ' Propiedad para almacenar el userName
    Private _userName As String

    ' Constructor que recibe el userName
    Public Sub New(userName As String)
        ' Este llamado es necesario para inicializar los componentes del formulario
        InitializeComponent()

        ' Asignar el valor de userName a la propiedad
        _userName = userName
    End Sub

    ' Usar el _userName dentro de FrmFactura
    Private Sub FrmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub VOLVERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub BtnCatalogo_Click(sender As Object, e As EventArgs)
        'OpenForms(New FrmCatalogo())
    End Sub

    Private Sub BtnCompra_Click(sender As Object, e As EventArgs) Handles BtnCompra.Click
        OpenForms(New FrmCompra(_userName))
    End Sub

    Private Sub BtnFactura_Click(sender As Object, e As EventArgs) Handles BtnFactura.Click
        OpenForms(New FrmFactura(_userName))
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Hide()
        FrmPrincipal.Show()
    End Sub
    Private Property masterForms As Form = Nothing
    Private Sub OpenForms(formsDerivado As Form)
        If masterForms IsNot Nothing Then masterForms.Close()
        masterForms = formsDerivado
        formsDerivado.TopLevel = False
        formsDerivado.FormBorderStyle = FormBorderStyle.None
        formsDerivado.Dock = DockStyle.Fill
        PanelForms.Controls.Add(formsDerivado)
        PanelForms.Tag = formsDerivado
        formsDerivado.BringToFront()
        formsDerivado.Show()
    End Sub

    Private Sub PictureFondo_Click(sender As Object, e As EventArgs) Handles PictureFondo.Click

    End Sub

    Private Sub PanelManuPrinc_Paint(sender As Object, e As PaintEventArgs) Handles PanelManuPrinc.Paint

    End Sub
End Class