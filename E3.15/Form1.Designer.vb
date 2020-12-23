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
        Me.Label1.Location = New System.Drawing.Point(135, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "今天是"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "年"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(364, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "月"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(469, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "日"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "现在是北京时间"
        '
        'labYear
        '
        Me.labYear.AutoSize = True
        Me.labYear.Location = New System.Drawing.Point(205, 181)
        Me.labYear.Name = "labYear"
        Me.labYear.Size = New System.Drawing.Size(0, 15)
        Me.labYear.TabIndex = 8
        '
        'labMonth
        '
        Me.labMonth.AutoSize = True
        Me.labMonth.Location = New System.Drawing.Point(303, 181)
        Me.labMonth.Name = "labMonth"
        Me.labMonth.Size = New System.Drawing.Size(0, 15)
        Me.labMonth.TabIndex = 9
        '
        'labDay
        '
        Me.labDay.AutoSize = True
        Me.labDay.Location = New System.Drawing.Point(408, 181)
        Me.labDay.Name = "labDay"
        Me.labDay.Size = New System.Drawing.Size(0, 15)
        Me.labDay.TabIndex = 10
        '
        'labTime
        '
        Me.labTime.AutoSize = True
        Me.labTime.Location = New System.Drawing.Point(321, 253)
        Me.labTime.Name = "labTime"
        Me.labTime.Size = New System.Drawing.Size(0, 15)
        Me.labTime.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents labYear As Label
    Friend WithEvents labMonth As Label
    Friend WithEvents labDay As Label
    Friend WithEvents labTime As Label
End Class
