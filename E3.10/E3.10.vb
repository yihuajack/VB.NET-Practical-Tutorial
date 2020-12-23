Dim i As Integer, Sum As Integer
Sum = 0
For i = 100 To 1 Step -1
    Sum = Sum + i
    If Sum >= 5000 Then Exit For                '当和大于等于5000时跳出循环
Next i