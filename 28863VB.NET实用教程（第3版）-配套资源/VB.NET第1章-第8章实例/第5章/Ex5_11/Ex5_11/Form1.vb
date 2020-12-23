Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MyControl As Control
        For Each MyControl In Me.Controls
            ListBox1.Items.Add(MyControl.Name)
        Next MyControl
    End Sub
End Class
