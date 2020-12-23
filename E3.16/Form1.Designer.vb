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
        Me.labFile = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.labFileName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labFile
        '
        Me.labFile.AutoSize = True
        Me.labFile.Location = New System.Drawing.Point(94, 137)
        Me.labFile.Name = "labFile"
        Me.labFile.Size = New System.Drawing.Size(112, 15)
        Me.labFile.TabIndex = 0
        Me.labFile.Text = "请输入文件名："
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(446, 317)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(115, 26)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "输入文件名"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'labFileName
        '
        Me.labFileName.AutoSize = True
        Me.labFileName.Location = New System.Drawing.Point(290, 139)
        Me.labFileName.Name = "labFileName"
        Me.labFileName.Size = New System.Drawing.Size(0, 15)
        Me.labFileName.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.labFileName)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.labFile)
        Me.Name = "Form1"
        Me.Text = "输入对话框"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labFile As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents labFileName As Label
End Class
