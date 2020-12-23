Public Class UpdateForm

    Private Sub mySubmitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mySubmitBtn.Click
        info = "学号: " + tbxId.Text + vbCrLf
        info += "姓名: " + tbxName.Text + vbCrLf
        For Each Control In gbxSex.Controls
            If Control.Checked Then
                info += "性别：" + Control.Text
            End If
        Next
        info += vbCrLf + "爱好: "
        For Each Control In gbxFavor.Controls
            If Control.Checked Then
                info += Control.Text + " "
            End If
        Next
        info += vbCrLf + "出生日期: " + DateTimePicker1.Text
        info += vbCrLf + "专    业: " + ComboBox1.Text
        Me.Hide()
        Browser.ShowDialog()
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        '首先清除所有现有项
        ListBox1.Items.Clear()
        '用Add方法插入新项
        ListBox1.Items.Add("2012年度校优秀团员")
        ListBox1.Items.Add("2012年度一等奖学金")
        '用Insert方法插入新项
        ListBox1.Items.Insert(2, "2012年度校运动会1000米游泳冠军")
        '使第二项选中
        ListBox1.SelectedIndex = 1
        '获得添加的记录数
        MsgBox("已添加奖惩记录" + ListBox1.Items.Count.ToString() + "条", , "提示")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabelNowTime.Text = String.Format("现在时间: {0}", DateTime.Now.ToLongTimeString())
        ToolStripProgressBar1.PerformStep()
        If ToolStripProgressBar1.Value = ToolStripProgressBar1.Maximum Then
            ToolStripProgressBar1.Value = ToolStripProgressBar1.Minimum
        End If
    End Sub

    Private Sub myOpenPictureBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myOpenPictureBtn.Click
        '设置文件对话框显示的初始目录
        OpenFileDialog1.InitialDirectory = "D:\My Documents\My Pictures"
        '设置当前选定筛选器字符串以决定对话框中"文档类型"选项
        OpenFileDialog1.Filter = "bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif|jpeg文件(*.jpg)|*.jpg"
        '设置对话框中当前选定筛选器的索引
        OpenFileDialog1.FilterIndex = 3
        '关闭对话框，还原当前的目录
        OpenFileDialog1.RestoreDirectory = True
        '设置对话框的标题
        OpenFileDialog1.Title = "选择学生照片"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            path = OpenFileDialog1.FileName '获取文件路径
        End If
        PictureBox1.Image = Image.FromFile(path) '加载照片
    End Sub
End Class