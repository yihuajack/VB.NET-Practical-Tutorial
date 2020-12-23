Public Class Form1

    Private Sub Form1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim g As Graphics
        Dim I As Short
        Dim BlackPen As New Pen(Color.Black, 2) ' 定义一个黑色画笔
        g = Me.CreateGraphics() ' 把窗体设置为Graphics对象
        For I = 0 To 180 Step 10 ' 循环画19条竖线
            g.DrawLine(BlackPen, 20 + I, 20, 20 + I, 200) ' 画一根线
        Next I
        For I = 0 To 180 Step 10 ' 循环画19条横线
            g.DrawLine(BlackPen, 20, 20 + I, 200, 20 + I) ' 画一根线
        Next I
    End Sub
End Class
