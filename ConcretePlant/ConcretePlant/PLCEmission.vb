Public Class PLCEmission
    Private _AdressStart As String = "R1000"
    Private _Data(12) As Long
    Public Sub New(Optional ByVal i As Integer = 0)
        Dim emission As Emission_Tbl = New Emission_Tbl(i)
        _Data(0) = emission.LoadcellCD
        _Data(1) = emission.MixingType1
        _Data(2) = emission.MixingType2
        _Data(3) = emission.MixingType3
        _Data(4) = emission.MixingType4
        _Data(5) = emission.MixingType5
        _Data(6) = emission.MixingType6
        _Data(7) = emission.MixingType7
        _Data(8) = emission.MixingType8
        _Data(9) = emission.MixingType9
        _Data(10) = emission.MixingType10
        _Data(11) = emission.Ems_cpt_range
        _Data(12) = emission.GateCloseTime
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
        MCSendData(_AdressStart, 13, _Data)
    End Sub
    Public Sub ClearData()
        MCSendData(_AdressStart, 13, {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0})
    End Sub
End Class
