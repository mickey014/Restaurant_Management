<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class last_transaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lst_trns_cash = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lst_trns_num = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lst_trns_change = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(953, 67)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(883, 8)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 52)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 54)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cash:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(173, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 54)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Change:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 405)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 54)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Transaction #:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 493)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(953, 67)
        Me.Panel2.TabIndex = 3
        '
        'lst_trns_cash
        '
        Me.lst_trns_cash.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lst_trns_cash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_trns_cash.Enabled = False
        Me.lst_trns_cash.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_trns_cash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lst_trns_cash.Location = New System.Drawing.Point(365, 174)
        Me.lst_trns_cash.Name = "lst_trns_cash"
        Me.lst_trns_cash.Size = New System.Drawing.Size(482, 48)
        Me.lst_trns_cash.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(365, 228)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(482, 3)
        Me.Panel3.TabIndex = 5
        '
        'lst_trns_num
        '
        Me.lst_trns_num.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lst_trns_num.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_trns_num.Enabled = False
        Me.lst_trns_num.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_trns_num.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lst_trns_num.Location = New System.Drawing.Point(365, 411)
        Me.lst_trns_num.Name = "lst_trns_num"
        Me.lst_trns_num.Size = New System.Drawing.Size(482, 48)
        Me.lst_trns_num.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(365, 465)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(482, 3)
        Me.Panel4.TabIndex = 5
        '
        'lst_trns_change
        '
        Me.lst_trns_change.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lst_trns_change.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_trns_change.Enabled = False
        Me.lst_trns_change.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_trns_change.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lst_trns_change.Location = New System.Drawing.Point(365, 276)
        Me.lst_trns_change.Name = "lst_trns_change"
        Me.lst_trns_change.Size = New System.Drawing.Size(482, 48)
        Me.lst_trns_change.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(365, 330)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(482, 3)
        Me.Panel5.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(310, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Press enter key to continue..."
        '
        'last_transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(953, 559)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lst_trns_change)
        Me.Controls.Add(Me.lst_trns_num)
        Me.Controls.Add(Me.lst_trns_cash)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "last_transaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lst_trns_cash As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lst_trns_num As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lst_trns_change As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
End Class
