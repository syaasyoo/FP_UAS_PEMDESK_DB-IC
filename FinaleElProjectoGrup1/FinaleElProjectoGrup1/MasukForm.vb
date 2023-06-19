Imports System.Data.OracleClient
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel


Public Class MasukForm
    'Coding Tombol Login
    Public Sub MasukButton_Click(sender As Object, e As EventArgs) Handles MasukButton.Click
        'IfElse untuk memastikan semua textbox terisi
        If MskPassTextBox.Text = "" Or MskPassTextBox.Text = "" Then
            MsgBox("Username/Password Belum Terisi")
        Else
            Call Koneksi()
            cmd = New OracleCommand("Select * From users WHERE USERNAME_USER = '" & MskUserTextBox.Text & "' and PASSWORD_USER = '" & MskPassTextBox.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("Username/Password Salah")
            Else
                un = dr!USERNAME_USER
                ids = dr!ID_USER
                Me.Hide()
                mainForm.Show()
            End If
        End If
    End Sub
    Private Sub MasukForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub
End Class