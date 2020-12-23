'  引入名称空间System.Windows.Forms.Application，以便调用DoEvents方法
Imports System.Windows.Forms.Application
Module Module1
    Public F1 As New Form1 '  定义全局变量，将第一个窗体对象声明为全局变量。
    Sub Main()
        F1.Show() '  显示第一个窗体
        Do While True
            DoEvents() '  把控制权交给其他对象
        Loop
    End Sub
    Public Sub ShowMsg() '  定义全局过程
        MsgBox("调用全局过程示例")
    End Sub
End Module
