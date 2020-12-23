<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxUsr = New System.Windows.Forms.TextBox()
        Me.tbxPwd = New System.Windows.Forms.TextBox()
        Me.myDefaultBtn = New System.Windows.Forms.Button()
        Me.myCancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "用户名:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "密  码:"
        '
        'tbxUsr
        '
        Me.tbxUsr.Location = New System.Drawing.Point(123, 31)
        Me.tbxUsr.Name = "tbxUsr"
        Me.tbxUsr.Size = New System.Drawing.Size(100, 21)
        Me.tbxUsr.TabIndex = 2
        '
        'tbxPwd
        '
        Me.tbxPwd.Location = New System.Drawing.Point(123, 70)
        Me.tbxPwd.Name = "tbxPwd"
        Me.tbxPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPwd.Size = New System.Drawing.Size(100, 21)
        Me.tbxPwd.TabIndex = 3
        '
        'myDefaultBtn
        '
        Me.myDefaultBtn.Location = New System.Drawing.Point(68, 118)
        Me.myDefaultBtn.Name = "myDefaultBtn"
        Me.myDefaultBtn.Size = New System.Drawing.Size(75, 23)
        Me.myDefaultBtn.TabIndex = 4
        Me.myDefaultBtn.Text = "登录"
        Me.myDefaultBtn.UseVisualStyleBackColor = True
        '
        'myCancelBtn
        '
        Me.myCancelBtn.Location = New System.Drawing.Point(149, 118)
        Me.myCancelBtn.Name = "myCancelBtn"
        Me.myCancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.myCancelBtn.TabIndex = 5
        Me.myCancelBtn.Text = "重写"
        Me.myCancelBtn.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AcceptButton = Me.myDefaultBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 171)
        Me.Controls.Add(Me.myCancelBtn)
        Me.Controls.Add(Me.myDefaultBtn)
        Me.Controls.Add(Me.tbxPwd)
        Me.Controls.Add(Me.tbxUsr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "登录"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxUsr As System.Windows.Forms.TextBox
    Friend WithEvents tbxPwd As System.Windows.Forms.TextBox
    Friend WithEvents myDefaultBtn As System.Windows.Forms.Button
    Friend WithEvents myCancelBtn As System.Windows.Forms.Button
End Class
