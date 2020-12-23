Public Class Form1
    Private Function Max(ByVal x As Integer, ByVal y As Integer)
        '求最大值
        Dim z As Integer
        If x < y Then
            z = x : x = y : y = z
        End If
        Max = x
        txtX.Text = x
        txtY.Text = y                       '显示x,y的值
    End Function

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        Dim a As Integer, b As Integer
        a = Val(txtA.Text)
        b = Val(txtB.Text)
        txtMax.Text = Max(a, b)         '显示最大值
        txtResultA.Text = a
        txtResultB.Text = b
    End Sub

    Private Sub cmeEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnd.Click
        End
    End Sub
End Class
