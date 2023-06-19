Imports System.Data.OracleClient
Public Class ProductForm

    'CODING SUB untuk dipanggil
    'untuk kondisi awal saat membuka Product form
    Sub kondisiAwal()
        Call clear()
        FormPanel.Visible = False
        Call ComboboxID()
        Call ComboboxKategori()

        Call Koneksi()
        da = New OracleDataAdapter("SELECT * FROM PRODUK", conn)
        ds = New DataSet
        da.Fill(ds, "PRODUK")
        ProdDataGridView.DataSource = (ds.Tables("PRODUK"))
    End Sub
    'Untuk mengisi item di Combobox
    Sub ComboboxID()
        Call Koneksi()
        ProdIDComboBox.Items.Clear()
        Dim IDCombo As String = "SELECT * FROM PRODUK"
        cmd = New OracleCommand(IDCombo, conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            ProdIDComboBox.Items.Add(dr.Item(0))
        Loop
    End Sub
    Sub ComboboxKategori()
        Call Koneksi()
        ProdKategoriComboBox.Items.Clear()
        Dim KategoriCombo As String = "SELECT * FROM KATEGORI"
        cmd = New OracleCommand(KategoriCombo, conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            ProdKategoriComboBox.Items.Add(dr.Item(1))
        Loop
    End Sub
    'Untuk membuat ID secara Otomatis
    Sub GenerateID()
        Call Koneksi()
        cmd = New OracleCommand("Select * FROM PRODUK WHERE ID_PRODUK IN (SELECT max(ID_PRODUK) FROM PRODUK)", conn)
        Dim kodegenerator As String
        Dim Hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            kodegenerator = "P" + "0001"
        Else
            Hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            kodegenerator = "P" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
        End If
        ProdIDTextBox.Text = kodegenerator
        ProdNamaTextBox.Focus()
    End Sub
    'untuk mengosongkan Form Pengisian
    Sub clear()
        ProdIDComboBox.Text = ""
        ProdNamaTextBox.Text = ""
        ProdHargaTextBox.Text = ""
        ProdJumlahTextBox.Text = ""
        ProdKategoriTextBox.Text = ""
        ProdKategoriComboBox.Text = ""
        ProdDeskripsiTextBox.Text = ""
    End Sub
    'Untuk mengelola tombol CRUD
    Sub disable()
        EditButton.Enabled = False
        TambahJumlahButton.Enabled = False
        ProdTambahButton.Enabled = False
        HapusButton.Enabled = False
        LihatButton.Enabled = False
    End Sub
    Sub enable()
        EditButton.Enabled = True
        TambahJumlahButton.Enabled = True
        ProdTambahButton.Enabled = True
        HapusButton.Enabled = True
        LihatButton.Enabled = True
    End Sub
    'Untuk mengelola tombol simpan
    Sub HapusLihatTJ()
        FormPanel.Visible = True
        ProdIDComboBox.Visible = True
        ProdIDTextBox.Visible = False
        ProdIDTextBox.ReadOnly = True
        ProdNamaTextBox.Visible = True
        ProdNamaTextBox.ReadOnly = True
        ProdHargaTextBox.Visible = True
        ProdHargaTextBox.ReadOnly = True
        ProdJumlahTextBox.Visible = True
        ProdJumlahTextBox.ReadOnly = True
        ProdKategoriTextBox.Visible = True
        ProdKategoriTextBox.ReadOnly = True
        ProdKategoriComboBox.Visible = False
        ProdDeskripsiTextBox.Visible = True
        ProdDeskripsiTextBox.ReadOnly = True
    End Sub
    Sub TambahEdit()
        FormPanel.Visible = True
        ProdNamaTextBox.Visible = True
        ProdNamaTextBox.ReadOnly = False
        ProdHargaTextBox.Visible = True
        ProdHargaTextBox.ReadOnly = False
        ProdJumlahTextBox.Visible = True
        ProdJumlahTextBox.ReadOnly = False
        ProdKategoriTextBox.Visible = False
        ProdKategoriTextBox.ReadOnly = True
        ProdKategoriComboBox.Visible = True
        ProdDeskripsiTextBox.Visible = True
        ProdDeskripsiTextBox.ReadOnly = False
    End Sub

    'LOAD
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    'CODING BUTTON
    'Coding Button CRUD
    Private Sub ProdTambahButton_Click(sender As Object, e As EventArgs) Handles ProdTambahButton.Click
        Call TambahEdit()
        Call GenerateID()

        ProdIDComboBox.Visible = False
        ProdIDTextBox.Visible = True
        ProdIDTextBox.ReadOnly = True

        FormLabel.Text = "TAMBAH PRODUK"
        ClearButton.Visible = True
        SimpanButton.Visible = True
        BatalButton.Visible = True
        ClearButton.Text = "Clear"
        SimpanButton.Text = "Simpan"

        Call disable()
    End Sub

    Private Sub HapusButton_Click(sender As Object, e As EventArgs) Handles HapusButton.Click
        Call HapusLihatTJ()

        FormLabel.Text = "HAPUS PRODUK"
        ClearButton.Visible = True
        SimpanButton.Visible = True
        BatalButton.Visible = True
        ClearButton.Text = "Clear"
        SimpanButton.Text = "Hapus"

        Call disable()
    End Sub

    Private Sub LihatButton_Click(sender As Object, e As EventArgs) Handles LihatButton.Click
        Call HapusLihatTJ()

        FormLabel.Text = "LIHAT PRODUK"
        ClearButton.Visible = True
        SimpanButton.Visible = False
        BatalButton.Visible = False
        ClearButton.Text = "Tutup"

        Call disable()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Call TambahEdit()

        ProdIDComboBox.Visible = True
        ProdIDTextBox.Visible = False
        ProdIDTextBox.ReadOnly = True

        FormLabel.Text = "EDIT PRODUK"
        ClearButton.Visible = False
        SimpanButton.Visible = True
        BatalButton.Visible = True
        ClearButton.Text = "Clear"
        SimpanButton.Text = "Ubah"

        Call disable()
    End Sub

    Private Sub TambahJumlahButton_Click(sender As Object, e As EventArgs) Handles TambahJumlahButton.Click
        Call HapusLihatTJ()

        ProdIDComboBox.Visible = True
        ProdIDTextBox.Visible = False
        ProdIDTextBox.ReadOnly = True
        ProdJumlahTextBox.ReadOnly = False

        FormLabel.Text = "TAMBAH JUMLAH"
        ClearButton.Visible = True
        SimpanButton.Visible = True
        BatalButton.Visible = True
        ClearButton.Text = "Clear"
        SimpanButton.Text = "Tambah"

        Call disable()
    End Sub

    'Coding Button Clear Batal Simpan
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        If ClearButton.Text = "Tutup" Then
            FormPanel.Visible = False
            Call clear()
            Call enable()
        Else
            Call clear()
        End If
    End Sub

    Private Sub SimpanButton_Click(sender As Object, e As EventArgs) Handles SimpanButton.Click
        If ProdNamaTextBox.Text = "" Or ProdHargaTextBox.Text = "" Or ProdJumlahTextBox.Text = "" Then
            MsgBox("Semua Kolom Harus Diisi!!!")
        Else
            If SimpanButton.Text = "Simpan" Then
                If ProdKategoriComboBox.Text = "" Or ProdDeskripsiTextBox.Text = "" Then
                    MsgBox("Semua Kolom Harus Diisi!!!")
                Else
                    Call Koneksi()
                    Dim SimpanData As String = "INSERT INTO PRODUK VALUES ('" & ProdIDTextBox.Text & "', '" & IDKategori.Text & "', '" & ProdNamaTextBox.Text & "','" & ProdJumlahTextBox.Text & "','" & ProdHargaTextBox.Text & "','" & ProdKategoriComboBox.Text & "','" & ProdDeskripsiTextBox.Text & "')"
                    cmd = New OracleCommand(SimpanData, conn)
                    cmd.ExecuteReader()
                    MsgBox("Data Disimpan !")
                    Call kondisiAwal()
                End If
            ElseIf SimpanButton.Text = "Tambah" Then
                Call Koneksi()
                Dim TambahData As String = "UPDATE PRODUK SET JUMLAH_PRODUK = JUMLAH_PRODUK + '" & ProdJumlahTextBox.Text & "' WHERE ID_PRODUK =  '" & ProdIDComboBox.Text & "'"
                cmd = New OracleCommand(TambahData, conn)
                cmd.ExecuteReader()
                MsgBox("Data Ditambah !")
                Call kondisiAwal()
            ElseIf SimpanButton.Text = "Hapus" Then
                Call Koneksi()
                Dim FillData As String = "SELECT ID_PRODUK FROM ORDER_NOTES WHERE ID_PRODUK = '" & ProdIDComboBox.Text & "'"
                cmd = New OracleCommand(FillData, conn)
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then
                    MsgBox("Produk baru bisa dihapus setelah 2 tahun tanpa transaksi!!")
                Else
                    Dim HapusData As String = "DELETE FROM PRODUK WHERE ID_PRODUK =  '" & ProdIDComboBox.Text & "'"
                    cmd = New OracleCommand(HapusData, conn)
                    cmd.ExecuteReader()
                    MsgBox("Data Dihapus !")
                    Call kondisiAwal()
                End If

            ElseIf SimpanButton.Text = "Ubah" Then
                Call Koneksi()
                Dim UbahData As String = "UPDATE PRODUK SET ID_KATEGORI = '" & IDKategori.Text & "', NAMA_PRODUK = '" & ProdNamaTextBox.Text & "', JUMLAH_PRODUK = '" & ProdJumlahTextBox.Text & "', HARGA_PRODUK = '" & ProdHargaTextBox.Text & "', NAMA_KATEGORI = '" & ProdKategoriComboBox.Text & "', DESKRIPSI_PRODUK = '" & ProdDeskripsiTextBox.Text & "' WHERE ID_PRODUK =  '" & ProdIDComboBox.Text & "'"
                cmd = New OracleCommand(UbahData, conn)
                cmd.ExecuteReader()
                MsgBox("Data Diubah !")
                Call kondisiAwal()
            End If

            FormPanel.Visible = False
            Call clear()
            Call enable()
        End If
    End Sub

    Private Sub BatalButton_Click(sender As Object, e As EventArgs) Handles BatalButton.Click
        FormPanel.Visible = False
        Call clear()
        Call enable()
    End Sub

    'CODING BUKAN BUTTON
    'Auto fill Combobox
    Private Sub ProdIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProdIDComboBox.SelectedIndexChanged
        Call Koneksi()
        Dim FillData As String = "SELECT * FROM PRODUK WHERE ID_PRODUK =  '" & ProdIDComboBox.Text & "'"
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            ProdNamaTextBox.Text = dr!NAMA_PRODUK
            ProdJumlahTextBox.Text = dr!JUMLAH_PRODUK
            ProdHargaTextBox.Text = dr!HARGA_PRODUK
            ProdDeskripsiTextBox.Text = dr!DESKRIPSI_PRODUK
            If ProdKategoriTextBox.Visible = False Then
                ProdKategoriComboBox.Text = dr!NAMA_KATEGORI
            Else
                ProdKategoriTextBox.Text = dr!NAMA_KATEGORI
            End If
        End If

    End Sub
    'mendapatkan ID Kategori dari Combobox Kategori
    Private Sub ProdKategoriComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProdKategoriComboBox.SelectedIndexChanged
        Call Koneksi()
        Dim FillData As String = "SELECT * FROM KATEGORI WHERE NAMA_KATEGORI =  '" & ProdKategoriComboBox.Text & "' "
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            IDKategori.Text = dr!ID_KATEGORI
        End If
    End Sub
    'Text box Pencarian 
    Private Sub PencarianTextbox_TextChanged(sender As Object, e As EventArgs) Handles PencarianTextbox.TextChanged
        Call Koneksi()
        cmd = New OracleCommand("SELECT * FROM PRODUK WHERE ID_PRODUK LIKE '" & PencarianTextbox.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call Koneksi()
            da = New OracleDataAdapter("SELECT * FROM PRODUK WHERE ID_PRODUK LIKE '" & PencarianTextbox.Text & "'", conn)
            ds = New DataSet
            da.Fill(ds, "KetemuData")
            ProdDataGridView.DataSource = (ds.Tables("KetemuData"))
        Else
            Call kondisiAwal()
        End If
    End Sub
End Class