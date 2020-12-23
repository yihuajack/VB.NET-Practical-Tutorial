Public Class Student
    Private studentName As String ' 声明私有数据成员
    Public Property Name() As String ' 声明类中的姓名属性
        Get
            Return studentName
        End Get
        Set(ByVal Value As String)
            studentName = Value
        End Set
    End Property
End Class
