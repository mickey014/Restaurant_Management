Imports MySql.Data.MySqlClient
Public Class frm_transaction
    Private Sub frm_transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_transaction()
    End Sub

    Public Sub load_transaction()
        datagridview_trns_load.Rows.Clear()
        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT products.prd_id, products.prd_stock, product_pos.bill_no, product_pos.bill_date, product_pos.qty, product_pos.grand_total 
            FROM products 
            INNER JOIN product_pos 
            ORDER BY product_pos.bill_no DESC", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                datagridview_trns_load.Rows.Add(datagridview_trns_load.Rows.Count + 1, dr.Item("bill_no"), dr.Item("bill_date"), dr.Item("qty"), dr.Item("grand_total"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub srch_trnstn_txt_TextChanged(sender As Object, e As EventArgs) Handles srch_trnstn_txt.TextChanged
        datagridview_trns_load.Rows.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT products.prd_id, products.prd_stock, product_pos.bill_no, product_pos.bill_date, product_pos.qty, product_pos.grand_total  
            FROM products 
            INNER JOIN product_pos 
            WHERE product_pos.bill_no LIKE '%" & srch_trnstn_txt.Text & "%' 
            ORDER BY product_pos.bill_no DESC", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                datagridview_trns_load.Rows.Add(datagridview_trns_load.Rows.Count + 1, dr.Item("bill_no"), dr.Item("bill_date"), dr.Item("qty"), dr.Item("grand_total"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub


    Private Sub datagridview_trns_load_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridview_trns_load.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class