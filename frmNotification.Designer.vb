<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotification
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotification))
        Me.NotificationUI = New DevExpress.XtraEditors.GroupControl()
        Me.lblClose = New DevExpress.XtraEditors.LabelControl()
        Me.lblNotificationMessage = New DevExpress.XtraEditors.LabelControl()
        Me.NotificationIcon = New DevExpress.XtraEditors.PictureEdit()
        Me.lblHeading = New DevExpress.XtraEditors.LabelControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.NotificationUI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NotificationUI.SuspendLayout()
        CType(Me.NotificationIcon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotificationUI
        '
        Me.NotificationUI.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotificationUI.Appearance.Options.UseFont = True
        Me.NotificationUI.AppearanceCaption.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.NotificationUI.AppearanceCaption.Options.UseFont = True
        Me.NotificationUI.Controls.Add(Me.lblClose)
        Me.NotificationUI.Controls.Add(Me.lblNotificationMessage)
        Me.NotificationUI.Controls.Add(Me.NotificationIcon)
        Me.NotificationUI.Controls.Add(Me.lblHeading)
        Me.NotificationUI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotificationUI.Location = New System.Drawing.Point(0, 0)
        Me.NotificationUI.Name = "NotificationUI"
        Me.NotificationUI.Size = New System.Drawing.Size(408, 95)
        Me.NotificationUI.TabIndex = 0
        Me.NotificationUI.Text = "NotifyTitle"
        '
        'lblClose
        '
        Me.lblClose.Appearance.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.Appearance.Options.UseFont = True
        Me.lblClose.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.AppearanceHovered.Options.UseFont = True
        Me.lblClose.AppearancePressed.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblClose.AppearancePressed.Options.UseFont = True
        Me.lblClose.Location = New System.Drawing.Point(386, 2)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(19, 16)
        Me.lblClose.TabIndex = 3
        Me.lblClose.Text = "  X  "
        '
        'lblNotificationMessage
        '
        Me.lblNotificationMessage.Appearance.Font = New System.Drawing.Font("Ubuntu Condensed", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblNotificationMessage.Appearance.Options.UseFont = True
        Me.lblNotificationMessage.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu Condensed", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblNotificationMessage.AppearanceDisabled.Options.UseFont = True
        Me.lblNotificationMessage.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu Condensed", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblNotificationMessage.AppearanceHovered.Options.UseFont = True
        Me.lblNotificationMessage.AppearancePressed.Font = New System.Drawing.Font("Ubuntu Condensed", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificationMessage.AppearancePressed.Options.UseFont = True
        Me.lblNotificationMessage.Location = New System.Drawing.Point(88, 41)
        Me.lblNotificationMessage.Name = "lblNotificationMessage"
        Me.lblNotificationMessage.Size = New System.Drawing.Size(89, 16)
        Me.lblNotificationMessage.TabIndex = 2
        Me.lblNotificationMessage.Text = "Notification Message"
        '
        'NotificationIcon
        '
        Me.NotificationIcon.Cursor = System.Windows.Forms.Cursors.Default
        Me.NotificationIcon.EditValue = CType(resources.GetObject("NotificationIcon.EditValue"), Object)
        Me.NotificationIcon.Location = New System.Drawing.Point(5, 26)
        Me.NotificationIcon.Name = "NotificationIcon"
        Me.NotificationIcon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.NotificationIcon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.NotificationIcon.Properties.ZoomAccelerationFactor = 1.0R
        Me.NotificationIcon.Size = New System.Drawing.Size(64, 64)
        Me.NotificationIcon.TabIndex = 1
        '
        'lblHeading
        '
        Me.lblHeading.Appearance.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Appearance.Options.UseFont = True
        Me.lblHeading.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.AppearanceHovered.Options.UseFont = True
        Me.lblHeading.AppearancePressed.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.AppearancePressed.Options.UseFont = True
        Me.lblHeading.LineVisible = True
        Me.lblHeading.Location = New System.Drawing.Point(75, 26)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(67, 17)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "labelHeading"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frmNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 95)
        Me.Controls.Add(Me.NotificationUI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNotification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmNotification"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.NotificationUI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NotificationUI.ResumeLayout(False)
        Me.NotificationUI.PerformLayout()
        CType(Me.NotificationIcon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotificationUI As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblNotificationMessage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NotificationIcon As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblHeading As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblClose As DevExpress.XtraEditors.LabelControl
End Class
