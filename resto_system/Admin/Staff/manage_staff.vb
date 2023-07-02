Imports MySql.Data.MySqlClient
Imports System.IO

Public Class manage_staff
    Private Sub manage_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_staff()
    End Sub

    Public Sub load_staff()
        gridview_staff.Rows.Clear()

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT * FROM `staff` ORDER BY id DESC", conn)
            dr = cmd.ExecuteReader


            While dr.Read

                gridview_staff.Rows.Add(gridview_staff.Rows.Count + 1, dr.Item("name"), dr.Item("username"), dr.Item("email"), dr.Item("contact_no"), dr.Item("id"))

            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub srch_staff_txt_TextChanged(sender As Object, e As EventArgs) Handles srch_staff_txt.TextChanged
        gridview_staff.Rows.Clear()

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT * FROM `staff` WHERE name LIKE '%" & srch_staff_txt.Text & "%' OR username LIKE '%" & srch_staff_txt.Text & "%' OR email LIKE '%" & srch_staff_txt.Text & "%' OR contact_no LIKE '%" & srch_staff_txt.Text & "%' ORDER BY id DESC", conn)
            dr = cmd.ExecuteReader


            While dr.Read

                gridview_staff.Rows.Add(gridview_staff.Rows.Count + 1, dr.Item("name"), dr.Item("username"), dr.Item("email"), dr.Item("contact_no"), dr.Item("id"))

            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub gridview_staff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridview_staff.CellContentClick
        Dim col_name As String = gridview_staff.Columns(e.ColumnIndex).Name
        If col_name = "colEdit" Then


            update_staff.updatetxt_staff_name.Text = gridview_staff.Rows(e.RowIndex).Cells(1).Value.ToString
            update_staff.updatetxt_staff_username.Text = gridview_staff.Rows(e.RowIndex).Cells(2).Value.ToString
            update_staff.updatetxt_staff_email.Text = gridview_staff.Rows(e.RowIndex).Cells(3).Value.ToString
            update_staff.updatetxt_staff_contact.Text = gridview_staff.Rows(e.RowIndex).Cells(4).Value.ToString
            update_staff.hid_staff_id.Text = gridview_staff.Rows(e.RowIndex).Cells(5).Value.ToString
            update_staff.ShowDialog()
        ElseIf col_name = "colDel" Then
            If MsgBox("Are you sure about that?", vbQuestion + vbYesNo) = vbYes Then
                Try
                    conn.Open()
                    cmd = New MySqlCommand("DELETE FROM staff WHERE id='" & gridview_staff.Rows(e.RowIndex).Cells(5).Value & "' ", conn)
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        conn.Close()
                        load_staff()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conn.Close()
            End If
        End If
    End Sub
End Class