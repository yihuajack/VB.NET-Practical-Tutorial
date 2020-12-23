Public Class myTextBox

    Private Sub myTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim inputkey As Integer
        inputkey = Asc(e.KeyChar)
        Select Case inputkey
            Case 65 To 90, 97 To 122 ' 大写、小写英文字母

            Case Else ' 其他情况
                inputkey = 0
        End Select
        If inputkey = 0 Then
            e.Handled = True ' 忽略
        Else
            e.Handled = False ' 响应
        End If
    End Sub
End Class
