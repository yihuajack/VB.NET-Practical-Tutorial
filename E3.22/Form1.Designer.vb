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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtResultA = New System.Windows.Forms.TextBox()
        Me.txtResultB = New System.Windows.Forms.TextBox()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtB)
        Me.GroupBox1.Controls.Add(Me.txtA)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "输入数据"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtResultB)
        Me.GroupBox2.Controls.Add(Me.txtResultA)
        Me.GroupBox2.Controls.Add(Me.txtY)
        Me.GroupBox2.Controls.Add(Me.txtX)
        Me.GroupBox2.Controls.Add(Me.txtMax)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(68, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 171)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "运行结果"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "a ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "b ="
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(64, 55)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(65, 25)
        Me.txtA.TabIndex = 2
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(222, 55)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(78, 25)
        Me.txtB.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "最大数 ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "x ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "y ="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "a ="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(177, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "b ="
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(171, 21)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(89, 25)
        Me.txtMax.TabIndex = 5
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(71, 62)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(60, 25)
        Me.txtX.TabIndex = 6
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(235, 62)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(69, 25)
        Me.txtY.TabIndex = 7
        '
        'txtResultA
        '
        Me.txtResultA.Location = New System.Drawing.Point(71, 111)
        Me.txtResultA.Name = "txtResultA"
        Me.txtResultA.Size = New System.Drawing.Size(59, 25)
        Me.txtResultA.TabIndex = 8
        '
        'txtResultB
        '
        Me.txtResultB.Location = New System.Drawing.Point(233, 109)
        Me.txtResultB.Name = "txtResultB"
        Me.txtResultB.Size = New System.Drawing.Size(70, 25)
        Me.txtResultB.TabIndex = 9
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(577, 325)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(60, 21)
        Me.cmdStart.TabIndex = 2
        Me.cmdStart.Text = "计算"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cmdEnd
        '
        Me.cmdEnd.Location = New System.Drawing.Point(574, 373)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(62, 21)
        Me.cmdEnd.TabIndex = 3
        Me.cmdEnd.Text = "结束"
        Me.cmdEnd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtResultB As TextBox
    Friend WithEvents txtResultA As TextBox
    Friend WithEvents txtY As TextBox
    Friend WithEvents txtX As TextBox
    Friend WithEvents txtMax As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdStart As Button
    Friend WithEvents cmdEnd As Button
End Class
