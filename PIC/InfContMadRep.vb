Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient



Public Class InfContMadRep
    Inherits MetroFramework.Forms.MetroForm

    Dim fch, fchant As Date
    Dim UltDiaMesAnt As Date

    Dim stkant As Double
    Dim ingD, ingDC, ingDB, ingDV, ingDO, ingM, ingMC, ingMB, ingMV, ingMO As Double
    Dim conD, conDC, conDB, conDV, conDO, conM, conMC, conMB, conMV, conMO As Double
    Dim stkActC, stkActB, stkActV, stkActO As Double
    Dim TrD, TrM As Double
    Dim total As Double



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor

        'Borrar encabezado
        sql = "delete from auxcontH where auxcontH_userid='" + user + "'"
        cmd3 = New SqlCommand(sql, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()
        ProgressBar1.Value = 25


        'Borrar cuerpo
        sql = "delete from auxcont where auxcont_userid='" + user + "'"
        cmd3 = New SqlCommand(sql, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()
        ProgressBar1.Value = 50

        sql = ""


        fch = dtfecha.Text
        fchant = dthasta.Text

        'Día anterior de la fecha HASTA a partir de las 22 hs
        fechaant = FormatDateTime(fchant.AddDays(-1), DateFormat.ShortDate) & " 22:00:00"

        'Calcula el último día del mes anterior teniendo el cuenta la fecha DESDE
        UltDiaMesAnt = UltimoDiaDelMesAnt(dtfecha.Value) & " 22:00:00"

        fchhasta = dthasta.Text & " 21:59:59"



        sql = "Insert into AUXCONT (auxcont_pila,auxcont_fchpila,auxcont_tipmad,auxcont_stkini,auxcont_ingreso,auxcont_consumo,auxcont_transpaso,auxcont_stkact,auxcont_userid) " & _
        "SELECT Pila.Pila_ID,Pila.Pila_fecalta,Pila.Pila_tipo, " & _
        "(SELECT COALESCE(SUM(marmv_neto),0)FROM MARMV AS MARMV_2 " & _
        "WHERE(marmv_destino = 'P' OR marmv_ingegr='S') AND(marmv_pila = Pila.Pila_ID) AND (marmv_fecha <= '" + UltDiaMesAnt + "')) - " & _
        "(SELECT COALESCE(SUM(marmv_neto), 0)FROM MARMV AS MARMV_1 " & _
        "WHERE(marmv_ingegr = 'E') AND (marmv_pila = Pila.Pila_ID) AND (marmv_fecha <= '" + UltDiaMesAnt + "')) + " & _
        "(SELECT COALESCE(SUM(trajinv_cant * - 1000), 0)FROM TRAJINV AS TRAJINV_2 " & _
        "WHERE(trajinv_depila = Pila.Pila_ID) AND (trajinv_fch <= '" + UltDiaMesAnt + "')) + " & _
        "(SELECT COALESCE (SUM(trajinv_cant * 1000), 0)FROM TRAJINV AS TRAJINV_1 " & _
        "WHERE (trajinv_apila = Pila.Pila_ID) AND (trajinv_fch <= '" + UltDiaMesAnt + "')) " & _
        " + (SELECT COALESCE(SUM(cant * - 1000), 0)FROM TRMADBIO AS TRMADBIO_2 WHERE(depila = Pila.Pila_ID) AND (fch <='" + UltDiaMesAnt + "')) " & _
        " + (SELECT COALESCE (SUM(cant * 1000), 0)FROM TRMADBIO AS TRMADBIO_1 WHERE (apila = Pila.Pila_ID) AND (fch <= '" + UltDiaMesAnt + "')) - " & _
        "(SELECT COALESCE(SUM(marmv_neto), 0)FROM MARMV AS MARMV_1 WHERE(marmv_ingegr = 'V') " & _
        "AND (marmv_pila = Pila.Pila_ID) AND (marmv_fecha <= '" + UltDiaMesAnt + "'))AS Stock_Inicial, " & _
        "(SELECT (COALESCE(SUM(ABS(marmv_neto)), 0))FROM MARMV " & _
        "WHERE(marmv_destino = 'P' or marmv_ingegr= (case marmv_pila " & _
        "when 90 then  'V' else   '' " & _
        "end )) " & _
        "AND (marmv_pila = Pila.Pila_ID) and marmv_fecha>='" + UltDiaMesAnt + "' and marmv_fecha<='" + fchhasta + "') AS Ingresos, " & _
        "(SELECT COALESCE(SUM(marmv_neto), 0)FROM MARMV AS MARMV_1 " & _
        "WHERE(marmv_ingegr='E')AND (marmv_pila = Pila.Pila_ID)and marmv_fecha>='" + UltDiaMesAnt + "' and marmv_fecha<='" + fchhasta + "' ) AS Consumo, " & _
        "(SELECT COALESCE (SUM(trajinv_cant * - 1000), 0)FROM TRAJINV " & _
        "WHERE (trajinv_depila = Pila.Pila_ID) and trajinv_fch>='" + UltDiaMesAnt + "' and trajinv_fch<='" + fchhasta + "') + " & _
        "(SELECT COALESCE(SUM(trajinv_cant * 1000), 0)FROM TRAJINV AS TRAJINV_1 " & _
        "WHERE (trajinv_apila = Pila.Pila_ID)and trajinv_fch>='" + UltDiaMesAnt + "' and trajinv_fch<='" + fchhasta + "') " & _
        " +(SELECT COALESCE (SUM(cant * - 1000), 0)FROM TRMADBIO WHERE (depila = Pila.Pila_ID) and fch>='" + UltDiaMesAnt + "' and fch<='" + fchhasta + "') " & _
        "+ (SELECT COALESCE(SUM(cant * 1000), 0)FROM TRMADBIO AS TRMADBIO_1 WHERE (apila = Pila.Pila_ID)and fch>='" + UltDiaMesAnt + "' and fch<='" + fchhasta + "') AS Traspasos, " & _
        "'0','" + user + "' " & _
        "FROM Pila INNER JOIN STPILA ON Pila.Pila_ID = STPILA.stpila_pila " & _
        "UNION " & _
        "SELECT '0','','A Picadora','0', " & _
        "(SELECT COALESCE(SUM(marmv_neto),0)FROM MARMV WHERE(marmv_destino = 'C') AND (marmv_ingegr='I' OR marmv_ingegr = 'V') and marmv_fecha>='" + UltDiaMesAnt + "' and marmv_fecha<='" + fchhasta + "'), " & _
        "(SELECT COALESCE(SUM(marmv_neto),0)FROM MARMV WHERE(marmv_destino = 'C') AND (marmv_ingegr='I' OR marmv_ingegr = 'V') and marmv_fecha>='" + UltDiaMesAnt + "' and marmv_fecha<='" + fchhasta + "'), " & _
        "'0','0','" + user + "' " & _
        "from marmv "


        cmd3 = New SqlCommand(sql, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()

        ProgressBar1.Value = 75



        sql1 = "select 'StockAnt' as Datos,sum(case when marmv_ingegr='E' then -1 else 1 end * (marmv_neto/1000)) + " & _
                "(select COALESCE(sum(case when marmv_ingegr='V' then -1 else 1 end * (marmv_neto/1000)),0) " & _
                "from marmv where (marmv_ingegr='V' and marmv_destino='C') and marmv_fecha<='" + fechaant + "') " & _
                " - (select COALESCE(sum(cant),0) from TRMADBIO where fch<='" + fechaant + "') as Totales " & _
                "from marmv where (marmv_ingegr in ('I','E','S') and (marmv_destino='P' or marmv_destino is null)) and marmv_fecha<='" + fechaant + "' " & _
                "union " & _
                "select 'IngresoDiario',COALESCE(SUM(cast(marmv_neto as float)/1000),0)as IngDiario  from marmv where marmv_ingegr='I' and marmv_rechazado<>'S' and marmv_fecha>='" + fechaant + "' and marmv_fecha<='" + fchhasta + "' " & _
                "union " & _
                "select 'ConsumoDiario',COALESCE(SUM(cast(marmv_neto as float)/1000),0) as ConsumoDiario  from marmv where (marmv_ingegr='E' or marmv_destino='C') and marmv_fecha>='" + fechaant + "' and marmv_fecha<='" + fchhasta + "' " & _
                "union " & _
                "select 'IngresoM',COALESCE(SUM(cast(marmv_neto as float)/1000),0)as IngDiario  from marmv where marmv_ingegr='I' and marmv_rechazado<>'S' and marmv_fecha>='" + UltDiaMesAnt + "' and marmv_fecha<='" + fchhasta + "'" & _
                "union " & _
                "select 'ConsumoM',COALESCE(SUM(cast(marmv_neto as float)/1000),0)as ConsumoDiario  from marmv where (marmv_ingegr='E' or marmv_destino='C') and marmv_fecha>='" + UltDiaMesAnt + "' and marmv_fecha<='" + fchhasta + "' " & _
                "union " & _
                "(select  distinct 'IngresoD ' + pila_tipo , (select COALESCE(SUM(cast(marmv_neto as float)/1000),0) from marmv inner join tipmad on marmv_tipmad=tipmad_ID where marmv_ingegr='I' " & _
                    " and marmv_fecha>='" + fechaant + "'and marmv_fecha<='" + fchhasta + "' and marmv_rechazado<>'S' and tipmad_desc=pila_tipo ) as IngDiario " & _
                    "from pila inner join marmv on pila_id=marmv_pila) " & _
                "union " & _
                "(select distinct 'ConsumoD ' + pila_tipo  , (select COALESCE(SUM(cast(marmv_neto as float)/1000),0) from marmv inner join tipmad on marmv_tipmad=tipmad_ID where (marmv_ingegr='E' or marmv_destino='C') " & _
                "and marmv_fecha>='" + fechaant + "'and marmv_fecha<='" + fchhasta + "' and tipmad_desc=pila_tipo ) as ConsumoDiario " & _
                "from pila inner join marmv on pila_id=marmv_pila ) " & _
                "union " & _
                "(select distinct 'ConsumoM ' + pila_tipo  , (select COALESCE(SUM(cast(marmv_neto as float)/1000),0) from marmv inner join tipmad on marmv_tipmad=tipmad_ID where (marmv_ingegr='E' or marmv_destino='C') " & _
                "and marmv_fecha>='" + UltDiaMesAnt + "' and marmv_fecha<='" + fchhasta + "' and tipmad_desc=pila_tipo ) as ConsumoDiario " & _
                "from pila inner join marmv on pila_id=marmv_pila ) " & _
                "union " & _
                "(select  distinct 'IngresoM ' + pila_tipo , (select COALESCE(SUM(cast(marmv_neto as float)/1000),0) from marmv inner join tipmad on marmv_tipmad=tipmad_ID where marmv_ingegr='I' " & _
                "and marmv_rechazado<>'S' and marmv_fecha>='" + UltDiaMesAnt + "' and marmv_fecha<='" + fchhasta + "' and tipmad_desc=pila_tipo ) as IngDiario " & _
                "from pila inner join marmv on pila_id=marmv_pila) " & _
                "union " & _
                "select 'TrBioM',COALESCE(SUM(cast(cant as float)),0)as TrMensual from TRMADBIO where " & _
                "fch>='" + UltDiaMesAnt + "' and fch<='" + fchhasta + "'" & _
                "union " & _
                "select 'TrBioD',COALESCE(SUM(cast(cant as float)),0)as TrDiario  from TRMADBIO where fch>='" + fechaant + "' and fch<='" + fchhasta + "'" & _
                "UNION " & _
                "select 'stkAct' + auxcont_tipmad , COALESCE(sum((cast(auxcont_stkini as float) + cast(auxcont_ingreso as float)  - cast(auxcont_consumo as float) + cast(auxcont_transpaso as float)) /1000),0) from auxcont " & _
                "where auxcont_userid='" + user + "' and auxcont_tipmad<>'A Picadora' " & _
                "group by auxcont_tipmad"

        '"select 'stkAct' + pila_tipo,COALESCE((cast(total as float)/1000),0) from stockplayatotalxvariedad"

        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        n = dt1.Rows.Count

        Dim datos As String

        For x = 0 To n - 1
            datos = dt1.Rows(x).Item("datos")
            total = dt1.Rows(x).Item("Totales")

            Select Case datos
                Case "StockAnt"
                    stkant = total

                    'Ingresos diarios
                Case "IngresoDiario"
                    ingD = total

                Case "IngresoD Blanca"
                    ingDB = total

                Case "IngresoD Colorada"
                    ingDC = total

                Case "IngresoD Vigas"
                    ingDV = total

                Case "IngresoD Diversas"
                    ingDO = total


                    'Ingresos Mensuales
                Case "IngresoM"
                    ingM = total

                Case "IngresoM Blanca"
                    ingMB = total

                Case "IngresoM Colorada"
                    ingMC = total

                Case "IngresoM Vigas"
                    ingMV = total

                Case "IngresoM Diversas"
                    ingMO = total


                    'Consumos Diarios
                Case "ConsumoDiario"
                    conD = total

                Case "ConsumoD Blanca"
                    conDB = total

                Case "ConsumoD Colorada"
                    conDC = total

                Case "ConsumoD Vigas"
                    conDV = total

                Case "ConsumoD Diversas"
                    conDO = total


                    'Consumos Mensuales

                Case "ConsumoM"
                    conM = total

                Case "ConsumoM Blanca"
                    conMB = total

                Case "ConsumoM Colorada"
                    conMC = total

                Case "ConsumoM Vigas"
                    conMV = total

                Case "ConsumoM Diversas"
                    conMO = total


                    'Stock Actuales

                Case "stkActBlanca"
                    stkActB = total

                Case "stkActColorada"
                    stkActC = total

                Case "stkActVigas"
                    stkActV = total

                Case "stkActDiversas"
                    stkActO = total

                Case "TrBioD"
                    TrD = total

                Case "TrBioM"
                    TrM = total


            End Select

        Next

        campos = "auxcontH_stkant,auxcontH_ingD,auxcontH_ingDB,auxcontH_ingDC,auxcontH_ingDV,auxcontH_ingDO, " & _
                "auxcontH_conD,auxcontH_conDB,auxcontH_conDC,auxcontH_conDV,auxcontH_conDO, " & _
                "auxcontH_ingM,auxcontH_ingMB,auxcontH_ingMC,auxcontH_ingMV,auxcontH_ingMO, " & _
                "auxcontH_conM,auxcontH_conMB,auxcontH_conMC,auxcontH_conMV,auxcontH_conMO, " & _
                "auxcontH_actstkB,auxcontH_actstkC,auxcontH_actstkV,auxcontH_actstkO," & _
                "auxcontH_userid,auxcontH_trd,auxcontH_trm"
        variables = "'" + Str(stkant) + "','" + Str(ingD) + "','" + Str(ingDB) + "','" + Str(ingDC) + "','" + Str(ingDV) + "','" + Str(ingDO) + "', " & _
                    "'" + Str(conD) + "','" + Str(conDB) + "','" + Str(conDC) + "','" + Str(conDV) + "','" + Str(conDO) + "', " & _
                    "'" + Str(ingM) + "','" + Str(ingMB) + "','" + Str(ingMC) + "','" + Str(ingMV) + "','" + Str(ingMO) + "', " & _
                    "'" + Str(conM) + "','" + Str(conMB) + "','" + Str(conMC) + "','" + Str(conMV) + "','" + Str(conMO) + "', " & _
                    "'" + Str(stkActB) + "','" + Str(stkActC) + "','" + Str(stkActV) + "','" + Str(stkActO) + "', " & _
                    "'" + user + "','" + Str(TrD) + "','" + Str(TrM) + "'"

        SQL3 = "INSERT INTO auxcontH(" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()

        ProgressBar1.Value = 100


        'Pasamos las fechas desde-hasta para que nos las muestre en el reporte
        'Son solamente visuales ya que no realizan ninguna consulta
        fechaant = dtfecha.Text
        fecha = dthasta.Text

        nivdet = "infcont"

        ''***************************************
        Dim frmtnpic As New frmreppicadora
        frmtnpic.Show()

        ProgressBar1.Value = 0
        Me.Cursor = Cursors.Default



    End Sub

    'para saber el ultimo dia del mes  anterior
    Function UltimoDiaDelMesAnt(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMesAnt = DateSerial(Year(dtmFecha), Month(dtmFecha), 0)
    End Function

    'para saber el ultimo dia del mes 
    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function


    Private Sub InfContMadRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtfecha.Text = DateSerial(Year(Now), Month(Now), 1)
    End Sub
End Class