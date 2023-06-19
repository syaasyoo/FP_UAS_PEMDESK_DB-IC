Imports System.Data.OracleClient
Public Class Categories
    'SUB
    'untuk mengosongkan Form Pengisian
    Sub clear()
        CtgIDTextBox.Text = ""
        CtgIDComboBox.Text = ""
        CtgNamaTextBox.Text = ""
    End Sub
    'untuk kondisi awal saat membuka Categories form
    Sub kondisiAwal()
        Call clear()
        CtgPanel2.Visible = False
        Call ComboboxID()

        Call Koneksi()
        da = New OracleDataAdapter("SELECT * FROM KATEGORI", conn)
        ds = New DataSet
        da.Fill(ds, "KATEGORI")
        CtgDataGridView.DataSource = (ds.Tables("KATEGORI"))
    End Sub
    'Untuk mengisi item di Combobox
    Sub ComboboxID()
        Call Koneksi()
        CtgIDComboBox.Items.Clear()
        Dim IDCombo As String = "SELECT * FROM KATEGORI"
        cmd = New OracleCommand(IDCombo, conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            CtgIDComboBox.Items.Add(dr.Item(0))
        Loop
    End Sub
    'Untuk mengelola tombol CRUD
    Sub disable()
        CtgEditButton.Enabled = False
        CtgTambahButton.Enabled = False
        CtgHapusButton.Enabled = False
        CtgLihatButton.Enabled = False
    End Sub
    Sub enable()
        CtgEditButton.Enabled = True
        CtgTambahButton.Enabled = True
        CtgHapusButton.Enabled = True
        CtgLihatButton.Enabled = True
    End Sub

    'untuk mengelola tombol simpan
    Sub HapusLihat()
        CtgPanel2.Visible = True
        CtgIDComboBox.Visible = True
        CtgIDTextBox.Visible = False
        CtgIDTextBox.ReadOnly = True
        CtgNamaTextBox.Visible = True
        CtgNamaTextBox.ReadOnly = True
    End Sub
    Sub TambahEdit()
        CtgPanel2.Visible = True
        CtgNamaTextBox.Visible = True
        CtgNamaTextBox.ReadOnly = False
    End Sub

    'Untuk membuat ID secara Otomatis
    Sub GenerateID()
        '-- Membuat kode unik Id--
        Call Koneksi()
        cmd = New OracleCommand("Select * FROM KATEGORI WHERE ID_KATEGORI IN (SELECT max(ID_KATEGORI) FROM KATEGORI)", conn)
        Dim kodegenerator As String
        Dim Hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            kodegenerator = "CTG" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
            kodegenerator = "CTG" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        CtgIDTextBox.Text = kodegenerator
        CtgNamaTextBox.Focus()
    End Sub

    'LOAD
    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    'BUTTON
    'Untuk Button Clear
    Private Sub CtgClearButton_Click(sender As Object, e As EventArgs) Handles CtgClearButton.Click
        CtgIDComboBox.Text = ""
        CtgNamaTextBox.Text = ""
        CtgCariTextBox.Text = ""
        If CtgClearButton.Text = "Tutup" Then
            CtgPanel2.Visible = False
            Call clear()
            Call enable()
        End If
    End Sub
    'Untuk Tombol CRUD
    Private Sub CtgTambahButton_Click(sender As Object, e As EventArgs) Handles CtgTambahButton.Click
        Call TambahEdit()
        Call GenerateID()

        CtgIDComboBox.Visible = False
        CtgIDTextBox.Visible = True
        CtgIDTextBox.ReadOnly = True
        CtgFormLabel.Text = "TAMBAH KATEGORI"
        CtgClearButton.Visible = True
        CtgSimpanButton.Visible = True
        CtgBatalButton.Visible = True
        CtgClearButton.Text = "Clear"
        CtgSimpanButton.Text = "Simpan"

        Call disable()
    End Sub
    Private Sub CtgEditButton_Click(sender As Object, e As EventArgs) Handles CtgEditButton.Click
        Call TambahEdit()
        CtgIDComboBox.Visible = True
        CtgIDTextBox.Visible = False
        CtgIDTextBox.ReadOnly = True

        CtgFormLabel.Text = "EDIT KATEGORI"
        CtgClearButton.Visible = False
        CtgSimpanButton.Visible = True
        CtgBatalButton.Visible = True
        CtgClearButton.Text = "Clear"
        CtgSimpanButton.Text = "Ubah"

        Call disable()
    End Sub
    Private Sub CtgHapusButton_Click(sender As Object, e As EventArgs) Handles CtgHapusButton.Click
        Call HapusLihat()
        CtgFormLabel.Text = "HAPUS KATEGORI"
        CtgClearButton.Visible = True
        CtgSimpanButton.Visible = True
        CtgBatalButton.Visible = True
        CtgClearButton.Text = "Clear"
        CtgSimpanButton.Text = "Hapus"

        Call disable()
    End Sub
    Private Sub CtgLihatButton_Click(sender As Object, e As EventArgs) Handles CtgLihatButton.Click
        Call HapusLihat()
        CtgFormLabel.Text = " LIHAT KATEGORI"
        CtgClearButton.Visible = True
        CtgSimpanButton.Visible = False
        CtgBatalButton.Visible = False
        CtgClearButton.Text = "Tutup"
        CtgSimpanButton.Text = "Hapus"
        Call disable()
    End Sub
    'Untuk Tombol Batal
    Private Sub CtgBatalButton_Click(sender As Object, e As EventArgs) Handles CtgBatalButton.Click
        CtgPanel2.Visible = False
        Call clear()
        Call enable()
    End Sub
    'Untuk  Pencarian
    Private Sub CtgCariTextBox_TextChanged(sender As Object, e As EventArgs) Handles CtgCariTextBox.TextChanged
        Call Koneksi()
        cmd = New OracleCommand("SELECT * FROM KATEGORI WHERE ID_KATEGORI  LIKE '%" & CtgCariTextBox.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call Koneksi()
            da = New OracleDataAdapter("SELECT * FROM KATEGORI WHERE ID_KATEGORI LIKE '%" & CtgCariTextBox.Text & "'", conn)
            ds = New DataSet
            da.Fill(ds, "KetemuData")
            CtgDataGridView.DataSource = (ds.Tables("KetemuData"))
        Else
            Call kondisiAwal()
        End If
    End Sub
    'Untuk Tombol Simpan
    Private Sub CtgSimpanButton_Click(sender As Object, e As EventArgs) Handles CtgSimpanButton.Click
        If CtgNamaTextBox.Text = "" Then
            MsgBox("Semua Kolom Harus Di Isi !")
        Else
            If CtgSimpanButton.Text = "Simpan" Then
                Call Koneksi()
                Dim SimpanData As String = "INSERT INTO KATEGORI VALUES('" & CtgIDTextBox.Text & "', '" & CtgNamaTextBox.Text & "')"
                cmd = New OracleCommand(SimpanData, conn)
                cmd.ExecuteReader()
                MsgBox("Data Tersimpan !")
                Call kondisiAwal()
            ElseIf CtgSimpanButton.Text = "Ubah" Then
                If CtgIDComboBox.Text = "" Then
                    MsgBox("Semua Kolom Harus Di Isi !")
                Else
                    Call Koneksi()
                    Dim EditData As String = "UPDATE KATEGORI SET NAMA_KATEGORI = '" & CtgNamaTextBox.Text & "' WHERE ID_KATEGORI = '" & CtgIDComboBox.Text & "'"
                    cmd = New OracleCommand(EditData, conn)
                    cmd.ExecuteReader()
                    MsgBox("Data Tersimpan !")
                    Call kondisiAwal()
                End If
            ElseIf CtgSimpanButton.Text = "Hapus" Then
                If CtgIDComboBox.Text = "" Then
                    MsgBox("Semua Kolom Harus Di Isi !")
                Else
                    Call Koneksi()
                    Dim FillData As String = "SELECT * FROM PRODUK WHERE ID_KATEGORI =  '" & CtgIDComboBox.Text & "'"
                    cmd = New OracleCommand(FillData, conn)
                    dr = cmd.ExecuteReader()
                    dr.Read()
                    If dr.HasRows Then
                        MsgBox("Kategori Ini Tidak bisa dihapus!!")
                    Else
                        Dim HapusData As String = "DELETE KATEGORI WHERE ID_KATEGORI = '" & CtgIDComboBox.Text & "'"
                        cmd = New OracleCommand(HapusData, conn)
                        cmd.ExecuteReader()
                        MsgBox("Data Berhasil Di Hapus")
                    End If
                    Call kondisiAwal()
                End If
            End If
            CtgPanel2.Visible = False
            Call clear()
            Call enable()
        End If
    End Sub
    'Autofill Combobox
    Private Sub CtgIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CtgIDComboBox.SelectedIndexChanged
        Call Koneksi()
        Dim FillData As String = "SELECT * FROM KATEGORI WHERE ID_KATEGORI =  '" & CtgIDComboBox.Text & "'"
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            CtgNamaTextBox.Text = dr!NAMA_KATEGORI
        End If
    End Sub
End Class