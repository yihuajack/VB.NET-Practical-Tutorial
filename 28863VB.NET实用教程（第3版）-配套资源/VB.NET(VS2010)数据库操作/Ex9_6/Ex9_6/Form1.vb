Public Class Form1
    Dim objDs As New DataSet '  一个数据集DataSet对象
    Dim objXSTable As DataTable '  一个学生表Table对象
    Dim objDa As New OleDb.OleDbDataAdapter '  一个OleDbDataAdapter对象
    Dim WhereStr As String '  保存查询条件字符串
    Public Sub refreshdata() '  更新并刷新显示
        objDa.Update(objDs, "XS") '  更新物理学生表
        objXSTable.Clear() '  清空学生表记录
        bindgridview(WhereStr) '  重新添充学生表记录
    End Sub

    Public Sub bindgridview(ByVal strXH As String)
        Dim objConn As New OleDb.OleDbConnection '  创建一个OleDbConnection连接对象
        Dim objComm As New OleDb.OleDbCommand '  一个OleDbCommand对象
        ' 设置连接字符串，告诉程序应当如何连接到数据库
        objConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\My Documents\xscj.accdb'"
        ' 设置SQL命令，告诉程序应当如何取数
        objComm.CommandText = "Select XH as 学号,XM as 姓名,ZYM,XB,CSSJ,ZXF,BZ  From xs"
        If Trim(strXH) <> "" Then
            objComm.CommandText = objComm.CommandText & strXH
        End If
        ' 把objConn设置为objComm的数据库连接
        objComm.Connection = objConn
        objDa.SelectCommand = objComm
        ' 创建能自动生成用于协调对 DataSet 的更改与关联物理数据库的单表命令的对象
        Dim builder As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(objDa)
        objConn.Open() '  打开数据库连接
        objDa.Fill(objDs, "xs") '  填充数据集
        objXSTable = objDs.Tables("xs")
        objConn.Close() '  关闭数据库连接
        ' 把DataGridView1的DataSource属性设置为刚刚取到的数据表,这样就可以显示数据了   
        DataGridView1.DataSource = objXSTable
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WhereStr = ""
        bindgridview(WhereStr)
        txtStuXH.Text = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString ' 显示学号
        txtStuXM.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString ' 显示姓名
        txtStuZXF.Text = DataGridView1.CurrentRow.Cells.Item(5).Value.ToString ' 显示总学分
        cbxStuXB.Text = DataGridView1.CurrentRow.Cells.Item(3).Value.ToString ' 显示性别
        cbxStuZYM.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString ' 显示专业
        dtpStuCSSJ.Text = DataGridView1.CurrentRow.Cells.Item(4).Value.ToString ' 显示出生日期
        txtStuBZ.Text = DataGridView1.CurrentRow.Cells.Item(6).Value.ToString ' 显示备注
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtStuXH.Text = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString ' 显示学号
        txtStuXM.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString ' 显示姓名
        txtStuZXF.Text = DataGridView1.CurrentRow.Cells.Item(5).Value.ToString ' 显示总学分
        cbxStuXB.Text = DataGridView1.CurrentRow.Cells.Item(3).Value.ToString ' 显示性别
        cbxStuZYM.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString ' 显示专业
        dtpStuCSSJ.Text = DataGridView1.CurrentRow.Cells.Item(4).Value.ToString ' 显示出生日期
        txtStuBZ.Text = DataGridView1.CurrentRow.Cells.Item(6).Value.ToString ' 显示备注
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim response As MsgBoxResult
        response = MsgBox("确实要添加记录吗？", vbOKCancel + vbQuestion, "系统提示")
        If response = MsgBoxResult.Ok Then '  用户选择“确定”
            Dim myRow As DataRow = objXSTable.NewRow()
            myRow("学号") = txtStuXH.Text
            myRow("姓名") = txtStuXM.Text
            myRow("ZXF") = txtStuZXF.Text
            myRow("XB") = cbxStuXB.Text
            myRow("ZYM") = cbxStuZYM.Text
            myRow("BZ") = txtStuBZ.Text
            myRow("CSSJ") = CDate(dtpStuCSSJ.Text)
            objXSTable.Rows.Add(myRow) ' 向学生表添加记录
            refreshdata() '  更新并刷新显示
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim response As MsgBoxResult
        response = MsgBox("确实要修改记录吗？", vbOKCancel + vbQuestion, "系统提示")
        If response = MsgBoxResult.Ok Then ' 用户选择“确定”
            ' 修改学号
            objXSTable.Rows.Item(DataGridView1.CurrentRow.Index).Item(0) = txtStuXH.Text
            ' 修改姓名
            objXSTable.Rows.Item(DataGridView1.CurrentRow.Index).Item(1) = txtStuXM.Text
            ' 修改总学分
            objXSTable.Rows.Item(DataGridView1.CurrentRow.Index).Item(5) = txtStuZXF.Text
            ' 修改性别
            objXSTable.Rows.Item(DataGridView1.CurrentRow.Index).Item(3) = cbxStuXB.Text
            ' 修改专业
            objXSTable.Rows.Item(DataGridView1.CurrentRow.Index).Item(2) = cbxStuZYM.Text
            ' 修改出生日期
            objXSTable.Rows.Item(DataGridView1.CurrentRow.Index).Item(4) = dtpStuCSSJ.Text
            ' 修改备注
            objXSTable.Rows.Item(DataGridView1.CurrentRow.Index).Item(6) = txtStuBZ.Text
            refreshdata() '  更新并刷新显示
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim response As MsgBoxResult
        response = MsgBox("确实要删除记录吗？", vbOKCancel + vbQuestion, "系统提示")
        If response = MsgBoxResult.Ok Then ' 用户选择“确定”
            objXSTable.Rows.Item(DataGridView1.CurrentRow.Index).Delete() '  删除学生表当前记录
            refreshdata() '  更新并刷新显示
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WhereStr = ""
        If Trim(TxtXH.Text) <> "" Then
            WhereStr = " where XH like '%" + Trim(TxtXH.Text) + "%'"
        End If
        objXSTable.Clear() '  清空学生表记录
        bindgridview(WhereStr) '  重新填充学生表记录
    End Sub
End Class
