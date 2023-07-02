<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_logout_admin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_sales = New System.Windows.Forms.Button()
        Me.btn_attendance = New System.Windows.Forms.Button()
        Me.btn_stocks = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_categories = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.btn_dshboard = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dashboard_panel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_logout_admin)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btn_sales)
        Me.Panel1.Controls.Add(Me.btn_attendance)
        Me.Panel1.Controls.Add(Me.btn_stocks)
        Me.Panel1.Controls.Add(Me.btn_staff)
        Me.Panel1.Controls.Add(Me.btn_categories)
        Me.Panel1.Controls.Add(Me.btn_menu)
        Me.Panel1.Controls.Add(Me.btn_dshboard)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(387, 1117)
        Me.Panel1.TabIndex = 12
        '
        'btn_logout_admin
        '
        Me.btn_logout_admin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout_admin.BackgroundImage = Global.resto_system.My.Resources.Resources.out
        Me.btn_logout_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_logout_admin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout_admin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout_admin.FlatAppearance.BorderSize = 0
        Me.btn_logout_admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout_admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout_admin.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout_admin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout_admin.Location = New System.Drawing.Point(288, 1011)
        Me.btn_logout_admin.Name = "btn_logout_admin"
        Me.btn_logout_admin.Size = New System.Drawing.Size(75, 72)
        Me.btn_logout_admin.TabIndex = 8
        Me.btn_logout_admin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.resto_system.My.Resources.Resources.vecteezy_customer_service_icon_user_with_laptop_computer_and_6017842_removebg_preview
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(387, 307)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btn_sales
        '
        Me.btn_sales.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_sales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sales.FlatAppearance.BorderSize = 0
        Me.btn_sales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sales.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sales.ForeColor = System.Drawing.Color.White
        Me.btn_sales.Image = Global.resto_system.My.Resources.Resources.money_graph_with_up_arrow
        Me.btn_sales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sales.Location = New System.Drawing.Point(5, 756)
        Me.btn_sales.Name = "btn_sales"
        Me.btn_sales.Padding = New System.Windows.Forms.Padding(5)
        Me.btn_sales.Size = New System.Drawing.Size(382, 69)
        Me.btn_sales.TabIndex = 1
        Me.btn_sales.Text = "Sales"
        Me.btn_sales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_sales.UseVisualStyleBackColor = False
        '
        'btn_attendance
        '
        Me.btn_attendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_attendance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_attendance.FlatAppearance.BorderSize = 0
        Me.btn_attendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_attendance.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_attendance.ForeColor = System.Drawing.Color.White
        Me.btn_attendance.Image = Global.resto_system.My.Resources.Resources.id_card__2_
        Me.btn_attendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_attendance.Location = New System.Drawing.Point(5, 680)
        Me.btn_attendance.Name = "btn_attendance"
        Me.btn_attendance.Padding = New System.Windows.Forms.Padding(5)
        Me.btn_attendance.Size = New System.Drawing.Size(382, 69)
        Me.btn_attendance.TabIndex = 1
        Me.btn_attendance.Text = "Staff Attendance"
        Me.btn_attendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_attendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_attendance.UseVisualStyleBackColor = False
        '
        'btn_stocks
        '
        Me.btn_stocks.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_stocks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_stocks.FlatAppearance.BorderSize = 0
        Me.btn_stocks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_stocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stocks.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stocks.ForeColor = System.Drawing.Color.White
        Me.btn_stocks.Image = Global.resto_system.My.Resources.Resources.boxes
        Me.btn_stocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_stocks.Location = New System.Drawing.Point(5, 530)
        Me.btn_stocks.Name = "btn_stocks"
        Me.btn_stocks.Padding = New System.Windows.Forms.Padding(5)
        Me.btn_stocks.Size = New System.Drawing.Size(382, 69)
        Me.btn_stocks.TabIndex = 1
        Me.btn_stocks.Text = "Stocks"
        Me.btn_stocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_stocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_stocks.UseVisualStyleBackColor = False
        '
        'btn_staff
        '
        Me.btn_staff.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_staff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_staff.FlatAppearance.BorderSize = 0
        Me.btn_staff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_staff.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.ForeColor = System.Drawing.Color.White
        Me.btn_staff.Image = Global.resto_system.My.Resources.Resources.group_chat
        Me.btn_staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_staff.Location = New System.Drawing.Point(5, 605)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Padding = New System.Windows.Forms.Padding(5)
        Me.btn_staff.Size = New System.Drawing.Size(382, 69)
        Me.btn_staff.TabIndex = 1
        Me.btn_staff.Text = "Staff Account "
        Me.btn_staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'btn_categories
        '
        Me.btn_categories.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_categories.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_categories.FlatAppearance.BorderSize = 0
        Me.btn_categories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_categories.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_categories.ForeColor = System.Drawing.Color.White
        Me.btn_categories.Image = Global.resto_system.My.Resources.Resources.food_tray
        Me.btn_categories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_categories.Location = New System.Drawing.Point(5, 454)
        Me.btn_categories.Name = "btn_categories"
        Me.btn_categories.Padding = New System.Windows.Forms.Padding(5)
        Me.btn_categories.Size = New System.Drawing.Size(382, 69)
        Me.btn_categories.TabIndex = 1
        Me.btn_categories.Text = "Categories"
        Me.btn_categories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_categories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_categories.UseVisualStyleBackColor = False
        '
        'btn_menu
        '
        Me.btn_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu.FlatAppearance.BorderSize = 0
        Me.btn_menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.ForeColor = System.Drawing.Color.White
        Me.btn_menu.Image = Global.resto_system.My.Resources.Resources.restaurant1
        Me.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_menu.Location = New System.Drawing.Point(5, 379)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Padding = New System.Windows.Forms.Padding(5)
        Me.btn_menu.Size = New System.Drawing.Size(382, 69)
        Me.btn_menu.TabIndex = 1
        Me.btn_menu.Text = "Menu"
        Me.btn_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'btn_dshboard
        '
        Me.btn_dshboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_dshboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_dshboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dshboard.FlatAppearance.BorderSize = 0
        Me.btn_dshboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_dshboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dshboard.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dshboard.ForeColor = System.Drawing.Color.White
        Me.btn_dshboard.Image = Global.resto_system.My.Resources.Resources.dashboard__1_
        Me.btn_dshboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dshboard.Location = New System.Drawing.Point(5, 304)
        Me.btn_dshboard.Name = "btn_dshboard"
        Me.btn_dshboard.Padding = New System.Windows.Forms.Padding(5)
        Me.btn_dshboard.Size = New System.Drawing.Size(382, 69)
        Me.btn_dshboard.TabIndex = 1
        Me.btn_dshboard.Text = "Dashboard"
        Me.btn_dshboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dshboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_dshboard.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lbl_date)
        Me.Panel3.Controls.Add(Me.lbl_time)
        Me.Panel3.Location = New System.Drawing.Point(383, -8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1546, 182)
        Me.Panel3.TabIndex = 13
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.White
        Me.lbl_date.Location = New System.Drawing.Point(912, 31)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(129, 54)
        Me.lbl_date.TabIndex = 14
        Me.lbl_date.Text = "Date: "
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.White
        Me.lbl_time.Location = New System.Drawing.Point(912, 97)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(121, 54)
        Me.lbl_time.TabIndex = 15
        Me.lbl_time.Text = "Time:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'dashboard_panel
        '
        Me.dashboard_panel.BackColor = System.Drawing.Color.White
        Me.dashboard_panel.Location = New System.Drawing.Point(383, 173)
        Me.dashboard_panel.Name = "dashboard_panel"
        Me.dashboard_panel.Size = New System.Drawing.Size(1546, 935)
        Me.dashboard_panel.TabIndex = 14
        '
        'admin_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1922, 1106)
        Me.ControlBox = False
        Me.Controls.Add(Me.dashboard_panel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "admin_dashboard"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_dshboard As Button
    Friend WithEvents btn_attendance As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_categories As Button
    Friend WithEvents btn_menu As Button
    Friend WithEvents btn_sales As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_logout_admin As Button
    Friend WithEvents dashboard_panel As Panel
    Friend WithEvents btn_stocks As Button
End Class
