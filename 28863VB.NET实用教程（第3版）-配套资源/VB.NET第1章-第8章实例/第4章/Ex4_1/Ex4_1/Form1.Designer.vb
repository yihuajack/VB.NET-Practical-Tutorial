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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnImage = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'btnImage
        '
        Me.btnImage.BackColor = System.Drawing.Color.White
        Me.btnImage.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImage.ImageKey = "关闭.ico"
        Me.btnImage.ImageList = Me.ImageList1
        Me.btnImage.Location = New System.Drawing.Point(71, 68)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(90, 40)
        Me.btnImage.TabIndex = 0
        Me.btnImage.Text = "打开"
        Me.btnImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImage.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "关闭.ico")
        Me.ImageList1.Images.SetKeyName(1, "打开.ico")
        Me.ImageList1.Images.SetKeyName(2, "装入.ico")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 176)
        Me.Controls.Add(Me.btnImage)
        Me.Name = "Form1"
        Me.Text = "图片按钮"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnImage As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
