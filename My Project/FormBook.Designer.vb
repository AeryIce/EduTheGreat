<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
		Me.PanelKiri = New System.Windows.Forms.Panel()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.ButtonReport = New System.Windows.Forms.Button()
		Me.ButtonAdmin = New System.Windows.Forms.Button()
		Me.ButtonBook = New System.Windows.Forms.Button()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.ButtonHome = New System.Windows.Forms.Button()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.PanelKiri.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PanelKiri
		'
		Me.PanelKiri.BackColor = System.Drawing.Color.Blue
		Me.PanelKiri.Controls.Add(Me.Panel5)
		Me.PanelKiri.Controls.Add(Me.ButtonReport)
		Me.PanelKiri.Controls.Add(Me.Panel4)
		Me.PanelKiri.Controls.Add(Me.ButtonAdmin)
		Me.PanelKiri.Controls.Add(Me.Panel6)
		Me.PanelKiri.Controls.Add(Me.ButtonBook)
		Me.PanelKiri.Controls.Add(Me.Panel3)
		Me.PanelKiri.Controls.Add(Me.Panel2)
		Me.PanelKiri.Controls.Add(Me.ButtonExit)
		Me.PanelKiri.Controls.Add(Me.ButtonHome)
		Me.PanelKiri.Location = New System.Drawing.Point(0, 0)
		Me.PanelKiri.Name = "PanelKiri"
		Me.PanelKiri.Size = New System.Drawing.Size(98, 450)
		Me.PanelKiri.TabIndex = 0
		'
		'Panel5
		'
		Me.Panel5.BackColor = System.Drawing.Color.Yellow
		Me.Panel5.Location = New System.Drawing.Point(1, 250)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(11, 32)
		Me.Panel5.TabIndex = 8
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.Yellow
		Me.Panel4.Location = New System.Drawing.Point(1, 172)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(11, 32)
		Me.Panel4.TabIndex = 4
		'
		'Panel6
		'
		Me.Panel6.BackColor = System.Drawing.Color.Yellow
		Me.Panel6.Location = New System.Drawing.Point(1, 210)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(11, 32)
		Me.Panel6.TabIndex = 6
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.Yellow
		Me.Panel3.Location = New System.Drawing.Point(3, 339)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(11, 32)
		Me.Panel3.TabIndex = 3
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.Yellow
		Me.Panel2.Location = New System.Drawing.Point(1, 134)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(11, 32)
		Me.Panel2.TabIndex = 2
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Yellow
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(801, 95)
		Me.Panel1.TabIndex = 1
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.EduTheGreat.My.Resources.Resources.Periplus_Education
		Me.PictureBox1.Location = New System.Drawing.Point(184, 134)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(554, 237)
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'ButtonReport
		'
		Me.ButtonReport.BackColor = System.Drawing.Color.LightSkyBlue
		Me.ButtonReport.FlatAppearance.BorderSize = 0
		Me.ButtonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonReport.Image = Global.EduTheGreat.My.Resources.Resources.stationery_32px
		Me.ButtonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonReport.Location = New System.Drawing.Point(12, 250)
		Me.ButtonReport.Name = "ButtonReport"
		Me.ButtonReport.Size = New System.Drawing.Size(83, 32)
		Me.ButtonReport.TabIndex = 7
		Me.ButtonReport.Text = "Report"
		Me.ButtonReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonReport.UseVisualStyleBackColor = False
		'
		'ButtonAdmin
		'
		Me.ButtonAdmin.BackColor = System.Drawing.Color.LightSkyBlue
		Me.ButtonAdmin.FlatAppearance.BorderSize = 0
		Me.ButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonAdmin.Image = Global.EduTheGreat.My.Resources.Resources.user_32px
		Me.ButtonAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonAdmin.Location = New System.Drawing.Point(12, 172)
		Me.ButtonAdmin.Name = "ButtonAdmin"
		Me.ButtonAdmin.Size = New System.Drawing.Size(83, 32)
		Me.ButtonAdmin.TabIndex = 3
		Me.ButtonAdmin.Text = "Admin"
		Me.ButtonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonAdmin.UseVisualStyleBackColor = False
		'
		'ButtonBook
		'
		Me.ButtonBook.BackColor = System.Drawing.Color.LightSkyBlue
		Me.ButtonBook.FlatAppearance.BorderSize = 0
		Me.ButtonBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonBook.Image = Global.EduTheGreat.My.Resources.Resources.book_32px
		Me.ButtonBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonBook.Location = New System.Drawing.Point(12, 210)
		Me.ButtonBook.Name = "ButtonBook"
		Me.ButtonBook.Size = New System.Drawing.Size(83, 32)
		Me.ButtonBook.TabIndex = 5
		Me.ButtonBook.Text = "Books"
		Me.ButtonBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonBook.UseVisualStyleBackColor = False
		'
		'ButtonExit
		'
		Me.ButtonExit.BackColor = System.Drawing.Color.LightSkyBlue
		Me.ButtonExit.FlatAppearance.BorderSize = 0
		Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonExit.Image = Global.EduTheGreat.My.Resources.Resources.exit_sign_32px
		Me.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonExit.Location = New System.Drawing.Point(14, 339)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(81, 32)
		Me.ButtonExit.TabIndex = 0
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonExit.UseVisualStyleBackColor = False
		'
		'ButtonHome
		'
		Me.ButtonHome.BackColor = System.Drawing.Color.LightSkyBlue
		Me.ButtonHome.FlatAppearance.BorderSize = 0
		Me.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonHome.Image = Global.EduTheGreat.My.Resources.Resources.home_32px
		Me.ButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonHome.Location = New System.Drawing.Point(12, 134)
		Me.ButtonHome.Name = "ButtonHome"
		Me.ButtonHome.Size = New System.Drawing.Size(83, 32)
		Me.ButtonHome.TabIndex = 0
		Me.ButtonHome.Text = "Home"
		Me.ButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonHome.UseVisualStyleBackColor = False
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(588, 410)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 28)
		Me.TableLayoutPanel1.TabIndex = 3
		'
		'FormHome
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.PanelKiri)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormHome"
		Me.Opacity = 0.85R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormHome"
		Me.PanelKiri.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PanelKiri As Panel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents ButtonHome As Button
	Friend WithEvents ButtonExit As Button
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Panel4 As Panel
	Friend WithEvents ButtonAdmin As Button
	Friend WithEvents Panel5 As Panel
	Friend WithEvents ButtonReport As Button
	Friend WithEvents Panel6 As Panel
	Friend WithEvents ButtonBook As Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
