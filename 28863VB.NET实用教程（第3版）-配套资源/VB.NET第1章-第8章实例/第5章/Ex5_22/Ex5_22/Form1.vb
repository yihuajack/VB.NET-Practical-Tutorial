Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim parts() As String = Split(My.User.Name, "\")
        Dim username As String = parts(1)
        MsgBox("当前用户名称: " & My.User.Name, , "当前用户名")
    End Sub
End Class
