Public Class Form1
    Shared count As Integer
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("http://www.njnu.edu.cn/")
        count = count + 1
        If count < 5 Then
            Label1.Text = "访问了" & count.ToString() & "次"
        Else
            LinkLabel1.Enabled = False
            Label1.Text = "您已访问超5次！"
        End If
    End Sub
End Class
