Public Class Form1

    Private Sub Form1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim Str(3) As Object '变体型数组
        Str(0) = "8/16/2014"
        Str(1) = "是第"
        Str(2) = "2"
        Str(3) = "届青奥会"
        MsgBox(Str(0) & Str(1) & Str(2) & Str(3), , "")
    End Sub
End Class
