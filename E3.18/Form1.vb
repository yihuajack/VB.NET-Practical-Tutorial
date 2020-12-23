Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim m As Integer, n As Integer, g As Integer
        m = InputBox("请输入M")
        n = InputBox("请输入N")
        g = Divisor(m, n)                   '调用函数Divisor
        Debug.Write(m & "和" & n & "的最大公约数是：" & g)
    End Sub
    Private Function Divisor(ByVal x As Integer, ByVal y As Integer)
        '函数 Divisor 计算最大公约数
        Dim r As Integer
        r = x Mod y
        Do While r <> 0
            x = y
            y = r
            r = x Mod y
        Loop
        Divisor = y
    End Function
End Class
