<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddPatient
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
        Me.SimpleButtonBack = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelAddress = New DevExpress.XtraEditors.LabelControl()
        Me.xTabPageContactInfo = New DevExpress.XtraTab.XtraTabPage()
        Me.SimpleButtonRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControlAddContact = New DevExpress.XtraGrid.GridControl()
        Me.GridViewAddContact = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButtonAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEditContactDetail = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButtonSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelContactDetail = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButtonBackContactInfo = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboBoxEditContactType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelContactType = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButtonAddressNext = New DevExpress.XtraEditors.SimpleButton()
        Me.xTabAddPatientRecords = New DevExpress.XtraTab.XtraTabControl()
        Me.xTabPagePersonalInfo = New DevExpress.XtraTab.XtraTabPage()
        Me.ToggleSwitchNationalIdPassportNumber = New DevExpress.XtraEditors.ToggleSwitch()
        Me.TextEditDateOfBirth = New DevExpress.XtraEditors.DateEdit()
        Me.LabelHospitalNumber = New DevExpress.XtraEditors.LabelControl()
        Me.TextEditHospitalNumber = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButtonPersonalInfoNext = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelNid = New DevExpress.XtraEditors.LabelControl()
        Me.TextEditNid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelPatientName = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEditGender = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TextEditPatientName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelDob = New DevExpress.XtraEditors.LabelControl()
        Me.LabelGender = New DevExpress.XtraEditors.LabelControl()
        Me.xTabPageAddress = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelCountry = New DevExpress.XtraEditors.LabelControl()
        Me.TextEditAddress = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxEditAtoll = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelAtoll = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxIsland = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelIsland = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEditCountry = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupPatientDetails = New DevExpress.XtraEditors.GroupControl()
        Me.LabelClose = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControlSummary = New DevExpress.XtraEditors.GroupControl()
        Me.LabelSummary = New DevExpress.XtraEditors.LabelControl()
        Me.xTabPageContactInfo.SuspendLayout()
        CType(Me.GridControlAddContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAddContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditContactDetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEditContactType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xTabAddPatientRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xTabAddPatientRecords.SuspendLayout()
        Me.xTabPagePersonalInfo.SuspendLayout()
        CType(Me.ToggleSwitchNationalIdPassportNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditDateOfBirth.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditDateOfBirth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditHospitalNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditNid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEditGender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditPatientName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xTabPageAddress.SuspendLayout()
        CType(Me.TextEditAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEditAtoll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxIsland.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEditCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupPatientDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPatientDetails.SuspendLayout()
        CType(Me.GroupControlSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControlSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'SimpleButtonBack
        '
        Me.SimpleButtonBack.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButtonBack.Appearance.Options.UseFont = True
        Me.SimpleButtonBack.Location = New System.Drawing.Point(272, 119)
        Me.SimpleButtonBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButtonBack.Name = "SimpleButtonBack"
        Me.SimpleButtonBack.Size = New System.Drawing.Size(75, 28)
        Me.SimpleButtonBack.TabIndex = 12
        Me.SimpleButtonBack.Text = "Ba&ck"
        '
        'LabelAddress
        '
        Me.LabelAddress.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.Appearance.Options.UseFont = True
        Me.LabelAddress.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.AppearanceDisabled.Options.UseFont = True
        Me.LabelAddress.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.AppearanceHovered.Options.UseFont = True
        Me.LabelAddress.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.AppearancePressed.Options.UseFont = True
        Me.LabelAddress.Location = New System.Drawing.Point(16, 15)
        Me.LabelAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(41, 16)
        Me.LabelAddress.TabIndex = 6
        Me.LabelAddress.Text = "Address"
        '
        'xTabPageContactInfo
        '
        Me.xTabPageContactInfo.Controls.Add(Me.SimpleButtonRemove)
        Me.xTabPageContactInfo.Controls.Add(Me.GridControlAddContact)
        Me.xTabPageContactInfo.Controls.Add(Me.SimpleButtonAdd)
        Me.xTabPageContactInfo.Controls.Add(Me.TextEditContactDetail)
        Me.xTabPageContactInfo.Controls.Add(Me.SimpleButtonSave)
        Me.xTabPageContactInfo.Controls.Add(Me.LabelContactDetail)
        Me.xTabPageContactInfo.Controls.Add(Me.SimpleButtonBackContactInfo)
        Me.xTabPageContactInfo.Controls.Add(Me.ComboBoxEditContactType)
        Me.xTabPageContactInfo.Controls.Add(Me.LabelContactType)
        Me.xTabPageContactInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.xTabPageContactInfo.Name = "xTabPageContactInfo"
        Me.xTabPageContactInfo.Size = New System.Drawing.Size(470, 154)
        Me.xTabPageContactInfo.Text = "CONTACT INFO"
        '
        'SimpleButtonRemove
        '
        Me.SimpleButtonRemove.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonRemove.Appearance.Options.UseFont = True
        Me.SimpleButtonRemove.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonRemove.AppearanceDisabled.Options.UseFont = True
        Me.SimpleButtonRemove.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonRemove.AppearanceHovered.Options.UseFont = True
        Me.SimpleButtonRemove.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonRemove.AppearancePressed.Options.UseFont = True
        Me.SimpleButtonRemove.Location = New System.Drawing.Point(386, 46)
        Me.SimpleButtonRemove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButtonRemove.Name = "SimpleButtonRemove"
        Me.SimpleButtonRemove.Size = New System.Drawing.Size(75, 28)
        Me.SimpleButtonRemove.TabIndex = 16
        Me.SimpleButtonRemove.Text = "&Remove"
        '
        'GridControlAddContact
        '
        Me.GridControlAddContact.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControlAddContact.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControlAddContact.Location = New System.Drawing.Point(8, 56)
        Me.GridControlAddContact.MainView = Me.GridViewAddContact
        Me.GridControlAddContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControlAddContact.Name = "GridControlAddContact"
        Me.GridControlAddContact.Size = New System.Drawing.Size(372, 94)
        Me.GridControlAddContact.TabIndex = 15
        Me.GridControlAddContact.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAddContact})
        '
        'GridViewAddContact
        '
        Me.GridViewAddContact.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewAddContact.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.GridViewAddContact.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewAddContact.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.GridViewAddContact.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewAddContact.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.GridViewAddContact.Appearance.DetailTip.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewAddContact.Appearance.DetailTip.Options.UseFont = True
        Me.GridViewAddContact.Appearance.Empty.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewAddContact.Appearance.Empty.Options.UseFont = True
        Me.GridViewAddContact.Appearance.EvenRow.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewAddContact.Appearance.EvenRow.Options.UseFont = True
        Me.GridViewAddContact.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewAddContact.Appearance.FilterCloseButton.Options.UseFont = True
        Me.GridViewAddContact.Appearance.FilterPanel.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewAddContact.Appearance.FilterPanel.Options.UseFont = True
        Me.GridViewAddContact.Appearance.FixedLine.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.FixedLine.Options.UseFont = True
        Me.GridViewAddContact.Appearance.FocusedCell.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.FocusedCell.Options.UseFont = True
        Me.GridViewAddContact.Appearance.FocusedRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewAddContact.Appearance.FooterPanel.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewAddContact.Appearance.GroupButton.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.GroupButton.Options.UseFont = True
        Me.GridViewAddContact.Appearance.GroupFooter.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewAddContact.Appearance.GroupPanel.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.GroupPanel.Options.UseFont = True
        Me.GridViewAddContact.Appearance.GroupRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.GroupRow.Options.UseFont = True
        Me.GridViewAddContact.Appearance.HeaderPanel.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewAddContact.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.HideSelectionRow.Options.UseFont = True
        Me.GridViewAddContact.Appearance.HorzLine.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.HorzLine.Options.UseFont = True
        Me.GridViewAddContact.Appearance.OddRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.OddRow.Options.UseFont = True
        Me.GridViewAddContact.Appearance.Preview.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.Preview.Options.UseFont = True
        Me.GridViewAddContact.Appearance.Row.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.Row.Options.UseFont = True
        Me.GridViewAddContact.Appearance.RowSeparator.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.RowSeparator.Options.UseFont = True
        Me.GridViewAddContact.Appearance.SelectedRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.SelectedRow.Options.UseFont = True
        Me.GridViewAddContact.Appearance.TopNewRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.TopNewRow.Options.UseFont = True
        Me.GridViewAddContact.Appearance.VertLine.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.Appearance.VertLine.Options.UseFont = True
        Me.GridViewAddContact.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.AppearancePrint.EvenRow.Options.UseFont = True
        Me.GridViewAddContact.AppearancePrint.FilterPanel.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.AppearancePrint.FilterPanel.Options.UseFont = True
        Me.GridViewAddContact.AppearancePrint.FooterPanel.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.GridViewAddContact.AppearancePrint.GroupFooter.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.AppearancePrint.GroupFooter.Options.UseFont = True
        Me.GridViewAddContact.AppearancePrint.GroupRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.AppearancePrint.GroupRow.Options.UseFont = True
        Me.GridViewAddContact.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.GridViewAddContact.AppearancePrint.Lines.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.AppearancePrint.Lines.Options.UseFont = True
        Me.GridViewAddContact.AppearancePrint.OddRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.AppearancePrint.OddRow.Options.UseFont = True
        Me.GridViewAddContact.AppearancePrint.Preview.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Strikeout)
        Me.GridViewAddContact.AppearancePrint.Preview.FontStyleDelta = System.Drawing.FontStyle.Strikeout
        Me.GridViewAddContact.AppearancePrint.Preview.Options.UseFont = True
        Me.GridViewAddContact.AppearancePrint.Row.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridViewAddContact.AppearancePrint.Row.Options.UseFont = True
        Me.GridViewAddContact.GridControl = Me.GridControlAddContact
        Me.GridViewAddContact.Name = "GridViewAddContact"
        Me.GridViewAddContact.NewItemRowText = "Add New Contact"
        Me.GridViewAddContact.OptionsView.ShowGroupPanel = False
        '
        'SimpleButtonAdd
        '
        Me.SimpleButtonAdd.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonAdd.Appearance.Options.UseFont = True
        Me.SimpleButtonAdd.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonAdd.AppearanceDisabled.Options.UseFont = True
        Me.SimpleButtonAdd.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonAdd.AppearanceHovered.Options.UseFont = True
        Me.SimpleButtonAdd.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonAdd.AppearancePressed.Options.UseFont = True
        Me.SimpleButtonAdd.Location = New System.Drawing.Point(386, 12)
        Me.SimpleButtonAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButtonAdd.Name = "SimpleButtonAdd"
        Me.SimpleButtonAdd.Size = New System.Drawing.Size(75, 28)
        Me.SimpleButtonAdd.TabIndex = 15
        Me.SimpleButtonAdd.Text = "&Add"
        '
        'TextEditContactDetail
        '
        Me.TextEditContactDetail.CausesValidation = False
        Me.TextEditContactDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextEditContactDetail.Location = New System.Drawing.Point(8, 28)
        Me.TextEditContactDetail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEditContactDetail.Name = "TextEditContactDetail"
        Me.TextEditContactDetail.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.TextEditContactDetail.Properties.Appearance.Options.UseFont = True
        Me.TextEditContactDetail.Size = New System.Drawing.Size(218, 22)
        Me.TextEditContactDetail.TabIndex = 13
        '
        'SimpleButtonSave
        '
        Me.SimpleButtonSave.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonSave.Appearance.Options.UseFont = True
        Me.SimpleButtonSave.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonSave.AppearanceDisabled.Options.UseFont = True
        Me.SimpleButtonSave.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonSave.AppearanceHovered.Options.UseFont = True
        Me.SimpleButtonSave.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonSave.AppearancePressed.Options.UseFont = True
        Me.SimpleButtonSave.Location = New System.Drawing.Point(388, 121)
        Me.SimpleButtonSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButtonSave.Name = "SimpleButtonSave"
        Me.SimpleButtonSave.Size = New System.Drawing.Size(75, 28)
        Me.SimpleButtonSave.TabIndex = 18
        Me.SimpleButtonSave.Text = "&Save"
        '
        'LabelContactDetail
        '
        Me.LabelContactDetail.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContactDetail.Appearance.Options.UseFont = True
        Me.LabelContactDetail.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.LabelContactDetail.AppearanceDisabled.Options.UseFont = True
        Me.LabelContactDetail.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.LabelContactDetail.AppearanceHovered.Options.UseFont = True
        Me.LabelContactDetail.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.LabelContactDetail.AppearancePressed.Options.UseFont = True
        Me.LabelContactDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelContactDetail.Location = New System.Drawing.Point(11, 9)
        Me.LabelContactDetail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelContactDetail.Name = "LabelContactDetail"
        Me.LabelContactDetail.Size = New System.Drawing.Size(75, 16)
        Me.LabelContactDetail.TabIndex = 6
        Me.LabelContactDetail.Text = "Contact Detail"
        '
        'SimpleButtonBackContactInfo
        '
        Me.SimpleButtonBackContactInfo.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonBackContactInfo.Appearance.Options.UseFont = True
        Me.SimpleButtonBackContactInfo.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonBackContactInfo.AppearanceDisabled.Options.UseFont = True
        Me.SimpleButtonBackContactInfo.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonBackContactInfo.AppearanceHovered.Options.UseFont = True
        Me.SimpleButtonBackContactInfo.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButtonBackContactInfo.AppearancePressed.Options.UseFont = True
        Me.SimpleButtonBackContactInfo.Location = New System.Drawing.Point(388, 86)
        Me.SimpleButtonBackContactInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButtonBackContactInfo.Name = "SimpleButtonBackContactInfo"
        Me.SimpleButtonBackContactInfo.Size = New System.Drawing.Size(75, 28)
        Me.SimpleButtonBackContactInfo.TabIndex = 17
        Me.SimpleButtonBackContactInfo.Text = "Ba&ck"
        '
        'ComboBoxEditContactType
        '
        Me.ComboBoxEditContactType.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboBoxEditContactType.Location = New System.Drawing.Point(232, 28)
        Me.ComboBoxEditContactType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEditContactType.Name = "ComboBoxEditContactType"
        Me.ComboBoxEditContactType.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.ComboBoxEditContactType.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEditContactType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEditContactType.Properties.Items.AddRange(New Object() {"Mobile", "Office", "Home", "Email"})
        Me.ComboBoxEditContactType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEditContactType.Size = New System.Drawing.Size(148, 22)
        Me.ComboBoxEditContactType.TabIndex = 14
        '
        'LabelContactType
        '
        Me.LabelContactType.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContactType.Appearance.Options.UseFont = True
        Me.LabelContactType.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.LabelContactType.AppearanceDisabled.Options.UseFont = True
        Me.LabelContactType.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.LabelContactType.AppearanceHovered.Options.UseFont = True
        Me.LabelContactType.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.LabelContactType.AppearancePressed.Options.UseFont = True
        Me.LabelContactType.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelContactType.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelContactType.Location = New System.Drawing.Point(235, 10)
        Me.LabelContactType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelContactType.Name = "LabelContactType"
        Me.LabelContactType.Size = New System.Drawing.Size(68, 16)
        Me.LabelContactType.TabIndex = 11
        Me.LabelContactType.Text = "Contact Type"
        '
        'SimpleButtonAddressNext
        '
        Me.SimpleButtonAddressNext.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButtonAddressNext.Appearance.Options.UseFont = True
        Me.SimpleButtonAddressNext.Location = New System.Drawing.Point(352, 119)
        Me.SimpleButtonAddressNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButtonAddressNext.Name = "SimpleButtonAddressNext"
        Me.SimpleButtonAddressNext.Size = New System.Drawing.Size(75, 28)
        Me.SimpleButtonAddressNext.TabIndex = 11
        Me.SimpleButtonAddressNext.Text = "&Next"
        '
        'xTabAddPatientRecords
        '
        Me.xTabAddPatientRecords.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabAddPatientRecords.Appearance.Options.UseFont = True
        Me.xTabAddPatientRecords.Location = New System.Drawing.Point(2, 27)
        Me.xTabAddPatientRecords.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.xTabAddPatientRecords.Name = "xTabAddPatientRecords"
        Me.xTabAddPatientRecords.SelectedTabPage = Me.xTabPagePersonalInfo
        Me.xTabAddPatientRecords.Size = New System.Drawing.Size(476, 185)
        Me.xTabAddPatientRecords.TabIndex = 24
        Me.xTabAddPatientRecords.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xTabPagePersonalInfo, Me.xTabPageAddress, Me.xTabPageContactInfo})
        '
        'xTabPagePersonalInfo
        '
        Me.xTabPagePersonalInfo.Appearance.Header.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabPagePersonalInfo.Appearance.Header.Options.UseFont = True
        Me.xTabPagePersonalInfo.Appearance.HeaderActive.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabPagePersonalInfo.Appearance.HeaderActive.Options.UseFont = True
        Me.xTabPagePersonalInfo.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabPagePersonalInfo.Appearance.HeaderDisabled.Options.UseFont = True
        Me.xTabPagePersonalInfo.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabPagePersonalInfo.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.xTabPagePersonalInfo.Appearance.PageClient.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabPagePersonalInfo.Appearance.PageClient.Options.UseFont = True
        Me.xTabPagePersonalInfo.Controls.Add(Me.ToggleSwitchNationalIdPassportNumber)
        Me.xTabPagePersonalInfo.Controls.Add(Me.TextEditDateOfBirth)
        Me.xTabPagePersonalInfo.Controls.Add(Me.LabelHospitalNumber)
        Me.xTabPagePersonalInfo.Controls.Add(Me.TextEditHospitalNumber)
        Me.xTabPagePersonalInfo.Controls.Add(Me.SimpleButtonPersonalInfoNext)
        Me.xTabPagePersonalInfo.Controls.Add(Me.LabelNid)
        Me.xTabPagePersonalInfo.Controls.Add(Me.TextEditNid)
        Me.xTabPagePersonalInfo.Controls.Add(Me.LabelPatientName)
        Me.xTabPagePersonalInfo.Controls.Add(Me.ComboBoxEditGender)
        Me.xTabPagePersonalInfo.Controls.Add(Me.TextEditPatientName)
        Me.xTabPagePersonalInfo.Controls.Add(Me.LabelDob)
        Me.xTabPagePersonalInfo.Controls.Add(Me.LabelGender)
        Me.xTabPagePersonalInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.xTabPagePersonalInfo.Name = "xTabPagePersonalInfo"
        Me.xTabPagePersonalInfo.Size = New System.Drawing.Size(470, 154)
        Me.xTabPagePersonalInfo.Text = "PERSONAL INFO"
        '
        'ToggleSwitchNationalIdPassportNumber
        '
        Me.ToggleSwitchNationalIdPassportNumber.Location = New System.Drawing.Point(14, 108)
        Me.ToggleSwitchNationalIdPassportNumber.Name = "ToggleSwitchNationalIdPassportNumber"
        Me.ToggleSwitchNationalIdPassportNumber.Properties.OffText = "National ID Card Number"
        Me.ToggleSwitchNationalIdPassportNumber.Properties.OnText = "Passport Number"
        Me.ToggleSwitchNationalIdPassportNumber.Size = New System.Drawing.Size(228, 24)
        Me.ToggleSwitchNationalIdPassportNumber.TabIndex = 27
        '
        'TextEditDateOfBirth
        '
        Me.TextEditDateOfBirth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEditDateOfBirth.EditValue = ""
        Me.TextEditDateOfBirth.Location = New System.Drawing.Point(191, 79)
        Me.TextEditDateOfBirth.Name = "TextEditDateOfBirth"
        Me.TextEditDateOfBirth.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEditDateOfBirth.Properties.Appearance.Options.UseFont = True
        Me.TextEditDateOfBirth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TextEditDateOfBirth.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TextEditDateOfBirth.Properties.DisplayFormat.FormatString = ""
        Me.TextEditDateOfBirth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TextEditDateOfBirth.Properties.EditFormat.FormatString = ""
        Me.TextEditDateOfBirth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TextEditDateOfBirth.Properties.Mask.BeepOnError = True
        Me.TextEditDateOfBirth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TextEditDateOfBirth.Size = New System.Drawing.Size(138, 22)
        Me.TextEditDateOfBirth.TabIndex = 4
        '
        'LabelHospitalNumber
        '
        Me.LabelHospitalNumber.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHospitalNumber.Appearance.Options.UseFont = True
        Me.LabelHospitalNumber.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelHospitalNumber.AppearanceDisabled.Options.UseFont = True
        Me.LabelHospitalNumber.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelHospitalNumber.AppearanceHovered.Options.UseFont = True
        Me.LabelHospitalNumber.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelHospitalNumber.AppearancePressed.Options.UseFont = True
        Me.LabelHospitalNumber.Location = New System.Drawing.Point(17, 14)
        Me.LabelHospitalNumber.Name = "LabelHospitalNumber"
        Me.LabelHospitalNumber.Size = New System.Drawing.Size(84, 16)
        Me.LabelHospitalNumber.TabIndex = 26
        Me.LabelHospitalNumber.Text = "Hospital Number"
        '
        'TextEditHospitalNumber
        '
        Me.TextEditHospitalNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEditHospitalNumber.CausesValidation = False
        Me.TextEditHospitalNumber.EditValue = ""
        Me.TextEditHospitalNumber.Location = New System.Drawing.Point(14, 32)
        Me.TextEditHospitalNumber.Name = "TextEditHospitalNumber"
        Me.TextEditHospitalNumber.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEditHospitalNumber.Properties.Appearance.Options.UseFont = True
        Me.TextEditHospitalNumber.Size = New System.Drawing.Size(157, 22)
        Me.TextEditHospitalNumber.TabIndex = 1
        '
        'SimpleButtonPersonalInfoNext
        '
        Me.SimpleButtonPersonalInfoNext.Location = New System.Drawing.Point(380, 116)
        Me.SimpleButtonPersonalInfoNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButtonPersonalInfoNext.Name = "SimpleButtonPersonalInfoNext"
        Me.SimpleButtonPersonalInfoNext.Size = New System.Drawing.Size(75, 28)
        Me.SimpleButtonPersonalInfoNext.TabIndex = 6
        Me.SimpleButtonPersonalInfoNext.Text = "&Next"
        '
        'LabelNid
        '
        Me.LabelNid.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNid.Appearance.Options.UseFont = True
        Me.LabelNid.Location = New System.Drawing.Point(17, 61)
        Me.LabelNid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelNid.Name = "LabelNid"
        Me.LabelNid.Size = New System.Drawing.Size(126, 16)
        Me.LabelNid.TabIndex = 11
        Me.LabelNid.Text = "National ID Card Number"
        '
        'TextEditNid
        '
        Me.TextEditNid.CausesValidation = False
        Me.TextEditNid.EditValue = ""
        Me.TextEditNid.EnterMoveNextControl = True
        Me.TextEditNid.Location = New System.Drawing.Point(14, 79)
        Me.TextEditNid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEditNid.Name = "TextEditNid"
        Me.TextEditNid.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.TextEditNid.Properties.Appearance.Options.UseFont = True
        Me.TextEditNid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEditNid.Size = New System.Drawing.Size(157, 22)
        Me.TextEditNid.TabIndex = 3
        '
        'LabelPatientName
        '
        Me.LabelPatientName.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPatientName.Appearance.Options.UseFont = True
        Me.LabelPatientName.Location = New System.Drawing.Point(195, 14)
        Me.LabelPatientName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelPatientName.Name = "LabelPatientName"
        Me.LabelPatientName.Size = New System.Drawing.Size(69, 16)
        Me.LabelPatientName.TabIndex = 14
        Me.LabelPatientName.Text = "Patient Name"
        '
        'ComboBoxEditGender
        '
        Me.ComboBoxEditGender.EditValue = ""
        Me.ComboBoxEditGender.EnterMoveNextControl = True
        Me.ComboBoxEditGender.Location = New System.Drawing.Point(359, 79)
        Me.ComboBoxEditGender.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEditGender.Name = "ComboBoxEditGender"
        Me.ComboBoxEditGender.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.ComboBoxEditGender.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEditGender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEditGender.Properties.Items.AddRange(New Object() {"Male", "Female", "Other", "Unknown", " "})
        Me.ComboBoxEditGender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEditGender.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBoxEditGender.Size = New System.Drawing.Size(96, 22)
        Me.ComboBoxEditGender.TabIndex = 5
        '
        'TextEditPatientName
        '
        Me.TextEditPatientName.EditValue = ""
        Me.TextEditPatientName.EnterMoveNextControl = True
        Me.TextEditPatientName.Location = New System.Drawing.Point(191, 32)
        Me.TextEditPatientName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEditPatientName.Name = "TextEditPatientName"
        Me.TextEditPatientName.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.TextEditPatientName.Properties.Appearance.Options.UseFont = True
        Me.TextEditPatientName.Properties.Mask.BeepOnError = True
        Me.TextEditPatientName.Properties.Mask.EditMask = "[a-zA-Z -]+"
        Me.TextEditPatientName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.TextEditPatientName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEditPatientName.Size = New System.Drawing.Size(264, 22)
        Me.TextEditPatientName.TabIndex = 2
        '
        'LabelDob
        '
        Me.LabelDob.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDob.Appearance.Options.UseFont = True
        Me.LabelDob.Location = New System.Drawing.Point(195, 61)
        Me.LabelDob.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelDob.Name = "LabelDob"
        Me.LabelDob.Size = New System.Drawing.Size(68, 16)
        Me.LabelDob.TabIndex = 6
        Me.LabelDob.Text = "Date of Birth"
        '
        'LabelGender
        '
        Me.LabelGender.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGender.Appearance.Options.UseFont = True
        Me.LabelGender.Location = New System.Drawing.Point(359, 61)
        Me.LabelGender.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(36, 16)
        Me.LabelGender.TabIndex = 11
        Me.LabelGender.Text = "Gender"
        '
        'xTabPageAddress
        '
        Me.xTabPageAddress.Appearance.Header.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabPageAddress.Appearance.Header.Options.UseFont = True
        Me.xTabPageAddress.Appearance.HeaderActive.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabPageAddress.Appearance.HeaderActive.Options.UseFont = True
        Me.xTabPageAddress.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabPageAddress.Appearance.HeaderDisabled.Options.UseFont = True
        Me.xTabPageAddress.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabPageAddress.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.xTabPageAddress.Controls.Add(Me.SimpleButtonBack)
        Me.xTabPageAddress.Controls.Add(Me.SimpleButtonAddressNext)
        Me.xTabPageAddress.Controls.Add(Me.LabelAddress)
        Me.xTabPageAddress.Controls.Add(Me.LabelCountry)
        Me.xTabPageAddress.Controls.Add(Me.TextEditAddress)
        Me.xTabPageAddress.Controls.Add(Me.ComboBoxEditAtoll)
        Me.xTabPageAddress.Controls.Add(Me.LabelAtoll)
        Me.xTabPageAddress.Controls.Add(Me.ComboBoxIsland)
        Me.xTabPageAddress.Controls.Add(Me.LabelIsland)
        Me.xTabPageAddress.Controls.Add(Me.ComboBoxEditCountry)
        Me.xTabPageAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.xTabPageAddress.Name = "xTabPageAddress"
        Me.xTabPageAddress.Size = New System.Drawing.Size(470, 154)
        Me.xTabPageAddress.Text = "ADDRESS"
        '
        'LabelCountry
        '
        Me.LabelCountry.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCountry.Appearance.Options.UseFont = True
        Me.LabelCountry.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCountry.AppearanceDisabled.Options.UseFont = True
        Me.LabelCountry.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCountry.AppearanceHovered.Options.UseFont = True
        Me.LabelCountry.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCountry.AppearancePressed.Options.UseFont = True
        Me.LabelCountry.Location = New System.Drawing.Point(274, 56)
        Me.LabelCountry.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelCountry.Name = "LabelCountry"
        Me.LabelCountry.Size = New System.Drawing.Size(41, 16)
        Me.LabelCountry.TabIndex = 17
        Me.LabelCountry.Text = "Country"
        '
        'TextEditAddress
        '
        Me.TextEditAddress.EnterMoveNextControl = True
        Me.TextEditAddress.Location = New System.Drawing.Point(14, 33)
        Me.TextEditAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEditAddress.Name = "TextEditAddress"
        Me.TextEditAddress.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEditAddress.Properties.Appearance.Options.UseFont = True
        Me.TextEditAddress.Size = New System.Drawing.Size(414, 22)
        Me.TextEditAddress.TabIndex = 7
        '
        'ComboBoxEditAtoll
        '
        Me.ComboBoxEditAtoll.EnterMoveNextControl = True
        Me.ComboBoxEditAtoll.Location = New System.Drawing.Point(14, 74)
        Me.ComboBoxEditAtoll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEditAtoll.Name = "ComboBoxEditAtoll"
        Me.ComboBoxEditAtoll.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEditAtoll.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEditAtoll.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEditAtoll.Size = New System.Drawing.Size(65, 22)
        Me.ComboBoxEditAtoll.TabIndex = 8
        '
        'LabelAtoll
        '
        Me.LabelAtoll.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAtoll.Appearance.Options.UseFont = True
        Me.LabelAtoll.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAtoll.AppearanceDisabled.Options.UseFont = True
        Me.LabelAtoll.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAtoll.AppearanceHovered.Options.UseFont = True
        Me.LabelAtoll.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAtoll.AppearancePressed.Options.UseFont = True
        Me.LabelAtoll.Location = New System.Drawing.Point(17, 56)
        Me.LabelAtoll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelAtoll.Name = "LabelAtoll"
        Me.LabelAtoll.Size = New System.Drawing.Size(27, 16)
        Me.LabelAtoll.TabIndex = 14
        Me.LabelAtoll.Text = "Atoll"
        '
        'ComboBoxIsland
        '
        Me.ComboBoxIsland.EnterMoveNextControl = True
        Me.ComboBoxIsland.Location = New System.Drawing.Point(83, 74)
        Me.ComboBoxIsland.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxIsland.Name = "ComboBoxIsland"
        Me.ComboBoxIsland.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxIsland.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxIsland.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxIsland.Size = New System.Drawing.Size(183, 22)
        Me.ComboBoxIsland.TabIndex = 9
        '
        'LabelIsland
        '
        Me.LabelIsland.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIsland.Appearance.Options.UseFont = True
        Me.LabelIsland.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIsland.AppearanceDisabled.Options.UseFont = True
        Me.LabelIsland.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIsland.AppearanceHovered.Options.UseFont = True
        Me.LabelIsland.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIsland.AppearancePressed.Options.UseFont = True
        Me.LabelIsland.Location = New System.Drawing.Point(85, 56)
        Me.LabelIsland.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelIsland.Name = "LabelIsland"
        Me.LabelIsland.Size = New System.Drawing.Size(30, 16)
        Me.LabelIsland.TabIndex = 11
        Me.LabelIsland.Text = "Island"
        '
        'ComboBoxEditCountry
        '
        Me.ComboBoxEditCountry.EditValue = ""
        Me.ComboBoxEditCountry.EnterMoveNextControl = True
        Me.ComboBoxEditCountry.Location = New System.Drawing.Point(272, 74)
        Me.ComboBoxEditCountry.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEditCountry.Name = "ComboBoxEditCountry"
        Me.ComboBoxEditCountry.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEditCountry.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEditCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEditCountry.Properties.Items.AddRange(New Object() {"Maldives"})
        Me.ComboBoxEditCountry.Size = New System.Drawing.Size(156, 22)
        Me.ComboBoxEditCountry.TabIndex = 10
        '
        'GroupPatientDetails
        '
        Me.GroupPatientDetails.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPatientDetails.Appearance.Options.UseFont = True
        Me.GroupPatientDetails.AppearanceCaption.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPatientDetails.AppearanceCaption.Options.UseFont = True
        Me.GroupPatientDetails.Controls.Add(Me.LabelClose)
        Me.GroupPatientDetails.Controls.Add(Me.GroupControlSummary)
        Me.GroupPatientDetails.Controls.Add(Me.xTabAddPatientRecords)
        Me.GroupPatientDetails.Location = New System.Drawing.Point(1, 1)
        Me.GroupPatientDetails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupPatientDetails.Name = "GroupPatientDetails"
        Me.GroupPatientDetails.Size = New System.Drawing.Size(478, 284)
        Me.GroupPatientDetails.TabIndex = 32
        Me.GroupPatientDetails.Text = "frmLabelAddEditPatient"
        '
        'LabelClose
        '
        Me.LabelClose.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClose.Appearance.Options.UseFont = True
        Me.LabelClose.Location = New System.Drawing.Point(459, 3)
        Me.LabelClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelClose.Name = "LabelClose"
        Me.LabelClose.Size = New System.Drawing.Size(14, 16)
        Me.LabelClose.TabIndex = 23
        Me.LabelClose.Text = " X "
        '
        'GroupControlSummary
        '
        Me.GroupControlSummary.AppearanceCaption.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControlSummary.AppearanceCaption.Options.UseFont = True
        Me.GroupControlSummary.Controls.Add(Me.LabelSummary)
        Me.GroupControlSummary.Location = New System.Drawing.Point(3, 214)
        Me.GroupControlSummary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControlSummary.Name = "GroupControlSummary"
        Me.GroupControlSummary.Size = New System.Drawing.Size(470, 69)
        Me.GroupControlSummary.TabIndex = 33
        Me.GroupControlSummary.Text = "Summary"
        '
        'LabelSummary
        '
        Me.LabelSummary.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSummary.Appearance.Options.UseFont = True
        Me.LabelSummary.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelSummary.Location = New System.Drawing.Point(14, 27)
        Me.LabelSummary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelSummary.Name = "LabelSummary"
        Me.LabelSummary.Size = New System.Drawing.Size(420, 16)
        Me.LabelSummary.TabIndex = 34
        Me.LabelSummary.Text = "# HospitalNumber:PatientName"
        '
        'FormAddPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 287)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPatientDetails)
        Me.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAddPatient"
        Me.Text = " New Patient"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.xTabPageContactInfo.ResumeLayout(False)
        Me.xTabPageContactInfo.PerformLayout()
        CType(Me.GridControlAddContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAddContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditContactDetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEditContactType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xTabAddPatientRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xTabAddPatientRecords.ResumeLayout(False)
        Me.xTabPagePersonalInfo.ResumeLayout(False)
        Me.xTabPagePersonalInfo.PerformLayout()
        CType(Me.ToggleSwitchNationalIdPassportNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditDateOfBirth.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditDateOfBirth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditHospitalNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditNid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEditGender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditPatientName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xTabPageAddress.ResumeLayout(False)
        Me.xTabPageAddress.PerformLayout()
        CType(Me.TextEditAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEditAtoll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxIsland.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEditCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupPatientDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPatientDetails.ResumeLayout(False)
        Me.GroupPatientDetails.PerformLayout()
        CType(Me.GroupControlSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControlSummary.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SimpleButtonBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents xTabPageContactInfo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SimpleButtonRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControlAddContact As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAddContact As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButtonAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEditContactDetail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButtonSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelContactDetail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButtonBackContactInfo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboBoxEditContactType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelContactType As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButtonAddressNext As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents xTabAddPatientRecords As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xTabPagePersonalInfo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelNid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEditNid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelPatientName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEditGender As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TextEditPatientName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelDob As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelGender As DevExpress.XtraEditors.LabelControl
    Friend WithEvents xTabPageAddress As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelCountry As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEditAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComboBoxEditAtoll As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelAtoll As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxIsland As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelIsland As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEditCountry As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupPatientDetails As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControlSummary As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelSummary As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelClose As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButtonPersonalInfoNext As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelHospitalNumber As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEditHospitalNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEditDateOfBirth As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ToggleSwitchNationalIdPassportNumber As DevExpress.XtraEditors.ToggleSwitch
End Class
