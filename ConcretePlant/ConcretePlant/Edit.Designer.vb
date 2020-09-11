<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbx_No = New System.Windows.Forms.TextBox()
        Me.tbx_OrderCode = New System.Windows.Forms.TextBox()
        Me.lb_CbnCode = New System.Windows.Forms.Label()
        Me.lb_No = New System.Windows.Forms.Label()
        Me.lb_Volume = New System.Windows.Forms.Label()
        Me.lb_Name = New System.Windows.Forms.Label()
        Me.lb_CarNo = New System.Windows.Forms.Label()
        Me.lb_OrderCode = New System.Windows.Forms.Label()
        Me.tbx_Name = New System.Windows.Forms.TextBox()
        Me.tbx_CarNo = New System.Windows.Forms.TextBox()
        Me.tbx_Volume = New System.Windows.Forms.TextBox()
        Me.tbx_CbnCode = New System.Windows.Forms.TextBox()
        Me.bt_edit = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_No, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_OrderCode, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_CbnCode, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_No, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_Volume, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_Name, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_CarNo, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_OrderCode, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_Name, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_CarNo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_Volume, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_CbnCode, 1, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 56)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(239, 193)
        Me.TableLayoutPanel1.TabIndex = 26
        '
        'tbx_No
        '
        Me.tbx_No.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_No.Enabled = False
        Me.tbx_No.Location = New System.Drawing.Point(123, 6)
        Me.tbx_No.Name = "tbx_No"
        Me.tbx_No.Size = New System.Drawing.Size(111, 20)
        Me.tbx_No.TabIndex = 22
        '
        'tbx_OrderCode
        '
        Me.tbx_OrderCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_OrderCode.Enabled = False
        Me.tbx_OrderCode.Location = New System.Drawing.Point(123, 37)
        Me.tbx_OrderCode.Name = "tbx_OrderCode"
        Me.tbx_OrderCode.Size = New System.Drawing.Size(111, 20)
        Me.tbx_OrderCode.TabIndex = 12
        '
        'lb_CbnCode
        '
        Me.lb_CbnCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_CbnCode.Location = New System.Drawing.Point(2, 160)
        Me.lb_CbnCode.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.lb_CbnCode.Name = "lb_CbnCode"
        Me.lb_CbnCode.Size = New System.Drawing.Size(116, 28)
        Me.lb_CbnCode.TabIndex = 21
        Me.lb_CbnCode.Text = "COMBINE CODE"
        Me.lb_CbnCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_No
        '
        Me.lb_No.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_No.Location = New System.Drawing.Point(2, 5)
        Me.lb_No.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.lb_No.Name = "lb_No"
        Me.lb_No.Size = New System.Drawing.Size(116, 23)
        Me.lb_No.TabIndex = 23
        Me.lb_No.Text = "No"
        Me.lb_No.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_Volume
        '
        Me.lb_Volume.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_Volume.Location = New System.Drawing.Point(2, 129)
        Me.lb_Volume.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.lb_Volume.Name = "lb_Volume"
        Me.lb_Volume.Size = New System.Drawing.Size(116, 23)
        Me.lb_Volume.TabIndex = 19
        Me.lb_Volume.Text = "VOLUME"
        Me.lb_Volume.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_Name
        '
        Me.lb_Name.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_Name.Location = New System.Drawing.Point(2, 67)
        Me.lb_Name.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.lb_Name.Name = "lb_Name"
        Me.lb_Name.Size = New System.Drawing.Size(116, 23)
        Me.lb_Name.TabIndex = 15
        Me.lb_Name.Text = "NAME"
        Me.lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_CarNo
        '
        Me.lb_CarNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_CarNo.Location = New System.Drawing.Point(2, 98)
        Me.lb_CarNo.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.lb_CarNo.Name = "lb_CarNo"
        Me.lb_CarNo.Size = New System.Drawing.Size(116, 23)
        Me.lb_CarNo.TabIndex = 17
        Me.lb_CarNo.Text = "CAR.No"
        Me.lb_CarNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_OrderCode
        '
        Me.lb_OrderCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_OrderCode.Location = New System.Drawing.Point(2, 36)
        Me.lb_OrderCode.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.lb_OrderCode.Name = "lb_OrderCode"
        Me.lb_OrderCode.Size = New System.Drawing.Size(116, 23)
        Me.lb_OrderCode.TabIndex = 13
        Me.lb_OrderCode.Text = "ORDER CODE"
        Me.lb_OrderCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_Name
        '
        Me.tbx_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Name.Location = New System.Drawing.Point(123, 68)
        Me.tbx_Name.Name = "tbx_Name"
        Me.tbx_Name.Size = New System.Drawing.Size(111, 20)
        Me.tbx_Name.TabIndex = 14
        '
        'tbx_CarNo
        '
        Me.tbx_CarNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_CarNo.Location = New System.Drawing.Point(123, 99)
        Me.tbx_CarNo.Name = "tbx_CarNo"
        Me.tbx_CarNo.Size = New System.Drawing.Size(111, 20)
        Me.tbx_CarNo.TabIndex = 16
        '
        'tbx_Volume
        '
        Me.tbx_Volume.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Volume.Location = New System.Drawing.Point(123, 130)
        Me.tbx_Volume.Name = "tbx_Volume"
        Me.tbx_Volume.Size = New System.Drawing.Size(111, 20)
        Me.tbx_Volume.TabIndex = 18
        '
        'tbx_CbnCode
        '
        Me.tbx_CbnCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_CbnCode.Location = New System.Drawing.Point(123, 164)
        Me.tbx_CbnCode.Name = "tbx_CbnCode"
        Me.tbx_CbnCode.Size = New System.Drawing.Size(111, 20)
        Me.tbx_CbnCode.TabIndex = 20
        '
        'bt_edit
        '
        Me.bt_edit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_edit.Location = New System.Drawing.Point(86, 12)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(120, 25)
        Me.bt_edit.TabIndex = 27
        Me.bt_edit.Text = "EDIT"
        Me.bt_edit.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.bt_edit)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Edit"
        Me.Text = "Edit"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tbx_No As TextBox
    Friend WithEvents tbx_OrderCode As TextBox
    Friend WithEvents lb_CbnCode As Label
    Friend WithEvents lb_No As Label
    Friend WithEvents lb_Volume As Label
    Friend WithEvents lb_Name As Label
    Friend WithEvents lb_CarNo As Label
    Friend WithEvents lb_OrderCode As Label
    Friend WithEvents tbx_Name As TextBox
    Friend WithEvents tbx_CarNo As TextBox
    Friend WithEvents tbx_Volume As TextBox
    Friend WithEvents tbx_CbnCode As TextBox
    Friend WithEvents bt_edit As Button
End Class
