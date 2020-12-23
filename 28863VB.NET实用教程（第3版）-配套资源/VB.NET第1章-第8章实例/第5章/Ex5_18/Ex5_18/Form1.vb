Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj1 As Object = New Multiply() ' 后期绑定
        Dim obj2 As Object = New NewAdd() ' 后期绑定
        MsgBox(obj1.Calculate(10, 20)) ' 计算乘积
        MsgBox(obj2.Calculate(10, 20)) ' 计算加法
    End Sub
End Class
