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
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtS2 = New System.Windows.Forms.TextBox()
        Me.txtS1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(566, 261)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(113, 26)
        Me.btnEnd.TabIndex = 11
        Me.btnEnd.Text = "结束"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(570, 162)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(110, 28)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "计算"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtS2
        '
        Me.txtS2.Location = New System.Drawing.Point(345, 263)
        Me.txtS2.Name = "txtS2"
        Me.txtS2.Size = New System.Drawing.Size(113, 25)
        Me.txtS2.TabIndex = 9
        '
        'txtS1
        '
        Me.txtS1.Location = New System.Drawing.Point(345, 168)
        Me.txtS1.Name = "txtS1"
        Me.txtS1.Size = New System.Drawing.Size(113, 25)
        Me.txtS1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "一班学生前3人的平均成绩："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "一班学生的平均成绩："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtS2)
        Me.Controls.Add(Me.txtS1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "计算平均成绩"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnd As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents txtS2 As TextBox
    Friend WithEvents txtS1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
