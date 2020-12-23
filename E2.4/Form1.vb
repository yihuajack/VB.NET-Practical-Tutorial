Public Class Form1
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.SelectAll()                            '选中TextBox1中的所有文本
        TextBox1.Copy()                                 '将选中的文本复制到剪贴板上
        TextBox2.Clear()                                '将TextBox2中的所有文本删除
        TextBox2.Paste()                                '将剪贴板中的文本粘贴到TextBox2中
        TextBox1.SelectionStart = Len(TextBox1.Text)    '取消TextBox1文本的选中状态
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Clear()                                '清空TextBox1的内容
        TextBox2.Clear()                                '清空TextBox2的内容
    End Sub
End Class
