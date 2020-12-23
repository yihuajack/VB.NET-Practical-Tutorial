Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(My.Application.Info.ProductName & "  Version" & My.Application.Info.Version.ToString() & vbCrLf & My.Application.Info.Copyright, , My.Application.Info.Title)
    End Sub
End Class
