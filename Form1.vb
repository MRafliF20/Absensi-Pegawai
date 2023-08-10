Imports System.Data.OleDb

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Then

            MsgBox("Data Belum Lengkap,Silahkan isi semua form !")
        Else
            Call Koneksi()
            Cmd = New OleDbCommand("select * from TbLogin where userid='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", conn)

            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                If Rd("userid").ToString = "admin" Then

                    Me.Hide()
                    Form2.Show()


                Else
                    Me.Hide()
                    Form3.Show()


                End If
            Else
                MsgBox("Username atau password Salah")
            End If
        End If


    End Sub

End Class
