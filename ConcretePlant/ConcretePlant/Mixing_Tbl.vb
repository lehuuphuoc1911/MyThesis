Imports System.Data.SqlClient
Public Class Mixing_Tbl
    Private _Code As Integer
    Private _LoadcellCD As Integer
    Private _MixingType1 As Integer = 0
    Private _MixingType2 As Integer = 0
    Private _MixingType3 As Integer = 0
    Private _MixingType4 As Integer = 0
    Private _MixingType5 As Integer = 0
    Private _MixingType6 As Integer = 0
    Private _MixingType7 As Integer = 0
    Private _MixingType8 As Integer = 0
    Private _MixingType9 As Integer = 0
    Private _MixingType10 As Integer = 0
    Private _CountUpType As Integer = 0
    Private _MixerGateOpenTime As Integer = 0
    Private _MixerEmptyTime As Integer = 0
    Private _MixerCheckTime As Integer = 0
    Private _HopperCheckTime As Integer = 0
    Public Property Code() As Integer
        Get
            Return _Code
        End Get
        Set(value As Integer)
            _Code = value
        End Set
    End Property
    Public Property MixingType1() As Integer
        Get
            Return _MixingType1
        End Get
        Set(value As Integer)
            _MixingType1 = value
        End Set
    End Property
    Public Property MixingType2() As Integer
        Get
            Return _MixingType2
        End Get
        Set(value As Integer)
            _MixingType2 = value
        End Set
    End Property
    Public Property MixingType3() As Integer
        Get
            Return _MixingType3
        End Get
        Set(value As Integer)
            _MixingType3 = value
        End Set
    End Property
    Public Property MixingType4() As Integer
        Get
            Return _MixingType4
        End Get
        Set(value As Integer)
            _MixingType4 = value
        End Set
    End Property
    Public Property MixingType5() As Integer
        Get
            Return _MixingType5
        End Get
        Set(value As Integer)
            _MixingType5 = value
        End Set
    End Property
    Public Property MixingType6() As Integer
        Get
            Return _MixingType6
        End Get
        Set(value As Integer)
            _MixingType6 = value
        End Set
    End Property
    Public Property MixingType7() As Integer
        Get
            Return _MixingType7
        End Get
        Set(value As Integer)
            _MixingType7 = value
        End Set
    End Property
    Public Property MixingType8() As Integer
        Get
            Return _MixingType8
        End Get
        Set(value As Integer)
            _MixingType8 = value
        End Set
    End Property
    Public Property MixingType9() As Integer
        Get
            Return _MixingType9
        End Get
        Set(value As Integer)
            _MixingType9 = value
        End Set
    End Property
    Public Property MixingType10() As Integer
        Get
            Return _MixingType10
        End Get
        Set(value As Integer)
            _MixingType10 = value
        End Set
    End Property
    Public Property CountUpType() As Integer
        Get
            Return _CountUpType
        End Get
        Set(value As Integer)
            _CountUpType = value
        End Set
    End Property
    Public Property MixerGateOpenTime() As Integer
        Get
            Return _MixerGateOpenTime
        End Get
        Set(value As Integer)
            _MixerGateOpenTime = value
        End Set
    End Property
    Public Property MixerEmptyTime() As Integer
        Get
            Return _MixerEmptyTime
        End Get
        Set(value As Integer)
            _MixerEmptyTime = value
        End Set
    End Property
    Public Property MixerCheckTime() As Integer
        Get
            Return _MixerCheckTime
        End Get
        Set(value As Integer)
            _MixerCheckTime = value
        End Set
    End Property
    Public Property HopperCheckTime() As Integer
        Get
            Return _HopperCheckTime
        End Get
        Set(value As Integer)
            _HopperCheckTime = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal Code_ As Integer)
        GetMixingbyCode(Code_)
    End Sub
    Public Function GetMixingbyCode(ByVal Code_ As Integer) As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "select MixingType1, MixingType2, MixingType3, MixingType4, MixingType5, MixingType6, MixingType7, MixingType8, MixingType9, MixingType10, CountUpType, MixerGateOpenTime, MixerEmptyTime, MixerCheckTime, HopperCheckTime from Mixing_Tbl where Code = " & Code_.ToString
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                Dim data As SqlDataReader = cmd.ExecuteReader()
                Do While data.Read
                    _MixingType1 = data.GetInt32(0)
                    _MixingType2 = data.GetInt32(1)
                    _MixingType3 = data.GetInt32(2)
                    _MixingType4 = data.GetInt32(3)
                    _MixingType5 = data.GetInt32(4)
                    _MixingType6 = data.GetInt32(5)
                    _MixingType7 = data.GetInt32(6)
                    _MixingType8 = data.GetInt32(7)
                    _MixingType9 = data.GetInt32(8)
                    _MixingType10 = data.GetInt32(9)
                    _CountUpType = data.GetInt32(10)
                    _MixerGateOpenTime = data.GetInt32(11)
                    _MixerEmptyTime = data.GetInt32(12)
                    _MixerCheckTime = data.GetInt32(13)
                    _HopperCheckTime = data.GetInt32(14)
                    isOK = True
                Loop
                _Code = Code_
            Catch ex As Exception
                MessageBox.Show("Can not find that mixture in server")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
    Public Function DeleteMixing(ByVal Code_ As Int32) As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "delete from Mixing_Tbl where Code = " & Code_.ToString
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                cmd.ExecuteNonQuery()
                isOK = True
            Catch ex As Exception
                MessageBox.Show("Can not find that mixture in server")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
    Public Function WriteMixing(ByVal Code_ As Integer, ByVal val1 As Integer, ByVal val2 As Integer, ByVal val3 As Integer, ByVal val4 As Integer, ByVal val5 As Integer, ByVal val6 As Integer, ByVal val7 As Integer, ByVal val8 As Integer, ByVal val9 As Integer, ByVal val10 As Integer, ByVal val11 As Integer, ByVal val12 As Integer, ByVal val13 As Integer, ByVal val14 As Integer, ByVal val15 As Integer) As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try

                Dim CmdStr As String = "insert into Mixing_Tbl values(" & Code_.ToString & "," & val1.ToString & "," & val2.ToString & "," & val3.ToString & "," & val4.ToString & "," & val5.ToString & "," & val6.ToString & "," & val7.ToString & "," & val8.ToString & "," & val9.ToString & "," & val10.ToString & "," & val11.ToString & "," & val12.ToString & "," & val13.ToString & "," & val14.ToString & "," & val15.ToString & ")"
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                cmd.ExecuteNonQuery()
                isOK = True
            Catch ex As Exception
                MessageBox.Show("Can not write that mixture")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
    Public Function WriteMixing() As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "insert into Mixing_Tbl values(" & _Code.ToString & "," & _MixingType1.ToString & "," & _MixingType2.ToString & "," & _MixingType3.ToString & "," & _MixingType4.ToString & "," & _MixingType5.ToString & "," & _MixingType6.ToString & "," & _MixingType7.ToString & "," & _MixingType8.ToString & "," & _MixingType9.ToString & "," & _MixingType10.ToString & "," & _CountUpType.ToString & " , " & _MixerGateOpenTime.ToString & " , " & _MixerEmptyTime.ToString & " , " & _MixerCheckTime.ToString & " , " & _HopperCheckTime.ToString & ")"
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                cmd.ExecuteNonQuery()
                isOK = True
            Catch ex As Exception
                MessageBox.Show("Can not write in server, it may have a mixture with the same code or your mixture is invalid")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
    Public Function UpdateMixing() As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "update Mixing_Tbl set MixingType1 = " & _MixingType1.ToString & " , MixingType2 = " & _MixingType2.ToString & " , MixingType3 = " & _MixingType3.ToString & " , MixingType4 = " & _MixingType4.ToString & " , MixingType5 = " & _MixingType5.ToString & " , MixingType6 = " & _MixingType6.ToString & " , MixingType7 = " & _MixingType7.ToString & " , MixingType8 = " & _MixingType8.ToString & " , MixingType9 = " & _MixingType9.ToString & " , MixingType10 = " & _MixingType10.ToString & " , CountUpType = " & _CountUpType.ToString & " , MixerGateOpenTime = " & _MixerGateOpenTime.ToString & " , MixerEmptyTime =" & _MixerEmptyTime.ToString & " , MixerCheckTime =" & _MixerCheckTime.ToString & " , HopperCheckTime =" & _HopperCheckTime.ToString & " where Code = " & _Code
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                cmd.ExecuteNonQuery()
                isOK = True
            Catch ex As Exception
                MessageBox.Show("Can not UPDATE")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
End Class
