Public Class mainForm

    Private currentform As Form = Nothing
    'Untuk Membuka Form (Coding Tombol Navigasi)
    Public Sub openChildForm(Childform As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = Childform
        currentform.TopLevel = False
        currentform.FormBorderStyle = FormBorderStyle.None
        currentform.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(Childform)
        PanelChildForm.Tag = Childform
        Childform.BringToFront()
        Childform.Show()
    End Sub
    Private Sub MainProdukButton_Click(sender As Object, e As EventArgs) Handles MainProdukButton.Click
        openChildForm(New ProductForm())
    End Sub
    Private Sub MainKeluarButton_Click(sender As Object, e As EventArgs) Handles MainKeluarButton.Click
        Me.Hide()
        MasukForm.Show()
    End Sub
    Private Sub MainBerandaButton_Click(sender As Object, e As EventArgs) Handles MainBerandaButton.Click
        openChildForm(New BerandaForm())
    End Sub
    Private Sub MainKategoriButton_Click(sender As Object, e As EventArgs) Handles MainKategoriButton.Click
        openChildForm(New Categories())
    End Sub
    Private Sub MainUsersButton_Click(sender As Object, e As EventArgs) Handles MainUsersButton.Click
        openChildForm(New UserForm())
    End Sub
    Private Sub MainCustomerButton_Click(sender As Object, e As EventArgs) Handles MainCustomerButton.Click
        openChildForm(New Customers())
    End Sub
    Private Sub MainOrdersButton_Click(sender As Object, e As EventArgs) Handles MainOrdersButton.Click
        openChildForm(New OrderForm())
    End Sub
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openChildForm(New BerandaForm())
    End Sub
End Class
