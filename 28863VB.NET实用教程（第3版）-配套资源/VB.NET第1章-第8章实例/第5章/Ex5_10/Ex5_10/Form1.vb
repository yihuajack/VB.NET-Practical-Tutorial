Public Class Form1
    Class Class1
        Private proMyPro As String
        Public Property myPro() As String
            Get
                Return proMyPro ' 返回保存在局部变量中的属性值
            End Get
            Set(ByVal Value As String)
                proMyPro = Value ' 将设置值保存在局部变量中
            End Set
        End Property
        Public Sub ShowInfo()
            MsgBox(proMyPro, , "信息") ' 显示Hello信息
        End Sub
    End Class

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myClass1 As New Class1() ' 建立类的实例
        myClass1.myPro = "Hello World!" ' 设置类的myPro属性值
        myClass1.ShowInfo() ' 调用类的ShowInfo方法
    End Sub
End Class
