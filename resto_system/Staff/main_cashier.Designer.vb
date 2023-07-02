<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_cashier
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
        Me.components = New System.ComponentModel.Container()
        Me.view_prd = New System.Windows.Forms.Button()
        Me.set_disc_btn = New System.Windows.Forms.Button()
        Me.btn_trans_show = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_billno = New System.Windows.Forms.Label()
        Me.txt_bill_date = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_logout_staff = New System.Windows.Forms.Button()
        Me.btn_clear_cashier = New System.Windows.Forms.Button()
        Me.lbl_overAllgTotal = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_amount_received = New System.Windows.Forms.TextBox()
        Me.lbl_change = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_search_prd_code = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_disc = New System.Windows.Forms.TextBox()
        Me.lbl_no_of_Items = New System.Windows.Forms.Label()
        Me.lbl_tprice = New System.Windows.Forms.Label()
        Me.lbl_disc = New System.Windows.Forms.Label()
        Me.lbl_gtotal = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'view_prd
        '
        Me.view_prd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_prd.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.view_prd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.view_prd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.view_prd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.view_prd.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_prd.ForeColor = System.Drawing.Color.White
        Me.view_prd.Location = New System.Drawing.Point(18, 29)
        Me.view_prd.Name = "view_prd"
        Me.view_prd.Size = New System.Drawing.Size(300, 128)
        Me.view_prd.TabIndex = 0
        Me.view_prd.Text = "Manage " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.view_prd.UseVisualStyleBackColor = True
        '
        'set_disc_btn
        '
        Me.set_disc_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.set_disc_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.set_disc_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.set_disc_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.set_disc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.set_disc_btn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.set_disc_btn.ForeColor = System.Drawing.Color.White
        Me.set_disc_btn.Location = New System.Drawing.Point(18, 183)
        Me.set_disc_btn.Name = "set_disc_btn"
        Me.set_disc_btn.Size = New System.Drawing.Size(300, 126)
        Me.set_disc_btn.TabIndex = 3
        Me.set_disc_btn.Text = "Discount"
        Me.set_disc_btn.UseVisualStyleBackColor = True
        '
        'btn_trans_show
        '
        Me.btn_trans_show.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_trans_show.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_trans_show.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_trans_show.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn_trans_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_trans_show.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_trans_show.ForeColor = System.Drawing.Color.White
        Me.btn_trans_show.Location = New System.Drawing.Point(18, 335)
        Me.btn_trans_show.Name = "btn_trans_show"
        Me.btn_trans_show.Size = New System.Drawing.Size(300, 125)
        Me.btn_trans_show.TabIndex = 4
        Me.btn_trans_show.Text = "Transaction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_trans_show.UseVisualStyleBackColor = True
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(1140, 263)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(92, 38)
        Me.lbl_date.TabIndex = 5
        Me.lbl_date.Text = "Date: "
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(1140, 196)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(86, 38)
        Me.lbl_time.TabIndex = 6
        Me.lbl_time.Text = "Time:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbl_billno)
        Me.Panel1.Controls.Add(Me.txt_bill_date)
        Me.Panel1.Location = New System.Drawing.Point(334, -8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1183, 186)
        Me.Panel1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(528, 130)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Welcome!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Thankyou for coming!"
        '
        'lbl_billno
        '
        Me.lbl_billno.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_billno.AutoSize = True
        Me.lbl_billno.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_billno.Location = New System.Drawing.Point(649, 78)
        Me.lbl_billno.Name = "lbl_billno"
        Me.lbl_billno.Size = New System.Drawing.Size(65, 30)
        Me.lbl_billno.TabIndex = 14
        Me.lbl_billno.Text = "Bill #:"
        Me.lbl_billno.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_bill_date
        '
        Me.txt_bill_date.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bill_date.Location = New System.Drawing.Point(750, 30)
        Me.txt_bill_date.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_bill_date.Name = "txt_bill_date"
        Me.txt_bill_date.Size = New System.Drawing.Size(362, 34)
        Me.txt_bill_date.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Controls.Add(Me.btn_logout_staff)
        Me.Panel2.Controls.Add(Me.btn_clear_cashier)
        Me.Panel2.Controls.Add(Me.view_prd)
        Me.Panel2.Controls.Add(Me.set_disc_btn)
        Me.Panel2.Controls.Add(Me.btn_trans_show)
        Me.Panel2.Location = New System.Drawing.Point(-7, -8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(344, 1157)
        Me.Panel2.TabIndex = 8
        '
        'btn_logout_staff
        '
        Me.btn_logout_staff.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout_staff.BackgroundImage = Global.resto_system.My.Resources.Resources.out
        Me.btn_logout_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_logout_staff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout_staff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout_staff.FlatAppearance.BorderSize = 0
        Me.btn_logout_staff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout_staff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout_staff.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout_staff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout_staff.Location = New System.Drawing.Point(243, 1001)
        Me.btn_logout_staff.Name = "btn_logout_staff"
        Me.btn_logout_staff.Size = New System.Drawing.Size(75, 72)
        Me.btn_logout_staff.TabIndex = 7
        Me.btn_logout_staff.UseVisualStyleBackColor = False
        '
        'btn_clear_cashier
        '
        Me.btn_clear_cashier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear_cashier.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_clear_cashier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_clear_cashier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn_clear_cashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear_cashier.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear_cashier.ForeColor = System.Drawing.Color.White
        Me.btn_clear_cashier.Location = New System.Drawing.Point(18, 483)
        Me.btn_clear_cashier.Name = "btn_clear_cashier"
        Me.btn_clear_cashier.Size = New System.Drawing.Size(300, 128)
        Me.btn_clear_cashier.TabIndex = 5
        Me.btn_clear_cashier.Text = "Clear"
        Me.btn_clear_cashier.UseVisualStyleBackColor = True
        '
        'lbl_overAllgTotal
        '
        Me.lbl_overAllgTotal.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_overAllgTotal.ForeColor = System.Drawing.Color.Lime
        Me.lbl_overAllgTotal.Location = New System.Drawing.Point(111, 17)
        Me.lbl_overAllgTotal.Name = "lbl_overAllgTotal"
        Me.lbl_overAllgTotal.Size = New System.Drawing.Size(280, 135)
        Me.lbl_overAllgTotal.TabIndex = 18
        Me.lbl_overAllgTotal.Text = "00.00"
        Me.lbl_overAllgTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Controls.Add(Me.lbl_overAllgTotal)
        Me.Panel3.Location = New System.Drawing.Point(1515, -8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(409, 234)
        Me.Panel3.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(344, 327)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1173, 750)
        Me.Panel4.TabIndex = 20
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersHeight = 34
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.Size = New System.Drawing.Size(1165, 869)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Product Code"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 175
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Product Name"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Price"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Qty"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 82
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Sub Total"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'txt_amount_received
        '
        Me.txt_amount_received.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_amount_received.Font = New System.Drawing.Font("Segoe UI Semibold", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount_received.Location = New System.Drawing.Point(1540, 896)
        Me.txt_amount_received.Margin = New System.Windows.Forms.Padding(25)
        Me.txt_amount_received.Name = "txt_amount_received"
        Me.txt_amount_received.Size = New System.Drawing.Size(365, 82)
        Me.txt_amount_received.TabIndex = 44
        '
        'lbl_change
        '
        Me.lbl_change.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_change.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_change.Location = New System.Drawing.Point(220, 453)
        Me.lbl_change.Name = "lbl_change"
        Me.lbl_change.Size = New System.Drawing.Size(170, 28)
        Me.lbl_change.TabIndex = 43
        Me.lbl_change.Text = "00.00"
        Me.lbl_change.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(97, 453)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 32)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Change:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1532, 834)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 38)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Cash:"
        '
        'txt_search_prd_code
        '
        Me.txt_search_prd_code.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_search_prd_code.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_search_prd_code.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_prd_code.Location = New System.Drawing.Point(384, 245)
        Me.txt_search_prd_code.Name = "txt_search_prd_code"
        Me.txt_search_prd_code.Size = New System.Drawing.Size(720, 43)
        Me.txt_search_prd_code.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 32)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "No of Items:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 32)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Total Price:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 32)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Discount %:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(51, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 32)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Grand Total:"
        '
        'txt_disc
        '
        Me.txt_disc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_disc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_disc.Enabled = False
        Me.txt_disc.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_disc.ForeColor = System.Drawing.Color.Firebrick
        Me.txt_disc.Location = New System.Drawing.Point(189, 271)
        Me.txt_disc.Name = "txt_disc"
        Me.txt_disc.Size = New System.Drawing.Size(41, 27)
        Me.txt_disc.TabIndex = 31
        Me.txt_disc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_no_of_Items
        '
        Me.lbl_no_of_Items.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no_of_Items.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_no_of_Items.Location = New System.Drawing.Point(220, 109)
        Me.lbl_no_of_Items.Name = "lbl_no_of_Items"
        Me.lbl_no_of_Items.Size = New System.Drawing.Size(170, 28)
        Me.lbl_no_of_Items.TabIndex = 37
        Me.lbl_no_of_Items.Text = "00.00"
        Me.lbl_no_of_Items.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_tprice
        '
        Me.lbl_tprice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tprice.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_tprice.Location = New System.Drawing.Point(220, 189)
        Me.lbl_tprice.Name = "lbl_tprice"
        Me.lbl_tprice.Size = New System.Drawing.Size(170, 28)
        Me.lbl_tprice.TabIndex = 38
        Me.lbl_tprice.Text = "00.00"
        Me.lbl_tprice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_disc
        '
        Me.lbl_disc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_disc.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_disc.Location = New System.Drawing.Point(254, 271)
        Me.lbl_disc.Name = "lbl_disc"
        Me.lbl_disc.Size = New System.Drawing.Size(136, 28)
        Me.lbl_disc.TabIndex = 40
        Me.lbl_disc.Text = "00.00"
        Me.lbl_disc.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_gtotal
        '
        Me.lbl_gtotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gtotal.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_gtotal.Location = New System.Drawing.Point(220, 361)
        Me.lbl_gtotal.Name = "lbl_gtotal"
        Me.lbl_gtotal.Size = New System.Drawing.Size(170, 28)
        Me.lbl_gtotal.TabIndex = 41
        Me.lbl_gtotal.Text = "00.00"
        Me.lbl_gtotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lbl_change)
        Me.Panel5.Controls.Add(Me.lbl_gtotal)
        Me.Panel5.Controls.Add(Me.lbl_disc)
        Me.Panel5.Controls.Add(Me.lbl_tprice)
        Me.Panel5.Controls.Add(Me.lbl_no_of_Items)
        Me.Panel5.Controls.Add(Me.txt_disc)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(1515, 235)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(409, 551)
        Me.Panel5.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 38)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Entry:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(368, 302)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(753, 3)
        Me.Panel6.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1534, 993)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 32)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "(No Commas)"
        '
        'main_cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1924, 1077)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_amount_received)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.txt_search_prd_code)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main_cashier"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents view_prd As Button
    Friend WithEvents set_disc_btn As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_bill_date As DateTimePicker
    Friend WithEvents lbl_overAllgTotal As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_amount_received As TextBox
    Friend WithEvents lbl_change As Label
    Friend WithEvents txt_search_prd_code As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents btn_clear_cashier As Button
    Friend WithEvents btn_logout_staff As Button
    Friend WithEvents btn_trans_show As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_disc As TextBox
    Friend WithEvents lbl_no_of_Items As Label
    Friend WithEvents lbl_tprice As Label
    Friend WithEvents lbl_disc As Label
    Friend WithEvents lbl_gtotal As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_billno As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
