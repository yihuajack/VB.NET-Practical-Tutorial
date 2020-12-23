Public Class Form1
    Private Function Fib(ByVal g As Integer)
        ' 计算Fibonacci数列
        If g = 1 Or g = 2 Then
            Fib = 1
        Else
            Fib = Fib(g - 1) + Fib(g - 2)
        End If
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim k As Long
        Dim n As Integer
        n = InputBox("请输入计算的数列的个数：")
        k = Fib(n)
        Debug.WriteLine("Fibonacci数列第" & n & "个数是" & k)
    End Sub
End Class
