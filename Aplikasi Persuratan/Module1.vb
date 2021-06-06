Imports System.Data.OleDb

Module Module1
    Public Conn As OleDbConnection
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public CMD As OleDbCommand
    Public DR As OleDbDataReader

    Public Sub Koneksi()
        Try
            Conn = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=apksurat.mdb")
            Conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
    End Sub
End Module
