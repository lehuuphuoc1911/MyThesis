Imports System.Globalization
Imports ConcretePlant.Setting
Public Class Mixer
    Private Sub Mixer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBounds((Screen.GetWorkingArea(Me).Width - Width) / 2, (Screen.GetWorkingArea(Me).Height - Height) / 2, Width, Height)
        My.Resources.Resource.Culture = New CultureInfo(__Language)
        Lb_MixerStep.Text = My.Resources.Resource.MIXSTEP
        Lb_MixerVol.Text = My.Resources.Resource.MIXVOL
        bt_Save.Text = My.Resources.Resource.SAVE
        Text = My.Resources.Resource.bt_Mixer_ope
        'If __Language Then
        '    Lb_MixerStep.Text = "MIXER STEP"
        '    Lb_MixerVol.Text = "MIXER VOLUME"
        '    bt_Save.Text = "SAVE"
        'Else
        '    Lb_MixerStep.Text = "ĐỘ CHIA"
        '    Lb_MixerVol.Text = "DUNG TÍCH TỐI ĐA"
        '    bt_Save.Text = "SAVE"
        'End If
        tb_MixerStep.Text = IntToStr(__MixerStep)
        tb_MixerVol.Text = IntToStr(__MixerVolume)
    End Sub
    Private Sub bt_Save_Click(sender As Object, e As EventArgs) Handles bt_Save.Click
        Try
            Dim vol_ As Integer = StrToInt(tb_MixerVol.Text)
            Dim step_ As Integer = StrToInt(tb_MixerStep.Text)
            __MixerVolume = vol_
            __MixerStep = step_
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Invalid number format")
        End Try
    End Sub
End Class