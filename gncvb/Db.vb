Imports System.Data.OleDb

Module Db
    Private ConnectionString As String
    Private ReadOnly a As String
    Dim cmd1 As OleDbCommand
    Dim dr As OleDbDataReader


    Public Function Selectqry(a) As OleDbDataReader
		ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\source\\repos\\erjkjaskaran\\gncvb\\gncvb\\GNC.mdb"
		Dim Connection As New OleDbConnection(ConnectionString)
        Connection.Open()
        cmd1 = New OleDb.OleDbCommand(a, Connection)
        dr = cmd1.ExecuteReader()
        Return dr
    End Function

    Public Function Updateqry(a)
		ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\source\\repos\\erjkjaskaran\\gncvb\\gncvb\\GNC.mdb"
		Dim Connection As New OleDbConnection(ConnectionString)
		Connection.Open()
    End Function
End Module