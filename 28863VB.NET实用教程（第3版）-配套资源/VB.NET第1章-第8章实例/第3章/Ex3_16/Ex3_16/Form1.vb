Public Class Form1

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim FileName As String
        FileName = InputBox("请输入文件名：", "打开文件", "C:\Program Files\Microsoft Visual Studio 10.0\Common7\IDE\devenv.exe")
        ' 默认的文件名是"C:\Program Files\Microsoft Visual Studio 10.0\Common7\IDE\devenv.exe"
        If FileName <> "" Then
            labFileName.Text = FileName
        Else                                    ' 当用户按【取消】时
            labFileName.Text = ""
        End If
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Dim Response
        Response = MsgBox("是否退出系统？", vbOKCancel + vbQuestion, "退出")
        If Response = 1 Then                    ' 当单击【确定】按钮
            End
        End If
    End Sub
End Class
