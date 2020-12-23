Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim m_path As System.Drawing.Drawing2D.GraphicsPath
        m_path = New System.Drawing.Drawing2D.GraphicsPath(Drawing.Drawing2D.FillMode.Winding)
        m_path.AddEllipse(5, 5, 20, 20)
        'Button1.Region() = New Region(m_path)
        ' 定义多边形路径中的点
        'Dim pts() As Point = {New Point(5, 15), New Point(35, 15), New Point(35, 5), New Point(55, 25), New Point(35, 45), New Point(35, 35), New Point(5, 35)}
        ' 形成GraphicsPath
        'Dim polygon_path As New System.Drawing.Drawing2D.GraphicsPath(Drawing2D.FillMode.Winding)
        'polygon_path.AddPolygon(pts)
        ' 将GraphicsPath转为Region
        Dim polygon_region = New Region(m_path)
        ' 将按钮约束在Region内
        Button1.Region = polygon_region
        ' 让按钮填充Region
        Button1.SetBounds(Button1.Location.X, Button1.Location.Y, 20, 20)
    End Sub
End Class
