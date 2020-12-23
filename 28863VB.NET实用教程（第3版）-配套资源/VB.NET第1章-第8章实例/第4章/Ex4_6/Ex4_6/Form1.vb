Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)           '将文本框中的内容添加到列表框
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListBox1.Items.Count = 0 Then            '如果列表框中没内容则给出提示
            MsgBox("没有条目可以删除！")
        Else
            ListBox1.Items.RemoveAt(0)              '如果列表框中有内容，则删除第一项
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        MsgBox(ListBox1.SelectedItem)               '显示单击的列表条目
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End                                         '结束程序的运行
    End Sub
End Class
