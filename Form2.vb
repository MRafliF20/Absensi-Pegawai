Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TbAbsenBindingSource.MoveNext()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBAbsensiDataSet.TbAbsen' table. You can move, or remove it, as needed.
        Me.TbAbsenTableAdapter.Fill(Me.DBAbsensiDataSet.TbAbsen)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TbAbsenBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TbAbsenBindingSource.AddNew()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        On Error GoTo Err

        TbAbsenBindingSource.EndEdit()
        TbAbsenTableAdapter.Update(DBAbsensiDataSet.TbAbsen)
        MsgBox("Data Anda Telah Disimpan")

Err:
        Exit Sub

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TbAbsenBindingSource.RemoveCurrent()



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form1.Show()




    End Sub
End Class