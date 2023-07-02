<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class disc_form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.disc_numdropdwn = New System.Windows.Forms.NumericUpDown()
        CType(Me.disc_numdropdwn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(68, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Discount %:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(447, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 52)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'disc_numdropdwn
        '
        Me.disc_numdropdwn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.disc_numdropdwn.DecimalPlaces = 2
        Me.disc_numdropdwn.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disc_numdropdwn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.disc_numdropdwn.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.disc_numdropdwn.Location = New System.Drawing.Point(75, 165)
        Me.disc_numdropdwn.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.disc_numdropdwn.Minimum = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.disc_numdropdwn.Name = "disc_numdropdwn"
        Me.disc_numdropdwn.Size = New System.Drawing.Size(342, 50)
        Me.disc_numdropdwn.TabIndex = 13
        Me.disc_numdropdwn.Value = New Decimal(New Integer() {25, 0, 0, 131072})
        '
        'disc_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(522, 328)
        Me.ControlBox = False
        Me.Controls.Add(Me.disc_numdropdwn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "disc_form"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.disc_numdropdwn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents disc_numdropdwn As NumericUpDown
End Class
