Imports System.Data.SqlClient
Imports System.Globalization
Imports ConcretePlant.Setting

Public Class Combine_Tbl
    Private _CbnCode As Integer = -1
    Public Sub New()
        _CbnCode = -1
        Dim i As Integer
        For i = 0 To 31
            _Value(i) = 0
        Next
    End Sub
    Public Sub New(ByVal Code_ As Integer)
        GetCombinebyCode(Code_)
    End Sub
    Private _Value(31) As Integer
    Public Property CbnCode() As Integer
        Get
            Return _CbnCode
        End Get
        Set(value As Integer)
            _CbnCode = value
        End Set
    End Property
    Public Function GetValue(ByVal i As Integer)
        Return _Value(i)
    End Function
    Public Sub SetValue(ByVal x() As Integer)
        _Value = x
    End Sub
    Public Sub SetValue(ByVal i As Integer, ByVal x As Integer)
        _Value(i) = x
    End Sub
    ' ===========================================================================================================
    ' ===========================================================================================================
    ' GetCombinebyCode(ByVal Code_ As String): Look for combine with CbnCode = "CbnCode_" and take all properties of material Code_. 
    '   The Function returns True If succeed
    Public Function GetCombinebyCode(ByVal CbnCode_ As Integer) As Boolean
        Dim isOK As Boolean = False
        My.Resources.Resource.Culture = New CultureInfo(__Language)
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = __ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "select "
                Dim j As Integer
                For j = 1 To 31
                    CmdStr = CmdStr & "Value" & j.ToString & " , "
                Next
                CmdStr = CmdStr & "Value32  from Combine_Tbl where CbnCode = " & CbnCode_
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                Dim data As SqlDataReader = cmd.ExecuteReader()
                Do While data.Read
                    Dim i As Integer = 0
                    For i = 0 To 31
                        SetValue(i, data.GetInt32(i))
                    Next
                    isOK = True
                Loop
                _CbnCode = CbnCode_
            Catch ex As Exception
                MessageBox.Show("CAN NOT GET DATA FROM SERVER")
            End Try
            conn_.Close()
            If isOK = False Then
                MessageBox.Show("COMBINE CODE NOT FOUND")
            End If
        Catch ex As Exception
            MessageBox.Show("CAN NOT CONNECT TO SERVER")
        End Try
        Return isOK
    End Function
    ' ===========================================================================================================
    ' ===========================================================================================================
    ' DeleteCombine: Delete Combine has CbnCode = CbnCode_
    Public Function DeleteCombine(ByVal CbnCode_ As Integer) As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "delete from Combine_Tbl where CbnCode=" & CbnCode_.ToString
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                cmd.ExecuteNonQuery()
                isOK = True
            Catch ex As Exception
                MessageBox.Show("COMBINE CODE NOT FOUND")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("CAN NOT CONNECT TO SERVER")
        End Try
        Return isOK
    End Function
    ' ===========================================================================================================
    ' ===========================================================================================================
    ' WriteCombine: Insert combine by properties as those parameters
    Public Function WriteCombine(ByVal CbnCode_ As Integer, ByVal Value_() As Integer, ByVal K As Integer) As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "insert into Combine_Tbl values( " & CbnCode_.ToString
                Dim i As Integer
                For i = 0 To K - 1
                    CmdStr = CmdStr & " , " & Value_(i).ToString
                Next
                For i = K To 31
                    CmdStr = CmdStr & " , " & "0"
                Next
                CmdStr = CmdStr & " )"
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                cmd.ExecuteNonQuery()
                isOK = True
            Catch ex As Exception
                MessageBox.Show("Can not write that combine in server, it may have a combine with the same code")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("CAN NOT CONNECT TO SERVER")
        End Try
        Return isOK
    End Function
    ' ===========================================================================================================
    ' ===========================================================================================================
    ' WriteMaterial: Insert material by object's properties
    Public Function WriteCombine() As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "insert into Combine_Tbl values(" & _CbnCode.ToString
                Dim i As Integer
                For i = 0 To 31
                    CmdStr = CmdStr & ", " & _Value(i).ToString
                Next
                CmdStr = CmdStr & ")"
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                cmd.ExecuteNonQuery()
                isOK = True
            Catch ex As Exception
                MessageBox.Show("Can not write that combine in server, it may have a combine with the same code or your combine is invalid")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
    Public Function EditCombine(ByVal value() As Integer) As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "update Combine_Tbl set Value1 =" & value(0).ToString
                Dim i As Integer
                For i = 2 To 32
                    CmdStr = CmdStr & ", Value" & i.ToString & " = " & _Value(i - 1).ToString
                Next
                CmdStr = CmdStr & " where CbnCode = " & _CbnCode.ToString
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                cmd.ExecuteNonQuery()
                isOK = True
            Catch ex As Exception
                MessageBox.Show("Can not edit")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
    Public Sub PLCWrite(ByVal volume As Integer)
        Dim i As Integer
        Dim m(23) As Long
        For i = 0 To 23
            m(i) = Convert.ToInt64(_Value(i) * (volume \ 10))
        Next
        m = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        MCSendData("D220", 24, m)
    End Sub
End Class
