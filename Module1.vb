Imports System.Data.SqlClient
Imports Microsoft.Win32
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Module Module1

    Public conexion As New SqlConnection
    Public gtsen As String = "N"
    Public cnn, cnnProduccion As SqlClient.SqlConnection
    Public cnnMySql As MySqlConnection
    Public cnnA, cnnISO As OleDbConnection
    Public BaseAccess, PBaseAccess, PassAccess, PPassAccess As String
    Public daA As OleDbDataAdapter
    Public TurnoAuto As String
    Public Path_Archivo_Ini, BDSelection As String
    Public nomnu1 As New Object
    Public momnu As New System.Windows.Forms.ToolStripMenuItem
    Public cnnini As OleDbConnection
    Public sign, token, expira, Unico_ID, url, AFIPcuit, nrocae, vtocae, rescae, obscae, debhab, debhab1 As String
    Public seni, usersql, Pusersql, Ppass, pass, leg, leg1, base, Pbase, ProdBase, perfil1, sql4, SQL3, sql1, sql2, mingr, megr, ultnro, sen1, SenNov, motivo As String
    Public totfae, sqlini, Pdirbase, dirbase, dirbase1, campos, variables, excen, sen, cc1, cc2, perfil, user, observa, tituloRepo As String
    Public dtini As DataTable
    Public campatente, camfching, camhoraing, camtdesc, camchofer, campdesc, camrnombre As String
    Public camAviso As DateTime
    Public camtcod, camdni, camticket, campcod, campbruto, camrcod As Integer
    Public fechaant, fecha, fechaborra, turno, turnoD, turnoH, sector, fchhasta, estado, linea, lineaD, lineaH, DefectoD, DefectoH, EspesorD, EspesorH, ReparaD, ReparaH As String
    Public razonD, razonH, CampoD, CampoH, PropioD, PropioH As String
    Public MaderaD, MaderaH, ProveedorD, ProveedorH As Integer
    Public fch, fch1, fchPrimerDia As DateTime
    Public sql5, sql6, sql7, sql8, sql9, sql22, sql As String
    Public dt1, dt2, dt3, dt4, dt5, dt6, dt7, dt8, dt9, dt22, dt, TablaInforme As DataTable
    Public da1, da2, da3, da4, da5, da6, da7, da8, da9, da22, da As SqlDataAdapter
    Public pu, pp, kg, mbx, vdec, bult, desc, cost, cant, arti, usua As String
    Public s, line, deleteline, lineatarea, lineanovedad, lineaEnsayo, lineaTQ3, lineaprod, chk, kk, stk, nropedido As Integer
    Public tipo, tipo1, modfor, id, id1, id11, idf, anula, subta, iv, totl, cc, sto, vim, codbarra, cosuc As String
    Public daini As New OleDbDataAdapter
    Public cmd1, cmd2, cmd3, cmd4 As New SqlCommand
    Public n, n1, i1, x, a, m, sss, ser, nini, i, cobnro, rtonro, rtonro1, gtnro, gtnro1, presnro, presnro1, remnro, remnro1, iva, facnro, ncrenro, ndebnro, msg As Integer
    Public des, vale, equipo, nro, idlc, vObs, pub_sucur, suc, tip, sociosi, sociosd As String
    Public rsen, cdk, cdk1, cdk2, cdk3, cdk4, cdkf, cdks, cl, docu, nroform, fchform, fchvto, tipofae As String
    Public subt, iva1, tot, totp, subt2, iva2, tot2, tchq, impo, tim, ImpTotConc, ImpNeto, ImpOpEx, ImpIVA, ImpTrib As Double
    Public serie As Integer
    Public Mykey As RegistryKey
    Public newkey As RegistryKey
    Public var, var1, marca As String
    Public nivdet, area As String
    Public stock, alerta, limi As Integer

    'Variables de Tareas
    Public tareaID As Integer
    Public tareaFecha, tareaArea, tareaTurno, tareaAsunto, tareaDescripcion, creatarea As String

    'Variables de NovedadesVisto
    Public novedadesID As Integer
    Public novFCH, novMOTIVO, novTEXTO, novUSER, novAREA As String

    Function conex(ByVal modulo)
        If BDSelection = "P" Then
            cnn = New SqlClient.SqlConnection("Database=" + Pbase + ";user id=" + Pusersql + ";password=" + Ppass + ";Data Source=" + Pdirbase + ";")
        Else
            cnn = New SqlClient.SqlConnection("Database=" + base + ";user id=" + usersql + ";password=" + pass + ";Data Source=" + dirbase + ";")
        End If
    End Function


    Function conexA(ByVal modulo)
        Try
            cnnA = New OleDbConnection
            cnnA.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + BaseAccess + ";Persist Security Info=true;Jet OLEDB:Database Password=" + PassAccess + ""
            cnnA.Open()
        Catch ex As Exception
            MessageBox.Show("No se conecto con la Base de Datos " & ex.Message, "Aviso")

        End Try

    End Function


    Function conexISO(ByVal modulo)
        cnnISO = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='\\ramallo05\SitioISO\App_Data\ISONEW.mdb';Persist Security Info=true;Jet OLEDB:Database Password=''")
    End Function

    Function conexProduccion(ByVal modulo)
        cnnProduccion = New SqlClient.SqlConnection("Database=" + ProdBase + ";user id=" + usersql + ";password=" + pass + ";Data Source=" + dirbase + ";")
    End Function

    Function ConectMySql()
        Dim servidor, usuario, pswd, base As String
        servidor = "2.2.2.247"
        usuario = "root"
        pswd = "Fiplasto@2048"
        base = "fiplasto"
        cnnMySql = New MySqlConnection("server=" & servidor & ";" & "user id=" & usuario & ";" & "password=" & pswd & ";" & "database=" & base & ";")

    End Function



    Function barra(ByVal nombre)
        Dim l, c, x As Integer

        nombre.Visible = True
        For l = 0 To 100
            For x = 0 To 59000
                c = (c + 1 * 3450) / 18
            Next
            nombre.Value = l
        Next
        nombre.Visible = False
    End Function

    Function datosini()

        Try
            Path_Archivo_Ini = Environment.CurrentDirectory & "\Config.ini"
            dirbase = Leer_Ini("CONECT", Path_Archivo_Ini, "server", " ")
            base = Leer_Ini("CONECT", Path_Archivo_Ini, "base", " ")
            usersql = Leer_Ini("CONECT", Path_Archivo_Ini, "usuario", "")
            pass = Leer_Ini("CONECT", Path_Archivo_Ini, "password", "")

            ProdBase = Leer_Ini("CONECT", Path_Archivo_Ini, "baseProduccion", "")

            BaseAccess = Leer_Ini("CONECT", Path_Archivo_Ini, "BaseAccess", " ")
            PassAccess = Leer_Ini("CONECT", Path_Archivo_Ini, "PasswordAccess", "")
            Pdirbase = Leer_Ini("CONECT1", Path_Archivo_Ini, "Pserver", " ")
            Pbase = Leer_Ini("CONECT1", Path_Archivo_Ini, "Pbase", " ")
            Pusersql = Leer_Ini("CONECT1", Path_Archivo_Ini, "Pusuario", "")
            Ppass = Leer_Ini("CONECT1", Path_Archivo_Ini, "Ppassword", "")
            PBaseAccess = Leer_Ini("CONECT1", Path_Archivo_Ini, "PBaseAccess", " ")
            PPassAccess = Leer_Ini("CONECT1", Path_Archivo_Ini, "PPasswordAccess", "")

        Catch
            MsgBox("No se encuentra el archivo config.ini", MsgBoxStyle.Critical)
            End
        End Try

    End Function

    Function llenacb(ByVal tabla) 'LLenar combos
        Try
            Call conex("combo")
            sql7 = "SELECT * From " + tabla
            da7 = New SqlDataAdapter(sql7, cnn)
            dt7 = New DataTable
            da7.Fill(dt7)
            n = dt7.Rows.Count
            If n = 0 Then
                'Response.Write("<p>No hay registros.</p>")
            Else
                Return dt7
            End If
        Catch
            MsgBox(ErrorToString)
        End Try
    End Function


    Function nivel(ByVal codniv As Integer, ByVal combo As Object)

        Select Case codniv

            Case 1 'lleno

                combo.Value = 100

            Case 2 '+3/4
                combo.Value = 85

            Case 3 '3/4
                combo.Value = 75

            Case 4 '+1/2
                combo.Value = 65

            Case 5 '1/2
                combo.Value = 50

            Case 6 '+1/4
                combo.Value = 40

            Case 7 '1/4
                combo.Value = 25

            Case 8 '-1/4
                combo.Value = 10

            Case 9 'Vacio
                combo.Value = 0

        End Select

    End Function

    Function limites(ByVal param)

        sql8 = "SELECT * from PARAMETROS where param_cod= '" + param + "' "
        da8 = New SqlDataAdapter(sql8, cnn)
        dt8 = New DataTable
        da8.Fill(dt8)

    End Function


    Function llenacbwhere(ByVal tabla, ByVal where) 'LLenar combos
        Try
            Call conex("combo")
            sql9 = "SELECT * From " + tabla + " " + where
            da9 = New SqlDataAdapter(sql9, cnn)
            dt9 = New DataTable
            da9.Fill(dt9)
            n = dt9.Rows.Count
            If n = 0 Then
                'Response.Write("<p>No hay registros.</p>")
            Else
                Return dt9
            End If
        Catch
            MsgBox(ErrorToString, "Aviso")
        End Try
    End Function

    'solo admite numeros
    Public Function SoloNumeros(e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = vbBack
    End Function


    'Function SoloNumeros(ByVal Keyascii As Short) As Short
    '    If InStr("1234567890", Chr(Keyascii)) = 0 Then
    '        SoloNumeros = 0
    '    Else
    '        SoloNumeros = Keyascii
    '    End If
    '    Select Case Keyascii
    '        Case 8
    '            SoloNumeros = Keyascii
    '        Case 13
    '            SoloNumeros = Keyascii
    '    End Select
    'End Function


    'solo admite numeros
    Public Function SoloDecimal(CajaTexto As TextBox, e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Function

    'Function SoloDecimal(ByVal Keyascii As Short) As Short
    '    If InStr("1234567890.", Chr(Keyascii)) = 0 Then
    '        SoloDecimal = 0
    '    Else
    '        SoloDecimal = Keyascii
    '    End If
    '    Select Case Keyascii
    '        Case 8
    '            SoloDecimal = Keyascii
    '        Case 13
    '            SoloDecimal = Keyascii
    '    End Select
    'End Function

    Function CargaTurnoAuto()
        If Format(Now, "HH:mm:ss") >= "06:00:00" And Format(Now, "HH:mm:ss") <= "13:59:59" Then
            TurnoAuto = "06-14"
        ElseIf Format(Now, "HH:mm:ss") >= "14:00:00" And Format(Now, "HH:mm:ss") < "21:59:59" Then
            TurnoAuto = "14-22"
        Else
            TurnoAuto = "22-06"
        End If

    End Function


End Module
