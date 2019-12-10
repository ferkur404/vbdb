Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Sub BERSIH()
        nip.Text = ""
        Nama.Text = ""
        alamat.Text = ""
        jabatan.Text = ""
        pendidikan.Text = ""
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim nikah As String

        If nip.Text = "" Or Nama.Text = "" Then
            MsgBox("Isi data dengan benar", MsgBoxStyle.Exclamation, "Kesalahan")
            Exit Sub
        End If
        If rnikah.Checked = True Then
            nikah = "Belum Nikah"
        Else
            nikah = "Menikah"
        End If
        CON = New OleDbConnection(KONEKSI)
        If CON.State <> ConnectionState.Closed Then CON.Close()
        CON.Open()
        OLECMD = New OleDbCommand("insert into pegawai (NIP,Nama,Jabatan,Tgl,Alamat,Pendidikan,Status)values('" &
                                  nip.Text & "','" & Nama.Text & "','" & jabatan.Text & "','" & Tgl.Text &
                                  "','" & alamat.Text & "','" & pendidikan.Text & "','" & nikah & "')", CON)
        x = OLECMD.ExecuteNonQuery
        If x = 1 Then
            MsgBox("Data Berhasil disimpan", MsgBoxStyle.Information, "Informasi")
            Call BERSIH()
            nip.Focus()
        Else
            MsgBox("Gagal Menambahkan data", MsgBoxStyle.Exclamation, "Kesalahan")
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Call BERSIH()
        save.Enabled = True
        edit.Enabled = False
        delete.Enabled = False
        nip.Text = True
        nip.Focus()
    End Sub

    Private Sub nip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nip.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Nama.Focus()
        End If
    End Sub

    Private Sub Nama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nama.KeyPress
        If Asc(e.KeyChar) = 13 Then
            jabatan.Focus()
        End If
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Dim nikah As String

        If nip.Text = "" Or Nama.Text = "" Then
            MsgBox("Isi data dengan benar", MsgBoxStyle.Exclamation, "Kesalahan")
            Exit Sub
        End If
        If rnikah.Checked = True Then
            nikah = "Belum Nikah"
        Else
            nikah = "Menikah"
        End If
        CON = New OleDbConnection(KONEKSI)
        If CON.State <> ConnectionState.Closed Then CON.Close()
        CON.Open()
        OLECMD = New OleDbCommand("Update Pegawai Set Nama='" & Nama.Text &
                                  "',Jabatan='" & jabatan.Text &
                                  "',Tgl='" & Tgl.Text &
                                  "',Alamat='" & alamat.Text &
                                  "',Pendidikan='" & pendidikan.Text &
                                  "',Status='" & nikah & "' where NIP ='" & nip.Text & "'", CON)
        x = OLECMD.ExecuteNonQuery
        If x = 1 Then
            MsgBox("Data Berhasil disimpan", MsgBoxStyle.Information, "Informasi")
            Call BERSIH()
            nip.Focus()
        Else
            MsgBox("Gagal Menambahkan data", MsgBoxStyle.Exclamation, "Kesalahan")
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If MsgBox("Ingin menghapus data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            CON = New OleDbConnection(KONEKSI)
            If CON.State <> ConnectionState.Closed Then CON.Close()
            CON.Open()
            OLECMD = New OleDbCommand("delete from Pegawai where NIP ='" & nip.Text & "'", CON)
            x = OLECMD.ExecuteNonQuery
            If x = 1 Then
                Call BERSIH()
                save.Enabled = True
                edit.Enabled = False
                delete.Enabled = False
                nip.Focus()
            Else
                MsgBox("Gagal menghapus data", MsgBoxStyle.Exclamation, "Kesalahan")
            End If
        End If
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Me.Dispose()
    End Sub

    Private Sub cari_Click(sender As Object, e As EventArgs) Handles cari.Click
        Dim poppegawai As New popppeg
        poppegawai.ShowDialog()
        If poppegawai.colNama <> "" Then
            nip.Text = poppegawai.colNIP
            Nama.Text = poppegawai.colNama
            jabatan.Text = poppegawai.colJabatan
            Tgl.Text = poppegawai.colTgl
            alamat.Text = poppegawai.colAlamat
            pendidikan.Text = poppegawai.colPendidikan
            If poppegawai.colStatus = "Nikah" Then
                rnikah.Checked = True
            Else
                rnikah.Checked = False
            End If
            nip.Enabled = False
            Nama.Focus()
        End If
        edit.Enabled = True
        delete.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jabatan.Items.Add("Manager")
        jabatan.Items.Add("Karyawan")
        pendidikan.Items.Add("SMA")
        pendidikan.Items.Add("S1")
        pendidikan.Items.Add("S2")
    End Sub
End Class

