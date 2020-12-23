Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, j As Integer
        Dim r, g, b As Integer
        Dim bmp As New Bitmap(PictureBox1.Image) ' 定义一个bitmap对象
        PictureBox1.Image = bmp ' 指定图片框的图像属性
        Dim tmpbmp As New Bitmap(PictureBox1.Image) ' 定义一个临时bitmap对象
        ' 反转处理
        With tmpbmp
            For i = 0 To .Height - 1 ' 按Y坐标循环
                For j = 0 To .Width - 1 ' 按X坐标循环
                    Dim p1 As Color
                    p1 = .GetPixel(j, i) ' 获得点(j,i)的颜色值
                    ' 分别计算像素的红、绿、蓝色的反转值
                    r = 255 - p1.R ' 反转红色值
                    g = 255 - p1.G ' 反转绿色值
                    b = 255 - p1.B ' 反转蓝色值
                    bmp.SetPixel(j, i, Color.FromArgb(r, g, b)) ' 设置点(j,i)的新颜色值
                Next j
            Next i
        End With
    End Sub
End Class
