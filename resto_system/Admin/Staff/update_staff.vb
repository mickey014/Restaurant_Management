Imports MySql.Data.MySqlClient
Imports System.IO

Public Class update_staff
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub update_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hid_staff_id.Hide()
    End Sub

    Private Sub updatebtn_save_Click(sender As Object, e As EventArgs) Handles updatebtn_save.Click

        If (updatetxt_staff_name.Text = "" Or updatetxt_staff_username.Text = "" Or updatetxt_staff_contact.Text = "" Or updatetxt_staff_email.Text = "") Then
            MsgBox("All Fields are required!")
        ElseIf IsNumeric(updatetxt_staff_name.Text) Then
            MsgBox("Name Field must be letters only!")
        ElseIf Not IsNumeric(updatetxt_staff_contact.Text) Then
            MsgBox("Contact # Field must be digits only!")
        ElseIf updatetxt_staff_contact.TextLength < 11 Or updatetxt_staff_contact.TextLength > 11 Then
            MsgBox("Must be valid contact numnber!")
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand("UPDATE `staff` SET `name`=@name,`username`=@username,`email`=@email,`contact_no`=@contact_no WHERE `id` = @hidstaff_id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@hidstaff_id", hid_staff_id.Text)
                cmd.Parameters.AddWithValue("@name", updatetxt_staff_name.Text)
                cmd.Parameters.AddWithValue("@username", updatetxt_staff_username.Text)
                cmd.Parameters.AddWithValue("@email", updatetxt_staff_email.Text)
                cmd.Parameters.AddWithValue("@contact_no", updatetxt_staff_contact.Text)
                i = cmd.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Success!", vbInformation)
                Else
                    MsgBox("Failed!", vbInformation)
                End If
                Me.Hide()
                conn.Close()
                manage_staff.load_staff()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class