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
        Me.LabA = New System.Windows.Forms.Label()
        Me.LabB = New System.Windows.Forms.Label()
        Me.LabC = New System.Windows.Forms.Label()
        Me.LabX1 = New System.Windows.Forms.Label()
        Me.LabX2 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabA
        '
        Me.LabA.AutoSize = True
        Me.LabA.Location = New System.Drawing.Point(92, 25)
        Me.LabA.Name = "LabA"
        Me.LabA.Size = New System.Drawing.Size(23, 12)
        Me.LabA.TabIndex = 0
        Me.LabA.Text = "a ="
        '
        'LabB
        '
        Me.LabB.AutoSize = True
        Me.LabB.Location = New System.Drawing.Point(92, 74)
        Me.LabB.Name = "LabB"
        Me.LabB.Size = New System.Drawing.Size(23, 12)
        Me.LabB.TabIndex = 1
        Me.LabB.Text = "b ="
        '
        'LabC
        '
        Me.LabC.AutoSize = True
        Me.LabC.Location = New System.Drawing.Point(92, 123)
        Me.LabC.Name = "LabC"
        Me.LabC.Size = New System.Drawing.Size(23, 12)
        Me.LabC.TabIndex = 2
        Me.LabC.Text = "c ="
        '
        'LabX1
        '
        Me.LabX1.AutoSize = True
        Me.LabX1.Location = New System.Drawing.Point(51, 173)
        Me.LabX1.Name = "LabX1"
        Me.LabX1.Size = New System.Drawing.Size(29, 12)
        Me.LabX1.TabIndex = 3
        Me.LabX1.Text = "x1 ="
        '
        'LabX2
        '
        Me.LabX2.AutoSize = True
        Me.LabX2.Location = New System.Drawing.Point(163, 173)
        Me.LabX2.Name = "LabX2"
        Me.LabX2.Size = New System.Drawing.Size(29, 12)
        Me.LabX2.TabIndex = 4
        Me.LabX2.Text = "x2 ="
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(131, 21)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(70, 21)
        Me.txtA.TabIndex = 5
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(131, 70)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(70, 21)
        Me.txtB.TabIndex = 6
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(131, 119)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(70, 21)
        Me.txtC.TabIndex = 7
        '
        'txtX1
        '
        Me.txtX1.Location = New System.Drawing.Point(80, 169)
        Me.txtX1.Name = "txtX1"
        Me.txtX1.Size = New System.Drawing.Size(50, 21)
        Me.txtX1.TabIndex = 8
        '
        'txtX2
        '
        Me.txtX2.Location = New System.Drawing.Point(192, 169)
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(50, 21)
        Me.txtX2.TabIndex = 9
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(205, 231)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "计算"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtX2)
        Me.Controls.Add(Me.txtX1)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.LabX2)
        Me.Controls.Add(Me.LabX1)
        Me.Controls.Add(Me.LabC)
        Me.Controls.Add(Me.LabB)
        Me.Controls.Add(Me.LabA)
        Me.Name = "Form1"
        Me.Text = "计算方程根"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabA As System.Windows.Forms.Label
    Friend WithEvents LabB As System.Windows.Forms.Label
    Friend WithEvents LabC As System.Windows.Forms.Label
    Friend WithEvents LabX1 As System.Windows.Forms.Label
    Friend WithEvents LabX2 As System.Windows.Forms.Label
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtX1 As System.Windows.Forms.TextBox
    Friend WithEvents txtX2 As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button

End Class
