Public Class Menu_Utama


    Private Sub Menu_Utama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        '  GroupBox1.Visible = False
        GroupBox2.Visible = False
        'Login.Show()
        toolnama.Text = ""
        toolnim.Text = ""
        toolstatus.Text = ""
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        
        Buat_Surat.tperihal.Text = "Surat Izin Observasi"
        Buat_Surat.ljudul.Text = "Surat Izin Observasi"
        Buat_Surat.tperihal.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
        Buat_Surat.stnama.Text = toolnama.Text
        Buat_Surat.stnim.Text = toolnim.Text
        Buat_Surat.ststatus.Text = toolstatus.Text
        '   Me.Close()
        Buat_Surat.Show()
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        
        Buat_Surat.tperihal.Text = "Surat Izin Penelitian"
        Buat_Surat.ljudul.Text = "Surat Izin Penelitian"
        Buat_Surat.tmatkul.Visible = False
        Buat_Surat.tdosen.Visible = False
        Buat_Surat.GunaLabel9.Visible = False
        Buat_Surat.GunaLabel10.Visible = False
        Buat_Surat.tperihal.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
        Buat_Surat.stnama.Text = toolnama.Text
        Buat_Surat.stnim.Text = toolnim.Text
        Buat_Surat.ststatus.Text = toolstatus.Text
        ' Me.Close()
        Buat_Surat.Show()
    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        ' Me.Close()
        MsgBox("anda berhasil logout")
        toolnama.Text = ""
        toolnim.Text = ""
        toolstatus.Text = ""
        GroupBox1.Enabled = False
        GroupBox2.Visible = False
        '  btnlogout.Visible = False
        btnlogout.Enabled = False
        '  btnlogin.Visible = True
        Login.Show()
        Login.tid.Select()

    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click

    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        Data_Dosen.Show()
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        Data_Mahasiswa.Show()
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        Data_Surat.Show()
    End Sub

    Private Sub btnlogin_Click(sender As System.Object, e As System.EventArgs) Handles btnlogin.Click
        Login.Show()
    End Sub
End Class