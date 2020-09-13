<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrans
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
        Me.LabN = New System.Windows.Forms.Label()
        Me.LabSelect = New System.Windows.Forms.Label()
        Me.LabResult = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.cmbSelect = New System.Windows.Forms.ComboBox()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabN
        '
        Me.LabN.AutoSize = True
        Me.LabN.Location = New System.Drawing.Point(114, 136)
        Me.LabN.Name = "LabN"
        Me.LabN.Size = New System.Drawing.Size(127, 15)
        Me.LabN.TabIndex = 0
        Me.LabN.Text = "请输入十进制数："
        '
        'LabSelect
        '
        Me.LabSelect.AutoSize = True
        Me.LabSelect.Location = New System.Drawing.Point(114, 202)
        Me.LabSelect.Name = "LabSelect"
        Me.LabSelect.Size = New System.Drawing.Size(82, 15)
        Me.LabSelect.TabIndex = 1
        Me.LabSelect.Text = "转换进制："
        '
        'LabResult
        '
        Me.LabResult.AutoSize = True
        Me.LabResult.Location = New System.Drawing.Point(114, 273)
        Me.LabResult.Name = "LabResult"
        Me.LabResult.Size = New System.Drawing.Size(82, 15)
        Me.LabResult.TabIndex = 2
        Me.LabResult.Text = "转换结果："
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(284, 125)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(121, 25)
        Me.txtInput.TabIndex = 3
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(284, 270)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(121, 25)
        Me.txtResult.TabIndex = 4
        '
        'cmbSelect
        '
        Me.cmbSelect.FormattingEnabled = True
        Me.cmbSelect.Items.AddRange(New Object() {"2", "8", "16"})
        Me.cmbSelect.Location = New System.Drawing.Point(284, 199)
        Me.cmbSelect.Name = "cmbSelect"
        Me.cmbSelect.Size = New System.Drawing.Size(121, 23)
        Me.cmbSelect.TabIndex = 5
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(139, 335)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 23)
        Me.cmdStart.TabIndex = 6
        Me.cmdStart.Text = "转换"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cmdEnd
        '
        Me.cmdEnd.Location = New System.Drawing.Point(311, 335)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnd.TabIndex = 7
        Me.cmdEnd.Text = "结束"
        Me.cmdEnd.UseVisualStyleBackColor = True
        '
        'frmTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.cmbSelect)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.LabResult)
        Me.Controls.Add(Me.LabSelect)
        Me.Controls.Add(Me.LabN)
        Me.Name = "frmTrans"
        Me.Text = "数制转换"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabN As Label
    Friend WithEvents LabSelect As Label
    Friend WithEvents LabResult As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents cmbSelect As ComboBox
    Friend WithEvents cmdStart As Button
    Friend WithEvents cmdEnd As Button
End Class
