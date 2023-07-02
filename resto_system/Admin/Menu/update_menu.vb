Imports MySql.Data.MySqlClient
Imports System.IO
Public Class update_menu
    Dim opf As New OpenFileDialog
    Dim x As String = ""
    Dim rand As Random = New Random()
    Private Sub update_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hidprd_id.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub


    Private Sub updatebtn_save_Click(sender As Object, e As EventArgs) Handles updatebtn_save.Click
        Dim filename As String = OpenFileDialog1.FileName + ".jpg"
        Dim filesize As Int32

        Dim mstream As New System.IO.MemoryStream()
        updateimg_picbox.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        filesize = mstream.Length
        mstream.Close()


        If updatetxt_prdname.Text = "" Then
            MsgBox("You must enter product name!")
        ElseIf updatetxt_prdprice.Text = "" Then
            MsgBox("You must enter product price!")
        Else
                Try
                conn.Open()
                cmd = New MySqlCommand("UPDATE `products` SET `prd_name`=@prd_name,`prd_img`=@prd_img,`prd_price`=@prd_price WHERE `prd_id` = @hidprd_id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@hidprd_id", hidprd_id.Text)
                cmd.Parameters.AddWithValue("@prd_name", updatetxt_prdname.Text)
                cmd.Parameters.AddWithValue("@prd_img", arrImage)
                cmd.Parameters.AddWithValue("@prd_price", CDec(updatetxt_prdprice.Text))
                i = cmd.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Success!", vbInformation)
                Else
                    MsgBox("Failed!", vbInformation)
                End If
                Me.Hide()
                conn.Close()
                manage_menu.load_product()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub updatetxt_catname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles updatetxt_catname.KeyPress
        e.Handled = True
    End Sub

    Private Sub updatetxt_prdcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles updatetxt_prdcode.KeyPress
        e.Handled = True
    End Sub

    Private Sub updatesel_img_Click(sender As Object, e As EventArgs) Handles updatesel_img.Click
        opf.Filter = "Choose Image (*.JPG;*.PNG;*.GIF)| *.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            updateimg_picbox.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

    Private Sub updatetxt_prdprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles updatetxt_prdprice.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub
End Class