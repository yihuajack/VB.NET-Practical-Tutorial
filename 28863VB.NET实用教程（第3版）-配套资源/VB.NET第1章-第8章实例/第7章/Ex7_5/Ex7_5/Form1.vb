﻿Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim g1 As Graphics
        g1 = Me.CreateGraphics() ' 把窗体设置为Graphics对象
        Dim Rect1, Rect2 As RectangleF ' 声明矩形结构变量
        Dim myBrush1 As New SolidBrush(Color.Blue) ' 定义一个蓝色刷子
        Dim MySF As New StringFormat() ' 声明格式对象
        MySF.Alignment = StringAlignment.Center ' 水平对齐
        MySF.LineAlignment = StringAlignment.Center
        Dim Str1 As String = "登鹳雀楼"
        Dim Str2 As String
        Str2 = "白日依山尽，" & vbCrLf & "黄河入海流。" & vbCrLf
        Str2 &= "欲穷千里目，" & vbCrLf & "更上一层楼。"
        ' 定义两种字体
        Dim myFont1 As New Font("宋体", 18, FontStyle.Bold, GraphicsUnit.Point)
        Dim myFont2 As New Font("幼圆", 14, FontStyle.Bold, GraphicsUnit.Point)
        Rect1 = New RectangleF(10, 50, 200, 140) ' 定义矩形结构(输出诗文)
        Rect2 = New RectangleF(12, 20, 200, 70) ' 定义矩形结构(输出标题)
        g1.DrawString(Str1, myFont1, myBrush1, Rect2, MySF) ' 输出标题文本
        g1.DrawString(Str2, myFont2, myBrush1, Rect1, MySF) ' 输出诗文文本
        MySF.FormatFlags = StringFormatFlags.DirectionVertical ' 垂直排列
        Dim P1 As New PointF(230, 100) ' 定义标题起点
        Dim P2 As New PointF(290, 100) ' 定义诗文起点
        g1.DrawString(Str1, myFont1, myBrush1, P1, MySF) ' 输出标题文本
        g1.DrawString(Str2, myFont2, myBrush1, P2, MySF) ' 输出诗文文本
    End Sub
End Class
