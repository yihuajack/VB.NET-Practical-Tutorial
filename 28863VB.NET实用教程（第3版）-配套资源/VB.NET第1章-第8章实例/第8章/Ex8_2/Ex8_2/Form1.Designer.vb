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
        Me.btnSelFile = New System.Windows.Forms.Button()
        Me.btnReadFile = New System.Windows.Forms.Button()
        Me.btnWriteFile = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "请选择要读写的文件："
        '
        'btnSelFile
        '
        Me.btnSelFile.Location = New System.Drawing.Point(225, 33)
        Me.btnSelFile.Name = "btnSelFile"
        Me.btnSelFile.Size = New System.Drawing.Size(75, 23)
        Me.btnSelFile.TabIndex = 1
        Me.btnSelFile.Text = "选择文件"
        Me.btnSelFile.UseVisualStyleBackColor = True
        '
        'btnReadFile
        '
        Me.btnReadFile.Location = New System.Drawing.Point(241, 207)
        Me.btnReadFile.Name = "btnReadFile"
        Me.btnReadFile.Size = New System.Drawing.Size(75, 23)
        Me.btnReadFile.TabIndex = 2
        Me.btnReadFile.Text = "读文件"
        Me.btnReadFile.UseVisualStyleBackColor = True
        '
        'btnWriteFile
        '
        Me.btnWriteFile.Location = New System.Drawing.Point(241, 230)
        Me.btnWriteFile.Name = "btnWriteFile"
        Me.btnWriteFile.Size = New System.Drawing.Size(75, 23)
        Me.btnWriteFile.TabIndex = 3
        Me.btnWriteFile.Text = "写文件"
        Me.btnWriteFile.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(28, 34)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(197, 21)
        Me.txtFileName.TabIndex = 4
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(28, 55)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtContent.Size = New System.Drawing.Size(197, 199)
        Me.txtContent.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 266)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnWriteFile)
        Me.Controls.Add(Me.btnReadFile)
        Me.Controls.Add(Me.btnSelFile)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "文件读写示例"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSelFile As System.Windows.Forms.Button
    Friend WithEvents btnReadFile As System.Windows.Forms.Button
    Friend WithEvents btnWriteFile As System.Windows.Forms.Button
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
