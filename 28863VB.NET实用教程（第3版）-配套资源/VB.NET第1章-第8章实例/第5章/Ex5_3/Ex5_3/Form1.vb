﻿Public Class Form1
    Public Structure newStudents
        Public XH As String                     '  学号
        Public XM As String                     '  姓名
        Public ZYM As String                    '  专业名
        Public XB As String                     '  性别
        Public NL As Integer                    '  年龄
    End Structure

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Const MAX_STU = 2                       '  最多输入的学生数量
        Dim arrayXS(MAX_STU) As newStudents
        Dim I As Integer
        '  从键盘依次输入每个学生的基本信息。
        For I = 0 To MAX_STU
            arrayXS(I).XH = InputBox("请输入学号：")
            arrayXS(I).XM = InputBox("请输入姓名：")
            arrayXS(I).ZYM = InputBox("请输入专业名称：")
            arrayXS(I).XB = InputBox("请输入性别：")
            arrayXS(I).NL = Val(InputBox("请输入年龄："))
        Next I
        Debug.WriteLine("")
        Debug.WriteLine("学号    姓名    专业    性别    年龄")
        For I = 0 To MAX_STU
            Debug.Write(arrayXS(I).XH & Space(4))
            Debug.Write(arrayXS(I).XM & Space(4))
            Debug.Write(arrayXS(I).ZYM & Space(4))
            Debug.Write(arrayXS(I).XB & Space(4))
            Debug.WriteLine(arrayXS(I).NL)
        Next I
    End Sub
End Class
