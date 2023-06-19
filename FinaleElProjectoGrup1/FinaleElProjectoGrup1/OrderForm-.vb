Imports System.Data.OracleClient
Public Class OrderForm
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ CODING SUB \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Sub kondisiAwal()
        Call HapusDone()
        Call clear2()
        Call clear()
        KontrolPanel.Visible = False
        OFOrderDataGrid.Visible = False
        FormBarangPanel.Visible = False
        TotalPanel.Visible = False
        BatalOrderButton.Enabled = False
        PlaceOrderButton.Enabled = False
        BuatFormPanel.Enabled = True
        FormPanel.Visible = True
        PanelOrderNote.Visible = False
        HistoryID.ReadOnly = False

        Call GenerateID()
        Call ComboboxIDCust()
        Call ComboboxNamaCust()
        Call ComboboxKategori()
        Call ComboboxIDProd()
        Call Aksi()
        Call Disable()
        Call Tabel()
        Call Tabel2()

        LabelIDUser.Text = ids
        LabelUsername.Text = un


        Call Koneksi()
        da = New OracleDataAdapter("SELECT ID_PRODUK, NAMA_PRODUK, JUMLAH_ORDER, TOTAL_SEMENTARA Total FROM ORDER_NOTES WHERE ID_ORDER ='" & IDOrderTextBox.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "ORDER_NOTES")
        OFOrderDataGrid.DataSource = (ds.Tables("ORDER_NOTES"))
    End Sub
    '||||||||||||||||||||||||||||||||||||||1.ORDER FORM||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    'SUB BUAT FORM
    Sub GenerateID()
        Call Koneksi()
        cmd = New OracleCommand("Select * FROM ORDERS WHERE ID_ORDER IN (SELECT max(ID_ORDER) FROM ORDERS)", conn)
        Dim kodegenerator As String
        Dim Hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            kodegenerator = "OR" + "00001"
        Else
            Hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 5) + 1
            kodegenerator = "OR" + Microsoft.VisualBasic.Right("00000" & Hitung, 5)
        End If
        IDOrderTextBox.Text = kodegenerator
        IDCustomerComboBox.Focus()
    End Sub
    Sub ComboboxIDCust()
        Call Koneksi()
        IDCustomerComboBox.Items.Clear()
        Dim KategoriCombo As String = "SELECT * FROM CUSTOMER"
        cmd = New OracleCommand(KategoriCombo, conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            IDCustomerComboBox.Items.Add(dr.Item(0))
        Loop
    End Sub
    Sub ComboboxNamaCust()
        Call Koneksi()
        NamaCustomerComboBox.Items.Clear()
        Dim KategoriCombo As String = "SELECT * FROM CUSTOMER"
        cmd = New OracleCommand(KategoriCombo, conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            NamaCustomerComboBox.Items.Add(dr.Item(1))
        Loop
    End Sub
    Sub clear()
        IDCustomerComboBox.Text = ""
        NamaCustomerComboBox.Text = ""
        OFNoTelpTextBox.Text = ""
        OFAlamatTextbox.Text = ""
        TanggalDateTimePicker.Value = Today
    End Sub

    'SUB BARANG FORM
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
    Sub ComboboxIDProd()
        Call Koneksi()
        ProdIDComboBox.Items.Clear()
        Dim IDCombo As String
        If SimpanButton.Text = "Hapus" Or SimpanButton.Text = "Ubah" Then
            IDCombo = "SELECT * FROM ORDER_NOTES WHERE ID_ORDER = '" & IDOrderTextBox.Text & "'"
        Else
            IDCombo = "SELECT * FROM PRODUK WHERE ID_KATEGORI ='" & IDKategori.Text & "'"
        End If
        cmd = New OracleCommand(IDCombo, conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            ProdIDComboBox.Items.Add(dr.Item(0))
        Loop
    End Sub
    Sub ComboboxNamaProd()
        Call Koneksi()
        NamaProdukComboBox.Items.Clear()
        Dim IDCombo As String = "SELECT NAMA_PRODUK FROM PRODUK WHERE ID_KATEGORI ='" & IDKategori.Text & "'"
        cmd = New OracleCommand(IDCombo, conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            NamaProdukComboBox.Items.Add(dr.Item("NAMA_PRODUK"))
        Loop
    End Sub
    Sub clear2()
        ProdKategoriComboBox.Text = ""
        ProdIDComboBox.Text = ""
        NamaProdukTextBox.Text = ""
        NamaProdukComboBox.Text = ""
        ProdJumlahTextBox.Text = ""
        If SimpanButton.Text = "Tambah" Then
            NamaProdukComboBox.Items.Clear()
            ProdIDComboBox.Items.Clear()
        End If
    End Sub
    Sub HapusEditTambah()
        FormBarangPanel.Visible = True
        KategoriTextBox.Visible = True
        ProdKategoriComboBox.Visible = False
        ProdIDComboBox.Visible = True
        NamaProdukComboBox.Visible = False
        NamaProdukTextBox.Visible = True
        ProdJumlahTextBox.Visible = True
        BatalOrderButton.Enabled = False
        PlaceOrderButton.Enabled = False
        TambahBarangButton.Enabled = False
        HapusBarangButton.Enabled = False
        EditJumlahButton.Enabled = False
        LabelKategori.Visible = True
    End Sub
    Sub SimpanBatal()
        FormBarangPanel.Visible = False
        Call clear2()
        BatalOrderButton.Enabled = True
        PlaceOrderButton.Enabled = True
        TambahBarangButton.Enabled = True
        HapusBarangButton.Enabled = True
        EditJumlahButton.Enabled = True
    End Sub
    Sub kaliHarga()
        Call Koneksi()
        Dim Harga As String = "SELECT HARGA_PRODUK FROM PRODUK WHERE ID_PRODUK = '" & ProdIDComboBox.Text & "'"
        cmd = New OracleCommand(Harga, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        LabelHarga.Text = dr!HARGA_PRODUK
    End Sub
    Sub Total()
        Call Koneksi()
        Dim FillData As String = "SELECT SUM(TOTAL_SEMENTARA) TOTAL FROM ORDER_NOTES WHERE ID_ORDER =  '" & IDOrderTextBox.Text & "'"
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            OFTotalLabel.Text = dr!TOTAL
        End If
    End Sub
    '||||||||||||||||||||||||||||||||||||||1.ORDER FORM||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    '||||||||||||||||||||||||||||||||||||||2.ORDER CONTROL|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    Sub Clear3()
        OCOrderIDTextBox.Text = ""
        OCAlamatTextBox.Text = ""
        OCNoTelpTextBox.Text = ""
        OCTotalLabel.Text = 0
        TanggalTextBox.Text = ""
        NamaCustomerTextBox.Text = ""
        IDCustomerTextBox.Text = ""
    End Sub
    Sub Aksi()
        Dim Cek As String = "SELECT ID_ORDER FROM ORDERS"
        cmd = New OracleCommand(Cek, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            Dim Ambil As String = "SELECT * FROM ORDERS WHERE ID_ORDER IN (SELECT MIN(ID_ORDER) FROM ORDERS WHERE STATUS = '" & "PENDING" & "') "
            cmd = New OracleCommand(Ambil, conn)
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                OCOrderIDTextBox.Text = dr!ID_ORDER
                OCAlamatTextBox.Text = dr!ALAMAT_CUSTOMER
                OCNoTelpTextBox.Text = dr!NOTELP_CUSTOMER
                OCTotalLabel.Text = dr!TOTAL
                TanggalTextBox.Text = dr!TANGGAL
                NamaCustomerTextBox.Text = dr!NAMA_CUSTOMER
                IDCustomerTextBox.Text = dr!ID_CUSTOMER
            End If

        End If

        Call Koneksi()
        da = New OracleDataAdapter("SELECT ID_PRODUK, NAMA_PRODUK, JUMLAH_ORDER, TOTAL_SEMENTARA Total FROM ORDER_NOTES WHERE ID_ORDER ='" & OCOrderIDTextBox.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "ORDER_NOTES")
        OCOrderDataGrid.DataSource = (ds.Tables("ORDER_NOTES"))
    End Sub
    Sub Tabel()
        Call Koneksi()
        da = New OracleDataAdapter("SELECT ID_ORDER, ID_CUSTOMER, NAMA_CUSTOMER, STATUS FROM ORDERS WHERE STATUS = '" & "PENDING" & "'", conn)
        ds = New DataSet
        da.Fill(ds, "ORDERS")
        OPDataGrid.DataSource = (ds.Tables("ORDERS"))

        Call Koneksi()
        da = New OracleDataAdapter("SELECT ID_ORDER, ID_CUSTOMER, NAMA_CUSTOMER, STATUS FROM ORDERS WHERE STATUS = '" & "DONE" & "'", conn)
        ds = New DataSet
        da.Fill(ds, "ORDERS")
        ODDataGrid.DataSource = (ds.Tables("ORDERS"))
    End Sub
    Sub Disable()
        If OCOrderIDTextBox.Text = "" Then
            DoneButton.Enabled = False
            OCBatalButton.Enabled = False
        Else
            DoneButton.Enabled = True
            OCBatalButton.Enabled = True
        End If
    End Sub
    Sub HapusDone()
        Call Koneksi()
        Dim FillData As String = "SELECT ID_ORDER, TANGGAL FROM ORDERS WHERE STATUS = '" & "DONE" & "'"
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            Do While dr.Read
                Dim A As Date = dr!TANGGAL
                Dim B As Integer = DateDiff(DateInterval.Day, CDate(A), Today)
                If B > 730 Then
                    Dim Hapus As String = "DELETE FROM ORDER_NOTES WHERE ID_ORDER =  '" & dr!ID_ORDER & "'"
                    cmd = New OracleCommand(Hapus, conn)
                    cmd.ExecuteReader()
                    Dim HapusData2 As String = "DELETE FROM ORDERS WHERE ID_ORDER = '" & dr!ID_ORDER & "'"
                    cmd = New OracleCommand(HapusData2, conn)
                    cmd.ExecuteReader()
                End If
            Loop
            dr.Read()
        End If
    End Sub
    '||||||||||||||||||||||||||||||||||||||2.ORDER CONTROL|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ CODING SUB \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ LOAD \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
        TanggalDateTimePicker.Format = DateTimePickerFormat.Custom
        TanggalDateTimePicker.CustomFormat = "dd MMMM yyyy"
    End Sub
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ LOAD \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ CODING BUTTON \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    '||||||||||||||||||||||||||||||||||||||1.ORDER FORM||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    'BUATFORM
    Private Sub BuatFormButton_Click(sender As Object, e As EventArgs) Handles BuatFormButton.Click
        If IDCustomerComboBox.Text = "" Or NamaCustomerComboBox.Text = "" Then
            MsgBox("Masukkan Customer dulu!!")
        Else
            OFTotalLabel.Text = 0
            KontrolPanel.Visible = True
            OFOrderDataGrid.Visible = True
            FormBarangPanel.Visible = False
            TotalPanel.Visible = True
            BatalOrderButton.Enabled = True
            PlaceOrderButton.Enabled = True
            BuatFormPanel.Enabled = False
            Dim status As String = "PENDING"
            Call Koneksi()
            Dim SimpanData As String = "INSERT INTO ORDERS VALUES ('" & IDOrderTextBox.Text & "','" & LabelIDUser.Text & "','" & IDCustomerComboBox.Text & "','" & TanggalDateTimePicker.Text & "','" & status & "','" & NamaCustomerComboBox.Text & "','" & OFNoTelpTextBox.Text & "','" & OFAlamatTextbox.Text & "',0)"
            cmd = New OracleCommand(SimpanData, conn)
            cmd.ExecuteReader()
            MsgBox("Berhasil membuat Form !")
        End If
    End Sub
    Private Sub BatalOrderButton_Click(sender As Object, e As EventArgs) Handles BatalOrderButton.Click
        Call Koneksi()
        Dim FillData As String = "SELECT ID_ORDER FROM ORDER_NOTES WHERE ID_ORDER =  '" & IDOrderTextBox.Text & "'"
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            Dim Hapus As String = "DELETE FROM ORDER_NOTES WHERE ID_ORDER =  '" & IDOrderTextBox.Text & "'"
            cmd = New OracleCommand(Hapus, conn)
            cmd.ExecuteReader()
        End If
        Dim Hapus2 As String = "DELETE FROM ORDERS WHERE ID_ORDER = '" & IDOrderTextBox.Text & "'"
        cmd = New OracleCommand(Hapus2, conn)
        cmd.ExecuteReader()
        Call kondisiAwal()
        MsgBox("Order Dibatalkan!!")
    End Sub
    Private Sub PlaceOrderButton_Click(sender As Object, e As EventArgs) Handles PlaceOrderButton.Click
        Call Koneksi()
        Dim CekNota As String = "SELECT * FROM ORDER_NOTES WHERE ID_ORDER =  '" & IDOrderTextBox.Text & "'"
        cmd = New OracleCommand(CekNota, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            Dim UpTotal As String = "UPDATE ORDERS SET TOTAL = '" & OFTotalLabel.Text & "' WHERE ID_ORDER =  '" & IDOrderTextBox.Text & "'"
            cmd = New OracleCommand(UpTotal, conn)
            cmd.ExecuteReader()
            MsgBox("Order Telah Masuk Antrian!!")
            Dim FillData As String = "SELECT ID_PRODUK, JUMLAH_ORDER FROM ORDER_NOTES WHERE ID_ORDER =  '" & IDOrderTextBox.Text & "'"
            cmd = New OracleCommand(FillData, conn)
            dr = cmd.ExecuteReader()
            Do While dr.Read()
                IDLabel.Text = dr!ID_PRODUK
                PenguranganJumlah.Text = dr!JUMLAH_ORDER
                Dim PenguranganProduk As String = "UPDATE PRODUK SET JUMLAH_PRODUK = JUMLAH_PRODUK - '" & PenguranganJumlah.Text & "' WHERE ID_PRODUK =  '" & IDLabel.Text & "'"
                cmd = New OracleCommand(PenguranganProduk, conn)
                cmd.ExecuteReader()
            Loop
            dr.Read()
            Call kondisiAwal()
        Else
            MsgBox("List Order Kosong!!!")
        End If
    End Sub
    Private Sub OClearButton_Click(sender As Object, e As EventArgs) Handles OClearButton.Click
        Call clear()
    End Sub
    'BARANGFORM
    Private Sub TambahBarangButton_Click(sender As Object, e As EventArgs) Handles TambahBarangButton.Click
        Call HapusEditTambah()
        KategoriTextBox.Visible = False
        ProdKategoriComboBox.Visible = True
        NamaProdukComboBox.Visible = True
        NamaProdukTextBox.Visible = False
        ProdJumlahTextBox.ReadOnly = False
        SimpanButton.Text = "Tambah"
    End Sub
    Private Sub HapusBarangButton_Click(sender As Object, e As EventArgs) Handles HapusBarangButton.Click
        Call HapusEditTambah()
        LabelKategori.Visible = False
        KategoriTextBox.Visible = False
        ProdJumlahTextBox.ReadOnly = True
        SimpanButton.Text = "Hapus"
        Call ComboboxIDProd()
    End Sub
    Private Sub EditJumlahButton_Click(sender As Object, e As EventArgs) Handles EditJumlahButton.Click
        Call HapusEditTambah()
        LabelKategori.Visible = False
        KategoriTextBox.Visible = False
        ProdJumlahTextBox.ReadOnly = False
        SimpanButton.Text = "Ubah"
        Call ComboboxIDProd()
    End Sub
    Private Sub SimpanButton_Click(sender As Object, e As EventArgs) Handles SimpanButton.Click
        If ProdIDComboBox.Text = "" Or ProdJumlahTextBox.Text = "" Then
            MsgBox("Kolom ID, Nama, dan Jumlah Harus Di Isi !")
        Else
            If SimpanButton.Text = "Tambah" Then
                If NamaProdukComboBox.Text = "" Then
                    MsgBox("Kolom ID, Nama, dan Jumlah Harus Di Isi !")
                Else
                    Dim Cek As String = "SELECT JUMLAH_PRODUK FROM PRODUK WHERE ID_PRODUK = '" & ProdIDComboBox.Text & "'"
                    cmd = New OracleCommand(Cek, conn)
                    dr = cmd.ExecuteReader()
                    dr.Read()
                    IDLabel.Text = dr!JUMLAH_PRODUK
                    If IDLabel.Text - ProdJumlahTextBox.Text < 0 Then
                        MsgBox("Jumlah Produk tidak mencukupi Order!!")
                    Else
                        Dim FillData As String = "SELECT ID_PRODUK FROM ORDER_NOTES WHERE ID_ORDER =  '" & IDOrderTextBox.Text & "' AND ID_PRODUK = '" & ProdIDComboBox.Text & "'"
                        cmd = New OracleCommand(FillData, conn)
                        dr = cmd.ExecuteReader()
                        dr.Read()
                        If dr.HasRows Then
                            If ProdIDComboBox.Text = dr!ID_PRODUK Then
                                MsgBox("Produk sudah ditambahkan, silahkan ganti jumlah di Edit Jumlah")
                            Else
                                Call kaliHarga()
                                Dim Tosem As Integer = LabelHarga.Text * ProdJumlahTextBox.Text
                                Call Koneksi()
                                Dim SimpanData As String = "INSERT INTO ORDER_NOTES VALUES ('" & ProdIDComboBox.Text & "','" & IDOrderTextBox.Text & "','" & NamaProdukComboBox.Text & "','" & ProdJumlahTextBox.Text & "','" & Tosem & "')"
                                cmd = New OracleCommand(SimpanData, conn)
                                cmd.ExecuteReader()
                                Call Total()
                                MsgBox("Berhasil Menambah!")
                            End If
                        Else
                            Call kaliHarga()
                            Dim Tosem As Integer = LabelHarga.Text * ProdJumlahTextBox.Text
                            Call Koneksi()
                            Dim SimpanData As String = "INSERT INTO ORDER_NOTES VALUES ('" & ProdIDComboBox.Text & "','" & IDOrderTextBox.Text & "','" & NamaProdukComboBox.Text & "','" & ProdJumlahTextBox.Text & "','" & Tosem & "')"
                            cmd = New OracleCommand(SimpanData, conn)
                            cmd.ExecuteReader()
                            Call Total()
                            MsgBox("Berhasil Menambah!")
                        End If
                    End If
                End If
            ElseIf SimpanButton.Text = "Ubah" Then
                Dim Cek As String = "SELECT JUMLAH_PRODUK FROM PRODUK WHERE ID_PRODUK = '" & ProdIDComboBox.Text & "'"
                cmd = New OracleCommand(Cek, conn)
                dr = cmd.ExecuteReader()
                dr.Read()
                IDLabel.Text = dr!JUMLAH_PRODUK
                If IDLabel.Text - ProdJumlahTextBox.Text < 0 Then
                    MsgBox("Jumlah Produk tidak mencukupi Order!!")
                Else
                    Call kaliHarga()
                    Dim Tosem As Integer = LabelHarga.Text * ProdJumlahTextBox.Text
                    Call Koneksi()
                    Dim TambahData As String = "UPDATE ORDER_NOTES SET JUMLAH_ORDER = '" & ProdJumlahTextBox.Text & "',TOTAL_SEMENTARA = '" & Tosem & "' WHERE ID_PRODUK =  '" & ProdIDComboBox.Text & "'"
                    cmd = New OracleCommand(TambahData, conn)
                    cmd.ExecuteReader()
                    Call Total()
                    MsgBox("Jumlah Diubah !")
                End If
            ElseIf SimpanButton.Text = "Hapus" Then
                Call Koneksi()
                Dim HapusData As String = "DELETE FROM ORDER_NOTES WHERE ID_PRODUK =  '" & ProdIDComboBox.Text & "'"
                cmd = New OracleCommand(HapusData, conn)
                cmd.ExecuteReader()
                MsgBox("Data Dihapus !")

                Dim FillData As String = "SELECT ID_ORDER FROM ORDER_NOTES WHERE ID_ORDER =  '" & IDOrderTextBox.Text & "'"
                cmd = New OracleCommand(FillData, conn)
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then
                    Call Total()
                Else
                    OFTotalLabel.Text = 0
                End If
            End If
            Call Koneksi()
            da = New OracleDataAdapter("SELECT ID_PRODUK, NAMA_PRODUK, JUMLAH_ORDER, TOTAL_SEMENTARA Total FROM ORDER_NOTES WHERE ID_ORDER ='" & IDOrderTextBox.Text & "'", conn)
            ds = New DataSet
            da.Fill(ds, "ORDER_NOTES")
            OFOrderDataGrid.DataSource = (ds.Tables("ORDER_NOTES"))
            FormPanel.Visible = False
            Call clear2()
        End If
        Call SimpanBatal()
    End Sub
    Private Sub OFBatalButton_Click(sender As Object, e As EventArgs) Handles OFBatalButton.Click
        Call SimpanBatal()
    End Sub
    Private Sub PClearButton_Click(sender As Object, e As EventArgs) Handles PClearButton.Click
        Call clear2()
    End Sub
    '||||||||||||||||||||||||||||||||||||||1.ORDER FORM||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    '||||||||||||||||||||||||||||||||||||||2.ORDER CONTROL|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    Private Sub DoneButton_Click(sender As Object, e As EventArgs) Handles DoneButton.Click
        Call Koneksi()
        Dim TambahData As String = "UPDATE ORDERS SET STATUS = '" & "DONE" & "' WHERE ID_ORDER = '" & OCOrderIDTextBox.Text & "'"
        cmd = New OracleCommand(TambahData, conn)
        cmd.ExecuteReader()
        MsgBox("Order Telah Dikirim!!")
        Call Clear3()
        Call kondisiAwal()
    End Sub
    Private Sub OCBatalButton_Click(sender As Object, e As EventArgs) Handles OCBatalButton.Click
        Call Koneksi()
        Dim Kembalikan As String = "SELECT ID_PRODUK, JUMLAH_ORDER FROM ORDER_NOTES WHERE ID_ORDER =  '" & OCOrderIDTextBox.Text & "'"
        cmd = New OracleCommand(Kembalikan, conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read()
            IDLabel.Text = dr!ID_PRODUK
            PenambahanJumlah.Text = dr!JUMLAH_ORDER
            Dim PenambahanProduk As String = "UPDATE PRODUK SET JUMLAH_PRODUK = JUMLAH_PRODUK + '" & PenambahanJumlah.Text & "' WHERE ID_PRODUK =  '" & IDLabel.Text & "'"
            cmd = New OracleCommand(PenambahanProduk, conn)
            cmd.ExecuteReader()
        Loop
        dr.Read()
        Dim FillData As String = "SELECT ID_ORDER FROM ORDER_NOTES WHERE ID_ORDER =  '" & OCOrderIDTextBox.Text & "'"
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            Dim Hapus As String = "DELETE FROM ORDER_NOTES WHERE ID_ORDER =  '" & OCOrderIDTextBox.Text & "'"
            cmd = New OracleCommand(Hapus, conn)
            cmd.ExecuteReader()
        End If
        Dim Hapus2 As String = "DELETE FROM ORDERS WHERE ID_ORDER = '" & OCOrderIDTextBox.Text & "'"
        cmd = New OracleCommand(Hapus2, conn)
        cmd.ExecuteReader()
        Call Clear3()
        Call kondisiAwal()
        MsgBox("Order Dibatalkan!!")
    End Sub
    '||||||||||||||||||||||||||||||||||||||2.ORDER CONTROL|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ CODING BUTTON \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ CODING BUKAN BUTTON \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    '||||||||||||||||||||||||||||||||||||||1.ORDER FORM||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    'BUAT FORM
    Private Sub IDCustomerComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IDCustomerComboBox.SelectedIndexChanged
        Call Koneksi()
        Dim FillData As String = "SELECT * FROM CUSTOMER WHERE ID_CUSTOMER =  '" & IDCustomerComboBox.Text & "'"
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            NamaCustomerComboBox.Text = dr!NAMA_CUSTOMER
            OFNoTelpTextBox.Text = dr!NOTELP_CUSTOMER
            OFAlamatTextbox.Text = dr!ALAMAT_CUSTOMER
        End If
    End Sub
    Private Sub NamaCustomerComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NamaCustomerComboBox.SelectedIndexChanged
        Call Koneksi()
        Dim FillData As String = "SELECT * FROM CUSTOMER WHERE NAMA_CUSTOMER =  '" & NamaCustomerComboBox.Text & "'"
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            IDCustomerComboBox.Text = dr!ID_CUSTOMER
            OFNoTelpTextBox.Text = dr!NOTELP_CUSTOMER
            OFAlamatTextbox.Text = dr!ALAMAT_CUSTOMER
        End If
    End Sub

    'BARANG FORM
    Private Sub ProdKategoriComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProdKategoriComboBox.SelectedIndexChanged
        Call Koneksi()
        Dim FillData As String = "SELECT * FROM KATEGORI WHERE NAMA_KATEGORI =  '" & ProdKategoriComboBox.Text & "'"
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            IDKategori.Text = dr!ID_KATEGORI
        End If
        Call clear2()
        Call ComboboxIDProd()
        Call ComboboxNamaProd()
    End Sub
    Private Sub ProdIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProdIDComboBox.SelectedIndexChanged
        Call Koneksi()
        Dim FillData As String
        If SimpanButton.Text = "Hapus" Or SimpanButton.Text = "Ubah" Then
            FillData = "SELECT * FROM ORDER_NOTES WHERE ID_ORDER = '" & IDOrderTextBox.Text & "' AND ID_PRODUK =  '" & ProdIDComboBox.Text & "'"
            cmd = New OracleCommand(FillData, conn)
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                NamaProdukTextBox.Text = dr!NAMA_PRODUK
                ProdJumlahTextBox.Text = dr!JUMLAH_ORDER
            End If
        Else
            FillData = "SELECT * FROM PRODUK WHERE ID_PRODUK =  '" & ProdIDComboBox.Text & "'"
            cmd = New OracleCommand(FillData, conn)
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                NamaProdukComboBox.Text = dr!NAMA_PRODUK
            End If
        End If
    End Sub
    Private Sub NamaProdukComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NamaProdukComboBox.SelectedIndexChanged
        Call Koneksi()
        Dim FillData As String = "SELECT * FROM PRODUK WHERE NAMA_PRODUK =  '" & NamaProdukComboBox.Text & "'"
        cmd = New OracleCommand(FillData, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            ProdIDComboBox.Text = dr!ID_PRODUK
        End If
    End Sub
    '||||||||||||||||||||||||||||||||||||||1.ORDER FORM||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    '||||||||||||||||||||||||||||||||||||||2.ORDER CONTROL|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    Private Sub PencarianTextbox_TextChanged(sender As Object, e As EventArgs) Handles PencarianTextbox.TextChanged
        Call Koneksi()
        cmd = New OracleCommand("SELECT * FROM ORDERS WHERE ID_ORDER LIKE '" & PencarianTextbox.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If dr!STATUS = "PENDING" Then
                Call Koneksi()
                da = New OracleDataAdapter("SELECT ID_ORDER, ID_CUSTOMER, NAMA_CUSTOMER, STATUS FROM ORDERS WHERE ID_ORDER LIKE '" & PencarianTextbox.Text & "'", conn)
                ds = New DataSet
                da.Fill(ds, "KetemuData")
                OPDataGrid.DataSource = (ds.Tables("KetemuData"))
                ODDataGrid.DataSource = ""
            Else
                Call Koneksi()
                da = New OracleDataAdapter("SELECT ID_ORDER, ID_CUSTOMER, NAMA_CUSTOMER, STATUS FROM ORDERS WHERE ID_ORDER LIKE '" & PencarianTextbox.Text & "'", conn)
                ds = New DataSet
                da.Fill(ds, "KetemuData")
                OPDataGrid.DataSource = ""
                ODDataGrid.DataSource = (ds.Tables("KetemuData"))
            End If
        Else
            Call kondisiAwal()
        End If
    End Sub
    '||||||||||||||||||||||||||||||||||||||2.ORDER CONTROL|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ CODING BUKAN BUTTON \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

    '||||||||||||||||||||||||||||||||||||||3.HISTORY|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    Sub Tabel2()
        Call Koneksi()
        da = New OracleDataAdapter("SELECT * FROM ORDERS WHERE STATUS = '" & "DONE" & "'", conn)
        ds = New DataSet
        da.Fill(ds, "ORDERS")
        HistoryDataGrid.DataSource = (ds.Tables("ORDERS"))
    End Sub

    Private Sub HistoryID_TextChanged(sender As Object, e As EventArgs) Handles HistoryID.TextChanged
        Call Koneksi()
        cmd = New OracleCommand("SELECT * FROM ORDERS WHERE ID_ORDER LIKE '" & HistoryID.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call Koneksi()
            da = New OracleDataAdapter("SELECT * FROM ORDERS WHERE ID_ORDER LIKE '" & HistoryID.Text & "'", conn)
            ds = New DataSet
            da.Fill(ds, "KetemuData")
            HistoryDataGrid.DataSource = (ds.Tables("KetemuData"))
            da = New OracleDataAdapter("SELECT ID_PRODUK ID, NAMA_PRODUK NAMA, JUMLAH_ORDER JUMLAH, TOTAL_SEMENTARA TOTAL FROM ORDER_NOTES WHERE ID_ORDER LIKE '" & HistoryID.Text & "'", conn)
            ds = New DataSet
            da.Fill(ds, "KetemuData")
            OrderNoteGrid.DataSource = (ds.Tables("KetemuData"))
        Else
            Call kondisiAwal()
        End If
    End Sub

    Private Sub LihatNotes_Click(sender As Object, e As EventArgs) Handles LihatNotes.Click
        Call Koneksi()
        cmd = New OracleCommand("SELECT * FROM ORDERS WHERE ID_ORDER LIKE '" & HistoryID.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If LihatNotes.Text = "Lihat Order Note" Then
                PanelOrderNote.Visible = True
                LihatNotes.Text = "Tutup Order Note"
                HistoryID.ReadOnly = True
            Else
                PanelOrderNote.Visible = False
                LihatNotes.Text = "Lihat Order Note"
                HistoryID.Text = ""
                HistoryID.ReadOnly = False
            End If
        Else
            MsgBox("ID ORDER tidak ada!!")
        End If
    End Sub

    Private Sub OrderPrintButton_Click(sender As Object, e As EventArgs) Handles OrderPrintButton.Click
        OrderHistoryForm.Show()
    End Sub



    '||||||||||||||||||||||||||||||||||||||3.HISTORY|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
End Class