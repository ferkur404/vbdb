Imports System.Data.OleDb
Imports System.Data
Public Class popppeg
    Public colNIP, colNama, colJabatan, colTgl, colAlamat, colPendidikan, colStatus As String
    Dim cnn As OleDbConnection
    Dim cmmd As OleDbCommand
    Dim dReader As OleDbDataReader
    Private Sub clear_list()
        While Val(counter.Text) > 0
            ListView1.Items(0).Remove()
            counter.Text = Val(counter.Text) - 1
        End While
    End Sub
    Private Sub pilih()
        Try
            colNIP = ListView1.SelectedItems(0).SubItems(0).Text.ToString
            colNama = ListView1.SelectedItems(0).SubItems(1).Text.ToString
            colJabatan = ListView1.SelectedItems(0).SubItems(2).Text.ToString
            colTgl = ListView1.SelectedItems(0).SubItems(3).Text.ToString
            colAlamat = ListView1.SelectedItems(0).SubItems(4).Text.ToString
            colPendidikan = ListView1.SelectedItems(0).SubItems(5).Text.ToString
            colStatus = ListView1.SelectedItems(0).SubItems(6).Text.ToString
            Me.Close()
        Catch ex As Exception
            MsgBox("pilih salah satu data", MsgBoxStyle.Information)
        End Try
    End Sub
    Public Sub list_data()
        Call clear_list()

        Dim sqlx As String
        Dim x As Integer
        sqlx = "select NIP,Nama,Jabatan,Tgl,Alamat,Pendidikan,Status from Pegawai where Nama like '%" &
            Trim(Nama.Text) & "%' order by Nama asc"

        cnn = New OleDbConnection(KONEKSI)
        If cnn.State <> ConnectionState.Closed Then cnn.Close()
        cnn.Open()
        cmmd = New OleDbCommand(sqlx, cnn)
        dReader = cmmd.ExecuteReader
        Try
            While dReader.Read = True
                x = Val(counter.Text)
                counter.Text = Str(Val(counter.Text) + 1) & " Record"

                With ListView1
                    .Items.Add("")
                    .Items.Add(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items.Add(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items.Add(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items.Add(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items.Add(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items.Add(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items.Add(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(x).SubItems(0).Text = dReader.GetString(0)
                    .Items(x).SubItems(1).Text = dReader.GetString(1)
                    .Items(x).SubItems(2).Text = dReader.GetString(2)
                    .Items(x).SubItems(3).Text = dReader.GetString(3)
                    .Items(x).SubItems(4).Text = dReader.GetString(4)
                    .Items(x).SubItems(5).Text = dReader.GetString(5)
                    .Items(x).SubItems(6).Text = dReader.GetString(6)
                End With
            End While
        Finally
            dReader.Close()
        End Try
        cnn.Close()
    End Sub

    Private Sub popppeg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call list_data()
    End Sub

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        Call pilih()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Call pilih()
    End Sub

    Private Sub Nama_TextChanged(sender As Object, e As EventArgs) Handles Nama.TextChanged
        Call list_data()
    End Sub
End Class