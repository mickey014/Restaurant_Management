Imports MySql.Data.MySqlClient
Public Class authenticate_admin_access
    Public found As Boolean
    Private Sub btn_admin_access_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub authenticate_admin_access_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        txt_admin_pass.Focus()
        'txt_admin_pass.LostFocus()
        txt_admin_pass.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub txt_admin_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_admin_pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try


                Dim strname As String = ""

                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM admin", conn)
                dr = cmd.ExecuteReader


                While dr.Read

                    If txt_admin_pass.Text = decrypt_data(dr.Item("password").ToString) Then
                        found = True
                        strname = dr.Item("name").ToString
                    Else
                        found = False
                    End If

                End While
                dr.Close()
                conn.Close()
                If found = True Then

                    If (main_cashier.btn_select = "btn_clear") Then

                        For j As Integer = 0 To main_cashier.DataGridView1.Rows.Count - 1
                            Dim clr_code = main_cashier.DataGridView1.Rows(j).Cells(1).Value
                            Dim clr_qty = main_cashier.DataGridView1.Rows(j).Cells(4).Value

                            cmd = New MySqlCommand("UPDATE `products` SET prd_stock = (prd_stock + @qty) WHERE prd_code = @prd_code", conn)
                            conn.Open()
                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@qty", clr_qty)
                            cmd.Parameters.AddWithValue("@prd_code", clr_code)
                            cmd.ExecuteNonQuery()
                            conn.Close()
                        Next
                        main_cashier.DataGridView1.Rows.Clear()
                        main_cashier.txt_disc.Text = ""
                        Me.Hide()

                    ElseIf (main_cashier.btn_select = "set_disc") Then
                        Me.Hide()
                        disc_form.disc_numdropdwn.Focus()
                        disc_form.Show()
                    End If

                    Me.Hide()
                    txt_admin_pass.Clear()
                Else
                    MsgBox("Access Denied!", vbExclamation)
                End If



            Catch ex As Exception
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub authenticate_admin_access_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        txt_admin_pass.Focus()
    End Sub
End Class