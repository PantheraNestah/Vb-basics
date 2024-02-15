Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Form2
        frm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim toolTip As New ToolTip()
    End Sub
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub
End Class
