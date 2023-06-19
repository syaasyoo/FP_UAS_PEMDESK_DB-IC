<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.MainOrdersButton = New System.Windows.Forms.Button()
        Me.MainKeluarButton = New System.Windows.Forms.Button()
        Me.MainUsersButton = New System.Windows.Forms.Button()
        Me.MainCustomerButton = New System.Windows.Forms.Button()
        Me.MainKategoriButton = New System.Windows.Forms.Button()
        Me.MainProdukButton = New System.Windows.Forms.Button()
        Me.MainBerandaButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(290, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(936, 51)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DUA BERSAUDARA INVENTORY CONTROL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 82)
        Me.Panel1.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Location = New System.Drawing.Point(1, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(202, 82)
        Me.Panel4.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MainOrdersButton)
        Me.Panel2.Controls.Add(Me.MainKeluarButton)
        Me.Panel2.Controls.Add(Me.MainUsersButton)
        Me.Panel2.Controls.Add(Me.MainCustomerButton)
        Me.Panel2.Controls.Add(Me.MainKategoriButton)
        Me.Panel2.Controls.Add(Me.MainProdukButton)
        Me.Panel2.Controls.Add(Me.MainBerandaButton)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 528)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(203, 165)
        Me.Panel3.TabIndex = 0
        '
        'PanelChildForm
        '
        Me.PanelChildForm.Location = New System.Drawing.Point(213, 91)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(972, 510)
        Me.PanelChildForm.TabIndex = 5
        '
        'MainOrdersButton
        '
        Me.MainOrdersButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MainOrdersButton.FlatAppearance.BorderSize = 0
        Me.MainOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainOrdersButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainOrdersButton.ForeColor = System.Drawing.Color.White
        Me.MainOrdersButton.Image = Global.FinaleElProjectoGrup1.My.Resources.Resources.Order
        Me.MainOrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainOrdersButton.Location = New System.Drawing.Point(0, 415)
        Me.MainOrdersButton.Name = "MainOrdersButton"
        Me.MainOrdersButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.MainOrdersButton.Size = New System.Drawing.Size(203, 50)
        Me.MainOrdersButton.TabIndex = 7
        Me.MainOrdersButton.Text = "Orders"
        Me.MainOrdersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainOrdersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainOrdersButton.UseVisualStyleBackColor = True
        '
        'MainKeluarButton
        '
        Me.MainKeluarButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainKeluarButton.FlatAppearance.BorderSize = 0
        Me.MainKeluarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainKeluarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainKeluarButton.ForeColor = System.Drawing.Color.White
        Me.MainKeluarButton.Image = Global.FinaleElProjectoGrup1.My.Resources.Resources.log_out
        Me.MainKeluarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainKeluarButton.Location = New System.Drawing.Point(0, 488)
        Me.MainKeluarButton.Name = "MainKeluarButton"
        Me.MainKeluarButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.MainKeluarButton.Size = New System.Drawing.Size(203, 40)
        Me.MainKeluarButton.TabIndex = 6
        Me.MainKeluarButton.Text = "Keluar"
        Me.MainKeluarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainKeluarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainKeluarButton.UseVisualStyleBackColor = True
        '
        'MainUsersButton
        '
        Me.MainUsersButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MainUsersButton.FlatAppearance.BorderSize = 0
        Me.MainUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainUsersButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainUsersButton.ForeColor = System.Drawing.Color.White
        Me.MainUsersButton.Image = Global.FinaleElProjectoGrup1.My.Resources.Resources.user_add
        Me.MainUsersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainUsersButton.Location = New System.Drawing.Point(0, 365)
        Me.MainUsersButton.Name = "MainUsersButton"
        Me.MainUsersButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.MainUsersButton.Size = New System.Drawing.Size(203, 50)
        Me.MainUsersButton.TabIndex = 5
        Me.MainUsersButton.Text = "Users"
        Me.MainUsersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainUsersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainUsersButton.UseVisualStyleBackColor = True
        '
        'MainCustomerButton
        '
        Me.MainCustomerButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MainCustomerButton.FlatAppearance.BorderSize = 0
        Me.MainCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainCustomerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainCustomerButton.ForeColor = System.Drawing.Color.White
        Me.MainCustomerButton.Image = Global.FinaleElProjectoGrup1.My.Resources.Resources.Customer
        Me.MainCustomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainCustomerButton.Location = New System.Drawing.Point(0, 315)
        Me.MainCustomerButton.Name = "MainCustomerButton"
        Me.MainCustomerButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.MainCustomerButton.Size = New System.Drawing.Size(203, 50)
        Me.MainCustomerButton.TabIndex = 4
        Me.MainCustomerButton.Text = "Customer"
        Me.MainCustomerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainCustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainCustomerButton.UseVisualStyleBackColor = True
        '
        'MainKategoriButton
        '
        Me.MainKategoriButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MainKategoriButton.FlatAppearance.BorderSize = 0
        Me.MainKategoriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainKategoriButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainKategoriButton.ForeColor = System.Drawing.Color.White
        Me.MainKategoriButton.Image = Global.FinaleElProjectoGrup1.My.Resources.Resources.Kategori
        Me.MainKategoriButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainKategoriButton.Location = New System.Drawing.Point(0, 265)
        Me.MainKategoriButton.Name = "MainKategoriButton"
        Me.MainKategoriButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.MainKategoriButton.Size = New System.Drawing.Size(203, 50)
        Me.MainKategoriButton.TabIndex = 3
        Me.MainKategoriButton.Text = "Kategori"
        Me.MainKategoriButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainKategoriButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainKategoriButton.UseVisualStyleBackColor = True
        '
        'MainProdukButton
        '
        Me.MainProdukButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MainProdukButton.FlatAppearance.BorderSize = 0
        Me.MainProdukButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainProdukButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainProdukButton.ForeColor = System.Drawing.Color.White
        Me.MainProdukButton.Image = Global.FinaleElProjectoGrup1.My.Resources.Resources.produk
        Me.MainProdukButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainProdukButton.Location = New System.Drawing.Point(0, 215)
        Me.MainProdukButton.Name = "MainProdukButton"
        Me.MainProdukButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.MainProdukButton.Size = New System.Drawing.Size(203, 50)
        Me.MainProdukButton.TabIndex = 2
        Me.MainProdukButton.Text = "Produk"
        Me.MainProdukButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainProdukButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainProdukButton.UseVisualStyleBackColor = True
        '
        'MainBerandaButton
        '
        Me.MainBerandaButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MainBerandaButton.FlatAppearance.BorderSize = 0
        Me.MainBerandaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainBerandaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainBerandaButton.ForeColor = System.Drawing.Color.White
        Me.MainBerandaButton.Image = Global.FinaleElProjectoGrup1.My.Resources.Resources.home
        Me.MainBerandaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainBerandaButton.Location = New System.Drawing.Point(0, 165)
        Me.MainBerandaButton.Name = "MainBerandaButton"
        Me.MainBerandaButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.MainBerandaButton.Size = New System.Drawing.Size(203, 50)
        Me.MainBerandaButton.TabIndex = 1
        Me.MainBerandaButton.Text = "Beranda"
        Me.MainBerandaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainBerandaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainBerandaButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinaleElProjectoGrup1.My.Resources.Resources.main
        Me.PictureBox1.Location = New System.Drawing.Point(32, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FinaleElProjectoGrup1.My.Resources.Resources.LOGO_DB
        Me.PictureBox2.Location = New System.Drawing.Point(31, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1194, 610)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "mainForm"
        Me.Text = "DB-Inventory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MainKeluarButton As Button
    Friend WithEvents MainUsersButton As Button
    Friend WithEvents MainCustomerButton As Button
    Friend WithEvents MainKategoriButton As Button
    Friend WithEvents MainProdukButton As Button
    Friend WithEvents MainBerandaButton As Button
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents MainOrdersButton As Button
End Class
