<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_menu))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.sel_img = New System.Windows.Forms.Button()
        Me.select_ctg = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_prdcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt23 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_prdprice = New System.Windows.Forms.TextBox()
        Me.txt_prdstock = New System.Windows.Forms.TextBox()
        Me.txt_prdname = New System.Windows.Forms.TextBox()
        Me.btnclr_addprd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cat_prd_id = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.img_picbox = New System.Windows.Forms.PictureBox()
        CType(Me.img_picbox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Button1.Location = New System.Drawing.Point(968, 27)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 52)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'sel_img
        '
        Me.sel_img.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sel_img.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.sel_img.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sel_img.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sel_img.ForeColor = System.Drawing.Color.White
        Me.sel_img.Location = New System.Drawing.Point(625, 512)
        Me.sel_img.Name = "sel_img"
        Me.sel_img.Size = New System.Drawing.Size(362, 48)
        Me.sel_img.TabIndex = 31
        Me.sel_img.Text = "..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.sel_img.UseVisualStyleBackColor = False
        '
        'select_ctg
        '
        Me.select_ctg.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_ctg.FormattingEnabled = True
        Me.select_ctg.Location = New System.Drawing.Point(174, 449)
        Me.select_ctg.Name = "select_ctg"
        Me.select_ctg.Size = New System.Drawing.Size(356, 40)
        Me.select_ctg.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 456)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 32)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Category:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 32)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Code #:"
        '
        'txt_prdcode
        '
        Me.txt_prdcode.BackColor = System.Drawing.SystemColors.Info
        Me.txt_prdcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_prdcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_prdcode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prdcode.Location = New System.Drawing.Point(174, 158)
        Me.txt_prdcode.Name = "txt_prdcode"
        Me.txt_prdcode.Size = New System.Drawing.Size(358, 39)
        Me.txt_prdcode.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 32)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Stock:"
        '
        'txt23
        '
        Me.txt23.AutoSize = True
        Me.txt23.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt23.Location = New System.Drawing.Point(72, 307)
        Me.txt23.Name = "txt23"
        Me.txt23.Size = New System.Drawing.Size(74, 32)
        Me.txt23.TabIndex = 33
        Me.txt23.Text = "Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 32)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Name:"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(172, 543)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(166, 49)
        Me.btn_save.TabIndex = 30
        Me.btn_save.Text = "Add Menu"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'txt_prdprice
        '
        Me.txt_prdprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_prdprice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prdprice.Location = New System.Drawing.Point(174, 301)
        Me.txt_prdprice.Name = "txt_prdprice"
        Me.txt_prdprice.Size = New System.Drawing.Size(358, 39)
        Me.txt_prdprice.TabIndex = 29
        '
        'txt_prdstock
        '
        Me.txt_prdstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_prdstock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prdstock.Location = New System.Drawing.Point(174, 378)
        Me.txt_prdstock.Name = "txt_prdstock"
        Me.txt_prdstock.Size = New System.Drawing.Size(356, 39)
        Me.txt_prdstock.TabIndex = 28
        '
        'txt_prdname
        '
        Me.txt_prdname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_prdname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prdname.Location = New System.Drawing.Point(174, 229)
        Me.txt_prdname.Name = "txt_prdname"
        Me.txt_prdname.Size = New System.Drawing.Size(358, 39)
        Me.txt_prdname.TabIndex = 27
        '
        'btnclr_addprd
        '
        Me.btnclr_addprd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnclr_addprd.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnclr_addprd.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclr_addprd.ForeColor = System.Drawing.Color.White
        Me.btnclr_addprd.Location = New System.Drawing.Point(362, 543)
        Me.btnclr_addprd.Name = "btnclr_addprd"
        Me.btnclr_addprd.Size = New System.Drawing.Size(166, 49)
        Me.btnclr_addprd.TabIndex = 30
        Me.btnclr_addprd.Text = "Clear"
        Me.btnclr_addprd.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(324, 65)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Menu Details"
        '
        'cat_prd_id
        '
        Me.cat_prd_id.AutoSize = True
        Me.cat_prd_id.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cat_prd_id.Location = New System.Drawing.Point(902, 593)
        Me.cat_prd_id.Name = "cat_prd_id"
        Me.cat_prd_id.Size = New System.Drawing.Size(85, 29)
        Me.cat_prd_id.TabIndex = 46
        Me.cat_prd_id.Text = "cat_id"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'img_picbox
        '
        Me.img_picbox.BackgroundImage = Global.resto_system.My.Resources.Resources.No_Product_Image_Available_removebg_preview1
        Me.img_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_picbox.InitialImage = CType(resources.GetObject("img_picbox.InitialImage"), System.Drawing.Image)
        Me.img_picbox.Location = New System.Drawing.Point(609, 161)
        Me.img_picbox.Name = "img_picbox"
        Me.img_picbox.Size = New System.Drawing.Size(392, 327)
        Me.img_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_picbox.TabIndex = 43
        Me.img_picbox.TabStop = False
        '
        'add_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1056, 651)
        Me.Controls.Add(Me.cat_prd_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sel_img)
        Me.Controls.Add(Me.img_picbox)
        Me.Controls.Add(Me.select_ctg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_prdcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt23)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnclr_addprd)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_prdprice)
        Me.Controls.Add(Me.txt_prdstock)
        Me.Controls.Add(Me.txt_prdname)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "add_menu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.img_picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents sel_img As Button
    Friend WithEvents img_picbox As PictureBox
    Friend WithEvents select_ctg As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_prdcode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt23 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents txt_prdprice As TextBox
    Friend WithEvents txt_prdstock As TextBox
    Friend WithEvents txt_prdname As TextBox
    Friend WithEvents btnclr_addprd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cat_prd_id As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
