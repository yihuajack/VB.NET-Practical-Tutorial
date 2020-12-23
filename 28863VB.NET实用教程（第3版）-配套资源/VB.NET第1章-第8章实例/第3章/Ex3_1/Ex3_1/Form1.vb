Public Class Form1

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        ' 计算温度
        Dim f As Single, c As Single
        f = 78
        c = 5 / 9 * (f - 32)
        txtTemperature.Text = c
    End Sub
End Class
