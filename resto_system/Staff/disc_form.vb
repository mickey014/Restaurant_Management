Imports MySql.Data.MySqlClient
Public Class disc_form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub


    Private Sub disc_numdropdwn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles disc_numdropdwn.KeyPress
        e.Handled = True
    End Sub

    Private Sub disc_numdropdwn_KeyDown(sender As Object, e As KeyEventArgs) Handles disc_numdropdwn.KeyDown
        If e.KeyCode = Keys.Enter Then
            main_cashier.txt_disc.Text = disc_numdropdwn.Value
            Me.Hide()
        End If
    End Sub

    Private Sub disc_form_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        disc_numdropdwn.Focus()
    End Sub

    Private Sub disc_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
    End Sub
End Class