﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Browser
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rtbxStudentInfo = New System.Windows.Forms.RichTextBox()
        Me.myReturnBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'rtbxStudentInfo
        '
        Me.rtbxStudentInfo.BackColor = System.Drawing.Color.Silver
        Me.rtbxStudentInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbxStudentInfo.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rtbxStudentInfo.Location = New System.Drawing.Point(12, 105)
        Me.rtbxStudentInfo.Name = "rtbxStudentInfo"
        Me.rtbxStudentInfo.ReadOnly = True
        Me.rtbxStudentInfo.Size = New System.Drawing.Size(405, 259)
        Me.rtbxStudentInfo.TabIndex = 1
        Me.rtbxStudentInfo.Text = ""
        '
        'myReturnBtn
        '
        Me.myReturnBtn.Location = New System.Drawing.Point(342, 370)
        Me.myReturnBtn.Name = "myReturnBtn"
        Me.myReturnBtn.Size = New System.Drawing.Size(75, 23)
        Me.myReturnBtn.TabIndex = 2
        Me.myReturnBtn.Text = "返回"
        Me.myReturnBtn.UseVisualStyleBackColor = True
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 402)
        Me.Controls.Add(Me.myReturnBtn)
        Me.Controls.Add(Me.rtbxStudentInfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Browser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "预览"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rtbxStudentInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents myReturnBtn As System.Windows.Forms.Button
End Class
