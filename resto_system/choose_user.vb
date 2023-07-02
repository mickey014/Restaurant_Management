Public Class choose_user


    Sub switchPanel(ByVal panel As Form)
        FlowLayoutPanel1.Controls.Clear()
        panel.TopLevel = False
        FlowLayoutPanel1.Controls.Add(panel)

        panel.Show()
    End Sub
    Private Sub choose_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(login_staff)
        Me.user_cmbox.Text = "Staff"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub user_cmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles user_cmbox.SelectedIndexChanged
        If Me.user_cmbox.SelectedIndex = 0 Then
            'MsgBox("Staff")
            login_staff.txt_login_staff_username.Text = ""
            login_staff.txt_login_staff_pass.Text = ""
            add_staff.txt_add_staff_name.Text = ""
            add_staff.txt_add_staff_pass.Text = ""
            add_staff.txt_add_staff_chngpass.Text = ""
            add_staff.txt_add_staff_username.Text = ""
            add_staff.txt_add_staff_email.Text = ""
            add_staff.txt_add_staff_contactno.Text = ""
            switchPanel(login_staff)
            login_staff.txt_login_staff_username.Focus()
        ElseIf Me.user_cmbox.SelectedIndex = 1 Then
            'MsgBox("Admin")
            admin_login.txt_login_admin_pass.Text = ""
            add_staff.txt_add_staff_name.Text = ""
            add_staff.txt_add_staff_pass.Text = ""
            add_staff.txt_add_staff_chngpass.Text = ""
            add_staff.txt_add_staff_username.Text = ""
            add_staff.txt_add_staff_email.Text = ""
            add_staff.txt_add_staff_contactno.Text = ""
            switchPanel(admin_login)
            admin_login.txt_login_admin_pass.Focus()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Are you sure?", vbQuestion + vbYesNo) = vbYes Then
            Me.Hide()
        End If
    End Sub

    Private Sub user_cmbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles user_cmbox.KeyPress
        e.Handled = True
    End Sub
End Class