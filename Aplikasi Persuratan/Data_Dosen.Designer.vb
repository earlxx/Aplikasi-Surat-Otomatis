﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Dosen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Dosen))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.tcari = New Bunifu.Framework.UI.BunifuTextbox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.tnip = New Guna.UI.WinForms.GunaTextBox()
        Me.tnama = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.BackColor = System.Drawing.Color.Silver
        Me.GunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(7, 20)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(156, 32)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "NIP"
        '
        'btntutup
        '
        Me.btntutup.Dock = System.Windows.Forms.DockStyle.Left
        Me.btntutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntutup.Image = CType(resources.GetObject("btntutup.Image"), System.Drawing.Image)
        Me.btntutup.Location = New System.Drawing.Point(228, 16)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(75, 87)
        Me.btntutup.TabIndex = 13
        Me.btntutup.Text = "Tutup"
        Me.btntutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.Image = CType(resources.GetObject("btnbatal.Image"), System.Drawing.Image)
        Me.btnbatal.Location = New System.Drawing.Point(153, 16)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 87)
        Me.btnbatal.TabIndex = 0
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.Location = New System.Drawing.Point(78, 16)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 87)
        Me.btnhapus.TabIndex = 12
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'tcari
        '
        Me.tcari.BackColor = System.Drawing.Color.White
        Me.tcari.BackgroundImage = CType(resources.GetObject("tcari.BackgroundImage"), System.Drawing.Image)
        Me.tcari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tcari.ForeColor = System.Drawing.Color.Black
        Me.tcari.Icon = CType(resources.GetObject("tcari.Icon"), System.Drawing.Image)
        Me.tcari.Location = New System.Drawing.Point(6, 16)
        Me.tcari.Name = "tcari"
        Me.tcari.Size = New System.Drawing.Size(224, 42)
        Me.tcari.TabIndex = 10
        Me.tcari.text = "Bunifu TextBox"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tcari)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 158)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(236, 68)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cari Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GunaLabel2)
        Me.GroupBox2.Controls.Add(Me.GunaLabel1)
        Me.GroupBox2.Controls.Add(Me.tnip)
        Me.GroupBox2.Controls.Add(Me.tnama)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 108)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.BackColor = System.Drawing.Color.Silver
        Me.GunaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(7, 61)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(156, 32)
        Me.GunaLabel2.TabIndex = 5
        Me.GunaLabel2.Text = "Nama Dosen"
        '
        'tnip
        '
        Me.tnip.BaseColor = System.Drawing.Color.White
        Me.tnip.BorderColor = System.Drawing.Color.Black
        Me.tnip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tnip.FocusedBaseColor = System.Drawing.Color.White
        Me.tnip.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tnip.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tnip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnip.Location = New System.Drawing.Point(169, 20)
        Me.tnip.Name = "tnip"
        Me.tnip.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnip.Size = New System.Drawing.Size(236, 32)
        Me.tnip.TabIndex = 4
        Me.tnip.Text = "GunaTextBox1"
        '
        'tnama
        '
        Me.tnama.BaseColor = System.Drawing.Color.White
        Me.tnama.BorderColor = System.Drawing.Color.Black
        Me.tnama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tnama.FocusedBaseColor = System.Drawing.Color.White
        Me.tnama.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tnama.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tnama.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnama.Location = New System.Drawing.Point(169, 61)
        Me.tnama.Name = "tnama"
        Me.tnama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnama.Size = New System.Drawing.Size(236, 32)
        Me.tnama.TabIndex = 7
        Me.tnama.Text = "GunaTextBox2"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.BackColor = System.Drawing.Color.Lime
        Me.GunaLabel4.Font = New System.Drawing.Font("Square721 BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(105, 9)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(234, 32)
        Me.GunaLabel4.TabIndex = 23
        Me.GunaLabel4.Text = "Data Dosen"
        Me.GunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btntutup)
        Me.GroupBox1.Controls.Add(Me.btnbatal)
        Me.GroupBox1.Controls.Add(Me.btnhapus)
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 106)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proses"
        '
        'btnsimpan
        '
        Me.btnsimpan.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.Location = New System.Drawing.Point(3, 16)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 87)
        Me.btnsimpan.TabIndex = 11
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(12, 344)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(432, 155)
        Me.DGV1.TabIndex = 19
        '
        'Data_Dosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(456, 502)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV1)
        Me.MaximizeBox = False
        Me.Name = "Data_Dosen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data_Dosen"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btntutup As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents tcari As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents tnip As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents tnama As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
End Class
