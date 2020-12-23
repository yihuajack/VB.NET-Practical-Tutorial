Public Class Form1

    Private Sub btnStu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStu.Click
        ' 单击按钮
        ' 将按钮的文本传递给窗体中的Label1 
        Call frmTrans(ActiveForm, Label1, Me.Text)
    End Sub
    Private Sub frmTrans(ByVal F As Form, ByVal L As Label, ByVal btnText As String)
        ' 显示窗体标题和标签文本，形参为窗体参数
        F.Text = "传递对象"
        L.Text = btnText
        L.Visible = True
    End Sub
End Class
