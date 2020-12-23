Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        labYear.Text = Year(Now)                                            '显示年份
        labMonth.Text = Month(Now)                                          '显示月份
        labDay.Text = Microsoft.VisualBasic.Day(Now)                        '显示日期
        labTime.Text = Hour(Now) & ":" & Minute(Now) & ":" & Second(Now)    '显示时间
    End Sub
End Class
