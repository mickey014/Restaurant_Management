Imports MySql.Data.MySqlClient
Public Class admin_home


    Private Sub admin_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        admin_dashboard.btn_dshboard.BackColor = Color.FromArgb(192, 57, 43)
        count_menu()
        count_staff()
        count_cat()
        count_admin()
        critical_zero_products()

    End Sub

    Private Sub count_menu()
        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT COUNT(prd_id) AS total_prod FROM products", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                total_menu.Text = dr.Item("total_prod").ToString()
            End While

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
            dr.Close()
        End Try
        conn.Close()
    End Sub
    Private Sub count_staff()
        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT COUNT(id) AS total_staff FROM staff", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                total_staff.Text = dr.Item("total_staff").ToString()
            End While

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
            dr.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub count_cat()
        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT COUNT(cat_id) AS total_cat FROM categories", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                total_cat.Text = dr.Item("total_cat").ToString()
            End While

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
            dr.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub count_admin()
        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT COUNT(id) AS total_admin FROM admin", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                total_admin.Text = dr.Item("total_admin").ToString()
            End While

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
            dr.Close()
        End Try
        conn.Close()
    End Sub

    Public Sub critical_zero_products()

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT * FROM products", conn)
            dr = cmd.ExecuteReader

            While dr.Read

                If dr.Item("prd_stock") >= 1 And dr.Item("prd_stock") <= 2 Then
                    'datagridview_critc_prd.Rows.Clear()
                    datagridview_critc_prd.ClearSelection()
                    datagridview_critc_prd.Rows.Add(datagridview_critc_prd.Rows.Count + 1, dr.Item("prd_code"), dr.Item("prd_name"), dr.Item("prd_stock"))
                    datagridview_critc_prd.Rows(datagridview_critc_prd.RowCount - 1).DefaultCellStyle.BackColor = Color.Maroon
                    datagridview_critc_prd.Rows(datagridview_critc_prd.RowCount - 1).DefaultCellStyle.SelectionBackColor = Color.Maroon
                    datagridview_critc_prd.Rows(datagridview_critc_prd.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
                ElseIf dr.Item("prd_stock") <= 0 Then
                    'datagridview_critc_prd.Rows.Clear()
                    datagridview_zero_prd.ClearSelection()
                    datagridview_zero_prd.Rows.Add(datagridview_zero_prd.Rows.Count + 1, dr.Item("prd_code"), dr.Item("prd_name"))
                    datagridview_zero_prd.Rows(datagridview_zero_prd.RowCount - 1).DefaultCellStyle.BackColor = Color.DimGray
                    datagridview_zero_prd.Rows(datagridview_zero_prd.RowCount - 1).DefaultCellStyle.SelectionBackColor = Color.DimGray
                    datagridview_zero_prd.Rows(datagridview_zero_prd.RowCount - 1).DefaultCellStyle.ForeColor = Color.Black
                    datagridview_zero_prd.Rows(datagridview_zero_prd.RowCount - 1).DefaultCellStyle.SelectionForeColor = Color.White
                    datagridview_zero_prd.Rows(datagridview_zero_prd.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
                End If
            End While

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
            dr.Close()
        End Try
        conn.Close()
    End Sub


End Class