Public Class Form1
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        '单击“计算”按钮
        Dim Score1(5) As Single, Score2(8) As Single
        Score1(0) = 90 : Score1(1) = 70 : Score1(2) = 91                '置初值
        Score1(3) = 60 : Score1(4) = 65
        Score2(0) = 75 : Score2(1) = 80 : Score2(2) = 71
        Score2(3) = 54 : Score2(4) = 99
        Score2(5) = 77 : Score2(6) = 89 : Score2(7) = 76
        txtS1.Text = Int(Average(Score1, 5) * 100) / 100            '求一班学生的平均成绩
        txtS2.Text = Int(Average(Score2, 8) * 100) / 100            '求二班学生的平均成绩
    End Sub
    Private Function Average(ByVal stuArray() As Single, ByVal n As Integer) As Single
        '求平均值
        Dim i As Integer
        Dim aver As Single, sum As Single
        For i = 0 To n - 1
            sum = sum + stuArray(i)
        Next i
        aver = sum / n
        Average = aver
    End Function

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
