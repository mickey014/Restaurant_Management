<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add_admin
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
        Me.btn_add_admin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_add_admin_tag = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_add_admin_pass = New System.Windows.Forms.TextBox()
        Me.txt_add_admin_name = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_add_admin
        '
        Me.btn_add_admin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_add_admin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_admin.Location = New System.Drawing.Point(503, 430)
        Me.btn_add_admin.Name = "btn_add_admin"
        Me.btn_add_admin.Size = New System.Drawing.Size(142, 42)
        Me.btn_add_admin.TabIndex = 7
        Me.btn_add_admin.Text = "ADD"
        Me.btn_add_admin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(265, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(265, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(825, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 52)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_add_admin_tag
        '
        Me.txt_add_admin_tag.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_add_admin_tag.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add_admin_tag.ForeColor = System.Drawing.Color.White
        Me.txt_add_admin_tag.Location = New System.Drawing.Point(269, 152)
        Me.txt_add_admin_tag.Name = "txt_add_admin_tag"
        Me.txt_add_admin_tag.Size = New System.Drawing.Size(374, 39)
        Me.txt_add_admin_tag.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(265, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 28)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "RFID tag:"
        '
        'txt_add_admin_pass
        '
        Me.txt_add_admin_pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_add_admin_pass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add_admin_pass.ForeColor = System.Drawing.Color.White
        Me.txt_add_admin_pass.Location = New System.Drawing.Point(271, 363)
        Me.txt_add_admin_pass.Name = "txt_add_admin_pass"
        Me.txt_add_admin_pass.Size = New System.Drawing.Size(374, 39)
        Me.txt_add_admin_pass.TabIndex = 13
        '
        'txt_add_admin_name
        '
        Me.txt_add_admin_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_add_admin_name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add_admin_name.ForeColor = System.Drawing.Color.White
        Me.txt_add_admin_name.Location = New System.Drawing.Point(269, 258)
        Me.txt_add_admin_name.Name = "txt_add_admin_name"
        Me.txt_add_admin_name.Size = New System.Drawing.Size(374, 39)
        Me.txt_add_admin_name.TabIndex = 14
        '
        'add_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 615)
        Me.Controls.Add(Me.txt_add_admin_name)
        Me.Controls.Add(Me.txt_add_admin_pass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_add_admin_tag)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_add_admin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_admin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_add_admin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_add_admin_tag As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_add_admin_pass As TextBox
    Friend WithEvents txt_add_admin_name As TextBox
End Class
