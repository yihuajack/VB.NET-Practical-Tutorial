﻿Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OleDbDataAdapter1.Fill(XscjDataSet1)
    End Sub
End Class
