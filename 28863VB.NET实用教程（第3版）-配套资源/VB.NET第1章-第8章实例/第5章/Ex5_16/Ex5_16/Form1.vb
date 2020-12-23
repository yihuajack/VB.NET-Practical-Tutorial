Public Class Form1
    Dim objmySubClass As New mySubClass() ' 创建mySubClass类实例
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        objmySubClass.ShowInfo() ' 调用objmySubClass对象的ShowInfo方法
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        objmySubClass = Nothing
        Close()
    End Sub
End Class
