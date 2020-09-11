Imports ConcretePlant.Setting
Public Class TestComm
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fncMCConnect(giMode)
        'Dim writeinit As WritePLC = New WritePLC(16)
        'writeinit.AdressStart = "R1120"
        'mixing.GetMixingbyCode(0)
        'writeinit.Add(mixing.Code, 0)
        'writeinit.Add(mixing.MixingType1, 1)
        'writeinit.Add(mixing.MixingType2, 2)
        'writeinit.Add(mixing.MixingType3, 3)
        'writeinit.Add(mixing.MixingType4, 4)
        'writeinit.Add(mixing.MixingType5, 5)
        'writeinit.Add(mixing.MixingType6, 6)
        'writeinit.Add(mixing.MixingType7, 7)
        'writeinit.Add(mixing.MixingType8, 8)
        'writeinit.Add(mixing.MixingType9, 9)
        'writeinit.Add(mixing.MixingType10, 10)
        'writeinit.Add(mixing.CountUpType, 11)
        'writeinit.Add(mixing.MixerGateOpenTime, 12)
        'writeinit.Add(mixing.MixerEmptyTime, 13)
        'writeinit.Add(mixing.MixerCheckTime, 14)
        'writeinit.Add(mixing.HopperCheckTime, 15)
        'writeinit.SendData()
        Dim bbyte As Byte = 6
        TextBox2.Text = (bbyte Or 1).ToString

    End Sub


    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    fncSendToPlc("D1000", 4, "1234567812345678", 0)
    'End Sub


    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    'Dim r As Boolean = False
    '    'Dim btBuffer As Byte()

    '    'ReDim btBuffer(13)
    '    'btBuffer(0) = &HE8
    '    'btBuffer(1) = &H3
    '    'btBuffer(2) = &H0

    '    'btBuffer(3) = &HA8

    '    'btBuffer(4) = &H4
    '    'btBuffer(5) = &H0

    '    'btBuffer(6) = &H12
    '    'btBuffer(7) = &H34
    '    'btBuffer(8) = &H56
    '    'btBuffer(9) = &H78
    '    'btBuffer(10) = &H12
    '    'btBuffer(11) = &H34
    '    'btBuffer(12) = &H56
    '    'btBuffer(13) = &H78

    '    'r = SendToSeq_Byte(btBuffer, btBuffer.Length, 0)


    '    Dim r As Boolean = False
    '    Dim btBuffer As Byte()

    '    ReDim btBuffer(7)
    '    btBuffer(0) = &HE8
    '    btBuffer(1) = &H3
    '    btBuffer(2) = &H0

    '    btBuffer(3) = &HA8

    '    btBuffer(4) = &H1
    '    btBuffer(5) = &H0

    '    btBuffer(6) = &H1
    '    btBuffer(7) = &H1


    '    r = MCSendTo_Byte(btBuffer, btBuffer.Length, 0)



    '    'Dim r As Boolean = False
    '    'Dim btBuffer As Byte()

    '    ReDim btBuffer(6)
    '    btBuffer(0) = &HE8
    '    btBuffer(1) = &H3
    '    btBuffer(2) = &H0

    '    btBuffer(3) = &H90

    '    btBuffer(4) = &H1
    '    btBuffer(5) = &H0

    '    btBuffer(6) = &H10



    '    r = MCSendTo_Byte(btBuffer, btBuffer.Length, 1)
    'End Sub


    'Public ptr As IntPtr
    'Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    '    Dim btRetBuff(100) As Byte
    '    Dim i As Integer = False
    '    Dim btDevice(0) As Byte
    '    Dim iAdr As Integer

    '    TextBox1.Text = ""

    '    btDevice(0) = &HA8
    '    i = MCRequestData(btDevice, 1000, 4, btRetBuff)

    '    'btDevice(0) = &H9D    'M
    '    btDevice(0) = &HA8    'D
    '    'iAdr = &H80
    '    iAdr = &H1000
    '    i = MCRequestData(btDevice, iAdr, 10, btRetBuff)

    '    'If i > 0 Then
    '    TextBox1.Text = System.Text.Encoding.GetEncoding("SHIFT-JIS").GetString(btDevice)
    '    'End If

    '    'End If



    '    'JSendToSeq("M1008", 1, "1", 0)
    'End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fncMCConnect(giMode)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim bByte As Byte()
        'Dim bLong As Long() = {Long.Parse(TextBox2.Text)}

        'bByte = System.Text.Encoding.GetEncoding("SHIFT-JIS").GetBytes(TextBox2.Text)
        'ReDim bLong(bByte.Length \ 2 + (bByte.Length Mod 2))
        'For iCnt As Int16 = 0 To bByte.Length - 1 Step 2
        '    If (iCnt + 1 < bByte.Length) Then
        '        bLong(iCnt \ 2) = bByte(iCnt + 1) * &H100
        '    End If
        '    bLong(iCnt \ 2) += bByte(iCnt)
        'Next
        'MCSendData("M0", 1, {0})
        'MCSendData("M0", 1, bLong)  ' gửi 1*16bits
        MCSendData("D5000", 3, {1, 1, 1})
        'PLCSetBit(TextBox2.Text, Integer.Parse(TextBox3.Text), Byte.Parse(TextBox1.Text))
        'PLCSetBit(TextBox2.Text, Byte.Parse(TextBox1.Text))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim bByte(5) As Byte ' = {0, 0, 0, 0, 0, 0}

        MCRequestDat("D5000", 6, bByte)   ' đọc 1*16 bits

        'TextBox1.Text = GetValue(bByte, 0, 2) 'System.Text.Encoding.GetEncoding("SHIFT-JIS").GetString(bByte)

        'MessageBox.Show(PLCGetBit(TextBox2.Text, Integer.Parse(TextBox3.Text)).ToString)
        Dim i As Int16
        Dim blong(3) As Long
        blong = GetLongArray(bByte, bByte.Length)
        MessageBox.Show(blong(0).ToString)
        MessageBox.Show(blong(1).ToString)
        MessageBox.Show(blong(2).ToString)
    End Sub

    Private Sub bt_toOperate_Click(sender As Object, e As EventArgs) Handles bt_toOperate.Click
        Dim frm As Operate = New Operate
        frm.Show()
    End Sub
End Class