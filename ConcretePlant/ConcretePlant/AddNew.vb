Imports System.Globalization
Imports ConcretePlant.Setting
Public Class AddNew
    Private order As Order
    Private Sub AddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBounds((Screen.GetWorkingArea(Me).Width - Width) / 2, (Screen.GetWorkingArea(Me).Height - Height) / 2, Width, Height)
        tbx_No.Text = (order.NumberOfRows + 1).ToString
        My.Resources.Resource.Culture = New CultureInfo(__Language)
        Me.Text = My.Resources.Resource.addnew
        bt_add.Text = My.Resources.Resource.ADD
        lb_CarNo.Text = My.Resources.Resource.CARNO
        lb_CbnCode.Text = My.Resources.Resource.CBNCODE
        lb_Name.Text = My.Resources.Resource.NAME
        lb_No.Text = My.Resources.Resource.No_
        lb_Volume.Text = My.Resources.Resource.VOLUME
        lb_OrderCode.Text = My.Resources.Resource.ORDERCODE
    End Sub
    Public Sub New(ByRef _order)
        order = _order
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub bt_add_Click(sender As Object, e As EventArgs) Handles bt_add.Click
        Dim ok As Boolean = True
        Dim order_code_int As Integer
        Dim volume_int As Integer
        Dim combine_code_int As Integer
        Try
            order_code_int = Integer.Parse(tbx_OrderCode.Text)
            volume_int = StrToInt(tbx_Volume.Text)
            If volume_int < __MixerStep Then
                MessageBox.Show("VOLUME IS TO LOW")
                ok = False
            End If
            combine_code_int = Integer.Parse(tbx_CbnCode.Text)
            Dim combine As Combine_Tbl = New Combine_Tbl
            If combine.GetCombinebyCode(combine_code_int) = False Then
                ok = False
            End If
            If tbx_Name.Text = Nothing Or tbx_CarNo.Text = Nothing Then
                ok = False
            End If
        Catch ex As Exception
            ok = False
        End Try
        If ok = True Then
            If order.AddRow(order_code_int, tbx_Name.Text, tbx_CarNo.Text, volume_int, combine_code_int) Then
                Me.Close()
            End If
        Else
            MessageBox.Show("INVALID INPUT")
        End If
    End Sub
End Class