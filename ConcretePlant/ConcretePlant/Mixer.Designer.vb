<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mixer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lb_MixerVol = New System.Windows.Forms.Label()
        Me.tb_MixerVol = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_MixerStep = New System.Windows.Forms.TextBox()
        Me.Lb_MixerStep = New System.Windows.Forms.Label()
        Me.bt_Save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lb_MixerVol
        '
        Me.Lb_MixerVol.AutoSize = True
        Me.Lb_MixerVol.Location = New System.Drawing.Point(20, 60)
        Me.Lb_MixerVol.Name = "Lb_MixerVol"
        Me.Lb_MixerVol.Size = New System.Drawing.Size(89, 13)
        Me.Lb_MixerVol.TabIndex = 0
        Me.Lb_MixerVol.Text = "MIXER VOLUME"
        '
        'tb_MixerVol
        '
        Me.tb_MixerVol.Location = New System.Drawing.Point(135, 57)
        Me.tb_MixerVol.Name = "tb_MixerVol"
        Me.tb_MixerVol.Size = New System.Drawing.Size(100, 20)
        Me.tb_MixerVol.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "M3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "M3"
        '
        'tb_MixerStep
        '
        Me.tb_MixerStep.Location = New System.Drawing.Point(135, 98)
        Me.tb_MixerStep.Name = "tb_MixerStep"
        Me.tb_MixerStep.Size = New System.Drawing.Size(100, 20)
        Me.tb_MixerStep.TabIndex = 4
        '
        'Lb_MixerStep
        '
        Me.Lb_MixerStep.AutoSize = True
        Me.Lb_MixerStep.Location = New System.Drawing.Point(20, 101)
        Me.Lb_MixerStep.Name = "Lb_MixerStep"
        Me.Lb_MixerStep.Size = New System.Drawing.Size(72, 13)
        Me.Lb_MixerStep.TabIndex = 3
        Me.Lb_MixerStep.Text = "MIXER STEP"
        '
        'bt_Save
        '
        Me.bt_Save.Location = New System.Drawing.Point(125, 134)
        Me.bt_Save.Name = "bt_Save"
        Me.bt_Save.Size = New System.Drawing.Size(100, 33)
        Me.bt_Save.TabIndex = 6
        Me.bt_Save.Text = "SAVE"
        Me.bt_Save.UseVisualStyleBackColor = True
        '
        'Mixer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 191)
        Me.Controls.Add(Me.bt_Save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_MixerStep)
        Me.Controls.Add(Me.Lb_MixerStep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_MixerVol)
        Me.Controls.Add(Me.Lb_MixerVol)
        Me.Name = "Mixer"
        Me.Text = "MIXER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb_MixerVol As Label
    Friend WithEvents tb_MixerVol As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_MixerStep As TextBox
    Friend WithEvents Lb_MixerStep As Label
    Friend WithEvents bt_Save As Button
End Class
