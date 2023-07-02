Imports MySql.Data.MySqlClient
Imports System.IO.Ports

Public Class main_cashier
    Public btn_select As String
    Private Sub main_cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_time.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        dbconn()
        DataGridView1.RowTemplate.Height = 30
        txt_search_prd_code.Focus()
        'btn_pay.Enabled = False
        txt_amount_received.Enabled = False
        'lbl_billno.Hide()
        lbl_billno.Text = get_bill_no()
        lbl_billno.Hide()
        txt_bill_date.Hide()

        ' SMS MOdule

        If SerialPort1.PortName = "COM4" Then
            SerialPort1 = New SerialPort()
            SerialPort1.PortName = "COM4"
            SerialPort1.BaudRate = 115200
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.DataBits = 8
            SerialPort1.Handshake = Handshake.None
            SerialPort1.DtrEnable = True
            SerialPort1.RtsEnable = True
            SerialPort1.NewLine = vbCrLf
            SerialPort1.Open()
        End If


    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
        lbl_date.Text = Date.Now.ToString("dddd MMM dd, yyy")
        Total()
    End Sub

    'AddList using Product code
    Public Sub AddList()
        Dim exist As Boolean = False
        Dim numrow As Integer = 0
        Dim numtext As Integer
        Dim qty As Integer = 1
        For Each itm As DataGridViewRow In DataGridView1.Rows
            If itm.Cells(0).Value IsNot Nothing Then
                If itm.Cells(1).Value.ToString = txt_search_prd_code.Text Then
                    exist = True
                    numrow = itm.Index
                    numtext = CInt(itm.Cells(1).Value)
                    'MsgBox(numtext)
                    Exit For
                End If
            End If
        Next

        If exist = False Then
            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM products WHERE prd_code ='" & txt_search_prd_code.Text & "'", conn)
                dr = cmd.ExecuteReader

                While dr.Read()
                    If txt_search_prd_code.Text = String.Empty Then
                        Return
                    Else
                        'Create new row for products
                        Dim prd_code As String = dr("prd_code")
                        Dim prd_name As String = dr("prd_name")
                        Dim prd_price As Decimal = dr("prd_price")
                        Dim prd_qty As Decimal = frm_quantity.qty_numdropdwn.Value
                        Dim total_qty_price As Decimal = prd_price * prd_qty


                        DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, prd_code, prd_name, prd_price, prd_qty, total_qty_price)

                        txt_search_prd_code.Clear()
                        txt_search_prd_code.Focus()
                        txt_amount_received.Enabled = True
                    End If

                End While
                'dr.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            DataGridView1.Rows(numrow).Cells(4).Value += frm_quantity.qty_numdropdwn.Value
            DataGridView1.Rows(numrow).Cells(5).Value = CDec(DataGridView1.Rows(numrow).Cells(3).Value) * CDec(DataGridView1.Rows(numrow).Cells(4).Value)
        End If



    End Sub

    'Total
    Public Sub Total()
        lbl_no_of_Items.Text = DataGridView1.Rows.Count - 1 + 1

        Dim sum As Double = 0
        Dim subtotal As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            subtotal = subtotal + DataGridView1.Rows(i).Cells(3).Value * DataGridView1.Rows(i).Cells(4).Value
        Next

        Try
            lbl_tprice.Text = Format(CDec(subtotal), "#,##00.00")

            'grandtotal and discount
            If txt_disc.Text = "" Then
                lbl_gtotal.Text = Format(CDec(lbl_tprice.Text), "#,##00.00")
                lbl_overAllgTotal.Text = Format(CDec(lbl_gtotal.Text), "#,##00.00")
                lbl_disc.Text = "00.00"
            Else
                lbl_disc.Text = Format(CDec(txt_disc.Text * lbl_tprice.Text / 100), "#,##00.00")
                lbl_gtotal.Text = Format(CDec(lbl_tprice.Text - lbl_disc.Text), "#,##00.00")
                lbl_overAllgTotal.Text = Format(CDec(lbl_gtotal.Text), "#,##00.00")
            End If

            'compute if the search prdcode is trigger
            If txt_amount_received.Text = "" Then
                'btn_pay.Enabled = False
                lbl_change.Text = "0.00"
            ElseIf CDec(lbl_gtotal.Text) > CDec(txt_amount_received.Text) Then
                'btn_pay.Enabled = False
                lbl_change.Text = "0.00"
            Else

                lbl_change.Text = Format(CDec(txt_amount_received.Text - lbl_gtotal.Text), "#,##0.00")
            End If
            lbl_overAllgTotal.Text = Format(CDec(lbl_gtotal.Text), "#,##00.00")

        Catch ex As Exception

        End Try

    End Sub



    ' Selecting products using keydown 
    Private Sub txt_search_prd_code_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_search_prd_code.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True



            If txt_search_prd_code.Text <> "" Then

                Try
                    conn.Open()
                    cmd = New MySqlCommand("SELECT * FROM products WHERE prd_code ='" & txt_search_prd_code.Text & "'", conn)
                    dr = cmd.ExecuteReader

                    While dr.Read()
                        If dr.Item("prd_stock") > 0 Then
                            frm_quantity.ShowDialog()
                        Else
                            MsgBox("Product Code " & dr.Item("prd_code") & " is Not Available")
                            txt_search_prd_code.Text = ""
                        End If
                    End While
                    conn.Close()
                Catch ex As Exception
                    conn.Close()
                    dr.Close()
                    'MsgBox(ex.Message)
                End Try
            End If
        End If
        conn.Close()
    End Sub

    Private Sub txt_amount_received_TextChanged(sender As Object, e As EventArgs) Handles txt_amount_received.TextChanged


        'btn_pay.Enabled = True
        If txt_amount_received.Text = "" Then
            'btn_pay.Enabled = False
            lbl_change.Text = "0.00"
        ElseIf CDec(lbl_gtotal.Text) > CDec(txt_amount_received.Text) Then
            'btn_pay.Enabled = False
            lbl_change.Text = "0.00"
        End If

    End Sub



    Public Sub save_bill()

        Try
            conn.Open()

            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step 1
                cmd = New MySqlCommand("INSERT INTO `product_pos`(`bill_no`, `bill_date`, `bill_month`, `bill_monthyear`, `prd_code`, `prd_name`, `price`, `qty`, `sub_total`, `discount`, `total_price`, `grand_total`, `received_amount`, `balance`) VALUES (@bill_no, @bill_date, @bill_month, @bill_monthyear, @prd_code, @prd_name, @price, @qty, @sub_total, @discount, @total_price, @grand_total, @received_amount, @balance)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@bill_no", lbl_billno.Text)
                cmd.Parameters.AddWithValue("@bill_date", CDate(txt_bill_date.Text))
                cmd.Parameters.AddWithValue("@bill_month", Date.Now.ToString("MM"))
                cmd.Parameters.AddWithValue("@bill_monthyear", Date.Now.ToString("MMMM-yyyy"))
                cmd.Parameters.AddWithValue("@prd_code", DataGridView1.Rows(j).Cells(1).Value)
                cmd.Parameters.AddWithValue("@prd_name", DataGridView1.Rows(j).Cells(2).Value)
                cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(3).Value)
                cmd.Parameters.AddWithValue("@qty", DataGridView1.Rows(j).Cells(4).Value)
                cmd.Parameters.AddWithValue("@sub_total", DataGridView1.Rows(j).Cells(5).Value)
                cmd.Parameters.AddWithValue("@discount", CDec(lbl_disc.Text))
                cmd.Parameters.AddWithValue("@total_price", CDec(lbl_tprice.Text))
                cmd.Parameters.AddWithValue("@grand_total", CDec(lbl_gtotal.Text))
                cmd.Parameters.AddWithValue("@received_amount", txt_amount_received.Text)
                cmd.Parameters.AddWithValue("@balance", lbl_change.Text)

                i = cmd.ExecuteNonQuery
            Next

            If i > 0 Then
                'Clear()
                'MsgBox("New Transaction Save Success!" & vbNewLine & "Bill no: " & lbl_billno.Text, vbInformation)
                conn.Close()
                frm_transaction.load_transaction()
                last_transaction.ShowDialog()
            Else
                MsgBox("Last Transaction Failed!", vbExclamation)
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conn.Close()
        lbl_billno.Text = get_bill_no()
    End Sub

    Sub Clear()
        txt_bill_date.Text = Now
        txt_disc.Text = ""
        txt_search_prd_code.Clear()
        DataGridView1.Rows.Clear()
        lbl_change.Text = "00.00"
        lbl_disc.Text = "00.00"
        lbl_gtotal.Text = "00.00"
        lbl_no_of_Items.Text = ""
        lbl_overAllgTotal.Text = "00.00"
        lbl_tprice.Text = "00.00"
        txt_amount_received.Clear()
        'btn_pay.Enabled = False
        txt_amount_received.Enabled = False
    End Sub

    'Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click
    '    'save_bill()
    '    'frm_transaction.load_transaction()
    '    'txt_search_prd_code.Focus()
    'End Sub

    Private Sub btn_clear_cashier_Click(sender As Object, e As EventArgs) Handles btn_clear_cashier.Click
        btn_select = "btn_clear"
        authenticate_admin_access.ShowDialog()

    End Sub

    Private Sub btn_chng_pass_Click(sender As Object, e As EventArgs)
        'staff_change_password.ShowDialog()
    End Sub

    Private Sub btn_logout_staff_Click(sender As Object, e As EventArgs) Handles btn_logout_staff.Click
        'Dim show As New mb.ShowMessagebox
        If MsgBox("Are You Sure?", vbQuestion + vbYesNo) = vbYes Then
            Me.Hide()
            choose_user.ShowDialog()
        End If
    End Sub

    Private Sub view_prd_Click(sender As Object, e As EventArgs) Handles view_prd.Click
        view_products.ShowDialog()

    End Sub

    Private Sub btn_trans_show_Click(sender As Object, e As EventArgs) Handles btn_trans_show.Click
        frm_transaction.ShowDialog()
    End Sub

    Private Sub set_disc_btn_Click(sender As Object, e As EventArgs) Handles set_disc_btn.Click
        btn_select = "set_disc"
        'If (authenticate_admin_access.found = True) Then
        '    conn.Close()
        'Else
        '    authenticate_admin_access.Show()
        '    authenticate_admin_access.found = False
        'End If

        authenticate_admin_access.ShowDialog()
    End Sub



    Private Sub txt_amount_received_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_amount_received.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txt_amount_received.Text = "" Then
                'btn_pay.Enabled = False
                lbl_change.Text = "0.00"
            ElseIf CDec(lbl_gtotal.Text) > CDec(txt_amount_received.Text) Then
                'btn_pay.Enabled = False
                lbl_change.Text = "0.00"
            Else


                Dim receiverNumber As String = "09631633106"
                'Dim receiverNumber As String = "09309800034"
                Dim messageContent As String = "Your Bill is: " & lbl_overAllgTotal.Text

                ' Check if the receiver's number and message content are not empty
                If String.IsNullOrEmpty(receiverNumber) OrElse String.IsNullOrEmpty(messageContent) Then
                    MessageBox.Show("Please enter a receiver's number and a message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Format the AT command to send the message
                Dim atCommand As String = "AT+CMGS=" & """" & receiverNumber & """" & vbCr

                ' if sms module is inserted then open it
                If SerialPort1.PortName = "COM4" Then
                    If SerialPort1.IsOpen = True Then
                        SerialPort1.Write("AT" & vbCrLf)
                        SerialPort1.Write("AT+CMGF=1" & vbCrLf)
                        SerialPort1.Write(atCommand)
                        Dim response As String = SerialPort1.ReadExisting()
                        Do Until response.Contains(">")
                            response &= SerialPort1.ReadExisting()
                        Loop
                        SerialPort1.Write(messageContent & Chr(26))
                        System.Threading.Thread.Sleep(5000)
                        Dim newresponse = SerialPort1.ReadExisting()
                        If newresponse.Contains("OK") Then
                            MessageBox.Show("Message sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Failed to send message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Error: Invalid Port", "Port", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

                'save bill address
                save_bill()
            End If
        End If
    End Sub

    'Private Sub txt_search_prd_code_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_search_prd_code.KeyPress
    '    If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then e.Handled = True

    'End Sub

    Private Sub txt_search_prd_code_Enter(sender As Object, e As EventArgs) Handles txt_search_prd_code.Enter
        'btn_pay.Enabled = False
    End Sub

    Private Sub txt_search_prd_code_Leave(sender As Object, e As EventArgs) Handles txt_search_prd_code.Leave

        If txt_amount_received.Text = "" Then
            'btn_pay.Enabled = False
            lbl_change.Text = "0.00"
        ElseIf CDec(lbl_gtotal.Text) > CDec(txt_amount_received.Text) Then
            'btn_pay.Enabled = False
            lbl_change.Text = "0.00"
        Else

            'btn_pay.Enabled = True
        End If
    End Sub

    Private Sub txt_amount_received_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amount_received.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then e.Handled = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
