Imports System.Math
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' 牛顿迭代法
        Dim x, x0, f, f1 As Single
        x0 = Val(TextBox1.Text)
        Do
            x0 = x
            f = ((2 * x0 - 4) * x0 + 3) * x0 - 6
            f1 = (6 * x0 - 8) * x0 + 3
            x = x0 - f / f1
        Loop While Abs(x - x0) >= 0.00005
        TextBox2.Text = x
    End Sub
End Class
