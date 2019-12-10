Imports System.Data.Odbc
Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public x As Integer
    Public s As String = ""
    Public t As String = ""
    Public OLECMD As OleDbCommand
    Public OLERDR As OleDbDataReader
    Public CON As OleDbConnection
    Public KONEKSI As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
        Application.StartupPath & "\db.accdb;"
End Module
