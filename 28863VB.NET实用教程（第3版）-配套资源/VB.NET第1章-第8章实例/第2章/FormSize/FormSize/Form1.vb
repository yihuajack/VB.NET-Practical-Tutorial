Public Class Form1

    Private Sub Form1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        MsgBox("我变宽了！")                 '当窗体改变大小时显示该消息
    End Sub

    Private Sub Form1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Me.Width = Me.Width + 20            '当单击窗体时让该窗体的宽度增加 20 个像素点
    End Sub
End Class
