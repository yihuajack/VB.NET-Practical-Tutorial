Public Class myBaseClass
    Public Overridable Sub ShowInfo() ' 允许覆盖
        MsgBox("这是父类方法", , "消息") ' 显示父类的信息
    End Sub
End Class
