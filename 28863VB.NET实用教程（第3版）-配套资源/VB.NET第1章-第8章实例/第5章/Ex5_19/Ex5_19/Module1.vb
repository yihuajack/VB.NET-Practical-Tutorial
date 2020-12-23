Module Module1
    Public Interface MyInterface
        Property stuName As String ' 声明属性
        Function GetScores(ByVal x As Single) As Single ' 声明Function过程
    End Interface
    Public Class stuInfo ' 用stuInfo类实现接口
        Implements MyInterface ' 用Implements语句指定接口
        Private studentScore As Single ' 声明类中的变量
        Private studentName As String ' 声明类中的变量
        Public Property Score() As Single ' 声明类中的属性
            Get
                Return studentScore
            End Get
            Set(ByVal Value As Single)
                studentScore = Value
            End Set
        End Property
        Public Property stuName() As String Implements MyInterface.stuName ' 实现接口中的属性
            Get
                Return studentName
            End Get
            Set(ByVal Value As String)
                studentName = Value
            End Set
        End Property
        Public Function GetScore(ByVal x As Single) As Single Implements MyInterface.GetScores '实现接口中的Function过程
            Return x * 0.8
        End Function
    End Class
    Public Class stuMessage ' 用stuMessage类实现接口
        Implements MyInterface ' 用Implements语句指定接口
        Private studentScore As Single ' 声明类中的变量
        Private studentName As String ' 声明类中的变量
        Public Property stuName As String Implements MyInterface.stuName ' 实现接口中的属性
            Get
                Return studentName
            End Get
            Set(ByVal value As String)
                studentName = value
            End Set
        End Property
        Public Function GetScore(ByVal x As Single) As Single Implements MyInterface.GetScores '实现接口中的Function过程
            Return x * 0.2
        End Function
    End Class
End Module
