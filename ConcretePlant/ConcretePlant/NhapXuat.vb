Imports System.Globalization
Imports ConcretePlant.Setting
Public Class NhapXuat
    Private Sub NhapXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBounds((Screen.GetWorkingArea(Me).Width - Width) / 2, (Screen.GetWorkingArea(Me).Height - Height) / 2, Width, Height)
        Show_()

        My.Resources.Resource.Culture = New CultureInfo(__Language)
        Text = My.Resources.Resource.MIXING
        Label8.Text = My.Resources.Resource.MIX_TIME1
        Label9.Text = My.Resources.Resource.MIX_TIME2
        Label10.Text = My.Resources.Resource.MIX_TIME3
        Label11.Text = My.Resources.Resource.MIX_TIME4
        Label12.Text = My.Resources.Resource.MIX_TIME5
        Label13.Text = My.Resources.Resource.MIX_TIME6
        Label14.Text = My.Resources.Resource.MIX_TIME7
        Label15.Text = My.Resources.Resource.MIX_TIME8
        Label16.Text = My.Resources.Resource.MIX_TIME9
        Label17.Text = My.Resources.Resource.MIX_TIME10
        Label18.Text = My.Resources.Resource.EMS
        Label19.Text = My.Resources.Resource.GaClsTi
        GroupBox1.Text = My.Resources.Resource.FLUSHTIME
        GroupBox2.Text = My.Resources.Resource.MIXTIME
        save.Text = My.Resources.Resource.SAVE
        Label20.Text = My.Resources.Resource.MIXTYPE1
        Label21.Text = My.Resources.Resource.MIXTYPE2
        Label22.Text = My.Resources.Resource.MIXTYPE3
        Label23.Text = My.Resources.Resource.MIXTYPE4
        Label24.Text = My.Resources.Resource.MIXTYPE5
        Label25.Text = My.Resources.Resource.MIXTYPE6
        Label26.Text = My.Resources.Resource.MIXTYPE7
        label27.Text = My.Resources.Resource.MIXTYPE8
        Label28.Text = My.Resources.Resource.MIXTYPE9
        Label29.Text = My.Resources.Resource.MIXTYPE10
        Label30.Text = My.Resources.Resource.MGateOT
        Label31.Text = My.Resources.Resource.MEmptyT
        Label32.Text = My.Resources.Resource.MCheckT
        Label33.Text = My.Resources.Resource.HopCT
    End Sub
    Public Sub Show_()
        Dim loadcell As LoadCell_Tbl = New LoadCell_Tbl
        Dim emission As Emission_Tbl = New Emission_Tbl
        Dim mixing As Mixing_Tbl = New Mixing_Tbl
        If loadcell.GetLoadCellbyCode(0) Then
            Label1.Text = loadcell.Name
            emission.GetEmissionbyCode(0)
            tbx_1_1.Text = IntToStr(emission.MixingType1)
            tbx_1_2.Text = IntToStr(emission.MixingType2)
            tbx_1_3.Text = IntToStr(emission.MixingType3)
            tbx_1_4.Text = IntToStr(emission.MixingType4)
            tbx_1_5.Text = IntToStr(emission.MixingType5)
            tbx_1_6.Text = IntToStr(emission.MixingType6)
            tbx_1_7.Text = IntToStr(emission.MixingType7)
            tbx_1_8.Text = IntToStr(emission.MixingType8)
            tbx_1_9.Text = IntToStr(emission.MixingType9)
            tbx_1_A.Text = IntToStr(emission.MixingType10)
            tbx_1_B.Text = IntToStr(emission.Ems_cpt_range, 1)
            tbx_1_C.Text = IntToStr(emission.GateCloseTime)
        Else
            tbx_1_1.Enabled = False
            tbx_1_2.Enabled = False
            tbx_1_3.Enabled = False
            tbx_1_4.Enabled = False
            tbx_1_5.Enabled = False
            tbx_1_6.Enabled = False
            tbx_1_7.Enabled = False
            tbx_1_8.Enabled = False
            tbx_1_9.Enabled = False
            tbx_1_A.Enabled = False
            tbx_1_B.Enabled = False
            tbx_1_C.Enabled = False
        End If
        If loadcell.GetLoadCellbyCode(1) Then
            Label2.Text = loadcell.Name
            emission.GetEmissionbyCode(1)
            tbx_2_1.Text = IntToStr(emission.MixingType1)
            tbx_2_2.Text = IntToStr(emission.MixingType2)
            tbx_2_3.Text = IntToStr(emission.MixingType3)
            tbx_2_4.Text = IntToStr(emission.MixingType4)
            tbx_2_5.Text = IntToStr(emission.MixingType5)
            tbx_2_6.Text = IntToStr(emission.MixingType6)
            tbx_2_7.Text = IntToStr(emission.MixingType7)
            tbx_2_8.Text = IntToStr(emission.MixingType8)
            tbx_2_9.Text = IntToStr(emission.MixingType9)
            tbx_2_A.Text = IntToStr(emission.MixingType10)
            tbx_2_B.Text = IntToStr(emission.Ems_cpt_range, 1)
            tbx_2_C.Text = IntToStr(emission.GateCloseTime)
        Else
            tbx_2_1.Enabled = False
            tbx_2_2.Enabled = False
            tbx_2_3.Enabled = False
            tbx_2_4.Enabled = False
            tbx_2_5.Enabled = False
            tbx_2_6.Enabled = False
            tbx_2_7.Enabled = False
            tbx_2_8.Enabled = False
            tbx_2_9.Enabled = False
            tbx_2_A.Enabled = False
            tbx_2_B.Enabled = False
            tbx_2_C.Enabled = False
        End If
        If loadcell.GetLoadCellbyCode(2) Then
            Label3.Text = loadcell.Name
            emission.GetEmissionbyCode(2)
            tbx_3_1.Text = IntToStr(emission.MixingType1)
            tbx_3_2.Text = IntToStr(emission.MixingType2)
            tbx_3_3.Text = IntToStr(emission.MixingType3)
            tbx_3_4.Text = IntToStr(emission.MixingType4)
            tbx_3_5.Text = IntToStr(emission.MixingType5)
            tbx_3_6.Text = IntToStr(emission.MixingType6)
            tbx_3_7.Text = IntToStr(emission.MixingType7)
            tbx_3_8.Text = IntToStr(emission.MixingType8)
            tbx_3_9.Text = IntToStr(emission.MixingType9)
            tbx_3_A.Text = IntToStr(emission.MixingType10)
            tbx_3_B.Text = IntToStr(emission.Ems_cpt_range, 1)
            tbx_3_C.Text = IntToStr(emission.GateCloseTime)
        Else
            tbx_3_1.Enabled = False
            tbx_3_2.Enabled = False
            tbx_3_3.Enabled = False
            tbx_3_4.Enabled = False
            tbx_3_5.Enabled = False
            tbx_3_6.Enabled = False
            tbx_3_7.Enabled = False
            tbx_3_8.Enabled = False
            tbx_3_9.Enabled = False
            tbx_3_A.Enabled = False
            tbx_3_B.Enabled = False
            tbx_3_C.Enabled = False
        End If
        If loadcell.GetLoadCellbyCode(3) Then
            Label4.Text = loadcell.Name
            emission.GetEmissionbyCode(3)
            tbx_4_1.Text = IntToStr(emission.MixingType1)
            tbx_4_2.Text = IntToStr(emission.MixingType2)
            tbx_4_3.Text = IntToStr(emission.MixingType3)
            tbx_4_4.Text = IntToStr(emission.MixingType4)
            tbx_4_5.Text = IntToStr(emission.MixingType5)
            tbx_4_6.Text = IntToStr(emission.MixingType6)
            tbx_4_7.Text = IntToStr(emission.MixingType7)
            tbx_4_8.Text = IntToStr(emission.MixingType8)
            tbx_4_9.Text = IntToStr(emission.MixingType9)
            tbx_4_A.Text = IntToStr(emission.MixingType10)
            tbx_4_B.Text = IntToStr(emission.Ems_cpt_range, 1)
            tbx_4_C.Text = IntToStr(emission.GateCloseTime)
        Else
            tbx_4_1.Enabled = False
            tbx_4_2.Enabled = False
            tbx_4_3.Enabled = False
            tbx_4_4.Enabled = False
            tbx_4_5.Enabled = False
            tbx_4_6.Enabled = False
            tbx_4_7.Enabled = False
            tbx_4_8.Enabled = False
            tbx_4_9.Enabled = False
            tbx_4_A.Enabled = False
            tbx_4_B.Enabled = False
            tbx_4_C.Enabled = False
        End If
        If loadcell.GetLoadCellbyCode(4) Then
            Label5.Text = loadcell.Name
            emission.GetEmissionbyCode(4)
            tbx_5_1.Text = IntToStr(emission.MixingType1)
            tbx_5_2.Text = IntToStr(emission.MixingType2)
            tbx_5_3.Text = IntToStr(emission.MixingType3)
            tbx_5_4.Text = IntToStr(emission.MixingType4)
            tbx_5_5.Text = IntToStr(emission.MixingType5)
            tbx_5_6.Text = IntToStr(emission.MixingType6)
            tbx_5_7.Text = IntToStr(emission.MixingType7)
            tbx_5_8.Text = IntToStr(emission.MixingType8)
            tbx_5_9.Text = IntToStr(emission.MixingType9)
            tbx_5_A.Text = IntToStr(emission.MixingType10)
            tbx_5_B.Text = IntToStr(emission.Ems_cpt_range, 1)
            tbx_5_C.Text = IntToStr(emission.GateCloseTime)
        Else
            tbx_5_1.Enabled = False
            tbx_5_2.Enabled = False
            tbx_5_3.Enabled = False
            tbx_5_4.Enabled = False
            tbx_5_5.Enabled = False
            tbx_5_6.Enabled = False
            tbx_5_7.Enabled = False
            tbx_5_8.Enabled = False
            tbx_5_9.Enabled = False
            tbx_5_A.Enabled = False
            tbx_5_B.Enabled = False
            tbx_5_C.Enabled = False
        End If
        If loadcell.GetLoadCellbyCode(5) Then
            Label6.Text = loadcell.Name
            emission.GetEmissionbyCode(5)
            tbx_6_1.Text = IntToStr(emission.MixingType1)
            tbx_6_2.Text = IntToStr(emission.MixingType2)
            tbx_6_3.Text = IntToStr(emission.MixingType3)
            tbx_6_4.Text = IntToStr(emission.MixingType4)
            tbx_6_5.Text = IntToStr(emission.MixingType5)
            tbx_6_6.Text = IntToStr(emission.MixingType6)
            tbx_6_7.Text = IntToStr(emission.MixingType7)
            tbx_6_8.Text = IntToStr(emission.MixingType8)
            tbx_6_9.Text = IntToStr(emission.MixingType9)
            tbx_6_A.Text = IntToStr(emission.MixingType10)
            tbx_6_B.Text = IntToStr(emission.Ems_cpt_range, 1)
            tbx_6_C.Text = IntToStr(emission.GateCloseTime)
        Else
            tbx_6_1.Enabled = False
            tbx_6_2.Enabled = False
            tbx_6_3.Enabled = False
            tbx_6_4.Enabled = False
            tbx_6_5.Enabled = False
            tbx_6_6.Enabled = False
            tbx_6_7.Enabled = False
            tbx_6_8.Enabled = False
            tbx_6_9.Enabled = False
            tbx_6_A.Enabled = False
            tbx_6_B.Enabled = False
            tbx_6_C.Enabled = False
        End If
        If mixing.GetMixingbyCode(0) Then
            tbx_mt_1.Text = IntToStr(mixing.MixingType1)
            tbx_mt_2.Text = IntToStr(mixing.MixingType2)
            tbx_mt_3.Text = IntToStr(mixing.MixingType3)
            tbx_mt_4.Text = IntToStr(mixing.MixingType4)
            tbx_mt_5.Text = IntToStr(mixing.MixingType5)
            tbx_mt_6.Text = IntToStr(mixing.MixingType6)
            tbx_mt_7.Text = IntToStr(mixing.MixingType7)
            tbx_mt_8.Text = IntToStr(mixing.MixingType8)
            tbx_mt_9.Text = IntToStr(mixing.MixingType9)
            tbx_mt_A.Text = IntToStr(mixing.MixingType10)
            tbx_HopperCheckTime.Text = IntToStr(mixing.HopperCheckTime)
            tbx_MixerCheckTime.Text = IntToStr(mixing.MixerCheckTime)
            tbx_MixerEmptyTime.Text = IntToStr(mixing.MixerEmptyTime)
            tbx_MixerOpenGateTime.Text = IntToStr(mixing.MixerGateOpenTime)
        End If
    End Sub
    Public Sub save_()
        Dim emission As Emission_Tbl = New Emission_Tbl
        If emission.GetEmissionbyCode(0) Then
            Try
                emission.MixingType1 = StrToInt(Double.Parse(tbx_1_1.Text))
                emission.MixingType2 = StrToInt(Double.Parse(tbx_1_2.Text))
                emission.MixingType3 = StrToInt(Double.Parse(tbx_1_3.Text))
                emission.MixingType4 = StrToInt(Double.Parse(tbx_1_4.Text))
                emission.MixingType5 = StrToInt(Double.Parse(tbx_1_5.Text))
                emission.MixingType6 = StrToInt(Double.Parse(tbx_1_6.Text))
                emission.MixingType7 = StrToInt(Double.Parse(tbx_1_7.Text))
                emission.MixingType8 = StrToInt(Double.Parse(tbx_1_8.Text))
                emission.MixingType9 = StrToInt(Double.Parse(tbx_1_9.Text))
                emission.MixingType10 = StrToInt(Double.Parse(tbx_1_A.Text))
                emission.Ems_cpt_range = StrToInt(Double.Parse(tbx_1_B.Text))
                emission.GateCloseTime = StrToInt(Double.Parse(tbx_1_C.Text))
                emission.UpdateEmission()
            Catch ex As Exception
                MessageBox.Show("Invalid number format. line: 1")
            End Try
        End If
        If emission.GetEmissionbyCode(1) Then
            Try
                emission.MixingType1 = StrToInt(Double.Parse(tbx_2_1.Text))
                emission.MixingType2 = StrToInt(Double.Parse(tbx_2_2.Text))
                emission.MixingType3 = StrToInt(Double.Parse(tbx_2_3.Text))
                emission.MixingType4 = StrToInt(Double.Parse(tbx_2_4.Text))
                emission.MixingType5 = StrToInt(Double.Parse(tbx_2_5.Text))
                emission.MixingType6 = StrToInt(Double.Parse(tbx_2_6.Text))
                emission.MixingType7 = StrToInt(Double.Parse(tbx_2_7.Text))
                emission.MixingType8 = StrToInt(Double.Parse(tbx_2_8.Text))
                emission.MixingType9 = StrToInt(Double.Parse(tbx_2_9.Text))
                emission.MixingType10 = StrToInt(Double.Parse(tbx_2_A.Text))
                emission.Ems_cpt_range = StrToInt(Double.Parse(tbx_2_B.Text))
                emission.GateCloseTime = StrToInt(Double.Parse(tbx_2_C.Text))
                emission.UpdateEmission()
            Catch ex As Exception
                MessageBox.Show("Invalid number format. line: 2")
            End Try
        End If
        If emission.GetEmissionbyCode(2) Then
            Try
                emission.MixingType1 = StrToInt(Double.Parse(tbx_3_1.Text))
                emission.MixingType2 = StrToInt(Double.Parse(tbx_3_2.Text))
                emission.MixingType3 = StrToInt(Double.Parse(tbx_3_3.Text))
                emission.MixingType4 = StrToInt(Double.Parse(tbx_3_4.Text))
                emission.MixingType5 = StrToInt(Double.Parse(tbx_3_5.Text))
                emission.MixingType6 = StrToInt(Double.Parse(tbx_3_6.Text))
                emission.MixingType7 = StrToInt(Double.Parse(tbx_3_7.Text))
                emission.MixingType8 = StrToInt(Double.Parse(tbx_3_8.Text))
                emission.MixingType9 = StrToInt(Double.Parse(tbx_3_9.Text))
                emission.MixingType10 = StrToInt(Double.Parse(tbx_3_A.Text))
                emission.Ems_cpt_range = StrToInt(Double.Parse(tbx_3_B.Text))
                emission.GateCloseTime = StrToInt(Double.Parse(tbx_3_C.Text))
                emission.UpdateEmission()
            Catch ex As Exception
                MessageBox.Show("Invalid number format. line: 3")
            End Try
        End If
        If emission.GetEmissionbyCode(3) Then
            Try
                emission.MixingType1 = StrToInt(Double.Parse(tbx_4_1.Text))
                emission.MixingType2 = StrToInt(Double.Parse(tbx_4_2.Text))
                emission.MixingType3 = StrToInt(Double.Parse(tbx_4_3.Text))
                emission.MixingType4 = StrToInt(Double.Parse(tbx_4_4.Text))
                emission.MixingType5 = StrToInt(Double.Parse(tbx_4_5.Text))
                emission.MixingType6 = StrToInt(Double.Parse(tbx_4_6.Text))
                emission.MixingType7 = StrToInt(Double.Parse(tbx_4_7.Text))
                emission.MixingType8 = StrToInt(Double.Parse(tbx_4_8.Text))
                emission.MixingType9 = StrToInt(Double.Parse(tbx_4_9.Text))
                emission.MixingType10 = StrToInt(Double.Parse(tbx_4_A.Text))
                emission.Ems_cpt_range = StrToInt(Double.Parse(tbx_4_B.Text))
                emission.GateCloseTime = StrToInt(Double.Parse(tbx_4_C.Text))
                emission.UpdateEmission()
            Catch ex As Exception
                MessageBox.Show("Invalid number format. line: 4")
            End Try
        End If
        If emission.GetEmissionbyCode(4) Then
            Try
                emission.MixingType1 = StrToInt(Double.Parse(tbx_5_1.Text))
                emission.MixingType2 = StrToInt(Double.Parse(tbx_5_2.Text))
                emission.MixingType3 = StrToInt(Double.Parse(tbx_5_3.Text))
                emission.MixingType4 = StrToInt(Double.Parse(tbx_5_4.Text))
                emission.MixingType5 = StrToInt(Double.Parse(tbx_5_5.Text))
                emission.MixingType6 = StrToInt(Double.Parse(tbx_5_6.Text))
                emission.MixingType7 = StrToInt(Double.Parse(tbx_5_7.Text))
                emission.MixingType8 = StrToInt(Double.Parse(tbx_5_8.Text))
                emission.MixingType9 = StrToInt(Double.Parse(tbx_5_9.Text))
                emission.MixingType10 = StrToInt(Double.Parse(tbx_5_A.Text))
                emission.Ems_cpt_range = StrToInt(Double.Parse(tbx_5_B.Text))
                emission.GateCloseTime = StrToInt(Double.Parse(tbx_5_C.Text))
                emission.UpdateEmission()
            Catch ex As Exception
                MessageBox.Show("Invalid number format. line: 5")
            End Try
        End If
        If emission.GetEmissionbyCode(5) Then
            Try
                emission.MixingType1 = StrToInt(Double.Parse(tbx_6_1.Text))
                emission.MixingType2 = StrToInt(Double.Parse(tbx_6_2.Text))
                emission.MixingType3 = StrToInt(Double.Parse(tbx_6_3.Text))
                emission.MixingType4 = StrToInt(Double.Parse(tbx_6_4.Text))
                emission.MixingType5 = StrToInt(Double.Parse(tbx_6_5.Text))
                emission.MixingType6 = StrToInt(Double.Parse(tbx_6_6.Text))
                emission.MixingType7 = StrToInt(Double.Parse(tbx_6_7.Text))
                emission.MixingType8 = StrToInt(Double.Parse(tbx_6_8.Text))
                emission.MixingType9 = StrToInt(Double.Parse(tbx_6_9.Text))
                emission.MixingType10 = StrToInt(Double.Parse(tbx_6_A.Text))
                emission.Ems_cpt_range = StrToInt(Double.Parse(tbx_6_B.Text))
                emission.GateCloseTime = StrToInt(Double.Parse(tbx_6_C.Text))
                emission.UpdateEmission()
            Catch ex As Exception
                MessageBox.Show("Invalid number format. line: 6")
            End Try
        End If
        Dim mixing As Mixing_Tbl = New Mixing_Tbl
        If mixing.GetMixingbyCode(0) Then
            Try
                mixing.MixingType1 = StrToInt(Double.Parse(tbx_mt_1.Text))
                mixing.MixingType2 = StrToInt(Double.Parse(tbx_mt_2.Text))
                mixing.MixingType3 = StrToInt(Double.Parse(tbx_mt_3.Text))
                mixing.MixingType4 = StrToInt(Double.Parse(tbx_mt_4.Text))
                mixing.MixingType5 = StrToInt(Double.Parse(tbx_mt_5.Text))
                mixing.MixingType6 = StrToInt(Double.Parse(tbx_mt_6.Text))
                mixing.MixingType7 = StrToInt(Double.Parse(tbx_mt_7.Text))
                mixing.MixingType8 = StrToInt(Double.Parse(tbx_mt_8.Text))
                mixing.MixingType9 = StrToInt(Double.Parse(tbx_mt_9.Text))
                mixing.MixingType10 = StrToInt(Double.Parse(tbx_mt_A.Text))
                mixing.MixerGateOpenTime = StrToInt(Double.Parse(tbx_MixerOpenGateTime.Text))
                mixing.MixerEmptyTime = StrToInt(Double.Parse(tbx_MixerEmptyTime.Text))
                mixing.MixerCheckTime = StrToInt(Double.Parse(tbx_MixerCheckTime.Text))
                mixing.HopperCheckTime = StrToInt(Double.Parse(tbx_HopperCheckTime.Text))
                mixing.UpdateMixing()
            Catch ex As Exception
                MessageBox.Show("Invalid number format. mixingtime")
            End Try
        End If
    End Sub
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        save_()
        Show_()
    End Sub
    Private Sub tbx_1_1_KeyDown(sender As Object, e As KeyEventArgs) Handles tbx_1_1.KeyDown, tbx_1_2.KeyDown, tbx_1_3.KeyDown, tbx_1_4.KeyDown, tbx_1_5.KeyDown, tbx_1_6.KeyDown, tbx_1_7.KeyDown, tbx_1_8.KeyDown, tbx_1_9.KeyDown, tbx_1_A.KeyDown, tbx_1_B.KeyDown, tbx_1_C.KeyDown, tbx_2_1.KeyDown, tbx_2_2.KeyDown, tbx_2_3.KeyDown, tbx_2_4.KeyDown, tbx_2_5.KeyDown, tbx_2_6.KeyDown, tbx_2_7.KeyDown, tbx_2_8.KeyDown, tbx_2_9.KeyDown, tbx_2_A.KeyDown, tbx_2_B.KeyDown, tbx_2_C.KeyDown, tbx_3_1.KeyDown, tbx_3_2.KeyDown, tbx_3_3.KeyDown, tbx_3_4.KeyDown, tbx_3_5.KeyDown, tbx_3_6.KeyDown, tbx_3_7.KeyDown, tbx_3_8.KeyDown, tbx_3_9.KeyDown, tbx_3_A.KeyDown, tbx_3_B.KeyDown, tbx_3_C.KeyDown, tbx_4_1.KeyDown, tbx_4_2.KeyDown, tbx_4_3.KeyDown, tbx_4_4.KeyDown, tbx_4_5.KeyDown, tbx_4_6.KeyDown, tbx_4_7.KeyDown, tbx_4_8.KeyDown, tbx_4_9.KeyDown, tbx_4_A.KeyDown, tbx_4_B.KeyDown, tbx_4_C.KeyDown, tbx_5_1.KeyDown, tbx_5_2.KeyDown, tbx_5_3.KeyDown, tbx_5_4.KeyDown, tbx_5_5.KeyDown, tbx_5_6.KeyDown, tbx_5_7.KeyDown, tbx_5_8.KeyDown, tbx_5_9.KeyDown, tbx_5_A.KeyDown, tbx_5_B.KeyDown, tbx_5_C.KeyDown, tbx_6_1.KeyDown, tbx_6_2.KeyDown, tbx_6_3.KeyDown, tbx_6_4.KeyDown, tbx_6_5.KeyDown, tbx_6_6.KeyDown, tbx_6_7.KeyDown, tbx_6_8.KeyDown, tbx_6_9.KeyDown, tbx_6_A.KeyDown, tbx_6_B.KeyDown, tbx_6_C.KeyDown, tbx_mt_A.KeyDown, tbx_mt_9.KeyDown, tbx_mt_8.KeyDown, tbx_mt_7.KeyDown, tbx_mt_6.KeyDown, tbx_mt_5.KeyDown, tbx_mt_4.KeyDown, tbx_mt_3.KeyDown, tbx_mt_2.KeyDown, tbx_mt_1.KeyDown, tbx_MixerOpenGateTime.KeyDown, tbx_MixerEmptyTime.KeyDown, tbx_MixerCheckTime.KeyDown, tbx_HopperCheckTime.KeyDown
        If e.KeyCode = Keys.Enter Then
            save_()
            Show_()
        End If
    End Sub
    Private Sub tbx_1_1_Leave(sender As Object, e As EventArgs) Handles tbx_1_1.Leave, tbx_1_2.Leave, tbx_1_3.Leave, tbx_1_4.Leave, tbx_1_5.Leave, tbx_1_6.Leave, tbx_1_7.Leave, tbx_1_8.Leave, tbx_1_9.Leave, tbx_1_A.Leave, tbx_1_B.Leave, tbx_1_C.Leave, tbx_2_1.Leave, tbx_2_2.Leave, tbx_2_3.Leave, tbx_2_4.Leave, tbx_2_5.Leave, tbx_2_6.Leave, tbx_2_7.Leave, tbx_2_8.Leave, tbx_2_9.Leave, tbx_2_A.Leave, tbx_2_B.Leave, tbx_2_C.Leave, tbx_3_1.Leave, tbx_3_2.Leave, tbx_3_3.Leave, tbx_3_4.Leave, tbx_3_5.Leave, tbx_3_6.Leave, tbx_3_7.Leave, tbx_3_8.Leave, tbx_3_9.Leave, tbx_3_A.Leave, tbx_3_B.Leave, tbx_3_C.Leave, tbx_4_1.Leave, tbx_4_2.Leave, tbx_4_3.Leave, tbx_4_4.Leave, tbx_4_5.Leave, tbx_4_6.Leave, tbx_4_7.Leave, tbx_4_8.Leave, tbx_4_9.Leave, tbx_4_A.Leave, tbx_4_B.Leave, tbx_4_C.Leave, tbx_5_1.Leave, tbx_5_2.Leave, tbx_5_3.Leave, tbx_5_4.Leave, tbx_5_5.Leave, tbx_5_6.Leave, tbx_5_7.Leave, tbx_5_8.Leave, tbx_5_9.Leave, tbx_5_A.Leave, tbx_5_B.Leave, tbx_5_C.Leave, tbx_6_1.Leave, tbx_6_2.Leave, tbx_6_3.Leave, tbx_6_4.Leave, tbx_6_5.Leave, tbx_6_6.Leave, tbx_6_7.Leave, tbx_6_8.Leave, tbx_6_9.Leave, tbx_6_A.Leave, tbx_6_B.Leave, tbx_6_C.Leave, tbx_mt_A.Leave, tbx_mt_9.Leave, tbx_mt_8.Leave, tbx_mt_7.Leave, tbx_mt_6.Leave, tbx_mt_5.Leave, tbx_mt_4.Leave, tbx_mt_3.Leave, tbx_mt_2.Leave, tbx_mt_1.Leave, tbx_MixerOpenGateTime.Leave, tbx_MixerEmptyTime.Leave, tbx_MixerCheckTime.Leave, tbx_HopperCheckTime.Leave
        save_()
        Show_()
    End Sub
End Class