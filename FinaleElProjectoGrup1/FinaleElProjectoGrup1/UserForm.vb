Imports System.Data.OracleClient
Public Class UserForm
    'CODING SUB untuk dipanggil
    'untuk kondisi awal saat membuka Users form
    Sub kondisiAwal()
        Call clear()
        FormPanel.Visible = False
        Call ComboboxID()

        Call Koneksi()
        da = New OracleDataAdapter("SELECT * FROM USERS", conn)
        ds = New DataSet
        da.Fill(ds, "USERS")
        UserDataGridView.DataSource = (ds.Tables("USERS"))
    End Sub
    'Untuk mengisi item di Combobox
    Sub ComboboxID()
        Call Koneksi()
        UsrIDComboBox.Items.Clear()
        Dim IDCombo As String = "SELECT * FROM USERS"
        cmd = New OracleCommand(IDCombo, conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            UsrIDComboBox.Items.Add(dr.Item(0))
        Loop
    End Sub
    'Untuk membuat ID secara Otomatis
    Sub GenerateID()
        Call Koneksi()
        cmd = New OracleCommand("Select * FROM USERS WHERE ID_USER IN (SELECT max(ID_USER) FROM USERS)", conn)
        Dim kodegenerator As String
        Dim Hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            kodegenerator = "US" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
            kodegenerator = "US" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        UsrIDTextBox.Text = kodegenerator
        UsernameTextBox.Focus()
    End Sub
    'untuk mengosongkan Form Pengisian
    Sub clear()
        UsrIDComboBox.Text = ""
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub
    'Untuk mengelola tombol CRUD
    Sub disable()
        EditButton.Enabled = False
        TambahButton.Enabled = False
        HapusButton.Enabled = False
        LihatButton.Enabled = False
    End Sub
    Sub enable()
        EditButton.Enabled = True
        TambahButton.Enabled = True
        HapusButton.Enabled = True
        LihatButton.Enabled = True
    End Sub
    'Untuk mengelola tombol simpan
    Sub HapusLihat()
        FormPanel.Visible = True
        UsrIDComboBox.Visible = True
        UsrIDTextBox.Visible = False
        UsrIDTextBox.ReadOnly = True
        UsernameTextBox.Visible = True
        UsernameTextBox.ReadOnly = True
        PasswordTextBox.Visible = True
        PasswordTextBox.ReadOnly = True
    End Sub
    Sub TambahEdit()
        FormPanel.Visible = True
        UsernameTextBox.Visible = True
        UsernameTextBox.ReadOnly = False
        PasswordTextBox.Visible = True
        PasswordTextBox.ReadOnly = False
    End Sub

    'LOAD
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    'BUTTON
    'Coding Button CRUD
    Private Sub ProdTambahButton_Click(sender As Object, e As EventArgs) Handles TambahButton.Click
        Call TambahEdit()
        Call GenerateID()

        UsrIDComboBox.Visible = False
        UsrIDTextBox.Visible = True
        UsrIDTextBox.ReadOnly = True

        FormLabel.Text = "TAMBAH USER"
        ClearButton.Visible = True
        SimpanButton.Visible = True
        BatalButton.Visible = True
        ClearButton.Text = "Clear"
        SimpanButton.Text = "Simpan"

        Call disable()
    End Sub

    Private Sub HapusButton_Click(sender As Object, e As EventArgs) Handles HapusButton.Click
        Call HapusLihat()

        FormLabel.Text = " HAPUS USER"
        ClearButton.Visible = True
        SimpanButton.Visible = True
        BatalButton.Visible = True
        ClearButton.Text = "Clear"
        SimpanButton.Text = "Hapus"

        Call disable()
    End Sub

    Private Sub LihatButton_Click(sender As Object, e As EventArgs) Handles LihatButton.Click
        Call HapusLihat()

        FormLabel.Text = " LIHAT USER"
        ClearButton.Visible = True
        SimpanButton.Visible = False
        BatalButton.Visible = False
        ClearButton.Text = "Tutup"
        SimpanButton.Text = "Hapus"

        Call disable()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Call TambahEdit()

        UsrIDComboBox.Visible = True
        UsrIDTextBox.Visible = False
        UsrIDTextBox.ReadOnly = True

        FormLabel.Text = " EDIT USER "
        ClearButton.Visible = False
        SimpanButton.Visible = True
        BatalButton.Visible = True
        ClearButton.Text = "Clear"
        SimpanButton.Text = "Ubah"

        Call disable()
    End Sub

    'Tombol Clear
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        If ClearButton.Text = "Tutup" Then
            FormPanel.Visible = False
            Call clear()
            Call enable()
        Else
            Call clear()
        End If
    End Sub

    'Tombol Simpan
    Private Sub SimpanButton_Click(sender As Object, e As EventArgs) Handles SimpanButton.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Semua Kolom Harus Di Isi !")
        Else
            If SimpanButton.Text = "Simpan" Then
                Call Koneksi()
                Dim SimpanData As String = "INSERT INTO USERS VALUES ('" & UsrIDTextBox.Text & "', '" & UsernameTextBox.Text & "', '" & PasswordTextBox.Text & "')"
                cmd = New OracleCommand(SimpanData, conn)
                cmd.ExecuteReader()
                MsgBox("Data Disimpan !")
                Call kondisiAwal()
            ElseIf SimpanButton.Text = "Hapus" Then
                Call Koneksi()
                Dim FillData As String = "SELECT ID_USER FROM ORDERS WHERE ID_USER = '" & UsrIDComboBox.Text & "'"
                cmd = New OracleCommand(FillData, conn)
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then
                    MsgBox("Produk baru bisa dihapus setelah 2 tahun tanpa transaksi!!")
                Else
                    Dim HapusData As String = "DELETE FROM USERS WHERE ID_USER =  '" & UsrIDComboBox.Text & "'"
                    cmd = New OracleCommand(HapusData, conn)
                    cmd.ExecuteReader()
                    MsgBox("Data Dihapus !")
                    Call kondisiAwal()
                End If
            ElseIf SimpanButton.Text = "Ubah" Then
                Call Koneksi()
                Dim UbahData As String = "UPDATE USERS SET USERNAME_USER = '" & UsernameTextBox.Text & "', PASSWORD_USER = '" & PasswordTextBox.Text & "' WHERE ID_USER = '" & UsrIDComboBox.Text & "'"
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

    'Tombol Batal
    Private Sub BatalButton_Click(sender As Object, e As EventArgs) Handles BatalButton.Click
        FormPanel.Visible = False
        Call clear()
        Call enable()
    End Sub

    'Autofill
    Private Sub ProdIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UsrIDComboBox.SelectedIndexChanged
        Call Koneksi()
        Dim FillData As String = "SELECT * FROM USERS WHERE ID_USER =  '" & UsrIDComboBox.Text & "'"
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            UsernameTextBox.Text = dr!USERNAME_USER
            PasswordTextBox.Text = dr!PASSWORD_USER
        End If

    End Sub

    'Pencarian
    Private Sub PencarianTextbox_TextChanged(sender As Object, e As EventArgs) Handles PencarianTextbox.TextChanged
        Call Koneksi()
        cmd = New OracleCommand("SELECT * FROM USERS WHERE ID_USER LIKE '" & PencarianTextbox.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call Koneksi()
            da = New OracleDataAdapter("SELECT * FROM USERS WHERE ID_USER LIKE '" & PencarianTextbox.Text & "'", conn)
            ds = New DataSet
            da.Fill(ds, "KetemuData")
            UserDataGridView.DataSource = (ds.Tables("KetemuData"))
        Else
            Call kondisiAwal()
        End If
    End Sub
End Class