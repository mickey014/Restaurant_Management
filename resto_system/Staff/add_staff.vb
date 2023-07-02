Imports MySql.Data.MySqlClient

Public Class add_staff
    Private Sub add_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        txt_add_staff_pass.UseSystemPasswordChar = True
        txt_add_staff_chngpass.UseSystemPasswordChar = True
        txt_add_staff_tag.Focus()
        Label8.Hide()
    End Sub

    Public Sub Clear()
        txt_add_staff_name.Text = ""
        txt_add_staff_pass.Text = ""
        txt_add_staff_chngpass.Text = ""
        txt_add_staff_username.Text = ""
        txt_add_staff_email.Text = ""
        txt_add_staff_contactno.Text = ""
    End Sub

    Private Sub btn_admin_login_Click(sender As Object, e As EventArgs) Handles btn_add_staff.Click
        'password = admin12345 & kirk12345


        If (txt_add_staff_tag.Text = "" Or txt_add_staff_name.Text = "" Or txt_add_staff_pass.Text = "" Or txt_add_staff_chngpass.Text = "" Or txt_add_staff_username.Text = "" Or txt_add_staff_email.Text = "" Or txt_add_staff_contactno.Text = "") Then
            MsgBox("All Fields are required!")
        ElseIf IsNumeric(txt_add_staff_name.Text) Then
            MsgBox("Name Field must be letters only!")
        ElseIf Not IsNumeric(txt_add_staff_contactno.Text) Then
            MsgBox("Contact # Field must be digits only!")
        ElseIf txt_add_staff_contactno.TextLength < 11 Or txt_add_staff_contactno.TextLength > 11 Then
            MsgBox("Must be valid contact number!")
        ElseIf txt_add_staff_pass.Text <> txt_add_staff_chngpass.Text Then
            MsgBox("Password not matched!")
        Else
            Try
                conn.Open()

                cmd = New MySqlCommand("SELECT * FROM staff WHERE username = @username OR email = @email", conn)
                cmd.Parameters.AddWithValue("@username", txt_add_staff_username.Text)
                cmd.Parameters.AddWithValue("@email", txt_add_staff_email.Text)
                dr = cmd.ExecuteReader()

                If (dr.HasRows = True) Then
                    MsgBox("Username Or Email Already Exists", vbCritical)
                    dr.Close()
                    conn.Close()
                Else
                    conn.Close()
                    conn.Open()

                    cmd = New MySqlCommand("INSERT INTO staff(rfid_tag,name,password,username,email,contact_no) VALUES(@rfid_tag,@name,@password,@username,@email,@contact_no)", conn)
                    cmd.Parameters.AddWithValue("@rfid_tag", txt_add_staff_tag.Text)
                    cmd.Parameters.AddWithValue("@name", txt_add_staff_name.Text)
                    cmd.Parameters.AddWithValue("@password", encrypt_data(txt_add_staff_pass.Text))
                    cmd.Parameters.AddWithValue("@username", txt_add_staff_username.Text)
                    cmd.Parameters.AddWithValue("@email", txt_add_staff_email.Text)
                    cmd.Parameters.AddWithValue("@contact_no", txt_add_staff_contactno.Text)
                    i = cmd.ExecuteNonQuery()

                    If i > 0 Then
                        MsgBox("Welcome " & txt_add_staff_name.Text & "!", vbInformation)
                        Clear()
                        choose_user.switchPanel(login_staff)
                        login_staff.txt_login_staff_username.Focus()
                        Me.Hide()
                        conn.Close()

                    End If


                End If


            Catch ex As Exception
                conn.Close()
                MsgBox(ex.Message, vbCritical)
            End Try
        End If

        conn.Close()
    End Sub

    Private Sub lbl_already_registered_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        login_staff.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        login_staff.Show()
        Me.Hide()

    End Sub


    Private Sub regist_show_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles regist_show.LinkClicked
        Clear()
        choose_user.switchPanel(login_staff)
        login_staff.txt_login_staff_username.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clear()
    End Sub

    Private Sub add_staff_show_CheckedChanged(sender As Object, e As EventArgs) Handles add_staff_show.CheckedChanged
        txt_add_staff_pass.UseSystemPasswordChar = Not add_staff_show.Checked
        txt_add_staff_chngpass.UseSystemPasswordChar = Not add_staff_show.Checked
    End Sub

    Private Sub txt_add_staff_tag_TextChanged(sender As Object, e As EventArgs) Handles txt_add_staff_tag.TextChanged
        If (txt_add_staff_tag.Text.Length >= 10) Then

            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM staff WHERE rfid_tag = @rfid_tag", conn)
            cmd.Parameters.AddWithValue("@rfid_tag", txt_add_staff_tag.Text)
            dr = cmd.ExecuteReader()


            If (dr.HasRows = True) Then
                Label8.Show()
                Label8.Text = "RFID TAG has already been used!"
                txt_add_staff_tag.Clear()
            End If


            dr.Close()
            conn.Close()
            txt_add_staff_tag.SelectionStart = 0
            txt_add_staff_tag.SelectionLength = Len(txt_add_staff_tag.Text)

            'txt_add_staff_tag.Clear()

        Else
            Clear()
        End If
    End Sub

    Private Sub txt_add_staff_tag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_add_staff_tag.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then e.Handled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label8.Hide()
    End Sub
End Class