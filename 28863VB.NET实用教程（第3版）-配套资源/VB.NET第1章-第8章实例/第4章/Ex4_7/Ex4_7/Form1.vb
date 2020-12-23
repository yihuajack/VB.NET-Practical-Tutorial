﻿Public Class frmDay
    '  定义模块级变量和数组。
    Dim MyYear As Integer, MyMonth As Integer, MyDay As Integer
    Dim DayTab(12) As Integer

    Private Sub frmDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 置每月的天数
        Dim i As Integer
        DayTab(0) = 31 : DayTab(1) = 28 : DayTab(2) = 31 : DayTab(3) = 30
        DayTab(4) = 31 : DayTab(5) = 30 : DayTab(6) = 31 : DayTab(7) = 31
        DayTab(8) = 30 : DayTab(9) = 31 : DayTab(10) = 30 : DayTab(11) = 31
        MyMonth = 1
        MyDay = 1
        For i = 1 To 31                                 ' 置1～31日期
            lstDate.Items.Add(i)                        ' 向天数列表框添加31天
        Next i
        For i = 1 To 12                                 ' 置1～12月份
            cmbMonth.Items.Add(i)                       ' 向月份组合框添加月份
        Next i
    End Sub

    Private Sub txtYear_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear.Leave
        ' 失去焦点事件用于检查输入年份是否有效，如果出错则通过MsgBox语句提示。
        If Val(txtYear.Text) > 0 And IsNumeric(txtYear.Text) Then
            MyYear = Val(txtYear.Text)
        Else
            MsgBox("年份出错！", , "输入年份")
            txtYear.Focus()
        End If
    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        ' 在组合框的改变选择事件中，将所选项赋给变量MyMonth
        MyMonth = Val(cmbMonth.SelectedItem)                  ' 选择月份
    End Sub

    Private Sub lstDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDate.Click
        ' 在单击列表框事件过程将所选项赋给变量MyDay
        MyDay = Val(lstDate.SelectedItem)                     ' 选择日期
    End Sub

    Private Sub CmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdStart.Click
        ' 计算天数
        Dim Days As Integer
        Days = SumDay(MyMonth, MyDay)
        If (Leap(MyYear) And MyMonth >= 3) Then
            Days = Days + 1
        End If
        txtDay.Text = Days
    End Sub
    Private Function SumDay(ByVal month As Integer, ByVal day As Integer)
        ' 计算总天数，将每月的天数累加
        Dim i As Integer
        For i = 0 To month - 2
            day = day + DayTab(i)                   ' Daytab()数组为每月天数
        Next i
        SumDay = day
    End Function

    Private Function Leap(ByVal year As Integer)
        ' 判断年份是否是闰年
        Dim L As Integer
        L = (year Mod 4 = 0) And (year Mod 100 <> 0) Or (year Mod 400 = 0)
        ' 如果是闰年为True，由于L是整型进行类型转换，则函数返回-1。
        Leap = L
    End Function

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        End
    End Sub
End Class
