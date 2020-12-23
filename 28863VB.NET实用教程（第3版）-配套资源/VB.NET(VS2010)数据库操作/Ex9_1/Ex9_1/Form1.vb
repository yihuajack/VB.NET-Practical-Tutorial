Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objConn As New OleDb.OleDbConnection '  创建一个OleDbConnection连接对象
        Dim objDa As New OleDb.OleDbDataAdapter '  一个OleDbDataAdapter对象
        Dim objComm As New OleDb.OleDbCommand '  一个OleDbCommand对象
        Dim objDs As New DataSet '  一个数据集DataSet对象

        '  设置连接字符串，告诉程序应当如何连接到数据库
        objConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\My Documents\xscj.accdb'"
        '  设置SQL命令，告诉程序应当如何取数据
        objComm.CommandText = "Select * From kc" '  KC表(课程)
        '  把objConn设置为objComm的数据库连接，相当于告诉“卡车”：应该走objConn这座“桥”
        objComm.Connection = objConn
        objDa.SelectCommand = objComm
        objConn.Open() '   打开数据库连接,相当于把桥造好
        objDa.Fill(objDs, "kcb") ' 填充数据集并命名表
        objConn.Close() '  关闭数据库连接，相当于填充完毕，可以把桥拆掉了
        '  把DataGridView1的DataSource属性设置为刚刚取到的数据表,这样就可以显示数据了   
        DataGridView1.DataSource = objDs.Tables("kcb")
    End Sub
End Class
