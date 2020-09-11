<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete
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
        Me.bt_no = New System.Windows.Forms.Button()
        Me.bt_yes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bt_no
        '
        Me.bt_no.Location = New System.Drawing.Point(160, 73)
        Me.bt_no.Name = "bt_no"
        Me.bt_no.Size = New System.Drawing.Size(92, 33)
        Me.bt_no.TabIndex = 0
        Me.bt_no.Text = "NO"
        Me.bt_no.UseVisualStyleBackColor = True
        '
        'bt_yes
        '
        Me.bt_yes.Location = New System.Drawing.Point(40, 73)
        Me.bt_yes.Name = "bt_yes"
        Me.bt_yes.Size = New System.Drawing.Size(92, 33)
        Me.bt_yes.TabIndex = 1
        Me.bt_yes.Text = "YES"
        Me.bt_yes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DO YOU WANT TO DELETE THE ORDER"
        '
        'Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 148)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_yes)
        Me.Controls.Add(Me.bt_no)
        Me.Name = "Delete"
        Me.Text = "Delete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_no As Button
    Friend WithEvents bt_yes As Button
    Friend WithEvents Label1 As Label
End Class
