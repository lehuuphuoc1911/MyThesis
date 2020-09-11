Imports System.Globalization
Imports ConcretePlant.Setting
Public Class Edit

    Private order As Order
    Private No_int As Integer
    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBounds((Screen.GetWorkingArea(Me).Width - Width) / 2, (Screen.GetWorkingArea(Me).Height - Height) / 2, Width, Height)
        tbx_No.Text = (No_int + 1).ToString
        tbx_OrderCode.Text = order.OrderCode(No_int).ToString
        tbx_CarNo.Text = order.CarNo(No_int).ToString
        tbx_Name.Text = order.Name(No_int).ToString
        tbx_CbnCode.Text = order.CbnCode(No_int).ToString
        tbx_Volume.Text = IntToStr(order.Volume(No_int))
        My.Resources.Resource.Culture = New CultureInfo(__Language)
        Text = My.Resources.Resource.bt_edit
        bt_edit.Text = My.Resources.Resource.bt_edit
        lb_CarNo.Text = My.Resources.Resource.CARNO
        lb_CbnCode.Text = My.Resources.Resource.CBNCODE
        lb_Name.Text = My.Resources.Resource.NAME
        lb_No.Text = My.Resources.Resource.No_
        lb_OrderCode.Text = My.Resources.Resource.ORDERCODE
        lb_Volume.Text = My.Resources.Resource.VOLUME
    End Sub
    Public Sub New(ByRef _order, ByVal _No_int)
        order = _order
        No_int = _No_int
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        Dim ok As Boolean = True
        Dim volume_int As Integer
        Dim combine_code_int As Integer
        Try
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
        If ok Then
            If order.EditRow(No_int + 1, order.OrderCode(No_int), tbx_Name.Text, tbx_CarNo.Text, volume_int, combine_code_int) = False Then
                MessageBox.Show("can not add")
            Else
                Me.Close()
            End If
        Else
            MessageBox.Show("invalid input")
        End If
    End Sub
End Class