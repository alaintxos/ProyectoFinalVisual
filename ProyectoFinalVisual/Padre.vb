Public Class Padre
    Public f1 As New Menu
    Public f3 As New Primeros
    Public f4 As New Segundos
    Public f5 As New Postres
    Dim f2 As New Reserva

    Private Sub F2Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Me.Label1.Visible = False
        f1.Show()
        f1.Activate()
    End Sub

    Private Sub F3Form3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservaToolStripMenuItem.Click
        Me.Label1.Visible = False
        f2.Show()
        f2.Activate()
    End Sub

    Private Sub F4Form4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F4Form4ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Padre_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.MenuToolStripMenuItem.PerformClick()

        ElseIf e.KeyCode = Keys.F3 Then
            Me.ReservaToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub Padre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Me.KeyPreview = True

        f1.MdiParent = Me
        f2.MdiParent = Me
        f3.MdiParent = Me
        f4.MdiParent = Me
        f5.MdiParent = Me

        f1.WindowState = FormWindowState.Maximized
        f2.WindowState = FormWindowState.Maximized
        f3.WindowState = FormWindowState.Maximized
        f4.WindowState = FormWindowState.Maximized
        f5.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PrimerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrimerosToolStripMenuItem.Click
        Me.Label1.Visible = False
        f3.Show()
        f3.Activate()
    End Sub

    Private Sub SegundosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegundosToolStripMenuItem.Click
        Me.Label1.Visible = False
        f4.Show()
        f4.Activate()
    End Sub

    Private Sub PostresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PostresToolStripMenuItem.Click
        Me.Label1.Visible = False
        f5.Show()
        f5.Activate()
    End Sub
End Class
