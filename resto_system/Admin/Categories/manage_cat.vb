Imports MySql.Data.MySqlClient
Imports System.IO

Public Class manage_cat
    Private Sub manage_cat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_categories()
        'admin_dashboard.btn_dshboard.BackColor = Color.FromArgb(64, 64, 64)
        'admin_dashboard.btn_menu.BackColor = Color.FromArgb(64, 64, 64)
        'admin_dashboard.btn_categories.BackColor = Color.FromArgb(192, 57, 43)
        'add_update_ctg.btn_updatecat.Hide()
    End Sub

    Sub load_categories()
        gridview_categories.Rows.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM categories ORDER BY cat_id DESC", conn)
            dr = cmd.ExecuteReader


            While dr.Read

                gridview_categories.Rows.Add(gridview_categories.Rows.Count + 1, dr.Item("cat_name"), dr.Item("cat_id"))

            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub btnadd_categories_Click(sender As Object, e As EventArgs) Handles btnadd_categories.Click
        add_update_ctg.btn_addcat.Show()
        add_update_ctg.Button3.Show()
        add_update_ctg.btn_updatecat1.Hide()
        add_update_ctg.txt_ctg.Text = ""
        add_update_ctg.ShowDialog()
    End Sub

    Private Sub srch_prd_txt_TextChanged(sender As Object, e As EventArgs) Handles srch_prd_cat.TextChanged
        gridview_categories.Rows.Clear()

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT * FROM categories WHERE cat_name LIKE '%" & srch_prd_cat.Text & "%' ORDER BY cat_id DESC", conn)
            dr = cmd.ExecuteReader

            While dr.Read

                gridview_categories.Rows.Add(gridview_categories.Rows.Count + 1, dr.Item("cat_name"), dr.Item("cat_id"))
            End While



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub gridview_categories_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridview_categories.CellContentClick
        Dim col_name As String = gridview_categories.Columns(e.ColumnIndex).Name


        If col_name = "colcat_Edit" Then
            add_update_ctg.txt_ctg.Text = gridview_categories.Rows(e.RowIndex).Cells(1).Value.ToString
            add_update_ctg.cat_id.Text = gridview_categories.Rows(e.RowIndex).Cells(2).Value.ToString
            add_update_ctg.btn_updatecat1.Show()
            add_update_ctg.btn_addcat.Hide()
            add_update_ctg.Button3.Hide()
            add_update_ctg.ShowDialog()

        ElseIf col_name = "colcat_Del" Then
            If MsgBox("Do you want to delete this category?", vbQuestion + vbYesNo) = vbYes Then
                Try
                    conn.Open()
                    cmd = New MySqlCommand("DELETE FROM categories WHERE cat_id='" & gridview_categories.Rows(e.RowIndex).Cells(2).Value & "' ", conn)
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        conn.Close()
                        'gridview_menu.Rows.Clear()
                        load_categories()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conn.Close()
            End If
        End If
    End Sub
End Class