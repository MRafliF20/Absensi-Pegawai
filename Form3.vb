Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBAbsensiDataSet.TbAbsen' table. You can move, or remove it, as needed.
        Me.TbAbsenTableAdapter.Fill(Me.DBAbsensiDataSet.TbAbsen)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class