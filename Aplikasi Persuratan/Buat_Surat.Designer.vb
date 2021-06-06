<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buat_Surat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Buat_Surat))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.tcarisurat = New Bunifu.Framework.UI.BunifuTextbox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lketerangan = New System.Windows.Forms.Label()
        Me.romawi = New System.Windows.Forms.Label()
        Me.lmohon = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tdosen = New Guna.UI.WinForms.GunaComboBox()
        Me.tmatkul = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.talamat = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.thandphone = New Guna.UI.WinForms.GunaTextBox()
        Me.ttujuan = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.tperihal = New Guna.UI.WinForms.GunaTextBox()
        Me.tnomor = New Guna.UI.WinForms.GunaTextBox()
        Me.ttanggal = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.lcount = New System.Windows.Forms.Label()
        Me.lpemohon = New System.Windows.Forms.Label()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.tpemohon1 = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listpemohon = New System.Windows.Forms.ListBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.ljudul = New Guna.UI.WinForms.GunaLabel()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ststatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stnim = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stnama = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.BackColor = System.Drawing.Color.Silver
        Me.GunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(7, 20)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(129, 32)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Nomor Surat"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btntutup
        '
        Me.btntutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntutup.Image = CType(resources.GetObject("btntutup.Image"), System.Drawing.Image)
        Me.btntutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btntutup.Location = New System.Drawing.Point(1072, 5)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(65, 52)
        Me.btntutup.TabIndex = 13
        Me.btntutup.Text = "Keluar"
        Me.btntutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.Image = CType(resources.GetObject("btnbatal.Image"), System.Drawing.Image)
        Me.btnbatal.Location = New System.Drawing.Point(77, 16)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(74, 78)
        Me.btnbatal.TabIndex = 0
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'tcarisurat
        '
        Me.tcarisurat.BackColor = System.Drawing.Color.White
        Me.tcarisurat.BackgroundImage = CType(resources.GetObject("tcarisurat.BackgroundImage"), System.Drawing.Image)
        Me.tcarisurat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tcarisurat.ForeColor = System.Drawing.Color.Black
        Me.tcarisurat.Icon = CType(resources.GetObject("tcarisurat.Icon"), System.Drawing.Image)
        Me.tcarisurat.Location = New System.Drawing.Point(6, 15)
        Me.tcarisurat.Name = "tcarisurat"
        Me.tcarisurat.Size = New System.Drawing.Size(274, 35)
        Me.tcarisurat.TabIndex = 10
        Me.tcarisurat.text = "Bunifu TextBox"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lketerangan)
        Me.GroupBox3.Controls.Add(Me.tcarisurat)
        Me.GroupBox3.Location = New System.Drawing.Point(209, 247)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(286, 97)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cari Data"
        '
        'lketerangan
        '
        Me.lketerangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lketerangan.ForeColor = System.Drawing.Color.Black
        Me.lketerangan.Location = New System.Drawing.Point(6, 56)
        Me.lketerangan.Name = "lketerangan"
        Me.lketerangan.Size = New System.Drawing.Size(274, 31)
        Me.lketerangan.TabIndex = 44
        Me.lketerangan.Text = "Label1"
        Me.lketerangan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'romawi
        '
        Me.romawi.AutoSize = True
        Me.romawi.Location = New System.Drawing.Point(218, 25)
        Me.romawi.Name = "romawi"
        Me.romawi.Size = New System.Drawing.Size(39, 13)
        Me.romawi.TabIndex = 18
        Me.romawi.Text = "Label1"
        Me.romawi.Visible = False
        '
        'lmohon
        '
        Me.lmohon.Location = New System.Drawing.Point(106, 25)
        Me.lmohon.Name = "lmohon"
        Me.lmohon.Size = New System.Drawing.Size(106, 21)
        Me.lmohon.TabIndex = 32
        Me.lmohon.Text = "Label1"
        Me.lmohon.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.tdosen)
        Me.GroupBox2.Controls.Add(Me.btnadd)
        Me.GroupBox2.Controls.Add(Me.tmatkul)
        Me.GroupBox2.Controls.Add(Me.btndel)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.DGV2)
        Me.GroupBox2.Controls.Add(Me.GunaLabel9)
        Me.GroupBox2.Controls.Add(Me.tpemohon1)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.talamat)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.GunaLabel8)
        Me.GroupBox2.Controls.Add(Me.GunaLabel6)
        Me.GroupBox2.Controls.Add(Me.listpemohon)
        Me.GroupBox2.Controls.Add(Me.GunaLabel5)
        Me.GroupBox2.Controls.Add(Me.thandphone)
        Me.GroupBox2.Controls.Add(Me.ttujuan)
        Me.GroupBox2.Controls.Add(Me.GunaLabel7)
        Me.GroupBox2.Controls.Add(Me.GunaLabel2)
        Me.GroupBox2.Controls.Add(Me.GunaLabel1)
        Me.GroupBox2.Controls.Add(Me.tperihal)
        Me.GroupBox2.Controls.Add(Me.tnomor)
        Me.GroupBox2.Controls.Add(Me.ttanggal)
        Me.GroupBox2.Controls.Add(Me.GunaLabel3)
        Me.GroupBox2.Controls.Add(Me.GunaLabel10)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1127, 356)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'tdosen
        '
        Me.tdosen.BackColor = System.Drawing.Color.Transparent
        Me.tdosen.BaseColor = System.Drawing.Color.White
        Me.tdosen.BorderColor = System.Drawing.Color.Silver
        Me.tdosen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tdosen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tdosen.FocusedColor = System.Drawing.Color.Empty
        Me.tdosen.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tdosen.ForeColor = System.Drawing.Color.Black
        Me.tdosen.FormattingEnabled = True
        Me.tdosen.Location = New System.Drawing.Point(501, 58)
        Me.tdosen.Name = "tdosen"
        Me.tdosen.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tdosen.OnHoverItemForeColor = System.Drawing.Color.White
        Me.tdosen.Size = New System.Drawing.Size(218, 26)
        Me.tdosen.TabIndex = 23
        '
        'tmatkul
        '
        Me.tmatkul.BaseColor = System.Drawing.Color.White
        Me.tmatkul.BorderColor = System.Drawing.Color.Black
        Me.tmatkul.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tmatkul.FocusedBaseColor = System.Drawing.Color.White
        Me.tmatkul.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tmatkul.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tmatkul.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmatkul.Location = New System.Drawing.Point(501, 18)
        Me.tmatkul.Name = "tmatkul"
        Me.tmatkul.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tmatkul.Size = New System.Drawing.Size(218, 32)
        Me.tmatkul.TabIndex = 19
        Me.tmatkul.Text = "GunaTextBox3"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.BackColor = System.Drawing.Color.Silver
        Me.GunaLabel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(366, 18)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(129, 32)
        Me.GunaLabel9.TabIndex = 18
        Me.GunaLabel9.Text = "Mata Kuliah"
        Me.GunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbatal)
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 97)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proses"
        '
        'btnsimpan
        '
        Me.btnsimpan.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.Location = New System.Drawing.Point(3, 16)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(74, 78)
        Me.btnsimpan.TabIndex = 11
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'talamat
        '
        Me.talamat.BaseColor = System.Drawing.Color.White
        Me.talamat.BorderColor = System.Drawing.Color.Black
        Me.talamat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.talamat.FocusedBaseColor = System.Drawing.Color.White
        Me.talamat.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.talamat.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.talamat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.talamat.Location = New System.Drawing.Point(142, 172)
        Me.talamat.MultiLine = True
        Me.talamat.Name = "talamat"
        Me.talamat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.talamat.Size = New System.Drawing.Size(354, 54)
        Me.talamat.TabIndex = 12
        Me.talamat.Text = "GunaTextBox3"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.BackColor = System.Drawing.Color.Silver
        Me.GunaLabel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(366, 96)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(129, 32)
        Me.GunaLabel8.TabIndex = 15
        Me.GunaLabel8.Text = "No. Handphone"
        Me.GunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaLabel6
        '
        Me.GunaLabel6.BackColor = System.Drawing.Color.Silver
        Me.GunaLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(7, 172)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(129, 32)
        Me.GunaLabel6.TabIndex = 11
        Me.GunaLabel6.Text = "Alamat Tujuan"
        Me.GunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaLabel5
        '
        Me.GunaLabel5.BackColor = System.Drawing.Color.Silver
        Me.GunaLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(7, 134)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(129, 32)
        Me.GunaLabel5.TabIndex = 9
        Me.GunaLabel5.Text = "Tujuan"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'thandphone
        '
        Me.thandphone.BaseColor = System.Drawing.Color.White
        Me.thandphone.BorderColor = System.Drawing.Color.Black
        Me.thandphone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.thandphone.FocusedBaseColor = System.Drawing.Color.White
        Me.thandphone.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.thandphone.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.thandphone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thandphone.Location = New System.Drawing.Point(502, 96)
        Me.thandphone.Name = "thandphone"
        Me.thandphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.thandphone.Size = New System.Drawing.Size(218, 32)
        Me.thandphone.TabIndex = 14
        Me.thandphone.Text = "GunaTextBox3"
        '
        'ttujuan
        '
        Me.ttujuan.BaseColor = System.Drawing.Color.White
        Me.ttujuan.BorderColor = System.Drawing.Color.Black
        Me.ttujuan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ttujuan.FocusedBaseColor = System.Drawing.Color.White
        Me.ttujuan.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ttujuan.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.ttujuan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttujuan.Location = New System.Drawing.Point(142, 134)
        Me.ttujuan.Name = "ttujuan"
        Me.ttujuan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ttujuan.Size = New System.Drawing.Size(354, 32)
        Me.ttujuan.TabIndex = 10
        Me.ttujuan.Text = "GunaTextBox3"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.BackColor = System.Drawing.Color.Silver
        Me.GunaLabel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(505, 151)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(215, 75)
        Me.GunaLabel7.TabIndex = 13
        Me.GunaLabel7.Text = "Nama Pemohon/Anggota"
        Me.GunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel2
        '
        Me.GunaLabel2.BackColor = System.Drawing.Color.Silver
        Me.GunaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(7, 58)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(129, 32)
        Me.GunaLabel2.TabIndex = 5
        Me.GunaLabel2.Text = "Tanggal Surat"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tperihal
        '
        Me.tperihal.BaseColor = System.Drawing.Color.White
        Me.tperihal.BorderColor = System.Drawing.Color.Black
        Me.tperihal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tperihal.FocusedBaseColor = System.Drawing.Color.White
        Me.tperihal.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tperihal.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tperihal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tperihal.Location = New System.Drawing.Point(142, 96)
        Me.tperihal.Name = "tperihal"
        Me.tperihal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tperihal.Size = New System.Drawing.Size(218, 32)
        Me.tperihal.TabIndex = 8
        Me.tperihal.Text = "GunaTextBox3"
        '
        'tnomor
        '
        Me.tnomor.BaseColor = System.Drawing.Color.White
        Me.tnomor.BorderColor = System.Drawing.Color.Black
        Me.tnomor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tnomor.FocusedBaseColor = System.Drawing.Color.White
        Me.tnomor.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tnomor.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tnomor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnomor.Location = New System.Drawing.Point(142, 20)
        Me.tnomor.Name = "tnomor"
        Me.tnomor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnomor.Size = New System.Drawing.Size(218, 32)
        Me.tnomor.TabIndex = 4
        Me.tnomor.Text = "GunaTextBox1"
        '
        'ttanggal
        '
        Me.ttanggal.BaseColor = System.Drawing.Color.White
        Me.ttanggal.BorderColor = System.Drawing.Color.Black
        Me.ttanggal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ttanggal.FocusedBaseColor = System.Drawing.Color.White
        Me.ttanggal.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ttanggal.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.ttanggal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttanggal.Location = New System.Drawing.Point(142, 58)
        Me.ttanggal.Name = "ttanggal"
        Me.ttanggal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ttanggal.Size = New System.Drawing.Size(218, 32)
        Me.ttanggal.TabIndex = 7
        Me.ttanggal.Text = "GunaTextBox2"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.BackColor = System.Drawing.Color.Silver
        Me.GunaLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(7, 96)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(129, 32)
        Me.GunaLabel3.TabIndex = 6
        Me.GunaLabel3.Text = "Perihal"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaLabel10
        '
        Me.GunaLabel10.BackColor = System.Drawing.Color.Silver
        Me.GunaLabel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(366, 58)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(129, 32)
        Me.GunaLabel10.TabIndex = 20
        Me.GunaLabel10.Text = "Dosen"
        Me.GunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lcount
        '
        Me.lcount.AutoSize = True
        Me.lcount.Location = New System.Drawing.Point(263, 25)
        Me.lcount.Name = "lcount"
        Me.lcount.Size = New System.Drawing.Size(39, 13)
        Me.lcount.TabIndex = 43
        Me.lcount.Text = "Label1"
        Me.lcount.Visible = False
        '
        'lpemohon
        '
        Me.lpemohon.Location = New System.Drawing.Point(174, 25)
        Me.lpemohon.Name = "lpemohon"
        Me.lpemohon.Size = New System.Drawing.Size(83, 21)
        Me.lpemohon.TabIndex = 41
        Me.lpemohon.Text = "Label1"
        Me.lpemohon.Visible = False
        '
        'DGV2
        '
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(751, 20)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.Size = New System.Drawing.Size(370, 108)
        Me.DGV2.TabIndex = 38
        '
        'tpemohon1
        '
        Me.tpemohon1.BaseColor = System.Drawing.Color.White
        Me.tpemohon1.BorderColor = System.Drawing.Color.Black
        Me.tpemohon1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tpemohon1.FocusedBaseColor = System.Drawing.Color.White
        Me.tpemohon1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpemohon1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tpemohon1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpemohon1.ForeColor = System.Drawing.Color.Black
        Me.tpemohon1.Location = New System.Drawing.Point(751, 153)
        Me.tpemohon1.Name = "tpemohon1"
        Me.tpemohon1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tpemohon1.Size = New System.Drawing.Size(284, 32)
        Me.tpemohon1.TabIndex = 37
        Me.tpemohon1.Text = "GunaTextBox3"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(751, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Format : NIM  - Nama Mahasiswa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'listpemohon
        '
        Me.listpemohon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listpemohon.FormattingEnabled = True
        Me.listpemohon.ItemHeight = 18
        Me.listpemohon.Location = New System.Drawing.Point(751, 203)
        Me.listpemohon.Name = "listpemohon"
        Me.listpemohon.Size = New System.Drawing.Size(370, 148)
        Me.listpemohon.TabIndex = 31
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(1041, 153)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(37, 32)
        Me.btnadd.TabIndex = 30
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Location = New System.Drawing.Point(1084, 153)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(37, 32)
        Me.btndel.TabIndex = 29
        Me.btndel.Text = "Del"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'ljudul
        '
        Me.ljudul.BackColor = System.Drawing.Color.Transparent
        Me.ljudul.Font = New System.Drawing.Font("Square721 BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ljudul.ForeColor = System.Drawing.Color.Black
        Me.ljudul.Location = New System.Drawing.Point(-5, -4)
        Me.ljudul.Name = "ljudul"
        Me.ljudul.Size = New System.Drawing.Size(1155, 59)
        Me.ljudul.TabIndex = 23
        Me.ljudul.Text = "Data Mahasiswa"
        Me.ljudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(12, 420)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(1127, 236)
        Me.DGV1.TabIndex = 19
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ststatus, Me.stnim, Me.stnama})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 659)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1150, 22)
        Me.StatusStrip1.TabIndex = 29
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ststatus
        '
        Me.ststatus.BackColor = System.Drawing.Color.White
        Me.ststatus.Name = "ststatus"
        Me.ststatus.Size = New System.Drawing.Size(133, 17)
        Me.ststatus.Text = "ToolStripStatusLabel1"
        '
        'stnim
        '
        Me.stnim.BackColor = System.Drawing.Color.White
        Me.stnim.Name = "stnim"
        Me.stnim.Size = New System.Drawing.Size(133, 17)
        Me.stnim.Text = "ToolStripStatusLabel2"
        '
        'stnama
        '
        Me.stnama.BackColor = System.Drawing.Color.White
        Me.stnama.Name = "stnama"
        Me.stnama.Size = New System.Drawing.Size(133, 17)
        Me.stnama.Text = "ToolStripStatusLabel3"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(12, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 48)
        Me.Button2.TabIndex = 42
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(1076, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 48)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Logout"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Buat_Surat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1150, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.btntutup)
        Me.Controls.Add(Me.lcount)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.romawi)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lpemohon)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.lmohon)
        Me.Controls.Add(Me.ljudul)
        Me.MaximizeBox = False
        Me.Name = "Buat_Surat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buat_Surat"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btntutup As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents tcarisurat As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents tperihal As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents tnomor As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents ttanggal As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ljudul As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents thandphone As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ttujuan As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents romawi As System.Windows.Forms.Label
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents tmatkul As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents tdosen As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents listpemohon As System.Windows.Forms.ListBox
    Friend WithEvents lmohon As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ststatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stnim As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stnama As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tpemohon1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents DGV2 As System.Windows.Forms.DataGridView
    Friend WithEvents lpemohon As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lcount As System.Windows.Forms.Label
    Friend WithEvents lketerangan As System.Windows.Forms.Label
    Friend WithEvents talamat As Guna.UI.WinForms.GunaTextBox
End Class
