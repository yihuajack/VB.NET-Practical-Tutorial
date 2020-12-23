Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ProgressBar1.Value >= (ProgressBar1.Maximum - 3) Then
            ProgressBar1.Value = 0
        End If
        ProgressBar1.Value += 3
    End Sub
End Class
