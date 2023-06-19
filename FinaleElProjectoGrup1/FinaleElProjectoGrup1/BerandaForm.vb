Imports System.Data.OracleClient

Public Class BerandaForm
    'Inisialisasi beranda
    Private Sub BerandaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalcustomer()
        totalproduk()
        totalkategori()
        totalorder()
        datastok()
        orderspending()
    End Sub
    'Untuk menampilkan data Produk
    Sub datastok()
        Call Koneksi()
        da = New OracleDataAdapter("SELECT ID_PRODUK, NAMA_PRODUK,JUMLAH_PRODUK FROM PRODUK", conn)
        ds = New DataSet
        da.Fill(ds, "PRODUK")
        ProdDataGridView.DataSource = (ds.Tables("PRODUK"))
    End Sub
    'Untuk menampilkan data dengan status pending
    Sub orderspending()
        Call Koneksi()
        da = New OracleDataAdapter("SELECT ID_ORDER, ID_CUSTOMER, NAMA_CUSTOMER, STATUS FROM ORDERS WHERE STATUS = '" & "PENDING" & "'", conn)
        ds = New DataSet
        da.Fill(ds, "ORDERS")
        OPDataGrid.DataSource = (ds.Tables("ORDERS"))
    End Sub
    'Menghitung Total Produk, kategori, customer, order
    Sub totalcustomer()
        Call Koneksi()
        Dim FillData As String = "Select count(ID_CUSTOMER) total from customer "
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            lbl_totalcustomer.Text = dr!total
        End If
    End Sub
    Sub totalproduk()
        Call Koneksi()
        Dim FillData As String = "Select count(ID_PRODUK) total from produk "
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            lbl_totalProduct.Text = dr!total
        End If
    End Sub
    Sub totalkategori()
        Call Koneksi()
        Dim FillData As String = "Select count(ID_KATEGORI) total from kategori "
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            lbl_totalkategori.Text = dr!total
        End If
    End Sub
    Sub totalorder()
        Call Koneksi()
        Dim FillData As String = "Select count(ID_ORDER) total FROM ORDERS WHERE STATUS = '" & "PENDING" & "'"
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            lbl_order.Text = dr!total
        End If
    End Sub
End Class