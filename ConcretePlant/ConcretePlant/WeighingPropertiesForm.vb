Imports System.Globalization
Imports ConcretePlant.Setting
Public Class WeighingPropertiesForm
    Private Sub WeighingPropertiesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBounds((Screen.GetWorkingArea(Me).Width - Width) / 2, 0, Width, 730)
        ' =============
        ' SHOW CAC PANEL, LABEL, TEXBOX -----------------
        Show_()

        My.Resources.Resource.Culture = New CultureInfo(__Language)
        Text = My.Resources.Resource.WEI_PRO
        Label36.Text = My.Resources.Resource.LB136WEI
        Label31.Text = My.Resources.Resource.FINE_WEI
        Label32.Text = My.Resources.Resource.JOGON
        Label33.Text = My.Resources.Resource.JOGOFF
        Label34.Text = My.Resources.Resource.ComTIME
        Label35.Text = My.Resources.Resource.ComRANG
        btn_Save.Text = My.Resources.Resource.SAVE
        'If __Language Then
        '    Me.Text = "WEIGHING PROPERTIES"
        '    Label36.Text = ""
        '    Label31.Text = "FINE WEIGHING"
        '    Label32.Text = "JOG ON"
        '    Label33.Text = "JOG OFF"
        '    Label34.Text = "COMPLETION TIME"
        '    Label35.Text = "COMPLETION RANGE"
        '    btn_Save.Text = "SAVE"
        'Else
        '    Me.Text = "CHẾ ĐỘ CÂN"
        '    Label36.Text = "CÂN TÍNH"
        '    Label31.Text = "KHỐI LƯỢNG"
        '    Label32.Text = "JOG ON"
        '    Label33.Text = "JOG OFF"
        '    Label34.Text = "THỜI GIAN GIÁM SÁT"
        '    Label35.Text = "SAI SỐ CHO PHÉP"
        '    btn_Save.Text = "LƯU"
        'End If
    End Sub
    Public Sub Show_()
        Dim loadcell As LoadCell_Tbl = New LoadCell_Tbl
        Dim material As Material_Tbl = New Material_Tbl
        If loadcell.GetLoadCellbyCode(0) = False Then
            Panel_G.Hide()
            Panel_G.Enabled = False
            panel_GG.Hide()
            panel_GG.Enabled = False
        Else
            Label_G.Text = loadcell.Name
            If material.GetMaterialbyCode(0) Then
                Label_G1.Text = Label_G.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_G1_2.Enabled = False
                    tbx_G1_3.Enabled = False
                Else
                    tbx_G1_2.Text = material.JoggingON.ToString
                    tbx_G1_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_G1_4.Enabled = False
                Else
                    tbx_G1_4.Text = material.CompletionTime.ToString
                End If
                tbx_G1_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_G1_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                Label_G1.Text = ""
                tbx_G1_1.Enabled = False
                tbx_G1_2.Enabled = False
                tbx_G1_3.Enabled = False
                tbx_G1_4.Enabled = False
                tbx_G1_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(1) Then
                Label_G2.Text = Label_G.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_G2_2.Enabled = False
                    tbx_G2_3.Enabled = False
                Else
                    tbx_G2_2.Text = material.JoggingON.ToString
                    tbx_G2_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_G2_4.Enabled = False
                Else
                    tbx_G2_4.Text = material.CompletionTime.ToString
                End If
                tbx_G2_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_G2_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                Label_G2.Text = ""
                tbx_G2_1.Enabled = False
                tbx_G2_2.Enabled = False
                tbx_G2_3.Enabled = False
                tbx_G2_4.Enabled = False
                tbx_G2_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(2) Then
                Label_G3.Text = Label_G.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_G3_2.Enabled = False
                    tbx_G3_3.Enabled = False
                Else
                    tbx_G3_2.Text = material.JoggingON.ToString
                    tbx_G3_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_G3_4.Enabled = False
                Else
                    tbx_G3_4.Text = material.CompletionTime.ToString
                End If
                tbx_G3_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_G3_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                Label_G3.Text = ""
                tbx_G3_1.Enabled = False
                tbx_G3_2.Enabled = False
                tbx_G3_3.Enabled = False
                tbx_G3_4.Enabled = False
                tbx_G3_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(3) Then
                Label_G4.Text = Label_G.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_G4_2.Enabled = False
                    tbx_G4_3.Enabled = False
                Else
                    tbx_G4_2.Text = material.JoggingON.ToString
                    tbx_G4_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_G4_4.Enabled = False
                Else
                    tbx_G4_4.Text = material.CompletionTime.ToString
                End If
                tbx_G4_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_G4_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                Label_G4.Text = ""
                tbx_G4_1.Enabled = False
                tbx_G4_2.Enabled = False
                tbx_G4_3.Enabled = False
                tbx_G4_4.Enabled = False
                tbx_G4_5.Enabled = False
            End If
            ' --------
            '---------------------------
        End If
        ' ----------------------------------
        If loadcell.GetLoadCellbyCode(1) = False Then
            Panel_S.Hide()
            Panel_S.Enabled = False
            Panel_SS.Hide()
            Panel_SS.Enabled = False
        Else
            Label_S.Text = loadcell.Name
            If material.GetMaterialbyCode(4) Then
                Label_S1.Text = Label_S.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_S1_2.Enabled = False
                    tbx_S1_3.Enabled = False
                Else
                    tbx_S1_2.Text = material.JoggingON.ToString
                    tbx_S1_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_S1_4.Enabled = False
                Else
                    tbx_S1_4.Text = material.CompletionTime.ToString
                End If
                tbx_S1_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_S1_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_S1_1.Enabled = False
                tbx_S1_2.Enabled = False
                tbx_S1_3.Enabled = False
                tbx_S1_4.Enabled = False
                tbx_S1_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(5) Then
                Label_S2.Text = Label_S.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_S2_2.Enabled = False
                    tbx_S2_3.Enabled = False
                Else
                    tbx_S2_2.Text = material.JoggingON.ToString
                    tbx_S2_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_S2_4.Enabled = False
                Else
                    tbx_S2_4.Text = material.CompletionTime.ToString
                End If
                tbx_S2_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_S2_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_S2_1.Enabled = False
                tbx_S2_2.Enabled = False
                tbx_S2_3.Enabled = False
                tbx_S2_4.Enabled = False
                tbx_S2_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(6) Then
                Label_S3.Text = Label_S.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_S3_2.Enabled = False
                    tbx_S3_3.Enabled = False
                Else
                    tbx_S3_2.Text = material.JoggingON.ToString
                    tbx_S3_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_S3_4.Enabled = False
                Else
                    tbx_S3_4.Text = material.CompletionTime.ToString
                End If
                tbx_S3_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_S3_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_S3_1.Enabled = False
                tbx_S3_2.Enabled = False
                tbx_S3_3.Enabled = False
                tbx_S3_4.Enabled = False
                tbx_S3_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(7) Then
                Label_S4.Text = Label_S.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_S4_2.Enabled = False
                    tbx_S4_3.Enabled = False
                Else
                    tbx_S4_2.Text = material.JoggingON.ToString
                    tbx_S4_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_S4_4.Enabled = False
                Else
                    tbx_S4_4.Text = material.CompletionTime.ToString
                End If
                tbx_S4_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_S4_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_S4_1.Enabled = False
                tbx_S4_2.Enabled = False
                tbx_S4_3.Enabled = False
                tbx_S4_4.Enabled = False
                tbx_S4_5.Enabled = False
            End If
            ' --------
            '---------------------------
        End If
        ' ----------------------------------
        If loadcell.GetLoadCellbyCode(2) = False Then
            Panel_C.Hide()
            Panel_C.Enabled = False
            Panel_CC.Hide()
            Panel_CC.Enabled = False
        Else
            Label_C.Text = loadcell.Name
            If material.GetMaterialbyCode(8) Then
                Label_C1.Text = Label_C.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_C1_2.Enabled = False
                    tbx_C1_3.Enabled = False
                Else
                    tbx_C1_2.Text = material.JoggingON.ToString
                    tbx_C1_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_C1_4.Enabled = False
                Else
                    tbx_C1_4.Text = material.CompletionTime.ToString
                End If
                tbx_C1_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_C1_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_C1_1.Enabled = False
                tbx_C1_2.Enabled = False
                tbx_C1_3.Enabled = False
                tbx_C1_4.Enabled = False
                tbx_C1_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(9) Then
                Label_C2.Text = Label_C.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_C2_2.Enabled = False
                    tbx_C2_3.Enabled = False
                Else
                    tbx_C2_2.Text = material.JoggingON.ToString
                    tbx_C2_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_C2_4.Enabled = False
                Else
                    tbx_C2_4.Text = material.CompletionTime.ToString
                End If
                tbx_C2_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_C2_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_C2_1.Enabled = False
                tbx_C2_2.Enabled = False
                tbx_C2_3.Enabled = False
                tbx_C2_4.Enabled = False
                tbx_C2_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(10) Then
                Label_C3.Text = Label_C.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_C3_2.Enabled = False
                    tbx_C3_3.Enabled = False
                Else
                    tbx_C3_2.Text = material.JoggingON.ToString
                    tbx_C3_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_C3_4.Enabled = False
                Else
                    tbx_C3_4.Text = material.CompletionTime.ToString
                End If
                tbx_C3_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_C3_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_C3_1.Enabled = False
                tbx_C3_2.Enabled = False
                tbx_C3_3.Enabled = False
                tbx_C3_4.Enabled = False
                tbx_C3_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(11) Then
                Label_C4.Text = Label_C.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_C4_2.Enabled = False
                    tbx_C4_3.Enabled = False
                Else
                    tbx_C4_2.Text = material.JoggingON.ToString
                    tbx_C4_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_C4_4.Enabled = False
                Else
                    tbx_C4_4.Text = material.CompletionTime.ToString
                End If
                tbx_C4_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_C4_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_C4_1.Enabled = False
                tbx_C4_2.Enabled = False
                tbx_C4_3.Enabled = False
                tbx_C4_4.Enabled = False
                tbx_C4_5.Enabled = False
            End If
            ' --------
            '---------------------------
        End If
        ' ----------------------------------
        If loadcell.GetLoadCellbyCode(3) = False Then
            Panel_A.Hide()
            Panel_A.Enabled = False
            Panel_AA.Hide()
            Panel_AA.Enabled = False
        Else
            Label_A.Text = loadcell.Name
            If material.GetMaterialbyCode(12) Then
                Label_A1.Text = Label_A.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_A1_2.Enabled = False
                    tbx_A1_3.Enabled = False
                Else
                    tbx_A1_2.Text = material.JoggingON.ToString
                    tbx_A1_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_A1_4.Enabled = False
                Else
                    tbx_A1_4.Text = material.CompletionTime.ToString
                End If
                tbx_A1_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_A1_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_A1_1.Enabled = False
                tbx_A1_2.Enabled = False
                tbx_A1_3.Enabled = False
                tbx_A1_4.Enabled = False
                tbx_A1_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(13) Then
                Label_A2.Text = Label_A.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_A2_2.Enabled = False
                    tbx_A2_3.Enabled = False
                Else
                    tbx_A2_2.Text = material.JoggingON.ToString
                    tbx_A2_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_A2_4.Enabled = False
                Else
                    tbx_A2_4.Text = material.CompletionTime.ToString
                End If
                tbx_A2_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_A2_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_A2_1.Enabled = False
                tbx_A2_2.Enabled = False
                tbx_A2_3.Enabled = False
                tbx_A2_4.Enabled = False
                tbx_A2_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(14) Then
                Label_A3.Text = Label_A.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_A3_2.Enabled = False
                    tbx_A3_3.Enabled = False
                Else
                    tbx_A3_2.Text = material.JoggingON.ToString
                    tbx_A3_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_A3_4.Enabled = False
                Else
                    tbx_A3_4.Text = material.CompletionTime.ToString
                End If
                tbx_A3_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_A3_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_A3_1.Enabled = False
                tbx_A3_2.Enabled = False
                tbx_A3_3.Enabled = False
                tbx_A3_4.Enabled = False
                tbx_A3_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(15) Then
                Label_A4.Text = Label_A.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_A4_2.Enabled = False
                    tbx_A4_3.Enabled = False
                Else
                    tbx_A4_2.Text = material.JoggingON.ToString
                    tbx_A4_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_A4_4.Enabled = False
                Else
                    tbx_A4_4.Text = material.CompletionTime.ToString
                End If
                tbx_A4_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_A4_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_A4_1.Enabled = False
                tbx_A4_2.Enabled = False
                tbx_A4_3.Enabled = False
                tbx_A4_4.Enabled = False
                tbx_A4_5.Enabled = False
            End If
            ' --------
            '---------------------------
        End If
        If loadcell.GetLoadCellbyCode(4) = False Then
            Panel_W.Hide()
            Panel_W.Enabled = False
            Panel_WW.Hide()
            Panel_WW.Enabled = False
        Else
            Label_W.Text = loadcell.Name
            If material.GetMaterialbyCode(16) Then
                Label_W1.Text = Label_W.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_W1_2.Enabled = False
                    tbx_W1_3.Enabled = False
                Else
                    tbx_W1_2.Text = material.JoggingON.ToString
                    tbx_W1_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_W1_4.Enabled = False
                Else
                    tbx_W1_4.Text = material.CompletionTime.ToString
                End If
                tbx_W1_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_W1_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_W1_1.Enabled = False
                tbx_W1_2.Enabled = False
                tbx_W1_3.Enabled = False
                tbx_W1_4.Enabled = False
                tbx_W1_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(17) Then
                Label_W2.Text = Label_W.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_W2_2.Enabled = False
                    tbx_W2_3.Enabled = False
                Else
                    tbx_W2_2.Text = material.JoggingON.ToString
                    tbx_W2_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_W2_4.Enabled = False
                Else
                    tbx_W2_4.Text = material.CompletionTime.ToString
                End If
                tbx_W2_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_W2_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_W2_1.Enabled = False
                tbx_W2_2.Enabled = False
                tbx_W2_3.Enabled = False
                tbx_W2_4.Enabled = False
                tbx_W2_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(18) Then
                Label_W3.Text = Label_W.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_W3_2.Enabled = False
                    tbx_W3_3.Enabled = False
                Else
                    tbx_W3_2.Text = material.JoggingON.ToString
                    tbx_W3_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_W3_4.Enabled = False
                Else
                    tbx_W3_4.Text = material.CompletionTime.ToString
                End If
                tbx_W3_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_W3_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_W3_1.Enabled = False
                tbx_W3_2.Enabled = False
                tbx_W3_3.Enabled = False
                tbx_W3_4.Enabled = False
                tbx_W3_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(19) Then
                Label_W4.Text = Label_W.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_U1_3.Enabled = False
                    tbx_W4_3.Enabled = False
                Else
                    tbx_U1_3.Text = material.JoggingON.ToString
                    tbx_W4_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_W4_4.Enabled = False
                Else
                    tbx_W4_4.Text = material.CompletionTime.ToString
                End If
                tbx_W4_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_W4_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_W4_1.Enabled = False
                tbx_W4_2.Enabled = False
                tbx_W4_3.Enabled = False
                tbx_W4_4.Enabled = False
                tbx_W4_5.Enabled = False
            End If
            ' --------
            '---------------------------
        End If
        ' ----------------------------------
        If loadcell.GetLoadCellbyCode(5) = False Then
            Panel_U.Hide()
            Panel_U.Enabled = False
            Panel_UU.Hide()
            Panel_UU.Enabled = False
        Else
            Label_U.Text = loadcell.Name
            If material.GetMaterialbyCode(20) Then
                Label_U1.Text = Label_U.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_U1_2.Enabled = False
                    tbx_U1_3.Enabled = False
                Else
                    tbx_U1_2.Text = material.JoggingON.ToString
                    tbx_U1_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_U1_4.Enabled = False
                Else
                    tbx_U1_4.Text = material.CompletionTime.ToString
                End If
                tbx_U1_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_U1_5.Text = material.CompletionRange.ToString
            Else
                tbx_U1_1.Enabled = False
                tbx_U1_2.Enabled = False
                tbx_U1_3.Enabled = False
                tbx_U1_4.Enabled = False
                tbx_U1_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(21) Then
                Label_U2.Text = Label_U.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_U2_2.Enabled = False
                    tbx_U2_3.Enabled = False
                Else
                    tbx_U2_2.Text = material.JoggingON.ToString
                    tbx_U2_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_U2_4.Enabled = False
                Else
                    tbx_U2_4.Text = material.CompletionTime.ToString
                End If
                tbx_U2_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_W4_2.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_U2_1.Enabled = False
                tbx_U2_2.Enabled = False
                tbx_U2_3.Enabled = False
                tbx_U2_4.Enabled = False
                tbx_U2_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(22) Then
                Label_U3.Text = Label_U.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_U3_2.Enabled = False
                    tbx_U3_3.Enabled = False
                Else
                    tbx_U3_2.Text = material.JoggingON.ToString
                    tbx_U3_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_U3_4.Enabled = False
                Else
                    tbx_U3_4.Text = material.CompletionTime.ToString
                End If
                tbx_U3_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_U3_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_U3_1.Enabled = False
                tbx_U3_2.Enabled = False
                tbx_U3_3.Enabled = False
                tbx_U3_4.Enabled = False
                tbx_U3_5.Enabled = False
            End If
            ' --------
            If material.GetMaterialbyCode(23) Then
                Label_U4.Text = Label_U.Text & material.WeighingStep.ToString
                If material.JoggingType = 0 Then
                    tbx_U4_2.Enabled = False
                    tbx_U4_3.Enabled = False
                Else
                    tbx_U4_2.Text = material.JoggingON.ToString
                    tbx_U4_3.Text = material.JoggingOFF.ToString
                End If
                If material.CompletionBit = 0 Then
                    tbx_U4_4.Enabled = False
                Else
                    tbx_U4_4.Text = material.CompletionTime.ToString
                End If
                tbx_U4_1.Text = IntToStr(material.FineWeighing, loadcell.DecPoint)
                tbx_U4_5.Text = IntToStr(material.CompletionRange, 1)
            Else
                tbx_U4_1.Enabled = False
                tbx_U4_2.Enabled = False
                tbx_U4_3.Enabled = False
                tbx_U4_4.Enabled = False
                tbx_U4_5.Enabled = False
            End If
            ' --------
            '---------------------------
        End If
        ' END SHOW ---------------
        ' =========================
    End Sub
    Private Function save() As Boolean
        Dim OK As Boolean = True
        Dim material As Material_Tbl = New Material_Tbl
        Dim loadcell As LoadCell_Tbl = New LoadCell_Tbl
        loadcell.GetLoadCellbyCode(0)
        If material.GetMaterialbyCode(0) Then
            Try
                If tbx_G1_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_G1_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_G1_3.Text)
                End If
                If tbx_G1_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_G1_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_G1_5.Text)
                material.FineWeighing = StrToInt(tbx_G1_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                OK = False
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try

        End If
        ' ----------------------
        If material.GetMaterialbyCode(1) Then
            Try
                If tbx_G2_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_G2_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_G2_3.Text)
                End If
                If tbx_G2_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_G2_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_G2_5.Text)
                material.FineWeighing = StrToInt(tbx_G2_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try

        End If
        ' -----------------------
        If material.GetMaterialbyCode(2) Then
            Try
                If tbx_G3_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_G3_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_G3_3.Text)
                End If
                If tbx_G3_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_G3_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_G3_5.Text)
                material.FineWeighing = StrToInt(tbx_G3_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try

        End If
        ' --------------------------
        If material.GetMaterialbyCode(3) Then
            Try
                If tbx_G4_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_G4_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_G4_3.Text)
                End If
                If tbx_G4_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_G4_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_G4_5.Text)
                material.FineWeighing = StrToInt(tbx_G4_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' ===========================
        loadcell.GetLoadCellbyCode(1)
        If material.GetMaterialbyCode(4) Then
            Try
                If tbx_S1_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_S1_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_S1_3.Text)
                End If
                If tbx_S1_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_S1_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_S1_5.Text)
                material.FineWeighing = StrToInt(tbx_S1_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' ----------------------
        If material.GetMaterialbyCode(5) Then
            Try
                If tbx_S2_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_S2_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_S2_3.Text)
                End If
                If tbx_S2_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_S2_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_S2_5.Text)
                material.FineWeighing = StrToInt(tbx_S2_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' -----------------------
        If material.GetMaterialbyCode(6) Then
            Try
                If tbx_S3_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_S3_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_S3_3.Text)
                End If
                If tbx_S3_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_S3_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_S3_5.Text)
                material.FineWeighing = StrToInt(tbx_S3_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' --------------------------
        If material.GetMaterialbyCode(7) Then
            Try
                If tbx_S4_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_S4_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_S4_3.Text)
                End If
                If tbx_S4_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_S4_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_S4_5.Text)
                material.FineWeighing = StrToInt(tbx_S4_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' ===========================
        loadcell.GetLoadCellbyCode(2)
        If material.GetMaterialbyCode(8) Then
            Try
                If tbx_C1_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_C1_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_C1_3.Text)
                End If
                If tbx_C1_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_C1_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_C1_5.Text)
                material.FineWeighing = StrToInt(tbx_C1_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' ----------------------
        If material.GetMaterialbyCode(9) Then
            Try
                If tbx_C2_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_C2_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_C2_3.Text)
                End If
                If tbx_C2_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_C2_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_C2_5.Text)
                material.FineWeighing = StrToInt(tbx_C2_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' -----------------------
        If material.GetMaterialbyCode(10) Then
            Try
                If tbx_C3_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_C3_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_C3_3.Text)
                End If
                If tbx_C3_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_C3_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_C3_5.Text)
                material.FineWeighing = StrToInt(tbx_C3_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' --------------------------
        If material.GetMaterialbyCode(11) Then
            Try
                If tbx_C4_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_C4_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_C4_3.Text)
                End If
                If tbx_C4_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_C4_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_C4_5.Text)
                material.FineWeighing = StrToInt(tbx_C4_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' ===========================
        loadcell.GetLoadCellbyCode(3)
        If material.GetMaterialbyCode(12) Then
            Try
                If tbx_A1_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_A1_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_A1_3.Text)
                End If
                If tbx_A1_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_A1_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_A1_5.Text)
                material.FineWeighing = StrToInt(tbx_A1_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' ----------------------
        If material.GetMaterialbyCode(13) Then
            Try
                If tbx_A2_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_A2_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_A2_3.Text)
                End If
                If tbx_A2_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_A2_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_A2_5.Text)
                material.FineWeighing = StrToInt(tbx_A2_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' -----------------------
        If material.GetMaterialbyCode(14) Then
            Try
                If tbx_A3_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_A3_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_A3_3.Text)
                End If
                If tbx_A3_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_A3_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_A3_5.Text)
                material.FineWeighing = StrToInt(tbx_A3_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' --------------------------
        If material.GetMaterialbyCode(15) Then
            Try
                If tbx_A4_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_A4_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_A4_3.Text)
                End If
                If tbx_A4_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_A4_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_A4_5.Text)
                material.FineWeighing = StrToInt(tbx_A4_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' ===========================
        loadcell.GetLoadCellbyCode(4)
        If material.GetMaterialbyCode(16) Then
            Try
                If tbx_W1_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_W1_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_W1_3.Text)
                End If
                If tbx_W1_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_W1_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_W1_5.Text)
                material.FineWeighing = StrToInt(tbx_W1_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' ----------------------
        If material.GetMaterialbyCode(17) Then
            Try
                If tbx_W2_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_W2_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_W2_3.Text)
                End If
                If tbx_W2_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_W2_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_W2_5.Text)
                material.FineWeighing = StrToInt(tbx_W2_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' -----------------------
        If material.GetMaterialbyCode(18) Then
            Try
                If tbx_W3_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_W3_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_W3_3.Text)
                End If
                If tbx_W3_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_W3_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_W3_5.Text)
                material.FineWeighing = StrToInt(tbx_W3_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' --------------------------
        If material.GetMaterialbyCode(19) Then
            Try
                If tbx_U1_3.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_U1_3.Text)
                    material.JoggingOFF = Integer.Parse(tbx_W4_3.Text)
                End If
                If tbx_W4_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_W4_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_W4_5.Text)
                material.FineWeighing = StrToInt(tbx_W4_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' ===========================
        loadcell.GetLoadCellbyCode(5)
        If material.GetMaterialbyCode(20) Then
            Try
                If tbx_U1_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_U1_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_U1_3.Text)
                End If
                If tbx_U1_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_U1_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_U1_5.Text)
                material.FineWeighing = StrToInt(tbx_U1_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' ----------------------
        If material.GetMaterialbyCode(21) Then
            Try
                If tbx_U2_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_U2_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_U2_3.Text)
                End If
                If tbx_U2_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_U2_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_W4_2.Text)
                material.FineWeighing = StrToInt(tbx_U2_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' -----------------------
        If material.GetMaterialbyCode(22) Then
            Try
                If tbx_U3_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_U3_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_U3_3.Text)
                End If
                If tbx_U3_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_U3_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_U3_5.Text)
                material.FineWeighing = StrToInt(tbx_U3_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' --------------------------
        If material.GetMaterialbyCode(23) Then
            Try
                If tbx_U4_2.Enabled Then
                    material.JoggingON = Integer.Parse(tbx_U4_2.Text)
                    material.JoggingOFF = Integer.Parse(tbx_U4_3.Text)
                End If
                If tbx_U4_4.Enabled Then
                    material.CompletionTime = Integer.Parse(tbx_U4_4.Text)
                End If
                material.CompletionRange = StrToInt(tbx_U4_5.Text, 1)
                material.FineWeighing = StrToInt(tbx_U4_1.Text, loadcell.DecPoint)
                If material.JoggingOFF < 300 And material.JoggingON < 300 And material.CompletionTime < 180 Then
                    If material.UpdateMaterial() Then
                    Else
                        OK = False
                    End If
                Else
                    OK = False
                    MessageBox.Show("OUT OF RANGE LINE" & (material.Code + 1).ToString)
                End If
            Catch
                MessageBox.Show("Invalid format numer line" & (material.Code + 1).ToString)
            End Try
        End If
        ' ===========================
        Return OK
    End Function
    Private Sub tbx_G1_1_Leave(sender As Object, e As EventArgs) Handles tbx_G1_1.Leave, tbx_W4_5.Leave, tbx_W4_4.Leave, tbx_W4_3.Leave, tbx_W4_2.Leave, tbx_W4_1.Leave, tbx_W3_5.Leave, tbx_W3_4.Leave, tbx_W3_3.Leave, tbx_W3_2.Leave, tbx_W3_1.Leave, tbx_W2_5.Leave, tbx_W2_4.Leave, tbx_W2_3.Leave, tbx_W2_2.Leave, tbx_W2_1.Leave, tbx_W1_5.Leave, tbx_W1_4.Leave, tbx_W1_3.Leave, tbx_W1_2.Leave, tbx_W1_1.Leave, tbx_U4_5.Leave, tbx_U4_4.Leave, tbx_U4_3.Leave, tbx_U4_2.Leave, tbx_U4_1.Leave, tbx_U3_5.Leave, tbx_U3_4.Leave, tbx_U3_3.Leave, tbx_U3_2.Leave, tbx_U3_1.Leave, tbx_U2_5.Leave, tbx_U2_4.Leave, tbx_U2_3.Leave, tbx_U2_2.Leave, tbx_U2_1.Leave, tbx_U1_5.Leave, tbx_U1_4.Leave, tbx_U1_3.Leave, tbx_U1_2.Leave, tbx_U1_1.Leave, tbx_S4_5.Leave, tbx_S4_4.Leave, tbx_S4_3.Leave, tbx_S4_2.Leave, tbx_S4_1.Leave, tbx_S3_5.Leave, tbx_S3_4.Leave, tbx_S3_3.Leave, tbx_S3_2.Leave, tbx_S3_1.Leave, tbx_S2_5.Leave, tbx_S2_4.Leave, tbx_S2_3.Leave, tbx_S2_2.Leave, tbx_S2_1.Leave, tbx_S1_5.Leave, tbx_S1_4.Leave, tbx_S1_3.Leave, tbx_S1_2.Leave, tbx_S1_1.Leave, tbx_G4_5.Leave, tbx_G4_4.Leave, tbx_G4_3.Leave, tbx_G4_2.Leave, tbx_G4_1.Leave, tbx_G3_5.Leave, tbx_G3_4.Leave, tbx_G3_3.Leave, tbx_G3_2.Leave, tbx_G3_1.Leave, tbx_G2_5.Leave, tbx_G2_4.Leave, tbx_G2_3.Leave, tbx_G2_2.Leave, tbx_G2_1.Leave, tbx_G1_5.Leave, tbx_G1_4.Leave, tbx_G1_3.Leave, tbx_G1_2.Leave, tbx_C4_5.Leave, tbx_C4_4.Leave, tbx_C4_3.Leave, tbx_C4_2.Leave, tbx_C4_1.Leave, tbx_C3_5.Leave, tbx_C3_4.Leave, tbx_C3_3.Leave, tbx_C3_2.Leave, tbx_C3_1.Leave, tbx_C2_5.Leave, tbx_C2_4.Leave, tbx_C2_3.Leave, tbx_C2_2.Leave, tbx_C2_1.Leave, tbx_C1_5.Leave, tbx_C1_4.Leave, tbx_C1_3.Leave, tbx_C1_2.Leave, tbx_C1_1.Leave, tbx_A4_5.Leave, tbx_A4_4.Leave, tbx_A4_3.Leave, tbx_A4_2.Leave, tbx_A4_1.Leave, tbx_A3_5.Leave, tbx_A3_4.Leave, tbx_A3_3.Leave, tbx_A3_2.Leave, tbx_A3_1.Leave, tbx_A2_5.Leave, tbx_A2_4.Leave, tbx_A2_3.Leave, tbx_A2_2.Leave, tbx_A2_1.Leave, tbx_A1_5.Leave, tbx_A1_4.Leave, tbx_A1_3.Leave, tbx_A1_2.Leave, tbx_A1_1.Leave
        save()
        Show_()
    End Sub
    Private Sub tbx_G1_1_KeyDown(sender As Object, e As KeyEventArgs) Handles tbx_G1_1.KeyDown, tbx_W4_5.KeyDown, tbx_W4_4.KeyDown, tbx_W4_3.KeyDown, tbx_W4_2.KeyDown, tbx_W4_1.KeyDown, tbx_W3_5.KeyDown, tbx_W3_4.KeyDown, tbx_W3_3.KeyDown, tbx_W3_2.KeyDown, tbx_W3_1.KeyDown, tbx_W2_5.KeyDown, tbx_W2_4.KeyDown, tbx_W2_3.KeyDown, tbx_W2_2.KeyDown, tbx_W2_1.KeyDown, tbx_W1_5.KeyDown, tbx_W1_4.KeyDown, tbx_W1_3.KeyDown, tbx_W1_2.KeyDown, tbx_W1_1.KeyDown, tbx_U4_5.KeyDown, tbx_U4_4.KeyDown, tbx_U4_3.KeyDown, tbx_U4_2.KeyDown, tbx_U4_1.KeyDown, tbx_U3_5.KeyDown, tbx_U3_4.KeyDown, tbx_U3_3.KeyDown, tbx_U3_2.KeyDown, tbx_U3_1.KeyDown, tbx_U2_5.KeyDown, tbx_U2_4.KeyDown, tbx_U2_3.KeyDown, tbx_U2_2.KeyDown, tbx_U2_1.KeyDown, tbx_U1_5.KeyDown, tbx_U1_4.KeyDown, tbx_U1_3.KeyDown, tbx_U1_2.KeyDown, tbx_U1_1.KeyDown, tbx_S4_5.KeyDown, tbx_S4_4.KeyDown, tbx_S4_3.KeyDown, tbx_S4_2.KeyDown, tbx_S4_1.KeyDown, tbx_S3_5.KeyDown, tbx_S3_4.KeyDown, tbx_S3_3.KeyDown, tbx_S3_2.KeyDown, tbx_S3_1.KeyDown, tbx_S2_5.KeyDown, tbx_S2_4.KeyDown, tbx_S2_3.KeyDown, tbx_S2_2.KeyDown, tbx_S2_1.KeyDown, tbx_S1_5.KeyDown, tbx_S1_4.KeyDown, tbx_S1_3.KeyDown, tbx_S1_2.KeyDown, tbx_S1_1.KeyDown, tbx_G4_5.KeyDown, tbx_G4_4.KeyDown, tbx_G4_3.KeyDown, tbx_G4_2.KeyDown, tbx_G4_1.KeyDown, tbx_G3_5.KeyDown, tbx_G3_4.KeyDown, tbx_G3_3.KeyDown, tbx_G3_2.KeyDown, tbx_G3_1.KeyDown, tbx_G2_5.KeyDown, tbx_G2_4.KeyDown, tbx_G2_3.KeyDown, tbx_G2_2.KeyDown, tbx_G2_1.KeyDown, tbx_G1_5.KeyDown, tbx_G1_4.KeyDown, tbx_G1_3.KeyDown, tbx_G1_2.KeyDown, tbx_C4_5.KeyDown, tbx_C4_4.KeyDown, tbx_C4_3.KeyDown, tbx_C4_2.KeyDown, tbx_C4_1.KeyDown, tbx_C3_5.KeyDown, tbx_C3_4.KeyDown, tbx_C3_3.KeyDown, tbx_C3_2.KeyDown, tbx_C3_1.KeyDown, tbx_C2_5.KeyDown, tbx_C2_4.KeyDown, tbx_C2_3.KeyDown, tbx_C2_2.KeyDown, tbx_C2_1.KeyDown, tbx_C1_5.KeyDown, tbx_C1_4.KeyDown, tbx_C1_3.KeyDown, tbx_C1_2.KeyDown, tbx_C1_1.KeyDown, tbx_A4_5.KeyDown, tbx_A4_4.KeyDown, tbx_A4_3.KeyDown, tbx_A4_2.KeyDown, tbx_A4_1.KeyDown, tbx_A3_5.KeyDown, tbx_A3_4.KeyDown, tbx_A3_3.KeyDown, tbx_A3_2.KeyDown, tbx_A3_1.KeyDown, tbx_A2_5.KeyDown, tbx_A2_4.KeyDown, tbx_A2_3.KeyDown, tbx_A2_2.KeyDown, tbx_A2_1.KeyDown, tbx_A1_5.KeyDown, tbx_A1_4.KeyDown, tbx_A1_3.KeyDown, tbx_A1_2.KeyDown, tbx_A1_1.KeyDown
        If e.KeyCode = Keys.Enter Then
            save()
            Show_()
        End If
    End Sub
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If save() Then
            MessageBox.Show("UPDATE SUCCESS")
        End If
    End Sub
End Class