<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categories
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CtgCariTextBox = New System.Windows.Forms.TextBox()
        Me.CtgEditButton = New System.Windows.Forms.Button()
        Me.CtgHapusButton = New System.Windows.Forms.Button()
        Me.CtgPanel2 = New System.Windows.Forms.Panel()
        Me.CtgIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CtgSimpanButton = New System.Windows.Forms.Button()
        Me.CtgBatalButton = New System.Windows.Forms.Button()
        Me.CtgClearButton = New System.Windows.Forms.Button()
        Me.CtgFormLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CtgNamaTextBox = New System.Windows.Forms.TextBox()
        Me.CtgIDTextBox = New System.Windows.Forms.TextBox()
        Me.CtgTambahButton = New System.Windows.Forms.Button()
        Me.CtgDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CtgLihatButton = New System.Windows.Forms.Button()
        Me.CtgPanel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.CtgPanel2.SuspendLayout()
        CType(Me.CtgDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.CtgPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "DAFTAR KATEGORI"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.CtgCariTextBox)
        Me.Panel2.Location = New System.Drawing.Point(616, 257)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(333, 68)
        Me.Panel2.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(104, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "PENCARIAN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "ID Kategori"
        '
        'CtgCariTextBox
        '
        Me.CtgCariTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CtgCariTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CtgCariTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtgCariTextBox.Location = New System.Drawing.Point(108, 31)
        Me.CtgCariTextBox.Name = "CtgCariTextBox"
        Me.CtgCariTextBox.Size = New System.Drawing.Size(213, 26)
        Me.CtgCariTextBox.TabIndex = 22
        '
        'CtgEditButton
        '
        Me.CtgEditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtgEditButton.Location = New System.Drawing.Point(16, 161)
        Me.CtgEditButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtgEditButton.Name = "CtgEditButton"
        Me.CtgEditButton.Size = New System.Drawing.Size(305, 41)
        Me.CtgEditButton.TabIndex = 3
        Me.CtgEditButton.Text = "Edit"
        Me.CtgEditButton.UseVisualStyleBackColor = True
        '
        'CtgHapusButton
        '
        Me.CtgHapusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtgHapusButton.Location = New System.Drawing.Point(16, 111)
        Me.CtgHapusButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtgHapusButton.Name = "CtgHapusButton"
        Me.CtgHapusButton.Size = New System.Drawing.Size(305, 41)
        Me.CtgHapusButton.TabIndex = 1
        Me.CtgHapusButton.Text = "Hapus"
        Me.CtgHapusButton.UseVisualStyleBackColor = True
        '
        'CtgPanel2
        '
        Me.CtgPanel2.Controls.Add(Me.CtgIDComboBox)
        Me.CtgPanel2.Controls.Add(Me.CtgSimpanButton)
        Me.CtgPanel2.Controls.Add(Me.CtgBatalButton)
        Me.CtgPanel2.Controls.Add(Me.CtgClearButton)
        Me.CtgPanel2.Controls.Add(Me.CtgFormLabel)
        Me.CtgPanel2.Controls.Add(Me.Label3)
        Me.CtgPanel2.Controls.Add(Me.Label2)
        Me.CtgPanel2.Controls.Add(Me.CtgNamaTextBox)
        Me.CtgPanel2.Controls.Add(Me.CtgIDTextBox)
        Me.CtgPanel2.Location = New System.Drawing.Point(-2, -1)
        Me.CtgPanel2.Name = "CtgPanel2"
        Me.CtgPanel2.Size = New System.Drawing.Size(333, 171)
        Me.CtgPanel2.TabIndex = 28
        '
        'CtgIDComboBox
        '
        Me.CtgIDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CtgIDComboBox.FormattingEnabled = True
        Me.CtgIDComboBox.Location = New System.Drawing.Point(133, 44)
        Me.CtgIDComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtgIDComboBox.Name = "CtgIDComboBox"
        Me.CtgIDComboBox.Size = New System.Drawing.Size(190, 28)
        Me.CtgIDComboBox.TabIndex = 26
        '
        'CtgSimpanButton
        '
        Me.CtgSimpanButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CtgSimpanButton.Location = New System.Drawing.Point(225, 129)
        Me.CtgSimpanButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtgSimpanButton.Name = "CtgSimpanButton"
        Me.CtgSimpanButton.Size = New System.Drawing.Size(98, 29)
        Me.CtgSimpanButton.TabIndex = 25
        Me.CtgSimpanButton.Text = "Simpan"
        Me.CtgSimpanButton.UseVisualStyleBackColor = True
        '
        'CtgBatalButton
        '
        Me.CtgBatalButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CtgBatalButton.Location = New System.Drawing.Point(14, 129)
        Me.CtgBatalButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtgBatalButton.Name = "CtgBatalButton"
        Me.CtgBatalButton.Size = New System.Drawing.Size(92, 29)
        Me.CtgBatalButton.TabIndex = 24
        Me.CtgBatalButton.Text = "Batal"
        Me.CtgBatalButton.UseVisualStyleBackColor = True
        '
        'CtgClearButton
        '
        Me.CtgClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtgClearButton.Location = New System.Drawing.Point(128, 129)
        Me.CtgClearButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtgClearButton.Name = "CtgClearButton"
        Me.CtgClearButton.Size = New System.Drawing.Size(78, 29)
        Me.CtgClearButton.TabIndex = 23
        Me.CtgClearButton.Text = "Clear"
        Me.CtgClearButton.UseVisualStyleBackColor = True
        '
        'CtgFormLabel
        '
        Me.CtgFormLabel.AutoSize = True
        Me.CtgFormLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtgFormLabel.Location = New System.Drawing.Point(80, 10)
        Me.CtgFormLabel.Name = "CtgFormLabel"
        Me.CtgFormLabel.Size = New System.Drawing.Size(180, 24)
        Me.CtgFormLabel.TabIndex = 22
        Me.CtgFormLabel.Text = "FORM KATEGORI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nama Kategori"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ID Kategori"
        '
        'CtgNamaTextBox
        '
        Me.CtgNamaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtgNamaTextBox.Location = New System.Drawing.Point(133, 79)
        Me.CtgNamaTextBox.Name = "CtgNamaTextBox"
        Me.CtgNamaTextBox.Size = New System.Drawing.Size(190, 26)
        Me.CtgNamaTextBox.TabIndex = 10
        '
        'CtgIDTextBox
        '
        Me.CtgIDTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CtgIDTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CtgIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtgIDTextBox.Location = New System.Drawing.Point(133, 44)
        Me.CtgIDTextBox.Name = "CtgIDTextBox"
        Me.CtgIDTextBox.Size = New System.Drawing.Size(190, 26)
        Me.CtgIDTextBox.TabIndex = 8
        '
        'CtgTambahButton
        '
        Me.CtgTambahButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtgTambahButton.Location = New System.Drawing.Point(15, 9)
        Me.CtgTambahButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtgTambahButton.Name = "CtgTambahButton"
        Me.CtgTambahButton.Size = New System.Drawing.Size(313, 41)
        Me.CtgTambahButton.TabIndex = 0
        Me.CtgTambahButton.Text = "Tambah"
        Me.CtgTambahButton.UseVisualStyleBackColor = True
        '
        'CtgDataGridView
        '
        Me.CtgDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CtgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CtgDataGridView.Location = New System.Drawing.Point(12, 33)
        Me.CtgDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtgDataGridView.Name = "CtgDataGridView"
        Me.CtgDataGridView.RowHeadersWidth = 51
        Me.CtgDataGridView.RowTemplate.Height = 24
        Me.CtgDataGridView.Size = New System.Drawing.Size(598, 468)
        Me.CtgDataGridView.TabIndex = 31
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.CtgLihatButton)
        Me.Panel3.Controls.Add(Me.CtgTambahButton)
        Me.Panel3.Controls.Add(Me.CtgEditButton)
        Me.Panel3.Controls.Add(Me.CtgHapusButton)
        Me.Panel3.Location = New System.Drawing.Point(616, 33)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(334, 219)
        Me.Panel3.TabIndex = 32
        '
        'CtgLihatButton
        '
        Me.CtgLihatButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtgLihatButton.Location = New System.Drawing.Point(15, 59)
        Me.CtgLihatButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtgLihatButton.Name = "CtgLihatButton"
        Me.CtgLihatButton.Size = New System.Drawing.Size(306, 41)
        Me.CtgLihatButton.TabIndex = 4
        Me.CtgLihatButton.Text = "Lihat"
        Me.CtgLihatButton.UseVisualStyleBackColor = True
        '
        'CtgPanel1
        '
        Me.CtgPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CtgPanel1.Controls.Add(Me.CtgPanel2)
        Me.CtgPanel1.Location = New System.Drawing.Point(616, 330)
        Me.CtgPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtgPanel1.Name = "CtgPanel1"
        Me.CtgPanel1.Size = New System.Drawing.Size(333, 172)
        Me.CtgPanel1.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(668, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 24)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "KONTROL KATEGORI"
        '
        'Categories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 511)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CtgPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.CtgDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Categories"
        Me.Text = "Categories"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.CtgPanel2.ResumeLayout(False)
        Me.CtgPanel2.PerformLayout()
        CType(Me.CtgDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.CtgPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CtgCariTextBox As TextBox
    Friend WithEvents CtgEditButton As Button
    Friend WithEvents CtgHapusButton As Button
    Friend WithEvents CtgPanel2 As Panel
    Friend WithEvents CtgClearButton As Button
    Friend WithEvents CtgFormLabel As Label
    Friend WithEvents CtgTambahButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CtgNamaTextBox As TextBox
    Friend WithEvents CtgIDTextBox As TextBox
    Friend WithEvents CtgBatalButton As Button
    Friend WithEvents CtgDataGridView As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CtgLihatButton As Button
    Friend WithEvents CtgSimpanButton As Button
    Friend WithEvents CtgIDComboBox As ComboBox
    Friend WithEvents CtgPanel1 As Panel
    Friend WithEvents Label4 As Label
End Class
