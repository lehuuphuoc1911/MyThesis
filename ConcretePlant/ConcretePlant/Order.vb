Imports System.Data.SqlClient
Public Class Order
    Private _data As DataTable
    Private _NumberOfRows As Integer = 0
    Public ReadOnly Property NumberOfRows As Integer
        Get
            Return _NumberOfRows
        End Get
    End Property
    Public Sub New()
        _NumberOfRows = 0
        _data = New DataTable
    End Sub
    Public Property data() As DataTable
        Get
            Return _data
        End Get
        Set(value As DataTable)
            _data = value
        End Set
    End Property
    Public Function GetFromServer() As Boolean
        Try
            Dim conn As SqlConnection = New SqlConnection
            conn.ConnectionString = Setting.__ConnStr
            conn.Open()
            Dim CmdStr As String = "Select *from Order_Tbl"
            Dim data_ As SqlDataAdapter = New SqlDataAdapter(CmdStr, conn)
            data_.Fill(_data)
            conn.Close()
            If _data.Rows.Count > 0 Then
                _NumberOfRows = _data.Rows.Count
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return False
    End Function
    Public Sub UpdateTable()
        Dim i As Integer
        For i = 0 To _NumberOfRows - 1
            _data.Rows(i)(0) = i + 1
        Next
    End Sub
    Public Function UpdateServer() As Boolean
        Try
            Dim conn As SqlConnection = New SqlConnection
            conn.ConnectionString = Setting.__ConnStr
            conn.Open()
            Dim CmdStr As String = "delete from Order_Tbl"
            Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn)
            cmd.ExecuteNonQuery()
            Dim i As Integer
            For i = 0 To _data.Rows.Count - 1
                CmdStr = "insert into Order_Tbl Values(" & (i + 1).ToString + " , " + _data.Rows(i)(1).ToString + " , '" + _data.Rows(i)(2) + "' , '" + _data.Rows(i)(3).ToString + "' , " + _data.Rows(i)(4).ToString + " , " + _data.Rows(i)(5).ToString + ")"
                cmd = New SqlCommand(CmdStr, conn)
                cmd.ExecuteNonQuery()
            Next
            conn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("can not update server")
        End Try
        Return False
    End Function
    Public Property No(ByVal i As Integer)
        Get
            Return _data.Rows(i)(0)
        End Get
        Set(value)
            _data.Rows(i)(0) = value
        End Set
    End Property
    Public Property OrderCode(ByVal i As Integer)
        Get
            Return _data.Rows(i)(1)
        End Get
        Set(value)
            _data.Rows(i)(1) = value
        End Set
    End Property
    Public Property Name(ByVal i As Integer)
        Get
            Return _data.Rows(i)(2)
        End Get
        Set(value)
            _data.Rows(i)(2) = value
        End Set
    End Property
    Public Property CarNo(ByVal i As Integer)
        Get
            Return _data.Rows(i)(3)
        End Get
        Set(value)
            _data.Rows(i)(3) = value
        End Set
    End Property
    Public Property Volume(ByVal i As Integer)
        Get
            Return _data.Rows(i)(4)
        End Get
        Set(value)
            _data.Rows(i)(4) = value
        End Set
    End Property
    Public Property CbnCode(ByVal i As Integer)
        Get
            Return _data.Rows(i)(5)
        End Get
        Set(value)
            _data.Rows(i)(5) = value
        End Set
    End Property
    Public Function RemoveRow(ByVal i As Integer) As Boolean
        Try
            If _NumberOfRows > 0 And _NumberOfRows > i Then
                _data.Rows.RemoveAt(i)
                _NumberOfRows -= 1
                UpdateTable()
                UpdateServer()
            End If
            Return True
        Catch
            Return False
        End Try
    End Function
    Public Function AddRow(ByVal val1 As Integer, ByVal val2 As String, ByVal val3 As String, ByVal val4 As Integer, ByVal val5 As Integer) As Boolean
        Try
            Dim i As Integer
            For i = 0 To _NumberOfRows - 1
                If OrderCode(i) = val1 Then
                    Return False
                End If
            Next
            _NumberOfRows += 1
            _data.Rows.Add(_NumberOfRows, val1, val2, val3, val4, val5)
            UpdateServer()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function EditRow(ByVal val0 As Integer, ByVal val1 As Integer, ByVal val2 As String, ByVal val3 As String, ByVal val4 As Integer, ByVal val5 As Integer)
        Dim i As Integer = 0
        If val0 = _data.Rows(val0 - 1)(0) And val1 = _data.Rows(val0 - 1)(1) Then
            Try
                Name(val0 - 1) = val2
                CarNo(val0 - 1) = val3
                Volume(val0 - 1) = val4
                CbnCode(val0 - 1) = val5
                If UpdateServer() Then
                    Return True
                Else
                    Return False
                End If
            Catch
                Return False
            End Try
        Else
            Return False
        End If
    End Function
End Class