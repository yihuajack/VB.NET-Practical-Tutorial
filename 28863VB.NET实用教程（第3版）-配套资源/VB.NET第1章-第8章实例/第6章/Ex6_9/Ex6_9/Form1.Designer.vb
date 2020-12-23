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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.sysMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.quitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.importMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.importscoreMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.windowMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bookhelpMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sysMenuItem, Me.importMenuItem, Me.windowMenuItem, Me.helpMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.windowMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'sysMenuItem
        '
        Me.sysMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.quitMenuItem})
        Me.sysMenuItem.Name = "sysMenuItem"
        Me.sysMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.sysMenuItem.Text = "系统"
        '
        'quitMenuItem
        '
        Me.quitMenuItem.Name = "quitMenuItem"
        Me.quitMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.quitMenuItem.Text = "退出"
        '
        'importMenuItem
        '
        Me.importMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.importscoreMenuItem})
        Me.importMenuItem.Name = "importMenuItem"
        Me.importMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.importMenuItem.Text = "录入"
        '
        'importscoreMenuItem
        '
        Me.importscoreMenuItem.Name = "importscoreMenuItem"
        Me.importscoreMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.importscoreMenuItem.Text = "学生成绩"
        '
        'windowMenuItem
        '
        Me.windowMenuItem.Name = "windowMenuItem"
        Me.windowMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.windowMenuItem.Text = "窗口"
        '
        'helpMenuItem
        '
        Me.helpMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bookhelpMenuItem, Me.aboutMenuItem})
        Me.helpMenuItem.Name = "helpMenuItem"
        Me.helpMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.helpMenuItem.Text = "帮助"
        '
        'bookhelpMenuItem
        '
        Me.bookhelpMenuItem.Name = "bookhelpMenuItem"
        Me.bookhelpMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.bookhelpMenuItem.Text = "使用指南"
        '
        'aboutMenuItem
        '
        Me.aboutMenuItem.Name = "aboutMenuItem"
        Me.aboutMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.aboutMenuItem.Text = "关于"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "学生成绩管理系统"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents sysMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents quitMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents importMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents importscoreMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents windowMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helpMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bookhelpMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents aboutMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
