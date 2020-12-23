Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = My.Forms.Form1.DBConnstr '获取主窗体中定义的数据库连接字符串

        '两个SqlDataAdapter和两个数据表，一个代表xsb表，一个代表cjb表
        Dim daXS As New SqlClient.SqlDataAdapter
        Dim daXK As New SqlClient.SqlDataAdapter
        Dim tblXS As New DataTable
        Dim tblXK As New DataTable
        '建立数据集对象,读学生XS和成绩XS_KC两个数据表到数据集中
        Dim dSXSandXK As New DataSet
        dSXSandXK.Tables.Add(tblXS)
        dSXSandXK.Tables.Add(tblXK)

        '生成Where子句
        Dim WhereStr As String '保存查询条件字符串
        WhereStr = ""
        If Trim(TxtXH.Text) <> "" Then
            If WhereStr = "" Then
                WhereStr = WhereStr & " XH like '%" + Trim(TxtXH.Text) + "%'"
            Else
                WhereStr = WhereStr & " and XH like '%" + Trim(TxtXH.Text) + "%'"
            End If
        End If
        If WhereStr <> "" Then
            WhereStr = " where " & WhereStr
        End If

        '设置读取数据的SQL命令
        Dim sqlstr As String
        sqlstr = "Select XH,XM,ZY,XB,CSRQ,ZXF From xsb"
        If WhereStr <> "" Then
            sqlstr = sqlstr & WhereStr
        End If
        daXS.SelectCommand = New SqlClient.SqlCommand(sqlstr, conn)
        daXK.SelectCommand = New SqlClient.SqlCommand("Select XH,KCH,CJ From cjb" & WhereStr, conn)
        '打开数据库连接，填充两个数据表
        conn.Open() : daXS.Fill(tblXS) : daXK.Fill(tblXK) : conn.Close()

        '开始建立两个数据表之间的关联
        '必须在数据表被填充以后建立关联，因为之前两个数据表都是空的，关联也无从谈起
        Dim XS_XK As DataRelation
        '第一个参数是关联的名字，第二个参数是父表中的XH，第三个参数是子表中的XH
        XS_XK = New DataRelation("XSXS_KC", tblXS.Columns("XH"), tblXK.Columns("XH"))
        '把建立好的关联加入数据集
        dSXSandXK.Relations.Add(XS_XK)

        '以下开始数据绑定,设置DataSource和DataMember属性
        DataGridView1.DataSource = tblXS
        DataGridView2.DataSource = tblXS
        DataGridView2.DataMember = "XSXS_KC"
    End Sub
End Class