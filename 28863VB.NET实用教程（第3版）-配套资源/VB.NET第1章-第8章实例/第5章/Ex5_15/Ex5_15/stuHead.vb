﻿Public Class stuHead
    Inherits Student ' 继承Student类
    Private wholeName(1) As String ' 声明私有数据成员数组，姓名
    Private zhiwuName As String ' 声明私有数据成员，职务
    Public Property zhiwu() As String ' 声明类中的职务属性
        Get
            Return zhiwuName
        End Get
        Set(ByVal Value As String)
            zhiwuName = Value
        End Set
    End Property
    Public Overloads Property Name(ByVal flag As Short) As String ' 重载姓名属性
        Get
            If flag = 0 Then
                Return wholeName(0)
            Else
                Return wholeName(1)
            End If
        End Get
        Set(ByVal Value As String)
            If flag = 0 Then
                wholeName(0) = Value
            Else
                wholeName(1) = Value
            End If
        End Set
    End Property
End Class
