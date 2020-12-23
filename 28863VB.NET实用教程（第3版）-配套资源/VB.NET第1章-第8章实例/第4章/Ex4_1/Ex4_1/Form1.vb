Public Class Form1

    Private Sub btnImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImage.Click
        If btnImage.Text = "打开" Then
            btnImage.Image = ImageList1.Images(1)
            btnImage.Text = "装入"
        ElseIf btnImage.Text = "装入" Then
            btnImage.Image = ImageList1.Images(2)
            btnImage.Text = "关闭"
        ElseIf btnImage.Text = "关闭" Then
            btnImage.Image = ImageList1.Images(0)
            btnImage.Text = "打开"
        End If
    End Sub
End Class
