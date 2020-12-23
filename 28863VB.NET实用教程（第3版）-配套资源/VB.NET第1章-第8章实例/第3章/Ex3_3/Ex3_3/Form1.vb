Public Class Form1

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim strInput As String          ' 定义字符串型
        strInput = txtInput.Text
        Select Case strInput
            Case 123
                labResult.Text = "真幸运,中了一等奖!"
            Case 120 To 129
                labResult.Text = "恭喜你,中了二等奖!"
            Case 100 To 199
                labResult.Text = "还不错,中了三等奖!"
            Case Else
                labResult.Text = "谢谢您的参与!"
        End Select

    End Sub
End Class
