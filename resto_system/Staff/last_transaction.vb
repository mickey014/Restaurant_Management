Imports MySql.Data.MySqlClient
Public Class last_transaction
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub last_transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_last_transaction()
    End Sub

    Public Sub load_last_transaction()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM product_pos ORDER BY ID DESC LIMIT 1;", conn)
        dr = cmd.ExecuteReader


        While dr.Read

            lst_trns_cash.Text = dr.Item("received_amount").ToString()
            lst_trns_change.Text = dr.Item("balance").ToString()
            lst_trns_num.Text = dr.Item("bill_no").ToString()

        End While
        main_cashier.Clear()
        dr.Close()
        conn.Close()
    End Sub

End Class