Public Class Form1
    Dim KCxml As New DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        KCxml.Clear()
        KCxml.ReadXml("D:\My Documents\KC.xml")
        With DataGridView1
            .DataSource = KCxml
            .DataMember = "KC"
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim swXML As New System.IO.StringWriter
        KCxml.WriteXmlSchema(swXML)
        TextBox1.Text = swXML.ToString
    End Sub
End Class
