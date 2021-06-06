Imports System.Data.OleDb
Imports word = Microsoft.Office.Interop.Word
Imports System.IO


Public Class Buat_Surat

    Sub bersihkan()
        lketerangan.Text = ""
        lketerangan.BackColor = Nothing
        tcarisurat.text = ""
        ttujuan.Text = ""
        talamat.Text = ""
        tpemohon1.Text = ""
        listpemohon.Items.Clear()
        lmohon.Text = ""
        thandphone.Text = ""
        tdosen.Items.Clear()
        tmatkul.Text = ""
        tnomor.MaxLength = 25
        thandphone.MaxLength = 15
        tnomor.ReadOnly = True
        tperihal.ReadOnly = True
        ttanggal.ReadOnly = True
        tnomor.Enabled = True
        ttujuan.SetOnGotFocus()
    End Sub

    Sub bulanromawi()
        Dim bulan As String = Format(Today, "MM")
        If bulan = "01" Then
            bulan = "I"
        ElseIf bulan = "02" Then
            bulan = "II"
        ElseIf bulan = "03" Then
            bulan = "III"
        ElseIf bulan = "04" Then
            bulan = "IV"
        ElseIf bulan = "05" Then
            bulan = "V"
        ElseIf bulan = "06" Then
            bulan = "VI"
        ElseIf bulan = "07" Then
            bulan = "VII"
        ElseIf bulan = "08" Then
            bulan = "VIII"
        ElseIf bulan = "09" Then
            bulan = "IX"
        ElseIf bulan = "10" Then
            bulan = "X"
        ElseIf bulan = "11" Then
            bulan = "XI"
        ElseIf bulan = "12" Then
            bulan = "XII"
        End If
        romawi.Text = bulan
    End Sub

    Sub faktis()
        Dim urutan As String
        Dim hitung, cari As Long

        CMD = New OleDbCommand(" select * from tblsurat where No_Surat in " & "(select max (No_Surat) from tblsurat)", Conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            urutan = "001" & "/KP-PM.FIP/" & romawi.Text & "/" & Date.Now.Year & ""
        Else
            cari = Microsoft.VisualBasic.Left(DR.GetString(0), 3)
            If Microsoft.VisualBasic.Right(DR.GetString(0), 4) <> Date.Now.Year Then
                urutan = "001" & "/KP-PM.FIP/" & romawi.Text & "/" & Date.Now.Year & ""
            Else
                hitung = Microsoft.VisualBasic.Left(DR.GetString(0), 3) + 1
                urutan = Microsoft.VisualBasic.Left("00" & hitung, 3) & "/KP-PM.FIP/" & romawi.Text & "/" & Date.Now.Year & ""
                lpemohon.Text = Len(CStr(hitung))
                If lpemohon.Text = "2" Then
                    urutan = Microsoft.VisualBasic.Left("0" & hitung, 3) & "/KP-PM.FIP/" & romawi.Text & "/" & Date.Now.Year & ""
                ElseIf lpemohon.Text = "3" Then
                    urutan = Microsoft.VisualBasic.Left(hitung, 3) & "/KP-PM.FIP/" & romawi.Text & "/" & Date.Now.Year & ""
                End If
            End If
        End If
        DR.Close()
        tnomor.Text = urutan

    End Sub

    Sub tampildosen()
        CMD = New OleDbCommand(" select distinct Nama_Dosen from tbldosen order by Nama_Dosen", Conn)
        DR = CMD.ExecuteReader
        tdosen.Items.Clear()
        Do While DR.Read
            tdosen.Items.Add(DR.Item("Nama_Dosen"))
        Loop
        Conn.Close()
    End Sub

    Sub tampildgv2()

        Call Koneksi()
        DA = New OleDbDataAdapter("select NIM, Nama_Mahasiswa from tblmahasiswa", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV2.DataSource = DS.Tables(0)
        DGV2.ReadOnly = True
        With DGV2
            .Columns(0).Width = 125
            .Columns(1).Width = 175
        End With
        DGV2.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
    End Sub

    Sub tampildgv1()

        Call Koneksi()
        DA = New OleDbDataAdapter("select * from tblsurat order by No_Surat desc", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV1.DataSource = DS.Tables(0)
        DGV1.ReadOnly = True
        With DGV1
            .Columns(0).Width = 140
            .Columns(2).Width = 120
            .Columns(3).Width = 100
            .Columns(4).Width = 100
            .Columns(5).Width = 100
            .Columns(7).Width = 100
            .Columns(8).Width = 100

        End With
    End Sub

    Sub tampildgv3()
        listpemohon.Items.Clear()
        'Call Koneksi()
        'DA = New OleDbDataAdapter("select * from tblanggota where Nomor_Surat = '" & tnomor.Text & "'", Conn)
        'DS = New DataSet
        'DA.Fill(DS)
        'DGV3.DataSource = DS.Tables(0)
        'DGV3.ReadOnly = True
        'For baris As Integer = 0 To DGV3.RowCount - 2
        '    listpemohon.Items.Add(DGV3.Rows(baris).Cells(1).Value)
        'Next
        Call Koneksi()
        CMD = New OleDbCommand(" select Anggota from tblanggota where Nomor_Surat = '" & tnomor.Text & "'", Conn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            listpemohon.Items.Add(DR.Item("Anggota").ToString)
        Loop

    End Sub

    Sub reset()
        Call bersihkan()
        Call bulanromawi()
        Call tampildgv1()
        Call tampildgv2()
        Call faktis()
        Call tampildgv3()
        Call tampildosen()
        listpemohon.Items.Clear()
        ttanggal.Text = Format(Today, "dd MMMM yyyy")
    End Sub

    Private Sub Buat_Surat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call reset()

    End Sub

    Private Sub tpemohon1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tpemohon1.KeyPress
        'Dim keyascii As Short = Asc(e.KeyChar)
        'If (e.KeyChar Like "[A-Z,a-z,0-9]" _
        '   OrElse keyascii = Keys.Back _
        '   OrElse keyascii = Keys.Space _
        '   OrElse keyascii = Keys.Return _
        '   OrElse keyascii = Keys.Delete) Then
        '    keyascii = 0
        'End If
        'e.Handled = CBool(keyascii)
        'If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tpemohon1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tpemohon1.TextChanged
        Call Koneksi()
        DA = New OleDbDataAdapter(" select NIM, Nama_Mahasiswa from tblmahasiswa where NIM like '%" & tpemohon1.Text & "%' or Nama_Mahasiswa like '%" & tpemohon1.Text & "%'", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV2.DataSource = DS.Tables(0)
        Conn.Close()

    End Sub


    Private Sub DGV2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV2.CellMouseClick
        On Error Resume Next
        tpemohon1.Text = DGV2.Rows(e.RowIndex).Cells(0).Value + " - " + DGV2.Rows(e.RowIndex).Cells(1).Value
       
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        'If tpemohon1.Text = "" Then
        '    MsgBox("pilih salah satu nama sebagai pemohon surat")
        '    Exit Sub
        'End If
        ' For baris As Integer = 0 To DGV1.RowCount - 2
        If ttujuan.Text = "" Or talamat.Text = "" Then
            MsgBox("data belum lengkap")
            Exit Sub
        End If
        'If tnomor.Text = DGV1.Rows(baris).Cells(0).Value Then
        '    MsgBox("Nomor Surat sudah ada")
        '    Exit Sub
        'Else
        Call Koneksi()
        CMD = New OleDbCommand("select * from tblsurat where No_Surat = '" & tnomor.Text & "'", Conn)
        DR = CMD.ExecuteReader()
        DR.Read()
        If Not DR.HasRows Then
            Call Koneksi()
            Dim simpan As String = "insert into tblsurat values ('" & tnomor.Text & "', '" & ttanggal.Text & "','" & tperihal.Text & "','" & ttujuan.Text & "','" & talamat.Text & "','" & stnama.Text & "','" & thandphone.Text & "','" & tmatkul.Text & "','" & tdosen.Text & "','" & lketerangan.Text & "')"
            CMD = New OleDbCommand(simpan, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("surat berhasil disimpan")
            Call reset()
        Else
            Call Koneksi()
            Dim edit As String = "update tblsurat set Tanggal_Surat = '" & ttanggal.Text & "',Perihal = '" & tperihal.Text & "', Tujuan = '" & ttujuan.Text & "', Alamat_Tujuan = '" & talamat.Text & "', Pemohon = '" & stnama.Text & "', No_HP = '" & thandphone.Text & "', Mata_Kuliah = '" & tmatkul.Text & "', Dosen = '" & tdosen.Text & "', Keterangan = '" & lketerangan.Text & "' where No_Surat = '" & tnomor.Text & "'"
            CMD = New OleDbCommand(edit, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("surat berhasil diedit")
            Call reset()

        End If

        If MessageBox.Show("Ingin Logout...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Menu_Utama.GroupBox1.Enabled = False
            Menu_Utama.btnlogout.Enabled = False
            Login.Show()
            ' lketerangan.Text = "Sudah di-print"
        Else
            Exit Sub
        End If
        ' End If
        ' Next

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        ' listpemohon.Items.Count = max
        tpemohon1.Text = Microsoft.VisualBasic.LTrim(tpemohon1.Text)
        If tpemohon1.Text = "" Then
            MsgBox("isi Mahasiswa terlebih dahulu")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = " insert into tblanggota values ('" & tnomor.Text & "','" & tpemohon1.Text & "')"
            CMD = New OleDbCommand(simpan, Conn)
            CMD.ExecuteNonQuery()
            listpemohon.Items.Add(tpemohon1.Text)
            Call tampildgv2()
            tpemohon1.Text = ""
            tpemohon1.SetOnGotFocus()
        End If
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        'listpemohon.SelectedIndex = tpemohon.Text

        If listpemohon.SelectedItem = Nothing Then
            MsgBox("pilih Mahasiswa yang ingin dihapus")
            Exit Sub
        Else
            Call Koneksi()
            Dim hapus As String = " delete from tblanggota where Anggota = '" & listpemohon.SelectedItem.ToString & "'"
            CMD = New OleDbCommand(hapus, Conn)
            CMD.ExecuteNonQuery()
            listpemohon.Items.Remove(listpemohon.SelectedItem)
            Call tampildgv2()
        End If
    End Sub

    'Private Sub listpemohon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listpemohon.SelectedIndexChanged
    '    tpemohon1.Text = listpemohon.SelectedItem
    'End Sub

    'Private Sub DGV1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseClick
    '    On Error Resume Next


    '    tnomor.Text = DGV1.Rows(e.RowIndex).Cells(0).Value
    '    ttanggal.Text = DGV1.Rows(e.RowIndex).Cells(1).Value
    '    tperihal.Text = DGV1.Rows(e.RowIndex).Cells(2).Value
    '    ttujuan.Text = DGV1.Rows(e.RowIndex).Cells(3).Value
    '    talamat.Text = DGV1.Rows(e.RowIndex).Cells(4).Value
    '    'tpemohon1.Text = DGV1.Rows(e.RowIndex).Cells(5).Value
    '    thandphone.Text = DGV1.Rows(e.RowIndex).Cells(6).Value.ToString
    '    tmatkul.Text = DGV1.Rows(e.RowIndex).Cells(7).Value.ToString
    '    tdosen.Text = DGV1.Rows(e.RowIndex).Cells(8).Value.ToString
    '    lketerangan.Text = DGV1.Rows(e.RowIndex).Cells(9).Value.ToString

    '    Call tampildgv3()
    '    ' tpemohon1.Text = listpemohon.SelectedItem
    'End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Call Koneksi()
        Dim hapus As String = " delete from tblanggota where Nomor_Surat = '" & tnomor.Text & "'"
        CMD = New OleDbCommand(hapus, Conn)
        CMD.ExecuteNonQuery()
        Call reset()

    End Sub

    Private Sub thandphone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles thandphone.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    'Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click

    '    If MessageBox.Show("Print data ini...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
    '        lcount.Text = listpemohon.Items.Count
    '        Call printword()
    '        ' lketerangan.Text = "Sudah di-print"
    '    Else
    '        Exit Sub
    '    End If

    '    If tnomor.Text = "" Or tperihal.Text = "" Then
    '        MsgBox("data belum lengkap")
    '        Exit Sub
    '    Else
    '        lketerangan.Text = "Sudah di-print"

    '        Call Koneksi()
    '        CMD = New OleDbCommand("select * from tblsurat where No_Surat = '" & tnomor.Text & "'", Conn)
    '        DR = CMD.ExecuteReader()
    '        DR.Read()
    '        If Not DR.HasRows Then
    '            Call Koneksi()
    '            Dim simpan As String = "insert into tblsurat values ('" & tnomor.Text & "', '" & ttanggal.Text & "','" & tperihal.Text & "','" & ttujuan.Text & "','" & talamat.Text & "','" & stnama.Text & "','" & thandphone.Text & "','" & tmatkul.Text & "','" & tdosen.Text & "','" & lketerangan.Text & "')"
    '            CMD = New OleDbCommand(simpan, Conn)
    '            CMD.ExecuteNonQuery()
    '            ' MsgBox("data berhasil disimpan")
    '            Call reset()
    '        Else
    '            Call Koneksi()
    '            Dim edit As String = "update tblsurat set Tanggal_Surat = '" & ttanggal.Text & "',Perihal = '" & tperihal.Text & "', Tujuan = '" & ttujuan.Text & "', Alamat_Tujuan = '" & talamat.Text & "', No_HP = '" & thandphone.Text & "', Mata_Kuliah = '" & tmatkul.Text & "', Dosen = '" & tdosen.Text & "', Keterangan = '" & lketerangan.Text & "' where No_Surat = '" & tnomor.Text & "'"
    '            CMD = New OleDbCommand(edit, Conn)
    '            CMD.ExecuteNonQuery()
    '            'MsgBox("data berhasil diedit")
    '            Call reset()
    '        End If
    '        Call reset()
    '    End If
    'End Sub

    Sub printword()
        Dim objappword As New word.Application
        Dim objdocword As New word.Document
        Dim namafile As String

        'Dim filename As String = IO.Path.Combine(Application.StartupPath, "\Surat Izin Penelitian.docx")
        objdocword = objappword.Documents.Open("D:\Belajar HTML\Surat Izin Penelitian.docx")
        objdocword.Bookmarks("nomor").Select()
        objappword.Selection.TypeText(tnomor.Text)
        objdocword.Bookmarks("perihal").Select()
        objappword.Selection.TypeText(tperihal.Text)
        objdocword.Bookmarks("tanggal").Select()
        objappword.Selection.TypeText(ttanggal.Text)
        objdocword.Bookmarks("tujuan1").Select()
        objappword.Selection.TypeText(ttujuan.Text)
        objdocword.Bookmarks("tujuan").Select()
        objappword.Selection.TypeText(ttujuan.Text)
        objdocword.Bookmarks("alamat").Select()
        objappword.Selection.TypeText(talamat.Text)
        If lcount.Text = "1" Then
            objdocword.Bookmarks("pemohon").Select()
            objappword.Selection.TypeText(listpemohon.Items(0).ToString)
        ElseIf lcount.Text = "2" Then
            objdocword.Bookmarks("pemohon").Select()
            objappword.Selection.TypeText(listpemohon.Items(0).ToString + listpemohon.Items(1).ToString)
        End If
        'objdocword.Bookmarks("pemohon").Select()
        'objappword.Selection.TypeText(listpemohon.Items(0).ToString)

        objdocword.Bookmarks("contact").Select()
        objappword.Selection.TypeText(thandphone.Text)
        namafile = Microsoft.VisualBasic.Left(tnomor.Text, 3) & " - " & listpemohon.Items(0).ToString & ".docx"
        objdocword.SaveAs2("D:\Belajar HTML\" & namafile)
        'FileCopy("C:\Users\ASUS\Documents\" & namafile, "D:\Belajar HTML\" & namafile)
        objappword.Visible = True
        Conn.Close()
        ' objappword.Quit()
    End Sub

    Private Sub btntutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntutup.Click
        Call Koneksi()
        Dim hapus As String = " delete from tblanggota where Nomor_Surat = '" & tnomor.Text & "'"
        CMD = New OleDbCommand(hapus, Conn)
        CMD.ExecuteNonQuery()
        Me.Close()
        'Menu_Utama.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        ' Menu_Utama.Close()
        Login.Show()
    End Sub

    Private Sub tcarisurat_OnTextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcarisurat.OnTextChange
        Call Koneksi()
        DA = New OleDbDataAdapter(" select * from tblsurat where No_Surat like '%" & tcarisurat.text & "%' or Tanggal_Surat like '%" & tcarisurat.text & "%' or Perihal like '%" & tcarisurat.text & "%' or Tujuan like '%" & tcarisurat.text & "%' or Pemohon like '%" & tcarisurat.text & "%'", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV1.DataSource = DS.Tables(0)
        Conn.Close()
    End Sub
End Class