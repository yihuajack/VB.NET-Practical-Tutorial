Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim form2 As New Form2 ' 创建Form2窗体实例
        form2.StartPosition = FormStartPosition.CenterScreen
        form2.Show() ' 显示第二个窗体
        Me.Hide() ' 隐藏当前窗体
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End '  结束程序
    End Sub
End Class
