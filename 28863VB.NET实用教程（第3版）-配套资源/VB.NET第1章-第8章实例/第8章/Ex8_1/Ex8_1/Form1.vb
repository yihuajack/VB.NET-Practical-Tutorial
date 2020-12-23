'  引入名称空间System.IO
Imports System.IO
Public Class Form1

    Private Sub DriveListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriveListBox1.SelectedIndexChanged
        DirListBox1.Path = DriveListBox1.Drive
    End Sub

    Private Sub DirListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirListBox1.SelectedIndexChanged
        FileListBox1.Path = DirListBox1.Path
    End Sub

    Private Sub btnNewDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewDir.Click
        Dim spath As String
        spath = DirListBox1.Path
        If txtNewDirName.Text = "" Or spath = "" Then
            MsgBox("请输入要新建的文件夹名！")
        Else
            Directory.CreateDirectory(spath & "\" & txtNewDirName.Text)
        End If
    End Sub

    Private Sub btnMoveDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveDir.Click
        Dim spath As String
        spath = DirListBox1.Path
        If spath = "" Then
            MsgBox("请先选择源文件夹！")
            Exit Sub
        End If
        If txtDestDirName.Text = "" Then
            MsgBox("请输入完整的目标文件夹名！")
            Exit Sub
        End If
        Try
            Directory.Move(spath, txtDestDirName.Text)
            MsgBox("移动文件夹成功！")
        Catch exp As ArgumentNullException
            MsgBox("给定路径无效！")
        Catch exp As System.Security.SecurityException
            MsgBox("调用者无权限！")
        Catch exp As ArgumentException
            MsgBox("给定路径为空或者有非法字符！")
        Catch exp As System.IO.IOException
            MsgBox("目标文件夹已存在或目标与源不在同一个卷！")
        End Try
    End Sub

    Private Sub btnDelDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelDir.Click
        Dim spath As String
        Dim flg As MsgBoxResult
        spath = DirListBox1.Path
        flg = MsgBox("确实要删除" & spath & "文件夹吗？", MsgBoxStyle.YesNo)
        If flg = MsgBoxResult.Yes Then
            Directory.Delete(spath)
        End If
    End Sub

    Private Sub btnNewFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewFile.Click
        Dim spath As String
        Dim ss As Stream
        spath = DirListBox1.Path
        If txtNewFileName.Text = "" Or spath = "" Then
            MsgBox("请输入要新建的文件名！")
        Else
            ss = File.Create(spath & "\" & txtNewFileName.Text)
            ss.Close()
        End If
    End Sub

    Private Sub btnMoveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveFile.Click
        Dim spath As String
        spath = DirListBox1.Path
        If FileListBox1.FileName = "" Then
            MsgBox("请先选择源文件！")
            Exit Sub
        End If
        If txtDestFileName.Text = "" Then
            MsgBox("请输入完整的目标文件名！")
            Exit Sub
        End If
        File.Move(spath & "\" & FileListBox1.FileName, txtDestFileName.Text)
    End Sub

    Private Sub btnCopyFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyFile.Click
        Dim spath As String
        spath = DirListBox1.Path
        If FileListBox1.FileName = "" Then
            MsgBox("请先选择源文件！")
            Exit Sub
        End If
        If txtDestFileName.Text = "" Then
            MsgBox("请输入完整的目标文件名！")
            Exit Sub
        End If
        File.Copy(spath & "\" & FileListBox1.FileName, txtDestFileName.Text)
    End Sub

    Private Sub btnDelFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelFile.Click
        Dim spath As String
        Dim flg As MsgBoxResult
        spath = FileListBox1.FileName
        flg = MsgBox("确实要删除" & DirListBox1.Path & "\" & spath & "文件吗？", _
         MsgBoxStyle.YesNo)
        If flg = MsgBoxResult.Yes Then
            File.Delete(DirListBox1.Path & "\" & spath)
        End If
    End Sub
End Class
