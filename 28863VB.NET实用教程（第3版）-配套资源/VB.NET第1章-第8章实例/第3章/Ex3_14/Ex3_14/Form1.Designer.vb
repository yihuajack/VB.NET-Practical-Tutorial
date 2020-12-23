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
        Me.LabInput = New System.Windows.Forms.Label()
        Me.LabOutput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabInput
        '
        Me.LabInput.AutoSize = True
        Me.LabInput.Location = New System.Drawing.Point(68, 41)
        Me.LabInput.Name = "LabInput"
        Me.LabInput.Size = New System.Drawing.Size(41, 12)
        Me.LabInput.TabIndex = 0
        Me.LabInput.Text = "原文："
        '
        'LabOutput
        '
        Me.LabOutput.AutoSize = True
        Me.LabOutput.Location = New System.Drawing.Point(68, 85)
        Me.LabOutput.Name = "LabOutput"
        Me.LabOutput.Size = New System.Drawing.Size(41, 12)
        Me.LabOutput.TabIndex = 1
        Me.LabOutput.Text = "密文："
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(125, 37)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 21)
        Me.txtInput.TabIndex = 2
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(125, 81)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(100, 21)
        Me.txtOutput.TabIndex = 3
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(189, 131)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "开始"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 166)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.LabOutput)
        Me.Controls.Add(Me.LabInput)
        Me.Name = "Form1"
        Me.Text = "加密电文"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabInput As System.Windows.Forms.Label
    Friend WithEvents LabOutput As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button

End Class
