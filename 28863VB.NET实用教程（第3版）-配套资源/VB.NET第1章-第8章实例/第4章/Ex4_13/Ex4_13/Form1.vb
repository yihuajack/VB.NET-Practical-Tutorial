Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.InitialDirectory = "C:\Documents and Settings\Administrator\桌面"
        OpenFileDialog1.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim filename As String
        Dim f As System.IO.FileStream
        Dim myStream As System.IO.StreamReader
        filename = OpenFileDialog1.FileName
        If Not (filename Is Nothing) Then
            ' 以下代码使用文件流对象读取文件内容
            f = New System.IO.FileStream(filename, IO.FileMode.Open, IO.FileAccess.Read)
            myStream = New System.IO.StreamReader(f)
            TextBox1.Text = myStream.ReadToEnd()
            myStream.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SaveFileDialog1.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim filename As String
        Dim f As System.IO.File
        Dim w As System.IO.StreamWriter
        filename = SaveFileDialog1.FileName
        If Not (filename Is Nothing) Then
            w = f.CreateText(filename)
            w.Write(TextBox1.Text)
            w.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then     ' 调用颜色对话框
            TextBox1.BackColor = ColorDialog1.Color             ' 改变文本框的背景颜色
        End If
    End Sub
    ' 单击【应用】按钮时触发本事件
    Private Sub FontDialog1_Apply(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontDialog1.Apply
        TextBox1.Font = FontDialog1.Font                        ' 设置文本框的字体
        TextBox1.ForeColor = FontDialog1.Color                  ' 设置文本框字体的颜色
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FontDialog1.ShowApply = True                            ' 设置文本框是否显示【应用】按钮
        FontDialog1.ShowColor = True                            ' 设置文本框是否显示颜色框
        FontDialog1.ShowHelp = True                             ' 设置文本框是否显示帮助
        If FontDialog1.ShowDialog = DialogResult.OK Then        ' 判定是否按下了【确定】按钮
            TextBox1.Font = FontDialog1.Font                    ' 设置文本框的字体
            TextBox1.ForeColor = FontDialog1.Color              ' 设置文本框字体的颜色
        End If
    End Sub
End Class
