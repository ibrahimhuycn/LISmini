<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAuthenticate
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
        Me.GroupControlAuthentication = New DevExpress.XtraEditors.GroupControl()
        Me.AuthenticateDescription = New System.Windows.Forms.Label()
        Me.AuthenticateHeader = New System.Windows.Forms.Label()
        Me.PictureBoxAuthenticateIcon = New System.Windows.Forms.PictureBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.LogIn = New System.Windows.Forms.Button()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.UserName = New System.Windows.Forms.TextBox()
        CType(Me.GroupControlAuthentication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControlAuthentication.SuspendLayout()
        CType(Me.PictureBoxAuthenticateIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControlAuthentication
        '
        Me.GroupControlAuthentication.AppearanceCaption.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControlAuthentication.AppearanceCaption.Options.UseFont = True
        Me.GroupControlAuthentication.Controls.Add(Me.AuthenticateDescription)
        Me.GroupControlAuthentication.Controls.Add(Me.AuthenticateHeader)
        Me.GroupControlAuthentication.Controls.Add(Me.PictureBoxAuthenticateIcon)
        Me.GroupControlAuthentication.Controls.Add(Me.Cancel)
        Me.GroupControlAuthentication.Controls.Add(Me.LogIn)
        Me.GroupControlAuthentication.Controls.Add(Me.Password)
        Me.GroupControlAuthentication.Controls.Add(Me.UserName)
        Me.GroupControlAuthentication.Location = New System.Drawing.Point(1, 1)
        Me.GroupControlAuthentication.Name = "GroupControlAuthentication"
        Me.GroupControlAuthentication.Size = New System.Drawing.Size(296, 161)
        Me.GroupControlAuthentication.TabIndex = 0
        Me.GroupControlAuthentication.Text = "Authentication"
        '
        'AuthenticateDescription
        '
        Me.AuthenticateDescription.AutoSize = True
        Me.AuthenticateDescription.Location = New System.Drawing.Point(62, 55)
        Me.AuthenticateDescription.Name = "AuthenticateDescription"
        Me.AuthenticateDescription.Size = New System.Drawing.Size(204, 13)
        Me.AuthenticateDescription.TabIndex = 27
        Me.AuthenticateDescription.Text = "please enter your credentials to continue"
        '
        'AuthenticateHeader
        '
        Me.AuthenticateHeader.AutoSize = True
        Me.AuthenticateHeader.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthenticateHeader.Location = New System.Drawing.Point(62, 33)
        Me.AuthenticateHeader.Name = "AuthenticateHeader"
        Me.AuthenticateHeader.Size = New System.Drawing.Size(132, 16)
        Me.AuthenticateHeader.TabIndex = 26
        Me.AuthenticateHeader.Text = "Authentication Required"
        '
        'PictureBoxAuthenticateIcon
        '
        Me.PictureBoxAuthenticateIcon.Image = Global.LISmini.My.Resources.Resources.Authenticate
        Me.PictureBoxAuthenticateIcon.Location = New System.Drawing.Point(8, 25)
        Me.PictureBoxAuthenticateIcon.Name = "PictureBoxAuthenticateIcon"
        Me.PictureBoxAuthenticateIcon.Size = New System.Drawing.Size(47, 53)
        Me.PictureBoxAuthenticateIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxAuthenticateIcon.TabIndex = 25
        Me.PictureBoxAuthenticateIcon.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(133, 132)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 21
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.LogIn.Location = New System.Drawing.Point(214, 132)
        Me.LogIn.Name = "LogIn"
        Me.LogIn.Size = New System.Drawing.Size(75, 23)
        Me.LogIn.TabIndex = 24
        Me.LogIn.Text = "Log In"
        Me.LogIn.UseVisualStyleBackColor = True
        '
        'Password
        '
        Me.Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Password.Location = New System.Drawing.Point(6, 107)
        Me.Password.Margin = New System.Windows.Forms.Padding(2)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(283, 21)
        Me.Password.TabIndex = 23
        Me.Password.Text = "Password"
        Me.Password.UseSystemPasswordChar = True
        '
        'UserName
        '
        Me.UserName.Location = New System.Drawing.Point(6, 83)
        Me.UserName.Margin = New System.Windows.Forms.Padding(2)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(283, 21)
        Me.UserName.TabIndex = 22
        Me.UserName.Text = "Username"
        '
        'Authenticate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 163)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControlAuthentication)
        Me.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Authenticate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.GroupControlAuthentication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControlAuthentication.ResumeLayout(False)
        Me.GroupControlAuthentication.PerformLayout()
        CType(Me.PictureBoxAuthenticateIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControlAuthentication As DevExpress.XtraEditors.GroupControl
    Friend WithEvents AuthenticateDescription As Label
    Friend WithEvents AuthenticateHeader As Label
    Friend WithEvents PictureBoxAuthenticateIcon As PictureBox
    Friend WithEvents Cancel As Button
    Friend WithEvents LogIn As Button
    Friend WithEvents Password As TextBox
    Friend WithEvents UserName As TextBox
End Class
