Public Class Class1
    Public Overloads Function add(ByVal x As Integer, ByVal y As Integer) As Integer ' 2个整数相加
        Return x + y ' 返回整型结果
    End Function
    Public Overloads Function add(ByVal x As Double, ByVal y As Double) As Double ' 2个小数相加
        Return x + y ' 返回实型结果
    End Function
End Class
