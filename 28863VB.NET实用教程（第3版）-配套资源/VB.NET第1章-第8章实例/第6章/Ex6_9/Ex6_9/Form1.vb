Public Class Form1

    Private Sub importscoreMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles importscoreMenuItem.Click
        Dim form2 As New Form2 ' 创建Form2窗体实例
        form2.MdiParent = Me ' 设置form2为MDI子窗体
        form2.WindowState = FormWindowState.Normal ' 子窗体默认显示
        form2.Show()
    End Sub

    Private Sub aboutMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutMenuItem.Click
        Dim form3 As New Form3 ' 创建Form3窗体实例
        form3.MdiParent = Me ' 设置form3为MDI子窗体
        form3.WindowState = FormWindowState.Normal ' 子窗体默认显示
        form3.Show()
    End Sub

    Private Sub quitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitMenuItem.Click
        End '  结束程序
    End Sub
End Class
