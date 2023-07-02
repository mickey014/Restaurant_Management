Imports MySql.Data.MySqlClient
Public Class add_admin
    Private Sub add_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        txt_add_admin_pass.UseSystemPasswordChar = True
        txt_add_admin_tag.Focus()
        'txt_add_admin_tag.LostFocus()
    End Sub

    Private Sub btn_add_admin_Click(sender As Object, e As EventArgs) Handles btn_add_admin.Click
        'password = admin12345
        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO admin(admin_rfid_tag,name,password) VALUES(@admin_rfid_tag,@name,@password)", conn)
            With cmd
                cmd.Parameters.AddWithValue("@admin_rfid_tag", txt_add_admin_tag.Text)
                cmd.Parameters.AddWithValue("@name", txt_add_admin_name.Text)
                cmd.Parameters.AddWithValue("@password", encrypt_data(txt_add_admin_pass.Text))
                cmd.ExecuteNonQuery()
            End With
            conn.Close()


        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txt_add_admin_tag_TextChanged(sender As Object, e As EventArgs) Handles txt_add_admin_tag.TextChanged
        If (txt_add_admin_tag.Text.Length >= 10) Then

            'conn.Open()
            'cmd = New MySqlCommand("SELECT * FROM staff WHERE rfid_tag = @rfid_tag", conn)
            'cmd.Parameters.AddWithValue("@rfid_tag", txt_add_staff_tag.Text)
            'dr = cmd.ExecuteReader()


            'If (dr.HasRows = True) Then
            '    Label8.Show()
            '    Label8.Text = "RFID TAG has already been used!"
            '    txt_add_staff_tag.Clear()
            'End If


            'dr.Close()
            'conn.Close()
            txt_add_admin_tag.SelectionStart = 0
            txt_add_admin_tag.SelectionLength = Len(txt_add_admin_tag.Text)
            txt_add_admin_tag.Focus()
            'txt_add_staff_tag.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class