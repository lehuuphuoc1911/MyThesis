Imports System.Globalization
Imports ConcretePlant.Setting
Public Class Delete
    Dim order As Order
    Dim no_ As Integer
    Private Sub Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBounds((Screen.GetWorkingArea(Me).Width - Width) / 2, (Screen.GetWorkingArea(Me).Height - Height) / 2, Width, Height)
        My.Resources.Resource.Culture = New CultureInfo(__Language)
        Me.Text = My.Resources.Resource.btn_del_ope
        Label1.Text = My.Resources.Resource.DELWARR & " " & My.Resources.Resource.No_ & " " & (no_ + 1).ToString & "?"
        bt_no.Text = My.Resources.Resource.NO
        bt_yes.Text = My.Resources.Resource.YES
    End Sub
    Public Sub New(ByRef order_ As Order, ByVal i As Integer)
        order = order_
        no_ = i
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub bt_no_Click(sender As Object, e As EventArgs) Handles bt_no.Click
        Me.Close()
    End Sub

    Private Sub bt_yes_Click(sender As Object, e As EventArgs) Handles bt_yes.Click
        If order.RemoveRow(no_) = False Then
            MessageBox.Show("CAN NOT REMOVE")
        End If
        Me.Close()
    End Sub
End Class