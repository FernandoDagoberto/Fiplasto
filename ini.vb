Imports System.Runtime.InteropServices
Module ini

    'Const APPLICATION As String = "CONECT"
    Declare Function GetPrivateProfileString Lib "kernel32.dll" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Public Function Leer_Ini(ByVal APPLICATION As String, ByVal Path_INI As String, ByVal Key As String, ByVal lpdefault As String) As String
        Try
            'Dim valor As String
            Dim Len_Value As Integer
            Dim objResult As String
            objResult = Space(256)
            Len_Value = GetPrivateProfileString(APPLICATION, Key, lpdefault, objResult, Len(objResult), Path_INI)

            If Len_Value > 0 Then Leer_Ini = Left(objResult.ToString, Len_Value)
        Catch
            MsgBox(ErrorToString)
        End Try
        'End
    End Function


End Module
