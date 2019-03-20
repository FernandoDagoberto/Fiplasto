Option Explicit On
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports MetroFramework
Imports System.Reflection

Public Class MenuPrincipal
    Dim dirini, dec As String
    Dim ptomn As String
    Dim tela As String
    Dim tqbl As String
    Dim TareaNoRealizada, ms As Integer
    Dim UltDiaMesAnt As Date

    Dim funciones As New Fnmenu
    Dim usrMenu As New cMenu
    Dim f, formActivo As Forms.MetroForm
    Private existe As Forms.MetroForm
    Dim key As String



    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datosini()
        '**************** Control de configuración ***************************

        dec = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        If dec = "," Then
            '*******Creo mi propia configuracion regional
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
            System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
            System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
            dec = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator
        End If

        Dim log As New Login
        log.ShowDialog(Me)
        log.Dispose()

        '**************** Resticcion segun perfil ****************************
        Call ARMAMENU()
        '********************************************************************

        tssluser.Text = user

        'Identifico en la barra de estado que base estoy usando sí ingreso con perfil 1
        If perfil = "1" Then
            tsslBase.Visible = True

            If BDSelection = "P" Then
                tsslBase.Text = "BASE DE PRUEBAS"
            Else
                tsslBase.Text = "BASE REAL"
            End If
        End If



        Call controlaLV()
        Call controlaTELAS()
        Call controlaTQBL()

        Call NovSinLeer()
        Call RemitosNoCargados()




    End Sub


    Sub NovSinLeer()
        sql = "SELECT * FROM NOVEDADES INNER JOIN MOTIVONOV ON NOVEDADES.nov_motivo = MOTIVONOV.MotivoNov_desc INNER JOIN " &
              "USUARIOS ON MOTIVONOV.MotivoNov_id = USUARIOS.user_novsec WHERE NOVEDADES.nov_visto IS NULL AND (USUARIOS.user_apenom = '" + user + "') and nov_fecha>='20161201' and nov_fecha<='" + Now + "'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

        If n = 0 Then

        Else
            ms = MetroMessageBox.Show(Me, "Tiene:" & " " & "" + Str(n) + " novedades sin leer" & Chr(13) & "Desea ir al formulario de notificación de novedades", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If ms = 1 Then
                SenNov = "SINLEER"
                motivo = dt.Rows(0).Item("nov_motivo")

                Dim novVisto As New NovedadesVisto
                novVisto.MdiParent = Me
                novVisto.Show()
            End If
        End If

    End Sub

    'para saber el ultimo dia del mes  anterior
    Function UltimoDiaDelMesAnt(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMesAnt = DateSerial(Year(dtmFecha), Month(dtmFecha), 0)
    End Function

    Sub RemitosNoCargados()
        'PARA MOSTRAR SOLO A LOS SUPERVISORES
        If perfil = "4" Then

            'Calcula el último día del mes anterior teniendo el cuenta la fecha DESDE
            UltDiaMesAnt = UltimoDiaDelMesAnt(Now())
            Try
                'Cambio el cursor
                Me.Cursor = Cursors.WaitCursor

                conexA("camion")
                fecha = Format(Now(), "MM/dd/yyyy")

                sql = "SELECT * From REPORTE WHERE fecha_2>#" + Format(UltDiaMesAnt, "MM/dd/yyyy") + "# and fecha_2<#" + fecha + "# and p_codigo in (16,17,18,21) and aux3>'0' order by aux3"
                daA = New OleDbDataAdapter(sql, cnnA)
                dt = New DataTable
                daA.Fill(dt)
                n = dt.Rows.Count

                Dim barra As Double
                barra = 100 / n
                tssBarra.Visible = True

                Dim rmtmensaje As String

                For y = 0 To n - 1
                    Dim nroremito As String
                    nroremito = dt.Rows(y).Item("aux3")
                    sql1 = "SELECT * FROM CAMION WHERE CAMION_NROREMITO='" + nroremito + "'"
                    da1 = New SqlDataAdapter(sql1, cnn)
                    dt1 = New DataTable
                    da1.Fill(dt1)
                    m = dt1.Rows.Count
                    Dim incremento As Double
                    incremento = incremento + barra
                    tssBarra.Value = incremento

                    If m = 0 Then
                        rmtmensaje = rmtmensaje + Chr(13) + nroremito
                    End If

                Next
                If rmtmensaje = "" Then
                    Me.Cursor = Cursors.Default
                    tssBarra.Visible = False
                Else
                    MetroMessageBox.Show(Me, "Faltan cargar los siguiente remitos: " & rmtmensaje, "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Cursor = Cursors.Default
                    tssBarra.Visible = False
                End If
            Catch

                Exit Sub
            End Try

        End If



    End Sub


    Sub controlaLV()

        Dim advertencia As Integer
        Dim ultfch As Date

        '*****************Perfil de Máquina Continua
        If perfil = "6" Then
            '******************************

            TimerMCLV.Start()

            For x = 1 To 2

                sql = "select max(limvac_fecha) as ult from MCLIMPVACIO where limvac_mc='" + Trim(Str(x)) + "'"
                da = New SqlDataAdapter(sql, cnn)
                dt = New DataTable
                da.Fill(dt)
                n = dt.Rows.Count

                If IsDBNull(dt.Rows(0).Item("ult")) Then

                Else

                    ultfch = dt.Rows(0).Item("ult")
                    Dim diferenciahs As Integer
                    diferenciahs = DateDiff(DateInterval.Hour, ultfch, Now)

                    limites("adverMCLV")
                    advertencia = dt8.Rows(0).Item("param_valor")

                    If diferenciahs >= advertencia Then

                        diferenciahs = Int(diferenciahs / 24)


                        Call buscamaxtarea()
                        'se crea una nueva tarea

                        creatarea = "limpvacio"
                        Call GuardaTarea()
                        Call GuardaFrecuencia()

                        MetroMessageBox.Show(Me, "Hace " + Str(diferenciahs) + " días que no se realiza una limpieza de vacios." + Chr(13) + "Se ha generado una nueva tarea. Favor de revisar Formulario de tareas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If

            Next

        End If


    End Sub

    Sub controlaTELAS()

        Dim advertenciaTela As Integer
        Dim ultfchTela As Date
        Dim tipoTela As String

        '*****************Perfil de Máquina Continua
        If perfil = "6" Then
            '******************************

            TimerMCTELAS.Start()

            sql1 = "select telas_tela from MCTELAS"
            da1 = New SqlDataAdapter(sql1, cnn)
            dt1 = New DataTable
            da1.Fill(dt1)
            m = dt1.Rows.Count

            For x = 0 To m - 1

                sql2 = "select max(camtela_fecha) as ult from MCCAMTELAS where camtela_tela='" + Trim(dt1.Rows(x).Item("telas_tela")) + "'"
                da2 = New SqlDataAdapter(sql2, cnn)
                dt2 = New DataTable
                da2.Fill(dt2)
                n = dt2.Rows.Count


                tela = Trim(dt1.Rows(x).Item("telas_tela"))

                If IsDBNull(dt2.Rows(0).Item("ult")) Then

                Else

                    ultfchTela = dt2.Rows(0).Item("ult")
                    Dim diferenciahsTela As Integer
                    diferenciahsTela = DateDiff(DateInterval.Hour, ultfchTela, Now)

                    limites("adverMCTELAS")
                    advertenciaTela = dt8.Rows(0).Item("param_valor")

                    If diferenciahsTela >= advertenciaTela Then

                        'Pasar horas a días
                        diferenciahsTela = Int(diferenciahsTela / 24)

                        Call buscaTareaPendiente(tela)

                        If TareaNoRealizada = 1 Then
                            Call buscamaxtarea()
                            'se crea una nueva tarea
                            creatarea = "tela"
                            Call GuardaTarea()
                            Call GuardaFrecuencia()

                            MetroMessageBox.Show(Me, "Hace " + Str(diferenciahsTela) + " días que no se realiza el cambio de la tela: " + tela + " " + Chr(13) + "Se ha generado una nueva tarea. Favor de revisar Formulario de tareas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else

                        End If
                        MetroMessageBox.Show(Me, "Realizar cambio de tela:  " + tela + "", "", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    End If
                End If

            Next

        End If


    End Sub


    Sub controlaTQBL()

        Dim advertenciaTQBL As Integer
        Dim ultfchTQBL As Date

        '*****************Perfil de Máquina Continua
        If perfil = "6" Then
            '******************************

            TimerMCTQBL.Start()

            sql2 = "select max(mctqbl_fecha) as ult from MCTQBL"
            da2 = New SqlDataAdapter(sql2, cnn)
            dt2 = New DataTable
            da2.Fill(dt2)
            n = dt2.Rows.Count

            If IsDBNull(dt2.Rows(0).Item("ult")) Then

            Else

                ultfchTQBL = dt2.Rows(0).Item("ult")
                Dim diferenciahsTQ As Integer
                diferenciahsTQ = DateDiff(DateInterval.Hour, ultfchTQBL, Now)

                limites("adverMCTQ")
                advertenciaTQBL = dt8.Rows(0).Item("param_valor")

                tqbl = "Tanque de agua blanca"

                If diferenciahsTQ >= advertenciaTQBL Then

                    'Pasar horas a días
                    diferenciahsTQ = Int(diferenciahsTQ / 24)

                    Call buscaTareaPendiente(tqbl)

                    If TareaNoRealizada = 1 Then
                        Call buscamaxtarea()
                        'se crea una nueva tarea
                        creatarea = "TQBL"
                        Call GuardaTarea()
                        Call GuardaFrecuencia()

                        MetroMessageBox.Show(Me, "Hace " + Str(diferenciahsTQ) + " días que no se realiza la limpieza del tanque de agua blanca" + Chr(13) + "Se ha generado una nueva tarea. Favor de revisar Formulario de tareas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else

                    End If
                    MetroMessageBox.Show(Me, "Realizar limpieza del tanque de agua blanca")


                End If
            End If



        End If


    End Sub




    Private Sub buscaTareaPendiente(ByVal descripcion As String)
        conex("tareas")
        sql4 = "SELECT max(tarea_fchcre)as ult From tareas where tarea_desc like '%" + descripcion + "%' and tarea_estado is null"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)

        Dim fchtarea As Date
        If IsDBNull(dt4.Rows(0).Item("ult")) Then
            TareaNoRealizada = 1

        Else
            fchtarea = dt4.Rows(0).Item("ult")

            Dim diferenciahsTarea As Integer
            diferenciahsTarea = DateDiff(DateInterval.Hour, fchtarea, Now)

            '168 hs es igual a 7 días
            If diferenciahsTarea <= 168 Then

            Else
                sql4 = "update tareas set tarea_estado='N', tarea_fchestado='" + Now + "',tarea_obs='Tiempo Incumplido. Se generó una nueva tarea' where tarea_fchcre='" + fchtarea + "' and tarea_desc like '%" + descripcion + "%' "
                cmd4 = New SqlCommand(sql4, cnn)
                cmd4.Connection.Open()
                cmd4.ExecuteNonQuery()
                cmd4.Connection.Close()

                TareaNoRealizada = 1
            End If

        End If

    End Sub

    Private Sub buscamaxtarea()
        conex("tareas")
        sql2 = "SELECT max(tarea_id)as ult From tareas ;"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)

        If IsDBNull(dt2.Rows(0).Item("ult")) Then
            ultnro = "1"
        Else
            ultnro = dt2.Rows(0).Item("ult") + 1
        End If
    End Sub

    Sub GuardaTarea()
        If Format(Now, "HH:mm:ss") >= "06:00:00" And Format(Now, "HH:mm:ss") < "14:00:00" Then
            turno = "06-14"
        ElseIf Format(Now, "HH:mm:ss") >= "14:00:00" And Format(Now, "HH:mm:ss") < "22:00:00" Then
            turno = "14-22"
        Else
            turno = "22-06"
        End If

        campos = "tarea_id,tarea_fchcre,tarea_emisor,tarea_fchini,tarea_fchfin,tarea_area,tarea_turno,tarea_asunto,tarea_desc"

        If creatarea = "tela" Then
            variables = "'" + ultnro + "','" + Now + "','" + user + "','" + FormatDateTime(Now, DateFormat.ShortDate) + "','', " &
            "'MC','" + turno + "','Realizar cambio de tela' ,'Realizar Cambio de tela: " + tela + "'"
        ElseIf creatarea = "limpvacio" Then
            variables = "'" + ultnro + "','" + Now + "','" + user + "','" + FormatDateTime(Now, DateFormat.ShortDate) + "','', " &
            "'MC','" + turno + "','Realizar limpieza de Vacio' ,'Realizar Limpieza de Vacio de Línea: " + Trim(Str(x)) + "' "
        ElseIf creatarea = "TQBL" Then
            variables = "'" + ultnro + "','" + Now + "','" + user + "','" + FormatDateTime(Now, DateFormat.ShortDate) + "','', " &
            "'MC','" + turno + "','Realizar limpieza de Tanque' ,'Realizar Limpieza de Tanque de Agua Blanca' "
        End If



        SQL3 = "INSERT INTO TAREAS (" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()


    End Sub

    Sub GuardaFrecuencia()

        campos = "tarea_id,frecu_id,frecu_cada,frecu_repe"
        variables = "'" + ultnro + "','D','1','0'"
        sql4 = "INSERT INTO TAREA_FRECU (" + campos + ") VALUES (" + variables + ")"
        cmd4 = New SqlCommand(sql4, cnn)
        cmd4.Connection.Open()
        cmd4.ExecuteNonQuery()
        cmd4.Connection.Close()



    End Sub


    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNASalir.Click
        Me.Close()
    End Sub

    Private Sub MNACambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNACambio.Click
        perfil = ""
        user = ""


        Dim log As New Login
        log.ShowDialog(Me)
        log.Dispose()

        'MNATablas.Visible = True

        '**************** Resticcion segun perfil ****************************
        Call ARMAMENU()
        '********************************************************************



    End Sub

    Private Sub ARMAMENU()
        Try
            If perfil <> "1" Then
                Call conex("MNUPERFIL")
                sql7 = "SELECT mnuperfil_menu From MNUPERFIL WHERE MNUPERFIL_ID=" + perfil
                da7 = New SqlDataAdapter(sql7, cnn)
                dt7 = New DataTable
                da7.Fill(dt7)
                n = dt7.Rows.Count
                If n = 0 Then
                    If perfil <> "1" Then
                        MetroMessageBox.Show(Me, "No existe menú definido para el perfil de este usuario." + Chr(13) + "Favor de definirlo y probar nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End If
                Else
                    For a = 0 To n - 1
                        ptomn = dt7.Rows(a).Item("mnuperfil_menu")


                        '## Menu Archivos ##


                        '-- CONFIGURACION--
                        If ptomn = "MNACONFIGURACION" Then
                            MNAConfiguracion.Visible = False
                        End If

                        '---------------Configuración PERMISOS--
                        If ptomn = "MNACPERMISOS" Then
                            MNACPermisos.Visible = False
                        End If


                        '---------------Configuración ARMADO MENU--
                        If ptomn = "MNACARMADO" Then
                            MNACArmado.Visible = False
                        End If



                        '-- Tablas--
                        If ptomn = "MNATABLAS" Then

                            MNATablas.Visible = False
                        End If

                        '== Tablas Alistamiento ==
                        If ptomn = "MNATALISTAMIENTO" Then
                            MNATAlistamiento.Visible = False
                        End If
                        '.. Alistamiento - Productos ..
                        If ptomn = "MNATAPRODUCTOS" Then
                            MNATAProductos.Visible = False
                        End If



                        '== Tablas Básicos ==
                        If ptomn = "MNATBASICOS" Then
                            MNATBasicos.Visible = False
                        End If
                        '.. Playa de Madera ..
                        If ptomn = "MNATBPLAYA" Then
                            MNATBPlaya.Visible = False
                        End If

                        If ptomn = "MNATBPMADERA" Then
                            MNATBPMadera.Visible = False
                        End If
                        If ptomn = "MNATBPPILAS" Then
                            MNATBPPilas.Visible = False
                        End If
                        If ptomn = "MNATBPMOTIVOS" Then
                            MNATBPMotivos.Visible = False
                        End If
                        If ptomn = "MNATBPCAUSA" Then
                            MNATBPCausa.Visible = False
                        End If
                        If ptomn = "MNATBPMOTIVOSPI" Then
                            MNATBPMotivosPI.Visible = False
                        End If


                        'Tabla Básicos Desfibrador
                        If ptomn = "MNATBDESFIBRADOR" Then
                            MNATBDesfibrador.Visible = False
                        End If
                        'Tabla Básicos Máquina Continua
                        If ptomn = "MNATBCONTINUA" Then
                            MNATBContinua.Visible = False
                        End If


                        'Tabla Básicos Cargador de zorras
                        If ptomn = "MNATBCZORRAS" Then
                            MNATBCZorras.Visible = False
                        End If

                        '---------------Tabla Básicos CZ Zorras
                        If ptomn = "MNATBCZZORRAS" Then
                            MNATBCZZorras.Visible = False
                        End If
                        '---------------Tabla Básicos CZ DEFECTOS
                        If ptomn = "MNATBCZDEFECTOS" Then
                            MNATBCZDefectos.Visible = False
                        End If
                        '---------------Tabla Básicos CZ DEFECTOS DESCALIFICANTES
                        If ptomn = "MNATBCZDESCALIF" Then
                            MNATBCZDescalif.Visible = False
                        End If
                        '---------------Tabla Básicos CZ AVERIAS
                        If ptomn = "MNATBCZAVERIAS" Then
                            MNATBCZAverias.Visible = False
                        End If



                        'Tabla - Básicos - LAVADERO
                        If ptomn = "MNATBLAV" Then
                            MNATBLav.Visible = False
                        End If

                        '---------------Tabla - Básicos - LAVADERO - Decorativo
                        If ptomn = "MNATBLDECO" Then
                            MNATBLDeco.Visible = False
                        End If

                        '---------------Tabla - Básicos - LAVADERO - Inoxidables
                        If ptomn = "MNATBLINOX" Then
                            MNATBLInox.Visible = False
                        End If





                        '== TABLA Revestidos ==
                        If ptomn = "MNATREVESTIDOs" Then
                            MNATRevestidos.Visible = False
                        End If
                        '== TABLA Usuarios ==
                        If ptomn = "MNATUSUARIOS" Then
                            MNATUsuarios.Visible = False
                        End If
                        '== TABLA Perfil ==
                        If ptomn = "MNATPERFIL" Then
                            MNATPerfil.Visible = False
                        End If
                        '== TABLA Unidades ==
                        If ptomn = "MNATUNIDADES" Then
                            MNATUnidades.Visible = False
                        End If
                        '== TABLA Maquinas ==
                        If ptomn = "MNATMAQUINAS" Then
                            MNATMAQUINAS.Visible = False
                        End If
                        '== TABLA Area ==
                        If ptomn = "MNATAREA" Then
                            MNATArea.Visible = False
                        End If
                        '== TABLA Sector ==
                        If ptomn = "MNATSECTOR" Then
                            MNATSECTOR.Visible = False
                        End If
                        '== TABLA Causa ==
                        If ptomn = "MNATCAUSA" Then
                            MNATCAUSA.Visible = False
                        End If
                        '== TABLA Motivo ==
                        If ptomn = "MNATMOTIVO" Then
                            MNATMOTIVO.Visible = False
                        End If
                        '== TABLA Paradas ==
                        If ptomn = "MNATPARADAS" Then
                            MNATPARADAS.Visible = False
                        End If



                        '******************************************************************'
                        '##MENÚ PORTERIA##
                        ' Portería 
                        If ptomn = "MNPORTERIA" Then
                            MNPorteria.Visible = False
                        End If
                        'Ingreso Remito
                        If ptomn = "MNPREMITOS" Then
                            MNPRemitos.Visible = False
                        End If
                        'Salida Camión
                        If ptomn = "MNPSALIDA" Then
                            MNPSalida.Visible = False
                        End If






                        '***************************************************************
                        '## MENÚ BÁSICOS ## 
                        If ptomn = "MNBASICOS" Then
                            MNBasicos.Visible = False
                        End If
                        '-- Playa y Picadora --}
                        If ptomn = "MNBPLAYA" Then
                            MNBPlaya.Visible = False
                        End If
                        '== Playa Y Picadora ==
                        'Recepción de Madera
                        If ptomn = "MNBPRECEPCION" Then
                            MNBPRecepcion.Visible = False
                        End If
                        'Consumo de Madera'PILAPIC
                        If ptomn = "MNBPCONSUMO" Then
                            MNBPConsumo.Visible = False
                        End If
                        'Nivel de Silos
                        If ptomn = "MNBPNIVEL" Then
                            MNBPNivel.Visible = False
                        End If
                        'Ajuste de inventario
                        If ptomn = "MNBPAJUSTE" Then
                            MNBPAjuste.Visible = False
                        End If
                        'Transferencia a VigasTareas
                        If ptomn = "MNBPTRAVIG" Then
                            MNBPTravig.Visible = False
                        End If
                        'Transferencia de Madera a Biomasa
                        If ptomn = "MNBPTRAVIG" Then
                            MNBPTravig.Visible = False
                        End If




                        '-- Desfibrador --
                        If ptomn = "MNBDESFIBRADOR" Then
                            MNBDesfibrador.Visible = False
                        End If
                        '== Desfibrador ==
                        '=Control Solución Sulfato Aluminio=
                        If ptomn = "MNBDCRTLSSA" Then
                            MNBDCrtlssa.Visible = False
                        End If
                        'Bolsas
                        If ptomn = "MNBDCBOLSAS" Then
                            MNBDCBolsas.Visible = False
                        End If
                        'Ensayos
                        If ptomn = "MNBCDENSAYOS" Then
                            MNBDCEnsayos.Visible = False
                        End If

                        '=Control Visual de Fibras=
                        If ptomn = "MNBDCRTLVF" Then
                            MNBDCrtlvf.Visible = False
                        End If

                        '=Control Variables Precalentador
                        If ptomn = "MNBDCRTLVAR" Then
                            MNBDCrtlvar.Visible = False
                        End If






                        '-- Máquina Continua --
                        If ptomn = "MNBCONTINUA" Then
                            MNBContinua.Visible = False
                        End If
                        'MC - Variables del proceso
                        If ptomn = "MNBCVARPROC" Then
                            MNBCVarproc.Visible = False
                        End If
                        'MC - Cambio de Cuchillas
                        If ptomn = "MNBCCUCHILLAS" Then
                            MNBCCuchillas.Visible = False
                        End If
                        'MC - Preparación de Parafina
                        If ptomn = "MNBCPARAFINA" Then
                            MNBCParafina.Visible = False
                        End If
                        'MC - Consumo de Parafina
                        If ptomn = "MNBCCONSUMO" Then
                            MNBCConsumo.Visible = False
                        End If
                        'MC - Hipoclorito
                        If ptomn = "MNBCHIPOCLORITO" Then
                            MNBCHipoclorito.Visible = False
                        End If
                        'MC - Limpieza de Vacíos (MC1-MC2)
                        If ptomn = "MNBCLIMVAC" Then
                            MNBCLimvac.Visible = False
                        End If
                        'MC - Ensayos
                        If ptomn = "MNBCENSAYOS" Then
                            MNBCEnsayos.Visible = True
                        End If
                        'MC - Telas
                        If ptomn = "MNBCTELAS" Then
                            MNBCTelas.Visible = True
                        End If
                        'MC - Limpieza de Valvulas y cañerias de Vacíos (MC2)
                        If ptomn = "MNBCLVALVULAS" Then
                            MNBCLValvulas.Visible = False
                        End If



                        '-- LAVADERO --
                        If ptomn = "MNBLAVADERO" Then
                            MNBLavadero.Visible = False
                        End If
                        'LAV - Tejidos Doble Hilado
                        If ptomn = "MNBLTDH" Then
                            MNBLTdh.Visible = False
                        End If
                        'LAV - Chapas de transporte
                        If ptomn = "MNBLCHTR" Then
                            MNBLChtr.Visible = False
                        End If
                        'LAV - Cambio de cubreplacas
                        If ptomn = "MNBLPLACA" Then
                            MNBLPlaca.Visible = False
                        End If
                        'LAV - INOXIDABLES
                        If ptomn = "MNBLINOX" Then
                            MNBLInox.Visible = False
                        End If
                        'LAV - DECORATIVOS
                        If ptomn = "MNBLDECO" Then
                            MNBLDeco.Visible = False
                        End If
                        'LAV - Limpieza de cubas
                        If ptomn = "MNBLCUBAS" Then
                            MNBLCubas.Visible = False
                        End If
                        'LAV - Preparación de soda caustica
                        If ptomn = "MNBLSODA" Then
                            MNBLSoda.Visible = False
                        End If
                        'LAV - Preparación de soda caustica
                        If ptomn = "MNBLREPARACIONES" Then
                            MNBLReparaciones.Visible = False
                        End If
















                        '-- Prensa --
                        If ptomn = "MNBPRENSA" Then
                            MNBPrensa.Visible = False
                        End If


                        '-- Cargador de zorras --
                        If ptomn = "MNBCARGADOR" Then
                            MNBCargador.Visible = False
                        End If
                        '*******CZ Tableros Cargados******
                        If ptomn = "MNBCZTABLEROS" Then
                            MNBCZTableros.Visible = False
                        End If
                        '*******CZ Controles Dimensionales******
                        If ptomn = "MNBCZCTRL" Then
                            MNBCZCtrl.Visible = False
                        End If
                        '*******CZ Registro de espesores******
                        If ptomn = "MNBCZESPESORES" Then
                            MNBCZEspesores.Visible = False
                        End If
                        '*******CZ Registro descartes******
                        If ptomn = "MNBCZDESCARTES" Then
                            MNBCZDescartes.Visible = False
                        End If
                        '*******CZ Registro ROTULADOR******
                        If ptomn = "MNBCZROTULADOR" Then
                            MNBCZRotulador.Visible = False
                        End If
                        '*******CZ Estado del parque de zorras******
                        If ptomn = "MNBCZESTADO" Then
                            MNBCZEstado.Visible = False
                        End If
                        '*******CZ Confirmación de reparación de zorras******
                        If ptomn = "MNBCZCONFIRMACION" Then
                            MNBCZConfirmacion.Visible = False
                        End If





                        '-- Alistamiento --
                        If ptomn = "MNBALISTAMIENTO" Then
                            MNBAlistamiento.Visible = False
                        End If

                        '-- Novedades --
                        If ptomn = "MNBNOVEDADES" Then
                            MNBNovedades.Visible = False
                        End If
                        '--Paradas--
                        If ptomn = "MNBPARADAS" Then
                            MNBParadas.Visible = False
                        End If
                        '--Tareas--
                        If ptomn = "MNBTAREAS" Then
                            MNBTareas.Visible = False
                        End If

                        '--Notificación de Novedades--
                        If ptomn = "MNBNOTNOV" Then
                            MNBNotNov.Visible = False
                        End If

                        '--Modificación de Remito--
                        If ptomn = "MNBMREMITO" Then
                            MNBMremito.Visible = False
                        End If




                        '************************************************************
                        '## Revestidos ##
                        If ptomn = "MNREVESTIDOS" Then
                            MNRevestidos.Visible = False
                        End If
                        '-- Cortes Industriales --
                        If ptomn = "MNRCORTES" Then
                            MNRCortes.Visible = False
                        End If
                        '-- Línea III--
                        If ptomn = "MNRLIII" Then
                            MNRLIII.Visible = False
                        End If

                        '***************************************************************
                        '## Reportes##
                        If ptomn = "MNREPORTES" Then
                            MNReportes.Visible = False
                        End If

                        '-- GENERALES --}
                        If ptomn = "MNRGENERALES" Then
                            MNRGenerales.Visible = False
                        End If
                        '== Generales ==
                        'Area
                        If ptomn = "MNRGAREA" Then
                            MNRGArea.Visible = False
                        End If
                        'Causa
                        If ptomn = "MNRGCAUSA" Then
                            MNRGCausa.Visible = False
                        End If
                        'Máquinas
                        If ptomn = "MNRGMAQUINAS" Then
                            MNRGMaquinas.Visible = False
                        End If
                        'Motivo
                        If ptomn = "MNRGMOTIVO" Then
                            MNRGMotivo.Visible = False
                        End If
                        'Paradas
                        If ptomn = "MNRGPARADAS" Then
                            MNRGParadas.Visible = False
                        End If
                        'Reparo
                        If ptomn = "MNRGREPARO" Then
                            MNRGReparo.Visible = False
                        End If
                        'Sector
                        If ptomn = "MNRGSECTOR" Then
                            MNRGSector.Visible = False
                        End If
                        'Reporte de Novedades
                        If ptomn = "MNRGNOVEDADES" Then
                            MNRGNovedades.Visible = False
                        End If

                        '-- Alistamiento --}
                        If ptomn = "MNRAlistamiento" Then
                            MNRAlistamiento.Visible = False
                        End If


                        '-- PICADORA --}
                        If ptomn = "MNRPICADORA" Then
                            MNRPicadora.Visible = False
                        End If
                        '== Picadora ==
                        'Tipos de Madera
                        If ptomn = "MNRPTIPMAD" Then
                            MNRPTipmad.Visible = False
                        End If
                        'Tn de Madera Picada Diario y Mensual
                        If ptomn = "MNRPTNPIC" Then
                            MNRPTnpic.Visible = False
                        End If
                        'Stock de Madera en Playa
                        If ptomn = "MNRPSTVAR" Then
                            MNRPStvar.Visible = False
                        End If
                        'Nivel de Silos
                        If ptomn = "MNRPNIVSILOS" Then
                            MNRPNivsilos.Visible = False
                        End If
                        'Informe de producción Madera
                        If ptomn = "MNRPINFPROD" Then
                            MNRPInfprod.Visible = False
                        End If
                        'Informe de Eficiencia Madera
                        If ptomn = "MNRPEFIPIC" Then
                            MNRPEfiPic.Visible = False
                        End If
                        'Informe de Ajuste de Inventario - Transferencia a Vigas
                        If ptomn = "MNRPAJINVTRVIG" Then
                            MNRPAjinvtrvig.Visible = False
                        End If
                        'Informe de Ingreso de Camiones
                        If ptomn = "MNRPINGCAM" Then
                            MNRPIngcam.Visible = False
                        End If



                        '{-- REPORTES M48 --}
                        If ptomn = "MNRM48" Then
                            MNRM48.Visible = False
                        End If


                        '{-- REPORTES MC --}
                        If ptomn = "MNRMC" Then
                            MNRMc.Visible = False
                        End If

                        '{-- REPORTES Cargador de Zorras --}
                        If ptomn = "MNRCZ" Then
                            MNRCZ.Visible = False
                        End If


                        '{-- REPORTES LAVADERO --}
                        If ptomn = "MNRLAV" Then
                            MNRLav.Visible = False
                        End If

                        '{-- REPORTES BIOMASA --}
                        If ptomn = "MNRBIOMASA" Then
                            MNRBiomasa.Visible = False
                        End If


                        '-----Informe Paradas-----
                        If ptomn = "MNRPARADAS" Then
                            MNRParadas.Visible = False
                        End If

                        '-----INFORME TAREAS-----
                        If ptomn = "MNRTAREAS" Then
                            MNRTareas.Visible = False
                        End If

                        '-----INFORME HS PRODUCCIÓN-----
                        If ptomn = "MNRHSPROD" Then
                            MNRHsprod.Visible = False
                        End If


                        '************************************************************************
                        '## BIOMASA ##
                        If ptomn = "MNBIOMASA" Then
                            MNBiomasa.Visible = False
                        End If
                        '-- Ingresos y Consumos --
                        If ptomn = "MNBIYC" Then
                            MNBIyC.Visible = False
                        End If
                        '-- AJUSTES--
                        If ptomn = "MNBAJ" Then
                            MNBAj.Visible = False
                        End If



                        '************************************************************************
                        '## MADERA ##
                        If ptomn = "MNMADERA" Then
                            MNMadera.Visible = False
                        End If
                        '-- REMITOS --
                        If ptomn = "MNMREMITOS" Then
                            MNMRemitos.Visible = False
                        End If
                        '-- PROVEEDORES--
                        If ptomn = "MNMPROVEEDORES" Then
                            MNMProveedores.Visible = False
                        End If
                        '-- CAMPOS--
                        If ptomn = "MNMCAMPOS" Then
                            MNMCampos.Visible = False
                        End If
                        '-- REPORTES--
                        If ptomn = "MNMREPORTES" Then
                            MNMReportes.Visible = False
                        End If



                        '## PANEL ##
                        If ptomn = "MNPANEL" Then
                            MNPANEL.Visible = False
                        End If



                    Next

                End If

            Else


            End If
        Catch
            MetroMessageBox.Show(Me, ErrorToString)
            Me.Close()
        End Try

    End Sub







    Private Sub MNATBPMadera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATBPMadera.Click
        Dim tm As New ABMTipMad
        tm.MdiParent = Me
        tm.Show()
    End Sub

    Private Sub MNATUnidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATUnidades.Click
        Dim uni As New ABMUnidades
        uni.MdiParent = Me
        uni.Show()
    End Sub

    Private Sub MNATUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATUsuarios.Click
        Dim usu As New abmusuario
        usu.MdiParent = Me
        usu.Show()
    End Sub

    Private Sub MNATBPMotivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATBPMotivos.Click
        Dim motiv As New ABMMotivosNC
        motiv.MdiParent = Me
        motiv.Show()
    End Sub

    Private Sub MNATBPPilas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATBPPilas.Click
        Dim pila As New ABMPila
        pila.MdiParent = Me
        pila.Show()
    End Sub

    Private Sub MNATBPCausa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATBPCausa.Click
        Dim Cpila As New ABMCausaPilaInc
        Cpila.MdiParent = Me
        Cpila.Show()
    End Sub

    Private Sub MNATMAQUINAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATMAQUINAS.Click
        Dim mAQ As New ABMMaquinas
        mAQ.MdiParent = Me
        mAQ.Show()
    End Sub

    Private Sub MNTSECTOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim are As New ABMSector
        are.MdiParent = Me
        are.Show()
    End Sub

    Private Sub MNATPARADAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATPARADAS.Click
        Dim PAR As New ABMParadas
        PAR.MdiParent = Me
        PAR.Show()
    End Sub

    Private Sub MNATCAUSA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATCAUSA.Click
        Dim ca1 As New ABMCausa
        ca1.MdiParent = Me
        ca1.Show()
    End Sub

    Private Sub MNATMOTIVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATMOTIVO.Click
        Dim mot As New ABMMotivo
        mot.MdiParent = Me
        mot.Show()
    End Sub

    Private Sub MNATSECTOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATSECTOR.Click
        Dim sec As New ABMSector
        sec.MdiParent = Me
        sec.Show()
    End Sub


    Private Sub MNPRemitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNPRemitos.Click
        Dim ingrem As New IngresoRemito
        ingrem.MdiParent = Me
        ingrem.Show()
    End Sub

    Private Sub MNBPRecepcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBPRecepcion.Click
        Dim rmad As New RecepcionMadera
        rmad.MdiParent = Me
        rmad.Show()
    End Sub


    Private Sub SalidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNPSalida.Click
        Dim smad As New SalidaCamion
        smad.MdiParent = Me
        smad.Show()
    End Sub




    Private Sub MNATArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATArea.Click
        Dim area As New ABMArea
        area.MdiParent = Me
        area.Show()
    End Sub


    Private Sub MNACPermisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNACPermisos.Click
        Dim permi As New permisos
        permi.MdiParent = Me
        permi.Show()
    End Sub


    Private Sub MNBNovedades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBNovedades.Click
        Dim nov As New Novedades
        nov.MdiParent = Me
        nov.Show()
    End Sub

    Private Sub MNRGArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRGArea.Click

        sql = "select area_id as ID,area_desc as Descripcion from area"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        nivdet = "IdDescripcion"
        tituloRepo = "Areas"
        Dim repo As New frmREPOViewPic
        repo.MdiParent = Me
        repo.Show()

    End Sub

    Private Sub MNRGCausa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRGCausa.Click
        sql = "select CAUSA_ID as ID,CAUSA_DESC as Descripcion FROM CAUSA"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        nivdet = "IdDescripcion"
        tituloRepo = "Tipos de Causas - Paradas"
        Dim repo As New frmREPOViewPic
        repo.MdiParent = Me
        repo.Show()
    End Sub

    Private Sub MNRGMaquinas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRGMaquinas.Click
        sql = "select maquinas_id as ID, maquinas_desc as Descripcion from Maquinas"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        nivdet = "IdDescripcion"
        tituloRepo = "Listado de Máquinas Picadora"
        Dim repo As New frmREPOViewPic
        repo.MdiParent = Me
        repo.Show()
    End Sub

    Private Sub MNRGMotivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRGMotivo.Click
        sql = "select motivo_id as ID, motivo_desc as Descripcion from Motivo"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        nivdet = "IdDescripcion"
        tituloRepo = "Listado de Motivos - Paradas"
        Dim repo As New frmREPOViewPic
        repo.MdiParent = Me
        repo.Show()
    End Sub

    Private Sub MNRGParadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRGParadas.Click
        nivdet = "paradas"
        Dim repParadas As New frmrepgenerales
        repParadas.MdiParent = Me
        repParadas.Show()
    End Sub

    Private Sub MNRGReparo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRGReparo.Click
        sql = "select reparo_id as ID,reparo_desc as Descripcion from reparo"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        nivdet = "IdDescripcion"
        tituloRepo = "Reparo - Paradas"
        Dim repo As New frmREPOViewPic
        repo.MdiParent = Me
        repo.Show()
    End Sub

    Private Sub MNRGSector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRGSector.Click
        nivdet = "sector"
        Dim repSector As New frmrepgenerales
        repSector.MdiParent = Me
        repSector.Show()
    End Sub

    Private Sub MNRPTipmad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRPTipmad.Click
        sql = "select tipmad_id as ID, tipmad_desc as Descripcion from tipmad"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        nivdet = "IdDescripcion"
        tituloRepo = "Tipos de Madera"
        Dim repo As New frmREPOViewPic
        repo.MdiParent = Me
        repo.Show()
    End Sub



    Private Sub MNBPNivel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBPNivel.Click
        Dim nivel As New NivelSilos
        nivel.MdiParent = Me
        nivel.Show()
    End Sub

    Private Sub MNBPConsumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBPConsumo.Click
        Dim PilApic As New Pilapic
        PilApic.MdiParent = Me
        PilApic.Show()
    End Sub

    Private Sub MNATBPMotivosPI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATBPMotivosPI.Click
        Dim motivosPI As New ABMMotivosPI
        motivosPI.MdiParent = Me
        motivosPI.Show()
    End Sub

    Private Sub MNRPTnpic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRPTnpic.Click
        Dim tnpic As New MadePicRep
        tnpic.MdiParent = Me
        tnpic.Show()
    End Sub

    Private Sub MNRPStvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRPStvar.Click
        nivdet = "STPLTOXVAR"
        Dim repo As New frmREPOViewPic
        repo.MdiParent = Me
        repo.Show()

    End Sub


    Private Sub MNRPNivsilos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRPNivsilos.Click

        Dim nivsil As New NivSilosRep
        nivsil.MdiParent = Me
        nivsil.Show()

    End Sub

    Private Sub MNRGNovedades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRGNovedades.Click
        Dim repnov As New Novedadesrep
        repnov.MdiParent = Me
        repnov.Show()
    End Sub

    Private Sub MNATPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATPerfil.Click
        Dim tbperfil As New ABMPerfil
        tbperfil.MdiParent = Me
        tbperfil.Show()
    End Sub

    Private Sub MNAPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNAPass.Click
        Dim pass As New password
        pass.MdiParent = Me
        pass.Show()
    End Sub


    Private Sub MNBDCBolsas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBDCBolsas.Click
        Dim cssab As New CtrlSulfato
        cssab.MdiParent = Me
        cssab.Show()
    End Sub

    Private Sub MNBDCEnsayos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBDCEnsayos.Click
        Dim cssaens As New CtrlSulfEns
        cssaens.MdiParent = Me
        cssaens.Show()
    End Sub

    Private Sub MNBDCrtlvf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBDCrtlvf.Click
        Dim cvf As New CtrlFibras
        cvf.MdiParent = Me
        cvf.Show()
    End Sub

    Private Sub MNBParadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBParadas.Click
        Dim parpic As New Paradas
        parpic.MdiParent = Me
        parpic.Show()
    End Sub


    Private Sub MNRParadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRParadas.Click
        Dim ParRep As New ParadasPicRep
        ParRep.MdiParent = Me
        ParRep.Show()
    End Sub

    Private Sub MNBPAjuste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBPAjuste.Click
        Dim AjuInv As New AjInventario
        AjuInv.MdiParent = Me
        AjuInv.Show()
    End Sub


    Private Sub MNBPTravig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBPTravig.Click
        Dim TrMaVi As New TranfsMadVig
        TrMaVi.MdiParent = Me
        TrMaVi.Show()
    End Sub


    Private Sub MNBTareas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBTareas.Click
        Dim Tareas As New Tareas
        Tareas.MdiParent = Me
        Tareas.Show()
    End Sub

    Private Sub MNRPInfprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRPInfprod.Click
        Dim InfProd As New InfContMadRep
        InfProd.MdiParent = Me
        InfProd.Show()
    End Sub

    Private Sub MNRPEfiPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRPEfiPic.Click
        Dim EfiPic As New EfiPicRep
        EfiPic.MdiParent = Me
        EfiPic.Show()
    End Sub

    Private Sub MNRPAjinvtrvig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRPAjinvtrvig.Click
        Dim AjTr As New AjTrRep
        AjTr.MdiParent = Me
        AjTr.Show()
    End Sub

    Private Sub MNRTareas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRTareas.Click
        Dim tarrep As New TareasRep
        tarrep.MdiParent = Me
        tarrep.Show()
    End Sub


    Private Sub MNRPIngcam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRPIngcam.Click
        Dim ingcam As New IngCamionRep
        ingcam.MdiParent = Me
        ingcam.Show()
    End Sub

    Private Sub MNBCVarproc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCVarproc.Click
        Dim mcvarproc As New McVarProc
        mcvarproc.MdiParent = Me
        mcvarproc.Show()
    End Sub



    Private Sub MNBCCuchillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCCuchillas.Click
        Dim mccamcuch As New McCuchillas
        mccamcuch.MdiParent = Me
        mccamcuch.Show()
    End Sub

    Private Sub MNBCParafina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCParafina.Click
        Dim paraf As New McParafina
        paraf.MdiParent = Me
        paraf.Show()
    End Sub

    Private Sub MNBCHipoclorito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCHipoclorito.Click
        Dim hipoc As New Mchipoclorito
        hipoc.MdiParent = Me
        hipoc.Show()
    End Sub


    Private Sub MNBNotNov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBNotNov.Click
        Dim novVisto As New NovedadesVisto
        novVisto.MdiParent = Me
        novVisto.Show()
    End Sub

    Private Sub MNBCLimvac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCLimvac.Click
        Dim LimVac As New McLimpVacio
        LimVac.MdiParent = Me
        LimVac.Show()
    End Sub

    Private Sub TimerMCLV_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMCLV.Tick

        Call controlaLV()

    End Sub

    Private Sub TimerMCTELAS_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMCTELAS.Tick

        Call controlaTELAS()

    End Sub


    Private Sub MNRM48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRM48.Click
        Dim repm48 As New M48rep
        repm48.MdiParent = Me
        repm48.Show()
    End Sub


    Private Sub MNBCEnsayos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCEnsayos.Click
        Dim mcens As New McEnsayos
        mcens.MdiParent = Me
        mcens.Show()
    End Sub

    Private Sub MNBCTelas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCTelas.Click
        Dim telas As New McTelas
        telas.MdiParent = Me
        telas.Show()
    End Sub


    Private Sub MNDPicadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNDIO.Click
        Dim IO As New IO
        'IO.MdiChildren = Me
        IO.Show()
    End Sub

    Private Sub MNBCConsumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCConsumo.Click
        Dim consumoparaf As New McParafinaIn
        consumoparaf.MdiParent = Me
        consumoparaf.Show()
    End Sub

    Private Sub MNRHsprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRHsprod.Click
        Dim hsprod As New HsProdParRep
        hsprod.MdiParent = Me
        hsprod.Show()
    End Sub

    Private Sub MNBCLValvulas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCLValvulas.Click
        Dim valvacio As New McLimpCVVac
        valvacio.MdiParent = Me
        valvacio.Show()
    End Sub

    Private Sub MNRMc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRMc.Click
        Dim repmc As New MCrep
        repmc.MdiParent = Me
        repmc.Show()
    End Sub

    Private Sub MNBMremito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBMremito.Click
        Dim modrem As New PIModiMad
        modrem.MdiParent = Me
        modrem.Show()
    End Sub

    Private Sub MNBDCrtlvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBDCrtlvar.Click
        Dim m48var As New CtrlVar
        m48var.MdiParent = Me
        m48var.Show()
    End Sub

    Private Sub MNBCLimpTQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCLimpTQ.Click
        Dim mctqbl As New McLimpTQBL
        mctqbl.MdiParent = Me
        mctqbl.Show()
    End Sub

    Private Sub MNATBCZZorras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATBCZZorras.Click
        Dim ABMZorras As New ABMZorras
        ABMZorras.MdiParent = Me
        ABMZorras.Show()
    End Sub

    Private Sub MNATBCZDefectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATBCZDefectos.Click
        Dim ABMdefectos As New ABMCZDefectos
        ABMdefectos.MdiParent = Me
        ABMdefectos.Show()
    End Sub

    Private Sub MNBCZTableros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCZTableros.Click
        Dim cztableros As New CZZorrasCargadas
        cztableros.MdiParent = Me
        cztableros.Show()
    End Sub

    Private Sub MNBCZCtrl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCZCtrl.Click
        Dim czctrl As New CZCtrlDim
        czctrl.MdiParent = Me
        czctrl.Show()
    End Sub

    Private Sub MNBCZEspesores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCZEspesores.Click
        Dim CZespes As New CZRegistroEspesores
        CZespes.MdiParent = Me
        CZespes.Show()
    End Sub

    Private Sub MNATBCDescalif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATBCZDescalif.Click
        Dim czdefdesc As New ABMCZDEFDESC
        czdefdesc.MdiParent = Me
        czdefdesc.Show()
    End Sub

    Private Sub MNBCZDescartes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCZDescartes.Click
        Dim czregdes As New CZRegistroDescartes
        czregdes.MdiParent = Me
        czregdes.Show()
    End Sub

    Private Sub MNBCZRotulador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCZRotulador.Click
        Dim czrotu As New CZRotulador
        czrotu.MdiParent = Me
        czrotu.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNAAcerca.Click
        Dim acercade As New AboutBox1
        acercade.MdiParent = Me
        acercade.Show()
    End Sub

    Private Sub MNRCZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRCZ.Click
        Dim czrep As New CZrep
        czrep.MdiParent = Me
        czrep.Show()
    End Sub

    Private Sub MNATBCZAverias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATBCZAverias.Click
        Dim czaver As New ABMCZAverias
        czaver.MdiParent = Me
        czaver.Show()

    End Sub

    Private Sub MNBCZEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCZEstado.Click
        Dim pz As New CZEstadoZorras
        pz.MdiParent = Me
        pz.Show()
    End Sub

    Private Sub MNBCZConfirmacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBCZConfirmacion.Click
        Dim confZorras As New CZConfRepZorras
        confZorras.MdiParent = Me
        confZorras.Show()
    End Sub

    Private Sub MNBLTdh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBLTdh.Click
        Dim lavtdh As New LAVTDH
        lavtdh.MdiParent = Me
        lavtdh.Show()
    End Sub

    Private Sub MNBLChtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBLChtr.Click
        Dim LavChapas As New LAVCHTR
        LavChapas.MdiParent = Me
        LavChapas.Show()
    End Sub

    Private Sub MNBLPlaca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBLPlaca.Click
        Dim LavCubrePlaca As New LAVCCP
        LavCubrePlaca.MdiParent = Me
        LavCubrePlaca.Show()
    End Sub

    Private Sub MNBLInox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBLInox.Click
        Dim LavInox As New LAVINOX
        LavInox.MdiParent = Me
        LavInox.Show()
    End Sub

    Private Sub MNBLDeco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBLDeco.Click
        Dim lavdeco As New LAVDECO
        lavdeco.MdiParent = Me
        lavdeco.Show()
    End Sub

    Private Sub MNBLCubas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBLCubas.Click
        Dim lavlcuba As New LAVLimpCubas
        lavlcuba.MdiParent = Me
        lavlcuba.Show()

    End Sub

    Private Sub MNATBLDeco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATBLDeco.Click
        Dim ABMDECO As New ABMLAVDecorativo
        ABMDECO.MdiParent = Me
        ABMDECO.Show()
    End Sub

    Private Sub MNBLSoda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBLSoda.Click
        Dim lavsoda As New LAVSoda
        lavsoda.MdiParent = Me
        lavsoda.Show()
    End Sub

    Private Sub MNRLTdh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRLTdh.Click
        Dim reptdh As New LAVTDHrep
        reptdh.MdiParent = Me
        reptdh.Show()
    End Sub

    Private Sub MNRLChtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRLChtr.Click
        Dim repchtr As New LAVCHTRrep
        repchtr.MdiParent = Me
        repchtr.Show()
    End Sub

    Private Sub MNRLCcp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRLCcp.Click
        Dim repccp As New LAVCCPrep
        repccp.MdiParent = Me
        repccp.Show()
    End Sub

    Private Sub MNRLDeco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRLDeco.Click
        Dim repdeco As New LAVDECOrep
        repdeco.MdiParent = Me
        repdeco.Show()
    End Sub

    Private Sub MNRLInox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRLInox.Click
        Dim repInox As New LAVINOXrep
        repInox.MdiParent = Me
        repInox.Show()
    End Sub

    Private Sub MNRLSoda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRLSoda.Click
        Dim repSoda As New LAVSODArep
        repSoda.MdiParent = Me
        repSoda.Show()
    End Sub

    Private Sub MNRLTareas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRLTareas.Click
        Dim reptarealav As New LAVGralrep
        reptarealav.MdiParent = Me
        reptarealav.Show()
    End Sub

    Private Sub MNBLReparaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBLReparaciones.Click
        Dim lavReparar As New LAVREPARACION
        lavReparar.MdiParent = Me
        lavReparar.Show()
    End Sub

    Private Sub MNRLReparaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRLReparaciones.Click
        Dim replavRepar As New LavReparRep
        replavRepar.MdiParent = Me
        replavRepar.Show()
    End Sub

    Private Sub MNBAlistamiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBAlistamiento.Click

    End Sub

    Private Sub MNATBPilas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATBPilas.Click
        Dim biopilas As New ABMPilaBIO
        biopilas.MdiParent = Me
        biopilas.Show()
    End Sub

    Private Sub MNBIyC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBIyC.Click
        Dim bioIC As New Biomasa
        bioIC.MdiParent = Me
        bioIC.Show()
    End Sub

    Private Sub MNBAj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBAj.Click
        Dim bioAJ As New AjusteBio
        bioAJ.MdiParent = Me
        bioAJ.Show()
    End Sub

    Private Sub MNRBInfprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRBInfprod.Click
        Dim BioInfProd As New InfContBioRep
        BioInfProd.MdiParent = Me
        BioInfProd.Show()

    End Sub

    Private Sub MNMRemitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNMRemitos.Click
        Dim MadRem As New Remitos
        MadRem.MdiParent = Me
        MadRem.Show()
    End Sub

    Private Sub MNMProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNMProveedores.Click
        Dim MadProv As New Proveedores
        MadProv.MdiParent = Me
        MadProv.Show()
    End Sub

    Private Sub MNMCampos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNMCampos.Click
        Dim campos As New CamposMad
        campos.MdiParent = Me
        campos.Show()
    End Sub

    Private Sub MNMReportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNMReportes.Click
        Dim repMad As New MaderaRep
        repMad.MdiParent = Me
        repMad.Show()
    End Sub

    Private Sub MNBPTrMadBio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBPTrMadBio.Click
        'Transferencia madera a Biomasa
        Dim tmb As New TRMADBIO
        tmb.MdiParent = Me
        tmb.Show()
    End Sub

    Private Sub MNBASMohog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBASMohog.Click
        Dim smohog As New ProdMohog
        smohog.MdiParent = Me
        smohog.Show()

    End Sub

    Private Sub MNBAClasificadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNBAClasificadora.Click
        Dim clasif As New ProdClasificadora
        clasif.MdiParent = Me
        clasif.Show()
    End Sub

    Private Sub MNATAProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATAProductos.Click
        Dim ProductosAlis As New ABMProdAlis
        ProductosAlis.MdiParent = Me
        ProductosAlis.Show()
    End Sub

    Private Sub MNACArmado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNACArmado.Click
        Dim armado As New MenuConf
        armado.MdiParent = Me
        armado.Show()
    End Sub

    Private Sub MNPANEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNPANEL.Click
        Dim apanel As New PanelGraficos
        apanel.Show()
    End Sub

    Private Sub MNATBLInox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNATBLInox.Click
        Dim abminox As New ABMInox
        abminox.MdiParent = Me
        abminox.Show()
    End Sub

    Private Sub MNRPara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRPara.Click
        Dim pa As New BasicosRep
        pa.MdiParent = Me
        pa.Show()
    End Sub

    Private Sub MNRAlistamiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNRAlistamiento.Click
        Dim repAlist As New AlisRep
        repAlist.MdiParent = Me
        repAlist.Show()
    End Sub

End Class