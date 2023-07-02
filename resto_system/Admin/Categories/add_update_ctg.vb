Imports MySql.Data.MySqlClient
Imports System.Text
Public Class add_update_ctg

    Private Sub add_product_ctg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        cat_id.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub




    'Public Sub generate_code(x)


    '    For y As Integer = 1 To 4
    '        x += rand.Next("abcdefghehripwurf")
    '    Next
    '    For y As Integer = 1 To 4
    '        x += Convert.ToString(rand.Next(0, 9))
    '    Next
    '    generated_prdcode.Text = x

    '    If generated_prdcode.Text = x Then
    '        x = Nothing
    '    End If
    'End Sub


    Private Sub btn_addcat_Click(sender As Object, e As EventArgs) Handles btn_addcat.Click
        Try

            If txt_ctg.Text = "" Then
                MsgBox("Fill in the text fields!", vbCritical)
            ElseIf IsNumeric(txt_ctg.Text) Then
                MsgBox("You must enter characters only!", vbCritical)
            Else
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM categories WHERE cat_name = @cat_name", conn)
                cmd.Parameters.AddWithValue("@cat_name", txt_ctg.Text)
                dr = cmd.ExecuteReader()

                If (dr.HasRows = True) Then
                    MsgBox("Categories name already exists!", vbCritical)
                    dr.Close()
                    conn.Close()
                ElseIf (dr.HasRows = False) Then
                    conn.Close()
                    conn.Open()

                    cmd = New MySqlCommand("INSERT INTO `categories`(`cat_name`) VALUES (@cat_name)", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@cat_name", txt_ctg.Text)

                    i = cmd.ExecuteNonQuery

                    If i > 0 Then
                        MsgBox("Success!", vbInformation)
                    Else
                        MsgBox("Failed!", vbInformation)
                    End If
                    conn.Close()
                    Me.Dispose()
                    manage_cat.load_categories()
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        conn.Close()
        txt_ctg.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt_ctg.Clear()
    End Sub

    Private Sub btn_updatecat1_Click(sender As Object, e As EventArgs) Handles btn_updatecat1.Click
        If txt_ctg.Text = "" Then
            MsgBox("Fill in the text fields!", vbCritical)
        ElseIf IsNumeric(txt_ctg.Text) Then
            MsgBox("You must enter characters only!", vbCritical)
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand("UPDATE `categories` SET `cat_name`=@cat_name WHERE `cat_id` = @cat_id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@cat_name", txt_ctg.Text)
                cmd.Parameters.AddWithValue("@cat_id", cat_id.Text)
                i = cmd.ExecuteNonQuery

                'If i > 0 Then
                '    MsgBox("Success!", vbInformation)
                'Else
                '    MsgBox("Failed!", vbInformation)
                'End If
                Me.Hide()
                conn.Close()
                manage_cat.load_categories()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class