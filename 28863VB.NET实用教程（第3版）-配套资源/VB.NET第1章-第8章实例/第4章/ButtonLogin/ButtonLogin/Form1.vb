Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End                                     '当单击【退出】按钮时，结束程序运行
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Static n As Integer                     '定义静态变量，在每次触发该事件时，它的值能保留
        If TextBox1.Text = "ABC" And TextBox2.Text = "123" Then
            MsgBox("欢迎光临！", MsgBoxStyle.OkOnly, "系统提示")
        Else
            n = n + 1                           '统计错误的次数
            If n = 3 Then
                MsgBox("你无权登录！", MsgBoxStyle.OkOnly, "系统提示")
                Button1.Enabled = False         '使按钮禁用
            Else
                MsgBox("密码或用户名错误！", MsgBoxStyle.OkOnly, "系统提示")
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("http://member1.taobao.com/member/new_register.jhtml?from=&ex_info=&ex_sign=")
    End Sub
End Class
