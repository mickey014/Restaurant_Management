Imports MySql.Data.MySqlClient
Imports System.IO
Public Class manage_stock
    Private Sub manage_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_stocks()

    End Sub

    Sub load_stocks()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM products ORDER BY prd_id DESC", conn)
            dr = cmd.ExecuteReader



            While dr.Read
                gridview_stock.Rows.Add(gridview_stock.Rows.Count + 1, dr.Item("prd_name"), dr.Item("prd_stock"), dr.Item("prd_id"))
            End While




        Catch ex As Exception
            'MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub gridview_stock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridview_stock.CellContentClick
        Dim col_name As String = gridview_stock.Columns(e.ColumnIndex).Name
        Dim stock_id As Integer = gridview_stock.Rows(e.RowIndex).Cells(3).Value
        Dim stock As Integer = gridview_stock.Rows(e.RowIndex).Cells(2).Value


        If col_name = "colstock_plus" Then

            conn.Open()

            cmd = New MySqlCommand("UPDATE `products` SET prd_stock = (prd_stock + @prd_stock) WHERE prd_id = @prd_id", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@prd_stock", 1)
            cmd.Parameters.AddWithValue("@prd_id", stock_id)
            cmd.ExecuteNonQuery()
            conn.Close()
            gridview_stock.Rows.Clear()
            load_stocks()
            admin_home.datagridview_critc_prd.Rows.Clear()
            admin_home.datagridview_zero_prd.Rows.Clear()
            'admin_home.datagridview_critc_prd.ClearSelection()
            admin_home.critical_zero_products()

        ElseIf col_name = "colstock_minus" Then
            conn.Open()
            cmd = New MySqlCommand("UPDATE `products` SET prd_stock = (prd_stock - @prd_stock) WHERE prd_id = @prd_id", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@prd_stock", 1)
            cmd.Parameters.AddWithValue("@prd_id", stock_id)
            cmd.ExecuteNonQuery()
            conn.Close()
            gridview_stock.Rows.Clear()
            load_stocks()
            admin_home.datagridview_zero_prd.Rows.Clear()
            admin_home.datagridview_critc_prd.Rows.Clear()
            'admin_home.datagridview_critc_prd.ClearSelection()
            admin_home.critical_zero_products()



        End If

    End Sub

    Private Sub srch_stock_txt_TextChanged(sender As Object, e As EventArgs) Handles srch_stock_txt.TextChanged
        gridview_stock.Rows.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM products WHERE prd_name LIKE '%" & srch_stock_txt.Text & "%'   ORDER BY prd_id DESC", conn)
            dr = cmd.ExecuteReader



            While dr.Read
                gridview_stock.Rows.Add(gridview_stock.Rows.Count + 1, dr.Item("prd_name"), dr.Item("prd_stock"), dr.Item("prd_id"))
            End While



        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
        conn.Close()
    End Sub
End Class