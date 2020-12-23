Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, j, m, n As Integer
        Dim r, g, b As Integer
        Dim bmp As New Bitmap(PictureBox1.Image) ' 定义一个bitmap对象
        PictureBox1.Image = bmp ' 指定图片框的图像属性
        Dim tmpbmp As New Bitmap(PictureBox1.Image) ' 定义一个临时bitmap对象
        ' 柔化处理
        With tmpbmp
            For i = 1 To .Height - 2 ' 按Y坐标循环
                For j = 1 To .Width - 2 ' 按X坐标循环
                    r = 0 ' 初始化红颜色值
                    g = 0 ' 初始化绿颜色值
                    b = 0 ' 初始化蓝颜色值
                    ' 分别计算3×3像素块的红、绿、蓝颜色的平均值
                    For m = -1 To 1
                        For n = -1 To 1
                            Dim p1 As Color
                            p1 = .GetPixel(j + m, i + n) ' 获得点(j,i)的颜色值
                            r = r + p1.R
                            g = g + p1.G
                            b = b + p1.B
                        Next n
                    Next m
                    bmp.SetPixel(j, i, Color.FromArgb(r / 9, g / 9, b / 9)) ' 设置点(j,i)的新颜色值
                Next j
            Next i
        End With

    End Sub
End Class
