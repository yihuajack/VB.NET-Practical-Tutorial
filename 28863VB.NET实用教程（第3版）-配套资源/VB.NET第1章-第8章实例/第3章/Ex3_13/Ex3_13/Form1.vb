Public Class Form1

    Private Sub btnReverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReverse.Click
        Dim Str As String
        Str = StrReverse(LCase(Trim(txtInput.Text)))
        txtReverse.Text = Str
    End Sub
End Class
