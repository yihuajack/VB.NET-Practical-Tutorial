Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim g1 As Graphics
        g1 = Me.CreateGraphics() ' 把窗体设置为Graphics对象
        Dim Rect1 As RectangleF ' 声明矩形结构变量
        Dim myString As String = "VB.NET程序设计教程" ' 定义要输出的字符串
        Dim myBrush1 As New SolidBrush(Color.Black) ' 定义一个黑色刷子
        Dim myBrush2 As New SolidBrush(Color.Red) ' 定义一个红色刷子
        Dim myBrush3 As New SolidBrush(Color.Blue) ' 定义一个蓝色刷子
        ' 定义两种字体
        Dim myFont1 As New Font("隶书", 14, FontStyle.Underline, GraphicsUnit.Point)
        Dim myFont2 As New Font("隶书", 10, FontStyle.Underline Or FontStyle.Bold, GraphicsUnit.Point)
        Rect1 = New RectangleF(20.0F, 20.0F, 200.0F, 20.0F) ' 定义矩形结构
        Dim P1 As New PointF(20, 50) ' 定义一个点
        g1.DrawString(myString, myFont1, myBrush1, P1) ' 用第一种格式在窗体上输出文本
        g1.DrawString(myString, myFont2, myBrush2, 20, 80) ' 用第二种格式输出文本
        g1.DrawString(myString, myFont2, myBrush3, Rect1) ' 用第三种格式输出文本
    End Sub
End Class
