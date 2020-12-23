Public Class Form1
    Dim myClass1 As New Class1() ' 创建类的实例
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim intResult As Integer
        Dim realResult As Double
        intResult = myClass1.add(20, 30) ' 调用实例的方法
        realResult = myClass1.add(2.305, 3.61) ' 调用实例的方法
        MsgBox("整数相加=" & Str(intResult) & "，小数相加=" & Str(realResult), , "结果")
    End Sub
End Class
