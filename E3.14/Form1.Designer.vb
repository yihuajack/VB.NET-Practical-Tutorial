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
        Me.LabInput.Location = New System.Drawing.Point(203, 192)
        Me.LabInput.Name = "LabInput"
        Me.LabInput.Size = New System.Drawing.Size(52, 15)
        Me.LabInput.TabIndex = 0
        Me.LabInput.Text = "原文："
        '
        'LabOutput
        '
        Me.LabOutput.AutoSize = True
        Me.LabOutput.Location = New System.Drawing.Point(201, 243)
        Me.LabOutput.Name = "LabOutput"
        Me.LabOutput.Size = New System.Drawing.Size(52, 15)
        Me.LabOutput.TabIndex = 1
        Me.LabOutput.Text = "密文："
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(307, 189)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(69, 25)
        Me.txtInput.TabIndex = 2
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(307, 233)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(69, 25)
        Me.txtOutput.TabIndex = 3
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(454, 334)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(68, 25)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "开始"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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

    Friend WithEvents LabInput As Label
    Friend WithEvents LabOutput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnStart As Button
End Class
