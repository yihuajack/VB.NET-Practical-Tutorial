Public Class Browser
    Private Sub Browser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile(path)
        rtbxSudentInfo.Text = info
    End Sub
    Private Sub myReturnBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myReturnBtn.Click
        UpdateForm.Show()
        Me.Close()
    End Sub
End Class