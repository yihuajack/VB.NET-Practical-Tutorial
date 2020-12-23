Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Fibonacci 数列
        Dim i, f() As Integer
        Dim n As Integer
        n = Val(InputBox("请输入数组元素个数", "输入", , 100, 100))
        If n <> 0 Then
            ReDim f(n)
            f(0) = 1 : f(1) = 1                         ' 设置F1,F2初值
            For i = 2 To n - 1                          ' 计算Fn
                f(i) = f(i - 2) + f(i - 1)
            Next i
            For i = 0 To n - 1
                Debug.Write(f(i))                       ' 打印一个数
                Debug.Write(Space(4))      ' 空4格
                If (i + 1) Mod 5 = 0 And i <> 0 Then
                    Debug.WriteLine("")
                End If                                  ' 打印5个数换一行
            Next
        End If
    End Sub
End Class
