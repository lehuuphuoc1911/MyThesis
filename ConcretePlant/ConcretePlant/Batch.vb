Imports System.Globalization
Imports ConcretePlant.Setting
Public Class Batch
    Dim vol1_ As Integer = 0
    Dim no1_ As Integer = 0
    Dim vol2_ As Integer = 0
    Dim no2_ As Integer = 0
    Dim order As Order
    Dim no_order As Integer
    Private Sub Batch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBounds((Screen.GetWorkingArea(Me).Width - Width) / 2, (Screen.GetWorkingArea(Me).Height - Height) / 2, Width, Height)
        My.Resources.Resource.Culture = New CultureInfo(__Language)
        Lb_BatVol1.Text = My.Resources.Resource.BATCHVOL1
        Lb_BatVol2.Text = My.Resources.Resource.BATCHVOL2
        Lb_No1.Text = My.Resources.Resource.BATNO1
        Lb_No2.Text = My.Resources.Resource.BATNO2
        Me.Text = My.Resources.Resource.FRM_BATCH
        If split_(order.Volume(no_order)) Then
            tb_no1.Text = no1_
            tb_no2.Text = no2_
            tb_Vol1.Text = IntToStr(vol1_)
            tb_vol2.Text = IntToStr(vol2_)
        End If
        '============================================================
        Dim loadcell As LoadCell_Tbl = New LoadCell_Tbl
        Dim material As Material_Tbl = New Material_Tbl
        Dim combine As Combine_Tbl = New Combine_Tbl
        combine.GetCombinebyCode(order.CbnCode(no_order))
        '--------------
        If loadcell.GetLoadCellbyCode(0) = False Then
            Panel10.Hide()
            Panel10.Enabled = False
            Panel20.Hide()
            Panel20.Enabled = False
        Else
            Lb1_G.Text = loadcell.Name
            Lb2_G.Text = loadcell.Name
            If material.GetMaterialbyCode(0) = False Then
                Tbx1_G1.Enabled = False
                Tbx2_G1.Enabled = False
            Else
                Lb1_G1.Text = loadcell.Name + material.WeighingStep.ToString
                Lb2_G1.Text = loadcell.Name + material.WeighingStep.ToString
                Tbx1_G1.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                Tbx2_G1.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
            End If
            If material.GetMaterialbyCode(1) = False Then
                Tbx1_G2.Enabled = False
                Tbx2_G2.Enabled = False
            Else
                Lb1_G2.Text = loadcell.Name + material.WeighingStep.ToString
                Lb2_G2.Text = loadcell.Name + material.WeighingStep.ToString
                Tbx1_G2.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                Tbx2_G2.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
            End If
            If material.GetMaterialbyCode(2) = False Then
                Tbx1_G3.Enabled = False
                Tbx2_G3.Enabled = False
            Else
                Lb1_G3.Text = loadcell.Name + material.WeighingStep.ToString
                Lb2_G3.Text = loadcell.Name + material.WeighingStep.ToString
                Tbx1_G3.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                Tbx2_G3.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
            End If
            If material.GetMaterialbyCode(3) = False Then
                Tbx1_G4.Enabled = False
                Tbx2_G4.Enabled = False
            Else
                Lb1_G4.Text = loadcell.Name + material.WeighingStep.ToString
                Lb2_G4.Text = loadcell.Name + material.WeighingStep.ToString
                Tbx1_G4.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                Tbx2_G4.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
            End If
        End If
        '--------------
        If loadcell.GetLoadCellbyCode(1) = False Then
            Panel11.Hide()
            Panel11.Enabled = False
            Panel21.Hide()
            Panel21.Enabled = False
        Else
            Lb1_S.Text = loadcell.Name
            Lb2_S.Text = loadcell.Name
            If material.GetMaterialbyCode(4) = False Then
                Tbx1_S1.Enabled = False
                Tbx2_S1.Enabled = False
            Else
                Lb1_S1.Text = loadcell.Name + material.WeighingStep.ToString
                Lb2_S1.Text = loadcell.Name + material.WeighingStep.ToString
                Tbx1_S1.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                Tbx2_S1.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
            End If
            If material.GetMaterialbyCode(5) = False Then
                Tbx1_S2.Enabled = False
                Tbx2_S2.Enabled = False
            Else
                Lb1_S2.Text = loadcell.Name + material.WeighingStep.ToString
                Lb2_S2.Text = loadcell.Name + material.WeighingStep.ToString
                Tbx1_S2.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                Tbx2_S2.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
            End If
            If material.GetMaterialbyCode(6) = False Then
                Tbx1_S3.Enabled = False
                Tbx2_S3.Enabled = False
            Else
                Lb1_S3.Text = loadcell.Name + material.WeighingStep.ToString
                Lb2_S3.Text = loadcell.Name + material.WeighingStep.ToString
                Tbx1_S3.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                Tbx2_S3.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
            End If
            If material.GetMaterialbyCode(7) = False Then
                Tbx1_S4.Enabled = False
                Tbx2_S4.Enabled = False
            Else
                Lb1_S4.Text = loadcell.Name + material.WeighingStep.ToString
                Lb2_S4.Text = loadcell.Name + material.WeighingStep.ToString
                Tbx1_S4.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                Tbx2_S4.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
            End If
        End If
        '--------------
        If loadcell.GetLoadCellbyCode(2) = False Then
            Panel12.Hide()
            Panel12.Enabled = False
            Panel22.Hide()
            Panel22.Enabled = False
        Else
            Lb1_C.Text = loadcell.Name
            Lb2_C.Text = loadcell.Name
            If material.GetMaterialbyCode(8) = False Then
                Tbx1_C1.Enabled = False
                Tbx2_C1.Enabled = False
            Else
                Lb1_C1.Text = loadcell.Name + material.WeighingStep.ToString
                Lb2_C1.Text = loadcell.Name + material.WeighingStep.ToString
                Tbx1_C1.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                Tbx2_C1.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
            End If
            If material.GetMaterialbyCode(9) = False Then
                Tbx1_C2.Enabled = False
                Tbx2_C2.Enabled = False
            Else
                Lb1_C2.Text = loadcell.Name + material.WeighingStep.ToString
                Lb2_C2.Text = loadcell.Name + material.WeighingStep.ToString
                Tbx1_C2.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                Tbx2_C2.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
            End If
            If material.GetMaterialbyCode(10) = False Then
                Tbx1_C3.Enabled = False
                Tbx2_C3.Enabled = False
            Else
                Lb1_C3.Text = loadcell.Name + material.WeighingStep.ToString
                Lb2_C3.Text = loadcell.Name + material.WeighingStep.ToString
                Tbx1_C3.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                Tbx2_C3.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
            End If
            If material.GetMaterialbyCode(11) = False Then
                Tbx1_C4.Enabled = False
                Tbx2_C4.Enabled = False
            Else
                Lb1_C4.Text = loadcell.Name + material.WeighingStep.ToString
                Lb2_C4.Text = loadcell.Name + material.WeighingStep.ToString
                Tbx1_C4.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                Tbx2_C4.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
            End If
            '--------------
            If loadcell.GetLoadCellbyCode(3) = False Then
                Panel13.Hide()
                Panel13.Enabled = False
                Panel23.Hide()
                Panel23.Enabled = False
            Else
                Lb1_A.Text = loadcell.Name
                Lb2_A.Text = loadcell.Name
                If material.GetMaterialbyCode(12) = False Then
                    Tbx1_A1.Enabled = False
                    Tbx2_A1.Enabled = False
                Else
                    Lb1_A1.Text = loadcell.Name + material.WeighingStep.ToString
                    Lb2_A1.Text = loadcell.Name + material.WeighingStep.ToString
                    Tbx1_A1.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                    Tbx2_A1.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                End If
                If material.GetMaterialbyCode(13) = False Then
                    Tbx1_A2.Enabled = False
                    Tbx2_A2.Enabled = False
                Else
                    Lb1_A2.Text = loadcell.Name + material.WeighingStep.ToString
                    Lb2_A2.Text = loadcell.Name + material.WeighingStep.ToString
                    Tbx1_A2.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                    Tbx2_A2.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                End If
                If material.GetMaterialbyCode(14) = False Then
                    Tbx1_A3.Enabled = False
                    Tbx2_A3.Enabled = False
                Else
                    Lb1_A3.Text = loadcell.Name + material.WeighingStep.ToString
                    Lb2_A3.Text = loadcell.Name + material.WeighingStep.ToString
                    Tbx1_A3.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                    Tbx2_A3.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                End If
                If material.GetMaterialbyCode(15) = False Then
                    Tbx1_A4.Enabled = False
                    Tbx2_A4.Enabled = False
                Else
                    Lb1_A4.Text = loadcell.Name + material.WeighingStep.ToString
                    Lb2_A4.Text = loadcell.Name + material.WeighingStep.ToString
                    Tbx1_A4.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                    Tbx2_A4.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                End If
            End If
            '--------------
            If loadcell.GetLoadCellbyCode(4) = False Then
                Panel14.Hide()
                Panel14.Enabled = False
                Panel24.Hide()
                Panel24.Enabled = False
            Else
                Lb1_W.Text = loadcell.Name
                Lb2_W.Text = loadcell.Name
                If material.GetMaterialbyCode(16) = False Then
                    Tbx1_W1.Enabled = False
                    Tbx2_W1.Enabled = False
                Else
                    Lb1_W1.Text = loadcell.Name + material.WeighingStep.ToString
                    Lb2_W1.Text = loadcell.Name + material.WeighingStep.ToString
                    Tbx1_W1.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                    Tbx2_W1.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                End If
                If material.GetMaterialbyCode(17) = False Then
                    Tbx1_W2.Enabled = False
                    Tbx2_W2.Enabled = False
                Else
                    Lb1_W2.Text = loadcell.Name + material.WeighingStep.ToString
                    Lb2_W2.Text = loadcell.Name + material.WeighingStep.ToString
                    Tbx1_W2.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                    Tbx2_W2.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                End If
                If material.GetMaterialbyCode(18) = False Then
                    Tbx1_W3.Enabled = False
                    Tbx2_W3.Enabled = False
                Else
                    Lb1_W3.Text = loadcell.Name + material.WeighingStep.ToString
                    Lb2_W3.Text = loadcell.Name + material.WeighingStep.ToString
                    Tbx1_W3.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                    Tbx2_W3.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                End If
                If material.GetMaterialbyCode(19) = False Then
                    Tbx1_W4.Enabled = False
                    Tbx2_W4.Enabled = False
                Else
                    Lb1_W4.Text = loadcell.Name + material.WeighingStep.ToString
                    Lb2_W4.Text = loadcell.Name + material.WeighingStep.ToString
                    Tbx1_W4.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                    Tbx2_W4.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                End If
            End If
            '--------------
            If loadcell.GetLoadCellbyCode(5) = False Then
                Panel15.Hide()
                Panel15.Enabled = False
                Panel25.Hide()
                Panel25.Enabled = False
            Else
                Lb1_U.Text = loadcell.Name
                Lb2_U.Text = loadcell.Name
                If material.GetMaterialbyCode(20) = False Then
                    Tbx1_U1.Enabled = False
                    Tbx2_U1.Enabled = False
                Else
                    Lb1_U1.Text = loadcell.Name + material.WeighingStep.ToString
                    Lb2_U1.Text = loadcell.Name + material.WeighingStep.ToString
                    Tbx1_U1.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                    Tbx2_U1.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                End If
                If material.GetMaterialbyCode(21) = False Then
                    Tbx1_U2.Enabled = False
                    Tbx2_U2.Enabled = False
                Else
                    Lb1_U2.Text = loadcell.Name + material.WeighingStep.ToString
                    Lb2_U2.Text = loadcell.Name + material.WeighingStep.ToString
                    Tbx1_U2.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                    Tbx2_U2.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                End If
                If material.GetMaterialbyCode(22) = False Then
                    Tbx1_U3.Enabled = False
                    Tbx2_U3.Enabled = False
                Else
                    Lb1_U3.Text = loadcell.Name + material.WeighingStep.ToString
                    Lb2_U3.Text = loadcell.Name + material.WeighingStep.ToString
                    Tbx1_U3.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                    Tbx2_U3.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                End If
                If material.GetMaterialbyCode(23) = False Then
                    Tbx1_U4.Enabled = False
                    Tbx2_U4.Enabled = False
                Else
                    Lb1_U4.Text = loadcell.Name + material.WeighingStep.ToString
                    Lb2_U4.Text = loadcell.Name + material.WeighingStep.ToString
                    Tbx1_U4.Text = IntToStr(vol1_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                    Tbx2_U4.Text = IntToStr(vol2_ * combine.GetValue(material.Code) / 10, loadcell.DecPoint)
                End If
            End If
        End If
        '===============================================================
    End Sub
    Public Sub New(ByVal order_ As Order, ByVal i As Integer)
        order = order_
        no_order = i
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub bt_ok_Click(sender As Object, e As EventArgs) Handles bt_ok.Click
        Me.Close()
    End Sub
    Private Function split_(ByVal vol As Integer) As Boolean
        If vol Mod __MixerVolume = 0 Then
            no1_ = vol \ __MixerVolume
            no2_ = 0
            vol1_ = __MixerVolume
            vol2_ = 0
            Return True
        End If
        If vol <= __MixerVolume Then
            If vol < __MixerStep Then
                Return False
            Else
                no1_ = 1
                no2_ = 0
                vol1_ = vol
                vol2_ = 0
                Return True
            End If
        End If
        Dim total_no As Integer = vol \ __MixerVolume + 1
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        For i = 1 To total_no - 1
            For j = __MixerStep To __MixerVolume
                For k = j To __MixerVolume
                    If i * j + k * (total_no - i) = vol Then
                        no2_ = i
                        vol2_ = j
                        vol1_ = k
                        no1_ = total_no - no2_
                        Return True
                    End If
                Next
            Next
        Next
        vol1_ = 0
        vol2_ = 0
        no2_ = 0
        no1_ = 0
        Return False
    End Function
End Class