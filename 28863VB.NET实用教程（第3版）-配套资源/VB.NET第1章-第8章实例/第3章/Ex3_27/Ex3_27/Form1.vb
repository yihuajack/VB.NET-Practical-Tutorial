Public Class frmTrans
    Dim Number As Integer, n As Integer                     ' 定义模块级变量Number、n
    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        ' 单击转换按钮，调用Trans过程转换
        Dim i As Integer
        Dim myChar(15) As String, Ch As String
        Dim Bin() As String
        For i = 0 To 9
            myChar(i) = Str(i)                      ' 将字符0～9赋值给数组myChar
        Next i
        For i = 0 To 5                              ' 将字符A～F赋值给数组myChar
            myChar(10 + i) = Chr(Asc("A") + i)
        Next i
        Call Trans(Bin, myChar)                     ' 调用Trans函数
        For i = UBound(Bin) To 1 Step -1
            Ch = Ch & Bin(i)
        Next i
        txtResult.Text = Ch                         ' 显示转换结果
    End Sub
    Private Sub Trans(ByRef Arry() As String, ByVal S() As String)         '  Arry数组采用传址方式
        ' 数制转换
        Dim r As Integer, k As Integer
        k = 0
        Do Until Number = 0
            r = Number Mod n
            k = k + 1
            ReDim Preserve Arry(k)
            Arry(k) = S(r)
            Number = Int(Number / n)
        Loop
    End Sub

    Private Sub cmdEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnd.Click
        End
    End Sub

    Private Sub frmTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        n = 2                                       ' 数制预设为2
    End Sub

    Private Sub cmbSelect_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSelect.SelectedValueChanged
        ' 通过组合框cmbSelect改变选择事件，选择转换数制，属性SelectedItem分别对应2、8和16。   			
        n = CInt(cmbSelect.SelectedItem)
    End Sub

    Private Sub txtInput_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInput.Leave
        Dim Response As Integer
        If IsNumeric(txtInput.Text) = True Then     ' 判断输入的是否为数值
            Number = Val(txtInput.Text)
        Else
            Response = MsgBox("输入数据出错！", vbOKOnly + vbCritical, "数据出错")
            txtInput.Focus()
        End If
    End Sub
End Class
