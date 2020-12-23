Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Sum As Integer, i As Integer
        For i = 5 To 1 Step -1
            Sum = Sum + Multiply(i)
        Next i
        Debug.WriteLine("Sum=" & Sum)
    End Sub
    Private Function Multiply(ByRef n As Integer) As Integer
        Multiply = 1
        Do While n > 0
            Multiply = Multiply * n
            n = n - 1
        Loop
    End Function
End Class
