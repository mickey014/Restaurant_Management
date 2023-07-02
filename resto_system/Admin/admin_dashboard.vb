Imports MySql.Data.MySqlClient
Public Class admin_dashboard
    Private Sub btn_mng_menu_Click(sender As Object, e As EventArgs)
        manage_menu.Show()
    End Sub

    Sub switchPanel(ByVal panel As Form)
        dashboard_panel.Controls.Clear()
        panel.TopLevel = False
        dashboard_panel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        admin_login.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        If MsgBox("Are You Sure?", vbQuestion + vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub dashboard_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(admin_home)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
        lbl_date.Text = Date.Now.ToString("dddd MMM dd, yyy")
    End Sub

    Private Sub btn_logout_admin_Click(sender As Object, e As EventArgs) Handles btn_logout_admin.Click
        If MsgBox("Are You Sure?", vbQuestion + vbYesNo) = vbYes Then
            btn_dshboard.BackColor = Color.FromArgb(192, 57, 43)
            btn_menu.BackColor = Color.FromArgb(64, 64, 64)
            btn_categories.BackColor = Color.FromArgb(64, 64, 64)
            btn_stocks.BackColor = Color.FromArgb(64, 64, 64)
            btn_staff.BackColor = Color.FromArgb(64, 64, 64)
            btn_sales.BackColor = Color.FromArgb(64, 64, 64)
            Me.Hide()
            choose_user.ShowDialog()
        End If
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        switchPanel(manage_menu)
        btn_menu.BackColor = Color.FromArgb(192, 57, 43)
        btn_dshboard.BackColor = Color.FromArgb(64, 64, 64)
        btn_categories.BackColor = Color.FromArgb(64, 64, 64)
        btn_stocks.BackColor = Color.FromArgb(64, 64, 64)
        btn_staff.BackColor = Color.FromArgb(64, 64, 64)
        btn_sales.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub btn_dshboard_Click(sender As Object, e As EventArgs) Handles btn_dshboard.Click
        switchPanel(admin_home)
        btn_dshboard.BackColor = Color.FromArgb(192, 57, 43)
        btn_menu.BackColor = Color.FromArgb(64, 64, 64)
        btn_categories.BackColor = Color.FromArgb(64, 64, 64)
        btn_stocks.BackColor = Color.FromArgb(64, 64, 64)
        btn_staff.BackColor = Color.FromArgb(64, 64, 64)
        btn_sales.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub btn_categories_Click(sender As Object, e As EventArgs) Handles btn_categories.Click
        switchPanel(manage_cat)
        btn_categories.BackColor = Color.FromArgb(192, 57, 43)
        btn_dshboard.BackColor = Color.FromArgb(64, 64, 64)
        btn_menu.BackColor = Color.FromArgb(64, 64, 64)
        btn_stocks.BackColor = Color.FromArgb(64, 64, 64)
        btn_staff.BackColor = Color.FromArgb(64, 64, 64)
        btn_sales.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub btn_stocks_Click(sender As Object, e As EventArgs) Handles btn_stocks.Click
        switchPanel(manage_stock)
        btn_stocks.BackColor = Color.FromArgb(192, 57, 43)
        btn_dshboard.BackColor = Color.FromArgb(64, 64, 64)
        btn_categories.BackColor = Color.FromArgb(64, 64, 64)
        btn_menu.BackColor = Color.FromArgb(64, 64, 64)
        btn_staff.BackColor = Color.FromArgb(64, 64, 64)
        btn_sales.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        switchPanel(manage_staff)
        btn_staff.BackColor = Color.FromArgb(192, 57, 43)
        btn_dshboard.BackColor = Color.FromArgb(64, 64, 64)
        btn_categories.BackColor = Color.FromArgb(64, 64, 64)
        btn_stocks.BackColor = Color.FromArgb(64, 64, 64)
        btn_menu.BackColor = Color.FromArgb(64, 64, 64)
        btn_sales.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub btn_sales_Click(sender As Object, e As EventArgs) Handles btn_sales.Click
        switchPanel(manage_sales)
        btn_sales.BackColor = Color.FromArgb(192, 57, 43)
        btn_dshboard.BackColor = Color.FromArgb(64, 64, 64)
        btn_categories.BackColor = Color.FromArgb(64, 64, 64)
        btn_stocks.BackColor = Color.FromArgb(64, 64, 64)
        btn_staff.BackColor = Color.FromArgb(64, 64, 64)
        btn_menu.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class