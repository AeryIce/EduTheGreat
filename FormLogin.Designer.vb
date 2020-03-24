<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
		Me.GroupBoxLoginUser = New System.Windows.Forms.GroupBox()
		Me.TextBoxLoginPassword = New System.Windows.Forms.TextBox()
		Me.TextBoxLoginUserName = New System.Windows.Forms.TextBox()
		Me.LabelStatusDb = New System.Windows.Forms.Label()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.ButtonCancel = New System.Windows.Forms.Button()
		Me.ButtonLogin = New System.Windows.Forms.Button()
		Me.GroupBoxLoginUser.SuspendLayout()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBoxLoginUser
		'
		Me.GroupBoxLoginUser.BackColor = System.Drawing.Color.LemonChiffon
		Me.GroupBoxLoginUser.Controls.Add(Me.PictureBox3)
		Me.GroupBoxLoginUser.Controls.Add(Me.PictureBox2)
		Me.GroupBoxLoginUser.Controls.Add(Me.PictureBox1)
		Me.GroupBoxLoginUser.Controls.Add(Me.ButtonCancel)
		Me.GroupBoxLoginUser.Controls.Add(Me.ButtonLogin)
		Me.GroupBoxLoginUser.Controls.Add(Me.TextBoxLoginPassword)
		Me.GroupBoxLoginUser.Controls.Add(Me.TextBoxLoginUserName)
		Me.GroupBoxLoginUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GroupBoxLoginUser.Location = New System.Drawing.Point(56, 45)
		Me.GroupBoxLoginUser.Name = "GroupBoxLoginUser"
		Me.GroupBoxLoginUser.Size = New System.Drawing.Size(225, 336)
		Me.GroupBoxLoginUser.TabIndex = 0
		Me.GroupBoxLoginUser.TabStop = False
		Me.GroupBoxLoginUser.Text = " "
		'
		'TextBoxLoginPassword
		'
		Me.TextBoxLoginPassword.BackColor = System.Drawing.Color.Snow
		Me.TextBoxLoginPassword.Location = New System.Drawing.Point(82, 152)
		Me.TextBoxLoginPassword.Name = "TextBoxLoginPassword"
		Me.TextBoxLoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBoxLoginPassword.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxLoginPassword.TabIndex = 3
		'
		'TextBoxLoginUserName
		'
		Me.TextBoxLoginUserName.BackColor = System.Drawing.Color.Snow
		Me.TextBoxLoginUserName.Location = New System.Drawing.Point(82, 111)
		Me.TextBoxLoginUserName.Name = "TextBoxLoginUserName"
		Me.TextBoxLoginUserName.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxLoginUserName.TabIndex = 1
		'
		'LabelStatusDb
		'
		Me.LabelStatusDb.AutoSize = True
		Me.LabelStatusDb.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelStatusDb.Location = New System.Drawing.Point(605, 388)
		Me.LabelStatusDb.Name = "LabelStatusDb"
		Me.LabelStatusDb.Size = New System.Drawing.Size(12, 11)
		Me.LabelStatusDb.TabIndex = 0
		Me.LabelStatusDb.Text = "."
		'
		'PictureBox3
		'
		Me.PictureBox3.Image = Global.EduTheGreat.My.Resources.Resources.key_2_32px
		Me.PictureBox3.Location = New System.Drawing.Point(41, 152)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(35, 20)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox3.TabIndex = 8
		Me.PictureBox3.TabStop = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = Global.EduTheGreat.My.Resources.Resources.password_96px
		Me.PictureBox2.Location = New System.Drawing.Point(75, 21)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(96, 62)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 7
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.EduTheGreat.My.Resources.Resources.user_32px
		Me.PictureBox1.Location = New System.Drawing.Point(44, 108)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(32, 23)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 6
		Me.PictureBox1.TabStop = False
		'
		'ButtonCancel
		'
		Me.ButtonCancel.BackColor = System.Drawing.Color.Transparent
		Me.ButtonCancel.FlatAppearance.BorderSize = 0
		Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonCancel.Image = Global.EduTheGreat.My.Resources.Resources.cancel_32px
		Me.ButtonCancel.Location = New System.Drawing.Point(141, 193)
		Me.ButtonCancel.Name = "ButtonCancel"
		Me.ButtonCancel.Size = New System.Drawing.Size(41, 33)
		Me.ButtonCancel.TabIndex = 5
		Me.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonCancel.UseVisualStyleBackColor = False
		'
		'ButtonLogin
		'
		Me.ButtonLogin.BackColor = System.Drawing.Color.Transparent
		Me.ButtonLogin.FlatAppearance.BorderSize = 0
		Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonLogin.Image = Global.EduTheGreat.My.Resources.Resources.login_rounded_32px
		Me.ButtonLogin.Location = New System.Drawing.Point(82, 193)
		Me.ButtonLogin.Name = "ButtonLogin"
		Me.ButtonLogin.Size = New System.Drawing.Size(44, 33)
		Me.ButtonLogin.TabIndex = 4
		Me.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonLogin.UseVisualStyleBackColor = False
		'
		'FormLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LightYellow
		Me.ClientSize = New System.Drawing.Size(345, 450)
		Me.Controls.Add(Me.LabelStatusDb)
		Me.Controls.Add(Me.GroupBoxLoginUser)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormLogin"
		Me.Opacity = 0.9R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormLogin"
		Me.GroupBoxLoginUser.ResumeLayout(False)
		Me.GroupBoxLoginUser.PerformLayout()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBoxLoginUser As GroupBox
	Public WithEvents LabelStatusDb As Label
	Friend WithEvents TextBoxLoginUserName As TextBox
	Friend WithEvents ButtonCancel As Button
	Friend WithEvents ButtonLogin As Button
	Friend WithEvents TextBoxLoginPassword As TextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents PictureBox3 As PictureBox
End Class
