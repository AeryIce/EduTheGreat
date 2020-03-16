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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ButtonCancel = New System.Windows.Forms.Button()
		Me.ButtonLogin = New System.Windows.Forms.Button()
		Me.TextBoxLoginPassword = New System.Windows.Forms.TextBox()
		Me.LabelMasukanPassword = New System.Windows.Forms.Label()
		Me.TextBoxLoginUserName = New System.Windows.Forms.TextBox()
		Me.LabelMasukanUserName = New System.Windows.Forms.Label()
		Me.LabelStatusDb = New System.Windows.Forms.Label()
		Me.GroupBoxLoginUser.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBoxLoginUser
		'
		Me.GroupBoxLoginUser.Controls.Add(Me.Label1)
		Me.GroupBoxLoginUser.Controls.Add(Me.ButtonCancel)
		Me.GroupBoxLoginUser.Controls.Add(Me.ButtonLogin)
		Me.GroupBoxLoginUser.Controls.Add(Me.TextBoxLoginPassword)
		Me.GroupBoxLoginUser.Controls.Add(Me.LabelMasukanPassword)
		Me.GroupBoxLoginUser.Controls.Add(Me.TextBoxLoginUserName)
		Me.GroupBoxLoginUser.Controls.Add(Me.LabelMasukanUserName)
		Me.GroupBoxLoginUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GroupBoxLoginUser.Location = New System.Drawing.Point(56, 45)
		Me.GroupBoxLoginUser.Name = "GroupBoxLoginUser"
		Me.GroupBoxLoginUser.Size = New System.Drawing.Size(225, 336)
		Me.GroupBoxLoginUser.TabIndex = 0
		Me.GroupBoxLoginUser.TabStop = False
		Me.GroupBoxLoginUser.Text = " "
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(52, 51)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(117, 21)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "EDU.Corp"
		'
		'ButtonCancel
		'
		Me.ButtonCancel.BackColor = System.Drawing.Color.Transparent
		Me.ButtonCancel.FlatAppearance.BorderSize = 0
		Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonCancel.Location = New System.Drawing.Point(128, 193)
		Me.ButtonCancel.Name = "ButtonCancel"
		Me.ButtonCancel.Size = New System.Drawing.Size(86, 23)
		Me.ButtonCancel.TabIndex = 5
		Me.ButtonCancel.Text = "Cancel"
		Me.ButtonCancel.UseVisualStyleBackColor = False
		'
		'ButtonLogin
		'
		Me.ButtonLogin.BackColor = System.Drawing.Color.Transparent
		Me.ButtonLogin.FlatAppearance.BorderSize = 0
		Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonLogin.Location = New System.Drawing.Point(9, 193)
		Me.ButtonLogin.Name = "ButtonLogin"
		Me.ButtonLogin.Size = New System.Drawing.Size(97, 23)
		Me.ButtonLogin.TabIndex = 4
		Me.ButtonLogin.Text = "Login"
		Me.ButtonLogin.UseVisualStyleBackColor = False
		'
		'TextBoxLoginPassword
		'
		Me.TextBoxLoginPassword.BackColor = System.Drawing.Color.Aqua
		Me.TextBoxLoginPassword.Location = New System.Drawing.Point(114, 149)
		Me.TextBoxLoginPassword.Name = "TextBoxLoginPassword"
		Me.TextBoxLoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBoxLoginPassword.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxLoginPassword.TabIndex = 3
		'
		'LabelMasukanPassword
		'
		Me.LabelMasukanPassword.AutoSize = True
		Me.LabelMasukanPassword.Location = New System.Drawing.Point(37, 152)
		Me.LabelMasukanPassword.Name = "LabelMasukanPassword"
		Me.LabelMasukanPassword.Size = New System.Drawing.Size(53, 13)
		Me.LabelMasukanPassword.TabIndex = 2
		Me.LabelMasukanPassword.Text = "Password"
		'
		'TextBoxLoginUserName
		'
		Me.TextBoxLoginUserName.BackColor = System.Drawing.Color.Aqua
		Me.TextBoxLoginUserName.Location = New System.Drawing.Point(114, 111)
		Me.TextBoxLoginUserName.Name = "TextBoxLoginUserName"
		Me.TextBoxLoginUserName.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxLoginUserName.TabIndex = 1
		'
		'LabelMasukanUserName
		'
		Me.LabelMasukanUserName.AutoSize = True
		Me.LabelMasukanUserName.Location = New System.Drawing.Point(37, 114)
		Me.LabelMasukanUserName.Name = "LabelMasukanUserName"
		Me.LabelMasukanUserName.Size = New System.Drawing.Size(57, 13)
		Me.LabelMasukanUserName.TabIndex = 0
		Me.LabelMasukanUserName.Text = "UserName"
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
		'FormLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.SkyBlue
		Me.ClientSize = New System.Drawing.Size(345, 450)
		Me.Controls.Add(Me.LabelStatusDb)
		Me.Controls.Add(Me.GroupBoxLoginUser)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormLogin"
		Me.Opacity = 0.75R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormLogin"
		Me.GroupBoxLoginUser.ResumeLayout(False)
		Me.GroupBoxLoginUser.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBoxLoginUser As GroupBox
	Public WithEvents LabelStatusDb As Label
	Friend WithEvents LabelMasukanPassword As Label
	Friend WithEvents TextBoxLoginUserName As TextBox
	Friend WithEvents LabelMasukanUserName As Label
	Friend WithEvents ButtonCancel As Button
	Friend WithEvents ButtonLogin As Button
	Friend WithEvents TextBoxLoginPassword As TextBox
	Friend WithEvents Label1 As Label
End Class
