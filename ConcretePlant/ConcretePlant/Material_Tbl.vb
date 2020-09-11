Imports System.Data.SqlClient

Public Class Material_Tbl
    Private _Code As Integer = -1
    Private _LoadcellCD As Integer = -1
    Private _MaterialNo As Integer = -1
    Private _WeighingStep As Integer = -1
    Private _Type As Integer = -1
    Private _JoggingType As Integer = -1
    Private _JoggingON As Integer = -1
    Private _JoggingOFF As Integer = -1
    Private _FineWeighing As Integer = -1
    Private _CompletionTime As Integer = -1
    Private _CompletionRange As Integer = -1
    Private _CompletionBit As Integer = 0
    Public Sub New()
        '-------------
    End Sub
    Public Sub New(ByVal Code_ As Integer)
        GetMaterialbyCode(Code_)
    End Sub
    Public Property CompletionBit() As Integer
        Get
            Return _CompletionBit
        End Get
        Set(value As Integer)
            _CompletionBit = value
        End Set
    End Property
    Public Property Code() As Integer
        Get
            Return _Code
        End Get
        Set(value As Integer)
            _Code = value
        End Set
    End Property
    Public Property LoadcellCD() As Integer
        Get
            Return _LoadcellCD
        End Get
        Set(value As Integer)
            _LoadcellCD = value
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
    Public Property MaterialNo() As Integer
        Get
            Return _MaterialNo
        End Get
        Set(value As Integer)
            _MaterialNo = value
        End Set
    End Property
    Public Property WeighingStep() As Integer
        Get
            Return _WeighingStep
        End Get
        Set(value As Integer)
            _WeighingStep = value
        End Set
    End Property
    Public Property JoggingType() As Integer
        Get
            Return _JoggingType
        End Get
        Set(value As Integer)
            _JoggingType = value
        End Set
    End Property
    Public Property JoggingON() As Integer
        Get
            Return _JoggingON
        End Get
        Set(value As Integer)
            _JoggingON = value
        End Set
    End Property
    Public Property JoggingOFF() As Integer
        Get
            Return _JoggingOFF
        End Get
        Set(value As Integer)
            _JoggingOFF = value
        End Set
    End Property
    Public Property FineWeighing() As Integer
        Get
            Return _FineWeighing
        End Get
        Set(value As Integer)
            _FineWeighing = value
        End Set
    End Property
    Public Property CompletionTime() As Integer
        Get
            Return _CompletionTime
        End Get
        Set(value As Integer)
            _CompletionTime = value
        End Set
    End Property
    Public Property CompletionRange() As Integer
        Get
            Return _CompletionRange
        End Get
        Set(value As Integer)
            _CompletionRange = value
        End Set
    End Property
    ' ===========================================================================================================
    ' ===========================================================================================================
    ' GetMaterialbyCode(ByVal Code_ As String): Look for material with Code = "Code_" and take all properties of material Code_. 
    '   The Function returns True If succeed
    Public Function GetMaterialbyCode(ByVal Code_ As Integer) As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "select LoadcellCD, MaterialNo, Type, WeighingStep, JoggingType, JoggingON, JoggingOFF, FineWeighing, CompletionBit, CompletionTime, CompletionRange from Material_Tbl where Code = " & Code_.ToString
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                Dim data As SqlDataReader = cmd.ExecuteReader()
                Do While data.Read
                    _LoadcellCD = data.GetInt32(0)
                    _MaterialNo = data.GetInt32(1)
                    _Type = data.GetInt32(2)
                    _WeighingStep = data.GetInt32(3)
                    _JoggingType = data.GetInt32(4)
                    _JoggingON = data.GetInt32(5)
                    _JoggingOFF = data.GetInt32(6)
                    _FineWeighing = data.GetInt32(7)
                    _CompletionBit = data.GetInt32(8)
                    _CompletionTime = data.GetInt32(9)
                    _CompletionRange = data.GetInt32(10)
                    isOK = True
                    _Code = Code_
                Loop
            Catch ex As Exception
                MessageBox.Show("Can not find that Material in server")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
    ' ===========================================================================================================
    ' ===========================================================================================================
    ' DeleteMaterial: Delete Material has code = Code_
    Public Function DeleteMaterial(ByVal Code_ As Integer) As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "delete from Material_Tbl where Code=" & Code_.ToString
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                cmd.ExecuteNonQuery()
                isOK = True
            Catch ex As Exception
                MessageBox.Show("Can not find that Material in server")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
    ' ===========================================================================================================
    ' ===========================================================================================================
    ' WriteMaterial: Insert Material by properties as those parameters
    Public Function WriteMaterial(ByVal Code_ As Integer, ByVal LoadcellCD_ As Integer, ByVal MaterialNo_ As Integer, ByVal Type_ As Integer, ByVal WeighingStep_ As Integer, ByVal JoggingType_ As Integer, ByVal JoggingON_ As Integer, ByVal JoggingOFF_ As Integer, ByVal FineWeighing_ As Integer, ByVal CompletionBit_ As Integer, ByVal CompletionTime_ As Integer, CompletionRange_ As Integer) As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "insert into Material_Tbl values(" & Code_.ToString & "," & LoadcellCD_ & "," & MaterialNo_.ToString & "," & Type_.ToString & "," & WeighingStep_.ToString & "," & JoggingType_.ToString & "," & JoggingON_.ToString & "," & JoggingOFF_.ToString & "," & FineWeighing_.ToString & "," & CompletionBit_.ToString & "," & CompletionTime_.ToString & "," & CompletionRange_ & ")"
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                cmd.ExecuteNonQuery()
                isOK = True
            Catch ex As Exception
                MessageBox.Show("Can not write that Material in server, it may have a Material with the same code")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
    ' ===========================================================================================================
    ' ===========================================================================================================
    ' WriteMaterial: Insert material by object's properties
    Public Function WriteMaterial()
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "insert into Material_Tbl values(" & _Code.ToString & ", " & _LoadcellCD.ToString & " ," & _MaterialNo.ToString & "," & _Type.ToString & "," & _WeighingStep.ToString & "," & _JoggingType.ToString & "," & _JoggingON.ToString & "," & _JoggingOFF.ToString & "," & _FineWeighing.ToString & "," & _CompletionBit.ToString & "," & _CompletionTime.ToString & "," & _CompletionRange.ToString & ")"
                Dim cmd As SqlCommand = New SqlCommand(CmdStr, conn_)
                cmd.ExecuteNonQuery()
                isOK = True
            Catch ex As Exception
                MessageBox.Show("Can not update in server")
            End Try
            conn_.Close()
        Catch ex As Exception
            MessageBox.Show("Can not connect to server")
        End Try
        Return isOK
    End Function
    Public Function UpdateMaterial() As Boolean
        Dim isOK As Boolean = False
        Try
            Dim conn_ As New SqlConnection()
            conn_.ConnectionString = Setting.__ConnStr
            conn_.Open()
            Try
                Dim CmdStr As String = "update Material_Tbl set LoadcellCD= " & _LoadcellCD.ToString & ", MaterialNo = " & _MaterialNo.ToString & ", Type = " & _Type.ToString & ", WeighingStep = " & _WeighingStep.ToString & ", JoggingType = " & _JoggingType.ToString & ",JoggingON = " & _JoggingON.ToString & ", JoggingOFF = " & _JoggingOFF.ToString & ", FineWeighing = " & _FineWeighing.ToString & ", CompletionBit = " & _CompletionBit.ToString & ", CompletionTime = " & _CompletionTime.ToString & ", CompletionRange = " & _CompletionRange.ToString & " where Code = " & _Code.ToString
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
