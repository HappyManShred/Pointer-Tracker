Public Class Form1
    Public X As Integer
    Public Y As Integer
    Dim g As Graphics

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        X = e.X
        Y = e.Y
        Label1.Text = "X = " & e.X
        Label2.Text = "Y = " & e.Y
        PictureBox1.Location = New Point(0, Y)
        PictureBox2.Location = New Point(X, 0)

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics
    End Sub
End Class


