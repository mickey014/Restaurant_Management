Imports MySql.Data.MySqlClient
Public Class admin_login

    Private Sub admin_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        txt_login_admin_pass.UseSystemPasswordChar = True
        txt_login_admin_pass.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        choose_user.Show()
        Me.Hide()
    End Sub

    Private Sub txt_login_admin_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_login_admin_pass.TextChanged
        conn.Close()
        If (txt_login_admin_pass.Text.Length >= 10) Then

            'Dim found As Boolean = False

            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM admin WHERE rfid_tag = @rfid_tag", conn)
            cmd.Parameters.AddWithValue("@rfid_tag", txt_login_admin_pass.Text)
            dr = cmd.ExecuteReader()


            While dr.Read()
                txt_login_admin_pass.Text = decrypt_data(dr.Item("password").ToString)

            End While

            txt_login_admin_pass.SelectionStart = 0
            txt_login_admin_pass.SelectionLength = Len(txt_login_admin_pass.Text)



            'dr.Close()
            'conn.Close()
        End If

    End Sub

    Private Sub txt_login_admin_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_login_admin_pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim found As Boolean = False

                Dim strname As String = ""
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM admin", conn)
                dr = cmd.ExecuteReader


                While dr.Read

                    If txt_login_admin_pass.Text = decrypt_data(dr.Item("password").ToString) Then
                        found = True
                        strname = dr.Item("name").ToString
                    End If

                End While
                dr.Close()
                conn.Close()
                If found = True Then
                    MsgBox("Access Granted." & vbNewLine & "Welcome " & strname & "!", vbInformation)
                    txt_login_admin_pass.Text = ""
                    admin_dashboard.ShowDialog()
                    choose_user.Hide()
                Else
                    MsgBox("Access Denied!", vbExclamation)
                    txt_login_admin_pass.Text = ""
                    conn.Close()
                End If



            Catch ex As Exception
                conn.Close()
            End Try
            conn.Close()
        End If
        conn.Close()
    End Sub

End Class