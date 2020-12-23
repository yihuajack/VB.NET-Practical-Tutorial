Public Class stuHead
    Inherits Student ' 继承Student类
    Private zhiwuName As String ' 声明私有数据成员
    Public Property zhiwu() As String ' 声明类中的职务属性
        Get
            Return zhiwuName
        End Get
        Set(ByVal Value As String)
            zhiwuName = Value
        End Set
    End Property
End Class
