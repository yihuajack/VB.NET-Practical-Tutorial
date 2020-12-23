Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim form2 As New Form2 ' 创建Form2窗体实例
        form2.MdiParent = Me ' 设置form2为MDI子窗体
        form2.WindowState = FormWindowState.Maximized ' 子窗体最大化显示
        form2.Show() ' 显示子窗体
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End ' 结束程序
    End Sub
End Class
