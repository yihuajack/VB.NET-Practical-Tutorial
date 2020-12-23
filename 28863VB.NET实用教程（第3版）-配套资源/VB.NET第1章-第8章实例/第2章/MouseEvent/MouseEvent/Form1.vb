Public Class Form1

    Private Sub Label1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        TextBox1.Text = TextBox1.Text + "MouseDown 事件" + vbCrLf
    End Sub

    Private Sub Label1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseUp
        TextBox1.Text = TextBox1.Text + "MouseUp 事件" + vbCrLf
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        TextBox1.Text = TextBox1.Text + "Click 事件" + vbCrLf
    End Sub

    Private Sub Label1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        TextBox1.Text = TextBox1.Text + "DoubleClick 事件" + vbCrLf
    End Sub
End Class
