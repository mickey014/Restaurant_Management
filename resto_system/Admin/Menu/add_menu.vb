Imports MySql.Data.MySqlClient
Imports System.IO
Public Class add_menu
    Dim opf As New OpenFileDialog
    Dim x As String = ""
    Dim rand As Random = New Random()

    Private Sub add_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'select_ctg.Items.Clear()
        load_Product_Cat()

        cat_prd_id.Hide()
    End Sub

    Public Sub generate_code(ByVal x)
        For y As Integer = 1 To 4
            x += Convert.ToString(rand.Next(0, 9))
        Next
        txt_prdcode.Text = x

        If txt_prdcode.Text = x Then
            x = Nothing
        End If
    End Sub

    Public Sub clear_add_menu()
        txt_prdcode.Clear()
        txt_prdname.Clear()
        txt_prdprice.Clear()
        txt_prdstock.Clear()
        select_ctg.Text = "Select:"
    End Sub

    Private Sub btn_generate_code_Click(sender As Object, e As EventArgs)
        'generate_code("F000")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Sub load_Product_Cat()

        dt.Clear()
        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT * FROM categories", conn)
            da.SelectCommand = cmd

            da.Fill(dt)

            Dim row As DataRow = dt.NewRow
            row(0) = 0
            row(1) = "Select:"

            dt.Rows.InsertAt(row, 0)

            select_ctg.DataSource = dt
            select_ctg.DisplayMember = "cat_name"
            select_ctg.ValueMember = "cat_id"


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        conn.Close()

    End Sub

    Private Sub sel_img_Click(sender As Object, e As EventArgs) Handles sel_img.Click
        opf.Filter = "Choose Image (*.JPG;*.PNG;*.GIF)| *.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            img_picbox.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        'Dim filesize As UInt32
        'Dim mstream As New System.IO.MemoryStream
        'img_picbox.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        'Dim arrImage() As Byte = mstream.GetBuffer()
        'filesize = mstream.Length
        'mstream.Close()



        If (txt_prdname.Text = "") Then
            MsgBox("Please fill out all fields.", vbCritical)
        ElseIf (txt_prdcode.Text = "") Then
            MsgBox("Please fill out all fields.", vbCritical)
        ElseIf (txt_prdcode.Text = "") Then
            MsgBox("Please fill out all fields.", vbCritical)
        ElseIf (txt_prdstock.Text = "") Then
            MsgBox("Please fill out all fields.", vbCritical)
        ElseIf (txt_prdprice.Text = "") Then
            MsgBox("Please fill out all fields.", vbCritical)
        ElseIf (select_ctg.Text = "Select:") Then
            MsgBox("You must select categories.", vbCritical)
        ElseIf (img_picbox.Image Is Nothing) Then
            MsgBox("You must select images.", vbCritical)
        Else

            Try
                conn.Open()

                cmd = New MySqlCommand("SELECT * FROM products WHERE prd_code = @prd_code OR prd_name = @prd_name", conn)
                cmd.Parameters.AddWithValue("@prd_code", txt_prdcode.Text)
                cmd.Parameters.AddWithValue("@prd_name", txt_prdname.Text)
                dr = cmd.ExecuteReader()

                If (dr.HasRows = True) Then
                    MsgBox("Code # or Name already Exist!", vbCritical)
                    'While dr.Read
                    '    MsgBox(dr.Item("prd_id"))
                    'End While
                    dr.Close()
                    conn.Close()
                ElseIf (dr.HasRows = False) Then
                    conn.Close()
                    conn.Open()

                    Dim filename As String = OpenFileDialog1.FileName + ".jpg"
                    Dim filesize As Int32

                    Dim mstream As New System.IO.MemoryStream()
                    img_picbox.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.GetBuffer()
                    filesize = mstream.Length
                    mstream.Close()


                    cmd = New MySqlCommand("INSERT INTO `products`(`prd_code`, `prd_name`, `prd_img`, `prd_stock`, `prd_price`,`prd_category`) VALUES (@prd_code,@prd_name,@prd_img,@prd_stock,@prd_price,@prd_category)", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@prd_code", txt_prdcode.Text)
                    cmd.Parameters.AddWithValue("@prd_name", txt_prdname.Text)
                    cmd.Parameters.AddWithValue("@prd_img", arrImage)
                    cmd.Parameters.AddWithValue("@prd_stock", txt_prdstock.Text)
                    cmd.Parameters.AddWithValue("@prd_price", CDec(txt_prdprice.Text))
                    cmd.Parameters.AddWithValue("@prd_category", cat_prd_id.Text)

                    i = cmd.ExecuteNonQuery

                    If i > 0 Then
                        conn.Close()
                        manage_menu.load_product()
                        MsgBox("New Item Saved Sucessfully!", vbInformation)
                        Me.Hide()
                    Else
                        MsgBox("New Item Failed To Save!", vbExclamation)

                    End If

                    img_picbox.Image = Nothing
                    txt_prdcode.Clear()
                    txt_prdname.Clear()
                    txt_prdprice.Clear()
                    txt_prdstock.Clear()
                    select_ctg.Text = "Select:"
                End If



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        conn.Close()
    End Sub



    Private Sub select_ctg_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles select_ctg.SelectionChangeCommitted
        cat_prd_id.Text = select_ctg.SelectedValue
        If cat_prd_id.Text = 2 Then
            generate_code("DK00-")
        ElseIf cat_prd_id.Text = 3 Then
            generate_code("DS00-")
        ElseIf cat_prd_id.Text = 19 Then
            generate_code("CK00-")
        ElseIf cat_prd_id.Text = 20 Then
            generate_code("RA00-")
        ElseIf cat_prd_id.Text = 21 Then
            generate_code("GK00-")
        ElseIf cat_prd_id.Text = 22 Then
            generate_code("ST00-")
        ElseIf cat_prd_id.Text = 23 Then
            generate_code("GP00-")
        Else
            txt_prdcode.Text = ""
        End If
    End Sub

    Private Sub txt_prdcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_prdcode.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnclr_addprd_Click(sender As Object, e As EventArgs) Handles btnclr_addprd.Click
        img_picbox.Image = Nothing
        txt_prdcode.Clear()
        txt_prdname.Clear()
        txt_prdprice.Clear()
        txt_prdstock.Clear()
        select_ctg.Text = "Select:"
    End Sub

    Private Sub select_ctg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles select_ctg.KeyPress
        e.Handled = False
    End Sub

    Private Sub txt_prdprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_prdprice.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txt_prdstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_prdstock.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then e.Handled = True
    End Sub
End Class