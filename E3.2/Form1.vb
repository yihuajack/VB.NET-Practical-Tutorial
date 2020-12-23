Public Class Form1
    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        '单击按钮查询
        Dim strInput As String          '定义字符串型
        strInput = txtInput.Text
        If strInput = "123" Then        '号码为"123"
            labResult.Text = "恭喜你，中了一等奖！"
        ElseIf strInput Like "12?" Then    '号码前两位为"12"
            labResult.Text = "恭喜你，中了二等奖！"
        ElseIf strInput Like "1??" Then    '号码第一位为"1"
            labResult.Text = "恭喜你，中了三等奖！"
        Else
            labResult.Text = "谢谢您的参与！"
        End If
    End Sub
End Class
