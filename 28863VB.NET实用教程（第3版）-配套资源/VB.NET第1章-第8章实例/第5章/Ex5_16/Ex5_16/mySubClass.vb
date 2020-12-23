Public Class mySubClass
    Inherits myBaseClass ' 继承myBaseClass类
    Public Overrides Sub ShowInfo() ' 覆盖父类中的同名方法
        MsgBox("Hello", , "子类消息") ' 显示子类的信息Hello
    End Sub
End Class
