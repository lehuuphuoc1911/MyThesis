Imports System.Configuration
Imports System.Globalization
Public Class Setting
    Public Shared __ConnStr As String = ConfigurationManager.ConnectionStrings("Connect").ConnectionString
    Public Shared __ConnMasStr As String = ConfigurationManager.ConnectionStrings("ConnectMaster").ConnectionString
    Public Shared __Language As String = "en-US"
    Public Shared __MixerVolume As Integer = 10
    Public Shared __MixerStep As Integer = 4
    'Public Shared __IPAdress As String = ConfigurationManager.AppSettings("IPAdress").ToString
    'Public Shared __IPPort As Integer = Integer.Parse(ConfigurationManager.AppSettings("IPAdress"))
    Public Shared Function IntToStr(ByVal x As Integer, Optional ByVal i As Integer = 1) As String
        Dim s As String = ""
        Dim negative As Boolean = False
        If x < 0 Then
            negative = True
            x = -x
        End If
        If i = 0 Then
            Return x.ToString
        Else
            Dim a As Integer = x \ (10 ^ i)
            Dim b As Integer = x Mod (10 ^ i)
            If b = 0 Then
                s = a.ToString & "."
                Dim j As Integer
                For j = 1 To i
                    s = s & "0"
                Next
            Else
                Dim mm As String = "0000000" & b.ToString
                s = a.ToString & "." & mm.Substring(mm.Length - i)
            End If
        End If
        If negative Then
            s = "-" + s
        End If
        Return s
    End Function
    Public Shared Function StrToInt(ByVal str As String, Optional ByVal i As Integer = 1) As Integer
        Dim value As Integer = 0
        If str = Nothing Or str = "" Then
            Return value
        End If
        Dim valuedou As Double = 0
        valuedou = Double.Parse(str)
        valuedou *= 10 ^ i
        value = Math.Floor(valuedou)
        Return value
    End Function
    Public Shared Function GetValue(ByVal bbyte() As Byte, ByVal i As Integer, ByVal j As Integer) As Long
        Dim value As Long = 0
        Dim k As Integer
        For k = 0 To j - 1
            value += bbyte(i + k) * (256 ^ k)
        Next
        If value > 32767 Then
            value -= 65536
        End If
        Return value
    End Function

    Public Shared Function GetLongArray(ByVal bbyte() As Byte, ByVal i As Integer) As Long()
        Dim blong(i \ 2 - 1) As Long
        Dim j As Integer
        For j = 0 To blong.Length - 1
            blong(j) = bbyte(2 * j) + 256 * bbyte(2 * j + 1)
            If blong(j) > 32767 Then
                blong(j) -= 65536
            End If
        Next
        Return blong
    End Function
    'Public Shared Function PLCGetBit(ByVal Address As String) As Integer
    '    Dim bByte(1) As Byte
    '    MCRequestDat(Address, 1, bByte)
    '    Return bByte(0) Mod 2
    'End Function
    'Public Shared Function PLCGetBit(ByVal Address As String, ByVal BitNum As Integer) As Integer
    '    Dim bByte(1) As Byte
    '    MCRequestDat(Address, 1, bByte)
    '    Return (GetValue(bByte, 0, 2) >> BitNum) Mod 2
    'End Function
    'Public Sub PLCSetBit(ByVal Address As String, ByVal value As Byte)
    '    Dim bByte(1) As Byte
    '    MCRequestDat(Address, 1, bByte)
    '    If value Then
    '        bByte(0) = bByte(0) Or 1
    '    Else
    '        bByte(0) = bByte(0) - (bByte(0) Mod 2)
    '    End If
    '    Dim blong() As Long = {GetValue(bByte, 0, 2)}
    '    MCSendData(Address, 1, blong)
    'End Sub
    'Public Shared Sub PLCSetBit(ByVal Address As String, ByVal BitNum As Integer, ByVal value As Byte)
    '    Dim bByte(1) As Byte
    '    MCRequestDat(Address, 1, bByte)
    '    Dim blong() As Long = {GetValue(bByte, 0, 2)}
    '    Dim bb As Long = 1 << Bitnum
    '    If value Then
    '        blong(0) = blong(0) Or bb
    '    Else
    '        bb = &HFFFF - bb
    '        blong(0) = blong(0) And bb
    '    End If
    'End Sub
End Class
