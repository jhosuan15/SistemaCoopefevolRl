Imports System.Resources.ResXFileRef

Public Class Menu
    Public Sub New()
        InitializeComponent()
        Me.IsMdiContainer = True
        Me.BackColor = Color.Aqua ' Cambia este color al que desees
    End Sub
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AhorrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AhorrosToolStripMenuItem.Click
        Dim ahorros As New Ahorros()
        ahorros.MdiParent = Me ' Asigna el formulario MDIParent actual a la ventana secundaria
        ahorros.Show()
    End Sub

    Private Sub InformesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformesToolStripMenuItem.Click
        Dim informes As New Informes()
        informes.MdiParent = Me ' Asigna el formulario MDIParent actual a la ventana secundaria
        informes.Show()
    End Sub

    Private Sub AsociadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsociadosToolStripMenuItem.Click
        Dim asociados As New Asociados()
        asociados.MdiParent = Me ' Asigna el formulario MDIParent actual a la ventana secundaria
        asociados.Show()
    End Sub

    Private Sub VentaUtilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaUtilesToolStripMenuItem.Click
        Dim ventas As New Ventas()
        ventas.MdiParent = Me ' Asigna el formulario MDIParent actual a la ventana secundaria
        ventas.Show()
    End Sub

    Private Sub VentaUniformesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VentaUniformesFisicaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Dim inventario As New Inventario()
        inventario.MdiParent = Me ' Asigna el formulario MDIParent actual a la ventana secundaria
        inventario.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim productos As New Productos()
        productos.MdiParent = Me ' Asigna el formulario MDIParent actual a la ventana secundaria
        productos.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim casilleros As New Casilleros()
        casilleros.MdiParent = Me ' Asigna el formulario MDIParent actual a la ventana secundaria
        casilleros.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim activos As New Activos()
        activos.MdiParent = Me ' Asigna el formulario MDIParent actual a la ventana secundaria
        activos.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) 
        Dim corteAhorros As New CorteAhorros()
        corteAhorros.MdiParent = Me ' Asigna el formulario MDIParent actual a la ventana secundaria
        corteAhorros.Show()
    End Sub


    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs)

    End Sub
End Class