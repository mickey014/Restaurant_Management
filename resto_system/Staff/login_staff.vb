Imports MySql.Data.MySqlClient
Public Class login_staff
    Private Sub login_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        txt_login_staff_pass.UseSystemPasswordChar = True
        txt_login_staff_username.Focus()
    End Sub

    Private Sub regist_show_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles regist_show.LinkClicked
        txt_login_staff_username.Text = ""
        txt_login_staff_pass.Text = ""
        choose_user.switchPanel(add_staff)
        add_staff.txt_add_staff_tag.Focus()
    End Sub

    Private Sub btn_staff_login_Click(sender As Object, e As EventArgs) Handles btn_staff_login.Click

        If (txt_login_staff_username.Text = "" Or txt_login_staff_pass.Text = "") Then
            MsgBox("Incorrect Username or Password", vbCritical)
        Else
            Try
                Dim strname As String = ""
                Dim strpass As String = ""

                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM staff WHERE username = @username", conn)
                cmd.Parameters.AddWithValue("@username", txt_login_staff_username.Text)
                dr = cmd.ExecuteReader

                While dr.Read
                    'kirk12345
                    strname = dr.Item("username").ToString
                    strpass = dr.Item("password").ToString

                End While
                dr.Close()
                If txt_login_staff_username.Text = strname And txt_login_staff_pass.Text = decrypt_data(strpass) Then
                    conn.Close()
                    txt_login_staff_username.Text = ""
                    txt_login_staff_pass.Text = ""
                    main_cashier.ShowDialog()
                    choose_user.Hide()
                Else
                    MsgBox("Incorrect Username or Password", vbCritical)
                    txt_login_staff_username.Focus()
                    conn.Close()
                End If




            Catch ex As Exception
                conn.Close()
            End Try
            conn.Close()
        End If

        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        choose_user.Show()
        Me.Hide()
    End Sub

    Private Sub show_pass_CheckedChanged(sender As Object, e As EventArgs) Handles show_pass.CheckedChanged
        txt_login_staff_pass.UseSystemPasswordChar = Not show_pass.Checked
    End Sub


    Private Sub txt_login_staff_username_TextChanged(sender As Object, e As EventArgs) Handles txt_login_staff_username.TextChanged
        If (txt_login_staff_username.Text.Length >= 10) Then

            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM staff WHERE rfid_tag = @rfid_tag", conn)
            cmd.Parameters.AddWithValue("@rfid_tag", txt_login_staff_username.Text)
            dr = cmd.ExecuteReader()


            While dr.Read()
                txt_login_staff_username.Text = dr.Item("username")
                txt_login_staff_pass.Text = decrypt_data(dr.Item("password"))
            End While

            txt_login_staff_username.SelectionStart = 0
            txt_login_staff_username.SelectionLength = Len(txt_login_staff_username.Text)

            'txt_add_staff_tag.Clear()
            dr.Close()
            conn.Close()
        End If

    End Sub
End Class