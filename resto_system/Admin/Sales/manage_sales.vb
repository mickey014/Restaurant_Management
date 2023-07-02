Imports MySql.Data.MySqlClient
Imports System.IO
Public Class manage_sales
    Private Sub manage_sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_sales()
    End Sub
    Sub load_sales()

        Try
            conn.Open()
            Dim table As New DataTable()
            cmd = New MySqlCommand("SELECT bill_no,bill_date,bill_monthyear,prd_name,price,qty,sub_total FROM `product_pos` WHERE bill_date = NOW()", conn)

            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(table)
            gridview_sales.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub


    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click

        Try
            conn.Open()
            Dim table As New DataTable()
            cmd = New MySqlCommand("SELECT bill_no,bill_date,bill_monthyear,prd_name,price,qty,sub_total FROM `product_pos` WHERE bill_date BETWEEN @d1 AND @d2", conn)
            'dr = cmd.ExecuteReader
            cmd.Parameters.Add("@d1", MySqlDbType.Date).Value = DateTimePicker1.Value
            cmd.Parameters.Add("@d2", MySqlDbType.Date).Value = DateTimePicker2.Value

            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(table)
            gridview_sales.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub
End Class