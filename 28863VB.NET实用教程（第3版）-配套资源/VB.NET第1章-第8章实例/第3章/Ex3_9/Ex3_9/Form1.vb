Public Class Form1

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim i As Integer, j As Integer
        Dim a As Single
        Dim StrPrize As String
        StrPrize = ""
        For i = 1 To 3
            j = Int(10 * Rnd())                     ' 产生 0～9 的随机数
            StrPrize = StrPrize & j
            For a = 1 To 10000 Step 0.001           ' 延时
            Next a
            txtPrize.Text = StrPrize
            txtPrize.Refresh()                      ' 刷新文本框
        Next i
    End Sub
End Class
