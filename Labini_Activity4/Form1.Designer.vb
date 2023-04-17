<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.login = New System.Windows.Forms.Button()
        Me.signup = New System.Windows.Forms.Button()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'login
        '
        Me.login.BackColor = System.Drawing.SystemColors.Highlight
        Me.login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.login.Location = New System.Drawing.Point(565, 326)
        Me.login.Margin = New System.Windows.Forms.Padding(0)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(94, 29)
        Me.login.TabIndex = 0
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = False
        '
        'signup
        '
        Me.signup.BackColor = System.Drawing.SystemColors.MenuBar
        Me.signup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signup.FlatAppearance.BorderSize = 0
        Me.signup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.signup.Location = New System.Drawing.Point(464, 326)
        Me.signup.Name = "signup"
        Me.signup.Size = New System.Drawing.Size(94, 29)
        Me.signup.TabIndex = 1
        Me.signup.Text = "Signup"
        Me.signup.UseVisualStyleBackColor = False
        '
        'username
        '
        Me.username.BackColor = System.Drawing.SystemColors.MenuBar
        Me.username.Location = New System.Drawing.Point(464, 202)
        Me.username.Name = "username"
        Me.username.PlaceholderText = "Enter username"
        Me.username.Size = New System.Drawing.Size(195, 27)
        Me.username.TabIndex = 2
        '
        'password
        '
        Me.password.BackColor = System.Drawing.SystemColors.MenuBar
        Me.password.Location = New System.Drawing.Point(464, 273)
        Me.password.Name = "password"
        Me.password.PlaceholderText = "Enter password"
        Me.password.Size = New System.Drawing.Size(195, 27)
        Me.password.TabIndex = 3
        Me.password.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(464, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(464, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Labini_Activity4.My.Resources.Resources.FOODERIA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(706, 422)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.signup)
        Me.Controls.Add(Me.login)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FOODERIA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents login As Button
    Friend WithEvents signup As Button
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
