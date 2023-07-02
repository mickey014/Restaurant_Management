<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class update_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(update_menu))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.updatesel_img = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt23 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updatebtn_save = New System.Windows.Forms.Button()
        Me.updatetxt_prdprice = New System.Windows.Forms.TextBox()
        Me.updatetxt_prdname = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.updateimg_picbox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updatetxt_prdcode = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.hidprd_id = New System.Windows.Forms.Label()
        Me.updatetxt_catname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.updateimg_picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(252, 65)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Edit Menu"
        '
        'updatesel_img
        '
        Me.updatesel_img.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.updatesel_img.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.updatesel_img.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.updatesel_img.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatesel_img.ForeColor = System.Drawing.Color.White
        Me.updatesel_img.Location = New System.Drawing.Point(621, 474)
        Me.updatesel_img.Name = "updatesel_img"
        Me.updatesel_img.Size = New System.Drawing.Size(362, 48)
        Me.updatesel_img.TabIndex = 53
        Me.updatesel_img.Text = "..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.updatesel_img.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 32)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Category:"
        '
        'txt23
        '
        Me.txt23.AutoSize = True
        Me.txt23.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt23.Location = New System.Drawing.Point(76, 306)
        Me.txt23.Name = "txt23"
        Me.txt23.Size = New System.Drawing.Size(74, 32)
        Me.txt23.TabIndex = 55
        Me.txt23.Text = "Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 32)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Name:"
        '
        'updatebtn_save
        '
        Me.updatebtn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.updatebtn_save.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.updatebtn_save.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn_save.ForeColor = System.Drawing.Color.White
        Me.updatebtn_save.Location = New System.Drawing.Point(176, 473)
        Me.updatebtn_save.Name = "updatebtn_save"
        Me.updatebtn_save.Size = New System.Drawing.Size(360, 49)
        Me.updatebtn_save.TabIndex = 51
        Me.updatebtn_save.Text = "Save"
        Me.updatebtn_save.UseVisualStyleBackColor = False
        '
        'updatetxt_prdprice
        '
        Me.updatetxt_prdprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updatetxt_prdprice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatetxt_prdprice.Location = New System.Drawing.Point(178, 300)
        Me.updatetxt_prdprice.Name = "updatetxt_prdprice"
        Me.updatetxt_prdprice.Size = New System.Drawing.Size(358, 39)
        Me.updatetxt_prdprice.TabIndex = 50
        '
        'updatetxt_prdname
        '
        Me.updatetxt_prdname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updatetxt_prdname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatetxt_prdname.Location = New System.Drawing.Point(178, 228)
        Me.updatetxt_prdname.Name = "updatetxt_prdname"
        Me.updatetxt_prdname.Size = New System.Drawing.Size(358, 39)
        Me.updatetxt_prdname.TabIndex = 48
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(972, 26)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 52)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'updateimg_picbox
        '
        Me.updateimg_picbox.BackgroundImage = Global.resto_system.My.Resources.Resources.No_Product_Image_Available_removebg_preview
        Me.updateimg_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.updateimg_picbox.InitialImage = CType(resources.GetObject("updateimg_picbox.InitialImage"), System.Drawing.Image)
        Me.updateimg_picbox.Location = New System.Drawing.Point(599, 128)
        Me.updateimg_picbox.Name = "updateimg_picbox"
        Me.updateimg_picbox.Size = New System.Drawing.Size(392, 327)
        Me.updateimg_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.updateimg_picbox.TabIndex = 61
        Me.updateimg_picbox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 32)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Code #:"
        '
        'updatetxt_prdcode
        '
        Me.updatetxt_prdcode.BackColor = System.Drawing.SystemColors.Info
        Me.updatetxt_prdcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updatetxt_prdcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.updatetxt_prdcode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatetxt_prdcode.Location = New System.Drawing.Point(178, 157)
        Me.updatetxt_prdcode.Name = "updatetxt_prdcode"
        Me.updatetxt_prdcode.Size = New System.Drawing.Size(358, 39)
        Me.updatetxt_prdcode.TabIndex = 57
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'hidprd_id
        '
        Me.hidprd_id.AutoSize = True
        Me.hidprd_id.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hidprd_id.Location = New System.Drawing.Point(656, 570)
        Me.hidprd_id.Name = "hidprd_id"
        Me.hidprd_id.Size = New System.Drawing.Size(184, 29)
        Me.hidprd_id.TabIndex = 63
        Me.hidprd_id.Text = "hidden_prd_id"
        '
        'updatetxt_catname
        '
        Me.updatetxt_catname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updatetxt_catname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatetxt_catname.Location = New System.Drawing.Point(176, 383)
        Me.updatetxt_catname.Name = "updatetxt_catname"
        Me.updatetxt_catname.Size = New System.Drawing.Size(360, 39)
        Me.updatetxt_catname.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(542, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 32)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(542, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 32)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "*"
        '
        'update_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 621)
        Me.Controls.Add(Me.hidprd_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.updatesel_img)
        Me.Controls.Add(Me.updateimg_picbox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.updatetxt_prdcode)
        Me.Controls.Add(Me.txt23)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.updatebtn_save)
        Me.Controls.Add(Me.updatetxt_catname)
        Me.Controls.Add(Me.updatetxt_prdprice)
        Me.Controls.Add(Me.updatetxt_prdname)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "update_menu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "update_menu"
        Me.TopMost = True
        CType(Me.updateimg_picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents updatesel_img As Button
    Friend WithEvents updateimg_picbox As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt23 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents updatebtn_save As Button
    Friend WithEvents updatetxt_prdprice As TextBox
    Friend WithEvents updatetxt_prdname As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents updatetxt_prdcode As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents hidprd_id As Label
    Friend WithEvents updatetxt_catname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
