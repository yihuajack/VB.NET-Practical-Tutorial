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
        Me.rtbxSudentInfo = New System.Windows.Forms.RichTextBox()
        Me.myReturnBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(36, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 103)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'rtbxSudentInfo
        '
        Me.rtbxSudentInfo.Location = New System.Drawing.Point(36, 135)
        Me.rtbxSudentInfo.Name = "rtbxSudentInfo"
        Me.rtbxSudentInfo.Size = New System.Drawing.Size(738, 250)
        Me.rtbxSudentInfo.TabIndex = 1
        Me.rtbxSudentInfo.Text = ""
        '
        'myReturnBtn
        '
        Me.myReturnBtn.Location = New System.Drawing.Point(618, 408)
        Me.myReturnBtn.Name = "myReturnBtn"
        Me.myReturnBtn.Size = New System.Drawing.Size(75, 23)
        Me.myReturnBtn.TabIndex = 2
        Me.myReturnBtn.Text = "返回"
        Me.myReturnBtn.UseVisualStyleBackColor = True
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.myReturnBtn)
        Me.Controls.Add(Me.rtbxSudentInfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Browser"
        Me.Text = "预览"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rtbxSudentInfo As RichTextBox
    Friend WithEvents myReturnBtn As Button
End Class
