﻿Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim g1 As Graphics
        g1 = Me.CreateGraphics() ' 把窗体设置为Graphics对象
        Dim Rect2 As New Rectangle(10, 20, 340, 170) ' 定义矩形结构
        Dim BlackPen As New Pen(Color.Black, 3) ' 定义一个黑色画笔
        g1.DrawRectangle(BlackPen, Rect2) ' 画矩形外框
        Dim Rect1 As RectangleF ' 声明矩形结构变量
        Rect1 = New RectangleF(20, 20, 340, 170) ' 定义矩形结构(输出成绩表)
        Dim myBrush1 As New SolidBrush(Color.Blue) ' 定义一个蓝色刷子
        Dim MySF As New StringFormat() ' 声明格式对象
        Dim myTabs As Single() = {120, 120} ' 定义制表位
        MySF.SetTabStops(0, myTabs)
        ' 定义字体
        Dim myFont1 As New Font("宋体", 14, FontStyle.Bold, GraphicsUnit.Point)
        Dim Str1 As String ' 定义成绩表内容
        Str1 = vbCrLf & vbTab
        Str1 &= "学生成绩表" & vbCrLf & vbCrLf
        Str1 &= "姓名" & ControlChars.Tab & "数学" & ControlChars.Tab & "语文" & ControlChars.CrLf & vbCrLf
        Str1 &= "刘刚" & ControlChars.Tab & "75" & ControlChars.Tab & "80" & ControlChars.CrLf
        Str1 &= "吴欣" & vbTab & "90" & vbTab & "85" & vbCrLf
        g1.DrawString(Str1, myFont1, myBrush1, Rect1, MySF) ' 输出成绩表内容
    End Sub
End Class
