Imports MySql.Data.MySqlClient

Public Class frm_quantity
    Public qty As Decimal = 0
    Public prd_code As String
    Public prd_stock As String

    Private Sub frm_quantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        qty_numdropdwn.Select()
        load_stock()
        'view_products.view_load_products()
    End Sub

    Public Sub load_stock()
        conn.Close()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM products WHERE prd_code ='" & main_cashier.txt_search_prd_code.Text & "'", conn)
            dr = cmd.ExecuteReader

            While dr.Read()
                'Create new row for products
                prd_code = dr("prd_code")
                prd_stock = dr("prd_stock")

                qty_numdropdwn.Maximum = prd_stock

                'If prd_stock <= 0 Then
                '    qty_numdropdwn.Enabled = False
                '    qty_numdropdwn.Value = 1
                'End If

            End While
            'conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
            dr.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub qty_numdropdwn_KeyDown(sender As Object, e As KeyEventArgs) Handles qty_numdropdwn.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            'MsgBox(prd_stock)
            'MsgBox(main_cashier.txt_search_prd_code.Text)

            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM products WHERE prd_code ='" & main_cashier.txt_search_prd_code.Text & "'", conn)
                dr = cmd.ExecuteReader

                While dr.Read()

                    'Create new row for products
                    prd_code = dr("prd_code")
                    prd_stock = dr("prd_stock")

                    qty_numdropdwn.Maximum = prd_stock
                    'MsgBox(main_cashier.txt_search_prd_code.Text)
                    conn.Close()
                    conn.Open()
                    cmd = New MySqlCommand("UPDATE `products` SET prd_stock = (prd_stock - @prd_stock) WHERE prd_code = @prd_code", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@prd_stock", qty_numdropdwn.Value)
                    cmd.Parameters.AddWithValue("@prd_code", main_cashier.txt_search_prd_code.Text)
                    cmd.ExecuteNonQuery()
                    'MsgBox(main_cashier.txt_search_prd_code.Text)
                    'MsgBox(prd_stock)
                    'view_products.view_load_products()

                    conn.Close()

                    main_cashier.AddList()

                End While
            Catch ex As Exception
                conn.Close()
                dr.Close()
            End Try

            conn.Close()

            'qty_numdropdwn.Value = 1
            Me.Hide()
            main_cashier.txt_search_prd_code.Clear()
            main_cashier.txt_search_prd_code.Focus()
        End If
    End Sub

    Private Sub qty_numdropdwn_ValueChanged(sender As Object, e As EventArgs) Handles qty_numdropdwn.ValueChanged
        load_stock()
    End Sub

    Private Sub qty_numdropdwn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qty_numdropdwn.KeyPress
        e.Handled = True
    End Sub
End Class