Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data.OleDb


Public Class IO

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        Dim a As String
        a = TreeView1.SelectedNode.Text
        Dim url As String

        conexISO("IO")
        sql = "select * from menuView where ptomnu='" + a + "' and menu_spif='S'"
        daA = New OleDbDataAdapter(sql, cnnISO)
        dt = New DataTable
        daA.Fill(dt)
        n = dt.Rows.Count

        If n = 1 Then

            url = "http://ramallo05/sitioiso" & Mid(dt.Rows(0).Item("menu_link"), 2)
            WebBrowser1.Navigate(url)

        End If


        TreeView1.Refresh()

       
    End Sub

   




    Private Sub IO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '        Dim newNode As TreeNode = New TreeNode("Text for new node")
        Dim nodoP As TreeNode

        Dim nodo1 As String
        nodoP = TreeView1.Nodes.Add("Instructivos Operativos")

        conexISO("IO")
        sql = "SELECT * From menu WHERE menu_spif='S' order by menu_id"
        daA = New OleDbDataAdapter(sql, cnnISO)
        dt = New DataTable
        daA.Fill(dt)
        n = dt.Rows.Count

        'armar el árbol
        For x = 0 To n - 1

            nodo1 = dt.Rows(x).Item("menu_nombre") & " " & dt.Rows(x).Item("menu_titulo")
            TreeView1.Nodes(0).Nodes.Add(Trim((nodo1)))

        Next

    End Sub

    
End Class