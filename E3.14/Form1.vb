Public Class Form1
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        '单击按钮
        Dim String1, String2, c As String
        Dim StrL, i As Integer
        String1 = txtInput.Text
        String2 = ""
        StrL = Len(String1)
        i = 1
        Do While i <= StrL
            c = Mid(String1, i, 1)
            If (c >= "a" And c <= "z") Or (c >= "A" And c <= "Z") Then
                c = Chr(Asc(c) + 4)
                If c > "Z" And Asc(c) <= Asc("Z") + 4 Or c > "z" Then
                    '当字母是最后4个时
                    c = Chr(Asc(c) - 26)
                End If
            End If
            String2 = String2 & c           '连接字符串
            i = i + 1
        Loop
        txtOutput.Text = String2
    End Sub
End Class
