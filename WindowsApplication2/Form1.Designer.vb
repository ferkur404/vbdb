<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nip = New System.Windows.Forms.TextBox()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.jabatan = New System.Windows.Forms.ComboBox()
        Me.Tgl = New System.Windows.Forms.DateTimePicker()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.pendidikan = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.blmnikah = New System.Windows.Forms.RadioButton()
        Me.rnikah = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.keluar = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.cari = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pegawai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jabatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pendidikan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Status"
        '
        'nip
        '
        Me.nip.Location = New System.Drawing.Point(143, 30)
        Me.nip.Name = "nip"
        Me.nip.Size = New System.Drawing.Size(100, 20)
        Me.nip.TabIndex = 7
        '
        'Nama
        '
        Me.Nama.Location = New System.Drawing.Point(143, 66)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(165, 20)
        Me.Nama.TabIndex = 8
        '
        'jabatan
        '
        Me.jabatan.FormattingEnabled = True
        Me.jabatan.Location = New System.Drawing.Point(143, 98)
        Me.jabatan.Name = "jabatan"
        Me.jabatan.Size = New System.Drawing.Size(165, 21)
        Me.jabatan.TabIndex = 9
        '
        'Tgl
        '
        Me.Tgl.Location = New System.Drawing.Point(143, 130)
        Me.Tgl.Name = "Tgl"
        Me.Tgl.Size = New System.Drawing.Size(165, 20)
        Me.Tgl.TabIndex = 10
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(143, 166)
        Me.alamat.Multiline = True
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(165, 44)
        Me.alamat.TabIndex = 11
        '
        'pendidikan
        '
        Me.pendidikan.FormattingEnabled = True
        Me.pendidikan.Location = New System.Drawing.Point(143, 216)
        Me.pendidikan.Name = "pendidikan"
        Me.pendidikan.Size = New System.Drawing.Size(165, 21)
        Me.pendidikan.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.blmnikah)
        Me.GroupBox1.Controls.Add(Me.rnikah)
        Me.GroupBox1.Location = New System.Drawing.Point(143, 242)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 43)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'blmnikah
        '
        Me.blmnikah.AutoSize = True
        Me.blmnikah.Location = New System.Drawing.Point(102, 16)
        Me.blmnikah.Name = "blmnikah"
        Me.blmnikah.Size = New System.Drawing.Size(90, 17)
        Me.blmnikah.TabIndex = 1
        Me.blmnikah.TabStop = True
        Me.blmnikah.Text = "RadioButton2"
        Me.blmnikah.UseVisualStyleBackColor = True
        '
        'rnikah
        '
        Me.rnikah.AutoSize = True
        Me.rnikah.Location = New System.Drawing.Point(6, 16)
        Me.rnikah.Name = "rnikah"
        Me.rnikah.Size = New System.Drawing.Size(90, 17)
        Me.rnikah.TabIndex = 0
        Me.rnikah.TabStop = True
        Me.rnikah.Text = "RadioButton1"
        Me.rnikah.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.keluar)
        Me.GroupBox2.Controls.Add(Me.cancel)
        Me.GroupBox2.Controls.Add(Me.delete)
        Me.GroupBox2.Controls.Add(Me.edit)
        Me.GroupBox2.Controls.Add(Me.save)
        Me.GroupBox2.Location = New System.Drawing.Point(385, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(111, 257)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " "
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(19, 214)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(75, 23)
        Me.keluar.TabIndex = 19
        Me.keluar.Text = "Exit"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(19, 106)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 18
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Enabled = False
        Me.delete.Location = New System.Drawing.Point(19, 77)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(75, 23)
        Me.delete.TabIndex = 17
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Enabled = False
        Me.edit.Location = New System.Drawing.Point(19, 48)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(75, 23)
        Me.edit.TabIndex = 16
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(19, 19)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(75, 23)
        Me.save.TabIndex = 15
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(249, 28)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(59, 23)
        Me.cari.TabIndex = 16
        Me.cari.Text = "Cari"
        Me.cari.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 332)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pendidikan)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.Tgl)
        Me.Controls.Add(Me.jabatan)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.nip)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nip As System.Windows.Forms.TextBox
    Friend WithEvents Nama As System.Windows.Forms.TextBox
    Friend WithEvents jabatan As System.Windows.Forms.ComboBox
    Friend WithEvents Tgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents alamat As System.Windows.Forms.TextBox
    Friend WithEvents pendidikan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents blmnikah As System.Windows.Forms.RadioButton
    Friend WithEvents rnikah As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents keluar As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents cari As System.Windows.Forms.Button

End Class
