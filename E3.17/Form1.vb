Public Class Form1
    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Dim Response
        Response = MsgBox("是否退出系统？", vbOKCancel + vbQuestion, "退出")
        If Response = 1 Then                    '当单击“确定”按钮时
            End
        End If
    End Sub
End Class
