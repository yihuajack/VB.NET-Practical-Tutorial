Imports System.Math
Public Class Form1
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim a, b, c, Disc, x1, x2, Rpart, IPart As Single
        a = Val(txtA.Text)                                  '取数据a
        b = Val(txtB.Text)                                  '取数据b
        c = Val(txtC.Text)                                  '取数据c
        If Abs(a) <= 0.000001 Then                          '当a=0时
            txtX1.Text = -c / b
            txtX2.Text = "无解"
        Else                                                '当a<>0时
            Disc = b * b - 4 * a * c
            Rpart = -b / (2 * a)
            If Abs(Disc) <= 0.000001 Then                   '当Disc=0时
                txtX1.Text = Rpart
                txtX2.Text = Rpart
            ElseIf Disc > 0.000001 Then                     '当Disc>0时
                x1 = (-b + Sqrt(Disc)) / (2 * a)
                x2 = (-b - Sqrt(Disc)) / (2 * a)
                txtX1.Text = x1
                txtX2.Text = x2
            Else                                            '当Disc<0时
                IPart = Sqrt(-Disc) / (2 * a)
                txtX1.Text = Rpart & "+" & IPart & "i"
                txtX2.Text = Rpart & "-" & IPart & "i"
            End If
        End If
    End Sub
End Class
