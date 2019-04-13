Imports System.Data.OleDb

Module Db
    Private ConnectionString As String

    Dim cmd1 As OleDbCommand
    Dim dr As OleDbDataReader

    Public Function Selectqry(a As String) As OleDbDataReader
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\my pc\source\repos\gncvb\gncvb\GNC.mdb"
        Dim Connection As New OleDbConnection(ConnectionString)
        Connection.Open()
        cmd1 = New OleDb.OleDbCommand(a, Connection)
        dr = cmd1.ExecuteReader()
        Return dr
    End Function

    Sub Updateqry(a As String)
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\my pc\source\repos\gncvb\gncvb\GNC.mdb"
        Dim Connection As New OleDbConnection(ConnectionString)
        Connection.Open()
        cmd1 = New OleDb.OleDbCommand(a, Connection)
        cmd1.ExecuteNonQuery()
        Connection.Close()
    End Sub
End Module