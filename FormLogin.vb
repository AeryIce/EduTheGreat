Imports System.Data.SqlClient
Public Class FormLogin
	Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call Koneksi()
		TextBoxLoginUserName.Focus()
		ButtonLogin.Enabled = False


	End Sub

	Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
		Call Koneksi()
		Cmd = New SqlCommand("SELECT * FROM KARYAWAN_EDU WHERE NAMA_KARYAWAN ='" & TextBoxLoginUserName.Text & "' and PASSWORD_KARYAWAN ='" & TextBoxLoginPassword.Text & "' ", Conn)
		Dr = Cmd.ExecuteReader
		If Dr.HasRows Then
			FormHome.Show()
			Me.Visible = False
		Else
			If MsgBox("UserName dan Password Tidak Terdaftar, Ulangi Login?", MsgBoxStyle.YesNo, "Konfimasi") = MsgBoxResult.Yes Then
				TextBoxLoginUserName.Text = ""
				TextBoxLoginPassword.Text = ""
				Me.Show()
			Else
				Me.Close()
			End If
		End If




	End Sub

	Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
		If MsgBox("Quit ?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
			Me.Close()
		Else
			TextBoxLoginUserName.Text = ""
			TextBoxLoginPassword.Text = ""
		End If

	End Sub

	Private Sub TextBoxLoginUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLoginUserName.KeyPress
		If e.KeyChar = Chr(13) Then
			TextBoxLoginPassword.Focus()
		End If

	End Sub

	Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLoginPassword.KeyPress
		If e.KeyChar = Chr(13) Then
			ButtonLogin.Enabled = True
			ButtonLogin.Focus()
		End If

	End Sub
End Class
