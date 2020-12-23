Public Class Form4
    Dim objDs As New DataSet                    '一个数据集DataSet对象
    Dim objXSTable As DataTable                 '一个学生表Table对象
    Dim objDa As New SqlClient.SqlDataAdapter   '一个OleDbDataAdapter对象
    Dim WhereStr As String                      '保存查询条件字符串
    Public Sub refreshdata()                    '更新并刷新显示
        objDa.Update(objDs, "cjb")              '更新物理学生成绩表
        objXSTable.Clear()                      '清空学生成绩表记录
        bindgridview(WhereStr)                  '重新添充学生成绩表记录
    End Sub
    Public Sub bindgridview(ByVal strXH As String)
        Dim objConn As New SqlClient.SqlConnection '创建一个OleDbConnection连接对象
        Dim objComm As New SqlClient.SqlCommand '一个OleDbCommand对象
        WhereStr = ""
        If Trim(TxtXH.Text) <> "" Then
            WhereStr = " XH like '%" + Trim(TxtXH.Text) + "%'"
        End If

        '设置连接字符串，告诉程序应当如何连接到数据库
        objConn.ConnectionString = My.Forms.Form1.DBConnstr
        '设置SQL命令，告诉程序应当如何取数
        objComm.CommandText = "Select XKID,XH,KCH,CJ From cjb" 'xs_kc表(成绩)
        If WhereStr <> "" Then
            objComm.CommandText = objComm.CommandText & " where " & WhereStr
        End If
        '把objConn设置为objComm的数据库连接
        objComm.Connection = objConn
        objDa.SelectCommand = objComm
        '创建INSERT Command
        Dim InsCommand As New SqlClient.SqlCommand("INSERT INTO cjb(XH,KCH,CJ) VALUES(@XH,@KCH,@CJ)", objConn)
        ''InsCommand.Parameters.Add("@XKID", SqlDbType.Int, Nothing, "XKID")
        InsCommand.Parameters.Add("@XH", SqlDbType.VarChar, 6, "XH")
        InsCommand.Parameters.Add("@KCH", SqlDbType.VarChar, 4, "KCH")
        InsCommand.Parameters.Add("@CJ", SqlDbType.Int, Nothing, "CJ")

        objDa.InsertCommand = InsCommand

        '创建Delete Command
        Dim delCommand As New SqlClient.SqlCommand("delete from cjb where XKID=@XKID", objConn)

        delCommand.Parameters.Add("@XKID", SqlDbType.VarChar, 6, "XKID")
        objDa.DeleteCommand = delCommand

        '创建Update Command
        Dim updCommand As New SqlClient.SqlCommand("update cjb set XH=@XH,KCH=@KCH,CJ=@CJ where XKID=@XKID", objConn)

        updCommand.Parameters.Add("@XH", SqlDbType.VarChar, 6, "XH")
        updCommand.Parameters.Add("@KCH", SqlDbType.VarChar, 4, "KCH")
        updCommand.Parameters.Add("@CJ", SqlDbType.Int, Nothing, "CJ")
        updCommand.Parameters.Add("@XKID", SqlDbType.Int, Nothing, "XKID")
        objDa.UpdateCommand = updCommand

        objConn.Open()                      '打开数据库连接
        objDa.Fill(objDs, "cjb")            '填充数据集
        objXSTable = objDs.Tables("cjb")
        objConn.Close()                     '关闭数据库连接
        '把DataGrid1的DataSource属性设置为刚刚取到的数据表,这样就可以显示数据了   
        DataGridView1.DataSource = objDs.Tables("cjb")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WhereStr = ""
        If Trim(TxtXH.Text) <> "" Then
            WhereStr = " where XH like '%" + Trim(TxtXH.Text) + "%'"
        End If
        objXSTable.Clear()                  '清空学生成绩表记录
        bindgridview(WhereStr)              '重新添充学生成绩表记录
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WhereStr = ""
        bindgridview(WhereStr)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim response As MsgBoxResult
        response = MsgBox("确实要添加记录吗？", vbOKCancel + vbQuestion, "系统提示")
        If response = MsgBoxResult.Ok Then  ' 用户选择“确定”
            Dim myRow As DataRow = objXSTable.NewRow()
            myRow("XKID") = objXSTable.Rows.Item(objXSTable.Rows.Count - 1).Item(0) + 1
            myRow("XH") = txtStuXH.Text
            myRow("KCH") = txtStuKCH.Text
            myRow("CJ") = txtStuCJ.Text
            objXSTable.Rows.Add(myRow)      '向学生成绩表添加记录
            refreshdata()                   '更新并刷新显示
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim response As MsgBoxResult
        response = MsgBox("确实要修改记录吗？", vbOKCancel + vbQuestion, "系统提示")
        If response = MsgBoxResult.Ok Then  '用户选择“确定”
            objXSTable.Rows.Item(DataGridView1.CurrentRow.Index).Item(1) = txtStuXH.Text    ' 修改学号
            objXSTable.Rows.Item(DataGridView1.CurrentRow.Index).Item(2) = txtStuKCH.Text   ' 修改课程号
            objXSTable.Rows.Item(DataGridView1.CurrentRow.Index).Item(3) = txtStuCJ.Text    ' 修改成绩
            refreshdata()                   '更新并刷新显示
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim response As MsgBoxResult
        response = MsgBox("确实要删除记录吗？", vbOKCancel + vbQuestion, "系统提示")
        If response = MsgBoxResult.Ok Then  '用户选择“确定”
            objXSTable.Rows.Item(DataGridView1.CurrentRow.Index).Delete()       '删除学生成绩表当前记录
            refreshdata()                   '更新并刷新显示
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtStuXKID.Text = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString ' 显示ID
        txtStuXH.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString   ' 显示学号
        txtStuKCH.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString  ' 显示课程号
        txtStuCJ.Text = DataGridView1.CurrentRow.Cells.Item(3).Value.ToString   ' 显示成绩
    End Sub
End Class