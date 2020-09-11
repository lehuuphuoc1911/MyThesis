Imports System.Globalization
Imports ConcretePlant.Setting
Public Class Combine
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ==========================================================================================
        ' Put Form1 in the centre of the screen
        SetBounds((Screen.GetWorkingArea(Me).Width - Width) / 2, (Screen.GetWorkingArea(Me).Height - Height) / 2, Width, Height)
        ' =============================================================================================
        ' Load
        Dim loadcell0 As LoadCell_Tbl = New LoadCell_Tbl
        Dim material0 As Material_Tbl = New Material_Tbl
        If loadcell0.GetLoadCellbyCode(0) = False Then
            label00.Hide()
            label00.Enabled = False
            Panel01.Hide()
            Panel01.Enabled = False
            Panel02.Hide()
            Panel02.Enabled = False
            Panel03.Hide()
            Panel03.Enabled = False
            Panel04.Hide()
            Panel04.Enabled = False
        Else
            If material0.GetMaterialbyCode(0) Then
                Label01.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label01.Hide()
                Panel01.Enabled = False
            End If
            If material0.GetMaterialbyCode(1) Then
                Label02.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label02.Hide()
                Panel02.Enabled = False
            End If
            If material0.GetMaterialbyCode(2) Then
                Label03.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label03.Hide()
                Panel03.Enabled = False
            End If
            If material0.GetMaterialbyCode(3) Then
                Label04.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label04.Hide()
                Panel04.Enabled = False
            End If
            label00.Text = loadcell0.Name
        End If
        If loadcell0.GetLoadCellbyCode(1) = False Then
            Label10.Hide()
            Panel11.Hide()
            Panel12.Hide()
            Panel13.Hide()
            Panel04.Hide()
        Else
            If material0.GetMaterialbyCode(4) Then
                Label11.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label11.Hide()
                Panel11.Enabled = False
            End If
            If material0.GetMaterialbyCode(5) Then
                Label12.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label12.Hide()
                Panel12.Enabled = False
            End If
            If material0.GetMaterialbyCode(6) Then
                Label13.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label13.Hide()
                Panel13.Enabled = False
            End If
            If material0.GetMaterialbyCode(7) Then
                Label14.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label14.Hide()
                Panel14.Enabled = False
            End If
            Label10.Text = loadcell0.Name
        End If
        If loadcell0.GetLoadCellbyCode(2) = False Then
            Label20.Hide()
            Panel21.Hide()
            Panel22.Hide()
            Panel23.Hide()
            Panel24.Hide()
        Else
            If material0.GetMaterialbyCode(8) Then
                Label21.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label21.Hide()
                Panel21.Enabled = False
            End If
            If material0.GetMaterialbyCode(9) Then
                Label22.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label22.Hide()
                Panel22.Enabled = False
            End If
            If material0.GetMaterialbyCode(10) Then
                Label23.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label23.Hide()
                Panel23.Enabled = False
            End If
            If material0.GetMaterialbyCode(11) Then
                Label24.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label24.Hide()
                Panel24.Enabled = False
            End If
            Label20.Text = loadcell0.Name
        End If
        If loadcell0.GetLoadCellbyCode(3) = False Then
            Label30.Hide()
            Panel31.Hide()
            Panel32.Hide()
            Panel33.Hide()
            Panel34.Hide()
        Else
            If material0.GetMaterialbyCode(12) Then
                Label31.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label31.Hide()
                Panel31.Enabled = False
            End If
            If material0.GetMaterialbyCode(13) Then
                Label32.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label32.Hide()
                Panel32.Enabled = False
            End If
            If material0.GetMaterialbyCode(14) Then
                Label33.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label33.Hide()
                Panel33.Enabled = False
            End If
            If material0.GetMaterialbyCode(15) Then
                Label34.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label34.Hide()
                Panel34.Enabled = False
            End If
            Label30.Text = loadcell0.Name
        End If
        If loadcell0.GetLoadCellbyCode(4) = False Then
            Label40.Hide()
            Panel41.Hide()
            Panel42.Hide()
            Panel43.Hide()
            Panel44.Hide()
        Else
            If material0.GetMaterialbyCode(16) Then
                Label41.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label41.Hide()
                Panel41.Enabled = False
            End If
            If material0.GetMaterialbyCode(17) Then
                Label42.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label42.Hide()
                Panel42.Enabled = False
            End If
            If material0.GetMaterialbyCode(18) Then
                Label43.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label43.Hide()
                Panel43.Enabled = False
            End If
            If material0.GetMaterialbyCode(19) Then
                Label44.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label44.Hide()
                Panel44.Enabled = False
            End If
            Label40.Text = loadcell0.Name
        End If
        If loadcell0.GetLoadCellbyCode(5) = False Then
            Label50.Hide()
            Panel51.Hide()
            Panel52.Hide()
            Panel53.Hide()
            Panel54.Hide()
        Else
            If material0.GetMaterialbyCode(20) Then
                Label51.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label51.Hide()
                Panel51.Enabled = False
            End If
            If material0.GetMaterialbyCode(21) Then
                Label52.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label52.Hide()
                Panel52.Enabled = False
            End If
            If material0.GetMaterialbyCode(22) Then
                Label53.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label53.Hide()
                Panel53.Enabled = False
            End If
            If material0.GetMaterialbyCode(23) Then
                Label54.Text = loadcell0.Name & material0.WeighingStep.ToString
            Else
                Label54.Hide()
                Panel54.Enabled = False
            End If
            Label50.Text = loadcell0.Name
        End If
        My.Resources.Resource.Culture = New CultureInfo(__Language)
        Me.Text = My.Resources.Resource.bt_toCombine
        Label1.Text = My.Resources.Resource.CBNCODE
        delCombine_tbx.Text = My.Resources.Resource.btn_del_ope
        Clear.Text = My.Resources.Resource.NEWCOMBINE
        AddCbn.Text = My.Resources.Resource.ADDCOMBINE
        Edit_btn.Text = My.Resources.Resource.bt_edit
    End Sub
    Private Sub CombineCode_tbx_KeyDown(sender As Object, e As KeyEventArgs) Handles CombineCode_tbx.KeyDown
        Dim CbnCode_int As Integer
        Dim ok As Boolean = False
        If e.KeyCode = Keys.Enter Then
            Try
                CbnCode_int = Integer.Parse(CombineCode_tbx.Text)
                ok = True
                delCombine_tbx.Enabled = True
                Edit_btn.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Combine Code is an integer number", "Error003")
            End Try
            If ok Then
                PrintCombine(CbnCode_int)
            End If
        End If
    End Sub
    Public Sub PrintCombine(ByVal CbnCode_ As Integer)
        Dim SltCombine As Combine_Tbl = New Combine_Tbl
        Dim Loadcell As LoadCell_Tbl
        If SltCombine.GetCombinebyCode(CbnCode_) Then
            Loadcell = New LoadCell_Tbl(0)
            G1_tbx.Text = IntToStr(SltCombine.GetValue(0), Loadcell.DecPoint)
            G2_tbx.Text = IntToStr(SltCombine.GetValue(1), Loadcell.DecPoint)
            G3_tbx.Text = IntToStr(SltCombine.GetValue(2), Loadcell.DecPoint)
            G4_tbx.Text = IntToStr(SltCombine.GetValue(3), Loadcell.DecPoint)
            Loadcell = New LoadCell_Tbl(1)
            S1_tbx.Text = IntToStr(SltCombine.GetValue(4), Loadcell.DecPoint)
            S2_tbx.Text = IntToStr(SltCombine.GetValue(5), Loadcell.DecPoint)
            S3_tbx.Text = IntToStr(SltCombine.GetValue(6), Loadcell.DecPoint)
            S4_tbx.Text = IntToStr(SltCombine.GetValue(7), Loadcell.DecPoint)
            Loadcell = New LoadCell_Tbl(2)
            C1_tbx.Text = IntToStr(SltCombine.GetValue(8), Loadcell.DecPoint)
            C2_tbx.Text = IntToStr(SltCombine.GetValue(9), Loadcell.DecPoint)
            C3_tbx.Text = IntToStr(SltCombine.GetValue(10), Loadcell.DecPoint)
            C4_tbx.Text = IntToStr(SltCombine.GetValue(11), Loadcell.DecPoint)
            Loadcell = New LoadCell_Tbl(3)
            A1_tbx.Text = IntToStr(SltCombine.GetValue(12), Loadcell.DecPoint)
            A2_tbx.Text = IntToStr(SltCombine.GetValue(13), Loadcell.DecPoint)
            A3_tbx.Text = IntToStr(SltCombine.GetValue(14), Loadcell.DecPoint)
            A4_tbx.Text = IntToStr(SltCombine.GetValue(15), Loadcell.DecPoint)
            Loadcell = New LoadCell_Tbl(4)
            W1_tbx.Text = IntToStr(SltCombine.GetValue(16), Loadcell.DecPoint)
            W2_tbx.Text = IntToStr(SltCombine.GetValue(17), Loadcell.DecPoint)
            W3_tbx.Text = IntToStr(SltCombine.GetValue(18), Loadcell.DecPoint)
            W4_tbx.Text = IntToStr(SltCombine.GetValue(19), Loadcell.DecPoint)
            Loadcell = New LoadCell_Tbl(5)
            U1_tbx.Text = IntToStr(SltCombine.GetValue(20), Loadcell.DecPoint)
            U2_tbx.Text = IntToStr(SltCombine.GetValue(21), Loadcell.DecPoint)
            U3_tbx.Text = IntToStr(SltCombine.GetValue(22), Loadcell.DecPoint)
            U4_tbx.Text = IntToStr(SltCombine.GetValue(23), Loadcell.DecPoint)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Clear.Click
        ClearALl()
    End Sub
    Public Sub ClearALl()
        CombineCode_tbx.Text = ""
        G1_tbx.Text = ""
        G2_tbx.Text = ""
        G3_tbx.Text = ""
        G4_tbx.Text = ""
        S1_tbx.Text = ""
        S2_tbx.Text = ""
        S3_tbx.Text = ""
        S4_tbx.Text = ""
        C1_tbx.Text = ""
        C2_tbx.Text = ""
        C3_tbx.Text = ""
        C4_tbx.Text = ""
        A1_tbx.Text = ""
        A2_tbx.Text = ""
        A3_tbx.Text = ""
        A4_tbx.Text = ""
        W1_tbx.Text = ""
        W2_tbx.Text = ""
        W3_tbx.Text = ""
        W4_tbx.Text = ""
        U1_tbx.Text = ""
        U2_tbx.Text = ""
        U3_tbx.Text = ""
        U4_tbx.Text = ""
        AddCbn.Enabled = True
        delCombine_tbx.Enabled = False
        Edit_btn.Enabled = False
    End Sub
    Private Sub delCombine_tbx_Click(sender As Object, e As EventArgs) Handles delCombine_tbx.Click
        Dim deletingCombine As Combine_Tbl = New Combine_Tbl
        Dim Code_ As Integer
        Try
            Code_ = Integer.Parse(CombineCode_tbx.Text)
            deletingCombine.DeleteCombine(Code_)
            ClearALl()
        Catch ex As Exception
            MessageBox.Show("Wrong number format", "Error004")
        End Try
        AddCbn.Enabled = False
    End Sub
    Private Sub AddCbn_Click(sender As Object, e As EventArgs) Handles AddCbn.Click
        Dim value() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim OK As Boolean = False
        Dim combine As Combine_Tbl = New Combine_Tbl
        Try
            Dim Loadcell As LoadCell_Tbl
            Loadcell = New LoadCell_Tbl(0)
            value(0) = StrToInt(G1_tbx.Text, Loadcell.DecPoint)
            value(1) = StrToInt(G2_tbx.Text, Loadcell.DecPoint)
            value(2) = StrToInt(G3_tbx.Text, Loadcell.DecPoint)
            value(3) = StrToInt(G4_tbx.Text, Loadcell.DecPoint)
            Loadcell = New LoadCell_Tbl(1)
            value(4) = StrToInt(S1_tbx.Text, Loadcell.DecPoint)
            value(5) = StrToInt(S2_tbx.Text, Loadcell.DecPoint)
            value(6) = StrToInt(S3_tbx.Text, Loadcell.DecPoint)
            value(7) = StrToInt(S4_tbx.Text, Loadcell.DecPoint)
            Loadcell = New LoadCell_Tbl(2)
            value(8) = StrToInt(C1_tbx.Text, Loadcell.DecPoint)
            value(9) = StrToInt(C2_tbx.Text, Loadcell.DecPoint)
            value(10) = StrToInt(C2_tbx.Text, Loadcell.DecPoint)
            value(10) = StrToInt(C2_tbx.Text, Loadcell.DecPoint)
            Loadcell = New LoadCell_Tbl(3)
            value(12) = StrToInt(A1_tbx.Text, Loadcell.DecPoint)
            value(13) = StrToInt(A2_tbx.Text, Loadcell.DecPoint)
            value(14) = StrToInt(A3_tbx.Text, Loadcell.DecPoint)
            value(15) = StrToInt(A4_tbx.Text, Loadcell.DecPoint)
            Loadcell = New LoadCell_Tbl(4)
            value(16) = StrToInt(W1_tbx.Text, Loadcell.DecPoint)
            value(17) = StrToInt(W2_tbx.Text, Loadcell.DecPoint)
            value(18) = StrToInt(W3_tbx.Text, Loadcell.DecPoint)
            value(19) = StrToInt(W4_tbx.Text, Loadcell.DecPoint)
            combine.CbnCode = Integer.Parse(CombineCode_tbx.Text)
            Loadcell = New LoadCell_Tbl(5)
            value(20) = StrToInt(U1_tbx.Text, Loadcell.DecPoint)
            value(21) = StrToInt(U2_tbx.Text, Loadcell.DecPoint)
            value(22) = StrToInt(U3_tbx.Text, Loadcell.DecPoint)
            value(23) = StrToInt(U4_tbx.Text, Loadcell.DecPoint)
            combine.CbnCode = Integer.Parse(CombineCode_tbx.Text)
            combine.SetValue(value)
            OK = True
        Catch ex As Exception
            MessageBox.Show("WRONG FORMAT NUMBER", "Error005")
        End Try
        If OK Then
            If combine.WriteCombine() Then
                MessageBox.Show("successful action")
                ClearALl()
            End If
        End If
    End Sub
    Private Sub Edit_btn_Click(sender As Object, e As EventArgs) Handles Edit_btn.Click
        Dim value() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim OK As Boolean = False
        Dim combine As Combine_Tbl = New Combine_Tbl
        Try
            Dim Loadcell As LoadCell_Tbl
            Loadcell = New LoadCell_Tbl(0)
            value(0) = StrToInt(G1_tbx.Text, Loadcell.DecPoint)
            value(1) = StrToInt(G2_tbx.Text, Loadcell.DecPoint)
            value(2) = StrToInt(G3_tbx.Text, Loadcell.DecPoint)
            value(3) = StrToInt(G4_tbx.Text, Loadcell.DecPoint)
            Loadcell = New LoadCell_Tbl(1)
            value(4) = StrToInt(S1_tbx.Text, Loadcell.DecPoint)
            value(5) = StrToInt(S2_tbx.Text, Loadcell.DecPoint)
            value(6) = StrToInt(S3_tbx.Text, Loadcell.DecPoint)
            value(7) = StrToInt(S4_tbx.Text, Loadcell.DecPoint)
            Loadcell = New LoadCell_Tbl(2)
            value(8) = StrToInt(C1_tbx.Text, Loadcell.DecPoint)
            value(9) = StrToInt(C2_tbx.Text, Loadcell.DecPoint)
            value(10) = StrToInt(C2_tbx.Text, Loadcell.DecPoint)
            value(10) = StrToInt(C2_tbx.Text, Loadcell.DecPoint)
            Loadcell = New LoadCell_Tbl(3)
            value(12) = StrToInt(A1_tbx.Text, Loadcell.DecPoint)
            value(13) = StrToInt(A2_tbx.Text, Loadcell.DecPoint)
            value(14) = StrToInt(A3_tbx.Text, Loadcell.DecPoint)
            value(15) = StrToInt(A4_tbx.Text, Loadcell.DecPoint)
            Loadcell = New LoadCell_Tbl(4)
            value(16) = StrToInt(W1_tbx.Text, Loadcell.DecPoint)
            value(17) = StrToInt(W2_tbx.Text, Loadcell.DecPoint)
            value(18) = StrToInt(W3_tbx.Text, Loadcell.DecPoint)
            value(19) = StrToInt(W4_tbx.Text, Loadcell.DecPoint)
            Loadcell = New LoadCell_Tbl(5)
            value(20) = StrToInt(U1_tbx.Text, Loadcell.DecPoint)
            value(21) = StrToInt(U2_tbx.Text, Loadcell.DecPoint)
            value(22) = StrToInt(U3_tbx.Text, Loadcell.DecPoint)
            value(23) = StrToInt(U4_tbx.Text, Loadcell.DecPoint)
            combine.CbnCode = Integer.Parse(CombineCode_tbx.Text)
            combine.SetValue(value)
            OK = True
        Catch ex As Exception
            MessageBox.Show("WRONG FORMAT NUMBER", "Error005")
        End Try
        If OK Then
            If combine.EditCombine(value) Then
                MessageBox.Show("successful action")
                ClearALl()
            End If
        End If
    End Sub
End Class
