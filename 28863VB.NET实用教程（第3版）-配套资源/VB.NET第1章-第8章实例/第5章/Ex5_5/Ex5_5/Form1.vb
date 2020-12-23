Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Const N = 10
        Dim A(N), I, J, T As Integer
        Dim tmpstr As String
        Randomize()
        tmpstr = "显示排序前的A元素:" & Chr(13) & Chr(10) '  加入回车换行符
        For I = 0 To N - 1
            A(I) = Int(Rnd() * 100) + 1 '  产生1到100间的随机整数
            tmpstr = tmpstr & A(I) & "  " '  将A各元素连接成字符串
        Next I
        Label1.Text = tmpstr '  在标签中显示A元素
        For J = 0 To N - 2
            For I = 0 To N - 2 - J
                If A(I) > A(I + 1) Then '  相邻的数比较并调换顺序
                    T = A(I) '  T为中间变量
                    A(I) = A(I + 1)
                    A(I + 1) = T
                End If
            Next I
        Next J
        tmpstr = "显示排序后的A元素:" & Chr(13) & Chr(10)
        For I = 0 To N - 1
            tmpstr = tmpstr & A(I) & "  "
        Next I
        Label2.Text = tmpstr '  在标签中显示排序后的A元素
    End Sub
End Class
