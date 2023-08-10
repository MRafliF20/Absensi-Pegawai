Imports System.Data.OleDb

Module Module1
    Public conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Public Cmd As OleDbCommand
    Public Rd As OleDbDataReader


    Dim LokasiDB As String

    Public Sub Koneksi()
        LokasiDB = "Provider=Microsoft.ACE.OLEDB.12.0;data source=DBAbsensi.accdb"
        conn = New OleDbConnection(LokasiDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

End Module
