Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Y, F, k As Integer
        Y = Val(txtYear.Text)
        F = Int((Y - 1) * (1 + 1 / 4 - 1 / 100 + 1 / 400) + 1)
        k = F - Fix(F / 7) * 7
        If (k = 0) Then
            txtDay.Text = "日"
        Else
            txtDay.Text = k
        End If
    End Sub
End Class
