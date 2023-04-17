<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signupForm
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
        Me.fname = New System.Windows.Forms.Label()
        Me.lname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtContactnumber = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'fname
        '
        Me.fname.AutoSize = True
        Me.fname.BackColor = System.Drawing.Color.Transparent
        Me.fname.Location = New System.Drawing.Point(22, 140)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(87, 20)
        Me.fname.TabIndex = 0
        Me.fname.Text = "First Name: "
        '
        'lname
        '
        Me.lname.AutoSize = True
        Me.lname.BackColor = System.Drawing.Color.Transparent
        Me.lname.Location = New System.Drawing.Point(22, 191)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(82, 20)
        Me.lname.TabIndex = 1
        Me.lname.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(22, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(344, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(344, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contact Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(344, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Email:"
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(111, 133)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(196, 27)
        Me.txtFirstname.TabIndex = 6
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(111, 234)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(196, 27)
        Me.txtUsername.TabIndex = 8
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(111, 184)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(196, 27)
        Me.txtLastname.TabIndex = 9
        '
        'txtContactnumber
        '
        Me.txtContactnumber.Location = New System.Drawing.Point(482, 133)
        Me.txtContactnumber.Name = "txtContactnumber"
        Me.txtContactnumber.Size = New System.Drawing.Size(196, 27)
        Me.txtContactnumber.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(482, 241)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(196, 27)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(482, 191)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(196, 27)
        Me.txtEmail.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Brown
        Me.Label5.Location = New System.Drawing.Point(151, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(356, 38)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "WELCOME TO FOODERIA"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Brown
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(165, 316)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 29)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.login.BackColor = System.Drawing.SystemColors.Highlight
        Me.login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.login.Location = New System.Drawing.Point(371, 316)
        Me.login.Margin = New System.Windows.Forms.Padding(0)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(147, 29)
        Me.login.TabIndex = 16
        Me.login.Text = "Create Account"
        Me.login.UseVisualStyleBackColor = False
        '
        'signupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BackgroundImage = Global.Labini_Activity4.My.Resources.Resources.Untitled_design
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(706, 422)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtContactnumber)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.fname)
        Me.DoubleBuffered = True
        Me.Name = "signupForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fname As Label
    Friend WithEvents lname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtContactnumber As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents login As Button
End Class
