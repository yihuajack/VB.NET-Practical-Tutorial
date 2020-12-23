Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim g1, g2 As Graphics
        Dim BlackPen As New Pen(Color.Black, 2) ' 定义一个黑色画笔
        Dim p1 As New Point(20, 80) ' 定义一个坐标点
        Dim p2 As New Point(50, 30) ' 定义一个坐标点
        Dim p3 As New Point(80, 80) ' 定义一个坐标点
        Dim myPolyg As Point() = {p1, p2, p3} ' 定义一个顶点数组
        g1 = Me.CreateGraphics() ' 把窗体设置为Graphics对象
        g1.DrawRectangle(BlackPen, 10, 10, 80, 50) ' 在窗体上画出矩形
        g2 = PictureBox1.CreateGraphics() ' 把图片框设置为Graphics对象
        g2.DrawPolygon(BlackPen, myPolyg) ' 在图片框中画出三角形
    End Sub
End Class
