﻿Imports System.Data.SqlClient
Imports System.IO
Public Class FormBook

    Sub BersihkanTextBoxCariBuku()
        TextBoxCariBuku.Clear()
    End Sub

    Sub Reset()
        TextBoxISBN.Clear()
        TextBoxJudul.Clear()
        TextBoxKategori.Clear()
        TextBox1StDateIn.Clear()
        TextBoxBinlok.Clear()
        TextBoxCIP.Clear()
        TextBoxPengarang.Clear()
        TextBoxPublisher.Clear()
        TextBoxQty.Clear()
        TextBoxSubject.Clear()
        TextBoxCariBuku.Clear()
        PBBook.Image = Nothing

    End Sub

    Sub LoadDGVBook()
        Call Koneksi()
        Da = New SqlDataAdapter("SELECT * FROM Stock_Sample_Edu", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        DGVBook.DataSource = Ds.Tables(0)
        DGVBook.ReadOnly = True
    End Sub

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TextBoxISBN.ReadOnly = True
        'TextBoxJudul.ReadOnly = True
        'TextBoxKategori.ReadOnly = True
        'TextBox1StDateIn.ReadOnly = True
        'TextBoxBinlok.ReadOnly = True
        'TextBoxCIP.ReadOnly = True
        'TextBoxPengarang.ReadOnly = True
        'TextBoxPublisher.ReadOnly = True
        'TextBoxQty.ReadOnly = True
        'TextBoxSubject.ReadOnly = True
        Call LoadDGVBook()

    End Sub
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
        FormLogin.Close()
    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click

    End Sub

    Private Sub ButtonHome_MouseHover(sender As Object, e As EventArgs) Handles ButtonHome.MouseHover
        Me.ButtonHome.BackColor = Color.White
    End Sub

    Private Sub ButtonHome_MouseLeave(sender As Object, e As EventArgs) Handles ButtonHome.MouseLeave
        Me.ButtonHome.BackColor = Color.LightBlue
    End Sub

    Private Sub ButtonExit_MouseHover(sender As Object, e As EventArgs) Handles ButtonExit.MouseHover
        Me.ButtonExit.BackColor = Color.White
    End Sub

    Private Sub ButtonExit_MouseLeave(sender As Object, e As EventArgs) Handles ButtonExit.MouseLeave
        Me.ButtonExit.BackColor = Color.LightBlue
    End Sub

    Private Sub ButtonAdmin_MouseHover(sender As Object, e As EventArgs) Handles ButtonAdmin.MouseHover
        Me.ButtonAdmin.BackColor = Color.White
    End Sub

    Private Sub ButtonAdmin_MouseLeave(sender As Object, e As EventArgs) Handles ButtonAdmin.MouseLeave
        Me.ButtonAdmin.BackColor = Color.LightBlue
    End Sub

    Private Sub ButtonReport_MouseHover(sender As Object, e As EventArgs) Handles ButtonReport.MouseHover
        Me.ButtonReport.BackColor = Color.White
    End Sub

    Private Sub ButtonReport_MouseLeave(sender As Object, e As EventArgs) Handles ButtonReport.MouseLeave
        Me.ButtonReport.BackColor = Color.LightBlue
    End Sub

    Private Sub ButtonBook_MouseHover(sender As Object, e As EventArgs) Handles ButtonBook.MouseHover
        Me.ButtonBook.BackColor = Color.White
    End Sub

    Private Sub ButtonBook_MouseLeave(sender As Object, e As EventArgs) Handles ButtonBook.MouseLeave
        Me.ButtonBook.BackColor = Color.LightBlue
    End Sub


    Private Sub ButtonBook_Click(sender As Object, e As EventArgs) Handles ButtonBook.Click

    End Sub



    Private Sub TextBoxCariBuku_Click(sender As Object, e As EventArgs) Handles TextBoxCariBuku.Click
        Call BersihkanTextBoxCariBuku()

    End Sub

    Private Sub TextBoxCariBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCariBuku.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBoxCariBuku.Text = "" Then
                Call Koneksi()

                Da = New SqlDataAdapter("SELECT * FROM Stock_Sample_Edu WHERE ISBN = '" & TextBoxCariBuku.Text & "' ", Conn)
                Ds = New DataSet
                Da.Fill(Ds)
                DGVBook.DataSource = Ds.Tables(0)
            Else
                Call Koneksi()
                Cmd = New SqlCommand("SELECT * FROM Stock_Sample_Edu WHERE ISBN = '" & TextBoxCariBuku.Text & "' ", Conn)
                Dr = Cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Call Koneksi()

                    Da = New SqlDataAdapter("SELECT * FROM Stock_Sample_Edu WHERE ISBN = '" & TextBoxCariBuku.Text & "' ", Conn)
                    Ds = New DataSet
                    Da.Fill(Ds)
                    DGVBook.DataSource = Ds.Tables(0)

                    TextBoxISBN.Text = Dr.Item("ISBN")
                    TextBox1StDateIn.Text = Dr.Item("FirstDateIn")
                    TextBoxBinlok.Text = Dr.Item("Binlok")
                    TextBoxCIP.Text = Dr.Item("CIP")
                    TextBoxJudul.Text = Dr.Item("Judul")
                    TextBoxKategori.Text = Dr.Item("Kategori")
                    TextBoxPengarang.Text = Dr.Item("Pengarang")
                    TextBoxPublisher.Text = Dr.Item("Publiser")
                    TextBoxQty.Text = Dr.Item("Qty")
                    TextBoxSubject.Text = Dr.Item("Subject")
                    Dim data As Byte() = DirectCast(Dr("Gambar"), Byte())
                    Dim ms As New MemoryStream(data)
                    PBBook.Image = Image.FromStream(ms)
                Else
                    If MsgBox("Maaf,Data Tidak Ada, Ulangi?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then

                        Call BersihkanTextBoxCariBuku()
                        Call LoadDGVBook()

                        TextBoxCariBuku.Focus()

                    Else
                        FormHome.Show()
                        Me.Close()

                    End If

                End If
            End If
            Call Koneksi()
            Cmd = New SqlCommand("SELECT * FROM Stock_Sample_Edu WHERE ISBN = '" & TextBoxCariBuku.Text & "' ", Conn)
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Call Koneksi()

                Da = New SqlDataAdapter("SELECT * FROM Stock_Sample_Edu WHERE ISBN = '" & TextBoxCariBuku.Text & "' ", Conn)
                Ds = New DataSet
                Da.Fill(Ds)
                DGVBook.DataSource = Ds.Tables(0)

                TextBoxISBN.Text = Dr.Item("ISBN")
                TextBox1StDateIn.Text = Dr.Item("FirstDateIn")
                TextBoxBinlok.Text = Dr.Item("Binlok")
                TextBoxCIP.Text = Dr.Item("CIP")
                TextBoxJudul.Text = Dr.Item("Judul")
                TextBoxKategori.Text = Dr.Item("Kategori")
                TextBoxPengarang.Text = Dr.Item("Pengarang")
                TextBoxPublisher.Text = Dr.Item("Publiser")
                TextBoxQty.Text = Dr.Item("Qty")
                TextBoxSubject.Text = Dr.Item("Subject")
                Dim data As Byte() = DirectCast(Dr("Gambar"), Byte())
                Dim ms As New MemoryStream(data)
                PBBook.Image = Image.FromStream(ms)
            Else
                If MsgBox("Maaf,Data Tidak Ada, Ulangi?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Me.Show()
                    Call BersihkanTextBoxCariBuku()
                    TextBoxCariBuku.Focus()
                Else
                    FormHome.Show()
                    Me.Close()

                End If

            End If
        End If

    End Sub

    Private Sub GroupBoxDataBuku_Enter(sender As Object, e As EventArgs) Handles GroupBoxDataBuku.Enter

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        Call Reset()
        Call LoadDGVBook()
    End Sub
End Class