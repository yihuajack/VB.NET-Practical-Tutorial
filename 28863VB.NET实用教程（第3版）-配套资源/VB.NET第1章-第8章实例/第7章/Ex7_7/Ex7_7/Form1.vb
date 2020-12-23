﻿Public Class Form1

    Private Sub Form1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim bmp As Bitmap ' 声明一个Bitmap类型变量
        bmp = New Bitmap(Me.Width, Me.Height) ' 设置图形的尺寸，创建空的位图
        Me.BackgroundImage = bmp ' 赋给窗体的BackgroundImage属性
        Dim G As Graphics
        G = Graphics.FromImage(bmp) ' 从bmp对象创建一个Graphics对象
        G.Clear(Me.BackColor) ' 设置位图的背景色并清除原来的图形
        Dim pts(3) As PointF
        Dim i, angle As Integer
        angle = 90
        For i = 0 To 3 ' 建立正方形的4个顶点
            pts(i).X = 100 * Math.Cos(angle * Math.PI / 180)
            pts(i).Y = 100 * Math.Sin(angle * Math.PI / 180)
            angle += 90
        Next i
        G.TranslateTransform(Me.Width / 2, Me.Height / 2) ' 平移正方形到窗口中央
        For i = 1 To 40
            G.DrawPolygon(Pens.Black, pts) ' 画正方形
            G.RotateTransform(9) ' 旋转正方形
            G.ScaleTransform(0.92, 0.92) ' 缩小正方形
        Next i
    End Sub
End Class
