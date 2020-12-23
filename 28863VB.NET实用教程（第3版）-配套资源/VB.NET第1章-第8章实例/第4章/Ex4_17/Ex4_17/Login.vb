Public Class Login

    Private Sub myDefaultBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myDefaultBtn.Click
        If (tbxUsr.Text = String.Empty Or tbxPwd.Text = String.Empty) Then
            MsgBox("信息不完整！", , "提示")
        ElseIf (tbxUsr.Text <> "admin" Or tbxPwd.Text <> "admin") Then
            MsgBox("用户名或密码不正确,要重新输入吗？", vbOKCancel + vbInformation, "提示")
        Else
            Me.Close()
            UpdateForm.ShowDialog()
        End If
    End Sub

    Private Sub myCancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myCancelBtn.Click
        tbxUsr.Clear()
        tbxPwd.Clear()
    End Sub
End Class