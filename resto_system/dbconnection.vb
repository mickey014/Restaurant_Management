Imports MySql.Data.MySqlClient
'Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Module dbconnection
    Public conn As New MySqlConnection
    Public result As Boolean
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public dr As MySqlDataReader
    Public i As Integer
    'Private tripleDes As New TripleDESCryptoServiceProvider
    Dim iYear As Integer = Date.Now().Year
    Dim iMonth As Integer = Now().Month
    Dim iDay As Integer = Now().Day

    Public format_date As String = $"{iYear}{iMonth.ToString("00")}{iDay.ToString("00")}"


    Public Function dbconn() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;username=root;password=;port=3306;database=resto_system;"
                result = True
                'MsgBox("Server Connected", vbNormal)'

            End If
        Catch ex As Exception
            result = False
            MsgBox("Server Not Connected!", vbExclamation)
        End Try
    End Function

    Public Function get_bill_no() As String
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM product_pos WHERE bill_no ORDER BY id DESC", conn)
            dr = cmd.ExecuteReader
            dr.Read()


            If dr.HasRows Then
                get_bill_no = CLng(dr.Item("bill_no").ToString) + 1
                'get_bill_no = "RES-" & format_date & String.Format("{0:D5}", dr.Item("bill_no") + 1)
                'get_bill_no = "RES-" & format_date & CLng(dr.Item("bill_no").ToString) + 1
            Else
                get_bill_no = Date.Now.ToString("yyymmdd") + "1"
                'get_bill_no = "RES-" & format_date + "1"
                'get_bill_no = "RES-" & format_date & "-" & Date.Now.ToString("yyy") & "1"
                'get_bill_no = "RES-" & format_date & String.Format("{0:D5}", Date.Now.ToString("yyy") & "1")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Function

    'Public Function encrypt_data(ByVal plaintext As String) As String
    '    Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)
    '    Dim ms As New System.IO.MemoryStream
    '    Dim encStream As New CryptoStream(ms, tripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

    '    encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
    '    encStream.FlushFinalBlock()

    '    Return Convert.ToBase64String(ms.ToArray)
    'End Function

    'Public Function decrypt_data(ByVal encryptedtext As String) As String
    '    Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)
    '    Dim ms As New System.IO.MemoryStream
    '    Dim decStream As New CryptoStream(ms, tripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

    '    decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
    '    decStream.FlushFinalBlock()

    '    Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    'End Function

    Public Function encrypt_data(encryption As String) As String
        Dim msg As String = String.Empty
        Dim encode As Byte() = New Byte(encryption.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(encryption)
        msg = Convert.ToBase64String(encode)
        Return msg
    End Function

    Public Function decrypt_data(decryption As String) As String
        Dim decrypt_text As String = String.Empty
        Dim encoded_txt As New UTF8Encoding()
        Dim decode As Decoder = encoded_txt.GetDecoder()
        Dim code_byte As Byte() = Convert.FromBase64String(decryption)
        Dim charcount As Integer = decode.GetCharCount(code_byte, 0, code_byte.Length)
        Dim decode_char As Char() = New Char(charcount - 1) {}
        decode.GetChars(code_byte, 0, code_byte.Length, decode_char, 0)
        decrypt_text = New String(decode_char)

        Return decrypt_text

    End Function

End Module
