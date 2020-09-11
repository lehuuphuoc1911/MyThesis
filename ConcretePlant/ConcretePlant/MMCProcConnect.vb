'Option Strict On
Option Explicit On

Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Configuration
Imports ConcretePlant.Setting

Module MMCProcConnect
    Public seqConnected As Boolean

    <DllImport("MCProcDll.dll", CallingConvention:=CallingConvention.Cdecl, EntryPoint:="MCDisConnect")>
    Public Function MCDisConnect() As Integer
    End Function

    <DllImport("MCProcDll.dll", CallingConvention:=CallingConvention.Cdecl, EntryPoint:="MCConnect")>
    Public Function MCConnect() As Integer
    End Function

    <DllImport("MCProcDll.dll", CallingConvention:=CallingConvention.Cdecl, EntryPoint:="MCConnect_Md")>
    Public Function MCConnect_Md(ByVal ucTransMode As Byte, ByVal pscIpAddr As Byte(),
                                  ByVal scIpAddrLen As Byte, ByVal ssIpPort As Short) As Integer
    End Function

    <DllImport("MCProcDll.dll", CallingConvention:=CallingConvention.Cdecl, EntryPoint:="MCRequestData")>
    Public Function MCRequestData(ByVal pscDeviceCode As Byte(), ByVal usDataFrom As Integer,
                                ByVal usDataLen As Integer, ByVal pucRetDat As Byte()) As Integer
    End Function

    <DllImport("MCProcDll.dll", CallingConvention:=CallingConvention.Cdecl, EntryPoint:="MCSendTo")>
    Public Function MCSendTo(ByVal send_data As String, ByVal mode_b As Short) As Boolean
    End Function

    <DllImport("MCProcDll.dll", CallingConvention:=CallingConvention.Cdecl, EntryPoint:="MCSendTo_Byte")>
    Public Function MCSendTo_Byte(ByVal send_data As Byte(), ByVal sDatLen As Short,
                                   ByVal mode_b As Short) As Boolean
    End Function

    Public firstConnect As Boolean

    ' IP アドレス 設定
    Public gstrIpAddr As String = ConfigurationManager.AppSettings("IPAdress").ToString
    Public giIpPort As Integer = Integer.Parse(ConfigurationManager.AppSettings("IPPort"))
    Public giMode As Integer = Integer.Parse(ConfigurationManager.AppSettings("giMode"))
    Public Sub fncMCConnect(Optional ByVal iMode As Integer = 0)
        'Check PLC Connection 
        If My.Computer.Network.IsAvailable Then
            If My.Computer.Network.Ping(gstrIpAddr) = False Then
                MsgBox("Cannot connect to the PLC!" & vbCrLf &
                       "1. Check if PLC IP address is [" & gstrIpAddr & "]." & vbCrLf &
                       "2. Check if PC IP address is the same network with PLC!" & vbCrLf &
                       "3. Check the power supply, and connection!", MsgBoxStyle.Information)
                Exit Sub
            End If
        Else
            MsgBox("Connection error!", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim ret As Integer
        Try
            Dim bDat As Byte() = System.Text.Encoding.GetEncoding("SHIFT-JIS").GetBytes(gstrIpAddr)

            ret = MCConnect_Md(iMode, bDat, bDat.Length, giIpPort)
            If ret = 0 Then
                seqConnected = True

            Else
                seqConnected = False
                Dim msg As String = String.Empty
                MsgBox(jConnectionStatus(ret))
            End If

        Catch ex As Exception
            MsgBox(jConnectionStatus(ret) & vbCrLf & ex.Message)
        End Try
    End Sub


    Public Sub fncSendToPlc(ByVal devName As String, ByVal devNumber As Integer, ByVal strValue As String, Optional ByVal mode_b As Short = 0)
        If seqConnected = False Then Exit Sub
        Dim dev As String = devName.Substring(0, 1) & "*00" & devName.Substring(1, 4) & String.Format("{0:X4}", devNumber)
        Dim r As Boolean = False
        Dim senddata As String
        senddata = dev & strValue
        Try
            r = MCSendTo(senddata, mode_b)
            If r = False Then MsgBox("Error! Can not write")
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub


    Public Class MyDeviceDict

        Public Sub New()
            SubDictionaryInit()
        End Sub


        Public gobjDeviceDict As New Dictionary(Of String, Byte)
        Public gobjAddrDict As New Dictionary(Of String, String)

        Public Sub SubDictionaryInit()
            gobjDeviceDict.Add("D", &HA8)
            gobjDeviceDict.Add("M", &H90)
            gobjDeviceDict.Add("W", &HB4)
            gobjDeviceDict.Add("R", &HAF)
            gobjDeviceDict.Add("X", &H9C)
            gobjDeviceDict.Add("Y", &H9D)

            gobjAddrDict.Add("D", "")
            gobjAddrDict.Add("M", "")
            gobjAddrDict.Add("W", "&H")
            gobjAddrDict.Add("R", "")
            gobjAddrDict.Add("X", "&H")
            gobjAddrDict.Add("Y", "&H")

        End Sub

    End Class

    Public Sub MCSendData(ByVal strPlcAdd As String, ByVal iLen As Integer, ByVal value() As Long)
        Dim srtDevNam As String
        Dim strDevAdr As String
        Dim bSndDat As Byte()
        Dim lgWrk As Integer
        Dim lgRet As Integer

        Dim objDevDict As New MyDeviceDict
        Try

            srtDevNam = strPlcAdd.Substring(0, 1)
            strDevAdr = strPlcAdd.Substring(1, strPlcAdd.Length - 1)

            lgWrk = CInt(objDevDict.gobjAddrDict.Item(srtDevNam) & strDevAdr)
            lgWrk = lgWrk Mod &H1000000
            ReDim Preserve bSndDat(2)
            lgRet = lgWrk \ &H10000
            bSndDat(2) = lgRet
            lgWrk = lgWrk Mod &H10000
            bSndDat(1) = lgWrk \ &H100
            lgWrk = lgWrk Mod &H100
            bSndDat(0) = lgWrk

            ReDim Preserve bSndDat(3)
            Try

                bSndDat(3) = objDevDict.gobjDeviceDict.Item(srtDevNam)
            Catch ex As Exception

            End Try

            ReDim Preserve bSndDat(5)
            iLen = iLen Mod &H10000
            bSndDat(5) = iLen \ &H100
            iLen = iLen Mod &H100
            bSndDat(4) = iLen

            ReDim Preserve bSndDat(5 + iLen * 2)
            Dim iCnt As Integer
            For iCnt = 0 To iLen - 1
                lgWrk = value(iCnt)
                lgWrk = lgWrk Mod &H10000
                bSndDat(5 + 2 + iCnt * 2) = lgWrk \ &H100
                lgWrk = lgWrk Mod &H100
                bSndDat(5 + 1 + iCnt * 2) = lgWrk
            Next


        Catch ex As Exception
            Exit Sub
        End Try

        objDevDict = Nothing

        MCSendTo_Byte(bSndDat, bSndDat.Length, 0)

    End Sub


    Public Sub MCRequestDat(ByVal strPlcAdd As String, ByVal iLen As Integer, ByRef value() As Byte)
        Dim srtDevNam As String
        Dim strDevAdr As String
        Dim bSndDat(0) As Byte
        Dim lgWrk As Integer
        'Dim lgRet As Integer

        Dim objDevDict As New MyDeviceDict
        Try

            srtDevNam = strPlcAdd.Substring(0, 1)
            strDevAdr = strPlcAdd.Substring(1, strPlcAdd.Length - 1)

            lgWrk = CInt(objDevDict.gobjAddrDict.Item(srtDevNam) & strDevAdr)
            lgWrk = lgWrk Mod &H1000000


            ReDim Preserve bSndDat(0)
            Try

                bSndDat(0) = objDevDict.gobjDeviceDict.Item(srtDevNam)
            Catch ex As Exception

            End Try




        Catch ex As Exception
            Exit Sub
        End Try

        objDevDict = Nothing

        MCRequestData(bSndDat, lgWrk, iLen, value)

    End Sub


    Public Function jConnectionStatus(ByVal status As Integer) As String
        Dim ret As String = String.Empty
        Select Case status
            Case 0
                ret = "ERROR_INITIAL"
            Case 1
                ret = "ERROR_SOCKET"
            Case 2
                ret = "ERROR_BIND"
            Case 3
                ret = "ERROR_CONNECT"
            Case 4
                ret = "ERROR_SEND"
            Case 5
                ret = "ERROR_RECEIVE"
            Case 6
                ret = "ERROR_SHUTDOWN"
            Case 7
                ret = "ERROR_CLOSE"
            Case 8
                ret = ""
        End Select

        If status > 0 Then
            If My.Computer.Network.IsAvailable Then
                If My.Computer.Network.Ping(gstrIpAddr) = False Then
                    ret &= vbCrLf & "Please check if the IP address of PLC is [" & gstrIpAddr & "]！"
                End If
            Else
                ret &= vbCrLf & "Connection error!"
            End If
        End If

        seqConnected = False
        Return ret

    End Function
    '===================================================================
    ' GET BIT FROM M, X
    Public Function PLCGetBit(ByVal Address As String) As Integer
        Dim bByte(1) As Byte
        MCRequestDat(Address, 1, bByte)
        Return bByte(0) Mod 2
    End Function
    '======================================================================
    ' GET BIT FROM R, D
    Public Function PLCGetBit(ByVal Address As String, ByVal BitNum As Integer) As Integer
        Dim bByte(1) As Byte
        MCRequestDat(Address, 1, bByte)
        Return (GetValue(bByte, 0, 2) >> BitNum) Mod 2
    End Function
    '====================================================================
    ' SET BIT FROM M, X
    Public Sub PLCSetBit(ByVal Address As String, ByVal value As Byte)
        Dim bByte(1) As Byte
        MCRequestDat(Address, 1, bByte)
        If value Then
            bByte(0) = bByte(0) Or &H1
        Else
            bByte(0) = bByte(0) - (bByte(0) Mod 2)
        End If
        Dim blong() As Long = {GetValue(bByte, 0, 2)}
        MCSendData(Address, 1, blong)
    End Sub
    '==========================================================================
    ' SET BIT FROM R,D
    Public Sub PLCSetBit(ByVal Address As String, ByVal BitNum As Integer, ByVal value As Byte)
        Dim bByte(1) As Byte
        MCRequestDat(Address, 1, bByte)
        Dim blong() As Long = {GetValue(bByte, 0, 2)}
        Dim bb As Long = 2 ^ BitNum
        If value = 1 Then
            blong(0) = (blong(0) Or bb)
        Else
            bb = &HFFFF - bb
            blong(0) = (blong(0) And bb)
        End If
        MCSendData(Address, 1, blong)
    End Sub
    Public Function PLCGetLong(ByVal Address As String) As Long
        Dim bByte(1) As Byte
        MCRequestDat(Address, 1, bByte)
        Dim x As Long
        x = bByte(0) + bByte(1) * 256
        If x > 32767 Then
            x -= 65536
        End If
        Return x
    End Function
End Module
