Public Class Form1
    Private Sub HandleCalComplete()
        MsgBox("成绩修改完成", , "成绩更新")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim studentInfo As New stuInfo() ' 定义类实例
        ' 建立与studentInfo对象引发的事件关联的处理程序
        AddHandler studentInfo.CalComplete, AddressOf HandleCalComplete
        studentInfo.stuName = "张三"
        studentInfo.Score = 80
        MsgBox("学生" & studentInfo.stuName & "当前成绩是" & studentInfo.Score, , "当前成绩")
        ' 调用能引发CalComplete事件的GetScore方法
        studentInfo.GetScore(80)
    End Sub
End Class
