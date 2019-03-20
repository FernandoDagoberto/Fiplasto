Imports System.Data.SqlClient
Imports MetroFramework

Public Class CZConfRepZorras
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String
    Dim cantidad, MaxCtrl As Integer
    Dim averia As String
    Dim averia1, averia2 As String

    Private Sub CZConfRepZorras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call buscadatos()
    End Sub

    Private Sub conexion()
        conex("czreparacion")
    End Sub

    Private Sub buscadatos()

        Call conexion()

        sql1 = "SELECT czreparacion_fecha as Fecha, czreparacion_turno as Turno,czreparacion_grupo as Grupo, czreparacion_zorra as Zorra,CZAVERIAS_1.CZAVERIAS_DESC as Averia1, " &
        "(SELECT CZAVERIAS_DESC FROM CZAVERIAS WHERE (CZAVERIAS_ID = czreparacion_averia2)) AS Averia2, " &
        "czreparacion_reparada as Reparada " &
        "FROM CZAVERIAS AS CZAVERIAS_1 INNER JOIN CZREPARACION ON CZAVERIAS_1.CZAVERIAS_ID = czreparacion_averia1 " &
        "where  CZREPARACION_REPARADA='N' and czreparacion_bajaid='0' ORDER BY CZREPARACION_FECHA"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        cant = dt1.Rows.Count

        dg.DataSource = dt1


    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick

        If cant = 0 Then

        Else
            'line = dg.CurrentCell.RowIndex
            idl = dg.CurrentRow.Cells.Item(0).Value
            ms = MetroMessageBox.Show(Me, "¿Desea confirmar como reparada la zorra seleccionada?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If ms = 1 Then
                Call confirmaReparacion()
            End If

        End If
    End Sub

    Private Sub confirmaReparacion()
        sql4 = "update CZREPARACION set CZREPARACION_userid='" + user + "',CZREPARACION_reparada='S' where CZREPARACION_fecha='" + idl + "'"
        cmd4 = New SqlCommand(sql4, cnn)
        cmd4.Connection.Open()
        cmd4.ExecuteNonQuery()
        cmd4.Connection.Close()

        Call buscadatos()
        If dt1.Rows.Count <> 0 Then
            'dg.Select(0)
        Else

        End If
    End Sub



End Class