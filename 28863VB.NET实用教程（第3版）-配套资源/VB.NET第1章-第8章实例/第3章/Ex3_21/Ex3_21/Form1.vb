Public Class Form1
    Private Sub Warning()
        ' 通用过程
        If IsNumeric(txtInput.Text) = True Then                     ' 判断输入的是否为数值
            MsgBox("输入的是数值！", vbOKOnly, "输入")
        Else
            MsgBox("输入的是文字！", vbOKOnly, "输入")
        End If
    End Sub
    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        ' 单击【检查数据】按钮
        Call Warning()                                              ' 调用 Warning 过程
    End Sub

    Private Sub txtInput_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInput.Leave
        ' 失去焦点的事件
        Call Warning()                                              ' 调用 Warning 过程
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        End                                                         ' 结束程序，关闭窗口
    End Sub
End Class
