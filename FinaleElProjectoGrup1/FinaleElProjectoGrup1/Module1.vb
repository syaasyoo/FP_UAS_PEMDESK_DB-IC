Imports System.Data.OracleClient
Module Module1
    'Inisialisasi library
    Public conn As New OracleConnection
    Public cmd As New OracleCommand
    Public dr As OracleDataReader
    Public da As OracleDataAdapter
    Public ds As DataSet
    Public un As String
    Public ids As String
    'Koneksi ke database
    Sub Koneksi()
        conn.Close()
        conn = New OracleConnection("data source=(DESCRIPTION = " &
        "(ADDRESS = (PROTOCOL = TCP)(HOST = LAPTOP-MFA5005P)(PORT = 1521)) " &
        "(CONNECT_DATA = " &
        "(SERVER = DEDICATED)" &
        "(SERVICE_NAME = XE)" &
        ")" &
        "); user id = INVENTORYDB; password = system;")
        conn.Open()
    End Sub
End Module