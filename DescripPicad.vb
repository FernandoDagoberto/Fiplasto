Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class DescripPicad

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim a As String
        a = TreeView1.SelectedNode.Name




        Try
            Select Case a

                Case "tvGinchero"


                Case "tvOpPica"
                    WebBrowser1.Navigate("http://fiplasto/iso/IO/IO%209-1-3-1.htm")

                Case "tvOpDes"
                Case "tvAyMC"
                Case "tvOpPr"
                Case "tvAyPr"
                Case "tvQuiPr"
                Case "tvOpZo"



            End Select

        Catch
            MsgBox("No se encuentra")


        End Try
    End Sub



    Private Sub DescripPicad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class