Public Class PLCMaterial
    Private _AdressStart As String = "R500"
    Private _Data(11) As Long
    Public Sub New(Optional ByVal i As Integer = 0)
        Dim material As Material_Tbl = New Material_Tbl(i)
        _Data(0) = material.Code
        _Data(1) = material.LoadcellCD
        _Data(2) = material.MaterialNo
        _Data(3) = material.Type
        _Data(4) = material.WeighingStep
        _Data(5) = material.JoggingType
        _Data(6) = material.JoggingON
        _Data(7) = material.JoggingOFF
        _Data(8) = material.FineWeighing
        _Data(9) = material.CompletionBit
        _Data(10) = material.CompletionTime
        _Data(11) = material.CompletionRange
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
        MCSendData(_AdressStart, 12, _Data)
    End Sub
    Public Sub ClearData()
        MCSendData(_AdressStart, 12, {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0})
    End Sub
End Class
