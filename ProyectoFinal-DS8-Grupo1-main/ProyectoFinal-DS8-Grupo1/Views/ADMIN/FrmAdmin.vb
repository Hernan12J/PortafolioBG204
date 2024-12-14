Public Class FrmAdmin
    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideSubMenu()
    End Sub
    Private Sub HideSubMenu()
        PanelSubInvent.Visible = False
        PanelSubReportes.Visible = False
        PanelSubColab.Visible = False
    End Sub

    Private Sub ShowSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            HideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub

    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click
        ShowSubMenu(PanelSubInvent)
    End Sub

    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles BtnReportes.Click
        ShowSubMenu(PanelSubReportes)
    End Sub

    Private Sub BtnCategoria_Click(sender As Object, e As EventArgs) Handles BtnCategoria.Click
        OpenForms(New FrmCategoria)
        HideSubMenu()
    End Sub

    Private Sub BtnProveedor_Click(sender As Object, e As EventArgs) Handles BtnProveedor.Click
        OpenForms(New FrmProveedor)
        HideSubMenu()
    End Sub

    Private Sub BynProducto_Click(sender As Object, e As EventArgs) Handles BynProducto.Click
        OpenForms(New FrmInventario)
        HideSubMenu()
    End Sub

    '<----------------------------Reporte usuarios-------------------------->
    Private Sub BtnReporte1_Click(sender As Object, e As EventArgs) Handles BtnReporte1.Click
        Dim frm As New FrmReportes()
        frm.ReporteId = 1
        OpenForms(frm)
        HideSubMenu()
    End Sub

    '<----------------------------Reporte inventario-------------------------->
    Private Sub BtnReporteVenta_Click(sender As Object, e As EventArgs) Handles BtnReporteVenta.Click
        Dim frm As New FrmReportes()
        frm.ReporteId = 2
        OpenForms(frm)
        HideSubMenu()
    End Sub

    '<----------------------------Reporte pedidos-------------------------->
    Private Sub BtnReportePedidos_Click(sender As Object, e As EventArgs) Handles BtnReportePedidos.Click
        Dim frm As New FrmReportes()
        frm.ReporteId = 3
        OpenForms(frm)
        HideSubMenu()

        'OpenForms(New FrmReportes)
        'HideSubMenu()
    End Sub

    Private Sub BtnPedidos_Click(sender As Object, e As EventArgs) Handles BtnPedidos.Click
        'OpenForms(New FrmReportes)
        HideSubMenu()
    End Sub

    Private Sub BtnColab_Click(sender As Object, e As EventArgs) Handles BtnColab.Click
        ShowSubMenu(PanelSubColab)
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        HideSubMenu()
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
        PanelFormsAdm.Controls.Add(formsDerivado)
        PanelFormsAdm.Tag = formsDerivado
        formsDerivado.BringToFront()
        formsDerivado.Show()
    End Sub

    Private Sub BtnCrearColab_Click(sender As Object, e As EventArgs) Handles BtnCrearColab.Click
        OpenForms(New FrmColaborador)
        HideSubMenu()
    End Sub

    Private Sub BtnRol_Click(sender As Object, e As EventArgs) Handles BtnRol.Click
        OpenForms(New FrmRoles)
        HideSubMenu()
    End Sub
End Class