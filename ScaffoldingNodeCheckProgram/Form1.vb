Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports ScaffoldingNodeCheckTool

Public Class Form1
    Public Node3ds As New List(Of Node3D)
    Public ElementInfos As New List(Of Element)
    Public snc As clsScaffoldingNodeCheck

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeData()
        snc.Calulate()

        Dim res1 = snc.ResNodeLaYa.Max
        Dim res2 = snc.ResNodeLaYa.Min
        Dim res3 = snc.ResNodeShear.Max
        Dim res4 = snc.ResNodeShear.Min
    End Sub

    Public Sub Save_PorjectInfo_To_File(FileName As String)
        Try
            ' Opens a file and serializes the object into it in binary format.
            Dim stream As Stream = File.Open(FileName, FileMode.Create)
            Dim formatter As New BinaryFormatter
            formatter.Serialize(stream, snc)
            stream.Close()
            formatter = Nothing
        Catch ex As Exception
            MsgBox("Error occurs when save to file: " + FileName + vbCrLf + "Error: " + ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Public Sub Read_ProjectInfo_From_File(FileName As String)
        Dim stream As Stream = File.Open(FileName, FileMode.Open)
        Dim formatter As New BinaryFormatter
        Dim snc As clsScaffoldingNodeCheck
        snc = CType(formatter.Deserialize(stream), clsScaffoldingNodeCheck)
        stream.Close()
    End Sub

    '数据初始化
    Public Sub InitializeData()
        Dim NodeInfosFileName = "NodeInfos.txt"
        Dim ElemInfosFileName = "ElemInfos.txt"
        Dim NodeLines() As String = System.IO.File.ReadAllLines(NodeInfosFileName, System.Text.Encoding.Default)
        Dim ElemLines() As String = System.IO.File.ReadAllLines(ElemInfosFileName, System.Text.Encoding.Default)
        For Each l As String In NodeLines
            Dim CurLine As List(Of String) = LineSplit(l)
            Node3ds.Add(New Node3D(CurLine(0), CurLine(1), CurLine(2), CurLine(3)))
        Next
        For Each l As String In ElemLines
            Dim CurLine As List(Of String) = LineSplit(l)
            ElementInfos.Add(New Element(CurLine(0), CurLine(1), CurLine(2), CurLine(3), CurLine(4)))
        Next
        snc = New clsScaffoldingNodeCheck(Node3ds, ElementInfos)
    End Sub

    '将字符串行分割为字符数组
    Private Function LineSplit(s As String) As List(Of String)
        LineSplit = New List(Of String) : LineSplit.Clear()
        Dim vals As String() = s.Split(New Char() {"="c, " "c, ":"c, "："c, ","c, "，"c, CChar(vbTab)})
        For i = 0 To vals.Length - 1
            If vals(i).Length > 0 Then
                LineSplit.Add(vals(i))
            End If
        Next
        Return LineSplit
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SaveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.Filter = "My App File (*.app)|*.app|All files (*.*)|*.*"
        SaveFileDialog1.FileName = ""
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call Save_PorjectInfo_To_File(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.Filter = "My App File (*.app)|*.app|All files (*.*)|*.*"
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call Read_ProjectInfo_From_File(OpenFileDialog1.FileName)
        End If
    End Sub
End Class
