Imports System.Data.OleDb

Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radmin.Checked = False
        rmahasiswa.Checked = True
        tid.Text = ""
        tpwd.Text = ""
        tpwd.PasswordChar = "*"
        tid.Select()
        Menu_Utama.Show()

    End Sub

    Private Sub radmin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radmin.CheckedChanged
        tpwd.Visible = True
        Label3.Visible = True
        Label2.Text = "ID :"
        Label2.TextAlign = ContentAlignment.MiddleRight
        tid.Select()

    End Sub

    Private Sub rmahasiswa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rmahasiswa.CheckedChanged
        Label2.Text = "NIM :"
        Label2.TextAlign = ContentAlignment.MiddleRight
        tpwd.Visible = False
        Label3.Visible = False
        tid.Select()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Try
            If rmahasiswa.Checked = True Then
                Call Koneksi()
                CMD = New OleDbCommand("select * from tblmahasiswa where NIM ='" & tid.Text & "'", Conn)
                DR = CMD.ExecuteReader
                DR.Read()
                If Not DR.HasRows Then
                    MsgBox("Data Mahasiswa Tidak Ada")
                    tid.Clear()
                    tid.Select()
                Else

                    Menu_Utama.toolstatus.Text = rmahasiswa.Text
                    Menu_Utama.toolnim.Text = DR("NIM")
                    Menu_Utama.toolnama.Text = DR("Nama_Mahasiswa")
                    MsgBox("Selamat Datang" & " " & Menu_Utama.toolnama.Text)
                    tid.Text = ""
                    tpwd.Text = ""
                    rmahasiswa.Checked = True
                    Menu_Utama.GroupBox1.Enabled = True
                    ' Me.Close()

                    'Menu_Utama.GroupBox2.Visible = False
                    Me.Hide()
                    ' Menu_Utama.Show()
                End If
            Else
                Call Koneksi()
                CMD = New OleDbCommand("select * from tbladmin where ID ='" & tid.Text & "'", Conn)
                DR = CMD.ExecuteReader
                DR.Read()
                If Not DR.HasRows Then
                    MsgBox("Data Admin Tidak Ada")
                    tid.Clear()
                    tid.Select()
                Else
                    If DR("Password") <> tpwd.Text Then
                        MsgBox("Password Salah")
                        tpwd.Focus()
                        Exit Sub
                    End If
                    Menu_Utama.toolstatus.Text = radmin.Text
                    Menu_Utama.toolnim.Text = DR("ID")
                    Menu_Utama.toolnama.Text = DR("Nama_Admin")
                    MsgBox("Selamat Datang" & " " & Menu_Utama.toolnama.Text)
                    tid.Text = ""
                    tpwd.Text = ""
                    radmin.Checked = True
                    Menu_Utama.GroupBox1.Enabled = True
                    Menu_Utama.GroupBox2.Visible = True
                    ' Me.Close()

                    Me.Hide()
                    'Menu_Utama.Show()
                    End If
            End If
            Menu_Utama.btnlogout.Enabled = True
            '  Menu_Utama.btnlogin.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        radmin.Checked = False
        rmahasiswa.Checked = True
        tid.Text = ""
        tpwd.Text = ""
        tpwd.PasswordChar = "*"
    End Sub

    Private Sub tid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tid.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            btnok.PerformClick()
        End If
    End Sub

    Private Sub tid_TextChanged(sender As System.Object, e As System.EventArgs) Handles tid.TextChanged

    End Sub
End Class