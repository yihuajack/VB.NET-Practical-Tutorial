Public Class Form1
    Private Sub ShowScore(ByVal obj As MyInterface, ByVal S As String, ByVal score As Single)
        MsgBox(S & "成绩为" & obj.GetScores(score), , "显示成绩")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj1 As Object = New stuInfo()
        Dim obj2 As Object = New stuMessage()
        ShowScore(obj1, "期末", 85) ' 计算期末成绩
        ShowScore(obj2, "平时", 85) ' 计算平时成绩
    End Sub
End Class
