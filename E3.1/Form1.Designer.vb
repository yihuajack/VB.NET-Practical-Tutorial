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
        Me.labF = New System.Windows.Forms.Label()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labF
        '
        Me.labF.AutoSize = True
        Me.labF.Location = New System.Drawing.Point(235, 92)
        Me.labF.Name = "labF"
        Me.labF.Size = New System.Drawing.Size(98, 15)
        Me.labF.TabIndex = 0
        Me.labF.Text = "华氏温度：78"
        '
        'txtTemperature
        '
        Me.txtTemperature.Location = New System.Drawing.Point(254, 174)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(159, 25)
        Me.txtTemperature.TabIndex = 1
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(310, 286)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(133, 41)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "计算"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.labF)
        Me.Name = "Form1"
        Me.Text = "计算温度"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labF As Label
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents btnStart As Button
End Class
