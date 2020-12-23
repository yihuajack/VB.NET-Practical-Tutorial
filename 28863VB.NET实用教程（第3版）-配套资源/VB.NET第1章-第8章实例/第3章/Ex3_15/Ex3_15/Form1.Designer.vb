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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labYear = New System.Windows.Forms.Label()
        Me.labMonth = New System.Windows.Forms.Label()
        Me.labDay = New System.Windows.Forms.Label()
        Me.labTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "今天是"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "年"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(193, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "月"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "日"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "现在是北京时间"
        '
        'labYear
        '
        Me.labYear.AutoSize = True
        Me.labYear.Location = New System.Drawing.Point(70, 49)
        Me.labYear.Name = "labYear"
        Me.labYear.Size = New System.Drawing.Size(53, 12)
        Me.labYear.TabIndex = 5
        Me.labYear.Text = "        "
        '
        'labMonth
        '
        Me.labMonth.AutoSize = True
        Me.labMonth.Location = New System.Drawing.Point(156, 49)
        Me.labMonth.Name = "labMonth"
        Me.labMonth.Size = New System.Drawing.Size(29, 12)
        Me.labMonth.TabIndex = 6
        Me.labMonth.Text = "    "
        '
        'labDay
        '
        Me.labDay.AutoSize = True
        Me.labDay.Location = New System.Drawing.Point(218, 49)
        Me.labDay.Name = "labDay"
        Me.labDay.Size = New System.Drawing.Size(29, 12)
        Me.labDay.TabIndex = 7
        Me.labDay.Text = "    "
        '
        'labTime
        '
        Me.labTime.AutoSize = True
        Me.labTime.Location = New System.Drawing.Point(126, 92)
        Me.labTime.Name = "labTime"
        Me.labTime.Size = New System.Drawing.Size(101, 12)
        Me.labTime.TabIndex = 8
        Me.labTime.Text = "                "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 166)
        Me.Controls.Add(Me.labTime)
        Me.Controls.Add(Me.labDay)
        Me.Controls.Add(Me.labMonth)
        Me.Controls.Add(Me.labYear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "日期时间"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents labYear As System.Windows.Forms.Label
    Friend WithEvents labMonth As System.Windows.Forms.Label
    Friend WithEvents labDay As System.Windows.Forms.Label
    Friend WithEvents labTime As System.Windows.Forms.Label

End Class
