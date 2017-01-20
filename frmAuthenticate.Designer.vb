<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuthenticate
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
        Me.lblAuthenticateDescription = New System.Windows.Forms.Label()
        Me.lbLAuthenticateHeader = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        CType(Me.GroupControlAuthentication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControlAuthentication.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControlAuthentication
        '
        Me.GroupControlAuthentication.AppearanceCaption.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControlAuthentication.AppearanceCaption.Options.UseFont = True
        Me.GroupControlAuthentication.Controls.Add(Me.lblAuthenticateDescription)
        Me.GroupControlAuthentication.Controls.Add(Me.lbLAuthenticateHeader)
        Me.GroupControlAuthentication.Controls.Add(Me.PictureBox1)
        Me.GroupControlAuthentication.Controls.Add(Me.btnCancel)
        Me.GroupControlAuthentication.Controls.Add(Me.btnLogIn)
        Me.GroupControlAuthentication.Controls.Add(Me.txtPassword)
        Me.GroupControlAuthentication.Controls.Add(Me.txtUserName)
        Me.GroupControlAuthentication.Location = New System.Drawing.Point(1, 1)
        Me.GroupControlAuthentication.Name = "GroupControlAuthentication"
        Me.GroupControlAuthentication.Size = New System.Drawing.Size(296, 161)
        Me.GroupControlAuthentication.TabIndex = 0
        Me.GroupControlAuthentication.Text = "Authentication"
        '
        'lblAuthenticateDescription
        '
        Me.lblAuthenticateDescription.AutoSize = True
        Me.lblAuthenticateDescription.Location = New System.Drawing.Point(62, 55)
        Me.lblAuthenticateDescription.Name = "lblAuthenticateDescription"
        Me.lblAuthenticateDescription.Size = New System.Drawing.Size(204, 13)
        Me.lblAuthenticateDescription.TabIndex = 27
        Me.lblAuthenticateDescription.Text = "please enter your credentials to continue"
        '
        'lbLAuthenticateHeader
        '
        Me.lbLAuthenticateHeader.AutoSize = True
        Me.lbLAuthenticateHeader.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLAuthenticateHeader.Location = New System.Drawing.Point(62, 33)
        Me.lbLAuthenticateHeader.Name = "lbLAuthenticateHeader"
        Me.lbLAuthenticateHeader.Size = New System.Drawing.Size(132, 16)
        Me.lbLAuthenticateHeader.TabIndex = 26
        Me.lbLAuthenticateHeader.Text = "Authentication Required"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LISmini.My.Resources.Resources.Authenticate1
        Me.PictureBox1.Location = New System.Drawing.Point(8, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(133, 132)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(214, 132)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(75, 23)
        Me.btnLogIn.TabIndex = 24
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(6, 107)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(283, 21)
        Me.txtPassword.TabIndex = 23
        Me.txtPassword.Text = "Password"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(6, 83)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(283, 21)
        Me.txtUserName.TabIndex = 22
        Me.txtUserName.Text = "Username"
        '
        'frmAuthenticate
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
        Me.Name = "frmAuthenticate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.GroupControlAuthentication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControlAuthentication.ResumeLayout(False)
        Me.GroupControlAuthentication.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControlAuthentication As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblAuthenticateDescription As Label
    Friend WithEvents lbLAuthenticateHeader As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnLogIn As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserName As TextBox
End Class
