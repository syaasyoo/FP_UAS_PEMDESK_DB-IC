<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasukForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasukForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button = New System.Windows.Forms.Button()
        Me.MasukButton = New System.Windows.Forms.Button()
        Me.MskPassTextBox = New System.Windows.Forms.TextBox()
        Me.MskUserTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button)
        Me.Panel1.Controls.Add(Me.MasukButton)
        Me.Panel1.Controls.Add(Me.MskPassTextBox)
        Me.Panel1.Controls.Add(Me.MskUserTextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(562, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 610)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(43, 144)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(203, 48)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Username"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button
        '
        Me.Button.FlatAppearance.BorderSize = 0
        Me.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button.Image = CType(resources.GetObject("Button.Image"), System.Drawing.Image)
        Me.Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button.Location = New System.Drawing.Point(43, 223)
        Me.Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button.Name = "Button"
        Me.Button.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.Button.Size = New System.Drawing.Size(179, 48)
        Me.Button.TabIndex = 4
        Me.Button.Text = "Password"
        Me.Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button.UseVisualStyleBackColor = True
        '
        'MasukButton
        '
        Me.MasukButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.MasukButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MasukButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasukButton.ForeColor = System.Drawing.Color.White
        Me.MasukButton.Location = New System.Drawing.Point(253, 331)
        Me.MasukButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MasukButton.Name = "MasukButton"
        Me.MasukButton.Size = New System.Drawing.Size(184, 44)
        Me.MasukButton.TabIndex = 3
        Me.MasukButton.Text = "Masuk"
        Me.MasukButton.UseVisualStyleBackColor = False
        '
        'MskPassTextBox
        '
        Me.MskPassTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskPassTextBox.Location = New System.Drawing.Point(253, 233)
        Me.MskPassTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MskPassTextBox.Name = "MskPassTextBox"
        Me.MskPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MskPassTextBox.Size = New System.Drawing.Size(329, 41)
        Me.MskPassTextBox.TabIndex = 2
        '
        'MskUserTextBox
        '
        Me.MskUserTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskUserTextBox.Location = New System.Drawing.Point(253, 155)
        Me.MskUserTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MskUserTextBox.Name = "MskUserTextBox"
        Me.MskUserTextBox.Size = New System.Drawing.Size(329, 41)
        Me.MskUserTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(40, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(552, 77)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selamat Datang"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FinaleElProjectoGrup1.My.Resources.Resources.LOGO_DB
        Me.PictureBox2.Location = New System.Drawing.Point(144, 37)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(223, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(76, 158)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(364, 258)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(40, 438)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(433, 86)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DUA BERSAUDARA " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "INVENTORY CONTROL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MasukForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1195, 610)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MasukForm"
        Me.Text = "MasukForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MskPassTextBox As TextBox
    Friend WithEvents MskUserTextBox As TextBox
    Friend WithEvents MasukButton As Button
    Friend WithEvents Button As Button
    Friend WithEvents Button2 As Button
End Class
