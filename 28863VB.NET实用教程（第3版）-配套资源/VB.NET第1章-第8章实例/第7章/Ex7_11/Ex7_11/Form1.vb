﻿Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "打开AVI文件"
        OpenFileDialog1.Filter = "avi 文件 (*.avi)|*.avi|所有文件 (*.*)|*.*"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
            AxWindowsMediaPlayer1.URL = TextBox1.Text ' 装入AVI
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play() ' 播放
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop() ' 停止播放
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub
End Class
