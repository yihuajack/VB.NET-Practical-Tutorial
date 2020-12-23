<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOpacity
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
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSub = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(51, 59)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "增加透明度"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSub
        '
        Me.BtnSub.Location = New System.Drawing.Point(166, 59)
        Me.BtnSub.Name = "BtnSub"
        Me.BtnSub.Size = New System.Drawing.Size(75, 23)
        Me.BtnSub.TabIndex = 1
        Me.BtnSub.Text = "降低透明度"
        Me.BtnSub.UseVisualStyleBackColor = True
        '
        'FormOpacity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 140)
        Me.Controls.Add(Me.BtnSub)
        Me.Controls.Add(Me.BtnAdd)
        Me.Name = "FormOpacity"
        Me.Text = "可调节透明度的窗体"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnSub As System.Windows.Forms.Button

End Class
