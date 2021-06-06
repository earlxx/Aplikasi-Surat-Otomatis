Imports System.Data.OleDb

Public Class Data_Mahasiswa
    Sub Tampilgrid()
        Call Koneksi()
        DA = New OleDbDataAdapter("select * from tblmahasiswa order by Nama_Mahasiswa asc", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV1.DataSource = DS.Tables(0)
        DGV1.ReadOnly = True

        With DGV1
            On Error Resume Next
            .Columns(0).Width = 150
            .Columns(1).Width = 240
            .Columns(2).Width = 100
        End With
        DGV1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
    End Sub

    Sub kosongkan()
        tnim.Enabled = True
        tnim.Text = ""
        tnama.Text = ""
        tangkatan.Text = ""
        tcari.text = ""
        tnim.SetOnGotFocus()
    End Sub

    Sub cari_siswa()
        Call Koneksi()
        DA = New OleDbDataAdapter("select * from tblmahasiswa where NIM like '%" & tcari.Text & "%' or Nama_Mahasiswa like '%" & tcari.Text & "%' or Angkatan like '%" & tcari.Text & "%'", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV1.DataSource = DS.Tables(0)
        Conn.Close()
    End Sub

    Private Sub Data_Mahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kosongkan()
        Call Tampilgrid()
    End Sub

    Sub nemuin_siswa()
        Call Koneksi()
        CMD = New OleDbCommand("select * from tblmahasiswa where NIM = '" & tnim.Text & "'", Conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            tnim.Text = DR.Item("NIM")
            tnama.Text = DR.Item("Nama_Mahasiswa")
            tangkatan.Text = DR.Item("Angkatan")
        Else
            tnama.Text = ""
            tangkatan.Text = ""
            tnama.SetOnGotFocus()
        End If
    End Sub

    Private Sub tnim_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tnim.KeyPress
        If e.KeyChar = Chr(13) Then
            Call nemuin_siswa()
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If tnim.Text = "" Or tnama.Text = "" Or tangkatan.Text = "" Then
            MsgBox("data mahasiswa belum lengkap")
            Exit Sub
        Else
            Call Koneksi()
            CMD = New OleDbCommand("select * from tblmahasiswa where NIM = '" & tnim.Text & "'", Conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call Koneksi()
                Dim simpan As String = "insert into tblmahasiswa values('" & tnim.Text & "','" & tnama.Text & "','" & tangkatan.Text & "')"
                CMD = New OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("data mahasiswa berhasil disimpan")
            Else
                Call Koneksi()
                Dim edit As String = "update tblmahasiswa set Nama_Mahasiswa ='" & tnama.Text & "', Angkatan ='" & tangkatan.Text & "' where NIM = '" & tnim.Text & "'"
                CMD = New OleDbCommand(edit, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("data mahasiswa berhasil diedit")
            End If
            Call kosongkan()
            Call Tampilgrid()
        End If

    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If tnim.Text = "" Then
            MsgBox("NIM harus diisi dulu")
            tnim.SetOnGotFocus()
            Exit Sub
        Else
            If MessageBox.Show("hapus data ini...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call Koneksi()
                Dim hapus As String = "delete from tblmahasiswa where NIM ='" & tnim.Text & "'"
                CMD = New OleDbCommand(hapus, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("data berhasil dihapus")
                Call kosongkan()
                Call Tampilgrid()
            Else
                Call kosongkan()
            End If
        End If
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Call kosongkan()
        Call Tampilgrid()
    End Sub

    Private Sub btntutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntutup.Click
        Me.Close()
    End Sub

    Private Sub DGV1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseClick
        On Error Resume Next
        tnim.Enabled = False
        tnim.Text = DGV1.Rows(e.RowIndex).Cells(0).Value
        tnama.Text = DGV1.Rows(e.RowIndex).Cells(1).Value
        tangkatan.Text = DGV1.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub tcari_OnTextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.OnTextChange
        Call cari_siswa()

    End Sub
End Class