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
        Me.DriveListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox()
        Me.DirListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.FileListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnNewDir = New System.Windows.Forms.Button()
        Me.btnMoveDir = New System.Windows.Forms.Button()
        Me.btnDelDir = New System.Windows.Forms.Button()
        Me.btnNewFile = New System.Windows.Forms.Button()
        Me.btnCopyFile = New System.Windows.Forms.Button()
        Me.btnMoveFile = New System.Windows.Forms.Button()
        Me.btnDelFile = New System.Windows.Forms.Button()
        Me.txtNewDirName = New System.Windows.Forms.TextBox()
        Me.txtDestDirName = New System.Windows.Forms.TextBox()
        Me.txtNewFileName = New System.Windows.Forms.TextBox()
        Me.txtDestFileName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DriveListBox1
        '
        Me.DriveListBox1.FormattingEnabled = True
        Me.DriveListBox1.Location = New System.Drawing.Point(12, 12)
        Me.DriveListBox1.Name = "DriveListBox1"
        Me.DriveListBox1.Size = New System.Drawing.Size(121, 22)
        Me.DriveListBox1.TabIndex = 0
        '
        'DirListBox1
        '
        Me.DirListBox1.FormattingEnabled = True
        Me.DirListBox1.IntegralHeight = False
        Me.DirListBox1.Location = New System.Drawing.Point(12, 34)
        Me.DirListBox1.Name = "DirListBox1"
        Me.DirListBox1.Size = New System.Drawing.Size(121, 306)
        Me.DirListBox1.TabIndex = 1
        '
        'FileListBox1
        '
        Me.FileListBox1.FormattingEnabled = True
        Me.FileListBox1.Location = New System.Drawing.Point(133, 12)
        Me.FileListBox1.Name = "FileListBox1"
        Me.FileListBox1.Pattern = "*.*"
        Me.FileListBox1.Size = New System.Drawing.Size(211, 328)
        Me.FileListBox1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDestDirName)
        Me.GroupBox1.Controls.Add(Me.txtNewDirName)
        Me.GroupBox1.Controls.Add(Me.btnNewDir)
        Me.GroupBox1.Controls.Add(Me.btnMoveDir)
        Me.GroupBox1.Controls.Add(Me.btnDelDir)
        Me.GroupBox1.Location = New System.Drawing.Point(350, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 139)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "文件夹操作"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtNewFileName)
        Me.GroupBox2.Controls.Add(Me.txtDestFileName)
        Me.GroupBox2.Controls.Add(Me.btnNewFile)
        Me.GroupBox2.Controls.Add(Me.btnCopyFile)
        Me.GroupBox2.Controls.Add(Me.btnMoveFile)
        Me.GroupBox2.Controls.Add(Me.btnDelFile)
        Me.GroupBox2.Location = New System.Drawing.Point(350, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 183)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "文件操作"
        '
        'btnNewDir
        '
        Me.btnNewDir.Location = New System.Drawing.Point(178, 32)
        Me.btnNewDir.Name = "btnNewDir"
        Me.btnNewDir.Size = New System.Drawing.Size(75, 23)
        Me.btnNewDir.TabIndex = 4
        Me.btnNewDir.Text = "新建文件夹"
        Me.btnNewDir.UseVisualStyleBackColor = True
        '
        'btnMoveDir
        '
        Me.btnMoveDir.Location = New System.Drawing.Point(178, 63)
        Me.btnMoveDir.Name = "btnMoveDir"
        Me.btnMoveDir.Size = New System.Drawing.Size(75, 23)
        Me.btnMoveDir.TabIndex = 5
        Me.btnMoveDir.Text = "移动文件夹"
        Me.btnMoveDir.UseVisualStyleBackColor = True
        '
        'btnDelDir
        '
        Me.btnDelDir.Location = New System.Drawing.Point(178, 94)
        Me.btnDelDir.Name = "btnDelDir"
        Me.btnDelDir.Size = New System.Drawing.Size(75, 23)
        Me.btnDelDir.TabIndex = 6
        Me.btnDelDir.Text = "删除文件夹"
        Me.btnDelDir.UseVisualStyleBackColor = True
        '
        'btnNewFile
        '
        Me.btnNewFile.Location = New System.Drawing.Point(178, 43)
        Me.btnNewFile.Name = "btnNewFile"
        Me.btnNewFile.Size = New System.Drawing.Size(75, 23)
        Me.btnNewFile.TabIndex = 7
        Me.btnNewFile.Text = "新建文件"
        Me.btnNewFile.UseVisualStyleBackColor = True
        '
        'btnCopyFile
        '
        Me.btnCopyFile.Location = New System.Drawing.Point(178, 74)
        Me.btnCopyFile.Name = "btnCopyFile"
        Me.btnCopyFile.Size = New System.Drawing.Size(75, 23)
        Me.btnCopyFile.TabIndex = 8
        Me.btnCopyFile.Text = "复制文件"
        Me.btnCopyFile.UseVisualStyleBackColor = True
        '
        'btnMoveFile
        '
        Me.btnMoveFile.Location = New System.Drawing.Point(178, 105)
        Me.btnMoveFile.Name = "btnMoveFile"
        Me.btnMoveFile.Size = New System.Drawing.Size(75, 23)
        Me.btnMoveFile.TabIndex = 9
        Me.btnMoveFile.Text = "移动文件"
        Me.btnMoveFile.UseVisualStyleBackColor = True
        '
        'btnDelFile
        '
        Me.btnDelFile.Location = New System.Drawing.Point(178, 136)
        Me.btnDelFile.Name = "btnDelFile"
        Me.btnDelFile.Size = New System.Drawing.Size(75, 23)
        Me.btnDelFile.TabIndex = 10
        Me.btnDelFile.Text = "删除文件"
        Me.btnDelFile.UseVisualStyleBackColor = True
        '
        'txtNewDirName
        '
        Me.txtNewDirName.Location = New System.Drawing.Point(23, 44)
        Me.txtNewDirName.Name = "txtNewDirName"
        Me.txtNewDirName.Size = New System.Drawing.Size(140, 21)
        Me.txtNewDirName.TabIndex = 7
        '
        'txtDestDirName
        '
        Me.txtDestDirName.Location = New System.Drawing.Point(23, 93)
        Me.txtDestDirName.Name = "txtDestDirName"
        Me.txtDestDirName.Size = New System.Drawing.Size(140, 21)
        Me.txtDestDirName.TabIndex = 8
        '
        'txtNewFileName
        '
        Me.txtNewFileName.Location = New System.Drawing.Point(23, 62)
        Me.txtNewFileName.Name = "txtNewFileName"
        Me.txtNewFileName.Size = New System.Drawing.Size(140, 21)
        Me.txtNewFileName.TabIndex = 9
        '
        'txtDestFileName
        '
        Me.txtDestFileName.Location = New System.Drawing.Point(23, 127)
        Me.txtDestFileName.Name = "txtDestFileName"
        Me.txtDestFileName.Size = New System.Drawing.Size(140, 21)
        Me.txtDestFileName.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "新建文件夹名："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "目标文件夹："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "新建文件名："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "目标文件："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 350)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FileListBox1)
        Me.Controls.Add(Me.DirListBox1)
        Me.Controls.Add(Me.DriveListBox1)
        Me.Name = "Form1"
        Me.Text = "文件夹、文件操作示例"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DriveListBox1 As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents DirListBox1 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents FileListBox1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDestDirName As System.Windows.Forms.TextBox
    Friend WithEvents txtNewDirName As System.Windows.Forms.TextBox
    Friend WithEvents btnNewDir As System.Windows.Forms.Button
    Friend WithEvents btnMoveDir As System.Windows.Forms.Button
    Friend WithEvents btnDelDir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNewFileName As System.Windows.Forms.TextBox
    Friend WithEvents txtDestFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnNewFile As System.Windows.Forms.Button
    Friend WithEvents btnCopyFile As System.Windows.Forms.Button
    Friend WithEvents btnMoveFile As System.Windows.Forms.Button
    Friend WithEvents btnDelFile As System.Windows.Forms.Button

End Class
