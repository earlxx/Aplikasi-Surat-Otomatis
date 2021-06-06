Imports System.Data.OleDb

Public Class Data_Dosen
    Sub tampilgrid()
        Call Koneksi()
        DA = New OleDbDataAdapter(" select * from tbldosen", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV1.DataSource = DS.Tables(0)
        DGV1.ReadOnly = True
    End Sub

    Sub kosongkan()
        tnip.Enabled = True
        tnip.Text = ""
        tnama.Text = ""
        tcari.text = ""
        tnip.SetOnGotFocus()
        With DGV1
            On Error Resume Next
            .Columns(0).Width = 150
            .Columns(1).Width = 240

        End With
        DGV1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
    End Sub

    Sub cari_dosen()
        Call Koneksi()
        DA = New OleDbDataAdapter("select * from tbldosen where NIP like '%" & tcari.text & "%' or Nama_Dosen like '%" & tcari.text & "%'", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV1.DataSource = DS.Tables(0)
        Conn.Close()
    End Sub

    Private Sub Data_Dosen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilgrid()
        Call kosongkan()
    End Sub

    Sub nemuin_dosen()
        Call Koneksi()
        CMD = New OleDbCommand("select * from tbldosen where NIP = '" & tnip.Text & "' or Nama_Dosen = '" & tnama.Text & "'", Conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            tnip.Text = DR.Item("NIP")
            tnama.Text = DR.Item("Nama_Dosen")
      
        Else
            MsgBox("data dosen tidak ditemukan")

        End If
        Conn.Close()
    End Sub

    Private Sub tnip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tnip.KeyPress
        If e.KeyChar = Chr(13) Then
            Call nemuin_dosen()
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If tnip.Text = "" Or tnama.Text = "" Then
            MsgBox("data dosen belum lengkap")
            Exit Sub
        Else
            Call Koneksi()
            CMD = New OleDbCommand("select * from tbldosen where NIP='" & tnip.Text & "'", Conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call Koneksi()
                Dim simpan As String = "insert into tbldosen values('" & tnip.Text & "','" & tnama.Text & "')"
                CMD = New OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("data dosen berhasil disimpan")
            Else
                Call Koneksi()
                Dim edit As String = "update tbldosen set Nama_Dosen ='" & tnama.Text & "' where NIP = '" & tnip.Text & "'"
                CMD = New OleDbCommand(edit, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("data dosen berhasil diedit")
            End If
            Call kosongkan()
            Call tampilgrid()
        End If

    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If tnip.Text = "" Then
            MsgBox("NIP harus diisi dulu")
            tnip.SetOnGotFocus()
            Exit Sub
        Else
            If MessageBox.Show("hapus data ini...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call Koneksi()
                Dim hapus As String = "delete from tbldosen where NIP ='" & tnip.Text & "'"
                CMD = New OleDbCommand(hapus, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("data dosen berhasil dihapus")
                Call kosongkan()
                Call tampilgrid()
            Else
                Call kosongkan()
            End If
        End If
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Call kosongkan()

    End Sub

    Private Sub btntutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntutup.Click
        Me.Close()
        Call kosongkan()
    End Sub

    Private Sub DGV1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseClick
        On Error Resume Next
        tnip.Enabled = False
        tnip.Text = DGV1.Rows(e.RowIndex).Cells(0).Value
        tnama.Text = DGV1.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Sub tcari_OnTextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.OnTextChange
        Call cari_dosen()

    End Sub
End Class