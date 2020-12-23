'  引入名称空间System.IO
Imports System.IO
Public Class Form1

    Private Sub btnSelFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelFile.Click
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1 ' 指定*.txt是默认过滤器。
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtFileName.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnReadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadFile.Click
        If txtFileName.Text <> "" Then ' 用户选择了一个文件。
            Dim fs As FileStream
            fs = New FileStream(txtFileName.Text, FileMode.OpenOrCreate, FileAccess.Read)
            Dim sr As StreamReader
            sr = New StreamReader(fs)
            txtContent.Text = sr.ReadToEnd ' 读取全部数据放入文本框。
            sr.Close() ' 关闭StreamReader对象。
            fs.Close() ' 关闭FileStream对象。
        End If
    End Sub

    Private Sub btnWriteFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteFile.Click
        If txtFileName.Text <> "" Then
            Dim i As Integer
            Dim s As String
            Dim fs As FileStream
            fs = New FileStream(txtFileName.Text, FileMode.OpenOrCreate, FileAccess.ReadWrite)
            Dim sw As StreamWriter
            sw = New StreamWriter(fs) ' 以改写方式创建StreamWriter对象。
            For i = 0 To txtContent.Lines.Length - 1 ' 循环取多行文本框中的数据行。
                s = txtContent.Lines.GetValue(i) ' 取一行数据。
                sw.WriteLine(s) ' 将一行数据写入文件缓冲区。
            Next i
            sw.Flush() ' 将文件缓冲区数据写入文件。
            sw.Close() ' 关闭StreamWriter对象。
            fs.Close() ' 关闭FileStream对象。
        End If
    End Sub
End Class
