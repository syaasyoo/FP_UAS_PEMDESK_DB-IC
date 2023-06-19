<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BerandaForm
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_order = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_totalkategori = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_totalProduct = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_totalcustomer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProdDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OPDataGrid = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ProdDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel4.Controls.Add(Me.lbl_order)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(950, 39)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(267, 123)
        Me.Panel4.TabIndex = 11
        '
        'lbl_order
        '
        Me.lbl_order.AutoSize = True
        Me.lbl_order.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order.ForeColor = System.Drawing.Color.White
        Me.lbl_order.Location = New System.Drawing.Point(27, 62)
        Me.lbl_order.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_order.Name = "lbl_order"
        Me.lbl_order.Size = New System.Drawing.Size(64, 50)
        Me.lbl_order.TabIndex = 6
        Me.lbl_order.Text = "00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 30)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total Orders Pending"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel3.Controls.Add(Me.lbl_totalkategori)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(658, 39)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(267, 123)
        Me.Panel3.TabIndex = 10
        '
        'lbl_totalkategori
        '
        Me.lbl_totalkategori.AutoSize = True
        Me.lbl_totalkategori.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalkategori.ForeColor = System.Drawing.Color.White
        Me.lbl_totalkategori.Location = New System.Drawing.Point(27, 62)
        Me.lbl_totalkategori.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_totalkategori.Name = "lbl_totalkategori"
        Me.lbl_totalkategori.Size = New System.Drawing.Size(64, 50)
        Me.lbl_totalkategori.TabIndex = 6
        Me.lbl_totalkategori.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(29, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Kategori"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Controls.Add(Me.lbl_totalProduct)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(370, 39)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(267, 123)
        Me.Panel2.TabIndex = 9
        '
        'lbl_totalProduct
        '
        Me.lbl_totalProduct.AutoSize = True
        Me.lbl_totalProduct.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalProduct.ForeColor = System.Drawing.Color.White
        Me.lbl_totalProduct.Location = New System.Drawing.Point(39, 62)
        Me.lbl_totalProduct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_totalProduct.Name = "lbl_totalProduct"
        Me.lbl_totalProduct.Size = New System.Drawing.Size(64, 50)
        Me.lbl_totalProduct.TabIndex = 5
        Me.lbl_totalProduct.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Produk"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.lbl_totalcustomer)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(82, 39)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 123)
        Me.Panel1.TabIndex = 8
        '
        'lbl_totalcustomer
        '
        Me.lbl_totalcustomer.AutoSize = True
        Me.lbl_totalcustomer.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalcustomer.ForeColor = System.Drawing.Color.White
        Me.lbl_totalcustomer.Location = New System.Drawing.Point(47, 62)
        Me.lbl_totalcustomer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_totalcustomer.Name = "lbl_totalcustomer"
        Me.lbl_totalcustomer.Size = New System.Drawing.Size(64, 50)
        Me.lbl_totalcustomer.TabIndex = 4
        Me.lbl_totalcustomer.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Customer"
        '
        'ProdDataGridView
        '
        Me.ProdDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdDataGridView.Location = New System.Drawing.Point(82, 253)
        Me.ProdDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ProdDataGridView.Name = "ProdDataGridView"
        Me.ProdDataGridView.RowHeadersWidth = 51
        Me.ProdDataGridView.Size = New System.Drawing.Size(555, 276)
        Me.ProdDataGridView.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(77, 209)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 30)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Stock Produk"
        '
        'OPDataGrid
        '
        Me.OPDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OPDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OPDataGrid.Location = New System.Drawing.Point(658, 253)
        Me.OPDataGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.OPDataGrid.Name = "OPDataGrid"
        Me.OPDataGrid.RowHeadersWidth = 51
        Me.OPDataGrid.Size = New System.Drawing.Size(559, 276)
        Me.OPDataGrid.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(653, 209)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 30)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Orders Pending"
        '
        'BerandaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 629)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.OPDataGrid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ProdDataGridView)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BerandaForm"
        Me.Text = "BerandaForm"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProdDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_order As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_totalkategori As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_totalProduct As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_totalcustomer As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ProdDataGridView As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents OPDataGrid As DataGridView
    Friend WithEvents Label4 As Label
End Class
