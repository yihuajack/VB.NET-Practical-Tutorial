Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Module1.F1.Show() ' 访问模块中全局变量F1，显示第一个窗体
        Me.Hide() ' 隐藏当前窗体
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Module1.ShowMsg() ' 调用模块中定义的全局过程
    End Sub
End Class