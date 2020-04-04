Imports System.Data.SqlClient
Module ModuleKoneksi
	Public Conn As SqlConnection
	Public Dr As SqlDataReader
	Public Da As SqlDataAdapter
	Public Ds As DataSet
	Public Cmd As SqlCommand

	Sub Koneksi()
		Try
			Conn = New SqlConnection("Data Source =AERYICE-PC666\SQLEXPRESS2012; Initial Catalog = EDU; Integrated Security = True")
			Conn.Open()
			FormLogin.LabelStatusDb.Text = "Connected"
		Catch ex As Exception
			FormLogin.LabelStatusDb.Text = "Not Connected"
		End Try

	End Sub

End Module
