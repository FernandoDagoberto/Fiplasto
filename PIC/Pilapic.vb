Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class Pilapic

    Dim tipomad As String
    Dim stockfin As Integer
    Dim llena As String
    Dim colorAcoplado As String
    Dim nroAcoplado As Integer
    Dim kgacoplado As Integer
    Dim LimAju As Integer
    Dim autoriza As String


    Private Sub Pilapic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call llenaAcpl()
        cbAcpl.Focus()
        cbAcpl.SelectedIndex = 0
        Call controlallena()
        Call llenapila()


    End Sub

    Sub llenaAcpl()

        sql5 = "SELECT * FROM PIC_ACPL WHERE acpl_debaja='N' order by acpl_nro"
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        cbAcpl.DataSource = dt5
        cbAcpl.DisplayMember = "acpl_color"
        cbAcpl.ValueMember = "acpl_nro"



    End Sub

    Sub llenapila()

        sql = "SELECT ('Pila Nro: ' + ltrim(str(stpila_pila)) + ' - ' +  ltrim(cast(stpila_stock as float)/1000) + ' TN '  ) as StockPila,* From pila inner join stpila on ltrim(pila_id)=ltrim(stpila_pila) where stpila_stock>0 order by stpila_pila"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        cbpila.DataSource = dt
        cbpila.DisplayMember = "stockpila"
        cbpila.ValueMember = "pila_id"

    End Sub



    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        Call control()

        If cbAcpl.Text = "" Or cbturno.Text = "" Or cbgrupo.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Aviso", MessageBoxButtons.OK)
            cbturno.Focus()
            Exit Sub

        Else

            'Peso carrito, sí está chequeado fin de pila el peso del carrito es lo que queda de pila

            If chkfin.Checked = True Then
                kgacoplado = stockfin
            End If


            'Controlar ajuste. Sí es un ajuste descuenta el total restante de la pila
            If chkajuste.Checked = True Then
                chkfin.Checked = True
                kgacoplado = stock
                msg = MetroMessageBox.Show(Me, "Desea realizar el siguiente ajuste: " + Chr(13) + "Acoplado Color: '" + colorAcoplado + "'" + Chr(13) + "Turno: '" + cbturno.Text + "'" + Chr(13) + "Grupo:'" + cbgrupo.Text + "'" + Chr(13) + "Pila: '" + Trim(cbpila.SelectedValue) + "'" + Chr(13) + "KG: '" + Str(kgacoplado) + "'", "Atención", MessageBoxButtons.OKCancel)

            Else
                'Sí no es ajuste
                msg = MetroMessageBox.Show(Me, "Confirma los siguientes datos: " + Chr(13) + "Acoplado Color: '" + colorAcoplado + "'" + Chr(13) + "Turno: '" + cbturno.Text + "'" + Chr(13) + "Grupo:'" + cbgrupo.Text + "'" + Chr(13) + "Pila: '" + Trim(cbpila.SelectedValue) + "'" + Chr(13) + "KG: '" + Str(kgacoplado) + "'", "Atención", MessageBoxButtons.OKCancel)
            End If
        End If


        If msg = 1 Then

            Call buscamax()
            If IsDBNull(dt1.Rows(0).Item("ult")) Then
                ultnro = "1"
            Else
                ultnro = dt1.Rows(0).Item("ult") + 1
            End If

            campos = "pilapic_nromov,pilapic_nroacp,pilapic_fecha,pilapic_turno,pilapic_grupo,pilapic_pila,pilapic_consumo,pilapic_motivo,pilapic_motaju,pilapic_userid"
            variables = "'" + ultnro + "','" + Str(nroAcoplado) + "','" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + Str(cbpila.SelectedValue) + "','" + Str(kgacoplado) + "','" + cbmotpi.Text + "','" + txtmotaju.Text + "','" + user + "'"
            SQL3 = "INSERT INTO PILAPIC (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            campos = "marmv_ingegr,marmv_nroremito,marmv_conforme,marmv_tipmad,marmv_pila,marmv_neto,marmv_fecha,marmv_turno,marmv_grupo,marmv_userid"
            variables = "'E','" + ultnro + "','S','" + tipomad + "','" + Str(cbpila.SelectedValue) + "','" + Str(kgacoplado) + "','" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + user + "'"
            sql4 = "INSERT INTO MARMV (" + campos + ") VALUES (" + variables + ")"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Call ActualizaStock()
            chkfin.Checked = False
            chkajuste.Checked = False
            cbmotpi.DataSource = Nothing
            cbmotpi.Enabled = False

            MetroMessageBox.Show(Me, "Consumo generado", "", MessageBoxButtons.OK)
            Call llenapila()
            cbAcpl.Enabled = True
            If cbAcpl.SelectedValue = 999 Then
                cbAcpl.SelectedIndex = 0
            End If
            cbAcpl.Focus()
            cmdGuardar.Visible = False

            chkfin.Checked = False
            chkajuste.Checked = False
            lblmotaju.Visible = False
            txtmotaju.Visible = False

        Else

            cbAcpl.Focus()

        End If

        Call controlallena()


    End Sub


    Private Sub buscamax()
        conex("pilapic")
        sql1 = "SELECT max(pilapic_nromov)as ult From pilapic ;"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
    End Sub

    Private Sub cbpila_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbpila.LostFocus
        cmdGuardar.Visible = True
    End Sub


    Private Sub cbpila_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbpila.SelectionChangeCommitted

        If chkajuste.Checked = True Then
            Call controlastock()
            lbltn.Text = stock / 1000 & " TN "
        Else
            lbltn.Text = ""
        End If


        Call control()

        'Controla si la pila está llena.
        'En caso de que no esté llena tiene que habilitar un campo de texto.
        Dim nollena As String
        nollena = dt2.Rows(0).Item("stpila_llena")

        If nollena = "N" Then
            MetroMessageBox.Show(Me, "Pila no completa, favor de indicar el motivo por el cual se realiza esta maniobra", "Atención", MessageBoxButtons.OK)
            cbmotpi.Enabled = True
            llenacb("motivopi")
            cbmotpi.DataSource = dt7
            cbmotpi.DisplayMember = "motivopi_desc"
            cbmotpi.ValueMember = "motivopi_id"


        Else
            cbmotpi.DataSource = Nothing
            cbmotpi.Enabled = False

        End If


    End Sub

    Sub control()

        sql2 = "select * from PILA inner join TIPMAD on pila.pila_tipo=tipmad.tipmad_desc " &
        "INNER JOIN STPILA ON Pila.Pila_ID = STPILA.stpila_pila where pila.pila_id='" + Trim(cbpila.SelectedValue) + "'"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)
        tipomad = Trim(dt2.Rows(0).Item("tipmad_id"))




        If dt2.Rows(0).Item("stpila_stock") <= kgacoplado Then
            chkfin.Checked = True
            stockfin = dt2.Rows(0).Item("stpila_stock")

        Else
            chkfin.Checked = False

        End If
    End Sub



    Sub ActualizaStock()

        Call controlastock()

        'Marca el fin de pila si el stock es menor o igual a 13000
        If chkfin.Checked = True Then
            stock = 0
            llena = "N"
            sql2 = "update stpila set stpila_stock='" + Str(stock) + "', stpila_llena='" + llena + "' where stpila_pila='" + Str(cbpila.SelectedValue) + "'"

            'Blanquea fecha en Pila
            SQL3 = "update pila set pila_fecalta=null where pila_id='" + Trim(Str(cbpila.SelectedValue)) + "'"
            cmd2 = New SqlCommand(SQL3, cnn)
            cmd2.Connection.Open()
            cmd2.ExecuteNonQuery()
            cmd2.Connection.Close()

        Else
            stock = stock - kgacoplado
            sql2 = "update stpila set stpila_stock='" + Str(stock) + "' where stpila_pila='" + Trim(Str(cbpila.SelectedValue)) + "'"
        End If


        cmd2 = New SqlCommand(sql2, cnn)
        cmd2.Connection.Open()
        cmd2.ExecuteNonQuery()
        cmd2.Connection.Close()

    End Sub

    Sub controlallena()
        SQL3 = "select ('Pila Nro: ' + ltrim(str(stpila_pila)) + ' - ' +  Pila_tipo + ' - ' +  ltrim(cast(stpila_stock as float)/1000) + ' TN '  ) as PilasHab,* from STPILA inner join PILA on ltrim(STPILA.stpila_pila)=ltrim(pila_id) where stpila_llena='S' order by stpila.stpila_pila"
        da3 = New SqlDataAdapter(SQL3, cnn)
        dt3 = New DataTable
        da3.Fill(dt3)
        n = dt3.Rows.Count
        If n <> 0 Then
            lbllena.DataSource = dt3
            lbllena.DisplayMember = "PilasHab"
            lbllena.ValueMember = "stpila_pila"

        End If

    End Sub

    Private Sub cmdcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancelar.Click
        Me.Close()
    End Sub

    Private Sub chkajuste_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkajuste.CheckedChanged
        If chkajuste.Checked = True Then
            cbAcpl.Text = "FIN DE PILA"
            nroAcoplado = cbAcpl.SelectedValue
            cbAcpl.Enabled = False

            Call controlastock()

            lbltn.Text = stock / 1000 & " TN "
            chkfin.Checked = True

            lblmotaju.Visible = True
            txtmotaju.Visible = True


            limites("limiteajuste")
            LimAju = dt8.Rows(0).Item("param_valor")
            If stock <= LimAju Then
                autoriza = "S"
            Else
                gbautoriza.Visible = True
                cmdGuardar.Visible = False

            End If

        Else

            lbltn.Text = ""
            chkfin.Checked = False
            cbAcpl.Enabled = True

            lblmotaju.Visible = True
            lblmotaju.Visible = True

        End If
    End Sub

    Sub controlastock()
        SQL3 = "select * from STPILA where stpila_pila='" + Str(cbpila.SelectedValue) + "'"
        da3 = New SqlDataAdapter(SQL3, cnn)
        dt3 = New DataTable
        da3.Fill(dt3)

        stock = dt3.Rows(0).Item("stpila_stock")
    End Sub

    Private Sub cmdautoriza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdautoriza.Click
        conex("usuario")
        sql9 = "SELECT user_id ,user_pass From usuarios inner join perfil on usuarios.user_perfil=PERFIL.PERFIL_ID where user_id='" + txtusu.Text + "' and user_pass='" + txtpass.Text + "' and PERFIL.PERFIL_CARGO='S'"
        da9 = New SqlDataAdapter(sql9, cnn)
        dt9 = New DataTable
        da9.Fill(dt9)
        n = dt9.Rows.Count

        If n = 1 Then
            MetroMessageBox.Show(Me, "Ajuste autorizado", "", MessageBoxButtons.OK)
            autoriza = "S"
            gbautoriza.Visible = False
            cmdGuardar.Visible = True
            txtusu.Text = ""
            txtpass.Text = ""

        Else
            MetroMessageBox.Show(Me, "Usuario y contraseña incorrecta", "", MessageBoxButtons.OK)
            txtpass.Text = ""
            txtusu.Focus()
        End If


    End Sub


    Private Sub cmdrecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrecha.Click
        autoriza = "N"
        gbautoriza.Visible = False
        cmdGuardar.Visible = True
        chkfin.Checked = False
        chkajuste.Checked = False
        cbAcpl.SelectedIndex = 0
        lbltn.Text = ""

        lblmotaju.Visible = False
        txtmotaju.Visible = False
    End Sub

    Private Sub txtnroacp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)

        Call controlallena()
        Call llenapila()

    End Sub

    Private Sub cbAcpl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAcpl.SelectedIndexChanged
        'Obtengo el nro y kg del acoplado seleccionado desde el dt5 llenado al principio
        colorAcoplado = dt5.Rows(cbAcpl.SelectedIndex).Item("acpl_color")
        nroAcoplado = dt5.Rows(cbAcpl.SelectedIndex).Item("acpl_nro")
        kgacoplado = (dt5.Rows(cbAcpl.SelectedIndex).Item("acpl_tn")) * 1000

        If chkajuste.Checked = False And nroAcoplado = 999 Then
            MetroMessageBox.Show(Me, "ACOPLADO DESIGNADO SOLO PARA AJUSTES" & Chr(13) & "SELECCIONE OTRO", "ATENCIÓN", MessageBoxButtons.OK)
            cbAcpl.SelectedIndex = 0
        End If


    End Sub

    Private Sub cbAcpl_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAcpl.SelectionChangeCommitted
        'Obtengo el nro y kg del acoplado seleccionado desde el dt5 llenado al principio
        colorAcoplado = dt5.Rows(cbAcpl.SelectedIndex).Item("acpl_color")
        nroAcoplado = dt5.Rows(cbAcpl.SelectedIndex).Item("acpl_nro")
        kgacoplado = (dt5.Rows(cbAcpl.SelectedIndex).Item("acpl_tn")) * 1000

        If chkajuste.Checked = False And nroAcoplado = 999 Then
            MetroMessageBox.Show(Me, "ACOPLADO DESIGNADO SOLO PARA AJUSTES" & Chr(13) & "SELECCIONE OTRO", "ATENCIÓN", MessageBoxButtons.OK)
            cbAcpl.SelectedIndex = 0
        End If

    End Sub
End Class