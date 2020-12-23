Public Class Form1
    Dim objstuHead As New stuHead() ' 创建stuHead类实例
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With objstuHead
            .Name = "张三" ' 给objstuHead对象的Name属性赋值
            .Name(1) = "David" ' 给objstuHead对象的Name属性赋值
            MsgBox("学生" & .Name & "的英文名是" & .Name(1), , "学生情况")
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ObjstuHead = Nothing
        Close()
    End Sub
End Class
