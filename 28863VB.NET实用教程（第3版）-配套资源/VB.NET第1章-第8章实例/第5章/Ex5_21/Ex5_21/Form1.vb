Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("当前系统时间: " & My.Computer.Clock.LocalTime, , "系统时间")
    End Sub
End Class
