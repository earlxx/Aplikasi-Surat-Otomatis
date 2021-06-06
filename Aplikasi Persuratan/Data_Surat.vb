Imports System.Data.OleDb
Imports word = Microsoft.Office.Interop.Word
Imports System.IO

Public Class Data_Surat
    Sub bersihkan()
        tnomor.ReadOnly = True
        tperihal.ReadOnly = True
        ttanggal.ReadOnly = True
        lketerangan.Text = ""
        lketerangan.BackColor = Nothing
        tcarisurat.text = ""
        ttujuan.Text = ""
        talamat.Text = ""
        ' listpemohon.Items.Clear()
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

    Sub nemuinsurat()
        Call Koneksi()
        DA = New OleDbDataAdapter(" select * from tblsurat where No_Surat like '%" & tcarisurat.text & "%' or Tanggal_Surat like '%" & tcarisurat.text & "%' or Perihal like '%" & tcarisurat.text & "%' or Tujuan like '%" & tcarisurat.text & "%' or Pemohon like '%" & tcarisurat.text & "%'", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV1.DataSource = DS.Tables(0)
        Conn.Close()
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
        Call Koneksi()
        CMD = New OleDbCommand(" select Anggota from tblanggota where Nomor_Surat = '" & tnomor.Text & "'", Conn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            listpemohon.Items.Add(DR.Item("Anggota").ToString)
        Loop

    End Sub

    Private Sub Data_Surat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bersihkan()
        Call tampildgv1()
        Call tampildgv3()
    End Sub

    Private Sub DGV1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseClick
        tnomor.Text = DGV1.Rows(e.RowIndex).Cells(0).Value
        ttanggal.Text = DGV1.Rows(e.RowIndex).Cells(1).Value
        tperihal.Text = DGV1.Rows(e.RowIndex).Cells(2).Value
        ttujuan.Text = DGV1.Rows(e.RowIndex).Cells(3).Value
        talamat.Text = DGV1.Rows(e.RowIndex).Cells(4).Value
        'tpemohon1.Text = DGV1.Rows(e.RowIndex).Cells(5).Value
        thandphone.Text = DGV1.Rows(e.RowIndex).Cells(6).Value.ToString
        tmatkul.Text = DGV1.Rows(e.RowIndex).Cells(7).Value.ToString
        tdosen.Text = DGV1.Rows(e.RowIndex).Cells(8).Value.ToString
        lketerangan.Text = DGV1.Rows(e.RowIndex).Cells(9).Value.ToString
        Call tampildgv3()

    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Call bersihkan()
        Call tampildgv1()
        Call tampildgv3()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click

        If MessageBox.Show("Print data ini...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            lcount.Text = listpemohon.Items.Count
            Call printword()
            ' lketerangan.Text = "Sudah di-print"
        Else
            Exit Sub
        End If

        If tnomor.Text = "" Or tperihal.Text = "" Then
            MsgBox("data belum lengkap")
            Exit Sub
        Else
            lketerangan.Text = "Sudah di-print"

            Call Koneksi()
            CMD = New OleDbCommand("select * from tblsurat where No_Surat = '" & tnomor.Text & "'", Conn)
            DR = CMD.ExecuteReader()
            DR.Read()

                Call Koneksi()
                Dim edit As String = "update tblsurat set Tanggal_Surat = '" & ttanggal.Text & "',Perihal = '" & tperihal.Text & "', Tujuan = '" & ttujuan.Text & "', Alamat_Tujuan = '" & talamat.Text & "', No_HP = '" & thandphone.Text & "', Mata_Kuliah = '" & tmatkul.Text & "', Dosen = '" & tdosen.Text & "', Keterangan = '" & lketerangan.Text & "' where No_Surat = '" & tnomor.Text & "'"
                CMD = New OleDbCommand(edit, Conn)
                CMD.ExecuteNonQuery()
                'MsgBox("data berhasil diedit")
                Call reset()

                Call Reset()
            End If
    End Sub

    Sub printword()
        Dim objappword As New word.Application
        Dim objdocword As New word.Document
        Dim namafile As String

        If tperihal.Text = "Surat Izin Penelitian" Then
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
        ElseIf tperihal.Text = "Surat Izin Observasi" Then
            Exit Sub
        End If
        'Dim filename As String = IO.Path.Combine(Application.StartupPath, "\Surat Izin Penelitian.docx")
       
    End Sub

    Private Sub btntutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntutup.Click
        Me.Close()
        ' Menu_Utama.Show()
    End Sub

    Private Sub tcarisurat_OnTextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcarisurat.OnTextChange
        Call nemuinsurat()

    End Sub
End Class