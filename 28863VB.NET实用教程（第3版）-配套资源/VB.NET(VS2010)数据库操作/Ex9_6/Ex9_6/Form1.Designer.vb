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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtStuXH = New System.Windows.Forms.TextBox()
        Me.txtStuXM = New System.Windows.Forms.TextBox()
        Me.txtStuZXF = New System.Windows.Forms.TextBox()
        Me.txtStuBZ = New System.Windows.Forms.TextBox()
        Me.cbxStuXB = New System.Windows.Forms.ComboBox()
        Me.cbxStuZYM = New System.Windows.Forms.ComboBox()
        Me.dtpStuCSSJ = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtXH = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(577, 185)
        Me.DataGridView1.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(280, 421)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "添加"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(387, 421)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "修改"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(494, 421)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "删除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtStuXH
        '
        Me.txtStuXH.Location = New System.Drawing.Point(69, 285)
        Me.txtStuXH.Name = "txtStuXH"
        Me.txtStuXH.Size = New System.Drawing.Size(100, 21)
        Me.txtStuXH.TabIndex = 4
        '
        'txtStuXM
        '
        Me.txtStuXM.Location = New System.Drawing.Point(69, 329)
        Me.txtStuXM.Name = "txtStuXM"
        Me.txtStuXM.Size = New System.Drawing.Size(100, 21)
        Me.txtStuXM.TabIndex = 5
        '
        'txtStuZXF
        '
        Me.txtStuZXF.Location = New System.Drawing.Point(69, 373)
        Me.txtStuZXF.Name = "txtStuZXF"
        Me.txtStuZXF.Size = New System.Drawing.Size(100, 21)
        Me.txtStuZXF.TabIndex = 6
        '
        'txtStuBZ
        '
        Me.txtStuBZ.Location = New System.Drawing.Point(419, 304)
        Me.txtStuBZ.Multiline = True
        Me.txtStuBZ.Name = "txtStuBZ"
        Me.txtStuBZ.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtStuBZ.Size = New System.Drawing.Size(166, 90)
        Me.txtStuBZ.TabIndex = 7
        '
        'cbxStuXB
        '
        Me.cbxStuXB.FormattingEnabled = True
        Me.cbxStuXB.Location = New System.Drawing.Point(267, 285)
        Me.cbxStuXB.Name = "cbxStuXB"
        Me.cbxStuXB.Size = New System.Drawing.Size(121, 20)
        Me.cbxStuXB.TabIndex = 8
        '
        'cbxStuZYM
        '
        Me.cbxStuZYM.FormattingEnabled = True
        Me.cbxStuZYM.Location = New System.Drawing.Point(267, 329)
        Me.cbxStuZYM.Name = "cbxStuZYM"
        Me.cbxStuZYM.Size = New System.Drawing.Size(121, 20)
        Me.cbxStuZYM.TabIndex = 9
        '
        'dtpStuCSSJ
        '
        Me.dtpStuCSSJ.Location = New System.Drawing.Point(267, 373)
        Me.dtpStuCSSJ.Name = "dtpStuCSSJ"
        Me.dtpStuCSSJ.Size = New System.Drawing.Size(121, 21)
        Me.dtpStuCSSJ.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "学号："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "姓名："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "总学分："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(202, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "性别："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "专业："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "出生日期："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(417, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 12)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "备注："
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TxtXH)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 64)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "输入查询条件"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 12)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "学号："
        '
        'TxtXH
        '
        Me.TxtXH.Location = New System.Drawing.Point(73, 22)
        Me.TxtXH.Name = "TxtXH"
        Me.TxtXH.Size = New System.Drawing.Size(100, 21)
        Me.TxtXH.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(173, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "查询"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 457)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpStuCSSJ)
        Me.Controls.Add(Me.cbxStuZYM)
        Me.Controls.Add(Me.cbxStuXB)
        Me.Controls.Add(Me.txtStuBZ)
        Me.Controls.Add(Me.txtStuZXF)
        Me.Controls.Add(Me.txtStuXM)
        Me.Controls.Add(Me.txtStuXH)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "学生信息维护"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtStuXH As System.Windows.Forms.TextBox
    Friend WithEvents txtStuXM As System.Windows.Forms.TextBox
    Friend WithEvents txtStuZXF As System.Windows.Forms.TextBox
    Friend WithEvents txtStuBZ As System.Windows.Forms.TextBox
    Friend WithEvents cbxStuXB As System.Windows.Forms.ComboBox
    Friend WithEvents cbxStuZYM As System.Windows.Forms.ComboBox
    Friend WithEvents dtpStuCSSJ As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtXH As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
