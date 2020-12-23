Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\My Documents\xscj.accdb'"
        '  两个OleDBDataAdapter和两个数据表，一个代表XS表，一个代表XS_KC表
        Dim daXS As New OleDb.OleDbDataAdapter
        Dim daXK As New OleDb.OleDbDataAdapter
        Dim tblXS As New DataTable
        Dim tblXK As New DataTable
        '  建立数据集对象,读学生XS和成绩XS_KC两个数据表到数据集中
        Dim dSXSandXK As New DataSet
        dSXSandXK.Tables.Add(tblXS) : dSXSandXK.Tables.Add(tblXK)

        '  设置读取数据的SQL命令
        daXS.SelectCommand = New OleDb.OleDbCommand("Select XH,XM From XS", conn)
        daXK.SelectCommand = New OleDb.OleDbCommand("Select XH,KCH,CJ,XF From XS_KC", conn)
        '  打开数据库连接，填充两个数据表
        conn.Open() : daXS.Fill(tblXS) : daXK.Fill(tblXK) : conn.Close()

        '  开始建立两个数据表之间的关联，关联字段用XH
        '  必须在数据表被填充以后建立关联
        Dim XS_XK As DataRelation
        '  第一个参数是关联的名字，第二个参数是父表中的XH，第三个参数是子表中的XH
        XS_XK = New DataRelation("XSXS_KC", tblXS.Columns("XH"), tblXK.Columns("XH"))
        '  把建立好的关联加入数据集
        dSXSandXK.Relations.Add(XS_XK)

        '  以下开始数据绑定,设置DataSource和DataMember属性
        '  cmbXS.DataSource = tblXS : cmbXS.DisplayMember = "XH"
        DataGridView1.DataSource = tblXS
        DataGridView2.DataSource = tblXS : DataGridView2.DataMember = "XSXS_KC"
    End Sub
End Class
