<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add_update_ctg
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
        Me.btn_addcat = New System.Windows.Forms.Button()
        Me.txt_ctg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_updatecat1 = New System.Windows.Forms.Button()
        Me.cat_id = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_addcat
        '
        Me.btn_addcat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_addcat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addcat.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addcat.ForeColor = System.Drawing.Color.White
        Me.btn_addcat.Location = New System.Drawing.Point(71, 211)
        Me.btn_addcat.Name = "btn_addcat"
        Me.btn_addcat.Size = New System.Drawing.Size(114, 42)
        Me.btn_addcat.TabIndex = 0
        Me.btn_addcat.Text = "Add"
        Me.btn_addcat.UseVisualStyleBackColor = False
        '
        'txt_ctg
        '
        Me.txt_ctg.BackColor = System.Drawing.Color.White
        Me.txt_ctg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ctg.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ctg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_ctg.Location = New System.Drawing.Point(79, 133)
        Me.txt_ctg.Name = "txt_ctg"
        Me.txt_ctg.Size = New System.Drawing.Size(341, 39)
        Me.txt_ctg.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(73, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 32)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Category Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkRed
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(433, 14)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 52)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(200, 211)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 42)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btn_updatecat1
        '
        Me.btn_updatecat1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_updatecat1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_updatecat1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updatecat1.ForeColor = System.Drawing.Color.White
        Me.btn_updatecat1.Location = New System.Drawing.Point(71, 210)
        Me.btn_updatecat1.Name = "btn_updatecat1"
        Me.btn_updatecat1.Size = New System.Drawing.Size(114, 42)
        Me.btn_updatecat1.TabIndex = 0
        Me.btn_updatecat1.Text = "Save"
        Me.btn_updatecat1.UseVisualStyleBackColor = False
        '
        'cat_id
        '
        Me.cat_id.AutoSize = True
        Me.cat_id.Location = New System.Drawing.Point(400, 232)
        Me.cat_id.Name = "cat_id"
        Me.cat_id.Size = New System.Drawing.Size(52, 20)
        Me.cat_id.TabIndex = 22
        Me.cat_id.Text = "cat_id"
        '
        'add_update_ctg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(543, 317)
        Me.Controls.Add(Me.cat_id)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_ctg)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_updatecat1)
        Me.Controls.Add(Me.btn_addcat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_update_ctg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_addcat As Button
    Friend WithEvents txt_ctg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_updatecat1 As Button
    Friend WithEvents cat_id As Label
End Class
