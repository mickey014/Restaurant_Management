Imports MySql.Data.MySqlClient
Imports System.IO

Public Class manage_menu
    Dim caption As String
    Dim arrImage() As Byte
    Dim mstream As New System.IO.MemoryStream()
    Dim opf As New OpenFileDialog

    Private Sub manage_items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_product()
        'cat_prd_id.Hide()
        'admin_dashboard.btn_dshboard.BackColor = Color.FromArgb(64, 64, 64)
        'admin_dashboard.btn_menu.BackColor = Color.FromArgb(192, 57, 43)
    End Sub

    Sub load_product()
        gridview_menu.Rows.Clear()

        Try
            conn.Open()

            'cmd = New MySqlCommand("SELECT categories.cat_name, products.prd_id, products.prd_img, products.prd_code, products.prd_name, products.prd_stock, products.prd_price 
            'FROM categories
            'INNER JOIN products
            'ON categories.cat_id = products.prd_category", conn)
            cmd = New MySqlCommand("SELECT categories.*, products.* FROM categories INNER JOIN products ON categories.cat_id = products.prd_category ORDER BY prd_id DESC", conn)
            dr = cmd.ExecuteReader


            While dr.Read

                gridview_menu.Rows.Add(gridview_menu.Rows.Count + 1, dr.Item("prd_img"), dr.Item("prd_code"), dr.Item("prd_name"), dr.Item("prd_stock"), dr.Item("prd_price"), dr.Item("cat_name"), dr.Item("prd_id"))


                For i = 0 To gridview_menu.Rows.Count - 1
                    Dim r As DataGridViewRow = gridview_menu.Rows(i)
                    r.Height = 60
                Next

                Dim imgcol = DirectCast(gridview_menu.Columns("Column7"), DataGridViewImageColumn)
                imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch
            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub srch_prd_txt_TextChanged(sender As Object, e As EventArgs) Handles srch_prd_txt.TextChanged
        gridview_menu.Rows.Clear()

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT categories.*, products.*
            FROM categories
            INNER JOIN products
            ON categories.cat_id = products.prd_category 
            WHERE prd_code LIKE '%" & srch_prd_txt.Text & "%' OR products.prd_name LIKE '%" & srch_prd_txt.Text & "%' OR products.prd_name LIKE '%" & srch_prd_txt.Text & "%' OR products.prd_price LIKE '%" & srch_prd_txt.Text & "%' OR categories.cat_name LIKE '%" & srch_prd_txt.Text & "%' ORDER BY prd_id DESC", conn)
            dr = cmd.ExecuteReader

            While dr.Read

                gridview_menu.Rows.Add(gridview_menu.Rows.Count + 1, dr.Item("prd_img"), dr.Item("prd_code"), dr.Item("prd_name"), dr.Item("prd_stock"), dr.Item("prd_price"), dr.Item("cat_name"))
            End While

            For i = 0 To gridview_menu.Rows.Count - 1
                Dim r As DataGridViewRow = gridview_menu.Rows(i)
                r.Height = 60

            Next

            Dim imgcol = DirectCast(gridview_menu.Columns("Column7"), DataGridViewImageColumn)
            imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        add_update_ctg.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If MsgBox("Are You Sure?", vbQuestion + vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnadd_menu_Click(sender As Object, e As EventArgs) Handles btnadd_menu.Click
        add_menu.ShowDialog()
    End Sub

    Private Sub gridview_menu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridview_menu.CellContentClick
        Dim col_name As String = gridview_menu.Columns(e.ColumnIndex).Name
        If col_name = "colEdit" Then
            Dim data As Byte() = DirectCast(gridview_menu.Rows(e.RowIndex).Cells(1).Value, Byte())
            Dim ms As New MemoryStream(data)
            update_menu.updateimg_picbox.Image = Image.FromStream(ms)

            update_menu.updatetxt_prdcode.Text = gridview_menu.Rows(e.RowIndex).Cells(2).Value.ToString
            update_menu.updatetxt_prdname.Text = gridview_menu.Rows(e.RowIndex).Cells(3).Value.ToString
            update_menu.updatetxt_prdprice.Text = gridview_menu.Rows(e.RowIndex).Cells(5).Value.ToString
            update_menu.updatetxt_catname.Text = gridview_menu.Rows(e.RowIndex).Cells(6).Value.ToString
            update_menu.hidprd_id.Text = gridview_menu.Rows(e.RowIndex).Cells(7).Value.ToString
            update_menu.ShowDialog()

            'MsgBox(gridview_menu.Rows()
        ElseIf col_name = "colDel" Then
            If MsgBox("Do you want to delete this product?", vbQuestion + vbYesNo) = vbYes Then
                Try
                    conn.Open()
                    cmd = New MySqlCommand("DELETE FROM products WHERE prd_id='" & gridview_menu.Rows(e.RowIndex).Cells(7).Value & "' ", conn)
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        conn.Close()
                        'gridview_menu.Rows.Clear()
                        load_product()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conn.Close()
            End If
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub


End Class