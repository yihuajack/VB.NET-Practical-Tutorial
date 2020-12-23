Public Class Form1

    Private Sub Mnu_Edit_Cut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_Edit_Cut.Click
        TextBox1.Cut() ' 将选中的文本删除并复制到剪贴板上
    End Sub

    Private Sub Mnu_Edit_Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_Edit_Copy.Click
        TextBox1.Copy() ' 将选中的文本复制到剪贴板上
    End Sub

    Private Sub Mnu_Edit_Paste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_Edit_Paste.Click
        TextBox1.Paste() ' 将选中文本用剪贴板上的文本替换
    End Sub

    Private Sub Mnu_Edit_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_Edit_Del.Click
        TextBox1.SelectedText = "" ' 将选中的文本删除
    End Sub

    Private Sub Mnu_Edit_SelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_Edit_SelectAll.Click
        TextBox1.SelectAll() ' 选中TextBox1中的所有文本
    End Sub

    Private Sub Mnu_Edit_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_Edit_Date.Click
        TextBox1.SelectedText = Format(Now, "hh:mm:ss yyyy-MM-dd") ' 在文中框中添加日期和时间
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        If e.ClickedItem Is ToolStripButton1 Then
            TextBox1.Copy() ' ToolStripButton1 对应的是"复制"按钮
        ElseIf e.ClickedItem Is ToolStripButton2 Then
            TextBox1.Cut() ' ToolStriprButton2 对应的是"剪切"按钮
        ElseIf e.ClickedItem Is ToolStripButton3 Then
            TextBox1.Paste() ' ToolStripButton3 对应的是"粘贴"按钮
        ElseIf e.ClickedItem Is ToolStripButton4 Then
            TextBox1.SelectedText = "" ' ToolStripButton4 对应的是"删除"按钮
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Statusbar_txtlength.Text = "字符数：" & TextBox1.TextLength
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusBar_date.Text = "当前日期：" & Format(Now, "yyyy-MM-dd")
        StatusBar_time.Text = "当前时间：" & Format(Now, "hh:mm:ss")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start() ' 定时器开始启动
        Statusbar_txtlength.Text = "字符数：" & TextBox1.TextLength
    End Sub

    Private Sub Form1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        TextBox1.Width = Me.Width - 10
        ' 文本框的高度应设置为窗体的高度减去标题栏、状态栏、菜单栏和工具栏的高度
        TextBox1.Height = Me.Height - ToolStrip1.Height - StatusStrip1.Height - 60
    End Sub

    Private Sub Mnu_File_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_File_New.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Mnu_File_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_File_Open.Click
        Dim filename As String
        Dim f As System.IO.FileStream
        Dim r As System.IO.StreamReader
        OpenFileDialog1.ShowDialog() ' 调用对话框
        filename = OpenFileDialog1.FileName ' 获取选中的文件名
        f = New System.IO.FileStream(filename, IO.FileMode.Open, IO.FileAccess.Read)
        r = New System.IO.StreamReader(f)
        TextBox1.Text = r.ReadToEnd() ' 读文件
        r.Close()
    End Sub

    Private Sub Mnu_File_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_File_Save.Click
        Dim filename As String
        Dim f As System.IO.File
        Dim w As System.IO.StreamWriter
        SaveFileDialog1.ShowDialog() ' 调用对话框
        filename = SaveFileDialog1.FileName ' 获取选中的文件名
        w = f.CreateText(filename)
        w.Write(TextBox1.Text) ' 写文件
        w.Close()
    End Sub

    Private Sub Mnu_File_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_File_Exit.Click
        End ' 结束程序的运行
    End Sub
End Class
