Public Class PLCLoadcell
    Private _AdressStart As String = "R100"
    Private _Data(11) As Long
    Public Sub New(Optional ByVal i As Integer = 0)
        Dim loadcell As LoadCell_Tbl = New LoadCell_Tbl(i)
        Try
            _Data(0) = loadcell.Code
            _Data(1) = Text.Encoding.Unicode.GetBytes(loadcell.Name)(0)
            _Data(2) = loadcell.Type
            _Data(3) = loadcell.Capacity
            _Data(4) = loadcell.DecPoint
            _Data(5) = loadcell.Zero
            _Data(6) = loadcell.Span
            _Data(7) = loadcell.GateOpenLmt
            _Data(8) = loadcell.ExportTo
            _Data(9) = loadcell.ImportFrom1
            _Data(10) = loadcell.ImportFrom2
            _Data(11) = loadcell.ImportFrom3
        Catch
        End Try
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
