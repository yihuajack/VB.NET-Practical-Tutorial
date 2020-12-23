﻿Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 设置滚动条的最大值和最小值
        VScrollBar1.Maximum = PictureBox1.Height - Panel1.Height
        HScrollBar1.Maximum = PictureBox1.Width - Panel1.Width
        HScrollBar1.Minimum = 0
        VScrollBar1.Minimum = 0

        ' 设置 LargeChange 为图像大小的十分之一
        VScrollBar1.LargeChange = PictureBox1.Image.Height / 10
        HScrollBar1.LargeChange = PictureBox1.Image.Width / 10

        ' 设置 SmallChange 为 LargeChange 的五分之一
        VScrollBar1.SmallChange = System.Convert.ToInt32(VScrollBar1.LargeChange / 5)
        HScrollBar1.SmallChange = System.Convert.ToInt32(HScrollBar1.LargeChange / 5)

        ' 设置滚动条的初始值
        VScrollBar1.Value = 0
        HScrollBar1.Value = 0
    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        ' 当水平滚动条滚动时，改变图片框的位置
        PictureBox1.Left = -HScrollBar1.Value
    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar1.Scroll
        ' 当垂直滚动条滚动时，改变图片框的位置
        PictureBox1.Top = -VScrollBar1.Value
    End Sub
End Class
