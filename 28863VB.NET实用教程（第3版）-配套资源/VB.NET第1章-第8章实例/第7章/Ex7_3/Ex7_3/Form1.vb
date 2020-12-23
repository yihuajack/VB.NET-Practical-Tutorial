Imports System.Drawing.Drawing2D
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim g1 As Graphics
        g1 = Me.CreateGraphics() ' 把窗体设置为Graphics对象
        Dim Rect1, Rect2, Rect3 As Rectangle ' 声明矩形结构变量
        Dim BlackPen1 As New Pen(Color.Black, 1) ' 定义一个黑色细画笔
        Dim BlackPen2 As New Pen(Color.Black, 3) ' 定义一个黑色粗画笔
        Rect1 = New Rectangle(20, 20, 80, 80) ' 定义矩形结构
        g1.DrawEllipse(BlackPen1, Rect1) ' 在窗体上画圆
        g1.DrawPie(BlackPen2, Rect1, -30, -80) ' 在圆上画扇形
        Rect2 = New Rectangle(140, 20, 80, 80) ' 定义正方形结构
        Dim myBrush As New LinearGradientBrush(Rect2, Color.Yellow, Color.Red, LinearGradientMode.Horizontal) ' 定义一个渐变刷子
        g1.FillEllipse(myBrush, Rect2) ' 在窗体上画渐变圆
        Dim sd As New HatchBrush(HatchStyle.Percent40, Color.Blue, Color.White)
        Rect3 = New Rectangle(20, 140, 120, 80) ' 定义矩形结构
        g1.FillEllipse(sd, Rect3) ' 在窗体上画阴影椭圆
    End Sub
End Class
