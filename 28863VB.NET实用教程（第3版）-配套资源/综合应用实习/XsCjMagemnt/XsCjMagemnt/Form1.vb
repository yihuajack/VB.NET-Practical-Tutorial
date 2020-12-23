Public Class Form1
    Public DBConnstr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJ;Integrated Security=True"
    '退出菜单
    Private Sub quitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitMenuItem.Click
        End
    End Sub
    '查询学生信息菜单
    Private Sub selectinfoMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectinfoMenuItem.Click
        Dim form2 As New Form2  ' 创建Form2窗体实例
        form2.MdiParent = Me    ' 设置form2为MDI子窗体
        form2.WindowState = FormWindowState.Normal ' 子窗体最大化显示
        form2.Show()
    End Sub
    '修改学生信息菜单
    Private Sub updateinfoMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateinfoMenuItem.Click
        Dim form3 As New Form3  ' 创建Form3窗体实例
        form3.MdiParent = Me    ' 设置form3为MDI子窗体
        form3.WindowState = FormWindowState.Normal ' 子窗体最大化显示
        form3.Show()
    End Sub
    '录入学生成绩菜单
    Private Sub inportscoreMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inportscoreMenuItem.Click
        Dim form4 As New Form4  ' 创建Form4窗体实例
        form4.MdiParent = Me    ' 设置form4为MDI子窗体
        form4.WindowState = FormWindowState.Normal ' 子窗体最大化显示
        form4.Show()
    End Sub
    '层叠菜单
    Private Sub cascadeMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cascadeMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)         ' 层叠方式排列
    End Sub
    '水平平铺菜单
    Private Sub horizonMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles horizonMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)  ' 水平平铺方式排列
    End Sub
    '垂直平铺菜单
    Private Sub verticalMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verticalMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)    ' 垂直平铺方式排列
    End Sub
    '关于菜单
    Private Sub aboutMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutMenuItem.Click
        Dim form5 As New Form5                  ' 创建Form5窗体实例
        form5.MdiParent = Me                    ' 设置form5为MDI子窗体
        form5.WindowState = FormWindowState.Normal ' 子窗体最大化显示
        form5.Show()
    End Sub
    '退出按钮
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        quitMenuItem.PerformClick()         ' 退出
    End Sub
    '查询按钮
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        selectinfoMenuItem.PerformClick()   ' 打开学生信息查询窗口
    End Sub
    '信息维护按钮
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        updateinfoMenuItem.PerformClick()   ' 打开学生信息维护窗口
    End Sub
    '成绩录入按钮
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        inportscoreMenuItem.PerformClick() ' 打开学生成绩维护窗口
    End Sub
    '垂直平铺按钮
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        verticalMenuItem.PerformClick()     '垂直平铺窗口
    End Sub
    '关于按钮
    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        aboutMenuItem.PerformClick()        ' 打开关于窗口
    End Sub
End Class
