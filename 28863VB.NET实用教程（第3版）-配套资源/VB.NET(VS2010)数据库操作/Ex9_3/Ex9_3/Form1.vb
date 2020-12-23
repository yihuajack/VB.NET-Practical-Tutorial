Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objConn As New OleDb.OleDbConnection '  创建一个OleDbConnection连接对象
        Dim objDa As New OleDb.OleDbDataAdapter '  一个OleDbDataAdapter对象
        Dim objComm As New OleDb.OleDbCommand '  一个OleDbCommand对象
        Dim objDs As New DataSet '  一个数据集DataSet对象
        Dim WhereStr As String ' 定义查询条件字符串变量
        WhereStr = ""
        If Trim(TxtXH.Text) <> "" Then
            WhereStr = " XH like '%" + Trim(TxtXH.Text) + "%'" ' 生成查询条件字符串
        End If
        '  设置连接字符串，告诉程序应当如何连接到数据库
        objConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\My Documents\xscj.accdb'"
        '  设置SQL命令，设置显示的字段列表和相应的标题
        objComm.CommandText = "Select XH as 学号,XM as 姓名,ZYM,XB,CSSJ,ZXF  From xs"
        If WhereStr <> "" Then
            objComm.CommandText = objComm.CommandText & " where " & WhereStr
        End If
        '  把objConn设置为objComm的数据库连接
        objComm.Connection = objConn
        objDa.SelectCommand = objComm
        objConn.Open() '  打开数据库连接
        objDa.Fill(objDs, "xs") '  填充数据集
        objConn.Close() '  关闭数据库连接，相当于填充完毕
        ' 把DataGridView1的DataSource属性设置为刚刚取到的数据表,这样就可以显示数据了   
        DataGridView1.DataSource = objDs.Tables("xs")
    End Sub
End Class
