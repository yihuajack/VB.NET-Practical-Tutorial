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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.sysMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.quitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectinfoMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.updateMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.updateinfoMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.importMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.inportscoreMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.windowMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cascadeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.horizonMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.verticalMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bookhelpMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sysMenuItem, Me.selectMenuItem, Me.updateMenuItem, Me.importMenuItem, Me.windowMenuItem, Me.helpMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(479, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'sysMenuItem
        '
        Me.sysMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.quitMenuItem})
        Me.sysMenuItem.Name = "sysMenuItem"
        Me.sysMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.sysMenuItem.Text = "系统(&S)"
        '
        'quitMenuItem
        '
        Me.quitMenuItem.Image = Global.XsCjMagemnt.My.Resources.Resources.quit
        Me.quitMenuItem.Name = "quitMenuItem"
        Me.quitMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.quitMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.quitMenuItem.Text = "退出"
        '
        'selectMenuItem
        '
        Me.selectMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.selectinfoMenuItem})
        Me.selectMenuItem.Name = "selectMenuItem"
        Me.selectMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.selectMenuItem.Text = "查询(&Q)"
        '
        'selectinfoMenuItem
        '
        Me.selectinfoMenuItem.Image = Global.XsCjMagemnt.My.Resources.Resources.selectinfo
        Me.selectinfoMenuItem.Name = "selectinfoMenuItem"
        Me.selectinfoMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.selectinfoMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.selectinfoMenuItem.Text = "学生信息"
        '
        'updateMenuItem
        '
        Me.updateMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.updateinfoMenuItem})
        Me.updateMenuItem.Name = "updateMenuItem"
        Me.updateMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.updateMenuItem.Text = "修改(&E)"
        '
        'updateinfoMenuItem
        '
        Me.updateinfoMenuItem.Image = Global.XsCjMagemnt.My.Resources.Resources.updateinfo
        Me.updateinfoMenuItem.Name = "updateinfoMenuItem"
        Me.updateinfoMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.updateinfoMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.updateinfoMenuItem.Text = "学生信息"
        '
        'importMenuItem
        '
        Me.importMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inportscoreMenuItem})
        Me.importMenuItem.Name = "importMenuItem"
        Me.importMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.importMenuItem.Text = "录入(&I)"
        '
        'inportscoreMenuItem
        '
        Me.inportscoreMenuItem.Image = Global.XsCjMagemnt.My.Resources.Resources.inportscore
        Me.inportscoreMenuItem.Name = "inportscoreMenuItem"
        Me.inportscoreMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.inportscoreMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.inportscoreMenuItem.Text = "学生成绩"
        '
        'windowMenuItem
        '
        Me.windowMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cascadeMenuItem, Me.horizonMenuItem, Me.verticalMenuItem})
        Me.windowMenuItem.Name = "windowMenuItem"
        Me.windowMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.windowMenuItem.Text = "窗口"
        '
        'cascadeMenuItem
        '
        Me.cascadeMenuItem.Name = "cascadeMenuItem"
        Me.cascadeMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.cascadeMenuItem.Text = "层叠"
        '
        'horizonMenuItem
        '
        Me.horizonMenuItem.Name = "horizonMenuItem"
        Me.horizonMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.horizonMenuItem.Text = "水平平铺"
        '
        'verticalMenuItem
        '
        Me.verticalMenuItem.Image = Global.XsCjMagemnt.My.Resources.Resources.vertical
        Me.verticalMenuItem.Name = "verticalMenuItem"
        Me.verticalMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.verticalMenuItem.Text = "垂直平铺"
        '
        'helpMenuItem
        '
        Me.helpMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bookhelpMenuItem, Me.aboutMenuItem})
        Me.helpMenuItem.Name = "helpMenuItem"
        Me.helpMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.helpMenuItem.Text = "帮助(&H)"
        '
        'bookhelpMenuItem
        '
        Me.bookhelpMenuItem.Name = "bookhelpMenuItem"
        Me.bookhelpMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.bookhelpMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.bookhelpMenuItem.Text = "使用指南"
        '
        'aboutMenuItem
        '
        Me.aboutMenuItem.Image = Global.XsCjMagemnt.My.Resources.Resources.about
        Me.aboutMenuItem.Name = "aboutMenuItem"
        Me.aboutMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.aboutMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.aboutMenuItem.Text = "关于"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripSeparator4, Me.ToolStripButton5, Me.ToolStripSeparator5, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(479, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "退出"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "查询"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "信息维护"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "成绩录入"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "垂直平铺"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "关于"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 345)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "学生成绩管理系统"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents sysMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents quitMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents selectMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents selectinfoMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents updateMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents updateinfoMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents importMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents inportscoreMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents windowMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cascadeMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents horizonMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents verticalMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helpMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bookhelpMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents aboutMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton

End Class
