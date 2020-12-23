Public Class Form1
    Private Sub txtInput_Leave(ByRef sender As System.Object, ByVal e As System.EventArgs) Handles txtInput.Leave
        '检查输入数据
        If IsNumeric(txtInput.Text) = True Then                 '判断输入的是否为数值
            MsgBox("输入的是数值！", vbOKOnly, "输入")
        Else
            MsgBox("输入的是文字！", vbOKOnly, "输入")
        End If
    End Sub
    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Call txtInput_Leave(sender, e)                          '调用 txtInput_Leave 事件过程
    End Sub
    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
