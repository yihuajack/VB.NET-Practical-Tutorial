Public Class Form1
    Dim objstuHead As New stuHead() ' 创建stuHead类实例
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With objstuHead
            .Name = "张三" ' 给objstuHead对象的Name属性赋值
            .zhiwu = "班长" ' 给objstuHead对象的zhiwu属性赋值
            MsgBox("学生" & .Name & "的职务是" & .zhiwu, , "学生情况")
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        objstuHead = Nothing
        Close()
    End Sub
End Class
