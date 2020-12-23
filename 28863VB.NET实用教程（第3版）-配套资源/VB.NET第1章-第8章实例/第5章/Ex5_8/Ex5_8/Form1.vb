Public Class Form1
    Private Function Muln(ByVal n As Integer) As Integer
        If n = 0 Or n = 1 Then
            ' 结束条件n=0或n=1
            Muln = 1
        Else
            Muln = Muln(n - 1) * n
        End If
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim M As Integer, i As Integer
        i = InputBox("请输入一个正整数")
        M = Muln(i)
        Debug.WriteLine("M=" & M)
    End Sub
End Class
