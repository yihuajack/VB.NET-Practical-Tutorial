Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, j As Integer
        Dim r, g, b As Integer
        Dim bmp As New Bitmap(PictureBox1.Image) ' 定义一个bitmap对象
        PictureBox1.Image = bmp ' 指定图片框的图像属性
        Dim tmpbmp As New Bitmap(PictureBox1.Image) ' 定义一个临时bitmap对象
        ' 浮雕处理
        With tmpbmp
            For i = 0 To .Height - 2 ' 按Y坐标循环
                For j = 0 To .Width - 2 ' 按X坐标循环
                    Dim p1, p2 As Color
                    p1 = .GetPixel(j, i) ' 获得点(j,i)的颜色值
                    p2 = .GetPixel(j + 1, i + 1) ' 获得点(j+1,i+1)的颜色值
                    ' 分别计算相邻像素的红、绿、蓝色差值并加上128，若超过255则取值为255
                    r = Math.Min(Math.Abs(CInt(p1.R) - CInt(p2.R) + 128), 255)
                    g = Math.Min(Math.Abs(CInt(p1.G) - CInt(p2.G) + 128), 255)
                    b = Math.Min(Math.Abs(CInt(p1.B) - CInt(p2.B) + 128), 255)
                    bmp.SetPixel(j, i, Color.FromArgb(r, g, b)) ' 设置点(j,i)的新颜色值
                Next j
            Next i
        End With
    End Sub
End Class
