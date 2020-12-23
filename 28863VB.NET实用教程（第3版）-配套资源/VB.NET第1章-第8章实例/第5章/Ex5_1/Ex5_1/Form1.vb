Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MyDay As Day
        MyDay = Day.Monday
        If MyDay < Day.Saturday Then
            MsgBox("今天是星期一，不是周末", , "")
        End If
    End Sub
End Class
