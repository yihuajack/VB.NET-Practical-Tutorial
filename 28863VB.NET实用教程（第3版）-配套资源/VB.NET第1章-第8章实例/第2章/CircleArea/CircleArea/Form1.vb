Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r As Single                     '声明一个实数类型的变量 r
        r = TextBox1.Text                   '从 TextBox1 中读取半径值存入变量 r
        TextBox2.Text = Math.PI * r * r '计算圆面积并显示在 TextBox2 中
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
