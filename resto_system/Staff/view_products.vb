Imports MySql.Data.MySqlClient
Public Class view_products


    Private Sub view_products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        datagridview_prd_show.Rows.Clear()
        datagridview_prd_show.ClearSelection()

        view_load_products()
    End Sub

    Public Sub view_load_products()

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT categories.cat_name, products.prd_code, products.prd_name, products.prd_stock, products.prd_price FROM categories INNER JOIN products ON categories.cat_id = products.prd_category ORDER BY products.prd_stock;", conn)
            dr = cmd.ExecuteReader

            While dr.Read

                If dr.Item("prd_stock") >= 1 And dr.Item("prd_stock") <= 2 Then
                    datagridview_prd_show.Rows.Add(datagridview_prd_show.Rows.Count + 1, dr.Item("prd_code"), dr.Item("prd_name"), dr.Item("prd_stock"), dr.Item("prd_price"), dr.Item("cat_name"), "Critical")
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.BackColor = Color.Maroon
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.SelectionBackColor = Color.Maroon
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
                ElseIf dr.Item("prd_stock") = 0 Then
                    datagridview_prd_show.Rows.Add(datagridview_prd_show.Rows.Count + 1, dr.Item("prd_code"), dr.Item("prd_name"), dr.Item("prd_stock"), dr.Item("prd_price"), dr.Item("cat_name"), "Not Available")
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.BackColor = Color.DimGray
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.SelectionBackColor = Color.DimGray
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.ForeColor = Color.Black
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.SelectionForeColor = Color.Black
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Strikeout)
                Else
                    datagridview_prd_show.Rows.Add(datagridview_prd_show.Rows.Count + 1, dr.Item("prd_code"), dr.Item("prd_name"), dr.Item("prd_stock"), dr.Item("prd_price"), dr.Item("cat_name"), "Ready")
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.SelectionBackColor = Color.DarkGreen
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

    Private Sub srch_prd_txt_TextChanged(sender As Object, e As EventArgs) Handles srch_prd_txt.TextChanged
        datagridview_prd_show.Rows.Clear()
        Try
            conn.Open()

            'cmd = New MySqlCommand("SELECT * FROM PRODUCTS WHERE prd_code LIKE '%" & srch_prd_txt.Text & "%' ", conn)
            cmd = New MySqlCommand("SELECT categories.cat_name, products.prd_code, products.prd_name,   products.prd_stock, products.prd_price 
            FROM categories
            INNER JOIN products
            ON categories.cat_id = products.prd_category
            WHERE products.prd_code LIKE '%" & srch_prd_txt.Text & "%' OR products.prd_name LIKE '%" & srch_prd_txt.Text & "%' OR categories.cat_name LIKE '%" & srch_prd_txt.Text & "%' ORDER BY products.prd_stock;", conn)
            dr = cmd.ExecuteReader

            While dr.Read

                If dr.Item("prd_stock") >= 1 And dr.Item("prd_stock") <= 2 Then
                    datagridview_prd_show.Rows.Add(datagridview_prd_show.Rows.Count + 1, dr.Item("prd_code"), dr.Item("prd_name"), dr.Item("prd_stock"), dr.Item("prd_price"), dr.Item("cat_name"), "Critical")
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.BackColor = Color.Maroon
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.SelectionBackColor = Color.Maroon
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
                ElseIf dr.Item("prd_stock") = 0 Then
                    datagridview_prd_show.Rows.Add(datagridview_prd_show.Rows.Count + 1, dr.Item("prd_code"), dr.Item("prd_name"), dr.Item("prd_stock"), dr.Item("prd_price"), dr.Item("cat_name"), "Not Available")
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.BackColor = Color.DimGray
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.SelectionBackColor = Color.DimGray
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.ForeColor = Color.Black
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.SelectionForeColor = Color.Black
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Strikeout)
                Else
                    datagridview_prd_show.Rows.Add(datagridview_prd_show.Rows.Count + 1, dr.Item("prd_code"), dr.Item("prd_name"), dr.Item("prd_stock"), dr.Item("prd_price"), dr.Item("cat_name"), "Ready")
                    datagridview_prd_show.Rows(datagridview_prd_show.RowCount - 1).DefaultCellStyle.SelectionBackColor = Color.DarkGreen
                End If
            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

End Class