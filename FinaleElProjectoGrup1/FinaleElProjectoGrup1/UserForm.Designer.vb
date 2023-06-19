<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PencarianTextbox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FormPanelOuter = New System.Windows.Forms.Panel()
        Me.FormPanel = New System.Windows.Forms.Panel()
        Me.BatalButton = New System.Windows.Forms.Button()
        Me.UsrIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SimpanButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.FormLabel = New System.Windows.Forms.Label()
        Me.Harga = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.UsrIDTextBox = New System.Windows.Forms.TextBox()
        Me.KontrolPanel = New System.Windows.Forms.Panel()
        Me.TambahButton = New System.Windows.Forms.Button()
        Me.LihatButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.HapusButton = New System.Windows.Forms.Button()
        Me.UserDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.FormPanelOuter.SuspendLayout()
        Me.FormPanel.SuspendLayout()
        Me.KontrolPanel.SuspendLayout()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PencarianTextbox)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(537, 211)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 74)
        Me.Panel1.TabIndex = 38
        '
        'PencarianTextbox
        '
        Me.PencarianTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PencarianTextbox.Location = New System.Drawing.Point(100, 34)
        Me.PencarianTextbox.Name = "PencarianTextbox"
        Me.PencarianTextbox.Size = New System.Drawing.Size(302, 26)
        Me.PencarianTextbox.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(145, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 20)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "PENCARIAN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "ID Produk"
        '
        'FormPanelOuter
        '
        Me.FormPanelOuter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FormPanelOuter.Controls.Add(Me.FormPanel)
        Me.FormPanelOuter.Location = New System.Drawing.Point(537, 291)
        Me.FormPanelOuter.Name = "FormPanelOuter"
        Me.FormPanelOuter.Size = New System.Drawing.Size(415, 206)
        Me.FormPanelOuter.TabIndex = 37
        '
        'FormPanel
        '
        Me.FormPanel.Controls.Add(Me.BatalButton)
        Me.FormPanel.Controls.Add(Me.UsrIDComboBox)
        Me.FormPanel.Controls.Add(Me.SimpanButton)
        Me.FormPanel.Controls.Add(Me.ClearButton)
        Me.FormPanel.Controls.Add(Me.FormLabel)
        Me.FormPanel.Controls.Add(Me.Harga)
        Me.FormPanel.Controls.Add(Me.Label3)
        Me.FormPanel.Controls.Add(Me.PasswordTextBox)
        Me.FormPanel.Controls.Add(Me.Label2)
        Me.FormPanel.Controls.Add(Me.UsernameTextBox)
        Me.FormPanel.Controls.Add(Me.UsrIDTextBox)
        Me.FormPanel.Location = New System.Drawing.Point(-2, -2)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.Size = New System.Drawing.Size(415, 206)
        Me.FormPanel.TabIndex = 21
        '
        'BatalButton
        '
        Me.BatalButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatalButton.Location = New System.Drawing.Point(14, 162)
        Me.BatalButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BatalButton.Name = "BatalButton"
        Me.BatalButton.Size = New System.Drawing.Size(95, 30)
        Me.BatalButton.TabIndex = 26
        Me.BatalButton.Text = "Batal"
        Me.BatalButton.UseVisualStyleBackColor = True
        '
        'UsrIDComboBox
        '
        Me.UsrIDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsrIDComboBox.FormattingEnabled = True
        Me.UsrIDComboBox.Items.AddRange(New Object() {"Snack Kecil"})
        Me.UsrIDComboBox.Location = New System.Drawing.Point(102, 51)
        Me.UsrIDComboBox.Name = "UsrIDComboBox"
        Me.UsrIDComboBox.Size = New System.Drawing.Size(302, 28)
        Me.UsrIDComboBox.TabIndex = 29
        '
        'SimpanButton
        '
        Me.SimpanButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpanButton.Location = New System.Drawing.Point(309, 162)
        Me.SimpanButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(95, 30)
        Me.SimpanButton.TabIndex = 27
        Me.SimpanButton.Text = "Simpan"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(165, 162)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(95, 30)
        Me.ClearButton.TabIndex = 23
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'FormLabel
        '
        Me.FormLabel.AutoSize = True
        Me.FormLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormLabel.Location = New System.Drawing.Point(148, 13)
        Me.FormLabel.Name = "FormLabel"
        Me.FormLabel.Size = New System.Drawing.Size(131, 24)
        Me.FormLabel.TabIndex = 22
        Me.FormLabel.Text = "FORM USER"
        Me.FormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Harga
        '
        Me.Harga.AutoSize = True
        Me.Harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Harga.Location = New System.Drawing.Point(9, 118)
        Me.Harga.Name = "Harga"
        Me.Harga.Size = New System.Drawing.Size(78, 20)
        Me.Harga.TabIndex = 15
        Me.Harga.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Username"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(102, 118)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(302, 26)
        Me.PasswordTextBox.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ID User"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(102, 83)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(302, 26)
        Me.UsernameTextBox.TabIndex = 10
        '
        'UsrIDTextBox
        '
        Me.UsrIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsrIDTextBox.Location = New System.Drawing.Point(120, 51)
        Me.UsrIDTextBox.Name = "UsrIDTextBox"
        Me.UsrIDTextBox.Size = New System.Drawing.Size(284, 26)
        Me.UsrIDTextBox.TabIndex = 8
        '
        'KontrolPanel
        '
        Me.KontrolPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KontrolPanel.Controls.Add(Me.TambahButton)
        Me.KontrolPanel.Controls.Add(Me.LihatButton)
        Me.KontrolPanel.Controls.Add(Me.EditButton)
        Me.KontrolPanel.Controls.Add(Me.HapusButton)
        Me.KontrolPanel.Location = New System.Drawing.Point(537, 14)
        Me.KontrolPanel.Name = "KontrolPanel"
        Me.KontrolPanel.Size = New System.Drawing.Size(415, 191)
        Me.KontrolPanel.TabIndex = 36
        '
        'TambahButton
        '
        Me.TambahButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TambahButton.Location = New System.Drawing.Point(11, 10)
        Me.TambahButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TambahButton.Name = "TambahButton"
        Me.TambahButton.Size = New System.Drawing.Size(391, 40)
        Me.TambahButton.TabIndex = 0
        Me.TambahButton.Text = "Tambah"
        Me.TambahButton.UseVisualStyleBackColor = True
        '
        'LihatButton
        '
        Me.LihatButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LihatButton.Location = New System.Drawing.Point(11, 54)
        Me.LihatButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LihatButton.Name = "LihatButton"
        Me.LihatButton.Size = New System.Drawing.Size(391, 40)
        Me.LihatButton.TabIndex = 2
        Me.LihatButton.Text = "Lihat"
        Me.LihatButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(12, 142)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(390, 40)
        Me.EditButton.TabIndex = 3
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'HapusButton
        '
        Me.HapusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HapusButton.Location = New System.Drawing.Point(11, 98)
        Me.HapusButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(391, 40)
        Me.HapusButton.TabIndex = 1
        Me.HapusButton.Text = "Hapus"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'UserDataGridView
        '
        Me.UserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Location = New System.Drawing.Point(9, 41)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.RowHeadersWidth = 51
        Me.UserDataGridView.Size = New System.Drawing.Size(521, 456)
        Me.UserDataGridView.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "DAFTAR USER"
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 511)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FormPanelOuter)
        Me.Controls.Add(Me.KontrolPanel)
        Me.Controls.Add(Me.UserDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UserForm"
        Me.Text = "UserForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FormPanelOuter.ResumeLayout(False)
        Me.FormPanel.ResumeLayout(False)
        Me.FormPanel.PerformLayout()
        Me.KontrolPanel.ResumeLayout(False)
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PencarianTextbox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FormPanelOuter As Panel
    Friend WithEvents FormPanel As Panel
    Friend WithEvents BatalButton As Button
    Friend WithEvents UsrIDComboBox As ComboBox
    Friend WithEvents SimpanButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents FormLabel As Label
    Friend WithEvents Harga As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents UsrIDTextBox As TextBox
    Friend WithEvents KontrolPanel As Panel
    Friend WithEvents TambahButton As Button
    Friend WithEvents LihatButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents HapusButton As Button
    Friend WithEvents UserDataGridView As DataGridView
    Friend WithEvents Label1 As Label
End Class
