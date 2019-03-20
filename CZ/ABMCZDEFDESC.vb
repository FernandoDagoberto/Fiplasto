Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework

Public Class ABMCZDEFDESC
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl, decorativo As String
    Dim defecto1, defecto2, defecto3 As String
    Dim LineaItem, LineaGrupo As String
    Dim cantidad, marca, cant, cantLI, cantLII As Integer


    Private Sub ABMCZDEFDESC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call llenaGrupo()
        LineaGrupo = LBH.SelectedValue
        Call llenaItem()

    End Sub

    Private Sub llenaGrupo()
        Call conexion()

        sql1 = "select * FROM CZDESCARTEH where czdesch_baja='N'"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        LBH.DataSource = dt1
        LBH.DisplayMember = "CZDESCH_DESC"
        LBH.ValueMember = "CZDESCH_ID"

    End Sub

    Private Sub conexion()
        conex("CZ")
    End Sub

    Private Sub LBH_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBH.Click
        LineaGrupo = LBH.SelectedValue

        Call llenaItem()
    End Sub

    Private Sub llenaItem()
        Call conexion()

        sql2 = "select * FROM CZDESCARTEI where czdescH_ID='" + LineaGrupo + "' and CZDESCI_BAJA='N'"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)

        LBItem.DataSource = dt2
        LBItem.DisplayMember = "CZDESCI_DESC"
        LBItem.ValueMember = "CZDESCI_ID"

    End Sub

    Private Sub btngrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If String.IsNullOrEmpty(txtgrupo.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar los datos de grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtgrupo.Focus()

        Else
            Call buscamax()
            If IsDBNull(dt1.Rows(0).Item("ult")) Then
                ultnro = 1
            Else
                ultnro = dt1.Rows(0).Item("ult") + 1
            End If

            campos = "czdesch_id,czdesch_desc,czdescH_baja"
            variables = "'" + ultnro + "','" + Trim(txtgrupo.Text) + "','N'"
            SQL3 = "INSERT INTO CZDESCARTEH (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            txtgrupo.Text = Nothing

            Call llenaGrupo()

        End If
    End Sub

    Private Sub buscamax()
        conex("czdescarteH")
        sql1 = "SELECT max(czdescH_id)as ult from CZDESCARTEH "
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
    End Sub

    Private Sub btnitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnitem.Click
        If Trim(txtitem.Text) = "" Then
            MetroMessageBox.Show(Me, "Favor de completar los datos de item", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtitem.Focus()

        Else
            Call buscamaxItem()
            If IsDBNull(dt1.Rows(0).Item("ult")) Then
                ultnro = 1
            Else
                ultnro = dt1.Rows(0).Item("ult") + 1
            End If

            campos = "czdescI_id,czdesch_id,czdesci_desc,czdesci_BAJA"
            variables = "'" + Trim(ultnro) + "','" + Trim(Str(LBH.SelectedValue)) + "','" + Trim(txtitem.Text) + "','N'"
            SQL3 = "INSERT INTO CZDESCARTEI (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            txtitem.Text = ""

            Call llenaItem()

        End If
    End Sub

    Private Sub buscamaxItem()
        conex("czdescarteI")
        sql1 = "SELECT max(czdescI_id)as ult from CZDESCARTEI where czdescH_ID='" + Trim(Str(LBH.SelectedValue)) + "' "
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
    End Sub

    Private Sub LBItem_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LBItem.KeyUp
        If e.KeyCode = Keys.Delete Then
            ms = MetroMessageBox.Show(Me, "Desea eliminar  " + (LBItem.Text) + " ?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If ms = 1 Then
                Call eliminaitem()
            End If
        End If
    End Sub

    Private Sub eliminaitem()
        'elimina la fila de la grilla
        LineaItem = LBItem.SelectedValue
        If LineaItem <> "" Then
            sql4 = "update CZDESCARTEI set czdescI_baja='S' where czdescI_id='" + LineaItem + "' and czdescI_baja='N'"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Call llenaItem()

        Else
        End If


    End Sub

    Private Sub LBH_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LBH.KeyUp
        If e.KeyCode = Keys.Delete Then
            MetroMessageBox.Show(Me, "Desea eliminar el grupo: " + LBH.Text + " ? ", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If ms = 1 Then
                Call eliminagrupo()
            End If
        End If
    End Sub

    Private Sub eliminagrupo()
        'elimina la fila de la grilla Grupo
        LineaGrupo = LBH.SelectedValue
        If LineaGrupo <> "" Then
            sql4 = "update CZDESCARTEH set czdesch_baja='S' where czdesch_id='" + LineaGrupo + "'  and czdesch_baja='N'"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Call llenaGrupo()

        Else
        End If


    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class