<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Mnu_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_File_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_File_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_File_Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Mnu_File_SetPaper = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_File_Print = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Mnu_File_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Edit_Cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Edit_Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Edit_Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Edit_Del = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Mnu_Edit_SelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Edit_Date = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.撤消ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.剪切ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Statusbar_txtlength = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBar_date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBar_time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenu1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_File, Me.Mnu_Edit, Me.Mnu_About})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(321, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Mnu_File
        '
        Me.Mnu_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_File_New, Me.Mnu_File_Open, Me.Mnu_File_Save, Me.ToolStripSeparator1, Me.Mnu_File_SetPaper, Me.Mnu_File_Print, Me.ToolStripSeparator2, Me.Mnu_File_Exit})
        Me.Mnu_File.Name = "Mnu_File"
        Me.Mnu_File.Size = New System.Drawing.Size(57, 20)
        Me.Mnu_File.Text = "文件(&F)"
        '
        'Mnu_File_New
        '
        Me.Mnu_File_New.Name = "Mnu_File_New"
        Me.Mnu_File_New.Size = New System.Drawing.Size(152, 22)
        Me.Mnu_File_New.Text = "新建"
        '
        'Mnu_File_Open
        '
        Me.Mnu_File_Open.Name = "Mnu_File_Open"
        Me.Mnu_File_Open.Size = New System.Drawing.Size(152, 22)
        Me.Mnu_File_Open.Text = "打开"
        '
        'Mnu_File_Save
        '
        Me.Mnu_File_Save.Name = "Mnu_File_Save"
        Me.Mnu_File_Save.Size = New System.Drawing.Size(152, 22)
        Me.Mnu_File_Save.Text = "保存"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'Mnu_File_SetPaper
        '
        Me.Mnu_File_SetPaper.Name = "Mnu_File_SetPaper"
        Me.Mnu_File_SetPaper.Size = New System.Drawing.Size(152, 22)
        Me.Mnu_File_SetPaper.Text = "页面设置"
        '
        'Mnu_File_Print
        '
        Me.Mnu_File_Print.Name = "Mnu_File_Print"
        Me.Mnu_File_Print.Size = New System.Drawing.Size(152, 22)
        Me.Mnu_File_Print.Text = "打印"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'Mnu_File_Exit
        '
        Me.Mnu_File_Exit.Name = "Mnu_File_Exit"
        Me.Mnu_File_Exit.Size = New System.Drawing.Size(152, 22)
        Me.Mnu_File_Exit.Text = "退出"
        '
        'Mnu_Edit
        '
        Me.Mnu_Edit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_Edit_Cut, Me.Mnu_Edit_Copy, Me.Mnu_Edit_Paste, Me.Mnu_Edit_Del, Me.ToolStripSeparator3, Me.Mnu_Edit_SelectAll, Me.Mnu_Edit_Date})
        Me.Mnu_Edit.Name = "Mnu_Edit"
        Me.Mnu_Edit.Size = New System.Drawing.Size(57, 20)
        Me.Mnu_Edit.Text = "编辑(&E)"
        '
        'Mnu_Edit_Cut
        '
        Me.Mnu_Edit_Cut.Name = "Mnu_Edit_Cut"
        Me.Mnu_Edit_Cut.Size = New System.Drawing.Size(152, 22)
        Me.Mnu_Edit_Cut.Text = "剪切"
        '
        'Mnu_Edit_Copy
        '
        Me.Mnu_Edit_Copy.Name = "Mnu_Edit_Copy"
        Me.Mnu_Edit_Copy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.Mnu_Edit_Copy.Size = New System.Drawing.Size(152, 22)
        Me.Mnu_Edit_Copy.Text = "复制"
        '
        'Mnu_Edit_Paste
        '
        Me.Mnu_Edit_Paste.Name = "Mnu_Edit_Paste"
        Me.Mnu_Edit_Paste.Size = New System.Drawing.Size(152, 22)
        Me.Mnu_Edit_Paste.Text = "粘贴"
        '
        'Mnu_Edit_Del
        '
        Me.Mnu_Edit_Del.Name = "Mnu_Edit_Del"
        Me.Mnu_Edit_Del.Size = New System.Drawing.Size(152, 22)
        Me.Mnu_Edit_Del.Text = "删除"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'Mnu_Edit_SelectAll
        '
        Me.Mnu_Edit_SelectAll.Name = "Mnu_Edit_SelectAll"
        Me.Mnu_Edit_SelectAll.Size = New System.Drawing.Size(152, 22)
        Me.Mnu_Edit_SelectAll.Text = "全选"
        '
        'Mnu_Edit_Date
        '
        Me.Mnu_Edit_Date.Name = "Mnu_Edit_Date"
        Me.Mnu_Edit_Date.Size = New System.Drawing.Size(152, 22)
        Me.Mnu_Edit_Date.Text = "时间/日期"
        '
        'Mnu_About
        '
        Me.Mnu_About.Name = "Mnu_About"
        Me.Mnu_About.Size = New System.Drawing.Size(58, 20)
        Me.Mnu_About.Text = "关于(&A)"
        '
        'TextBox1
        '
        Me.TextBox1.ContextMenuStrip = Me.ContextMenu1
        Me.TextBox1.Location = New System.Drawing.Point(0, 52)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(309, 189)
        Me.TextBox1.TabIndex = 1
        '
        'ContextMenu1
        '
        Me.ContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.撤消ToolStripMenuItem, Me.复制ToolStripMenuItem, Me.剪切ToolStripMenuItem, Me.粘贴ToolStripMenuItem, Me.删除ToolStripMenuItem})
        Me.ContextMenu1.Name = "ContextMenu1"
        Me.ContextMenu1.Size = New System.Drawing.Size(99, 114)
        '
        '撤消ToolStripMenuItem
        '
        Me.撤消ToolStripMenuItem.Name = "撤消ToolStripMenuItem"
        Me.撤消ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.撤消ToolStripMenuItem.Text = "撤消"
        '
        '复制ToolStripMenuItem
        '
        Me.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem"
        Me.复制ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.复制ToolStripMenuItem.Text = "复制"
        '
        '剪切ToolStripMenuItem
        '
        Me.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem"
        Me.剪切ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.剪切ToolStripMenuItem.Text = "剪切"
        '
        '粘贴ToolStripMenuItem
        '
        Me.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem"
        Me.粘贴ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.粘贴ToolStripMenuItem.Text = "粘贴"
        '
        '删除ToolStripMenuItem
        '
        Me.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem"
        Me.删除ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.删除ToolStripMenuItem.Text = "删除"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(321, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton1.Text = "复制"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton2.Text = "剪切"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton3.Text = "粘贴"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton4.Text = "删除"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Statusbar_txtlength, Me.StatusBar_date, Me.StatusBar_time})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 244)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(321, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Statusbar_txtlength
        '
        Me.Statusbar_txtlength.Name = "Statusbar_txtlength"
        Me.Statusbar_txtlength.Size = New System.Drawing.Size(37, 17)
        Me.Statusbar_txtlength.Text = "length"
        '
        'StatusBar_date
        '
        Me.StatusBar_date.Name = "StatusBar_date"
        Me.StatusBar_date.Size = New System.Drawing.Size(29, 17)
        Me.StatusBar_date.Text = "date"
        '
        'StatusBar_time
        '
        Me.StatusBar_time.Name = "StatusBar_time"
        Me.StatusBar_time.Size = New System.Drawing.Size(27, 17)
        Me.StatusBar_time.Text = "time"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 266)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "记事本"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenu1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Mnu_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_File_New As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_File_Open As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_File_Save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Mnu_File_SetPaper As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_File_Print As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Mnu_File_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_Edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_Edit_Cut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_Edit_Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_Edit_Paste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_Edit_Del As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Mnu_Edit_SelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_Edit_Date As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 撤消ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 复制ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 剪切ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 粘贴ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Statusbar_txtlength As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusBar_date As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusBar_time As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
