Imports ConcretePlant.Setting
Imports System.Resources
Imports System.Globalization
Public Class Operate
    Dim order As Order = New Order
    Dim data_showed As DataTable = New DataTable
    Dim data_executing As DataTable = New DataTable
    Dim CurrentMouseOverRow As Integer
    Dim IsExecuting As Boolean = True
    Dim LoadCellValue(5) As Long
    Dim MaterialValue(23) As Long   ' in auto mode, it is the remaining value, not the current value
    Dim LoadcellValueDone(5) As Long
    Dim MaterialValueDone(23) As Long
    Dim OrderValue(23) As Long
    Dim mode As Long
    ' 0:OFF; 1: ROUGH; 2 FINE
    Dim Gate_G1 As Byte
    Dim Gate_G2 As Byte
    Dim Gate_G As Byte
    Dim Gate_S1 As Byte
    Dim Gate_S2 As Byte
    Dim Gate_C1 As Byte
    Dim Gate_C2 As Byte
    Dim Gate_C3 As Byte
    Dim Gate_A1 As Byte
    Dim Gate_A3 As Byte
    Dim Gate_A2 As Byte
    Dim Gate_W As Byte
    Dim Gate_W1 As Byte
    Dim Gate_A As Byte
    Dim Gate_S As Byte
    Dim Gate_C As Byte
    ' 0: OFF; 1: ON
    Dim Gate_G1VIB As Byte
    Dim Gate_G2VIB As Byte
    Dim Gate_G_VIB As Byte
    Dim Gate_S1VIB As Byte
    Dim Gate_S2VIB As Byte
    Dim Gate_C1VIB As Byte
    Dim Gate_C2VIB As Byte
    Dim Gate_C3VIB As Byte
    Dim Gate_A1VIB As Byte
    Dim Gate_A3VIB As Byte
    Dim Gate_A2VIB As Byte
    Dim Gate_W_VIB As Byte
    Dim Gate_W1VIB As Byte
    Dim Gate_A_VIB As Byte
    Dim Gate_S_VIB As Byte
    Dim Gate_C_VIB As Byte
    Dim Gate_Temp As Byte
    Dim Gate_Mixer As Byte
    Dim Mixer_ON As Byte
    Dim Conveyer_ON As Byte
    Private Sub Operate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WritePLCinit()
        SetBounds(0, 0, Width, Height)
        order.GetFromServer()
        order.UpdateTable()
        order.UpdateServer()
        data_showed.Columns.Add("No.", GetType(Integer))
        data_showed.Columns.Add("ORDER CODE", GetType(String))
        data_showed.Columns.Add("NAME", GetType(String))
        data_showed.Columns.Add("CAR No.", GetType(String))
        data_showed.Columns.Add("VOLUME", GetType(String))
        data_showed.Columns.Add("COMBINE CODE", GetType(Integer))
        data_showed.Columns.Add("NUMBER OF BATCHES", GetType(Integer))
        '--------------------------------
        data_executing.Columns.Add("No.", GetType(Integer))
        data_executing.Columns.Add("ORDER CODE", GetType(String))
        data_executing.Columns.Add("NAME", GetType(String))
        data_executing.Columns.Add("CAR No.", GetType(String))
        data_executing.Columns.Add("VOLUME", GetType(String))
        data_executing.Columns.Add("COMBINE CODE", GetType(Integer))
        data_executing.Columns.Add("NUMBER OF BATCHES", GetType(Integer))
        data_executing.Columns.Add("BATCH EXECUTING", GetType(Integer))

        UpdateData()
        dt_gridview.DataSource = data_showed
        dt_grid_Executing.DataSource = data_executing
        SetLanguage()
        'Dim combine As Combine_Tbl = New Combine_Tbl(0)
        'combine.PLCWrite(10)
        MCSendData("D220", 24, {5000, 5000, 0, 0, 5000, 5000, 0, 0, 3000, 3000, 5000, 0, 2000, 2000, 2000, 0, 5500, 0, 0, 0, 0, 0, 0, 0})
        'PLCSetBit("D221", 3, 1)        
    End Sub
    Public Sub WritePLCinit()
        fncMCConnect(giMode)
        Threading.Thread.Sleep(1000)
        Dim WriteMixingInit As PLCMixing = New PLCMixing(0)
        WriteMixingInit.SendData()

        Dim WriteLoadcellInit As PLCLoadcell = New PLCLoadcell(0)
        WriteLoadcellInit.AdressStart = "R100"
        WriteLoadcellInit.SendData()

        WriteLoadcellInit = New PLCLoadcell(1)
        WriteLoadcellInit.AdressStart = "R120"
        WriteLoadcellInit.SendData()

        WriteLoadcellInit = New PLCLoadcell(2)
        WriteLoadcellInit.AdressStart = "R140"
        WriteLoadcellInit.SendData()

        WriteLoadcellInit = New PLCLoadcell(3)
        WriteLoadcellInit.AdressStart = "R160"
        WriteLoadcellInit.SendData()

        WriteLoadcellInit = New PLCLoadcell(4)
        WriteLoadcellInit.AdressStart = "R180"
        WriteLoadcellInit.SendData()

        WriteLoadcellInit = New PLCLoadcell(5)
        WriteLoadcellInit.AdressStart = "R200"
        WriteLoadcellInit.SendData()

        Dim write As PLCMaterial = New PLCMaterial(0)
        write.AdressStart = "R500"
        write.SendData()

        write = New PLCMaterial(1)
        write.AdressStart = "R520"
        write.SendData()

        write = New PLCMaterial(2)
        write.AdressStart = "R540"
        write.SendData()

        write = New PLCMaterial(3)
        write.AdressStart = "R560"
        write.SendData()

        write = New PLCMaterial(4)
        write.AdressStart = "R580"
        write.SendData()

        write = New PLCMaterial(5)
        write.AdressStart = "R600"
        write.SendData()

        write = New PLCMaterial(6)
        write.AdressStart = "R620"
        write.SendData()

        write = New PLCMaterial(7)
        write.AdressStart = "R640"
        write.SendData()

        write = New PLCMaterial(8)
        write.AdressStart = "R660"
        write.SendData()

        write = New PLCMaterial(9)
        write.AdressStart = "R680"
        write.SendData()

        write = New PLCMaterial(10)
        write.AdressStart = "R700"
        write.SendData()

        write = New PLCMaterial(11)
        write.AdressStart = "R720"
        write.SendData()

        write = New PLCMaterial(12)
        write.AdressStart = "R740"
        write.SendData()

        write = New PLCMaterial(13)
        write.AdressStart = "R760"
        write.SendData()

        write = New PLCMaterial(14)
        write.AdressStart = "R780"
        write.SendData()

        write = New PLCMaterial(15)
        write.AdressStart = "R800"
        write.SendData()

        write = New PLCMaterial(16)
        write.AdressStart = "R820"
        write.SendData()

        write = New PLCMaterial(17)
        write.AdressStart = "R840"
        write.SendData()

        write = New PLCMaterial(18)
        write.AdressStart = "R860"
        write.SendData()

        write = New PLCMaterial(19)
        write.AdressStart = "R880"
        write.SendData()

        write = New PLCMaterial(20)
        write.AdressStart = "R900"
        write.SendData()

        write = New PLCMaterial(21)
        write.AdressStart = "R920"
        write.SendData()

        write = New PLCMaterial(22)
        write.AdressStart = "R940"
        write.SendData()

        write = New PLCMaterial(23)
        write.AdressStart = "R960"
        write.SendData()


        Dim write2 As PLCEmission
        write2 = New PLCEmission(0)
        write2.AdressStart = "R1000"
        write2.SendData()

        write2 = New PLCEmission(1)
        write2.AdressStart = "R1020"
        write2.SendData()

        write2 = New PLCEmission(2)
        write2.AdressStart = "R1040"
        write2.SendData()

        write2 = New PLCEmission(3)
        write2.AdressStart = "R1060"
        write2.SendData()

        write2 = New PLCEmission(4)
        write2.AdressStart = "R1080"
        write2.SendData()

        write2 = New PLCEmission(5)
        write2.AdressStart = "R1100"
        write2.SendData()

    End Sub
    Private Sub UpdateData(Optional ByVal step_ As Integer = 1)
        Dim i As Integer
        Dim num As Integer
        ' delete all
        While data_showed.Rows.Count
            Try
                data_showed.Rows.RemoveAt(0)
            Catch
            End Try
        End While
        Try
            data_executing.Rows.RemoveAt(0)
        Catch ex As Exception
        End Try

        ' set new
        order.GetFromServer()
        order.UpdateTable()
        order.UpdateServer()

        If IsExecuting Then
            If order.Volume(0) <= __MixerVolume Then
                num = 1
            ElseIf order.Volume(0) Mod __MixerVolume = 0 Then
                num = order.Volume(0) \ __MixerVolume
            Else
                num = order.Volume(0) \ __MixerVolume + 1
            End If
            data_executing.Rows.Add(order.No(0), order.OrderCode(0), order.Name(0), order.CarNo(0), IntToStr(order.Volume(0)), order.CbnCode(0), num, step_)
            For i = 1 To order.NumberOfRows - 1
                If order.Volume(i) <= __MixerVolume Then
                    num = 1
                ElseIf order.Volume(i) Mod __MixerVolume = 0 Then
                    num = order.Volume(i) \ __MixerVolume
                Else
                    num = order.Volume(i) \ __MixerVolume + 1
                End If
                data_showed.Rows.Add(order.No(i), order.OrderCode(i), order.Name(i), order.CarNo(i), IntToStr(order.Volume(i)), order.CbnCode(i), num)
            Next
        Else
            For i = 0 To order.NumberOfRows - 1
                If order.Volume(i) <= __MixerVolume Then
                    num = 1
                ElseIf order.Volume(i) Mod __MixerVolume = 0 Then
                    num = order.Volume(i) \ __MixerVolume
                Else
                    num = order.Volume(i) \ __MixerVolume + 1
                End If
                data_showed.Rows.Add(order.No(i), order.OrderCode(i), order.Name(i), order.CarNo(i), IntToStr(order.Volume(i)), order.CbnCode(i), num)
            Next
        End If

    End Sub
    Private Sub bt_toNhapXuat_Click(sender As Object, e As EventArgs) Handles bt_toNhapXuat.Click
        Dim frm As NhapXuat = New NhapXuat()
        frm.ShowDialog()
    End Sub
    Private Sub bt_toWeiPr_Click(sender As Object, e As EventArgs) Handles bt_toWeiPr.Click
        Dim frm As WeighingPropertiesForm = New WeighingPropertiesForm
        frm.ShowDialog()
    End Sub
    Private Sub bt_toCombine_Click(sender As Object, e As EventArgs) Handles bt_toCombine.Click
        Dim frm As Combine = New Combine
        frm.ShowDialog()
    End Sub
    Private Sub rb_VNese_CheckedChanged(sender As Object, e As EventArgs) Handles rb_VNese.CheckedChanged

    End Sub
    Private Sub dt_gridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_gridview.CellClick
        Try
            CurrentMouseOverRow = dt_gridview.CurrentCell.RowIndex
        Catch ex As Exception
            CurrentMouseOverRow = -1
        End Try
    End Sub
    Private Sub bt_add_Click(sender As Object, e As EventArgs) Handles bt_add.Click
        Dim frm As AddNew = New AddNew(order)
        frm.ShowDialog()
        UpdateData()
    End Sub
    Private Sub rb_Eng_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Eng.CheckedChanged
        If rb_Eng.Checked Then
            __Language = "en-US"
        Else
            __Language = "vi-VN"
        End If
        SetLanguage()
        Pic_A.Image = My.Resources.OFF

    End Sub
    Private Sub SetLanguage()
        My.Resources.Resource.Culture = New CultureInfo(__Language)
        lb_setting.Text = My.Resources.Resource.lb_setting_ope
        rb_Eng.Text = My.Resources.Resource.rb_Eng
        rb_VNese.Text = My.Resources.Resource.rb_VNese
        btn_del.Text = My.Resources.Resource.btn_del_ope
        bt_add.Text = My.Resources.Resource.addnew
        bt_detail.Text = My.Resources.Resource.bt_detail
        bt_edit.Text = My.Resources.Resource.bt_edit
        bt_Mixer.Text = My.Resources.Resource.bt_Mixer_ope
        bt_toCombine.Text = My.Resources.Resource.bt_toCombine
        bt_toNhapXuat.Text = My.Resources.Resource.bt_toNhapXuat
        bt_toWeiPr.Text = My.Resources.Resource.bt_toWeiPr
        gb_lang.Text = My.Resources.Resource.gb_lang
        Me.Text = My.Resources.Resource.frm_operate
        Try
            dt_gridview.Columns(0).HeaderText = My.Resources.Resource.No_
            dt_gridview.Columns(1).HeaderText = My.Resources.Resource.ORDERCODE
            dt_gridview.Columns(2).HeaderText = My.Resources.Resource.NAME
            dt_gridview.Columns(3).HeaderText = My.Resources.Resource.CARNO
            dt_gridview.Columns(4).HeaderText = My.Resources.Resource.VOLUME
            dt_gridview.Columns(5).HeaderText = My.Resources.Resource.CBNCODE
            dt_gridview.Columns(6).HeaderText = My.Resources.Resource.BATCHESNO
            dt_grid_Executing.Columns(0).HeaderText = My.Resources.Resource.No_
            dt_grid_Executing.Columns(1).HeaderText = My.Resources.Resource.ORDERCODE
            dt_grid_Executing.Columns(2).HeaderText = My.Resources.Resource.NAME
            dt_grid_Executing.Columns(3).HeaderText = My.Resources.Resource.CARNO
            dt_grid_Executing.Columns(4).HeaderText = My.Resources.Resource.VOLUME
            dt_grid_Executing.Columns(5).HeaderText = My.Resources.Resource.CBNCODE
            dt_grid_Executing.Columns(6).HeaderText = My.Resources.Resource.BATCHESNO
            dt_grid_Executing.Columns(7).HeaderText = My.Resources.Resource.BATCHEXE
        Catch
        End Try
    End Sub
    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click

        Dim ad As Integer = 0
        If IsExecuting Then
            ad = 1
        End If
        Dim frm As Delete = New Delete(order, CurrentMouseOverRow + ad)
        frm.ShowDialog()
        UpdateData()
    End Sub
    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        Try

            Dim ad As Integer = 0
            If IsExecuting Then
                ad = 1
            End If
            Dim frm As Edit = New Edit(order, dt_gridview.CurrentCell.RowIndex + ad)
            frm.ShowDialog()
            UpdateData()
        Catch
        End Try
    End Sub
    Private Sub dt_gridview_MouseClick(sender As Object, e As MouseEventArgs) Handles dt_gridview.MouseClick
        If e.Button = MouseButtons.Right Then
            CurrentMouseOverRow = dt_gridview.HitTest(e.X, e.Y).RowIndex
            If CurrentMouseOverRow >= 0 Then
                ContextMenuStrip1.Show(dt_gridview, e.Location)
            End If
        End If
    End Sub
    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Dim ad As Integer = 0
        If IsExecuting Then
            ad = 1
        End If
        If e.ClickedItem.Name = ToolStripMenuItem1.Name Then
            Try
                Dim frm As Edit = New Edit(order, CurrentMouseOverRow + ad)
                frm.ShowDialog()
                UpdateData()
            Catch
            End Try
        ElseIf e.ClickedItem.Name = ToolStripMenuItem2.Name Then
            Try
                Dim frm As Delete = New Delete(order, CurrentMouseOverRow + ad)
                frm.ShowDialog()
                UpdateData()
            Catch
            End Try
        ElseIf e.ClickedItem.Name = Detail.Name Then
            Try
                Dim frm As Batch = New Batch(order, CurrentMouseOverRow + ad)
                frm.ShowDialog()
            Catch
            End Try
        End If
    End Sub
    Private Sub bt_Mixer_Click(sender As Object, e As EventArgs) Handles bt_Mixer.Click
        Dim frm As Mixer = New Mixer
        frm.ShowDialog()
    End Sub
    Private Sub bt_detail_Click(sender As Object, e As EventArgs) Handles bt_detail.Click
        Try
            Dim ad As Integer = 0
            If IsExecuting Then
                ad = 1
            End If
            Dim frm As Batch = New Batch(order, CurrentMouseOverRow + ad)
            frm.ShowDialog()
        Catch
        End Try
    End Sub

    Private Sub ContextMenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip2.ItemClicked
        If e.ClickedItem.Text = "Detail" Then
            Try
                Dim frm As Batch = New Batch(order, 0)
                frm.ShowDialog()
            Catch
            End Try
        End If
    End Sub

    Private Sub dt_grid_Executing_MouseClick(sender As Object, e As MouseEventArgs) Handles dt_grid_Executing.MouseClick
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip2.Show(dt_grid_Executing, e.Location)
        End If
    End Sub
    Private Sub UpdateLCValue()
        Dim bByte(11) As Byte
        MCRequestDat("D10", 6, bByte)
        LoadCellValue = GetLongArray(bByte, bByte.Length)
        Dim lc As LoadCell_Tbl = New LoadCell_Tbl
        lc.GetLoadCellbyCode(0)
        Lb_Gvalue.Text = IntToStr(LoadCellValue(0), lc.DecPoint)
        lc.GetLoadCellbyCode(1)
        Lb_Svalue.Text = IntToStr(LoadCellValue(1), lc.DecPoint)
        lc.GetLoadCellbyCode(2)
        Lb_Cvalue.Text = IntToStr(LoadCellValue(2), lc.DecPoint)
        lc.GetLoadCellbyCode(3)
        Lb_Avalue.Text = IntToStr(LoadCellValue(3), lc.DecPoint)
        lc.GetLoadCellbyCode(4)
        Lb_Wvalue.Text = IntToStr(LoadCellValue(4), lc.DecPoint)
    End Sub
    Private Sub UpdateLCValueDone()
        Dim bByte(11) As Byte
        MCRequestDat("D50", 6, bByte)
        LoadcellValueDone = GetLongArray(bByte, bByte.Length)
        Dim lc As LoadCell_Tbl = New LoadCell_Tbl
        lc.GetLoadCellbyCode(0)
        Lb_GValueDone.Text = IntToStr(LoadcellValueDone(0), lc.DecPoint)
        lc.GetLoadCellbyCode(1)
        Lb_SValueDone.Text = IntToStr(LoadcellValueDone(1), lc.DecPoint)
        lc.GetLoadCellbyCode(2)
        Lb_CValueDone.Text = IntToStr(LoadcellValueDone(2), lc.DecPoint)
        lc.GetLoadCellbyCode(3)
        Lb_AValueDone.Text = IntToStr(LoadcellValueDone(3), lc.DecPoint)
        lc.GetLoadCellbyCode(4)
        Lb_WValueDone.Text = IntToStr(LoadcellValueDone(4), lc.DecPoint)
    End Sub
    Private Sub UpdateMaterialValue()
        Dim bByte(47) As Byte
        MCRequestDat("D20", 24, bByte)
        MaterialValue = GetLongArray(bByte, bByte.Length)
        Dim lc As LoadCell_Tbl = New LoadCell_Tbl
        lc.GetLoadCellbyCode(0)
        Lb_G1value.Text = IntToStr(MaterialValue(0), lc.DecPoint)
        Lb_G2value.Text = IntToStr(MaterialValue(1), lc.DecPoint)
        lc.GetLoadCellbyCode(1)
        Lb_S1value.Text = IntToStr(MaterialValue(4), lc.DecPoint)
        Lb_S2value.Text = IntToStr(MaterialValue(5), lc.DecPoint)
        lc.GetLoadCellbyCode(2)
        Lb_C1value.Text = IntToStr(MaterialValue(8), lc.DecPoint)
        Lb_C2value.Text = IntToStr(MaterialValue(9), lc.DecPoint)
        Lb_C3value.Text = IntToStr(MaterialValue(10), lc.DecPoint)
        lc.GetLoadCellbyCode(3)
        Lb_A1value.Text = IntToStr(MaterialValue(12), lc.DecPoint)
        Lb_A2value.Text = IntToStr(MaterialValue(13), lc.DecPoint)
        Lb_A3value.Text = IntToStr(MaterialValue(14), lc.DecPoint)
        lc.GetLoadCellbyCode(4)
        Lb_W1value.Text = IntToStr(MaterialValue(16), lc.DecPoint)
    End Sub
    Private Sub UpdateMaterialValueDone()
        Dim bByte(47) As Byte
        MCRequestDat("D60", 24, bByte)
        MaterialValueDone = GetLongArray(bByte, bByte.Length)
        Dim lc As LoadCell_Tbl = New LoadCell_Tbl
        lc.GetLoadCellbyCode(0)
        Lb_G1ValueDone.Text = IntToStr(MaterialValueDone(0), lc.DecPoint)
        Lb_G2ValueDone.Text = IntToStr(MaterialValueDone(1), lc.DecPoint)
        lc.GetLoadCellbyCode(1)
        Lb_S1ValueDone.Text = IntToStr(MaterialValueDone(4), lc.DecPoint)
        Lb_S2ValueDone.Text = IntToStr(MaterialValueDone(5), lc.DecPoint)
        lc.GetLoadCellbyCode(2)
        Lb_C1ValueDone.Text = IntToStr(MaterialValueDone(8), lc.DecPoint)
        Lb_C2ValueDone.Text = IntToStr(MaterialValueDone(9), lc.DecPoint)
        Lb_C3ValueDone.Text = IntToStr(MaterialValueDone(10), lc.DecPoint)
        lc.GetLoadCellbyCode(3)
        Lb_A1ValueDone.Text = IntToStr(MaterialValueDone(12), lc.DecPoint)
        Lb_A2ValueDone.Text = IntToStr(MaterialValueDone(13), lc.DecPoint)
        Lb_A3ValueDone.Text = IntToStr(MaterialValueDone(14), lc.DecPoint)
        lc.GetLoadCellbyCode(4)
        Lb_W1ValueDone.Text = IntToStr(MaterialValueDone(16), lc.DecPoint)
    End Sub
    Private Sub UpdateOrder()
        Dim bByte(47) As Byte
        MCRequestDat("D220", 24, bByte)
        OrderValue = GetLongArray(bByte, bByte.Length)
        Dim lc As LoadCell_Tbl = New LoadCell_Tbl
        lc.GetLoadCellbyCode(0)
        Lb_G1Order.Text = IntToStr(OrderValue(0), lc.DecPoint)
        Lb_G2Order.Text = IntToStr(OrderValue(1), lc.DecPoint)
        lc.GetLoadCellbyCode(1)
        Lb_S1Order.Text = IntToStr(OrderValue(4), lc.DecPoint)
        Lb_S2Order.Text = IntToStr(OrderValue(5), lc.DecPoint)
        lc.GetLoadCellbyCode(2)
        Lb_C1Order.Text = IntToStr(OrderValue(8), lc.DecPoint)
        Lb_C2Order.Text = IntToStr(OrderValue(9), lc.DecPoint)
        Lb_C3Order.Text = IntToStr(OrderValue(10), lc.DecPoint)
        lc.GetLoadCellbyCode(3)
        Lb_A1Order.Text = IntToStr(OrderValue(12), lc.DecPoint)
        Lb_A2Order.Text = IntToStr(OrderValue(13), lc.DecPoint)
        Lb_A3Order.Text = IntToStr(OrderValue(14), lc.DecPoint)
        lc.GetLoadCellbyCode(4)
        Lb_W1Order.Text = IntToStr(OrderValue(16), lc.DecPoint)
    End Sub
    Private Sub WriteOrderG()
        MCSendData("D220", 2, {OrderValue(0), OrderValue(1)})
    End Sub
    Private Sub WriteOrderS()
        MCSendData("D224", 2, {OrderValue(4), OrderValue(5)})
    End Sub
    Private Sub WriteOrderC()
        MCSendData("D228", 3, {OrderValue(8), OrderValue(9), OrderValue(10)})
    End Sub
    Private Sub WriteOrderA()
        MCSendData("D232", 3, {OrderValue(12), OrderValue(13), OrderValue(14)})
    End Sub
    Private Sub WriteOrderW()
        MCSendData("D236", 1, {OrderValue(16)})
    End Sub

    Private Sub ReadGate()
        Dim bByte(5) As Byte
        MCRequestDat("M500", 3, bByte)
        '------------------------------
        If bByte(0) And &H1 Then
            'Gate_G1 = 2
            Pic_G1.Image = My.Resources.Fine
        ElseIf bByte(3) And &H1 Then
            'Gate_G1 = 1
            Pic_G1.Image = My.Resources.Rough
        Else
            'Gate_G1 = 0
            Pic_G1.Image = My.Resources.None
        End If

        If bByte(0) And &H2 Then
            'Gate_G2 = 2
            Pic_G2.Image = My.Resources.Fine
        ElseIf bByte(3) And &H2 Then
            'Gate_G2 = 1
            Pic_G2.Image = My.Resources.Rough
        Else
            'Gate_G2 = 0
            Pic_G2.Image = My.Resources.None
        End If
        '------------------------------
        If bByte(0) And &H10 Then
            'Gate_S1 = 2
            Pic_S1.Image = My.Resources.Fine
        ElseIf bByte(3) And &H10 Then
            'Gate_S1 = 1
            Pic_S1.Image = My.Resources.Rough
        Else
            'Gate_S1 = 0
            Pic_S1.Image = My.Resources.None
        End If

        If bByte(0) And &H20 Then
            'Gate_S2 = 2
            Pic_S2.Image = My.Resources.Fine
        ElseIf bByte(3) And &H20 Then
            'Gate_S2 = 1
            Pic_S2.Image = My.Resources.Rough
        Else
            'Gate_S2 = 0
            Pic_S2.Image = My.Resources.None
        End If
        '------------------------------
        If bByte(1) And &H1 Then
            'Gate_C1 = 2
            Pic_C1.Image = My.Resources.Fine
        ElseIf bByte(4) And &H1 Then
            'Gate_C1 = 1
            Pic_C1.Image = My.Resources.Rough
        Else
            'Gate_C1 = 0
            Pic_C1.Image = My.Resources.None
        End If

        If bByte(1) And &H2 Then
            'Gate_C2 = 2
            Pic_C2.Image = My.Resources.Fine
        ElseIf bByte(4) And &H2 Then
            'Gate_C2 = 1
            Pic_C2.Image = My.Resources.Rough
        Else
            'Gate_C2 = 0
            Pic_C2.Image = My.Resources.None
        End If

        If bByte(1) And &H4 Then
            'Gate_C3 = 2
            Pic_C3.Image = My.Resources.Fine
        ElseIf bByte(4) And &H4 Then
            'Gate_C3 = 1
            Pic_C3.Image = My.Resources.Rough
        Else
            'Gate_C3 = 0
            Pic_C3.Image = My.Resources.None
        End If
        '------------------------------
        If bByte(1) And &H10 Then
            'Gate_A1 = 2
            Pic_A1.Image = My.Resources.Fine
        ElseIf bByte(4) And &H10 Then
            'Gate_A1 = 1
            Pic_A1.Image = My.Resources.Rough
        Else
            'Gate_A1 = 0
            Pic_A1.Image = My.Resources.None
        End If

        If bByte(1) And &H20 Then
            'Gate_A2 = 2
            Pic_A2.Image = My.Resources.Fine
        ElseIf bByte(4) And &H20 Then
            'Gate_A2 = 1
            Pic_A2.Image = My.Resources.Rough
        Else
            'Gate_A2 = 0
            Pic_A2.Image = My.Resources.None
        End If

        If bByte(1) And &H40 Then
            'Gate_A3 = 2
            Pic_A3.Image = My.Resources.Fine
        ElseIf bByte(4) And &H40 Then
            'Gate_A3 = 1
            Pic_A3.Image = My.Resources.Rough
        Else
            'Gate_A3 = 0
            Pic_A3.Image = My.Resources.None
        End If
        '------------------------------
        If bByte(2) And &H1 Then
            'Gate_W1 = 2
            Pic_W1.Image = My.Resources.Fine
        ElseIf bByte(5) And &H1 Then
            'Gate_W1 = 1
            Pic_W1.Image = My.Resources.Rough
        Else
            'Gate_W1 = 0
            Pic_W1.Image = My.Resources.None
        End If
        '====================================
        Dim bByte2(1) As Byte
        MCRequestDat("M550", 1, bByte2)
        If bByte2(0) And &H1 Then
            'Gate_G = 1
            Pic_G.Image = My.Resources.Rough
        Else
            'Gate_G = 0
            Pic_G.Image = My.Resources.None
        End If
        '--------------------------
        If bByte2(0) And &H2 Then
            'Gate_S = 1
            Pic_S.Image = My.Resources.Rough
        Else
            'Gate_S = 0
            Pic_S.Image = My.Resources.None
        End If
        '--------------------------
        If bByte2(0) And &H4 Then
            'Gate_C = 1
            Pic_C.Image = My.Resources.Rough
        Else
            'Gate_C = 0
            Pic_C.Image = My.Resources.None
        End If
        '--------------------------
        If bByte2(0) And &H8 Then
            'Gate_A = 1
            Pic_A.Image = My.Resources.Rough
        Else
            'Gate_A = 0
            Pic_A.Image = My.Resources.None
        End If
        '--------------------------
        If bByte2(0) And &H10 Then
            'Gate_W = 1
            Pic_W.Image = My.Resources.Rough
        Else
            'Gate_W = 0
            Pic_W.Image = My.Resources.None
        End If
        '--------------------------
        ' VIB =============================
        Dim bByte3(3) As Byte
        MCRequestDat("M560", 2, bByte3)
        If bByte3(0) And &H1 Then
            'Gate_G1VIB = 1
            Pic_VIB_G1.Image = My.Resources.LedON
        Else
            'Gate_G1VIB = 0
            Pic_VIB_G1.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(0) And &H2 Then
            'Gate_G2VIB = 1
            Pic_VIB_G2.Image = My.Resources.LedON
        Else
            'Gate_G2VIB = 0
            Pic_VIB_G2.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(0) And &H10 Then
            'Gate_S1VIB = 1
            Pic_VIB_S1.Image = My.Resources.LedON
        Else
            'Gate_S1VIB = 0
            Pic_VIB_S1.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(0) And &H20 Then
            'Gate_S2VIB = 1
            Pic_VIB_S2.Image = My.Resources.LedON
        Else
            'Gate_S2VIB = 0
            Pic_VIB_S2.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(1) And &H1 Then
            'Gate_C1VIB = 1
            Pic_VIB_C1.Image = My.Resources.LedON
        Else
            'Gate_C1VIB = 0
            Pic_VIB_C1.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(1) And &H2 Then
            'Gate_C2VIB = 1
            Pic_VIB_C2.Image = My.Resources.LedON
        Else
            'Gate_C2VIB = 0
            Pic_VIB_C2.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(1) And &H4 Then
            'Gate_C3VIB = 1
            Pic_VIB_C3.Image = My.Resources.LedON
        Else
            'Gate_C3VIB = 0
            Pic_VIB_C3.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(1) And &H10 Then
            'Gate_A1VIB = 1
            Pic_VIB_A1.Image = My.Resources.LedON
        Else
            'Gate_A1VIB = 0
            Pic_VIB_A1.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(1) And &H20 Then
            ' Gate_A2VIB = 1
            Pic_VIB_A2.Image = My.Resources.LedON
        Else
            'Gate_A2VIB = 0
            Pic_VIB_A2.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(1) And &H40 Then
            'Gate_A3VIB = 1
            Pic_VIB_A3.Image = My.Resources.LedON
        Else
            'Gate_A3VIB = 0
            Pic_VIB_A3.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(2) And &H1 Then
            'Gate_W1VIB = 1
            Pic_VIB_W1.Image = My.Resources.LedON
        Else
            'Gate_W1VIB = 0
            Pic_VIB_W1.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(3) And &H1 Then
            'Gate_G_VIB = 1
            Pic_VIB_G.Image = My.Resources.LedON
        Else
            ' Gate_G_VIB = 0
            Pic_VIB_G.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(3) And &H2 Then
            ' Gate_S_VIB = 1
            Pic_VIB_S.Image = My.Resources.LedON
        Else
            ' Gate_S_VIB = 0
            Pic_VIB_S.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(3) And &H4 Then
            ' Gate_C_VIB = 1
            Pic_VIB_C.Image = My.Resources.LedON
        Else
            ' Gate_C_VIB = 0
            Pic_VIB_C.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(3) And &H8 Then
            'Gate_A_VIB = 1
            Pic_VIB_A.Image = My.Resources.LedON
        Else
            'Gate_A_VIB = 0
            Pic_VIB_A.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte3(3) And &H10 Then
            'Gate_W_VIB = 1
            Pic_VIB_W.Image = My.Resources.LedON
        Else
            'Gate_W_VIB = 0
            Pic_VIB_W.Image = My.Resources.LedOFF
        End If
        '---------------------------
        '==============================
        Dim bByte4(1) As Byte
        MCRequestDat("M609", 1, bByte4)
        If bByte4(0) And &H1 Then
            'Gate_Mixer = 1
            Pic_MixerOpen.Image = My.Resources.Rough
        Else
            'Mixer_ON = 0
            Pic_MixerOpen.Image = My.Resources.None
        End If
        '---------------------------
        If bByte4(0) And &H2 Then
            'Mixer_ON = 1
            Pic_MixerON.Image = My.Resources.LedON
        Else
            'Mixer_ON = 0
            Pic_MixerON.Image = Nothing
        End If
        '---------------------------
        If bByte4(0) And &H4 Then
            'Conveyer_ON = 1
            Pic_ConveyerON.Image = My.Resources.LedON
        Else
            'Conveyer_ON = 0
            Pic_ConveyerON.Image = My.Resources.LedOFF
        End If
        '---------------------------
        If bByte4(0) And &H8 Then
            'Gate_Temp = 1
            Pic_Temp.Image = My.Resources.LedON
        Else
            ' Gate_Temp = 0
            Pic_Temp.Image = My.Resources.LedOFF
        End If

    End Sub
    Private Sub UpdateTimer()

        Lb_drymix_timer.Text = IntToStr(PLCGetLong("D3000"))
        Lb_TranferTime.Text = IntToStr(PLCGetLong("D3001"))
        Lb_OpenMixerTimer.Text = IntToStr(PLCGetLong("D3008"))
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ReadGate()
        UpdateData()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        UpdateTimer()
        UpdateMaterialValue()
        UpdateMaterialValueDone()
        UpdateLCValue()
        UpdateLCValueDone()
        UpdateOrder()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsExecuting Then
            IsExecuting = 0
        Else
            IsExecuting = 1
        End If
    End Sub
End Class