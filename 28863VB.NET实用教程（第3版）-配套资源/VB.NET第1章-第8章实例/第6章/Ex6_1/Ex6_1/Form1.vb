Public Class FormOpacity

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Me.Opacity += 0.1
        'Me.Location = New Point(100, 100)
    End Sub

    Private Sub BtnSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSub.Click
        If Me.Opacity > 0.2 Then
            Me.Opacity -= 0.1
        Else
            Me.Opacity = 1
        End If
        'Me.Left = 300
        'Me.TopMost = True
    End Sub
End Class
