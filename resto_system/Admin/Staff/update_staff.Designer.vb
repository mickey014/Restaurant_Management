<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_staff
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updatetxt_staff_name = New System.Windows.Forms.TextBox()
        Me.txt23 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updatebtn_save = New System.Windows.Forms.Button()
        Me.updatetxt_staff_contact = New System.Windows.Forms.TextBox()
        Me.updatetxt_staff_email = New System.Windows.Forms.TextBox()
        Me.updatetxt_staff_username = New System.Windows.Forms.TextBox()
        Me.hid_staff_id = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(755, 33)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 52)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 65)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Edit User"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(76, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 32)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Contact #:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 32)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Name:"
        '
        'updatetxt_staff_name
        '
        Me.updatetxt_staff_name.BackColor = System.Drawing.Color.White
        Me.updatetxt_staff_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updatetxt_staff_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.updatetxt_staff_name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatetxt_staff_name.Location = New System.Drawing.Point(234, 164)
        Me.updatetxt_staff_name.Name = "updatetxt_staff_name"
        Me.updatetxt_staff_name.Size = New System.Drawing.Size(358, 39)
        Me.updatetxt_staff_name.TabIndex = 71
        '
        'txt23
        '
        Me.txt23.AutoSize = True
        Me.txt23.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt23.Location = New System.Drawing.Point(116, 314)
        Me.txt23.Name = "txt23"
        Me.txt23.Size = New System.Drawing.Size(82, 32)
        Me.txt23.TabIndex = 70
        Me.txt23.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 32)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Username:"
        '
        'updatebtn_save
        '
        Me.updatebtn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.updatebtn_save.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.updatebtn_save.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn_save.ForeColor = System.Drawing.Color.White
        Me.updatebtn_save.Location = New System.Drawing.Point(232, 461)
        Me.updatebtn_save.Name = "updatebtn_save"
        Me.updatebtn_save.Size = New System.Drawing.Size(360, 49)
        Me.updatebtn_save.TabIndex = 66
        Me.updatebtn_save.Text = "Save"
        Me.updatebtn_save.UseVisualStyleBackColor = False
        '
        'updatetxt_staff_contact
        '
        Me.updatetxt_staff_contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updatetxt_staff_contact.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatetxt_staff_contact.Location = New System.Drawing.Point(232, 374)
        Me.updatetxt_staff_contact.Name = "updatetxt_staff_contact"
        Me.updatetxt_staff_contact.Size = New System.Drawing.Size(360, 39)
        Me.updatetxt_staff_contact.TabIndex = 64
        '
        'updatetxt_staff_email
        '
        Me.updatetxt_staff_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updatetxt_staff_email.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatetxt_staff_email.Location = New System.Drawing.Point(234, 307)
        Me.updatetxt_staff_email.Name = "updatetxt_staff_email"
        Me.updatetxt_staff_email.Size = New System.Drawing.Size(358, 39)
        Me.updatetxt_staff_email.TabIndex = 65
        '
        'updatetxt_staff_username
        '
        Me.updatetxt_staff_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updatetxt_staff_username.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatetxt_staff_username.Location = New System.Drawing.Point(234, 235)
        Me.updatetxt_staff_username.Name = "updatetxt_staff_username"
        Me.updatetxt_staff_username.Size = New System.Drawing.Size(358, 39)
        Me.updatetxt_staff_username.TabIndex = 63
        '
        'hid_staff_id
        '
        Me.hid_staff_id.AutoSize = True
        Me.hid_staff_id.Location = New System.Drawing.Point(640, 534)
        Me.hid_staff_id.Name = "hid_staff_id"
        Me.hid_staff_id.Size = New System.Drawing.Size(92, 20)
        Me.hid_staff_id.TabIndex = 75
        Me.hid_staff_id.Text = "hid_staff_id"
        '
        'update_staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(839, 610)
        Me.Controls.Add(Me.hid_staff_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.updatetxt_staff_name)
        Me.Controls.Add(Me.txt23)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.updatebtn_save)
        Me.Controls.Add(Me.updatetxt_staff_contact)
        Me.Controls.Add(Me.updatetxt_staff_email)
        Me.Controls.Add(Me.updatetxt_staff_username)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "update_staff"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "update_staff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents updatetxt_staff_name As TextBox
    Friend WithEvents txt23 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents updatebtn_save As Button
    Friend WithEvents updatetxt_staff_contact As TextBox
    Friend WithEvents updatetxt_staff_email As TextBox
    Friend WithEvents updatetxt_staff_username As TextBox
    Friend WithEvents hid_staff_id As Label
End Class
