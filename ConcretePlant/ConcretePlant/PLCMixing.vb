Public Class PLCMixing
    Private _AdressStart As String = "R1120"
    Private _Data(15) As Long
    Public Sub New(Optional ByVal i As Integer = 0)
        Dim Mixing As Mixing_Tbl = New Mixing_Tbl(i)
        _Data(0) = Mixing.Code
        _Data(1) = Mixing.MixingType1
        _Data(2) = Mixing.MixingType2
        _Data(3) = Mixing.MixingType3
        _Data(4) = Mixing.MixingType4
        _Data(5) = Mixing.MixingType5
        _Data(6) = Mixing.MixingType6
        _Data(7) = Mixing.MixingType7
        _Data(8) = Mixing.MixingType8
        _Data(9) = Mixing.MixingType9
        _Data(10) = Mixing.MixingType10
        _Data(11) = Mixing.CountUpType
        _Data(12) = Mixing.MixerGateOpenTime
        _Data(13) = Mixing.MixerEmptyTime
        _Data(14) = Mixing.MixerCheckTime
        _Data(15) = Mixing.HopperCheckTime
    End Sub
    Public Property AdressStart As String
        Get
            Return _AdressStart
        End Get
        Set(value As String)
            _AdressStart = value
        End Set
    End Property
    Public Sub SendData()
        MCSendData(_AdressStart, 16, _Data)
    End Sub
    Public Sub ClearData()
        MCSendData(_AdressStart, 16, {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0})
    End Sub
End Class
