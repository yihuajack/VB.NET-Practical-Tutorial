﻿Public Class Form1

    Private Sub CheckBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        TextBox1.Text = ""
        If CheckBox1.CheckState = CheckState.Checked Then
            TextBox1.Text = "你喜欢" & CheckBox1.Text
        End If
        If CheckBox2.CheckState = CheckState.Checked Then
            TextBox1.Text = TextBox1.Text & "你喜欢" & CheckBox2.Text
        End If
    End Sub

    Private Sub CheckBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        TextBox1.Text = ""
        If CheckBox1.CheckState = CheckState.Checked Then
            TextBox1.Text = "你喜欢" & CheckBox1.Text
        End If
        If CheckBox2.CheckState = CheckState.Checked Then
            TextBox1.Text = TextBox1.Text & "你喜欢" & CheckBox2.Text
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox1.Text = "你的性别为:" & RadioButton1.Text
        End If
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        TextBox1.Text = "你的性别为:" & RadioButton2.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GroupBox2.Visible Then
            GroupBox2.Visible = False
        Else
            GroupBox2.Visible = True
        End If
    End Sub
End Class
