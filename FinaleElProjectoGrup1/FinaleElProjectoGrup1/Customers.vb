Imports System.Data.OracleClient
Imports System.Runtime.Remoting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Customers
    'SUB
    'untuk mengosongkan Form Pengisian
    Sub clear()
        CstIDComboBox.Text = ""
        CstNamaTextBox.Text = ""
        CstTelpTextBox.Text = ""
        CstAlamatTextBox.Text = ""
    End Sub
    'untuk kondisi awal saat membuka Customers form
    Sub kondisiAwal()
        Call clear()
        CstPanel2.Visible = False
        Call ComboboxID()

        Call Koneksi()
        da = New OracleDataAdapter("SELECT * FROM CUSTOMER", conn)
        ds = New DataSet
        da.Fill(ds, "CUSTOMER")
        CstDataGridView.DataSource = (ds.Tables("CUSTOMER"))
    End Sub
    'Untuk mengisi item di Combobox
    Sub ComboboxID()
        Call Koneksi()
        CstIDComboBox.Items.Clear()
        Dim IDCombo As String = "SELECT * FROM CUSTOMER"
        cmd = New OracleCommand(IDCombo, conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            CstIDComboBox.Items.Add(dr.Item(0))
        Loop
    End Sub
    'Untuk mengelola tombol CRUD
    Sub disable()
        CstEditButton.Enabled = False
        CstTambahButton.Enabled = False
        CstHapusButton.Enabled = False
        CstLihatButton.Enabled = False
    End Sub
    Sub enable()
        CstEditButton.Enabled = True
        CstTambahButton.Enabled = True
        CstHapusButton.Enabled = True
        CstLihatButton.Enabled = True
    End Sub

    'untuk mengelola tombol simpan
    Sub HapusLihat()
        CstPanel2.Visible = True
        CstIDComboBox.Visible = True
        CstIDTextBox.Visible = False
        CstIDTextBox.ReadOnly = True
        CstNamaTextBox.Visible = True
        CstNamaTextBox.ReadOnly = True
        CstTelpTextBox.Visible = True
        CstTelpTextBox.ReadOnly = True
        CstAlamatTextBox.Visible = True
        CstAlamatTextBox.ReadOnly = True
    End Sub
    Sub TambahEdit()
        CstPanel2.Visible = True
        CstNamaTextBox.Visible = True
        CstNamaTextBox.ReadOnly = False
        CstTelpTextBox.Visible = True
        CstTelpTextBox.ReadOnly = False
        CstAlamatTextBox.Visible = True
        CstAlamatTextBox.ReadOnly = False
    End Sub

    'Untuk membuat ID secara Otomatis
    Sub GenerateID()
        '-- Membuat kode unik Id--
        Call Koneksi()
        cmd = New OracleCommand("Select * FROM CUSTOMER WHERE ID_CUSTOMER IN (SELECT max(ID_CUSTOMER) FROM CUSTOMER)", conn)
        Dim kodegenerator As String
        Dim Hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            kodegenerator = "CST" + "0001"
        Else
            Hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            kodegenerator = "CST" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
        End If
        CstIDTextBox.Text = kodegenerator
        CstNamaTextBox.Focus()
    End Sub

    'LOAD
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    'BUTTON
    'Untuk Button Clear
    Private Sub CstClearButton_Click(sender As Object, e As EventArgs) Handles CstClearButton.Click
        CstIDComboBox.Text = ""
        CstNamaTextBox.Text = ""
        CstTelpTextBox.Text = ""
        CstAlamatTextBox.Text = ""
        CstCariTextBox.Text = ""
        If CstClearButton.Text = "Tutup" Then
            CstPanel2.Visible = False
            Call clear()
            Call enable()
        End If
    End Sub

    'Untuk Button CRUD
    Private Sub CstTambahButton_Click(sender As Object, e As EventArgs) Handles CstTambahButton.Click
        Call TambahEdit()
        Call GenerateID()

        CstIDComboBox.Visible = False
        CstIDTextBox.Visible = True
        CstIDTextBox.ReadOnly = True

        CstFormLabel.Text = "TAMBAH CUSTOMER"
        CstClearButton.Visible = True
        CstSimpanButton.Visible = True
        CstBatalButton.Visible = True
        CstClearButton.Text = "Clear"
        CstSimpanButton.Text = "Simpan"

        Call disable()

    End Sub

    Private Sub CstEditButton_Click(sender As Object, e As EventArgs) Handles CstEditButton.Click
        Call TambahEdit()

        CstIDComboBox.Visible = True
        CstIDTextBox.Visible = False
        CstIDTextBox.ReadOnly = True

        CstFormLabel.Text = " EDIT CUSTOMER "
        CstClearButton.Visible = False
        CstSimpanButton.Visible = True
        CstBatalButton.Visible = True
        CstClearButton.Text = "Clear"
        CstSimpanButton.Text = "Ubah"

        Call disable()

    End Sub

    Private Sub CstHapusButton_Click(sender As Object, e As EventArgs) Handles CstHapusButton.Click
        Call HapusLihat()

        CstFormLabel.Text = " HAPUS CUSTOMER"
        CstClearButton.Visible = True
        CstSimpanButton.Visible = True
        CstBatalButton.Visible = True
        CstClearButton.Text = "Clear"
        CstSimpanButton.Text = "Hapus"

        Call disable()
    End Sub
    Private Sub CstLihatButton_Click(sender As Object, e As EventArgs) Handles CstLihatButton.Click
        Call HapusLihat()
        CstFormLabel.Text = " LIHAT CUSTOMER"
        CstClearButton.Visible = True
        CstSimpanButton.Visible = False
        CstBatalButton.Visible = False
        CstClearButton.Text = "Tutup"
        CstSimpanButton.Text = "Hapus"
        Call disable()
    End Sub

    'Untuk Button Batal
    Private Sub CstBatalButton_Click(sender As Object, e As EventArgs) Handles CstBatalButton.Click
        CstPanel2.Visible = False
        Call clear()
        Call enable()
    End Sub

    'Untuk Pencarian textbox
    Private Sub CstCariTextBox_TextChanged(sender As Object, e As EventArgs) Handles CstCariTextBox.TextChanged
        Call Koneksi()
        cmd = New OracleCommand("SELECT * FROM CUSTOMER WHERE ID_CUSTOMER LIKE '%" & CstCariTextBox.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call Koneksi()
            da = New OracleDataAdapter("SELECT * FROM CUSTOMER WHERE ID_CUSTOMER LIKE '%" & CstCariTextBox.Text & "'", conn)
            ds = New DataSet
            da.Fill(ds, "KetemuData")
            CstDataGridView.DataSource = (ds.Tables("KetemuData"))
        Else
            Call kondisiAwal()
        End If
    End Sub

    'Untuk Tombol simpan
    Private Sub CstSimpanButton_Click(sender As Object, e As EventArgs) Handles CstSimpanButton.Click
        If CstSimpanButton.Text = "Simpan" Then
            If CstNamaTextBox.Text = "" Or CstTelpTextBox.Text = "" Or CstAlamatTextBox.Text = "" Then
                MsgBox("Semua Kolom Harus Di Isi !")
            Else
                Call Koneksi()
                Dim SimpanData As String = "INSERT INTO CUSTOMER VALUES('" & CstIDTextBox.Text & "', '" & CstNamaTextBox.Text & "','" & CstTelpTextBox.Text & "', '" & CstAlamatTextBox.Text & "')"
                cmd = New OracleCommand(SimpanData, conn)
                cmd.ExecuteReader()
                MsgBox("Data Tersimpan !")
                Call kondisiAwal()
            End If
        ElseIf CstSimpanButton.Text = "Ubah" Then
            If CstIDComboBox.Text = "" Or CstNamaTextBox.Text = "" Or CstTelpTextBox.Text = "" Or CstAlamatTextBox.Text = "" Then
                MsgBox("Semua Kolom Harus Terisi !")
            Else
                Call Koneksi()
                Dim EditData As String = "UPDATE CUSTOMER SET NAMA_CUSTOMER = '" & CstNamaTextBox.Text & "', NOTELP_CUSTOMER ='" & CstTelpTextBox.Text & "', ALAMAT_CUSTOMER = '" & CstAlamatTextBox.Text & "' WHERE ID_CUSTOMER ='" & CstIDComboBox.Text & "'"
                cmd = New OracleCommand(EditData, conn)
                cmd.ExecuteReader()
                MsgBox("Data Tersimpan !")
                Call kondisiAwal()
            End If
        ElseIf CstSimpanButton.Text = "Hapus" Then
            If CstIDComboBox.Text = "" Then
                MsgBox("Kolom ID Harus Terisi !")
            Else
                Call Koneksi()
                Dim FillData As String = "SELECT ID_CUSTOMER FROM ORDERS WHERE ID_CUSTOMER = '" & CstIDComboBox.Text & "'"
                cmd = New OracleCommand(FillData, conn)
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then
                    MsgBox("Produk baru bisa dihapus setelah 2 tahun tanpa transaksi!!")
                Else
                    Dim HapusData As String = "DELETE CUSTOMER WHERE ID_CUSTOMER = '" & CstIDComboBox.Text & "'"
                    cmd = New OracleCommand(HapusData, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Di Hapus")
                    Call kondisiAwal()
                End If
            End If
        End If

        CstPanel2.Visible = False
        Call clear()
        Call enable()
    End Sub

    'Autofill Combobox
    Private Sub CstIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CstIDComboBox.SelectedIndexChanged
        Call Koneksi()
        Dim FillData As String = "SELECT * FROM CUSTOMER WHERE ID_CUSTOMER =  '" & CstIDComboBox.Text & "'"
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            CstNamaTextBox.Text = dr!NAMA_CUSTOMER
            CstTelpTextBox.Text = dr!NOTELP_CUSTOMER
            CstAlamatTextBox.Text = dr!ALAMAT_CUSTOMER
        End If
    End Sub
End Class