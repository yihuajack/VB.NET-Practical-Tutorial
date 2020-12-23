Public Class Form1

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Const N = 10
        Dim A(N), I, Num, Top, Bott, Min, loca As Integer
        Dim tmpstr, MyNum As String
        A(0) = 1 : A(1) = 3 : A(2) = 5 : A(3) = 8 : A(4) = 12
        A(5) = 23 : A(6) = 34 : A(7) = 44 : A(8) = 45 : A(9) = 68
        tmpstr = "显示A元素:"
        For I = 0 To N - 1
            tmpstr = tmpstr & A(I) & "  " ' 将A各元素连接成字符串
        Next I
        Label1.Text = tmpstr ' 在标签中显示A元素
        MyNum = InputBox("请输入查找数值", "查找数据") ' 输入数据
        Num = Val(MyNum)
        loca = -1 ' 置标志为-1
        Top = 0 : Bott = N - 1
        If Num < A(0) Or Num > A(N - 1) Then loca = -2
        '  不在数组范围内则置标志为-2
        Do While loca = -1 And Top <= Bott
            Min = Int((Bott + Top) / 2) ' 置折半数值
            If Num = A(Min) Then
                loca = Min
                Label2.Text = Num & "的位置在第" & loca + 1 & "个。"
            ElseIf Num < A(Min) Then ' 范围折半
                Bott = Min - 1
            Else
                Top = Min + 1
            End If
        Loop
        If loca = -2 Or loca = -1 Then Label2.Text = "数组中无" & Num

    End Sub
End Class
