<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPatient
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
        Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
        Me.lblAddress = New DevExpress.XtraEditors.LabelControl()
        Me.xTabPageContactInfo = New DevExpress.XtraTab.XtraTabPage()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControlAddContact = New DevExpress.XtraGrid.GridControl()
        Me.GridViewAddContact = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.txtContactDetail = New DevExpress.XtraEditors.TextEdit()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.lblContactDetail = New DevExpress.XtraEditors.LabelControl()
        Me.lblBackContactInfo = New DevExpress.XtraEditors.SimpleButton()
        Me.cboContactType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblContactType = New DevExpress.XtraEditors.LabelControl()
        Me.btnAddressNext = New DevExpress.XtraEditors.SimpleButton()
        Me.xTabAddPatientRecords = New DevExpress.XtraTab.XtraTabControl()
        Me.xTabPagePersonalInfo = New DevExpress.XtraTab.XtraTabPage()
        Me.txtEditDateOfBirth = New DevExpress.XtraEditors.DateEdit()
        Me.lblHospitalNumber = New DevExpress.XtraEditors.LabelControl()
        Me.txtEditHospitalNumber = New DevExpress.XtraEditors.TextEdit()
        Me.btnPersonalInfoNext = New DevExpress.XtraEditors.SimpleButton()
        Me.lblNid = New DevExpress.XtraEditors.LabelControl()
        Me.txtNid = New DevExpress.XtraEditors.TextEdit()
        Me.lblPatientName = New DevExpress.XtraEditors.LabelControl()
        Me.cboGender = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtPatientName = New DevExpress.XtraEditors.TextEdit()
        Me.lblDob = New DevExpress.XtraEditors.LabelControl()
        Me.lblGender = New DevExpress.XtraEditors.LabelControl()
        Me.xTabPageAddress = New DevExpress.XtraTab.XtraTabPage()
        Me.lblCountry = New DevExpress.XtraEditors.LabelControl()
        Me.txtAddress = New DevExpress.XtraEditors.TextEdit()
        Me.cboAtoll = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblAtoll = New DevExpress.XtraEditors.LabelControl()
        Me.cboIsland = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblIsland = New DevExpress.XtraEditors.LabelControl()
        Me.cboCountry = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GrpPatientDetails = New DevExpress.XtraEditors.GroupControl()
        Me.lblClose = New DevExpress.XtraEditors.LabelControl()
        Me.GrpControlSummary = New DevExpress.XtraEditors.GroupControl()
        Me.lblSummary = New DevExpress.XtraEditors.LabelControl()
        Me.xTabPageContactInfo.SuspendLayout()
        CType(Me.GridControlAddContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAddContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactDetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboContactType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xTabAddPatientRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xTabAddPatientRecords.SuspendLayout()
        Me.xTabPagePersonalInfo.SuspendLayout()
        CType(Me.txtEditDateOfBirth.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditDateOfBirth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditHospitalNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPatientName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xTabPageAddress.SuspendLayout()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAtoll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIsland.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpPatientDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPatientDetails.SuspendLayout()
        CType(Me.GrpControlSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpControlSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Appearance.Options.UseFont = True
        Me.btnBack.Location = New System.Drawing.Point(272, 119)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 28)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Ba&ck"
        '
        'lblAddress
        '
        Me.lblAddress.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Appearance.Options.UseFont = True
        Me.lblAddress.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.AppearanceDisabled.Options.UseFont = True
        Me.lblAddress.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.AppearanceHovered.Options.UseFont = True
        Me.lblAddress.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.AppearancePressed.Options.UseFont = True
        Me.lblAddress.Location = New System.Drawing.Point(16, 15)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(41, 16)
        Me.lblAddress.TabIndex = 6
        Me.lblAddress.Text = "Address"
        '
        'xTabPageContactInfo
        '
        Me.xTabPageContactInfo.Controls.Add(Me.btnRemove)
        Me.xTabPageContactInfo.Controls.Add(Me.GridControlAddContact)
        Me.xTabPageContactInfo.Controls.Add(Me.btnAdd)
        Me.xTabPageContactInfo.Controls.Add(Me.txtContactDetail)
        Me.xTabPageContactInfo.Controls.Add(Me.btnSave)
        Me.xTabPageContactInfo.Controls.Add(Me.lblContactDetail)
        Me.xTabPageContactInfo.Controls.Add(Me.lblBackContactInfo)
        Me.xTabPageContactInfo.Controls.Add(Me.cboContactType)
        Me.xTabPageContactInfo.Controls.Add(Me.lblContactType)
        Me.xTabPageContactInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.xTabPageContactInfo.Name = "xTabPageContactInfo"
        Me.xTabPageContactInfo.Size = New System.Drawing.Size(470, 154)
        Me.xTabPageContactInfo.Text = "CONTACT INFO"
        '
        'btnRemove
        '
        Me.btnRemove.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.btnRemove.Appearance.Options.UseFont = True
        Me.btnRemove.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.btnRemove.AppearanceDisabled.Options.UseFont = True
        Me.btnRemove.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.btnRemove.AppearanceHovered.Options.UseFont = True
        Me.btnRemove.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.btnRemove.AppearancePressed.Options.UseFont = True
        Me.btnRemove.Location = New System.Drawing.Point(386, 46)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 28)
        Me.btnRemove.TabIndex = 16
        Me.btnRemove.Text = "&Remove"
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
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.btnAdd.AppearanceDisabled.Options.UseFont = True
        Me.btnAdd.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.btnAdd.AppearanceHovered.Options.UseFont = True
        Me.btnAdd.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.btnAdd.AppearancePressed.Options.UseFont = True
        Me.btnAdd.Location = New System.Drawing.Point(386, 12)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "&Add"
        '
        'txtContactDetail
        '
        Me.txtContactDetail.CausesValidation = False
        Me.txtContactDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtContactDetail.Location = New System.Drawing.Point(8, 28)
        Me.txtContactDetail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtContactDetail.Name = "txtContactDetail"
        Me.txtContactDetail.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.txtContactDetail.Properties.Appearance.Options.UseFont = True
        Me.txtContactDetail.Size = New System.Drawing.Size(218, 22)
        Me.txtContactDetail.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.btnSave.AppearanceDisabled.Options.UseFont = True
        Me.btnSave.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.btnSave.AppearanceHovered.Options.UseFont = True
        Me.btnSave.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.btnSave.AppearancePressed.Options.UseFont = True
        Me.btnSave.Location = New System.Drawing.Point(388, 121)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 28)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "&Save"
        '
        'lblContactDetail
        '
        Me.lblContactDetail.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactDetail.Appearance.Options.UseFont = True
        Me.lblContactDetail.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.lblContactDetail.AppearanceDisabled.Options.UseFont = True
        Me.lblContactDetail.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.lblContactDetail.AppearanceHovered.Options.UseFont = True
        Me.lblContactDetail.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.lblContactDetail.AppearancePressed.Options.UseFont = True
        Me.lblContactDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblContactDetail.Location = New System.Drawing.Point(11, 9)
        Me.lblContactDetail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblContactDetail.Name = "lblContactDetail"
        Me.lblContactDetail.Size = New System.Drawing.Size(75, 16)
        Me.lblContactDetail.TabIndex = 6
        Me.lblContactDetail.Text = "Contact Detail"
        '
        'lblBackContactInfo
        '
        Me.lblBackContactInfo.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.lblBackContactInfo.Appearance.Options.UseFont = True
        Me.lblBackContactInfo.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.lblBackContactInfo.AppearanceDisabled.Options.UseFont = True
        Me.lblBackContactInfo.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.lblBackContactInfo.AppearanceHovered.Options.UseFont = True
        Me.lblBackContactInfo.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.lblBackContactInfo.AppearancePressed.Options.UseFont = True
        Me.lblBackContactInfo.Location = New System.Drawing.Point(388, 86)
        Me.lblBackContactInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblBackContactInfo.Name = "lblBackContactInfo"
        Me.lblBackContactInfo.Size = New System.Drawing.Size(75, 28)
        Me.lblBackContactInfo.TabIndex = 17
        Me.lblBackContactInfo.Text = "Ba&ck"
        '
        'cboContactType
        '
        Me.cboContactType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboContactType.Location = New System.Drawing.Point(232, 28)
        Me.cboContactType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboContactType.Name = "cboContactType"
        Me.cboContactType.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.cboContactType.Properties.Appearance.Options.UseFont = True
        Me.cboContactType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboContactType.Properties.Items.AddRange(New Object() {"Mobile", "Office", "Home", "Email"})
        Me.cboContactType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboContactType.Size = New System.Drawing.Size(148, 22)
        Me.cboContactType.TabIndex = 14
        '
        'lblContactType
        '
        Me.lblContactType.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactType.Appearance.Options.UseFont = True
        Me.lblContactType.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.lblContactType.AppearanceDisabled.Options.UseFont = True
        Me.lblContactType.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.lblContactType.AppearanceHovered.Options.UseFont = True
        Me.lblContactType.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.lblContactType.AppearancePressed.Options.UseFont = True
        Me.lblContactType.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblContactType.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblContactType.Location = New System.Drawing.Point(235, 10)
        Me.lblContactType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblContactType.Name = "lblContactType"
        Me.lblContactType.Size = New System.Drawing.Size(68, 16)
        Me.lblContactType.TabIndex = 11
        Me.lblContactType.Text = "Contact Type"
        '
        'btnAddressNext
        '
        Me.btnAddressNext.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddressNext.Appearance.Options.UseFont = True
        Me.btnAddressNext.Location = New System.Drawing.Point(352, 119)
        Me.btnAddressNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddressNext.Name = "btnAddressNext"
        Me.btnAddressNext.Size = New System.Drawing.Size(75, 28)
        Me.btnAddressNext.TabIndex = 11
        Me.btnAddressNext.Text = "&Next"
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
        Me.xTabPagePersonalInfo.Controls.Add(Me.txtEditDateOfBirth)
        Me.xTabPagePersonalInfo.Controls.Add(Me.lblHospitalNumber)
        Me.xTabPagePersonalInfo.Controls.Add(Me.txtEditHospitalNumber)
        Me.xTabPagePersonalInfo.Controls.Add(Me.btnPersonalInfoNext)
        Me.xTabPagePersonalInfo.Controls.Add(Me.lblNid)
        Me.xTabPagePersonalInfo.Controls.Add(Me.txtNid)
        Me.xTabPagePersonalInfo.Controls.Add(Me.lblPatientName)
        Me.xTabPagePersonalInfo.Controls.Add(Me.cboGender)
        Me.xTabPagePersonalInfo.Controls.Add(Me.txtPatientName)
        Me.xTabPagePersonalInfo.Controls.Add(Me.lblDob)
        Me.xTabPagePersonalInfo.Controls.Add(Me.lblGender)
        Me.xTabPagePersonalInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.xTabPagePersonalInfo.Name = "xTabPagePersonalInfo"
        Me.xTabPagePersonalInfo.Size = New System.Drawing.Size(470, 154)
        Me.xTabPagePersonalInfo.Text = "PERSONAL INFO"
        '
        'txtEditDateOfBirth
        '
        Me.txtEditDateOfBirth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEditDateOfBirth.EditValue = ""
        Me.txtEditDateOfBirth.Location = New System.Drawing.Point(191, 79)
        Me.txtEditDateOfBirth.Name = "txtEditDateOfBirth"
        Me.txtEditDateOfBirth.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditDateOfBirth.Properties.Appearance.Options.UseFont = True
        Me.txtEditDateOfBirth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEditDateOfBirth.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEditDateOfBirth.Properties.DisplayFormat.FormatString = ""
        Me.txtEditDateOfBirth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtEditDateOfBirth.Properties.EditFormat.FormatString = ""
        Me.txtEditDateOfBirth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtEditDateOfBirth.Properties.Mask.BeepOnError = True
        Me.txtEditDateOfBirth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtEditDateOfBirth.Size = New System.Drawing.Size(138, 22)
        Me.txtEditDateOfBirth.TabIndex = 4
        '
        'lblHospitalNumber
        '
        Me.lblHospitalNumber.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHospitalNumber.Appearance.Options.UseFont = True
        Me.lblHospitalNumber.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblHospitalNumber.AppearanceDisabled.Options.UseFont = True
        Me.lblHospitalNumber.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblHospitalNumber.AppearanceHovered.Options.UseFont = True
        Me.lblHospitalNumber.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblHospitalNumber.AppearancePressed.Options.UseFont = True
        Me.lblHospitalNumber.Location = New System.Drawing.Point(17, 14)
        Me.lblHospitalNumber.Name = "lblHospitalNumber"
        Me.lblHospitalNumber.Size = New System.Drawing.Size(84, 16)
        Me.lblHospitalNumber.TabIndex = 26
        Me.lblHospitalNumber.Text = "Hospital Number"
        '
        'txtEditHospitalNumber
        '
        Me.txtEditHospitalNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEditHospitalNumber.CausesValidation = False
        Me.txtEditHospitalNumber.EditValue = ""
        Me.txtEditHospitalNumber.Location = New System.Drawing.Point(14, 32)
        Me.txtEditHospitalNumber.Name = "txtEditHospitalNumber"
        Me.txtEditHospitalNumber.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditHospitalNumber.Properties.Appearance.Options.UseFont = True
        Me.txtEditHospitalNumber.Size = New System.Drawing.Size(157, 22)
        Me.txtEditHospitalNumber.TabIndex = 1
        '
        'btnPersonalInfoNext
        '
        Me.btnPersonalInfoNext.Location = New System.Drawing.Point(380, 116)
        Me.btnPersonalInfoNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPersonalInfoNext.Name = "btnPersonalInfoNext"
        Me.btnPersonalInfoNext.Size = New System.Drawing.Size(75, 28)
        Me.btnPersonalInfoNext.TabIndex = 6
        Me.btnPersonalInfoNext.Text = "&Next"
        '
        'lblNid
        '
        Me.lblNid.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNid.Appearance.Options.UseFont = True
        Me.lblNid.Location = New System.Drawing.Point(17, 61)
        Me.lblNid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblNid.Name = "lblNid"
        Me.lblNid.Size = New System.Drawing.Size(126, 16)
        Me.lblNid.TabIndex = 11
        Me.lblNid.Text = "National ID Card Number"
        '
        'txtNid
        '
        Me.txtNid.CausesValidation = False
        Me.txtNid.EditValue = ""
        Me.txtNid.EnterMoveNextControl = True
        Me.txtNid.Location = New System.Drawing.Point(14, 79)
        Me.txtNid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNid.Name = "txtNid"
        Me.txtNid.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.txtNid.Properties.Appearance.Options.UseFont = True
        Me.txtNid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNid.Size = New System.Drawing.Size(157, 22)
        Me.txtNid.TabIndex = 3
        '
        'lblPatientName
        '
        Me.lblPatientName.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.Appearance.Options.UseFont = True
        Me.lblPatientName.Location = New System.Drawing.Point(195, 14)
        Me.lblPatientName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(69, 16)
        Me.lblPatientName.TabIndex = 14
        Me.lblPatientName.Text = "Patient Name"
        '
        'cboGender
        '
        Me.cboGender.EditValue = ""
        Me.cboGender.EnterMoveNextControl = True
        Me.cboGender.Location = New System.Drawing.Point(359, 79)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.cboGender.Properties.Appearance.Options.UseFont = True
        Me.cboGender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGender.Properties.Items.AddRange(New Object() {"Male", "Female", "Other", "Unknown", " "})
        Me.cboGender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboGender.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboGender.Size = New System.Drawing.Size(96, 22)
        Me.cboGender.TabIndex = 5
        '
        'txtPatientName
        '
        Me.txtPatientName.EditValue = ""
        Me.txtPatientName.EnterMoveNextControl = True
        Me.txtPatientName.Location = New System.Drawing.Point(191, 32)
        Me.txtPatientName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.txtPatientName.Properties.Appearance.Options.UseFont = True
        Me.txtPatientName.Properties.Mask.BeepOnError = True
        Me.txtPatientName.Properties.Mask.EditMask = "[a-zA-Z -]+"
        Me.txtPatientName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtPatientName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPatientName.Size = New System.Drawing.Size(264, 22)
        Me.txtPatientName.TabIndex = 2
        '
        'lblDob
        '
        Me.lblDob.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDob.Appearance.Options.UseFont = True
        Me.lblDob.Location = New System.Drawing.Point(195, 61)
        Me.lblDob.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(68, 16)
        Me.lblDob.TabIndex = 6
        Me.lblDob.Text = "Date of Birth"
        '
        'lblGender
        '
        Me.lblGender.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Appearance.Options.UseFont = True
        Me.lblGender.Location = New System.Drawing.Point(359, 61)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(36, 16)
        Me.lblGender.TabIndex = 11
        Me.lblGender.Text = "Gender"
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
        Me.xTabPageAddress.Controls.Add(Me.btnBack)
        Me.xTabPageAddress.Controls.Add(Me.btnAddressNext)
        Me.xTabPageAddress.Controls.Add(Me.lblAddress)
        Me.xTabPageAddress.Controls.Add(Me.lblCountry)
        Me.xTabPageAddress.Controls.Add(Me.txtAddress)
        Me.xTabPageAddress.Controls.Add(Me.cboAtoll)
        Me.xTabPageAddress.Controls.Add(Me.lblAtoll)
        Me.xTabPageAddress.Controls.Add(Me.cboIsland)
        Me.xTabPageAddress.Controls.Add(Me.lblIsland)
        Me.xTabPageAddress.Controls.Add(Me.cboCountry)
        Me.xTabPageAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.xTabPageAddress.Name = "xTabPageAddress"
        Me.xTabPageAddress.Size = New System.Drawing.Size(470, 154)
        Me.xTabPageAddress.Text = "ADDRESS"
        '
        'lblCountry
        '
        Me.lblCountry.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Appearance.Options.UseFont = True
        Me.lblCountry.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.AppearanceDisabled.Options.UseFont = True
        Me.lblCountry.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.AppearanceHovered.Options.UseFont = True
        Me.lblCountry.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.AppearancePressed.Options.UseFont = True
        Me.lblCountry.Location = New System.Drawing.Point(274, 56)
        Me.lblCountry.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(41, 16)
        Me.lblCountry.TabIndex = 17
        Me.lblCountry.Text = "Country"
        '
        'txtAddress
        '
        Me.txtAddress.EnterMoveNextControl = True
        Me.txtAddress.Location = New System.Drawing.Point(14, 33)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Properties.Appearance.Options.UseFont = True
        Me.txtAddress.Size = New System.Drawing.Size(414, 22)
        Me.txtAddress.TabIndex = 7
        '
        'cboAtoll
        '
        Me.cboAtoll.EnterMoveNextControl = True
        Me.cboAtoll.Location = New System.Drawing.Point(14, 74)
        Me.cboAtoll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboAtoll.Name = "cboAtoll"
        Me.cboAtoll.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAtoll.Properties.Appearance.Options.UseFont = True
        Me.cboAtoll.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAtoll.Size = New System.Drawing.Size(65, 22)
        Me.cboAtoll.TabIndex = 8
        '
        'lblAtoll
        '
        Me.lblAtoll.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtoll.Appearance.Options.UseFont = True
        Me.lblAtoll.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtoll.AppearanceDisabled.Options.UseFont = True
        Me.lblAtoll.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtoll.AppearanceHovered.Options.UseFont = True
        Me.lblAtoll.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtoll.AppearancePressed.Options.UseFont = True
        Me.lblAtoll.Location = New System.Drawing.Point(17, 56)
        Me.lblAtoll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblAtoll.Name = "lblAtoll"
        Me.lblAtoll.Size = New System.Drawing.Size(27, 16)
        Me.lblAtoll.TabIndex = 14
        Me.lblAtoll.Text = "Atoll"
        '
        'cboIsland
        '
        Me.cboIsland.EnterMoveNextControl = True
        Me.cboIsland.Location = New System.Drawing.Point(83, 74)
        Me.cboIsland.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboIsland.Name = "cboIsland"
        Me.cboIsland.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIsland.Properties.Appearance.Options.UseFont = True
        Me.cboIsland.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIsland.Size = New System.Drawing.Size(183, 22)
        Me.cboIsland.TabIndex = 9
        '
        'lblIsland
        '
        Me.lblIsland.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIsland.Appearance.Options.UseFont = True
        Me.lblIsland.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIsland.AppearanceDisabled.Options.UseFont = True
        Me.lblIsland.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIsland.AppearanceHovered.Options.UseFont = True
        Me.lblIsland.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIsland.AppearancePressed.Options.UseFont = True
        Me.lblIsland.Location = New System.Drawing.Point(85, 56)
        Me.lblIsland.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblIsland.Name = "lblIsland"
        Me.lblIsland.Size = New System.Drawing.Size(30, 16)
        Me.lblIsland.TabIndex = 11
        Me.lblIsland.Text = "Island"
        '
        'cboCountry
        '
        Me.cboCountry.EditValue = ""
        Me.cboCountry.EnterMoveNextControl = True
        Me.cboCountry.Location = New System.Drawing.Point(272, 74)
        Me.cboCountry.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCountry.Properties.Appearance.Options.UseFont = True
        Me.cboCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCountry.Properties.Items.AddRange(New Object() {"Maldives"})
        Me.cboCountry.Size = New System.Drawing.Size(156, 22)
        Me.cboCountry.TabIndex = 10
        '
        'GrpPatientDetails
        '
        Me.GrpPatientDetails.AppearanceCaption.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpPatientDetails.AppearanceCaption.Options.UseFont = True
        Me.GrpPatientDetails.Controls.Add(Me.lblClose)
        Me.GrpPatientDetails.Controls.Add(Me.GrpControlSummary)
        Me.GrpPatientDetails.Controls.Add(Me.xTabAddPatientRecords)
        Me.GrpPatientDetails.Location = New System.Drawing.Point(1, 1)
        Me.GrpPatientDetails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrpPatientDetails.Name = "GrpPatientDetails"
        Me.GrpPatientDetails.Size = New System.Drawing.Size(478, 284)
        Me.GrpPatientDetails.TabIndex = 32
        Me.GrpPatientDetails.Text = "frmLabelAddEditPatient"
        '
        'lblClose
        '
        Me.lblClose.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.Appearance.Options.UseFont = True
        Me.lblClose.Location = New System.Drawing.Point(459, 3)
        Me.lblClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(14, 16)
        Me.lblClose.TabIndex = 23
        Me.lblClose.Text = " X "
        '
        'GrpControlSummary
        '
        Me.GrpControlSummary.AppearanceCaption.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpControlSummary.AppearanceCaption.Options.UseFont = True
        Me.GrpControlSummary.Controls.Add(Me.lblSummary)
        Me.GrpControlSummary.Location = New System.Drawing.Point(3, 214)
        Me.GrpControlSummary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrpControlSummary.Name = "GrpControlSummary"
        Me.GrpControlSummary.Size = New System.Drawing.Size(470, 69)
        Me.GrpControlSummary.TabIndex = 33
        Me.GrpControlSummary.Text = "Summary"
        '
        'lblSummary
        '
        Me.lblSummary.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.Appearance.Options.UseFont = True
        Me.lblSummary.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblSummary.Location = New System.Drawing.Point(14, 27)
        Me.lblSummary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(420, 16)
        Me.lblSummary.TabIndex = 34
        Me.lblSummary.Text = "# HospitalNumber:PatientName"
        '
        'frmAddPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 287)
        Me.ControlBox = False
        Me.Controls.Add(Me.GrpPatientDetails)
        Me.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddPatient"
        Me.Text = " New Patient"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.xTabPageContactInfo.ResumeLayout(False)
        Me.xTabPageContactInfo.PerformLayout()
        CType(Me.GridControlAddContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAddContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactDetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboContactType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xTabAddPatientRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xTabAddPatientRecords.ResumeLayout(False)
        Me.xTabPagePersonalInfo.ResumeLayout(False)
        Me.xTabPagePersonalInfo.PerformLayout()
        CType(Me.txtEditDateOfBirth.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditDateOfBirth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditHospitalNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPatientName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xTabPageAddress.ResumeLayout(False)
        Me.xTabPageAddress.PerformLayout()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAtoll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIsland.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpPatientDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPatientDetails.ResumeLayout(False)
        Me.GrpPatientDetails.PerformLayout()
        CType(Me.GrpControlSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpControlSummary.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents xTabPageContactInfo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControlAddContact As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAddContact As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtContactDetail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblContactDetail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblBackContactInfo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboContactType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblContactType As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAddressNext As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents xTabAddPatientRecords As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xTabPagePersonalInfo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblNid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPatientName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboGender As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtPatientName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDob As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGender As DevExpress.XtraEditors.LabelControl
    Friend WithEvents xTabPageAddress As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblCountry As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboAtoll As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblAtoll As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboIsland As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblIsland As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCountry As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GrpPatientDetails As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GrpControlSummary As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblSummary As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblClose As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPersonalInfoNext As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblHospitalNumber As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEditHospitalNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEditDateOfBirth As DevExpress.XtraEditors.DateEdit
End Class
