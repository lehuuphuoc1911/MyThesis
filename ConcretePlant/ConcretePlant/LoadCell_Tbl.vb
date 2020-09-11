Imports System.Data.SqlClient

Public Class LoadCell_Tbl
    Private _Code As Integer = -1
    Private _Name As String = ""
    Private _Type As Integer = -1
    Private _Capacity As Integer = -1
    Private _DecPoint As Integer = 0
    Private _Zero As Integer = 0
    Private _Span As Integer = -1
    Private _GateOpenLmt As Integer = -1
    Private _ExportTo As Integer = 0
    Private _ImportFrom1 As Integer = 0
    Private _ImportFrom2 As Integer = 0
    Private _ImportFrom3 As Integer = 0
    Public Sub New()

    End Sub
    Public Sub New(ByVal Code_ As Integer)
        GetLoadCellbyCode(Code_)
    End Sub
    Public Property Code() As Integer
        Get
            Return _Code
        End Get
        Set(value As Integer)
            _Code = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property
    Public Property Type() As Integer
        Get
            Return _Type
        End Get
        Set(value As Integer)
            _Type = value
        End Set
    End Property
    Public Property Capacity() As Integer
        Get
            Return _Capacity
        End Get
        Set(value As Integer)
            _Capacity = value
        End Set
    End Property
    Public Property DecPoint() As Integer
        Get
            Return _DecPoint
        End Get
        Set(value As Integer)
            _DecPoint = value
        End Set
    End Property
    Public Property Zero() As Integer
        Get
            Return _Zero
        End Get
        Set(value As Integer)
            _Zero = value
        End Set
    End Property
    Public Property Span() As Integer
        Get
            Return _Span
        End Get
        Set(value As Integer)
            _Span = value
        End Set
    End Property
    Public Property GateOpenLmt() As Integer
        Get
            Return _GateOpenLmt
        End Get
        Set(value As Integer)
            _GateOpenLmt = value
        End Set
    End Property
    Public Property ExportTo() As Integer
        Get
            Return _ExportTo
        End Get
        Set(value As Integer)
            _ExportTo = value
        End Set
    End Property
    Public Property ImportFrom1() As Integer
        Get
            Return _ImportFrom1
        End Get
        Set(value As Integer)
            _ImportFrom1 = value
        End Set
    End Property
    Public Property ImportFrom2() As Integer
        Get
            Return _ImportFrom2
        End Get
        Set(value As Integer)
            _ImportFrom2 = value
        End Set
    End Property
    Public Property ImportFrom3() As Integer
        Get
            Return _ImportFrom3
        End Get
        Set(value As Integer)
            _ImportFrom3 = value
        End Set
    End Property
    ' ===========================================================================================================
    ' ===========================================================================================================
    ' GetLoadCellbyCode(ByVal Code_ As String): Look for Loadcell with Code = "Code_" and set all property of loadcell Code_. 
    '   The Function returns True If succeed
    Public Function GetLoadCellbyCode(ByVal Code_ As Integer) As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "select Name, Type, Capacity, DecPoint, Zero, Span, GateOpenLmt, ExportTo, ImportFrom1, ImportFrom2, ImportFrom3 from Loadcell_Tbl where Code = " & Code_.ToString
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                Dim data As SqlDataReader = cmd.ExecuteReader()
                Do While data.Read
                    _Name = data.GetString(0)
                    _Type = data.GetInt32(1)
                    _Capacity = data.GetInt32(2)
                    _DecPoint = data.GetInt32(3)
                    _Zero = data.GetInt32(4)
                    _Span = data.GetInt32(5)
                    _GateOpenLmt = data.GetInt32(6)
                    _ExportTo = data.GetInt32(7)
                    _ImportFrom1 = data.GetInt32(8)
                    _ImportFrom2 = data.GetInt32(9)
                    _ImportFrom3 = data.GetInt32(10)
                    isOK = True
                Loop
                _Code = Code_
            Catch ex As Exception
                MessageBox.Show("Can not find that Loadcell in server")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
    ' ===========================================================================================================
    ' ===========================================================================================================
    ' DeleteLoadcell: Delete Loadcell has code = Code_
    Public Function DeleteLoadcell(ByVal Code_ As Int32) As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "delete from Loadcell_Tbl where Code=" & Code_.ToString
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                cmd.ExecuteNonQuery()
                isOK = True
            Catch ex As Exception
                MessageBox.Show("Can not find that Loadcell in server")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
    ' ===========================================================================================================
    ' ===========================================================================================================
    ' WriteLoadcell: Insert Loadcell by properties as those parameters
    Public Function WriteLoadcell(ByVal Code_ As Integer, ByVal Name_ As String, ByVal Type_ As Integer, ByVal Capacity_ As Integer, ByVal Decpoint_ As Integer, ByVal Zero_ As Integer, ByVal Span_ As Integer, ByVal GateOpenLmt_ As Integer) As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try

                Dim CmdStr As String = "insert into Loadcell_Tbl values(" & Code_.ToString & ",'" & Name_ & "'," & Type_.ToString & "," & Capacity_.ToString & "," & Decpoint_.ToString & "," & Zero_.ToString & "," & Span_.ToString & "," & GateOpenLmt_.ToString & "," & _ExportTo.ToString & "," & _ImportFrom1.ToString & "," & _ImportFrom2.ToString & "," & _ImportFrom3.ToString & ")"
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                cmd.ExecuteNonQuery()
                isOK = True
            Catch ex As Exception
                MessageBox.Show("Can not write that Loadcell in server, it may have a loadcell with the same code")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
    ' ===========================================================================================================
    ' ===========================================================================================================
    ' WriteLoadcell: Insert Loadcell by object properties
    Public Function WriteLoadcell() As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "insert into Loadcell_Tbl values(" & _Code.ToString & ",'" & _Name & "'," & _Type.ToString & "," & _Capacity.ToString & "," & _DecPoint.ToString & "," & _Zero.ToString & "," & _Span.ToString & "," & _GateOpenLmt.ToString & _ExportTo.ToString & "," & _ImportFrom1.ToString & "," & _ImportFrom2.ToString & "," & _ImportFrom3.ToString & ")"
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                cmd.ExecuteNonQuery()
                isOK = True
            Catch ex As Exception
                MessageBox.Show("Can not write that Loadcell in server, it may have a loadcell with the same code or your loadcell is invalid")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
End Class























