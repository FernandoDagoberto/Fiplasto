Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient



Public Class InfContBioRep
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
         "SELECT ID,fecalta,tipo, " & _
         "(SELECT COALESCE(SUM(neto),0)FROM BIOMOV AS BIOMOV_2 " & _
         "WHERE(destino = 'P' OR ingegr='S') AND(pila = ID) AND (fecha <= '" + UltDiaMesAnt + "')) - " & _
         "(SELECT COALESCE(SUM(neto), 0)FROM BIOMOV AS BIOMOV_1 " & _
         "WHERE(ingegr = 'E') AND (pila = ID) AND (fecha <= '" + UltDiaMesAnt + "')) + " & _
         "(SELECT COALESCE(SUM(cant * - 1000), 0)FROM BIOTRAJINV AS BIO2 " & _
         "WHERE(depila = ID) AND (fch <= '" + UltDiaMesAnt + "')) + " & _
         "(SELECT COALESCE (SUM(cant * 1000), 0)FROM BIOTRAJINV AS BIO1 " & _
         "WHERE (apila = ID) AND (fch <= '" + UltDiaMesAnt + "')) " & _
         " + (SELECT COALESCE(SUM(cant * - 1000), 0)FROM TRMADBIO AS TRMADBIO_2 WHERE(depila = ID) AND (fch <='" + UltDiaMesAnt + "')) " & _
        " + (SELECT COALESCE (SUM(cant * 1000), 0)FROM TRMADBIO AS TRMADBIO_1 WHERE (apila = ID) AND (fch <= '" + UltDiaMesAnt + "')) - " & _
        "(SELECT COALESCE(SUM(neto), 0)FROM BIOMOV AS BIOMOV_1 WHERE(ingegr = 'V') " & _
         "AND (pila = ID) AND (fecha <= '" + UltDiaMesAnt + "'))AS Stock_Inicial, " & _
         "(SELECT (COALESCE(SUM(ABS(neto)), 0))FROM BIOMOV " & _
         "WHERE(destino = 'P' or ingegr= (case pila " & _
         "when 90 then  'V' else   '' " & _
         "end )) " & _
         "AND (pila = ID) and fecha>='" + UltDiaMesAnt + "' and fecha<='" + fchhasta + "') AS Ingresos, " & _
         "(SELECT COALESCE(SUM(neto), 0)FROM BIOMOV AS BIOMOV_1 " & _
         "WHERE(ingegr='E')AND (pila = ID)and fecha>='" + UltDiaMesAnt + "' and fecha<='" + fchhasta + "' ) AS Consumo, " & _
         "(SELECT COALESCE (SUM(cant * - 1000), 0)FROM BIOTRAJINV " & _
         "WHERE (depila = ID) and fch>='" + UltDiaMesAnt + "' and fch<='" + fchhasta + "') + " & _
         "(SELECT COALESCE(SUM(cant * 1000), 0)FROM BIOTRAJINV AS BIO1 " & _
         "WHERE (apila = ID)and fch>='" + UltDiaMesAnt + "' and fch<='" + fchhasta + "') " & _
        "+(SELECT COALESCE (SUM(cant * - 1000), 0)FROM TRMADBIO WHERE (depila = ID) and fch>='" + UltDiaMesAnt + "' and fch<='" + fchhasta + "') " & _
        "+ (SELECT COALESCE(SUM(cant * 1000), 0)FROM TRMADBIO AS TRMADBIO_1 WHERE (apila = ID)and fch>='" + UltDiaMesAnt + "' and fch<='" + fchhasta + "') AS Traspasos, " & _
         "'0','" + user + "' " & _
         "FROM BioPila INNER JOIN BioStock ON ID = pila " & _
         "UNION " & _
         "SELECT '0','','A Caldera','0', " & _
         "(SELECT COALESCE(SUM(neto),0)FROM BIOMOV WHERE(destino = 'C') AND (ingegr='I' OR ingegr = 'V') and fecha>='" + UltDiaMesAnt + "' and fecha<='" + fchhasta + "'), " & _
         "(SELECT COALESCE(SUM(neto),0)FROM BIOMOV WHERE(destino = 'C') AND (ingegr='I' OR ingegr = 'V') and fecha>='" + UltDiaMesAnt + "' and fecha<='" + fchhasta + "'), " & _
         "'0','0','" + user + "' " & _
         "from BIOMOV "


        cmd3 = New SqlCommand(sql, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()

        ProgressBar1.Value = 75

        sql1 = "select 'StockAnt' as Datos,sum(case when ingegr='E' then -1 else 1 end * (neto/1000)) + " & _
                "(select COALESCE(sum(case when ingegr='V' then -1 else 1 end * (neto/1000)),0) " & _
                "from BIOMOV where (ingegr='V' and destino='C') and fecha<='" + fechaant + "') " & _
                " + (select COALESCE(sum(cant),0) from TRMADBIO where fch<='" + fechaant + "') as Totales " & _
                "from BIOMOV where (ingegr in ('I','E','S') and (destino='P' or destino is null)) and fecha<='" + fechaant + "' " & _
                "union " & _
                "select 'IngresoDiario',COALESCE(SUM(cast(neto as float)/1000),0)as IngDiario  from BIOMOV where ingegr='I' and  fecha>='" + fechaant + "' and fecha<='" + fchhasta + "' " & _
                "union " & _
                "select 'ConsumoDiario',COALESCE(SUM(cast(neto as float)/1000),0) as ConsumoDiario  from BIOMOV where (ingegr='E' or destino='C') and fecha>='" + fechaant + "' and fecha<='" + fchhasta + "' " & _
                "union " & _
                "select 'IngresoM',COALESCE(SUM(cast(neto as float)/1000),0)as IngDiario  from BIOMOV where ingegr='I' and  fecha>='" + UltDiaMesAnt + "' and fecha<='" + fchhasta + "'" & _
                "union " & _
                "select 'ConsumoM',COALESCE(SUM(cast(neto as float)/1000),0)as ConsumoDiario  from BIOMOV where (ingegr='E' or destino='C') and fecha>='" + UltDiaMesAnt + "' and fecha<='" + fchhasta + "' " & _
                "union " & _
                "(select  distinct 'IngresoD ' + tipo , (select COALESCE(SUM(cast(neto as float)/1000),0) from BIOMOV  where ingegr='I' " & _
                    " and fecha>='" + fechaant + "'and fecha<='" + fchhasta + "' and tipmad=codmad ) as IngDiario " & _
                    "from BioPila inner join BIOMOV on id=pila) " & _
                "union " & _
                "(select distinct 'ConsumoD ' + tipo  , (select COALESCE(SUM(cast(neto as float)/1000),0) from BIOMOV  where (ingegr='E' or destino='C') " & _
                "and fecha>='" + fechaant + "'and fecha<='" + fchhasta + "' and tipmad=codmad ) as ConsumoDiario " & _
                "from BioPila inner join BIOMOV on id=pila ) " & _
                "union " & _
                "(select distinct 'ConsumoM ' + tipo  , (select COALESCE(SUM(cast(neto as float)/1000),0) from BIOMOV  where (ingegr='E' or destino='C') " & _
                "and fecha>='" + UltDiaMesAnt + "' and fecha<='" + fchhasta + "' and tipmad=codmad) as ConsumoDiario " & _
                "from BioPila inner join BIOMOV on id=pila ) " & _
                "union " & _
                "(select  distinct 'IngresoM ' + tipo , (select COALESCE(SUM(cast(neto as float)/1000),0) from BIOMOV  where ingegr='I' " & _
                "and  fecha>='" + UltDiaMesAnt + "' and fecha<='" + fchhasta + "'and tipmad=codmad ) as IngDiario " & _
                "from BioPila inner join BIOMOV on id=pila) " & _
                "UNION " & _
                "select 'TrBioM',COALESCE(SUM(cast(cant as float)),0)as TrMensual from TRMADBIO where " & _
                "fch>='" + UltDiaMesAnt + "' and fch<='" + fchhasta + "'" & _
                "UNION " & _
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
            If dt1.Rows(x).Item("Totales").ToString = "" Then
                total = 0
            Else
                total = dt1.Rows(x).Item("Totales")
            End If


            Select Case datos
                Case "StockAnt"
                    stkant = total

                    'Ingresos diarios
                Case "IngresoDiario"
                    ingD = total

                Case "IngresoD COMBUSTIBLE DIVERSAS"
                    ingDB = total

                Case "IngresoD COMBUSTIBLE COSTANEROS"
                    ingDC = total

                Case "IngresoD COMBUSTIBLE CHIPS"
                    ingDV = total

                Case "IngresoD MADERA COLORADA"
                    ingDO = total


                    'Ingresos Mensuales
                Case "IngresoM"
                    ingM = total

                Case "IngresoM COMBUSTIBLE DIVERSAS"
                    ingMB = total

                Case "IngresoM COMBUSTIBLE COSTANEROS"
                    ingMC = total

                Case "IngresoM COMBUSTIBLE CHIPS"
                    ingMV = total

                Case "IngresoM MADERA COLORADA"
                    ingMO = total


                    'Consumos Diarios
                Case "ConsumoDiario"
                    conD = total

                Case "ConsumoD COMBUSTIBLE DIVERSAS"
                    conDB = total

                Case "ConsumoD COMBUSTIBLE COSTANEROS"
                    conDC = total

                Case "ConsumoD COMBUSTIBLE CHIPS"
                    conDV = total

                Case "ConsumoD MADERA COLORADA"
                    conDO = total


                    'Consumos Mensuales

                Case "ConsumoM"
                    conM = total

                Case "ConsumoM COMBUSTIBLE DIVERSAS"
                    conMB = total

                Case "ConsumoM COMBUSTIBLE COSTANEROS"
                    conMC = total

                Case "ConsumoM COMBUSTIBLE CHIPS"
                    conMV = total

                Case "ConsumoM MADERA COLORADA"
                    conMO = total


                    'Stock Actuales

                Case "stkActCOMBUSTIBLE DIVERSAS"
                    stkActB = total

                Case "stkActCOMBUSTIBLE COSTANEROS"
                    stkActC = total

                Case "stkActCOMBUSTIBLE CHIPS"
                    stkActV = total

                Case "stkActMADERA COLORADA"
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
        Dim frmbio As New frmrepBiomasa
        frmbio.Show()

        ProgressBar1.Value = 0



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