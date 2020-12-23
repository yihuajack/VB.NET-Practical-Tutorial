Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim I As Short
        Dim Name1, Name2, Name3 As String
        Dim MyNames As New Collection '  创建一个集合对象MyNames  
        For I = 1 To 10
            MyNames.Add(Item:="学生" & I, Key:="stuid" & I) '  添加字符型数据项和索引值
        Next I
        MyNames.Add(Item:="新加的学生", Before:=8) '  在第8个元素前插入一个元素
        MyNames.Add(Item:="学生11", After:=4) '  在第4个元素后插入一个元素

        Debug.WriteLine("")
        Name1 = MyNames.Item(5)
        Name2 = MyNames.Item(8)
        Name3 = MyNames.Item(9)
        Debug.WriteLine(Name1)
        Debug.WriteLine(Name2)
        Debug.WriteLine(Name3)
    End Sub
End Class
