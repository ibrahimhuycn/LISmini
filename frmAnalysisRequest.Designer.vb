<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnalysisRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalysisRequest))
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.gcAnalysisRequest = New DevExpress.XtraEditors.GroupControl()
        Me.lblClose = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControlPreviewAndPrintAnalysisRequest = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPageEditAnalysisRequest = New DevExpress.XtraTab.XtraTabPage()
        Me.ComboBoxEditQueryAnalytes = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControlEditAnalysisRequest = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAnalysisCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAnalysisName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActions = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEditRemoveEntry = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.lblDiagnosis = New DevExpress.XtraEditors.LabelControl()
        Me.lblAdditionalInformation = New DevExpress.XtraEditors.LabelControl()
        Me.lblHospitalNumber = New DevExpress.XtraEditors.LabelControl()
        Me.lblDoctor = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmail = New DevExpress.XtraEditors.LabelControl()
        Me.lblGender = New DevExpress.XtraEditors.LabelControl()
        Me.lblDateofBirth = New DevExpress.XtraEditors.LabelControl()
        Me.lblPatient = New DevExpress.XtraEditors.LabelControl()
        Me.lblPlaceofCollection = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmployee = New DevExpress.XtraEditors.LabelControl()
        Me.lblDateTime = New DevExpress.XtraEditors.LabelControl()
        Me.lblAccessionNumber = New DevExpress.XtraEditors.LabelControl()
        Me.txtEditDiagnosis = New DevExpress.XtraEditors.TextEdit()
        Me.txtEditAdditionalInformation = New DevExpress.XtraEditors.TextEdit()
        Me.txtEditHospitalNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txtEditDoctor = New DevExpress.XtraEditors.TextEdit()
        Me.txtEditEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtEditPatient = New DevExpress.XtraEditors.TextEdit()
        Me.txtEditEmployee = New DevExpress.XtraEditors.TextEdit()
        Me.txtEditAccessionNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txtEditDateTime = New DevExpress.XtraEditors.DateEdit()
        Me.txtEditDateOfBirth = New DevExpress.XtraEditors.DateEdit()
        Me.toggleSwitchGender = New DevExpress.XtraEditors.ToggleSwitch()
        Me.txtEditPlaceOfCollection = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControlEnterAssayValues = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gcAnalysisRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcAnalysisRequest.SuspendLayout()
        CType(Me.XtraTabControlPreviewAndPrintAnalysisRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.SuspendLayout()
        Me.XtraTabPageEditAnalysisRequest.SuspendLayout()
        CType(Me.ComboBoxEditQueryAnalytes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControlEditAnalysisRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEditRemoveEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditDiagnosis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditAdditionalInformation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditHospitalNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditDoctor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditPatient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditAccessionNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditDateTime.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditDateTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditDateOfBirth.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditDateOfBirth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toggleSwitchGender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditPlaceOfCollection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControlEnterAssayValues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcAnalysisRequest
        '
        Me.gcAnalysisRequest.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcAnalysisRequest.Appearance.Options.UseFont = True
        Me.gcAnalysisRequest.AppearanceCaption.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcAnalysisRequest.AppearanceCaption.Options.UseFont = True
        Me.gcAnalysisRequest.Controls.Add(Me.lblClose)
        Me.gcAnalysisRequest.Controls.Add(Me.XtraTabControlPreviewAndPrintAnalysisRequest)
        Me.gcAnalysisRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAnalysisRequest.Location = New System.Drawing.Point(0, 0)
        Me.gcAnalysisRequest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcAnalysisRequest.Name = "gcAnalysisRequest"
        Me.gcAnalysisRequest.Size = New System.Drawing.Size(911, 517)
        Me.gcAnalysisRequest.TabIndex = 1
        Me.gcAnalysisRequest.Text = "Analysis Request"
        '
        'lblClose
        '
        Me.lblClose.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.Appearance.Options.UseBackColor = True
        Me.lblClose.Appearance.Options.UseFont = True
        Me.lblClose.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblClose.AppearanceDisabled.Options.UseFont = True
        Me.lblClose.AppearanceHovered.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblClose.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblClose.AppearanceHovered.Options.UseBackColor = True
        Me.lblClose.AppearanceHovered.Options.UseFont = True
        Me.lblClose.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblClose.AppearancePressed.Options.UseFont = True
        Me.lblClose.Location = New System.Drawing.Point(887, 2)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(20, 16)
        Me.lblClose.TabIndex = 17
        Me.lblClose.Text = "  X  "
        '
        'XtraTabControlPreviewAndPrintAnalysisRequest
        '
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.Appearance.Options.UseFont = True
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.PageClient.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.PageClient.Options.UseFont = True
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.Location = New System.Drawing.Point(2, 23)
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.Name = "XtraTabControlPreviewAndPrintAnalysisRequest"
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.SelectedTabPage = Me.XtraTabPageEditAnalysisRequest
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.Size = New System.Drawing.Size(907, 492)
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.TabIndex = 1
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPageEditAnalysisRequest, Me.XtraTabPage2, Me.XtraTabPage1})
        '
        'XtraTabPageEditAnalysisRequest
        '
        Me.XtraTabPageEditAnalysisRequest.Appearance.Header.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPageEditAnalysisRequest.Appearance.Header.Options.UseFont = True
        Me.XtraTabPageEditAnalysisRequest.Appearance.HeaderActive.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPageEditAnalysisRequest.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPageEditAnalysisRequest.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPageEditAnalysisRequest.Appearance.HeaderDisabled.Options.UseFont = True
        Me.XtraTabPageEditAnalysisRequest.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPageEditAnalysisRequest.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.XtraTabPageEditAnalysisRequest.Appearance.PageClient.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPageEditAnalysisRequest.Appearance.PageClient.Options.UseFont = True
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.ComboBoxEditQueryAnalytes)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.SimpleButton3)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.SimpleButton2)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.SimpleButton1)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.GridControlEditAnalysisRequest)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.lblDiagnosis)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.lblAdditionalInformation)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.lblHospitalNumber)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.lblDoctor)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.lblEmail)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.lblGender)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.lblDateofBirth)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.lblPatient)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.lblPlaceofCollection)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.lblEmployee)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.lblDateTime)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.lblAccessionNumber)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.txtEditDiagnosis)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.txtEditAdditionalInformation)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.txtEditHospitalNumber)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.txtEditDoctor)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.txtEditEmail)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.txtEditPatient)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.txtEditEmployee)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.txtEditAccessionNumber)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.txtEditDateTime)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.txtEditDateOfBirth)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.toggleSwitchGender)
        Me.XtraTabPageEditAnalysisRequest.Controls.Add(Me.txtEditPlaceOfCollection)
        Me.XtraTabPageEditAnalysisRequest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPageEditAnalysisRequest.Name = "XtraTabPageEditAnalysisRequest"
        Me.XtraTabPageEditAnalysisRequest.Size = New System.Drawing.Size(901, 461)
        Me.XtraTabPageEditAnalysisRequest.Text = "Edit Analysis Request"
        '
        'ComboBoxEditQueryAnalytes
        '
        Me.ComboBoxEditQueryAnalytes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxEditQueryAnalytes.EditValue = "Analyte Name"
        Me.ComboBoxEditQueryAnalytes.Location = New System.Drawing.Point(146, 394)
        Me.ComboBoxEditQueryAnalytes.Name = "ComboBoxEditQueryAnalytes"
        Me.ComboBoxEditQueryAnalytes.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEditQueryAnalytes.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEditQueryAnalytes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEditQueryAnalytes.Size = New System.Drawing.Size(550, 22)
        Me.ComboBoxEditQueryAnalytes.TabIndex = 31
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButton3.AppearanceDisabled.Options.UseFont = True
        Me.SimpleButton3.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButton3.AppearanceHovered.Options.UseFont = True
        Me.SimpleButton3.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButton3.AppearancePressed.Options.UseFont = True
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(480, 419)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(96, 36)
        Me.SimpleButton3.TabIndex = 30
        Me.SimpleButton3.Text = "Ca&ncel"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButton2.AppearanceDisabled.Options.UseFont = True
        Me.SimpleButton2.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButton2.AppearanceHovered.Options.UseFont = True
        Me.SimpleButton2.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButton2.AppearancePressed.Options.UseFont = True
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(378, 419)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(96, 36)
        Me.SimpleButton2.TabIndex = 29
        Me.SimpleButton2.Text = "Ne&xt"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButton1.AppearanceDisabled.Options.UseFont = True
        Me.SimpleButton1.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButton1.AppearanceHovered.Options.UseFont = True
        Me.SimpleButton1.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.SimpleButton1.AppearancePressed.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(276, 419)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(96, 36)
        Me.SimpleButton1.TabIndex = 28
        Me.SimpleButton1.Text = "&Save"
        '
        'GridControlEditAnalysisRequest
        '
        Me.GridControlEditAnalysisRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControlEditAnalysisRequest.Location = New System.Drawing.Point(0, 190)
        Me.GridControlEditAnalysisRequest.MainView = Me.GridView
        Me.GridControlEditAnalysisRequest.Name = "GridControlEditAnalysisRequest"
        Me.GridControlEditAnalysisRequest.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEditRemoveEntry})
        Me.GridControlEditAnalysisRequest.Size = New System.Drawing.Size(901, 200)
        Me.GridControlEditAnalysisRequest.TabIndex = 27
        Me.GridControlEditAnalysisRequest.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.GridView.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.GridView.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.GridView.Appearance.DetailTip.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.Appearance.DetailTip.Options.UseFont = True
        Me.GridView.Appearance.Empty.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.Empty.Options.UseFont = True
        Me.GridView.Appearance.EvenRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.EvenRow.Options.UseFont = True
        Me.GridView.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.FilterCloseButton.Options.UseFont = True
        Me.GridView.Appearance.FilterPanel.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.FilterPanel.Options.UseFont = True
        Me.GridView.Appearance.FixedLine.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.FixedLine.Options.UseFont = True
        Me.GridView.Appearance.FocusedCell.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.FocusedCell.Options.UseFont = True
        Me.GridView.Appearance.FocusedRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView.Appearance.FooterPanel.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView.Appearance.GroupButton.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.GroupButton.Options.UseFont = True
        Me.GridView.Appearance.GroupFooter.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView.Appearance.GroupPanel.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView.Appearance.GroupRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.GroupRow.Options.UseFont = True
        Me.GridView.Appearance.HeaderPanel.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.HideSelectionRow.Options.UseFont = True
        Me.GridView.Appearance.HorzLine.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.HorzLine.Options.UseFont = True
        Me.GridView.Appearance.OddRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.OddRow.Options.UseFont = True
        Me.GridView.Appearance.Preview.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.Preview.Options.UseFont = True
        Me.GridView.Appearance.Row.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.Row.Options.UseFont = True
        Me.GridView.Appearance.RowSeparator.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.RowSeparator.Options.UseFont = True
        Me.GridView.Appearance.SelectedRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView.Appearance.TopNewRow.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.TopNewRow.Options.UseFont = True
        Me.GridView.Appearance.VertLine.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.VertLine.Options.UseFont = True
        Me.GridView.Appearance.ViewCaption.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.GridView.Appearance.ViewCaption.Options.UseFont = True
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAnalysisCode, Me.colAnalysisName, Me.colPrice, Me.colActions})
        Me.GridView.GridControl = Me.GridControlEditAnalysisRequest
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView.OptionsView.ShowPreview = True
        Me.GridView.PaintStyleName = "Skin"
        '
        'colAnalysisCode
        '
        Me.colAnalysisCode.Caption = "Analysis Code"
        Me.colAnalysisCode.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.colAnalysisCode.Name = "colAnalysisCode"
        Me.colAnalysisCode.Visible = True
        Me.colAnalysisCode.VisibleIndex = 0
        Me.colAnalysisCode.Width = 129
        '
        'colAnalysisName
        '
        Me.colAnalysisName.Caption = "Analysis Name"
        Me.colAnalysisName.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.colAnalysisName.Name = "colAnalysisName"
        Me.colAnalysisName.Visible = True
        Me.colAnalysisName.VisibleIndex = 1
        Me.colAnalysisName.Width = 549
        '
        'colPrice
        '
        Me.colPrice.Caption = "Price"
        Me.colPrice.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 2
        Me.colPrice.Width = 102
        '
        'colActions
        '
        Me.colActions.Caption = "Actions"
        Me.colActions.ColumnEdit = Me.RepositoryItemButtonEditRemoveEntry
        Me.colActions.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.colActions.Name = "colActions"
        Me.colActions.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.colActions.Visible = True
        Me.colActions.VisibleIndex = 3
        Me.colActions.Width = 103
        '
        'RepositoryItemButtonEditRemoveEntry
        '
        Me.RepositoryItemButtonEditRemoveEntry.AccessibleDescription = ""
        Me.RepositoryItemButtonEditRemoveEntry.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.RepositoryItemButtonEditRemoveEntry.Appearance.Image = CType(resources.GetObject("RepositoryItemButtonEditRemoveEntry.Appearance.Image"), System.Drawing.Image)
        Me.RepositoryItemButtonEditRemoveEntry.Appearance.Options.UseFont = True
        Me.RepositoryItemButtonEditRemoveEntry.Appearance.Options.UseImage = True
        Me.RepositoryItemButtonEditRemoveEntry.AutoHeight = False
        Me.RepositoryItemButtonEditRemoveEntry.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepositoryItemButtonEditRemoveEntry.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 110, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.RepositoryItemButtonEditRemoveEntry.Name = "RepositoryItemButtonEditRemoveEntry"
        Me.RepositoryItemButtonEditRemoveEntry.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'lblDiagnosis
        '
        Me.lblDiagnosis.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiagnosis.Appearance.Options.UseFont = True
        Me.lblDiagnosis.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDiagnosis.AppearanceDisabled.Options.UseFont = True
        Me.lblDiagnosis.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDiagnosis.AppearanceHovered.Options.UseFont = True
        Me.lblDiagnosis.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDiagnosis.AppearancePressed.Options.UseFont = True
        Me.lblDiagnosis.Location = New System.Drawing.Point(9, 144)
        Me.lblDiagnosis.Name = "lblDiagnosis"
        Me.lblDiagnosis.Size = New System.Drawing.Size(136, 16)
        Me.lblDiagnosis.TabIndex = 26
        Me.lblDiagnosis.Text = "Diagnosis | Clinical Details"
        '
        'lblAdditionalInformation
        '
        Me.lblAdditionalInformation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAdditionalInformation.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdditionalInformation.Appearance.Options.UseFont = True
        Me.lblAdditionalInformation.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAdditionalInformation.AppearanceDisabled.Options.UseFont = True
        Me.lblAdditionalInformation.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAdditionalInformation.AppearanceHovered.Options.UseFont = True
        Me.lblAdditionalInformation.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAdditionalInformation.AppearancePressed.Options.UseFont = True
        Me.lblAdditionalInformation.Location = New System.Drawing.Point(619, 98)
        Me.lblAdditionalInformation.Name = "lblAdditionalInformation"
        Me.lblAdditionalInformation.Size = New System.Drawing.Size(116, 16)
        Me.lblAdditionalInformation.TabIndex = 25
        Me.lblAdditionalInformation.Text = "Additional Information"
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
        Me.lblHospitalNumber.Location = New System.Drawing.Point(440, 98)
        Me.lblHospitalNumber.Name = "lblHospitalNumber"
        Me.lblHospitalNumber.Size = New System.Drawing.Size(84, 16)
        Me.lblHospitalNumber.TabIndex = 24
        Me.lblHospitalNumber.Text = "Hospital Number"
        '
        'lblDoctor
        '
        Me.lblDoctor.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctor.Appearance.Options.UseFont = True
        Me.lblDoctor.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDoctor.AppearanceDisabled.Options.UseFont = True
        Me.lblDoctor.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDoctor.AppearanceHovered.Options.UseFont = True
        Me.lblDoctor.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDoctor.AppearancePressed.Options.UseFont = True
        Me.lblDoctor.Location = New System.Drawing.Point(9, 98)
        Me.lblDoctor.Name = "lblDoctor"
        Me.lblDoctor.Size = New System.Drawing.Size(35, 16)
        Me.lblDoctor.TabIndex = 23
        Me.lblDoctor.Text = "Doctor"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Appearance.Options.UseFont = True
        Me.lblEmail.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.AppearanceDisabled.Options.UseFont = True
        Me.lblEmail.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.AppearanceHovered.Options.UseFont = True
        Me.lblEmail.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.AppearancePressed.Options.UseFont = True
        Me.lblEmail.Location = New System.Drawing.Point(727, 52)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(33, 16)
        Me.lblEmail.TabIndex = 22
        Me.lblEmail.Text = "E-Mail"
        '
        'lblGender
        '
        Me.lblGender.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGender.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Appearance.Options.UseFont = True
        Me.lblGender.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblGender.AppearanceDisabled.Options.UseFont = True
        Me.lblGender.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblGender.AppearanceHovered.Options.UseFont = True
        Me.lblGender.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblGender.AppearancePressed.Options.UseFont = True
        Me.lblGender.Location = New System.Drawing.Point(618, 51)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(36, 16)
        Me.lblGender.TabIndex = 21
        Me.lblGender.Text = "Gender"
        '
        'lblDateofBirth
        '
        Me.lblDateofBirth.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateofBirth.Appearance.Options.UseFont = True
        Me.lblDateofBirth.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDateofBirth.AppearanceDisabled.Options.UseFont = True
        Me.lblDateofBirth.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDateofBirth.AppearanceHovered.Options.UseFont = True
        Me.lblDateofBirth.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDateofBirth.AppearancePressed.Options.UseFont = True
        Me.lblDateofBirth.Location = New System.Drawing.Point(440, 52)
        Me.lblDateofBirth.Name = "lblDateofBirth"
        Me.lblDateofBirth.Size = New System.Drawing.Size(67, 16)
        Me.lblDateofBirth.TabIndex = 20
        Me.lblDateofBirth.Text = "Date of birth"
        '
        'lblPatient
        '
        Me.lblPatient.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatient.Appearance.Options.UseFont = True
        Me.lblPatient.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPatient.AppearanceDisabled.Options.UseFont = True
        Me.lblPatient.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPatient.AppearanceHovered.Options.UseFont = True
        Me.lblPatient.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPatient.AppearancePressed.Options.UseFont = True
        Me.lblPatient.Location = New System.Drawing.Point(9, 52)
        Me.lblPatient.Name = "lblPatient"
        Me.lblPatient.Size = New System.Drawing.Size(38, 16)
        Me.lblPatient.TabIndex = 19
        Me.lblPatient.Text = "Patient"
        '
        'lblPlaceofCollection
        '
        Me.lblPlaceofCollection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPlaceofCollection.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaceofCollection.Appearance.Options.UseFont = True
        Me.lblPlaceofCollection.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPlaceofCollection.AppearanceDisabled.Options.UseFont = True
        Me.lblPlaceofCollection.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPlaceofCollection.AppearanceHovered.Options.UseFont = True
        Me.lblPlaceofCollection.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPlaceofCollection.AppearancePressed.Options.UseFont = True
        Me.lblPlaceofCollection.Location = New System.Drawing.Point(619, 5)
        Me.lblPlaceofCollection.Name = "lblPlaceofCollection"
        Me.lblPlaceofCollection.Size = New System.Drawing.Size(95, 16)
        Me.lblPlaceofCollection.TabIndex = 18
        Me.lblPlaceofCollection.Text = "Place of collection"
        '
        'lblEmployee
        '
        Me.lblEmployee.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee.Appearance.Options.UseFont = True
        Me.lblEmployee.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEmployee.AppearanceDisabled.Options.UseFont = True
        Me.lblEmployee.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEmployee.AppearanceHovered.Options.UseFont = True
        Me.lblEmployee.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEmployee.AppearancePressed.Options.UseFont = True
        Me.lblEmployee.Location = New System.Drawing.Point(317, 5)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(49, 16)
        Me.lblEmployee.TabIndex = 17
        Me.lblEmployee.Text = "Employee"
        '
        'lblDateTime
        '
        Me.lblDateTime.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Appearance.Options.UseFont = True
        Me.lblDateTime.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDateTime.AppearanceDisabled.Options.UseFont = True
        Me.lblDateTime.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDateTime.AppearanceHovered.Options.UseFont = True
        Me.lblDateTime.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDateTime.AppearancePressed.Options.UseFont = True
        Me.lblDateTime.Location = New System.Drawing.Point(146, 5)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(28, 16)
        Me.lblDateTime.TabIndex = 16
        Me.lblDateTime.Text = " Date"
        '
        'lblAccessionNumber
        '
        Me.lblAccessionNumber.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccessionNumber.Appearance.Options.UseFont = True
        Me.lblAccessionNumber.AppearanceDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAccessionNumber.AppearanceDisabled.Options.UseFont = True
        Me.lblAccessionNumber.AppearanceHovered.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAccessionNumber.AppearanceHovered.Options.UseFont = True
        Me.lblAccessionNumber.AppearancePressed.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAccessionNumber.AppearancePressed.Options.UseFont = True
        Me.lblAccessionNumber.Location = New System.Drawing.Point(9, 5)
        Me.lblAccessionNumber.Name = "lblAccessionNumber"
        Me.lblAccessionNumber.Size = New System.Drawing.Size(91, 16)
        Me.lblAccessionNumber.TabIndex = 15
        Me.lblAccessionNumber.Text = "Accession Number"
        '
        'txtEditDiagnosis
        '
        Me.txtEditDiagnosis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEditDiagnosis.EditValue = "Diagnosis"
        Me.txtEditDiagnosis.Location = New System.Drawing.Point(9, 162)
        Me.txtEditDiagnosis.Name = "txtEditDiagnosis"
        Me.txtEditDiagnosis.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditDiagnosis.Properties.Appearance.Options.UseFont = True
        Me.txtEditDiagnosis.Size = New System.Drawing.Size(883, 22)
        Me.txtEditDiagnosis.TabIndex = 14
        '
        'txtEditAdditionalInformation
        '
        Me.txtEditAdditionalInformation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEditAdditionalInformation.EditValue = "Additional Information"
        Me.txtEditAdditionalInformation.Location = New System.Drawing.Point(619, 116)
        Me.txtEditAdditionalInformation.Name = "txtEditAdditionalInformation"
        Me.txtEditAdditionalInformation.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditAdditionalInformation.Properties.Appearance.Options.UseFont = True
        Me.txtEditAdditionalInformation.Size = New System.Drawing.Size(273, 22)
        Me.txtEditAdditionalInformation.TabIndex = 13
        '
        'txtEditHospitalNumber
        '
        Me.txtEditHospitalNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEditHospitalNumber.EditValue = "Hospital Number"
        Me.txtEditHospitalNumber.Location = New System.Drawing.Point(440, 116)
        Me.txtEditHospitalNumber.Name = "txtEditHospitalNumber"
        Me.txtEditHospitalNumber.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditHospitalNumber.Properties.Appearance.Options.UseFont = True
        Me.txtEditHospitalNumber.Size = New System.Drawing.Size(165, 22)
        Me.txtEditHospitalNumber.TabIndex = 12
        '
        'txtEditDoctor
        '
        Me.txtEditDoctor.EditValue = "Doctor"
        Me.txtEditDoctor.Location = New System.Drawing.Point(9, 116)
        Me.txtEditDoctor.Name = "txtEditDoctor"
        Me.txtEditDoctor.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditDoctor.Properties.Appearance.Options.UseFont = True
        Me.txtEditDoctor.Size = New System.Drawing.Size(425, 22)
        Me.txtEditDoctor.TabIndex = 11
        '
        'txtEditEmail
        '
        Me.txtEditEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEditEmail.EditValue = "E-mail"
        Me.txtEditEmail.Location = New System.Drawing.Point(727, 70)
        Me.txtEditEmail.Name = "txtEditEmail"
        Me.txtEditEmail.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEditEmail.Size = New System.Drawing.Size(165, 22)
        Me.txtEditEmail.TabIndex = 10
        '
        'txtEditPatient
        '
        Me.txtEditPatient.EditValue = "Patient"
        Me.txtEditPatient.Location = New System.Drawing.Point(9, 70)
        Me.txtEditPatient.Name = "txtEditPatient"
        Me.txtEditPatient.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditPatient.Properties.Appearance.Options.UseFont = True
        Me.txtEditPatient.Size = New System.Drawing.Size(425, 22)
        Me.txtEditPatient.TabIndex = 7
        '
        'txtEditEmployee
        '
        Me.txtEditEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEditEmployee.EditValue = "Employee"
        Me.txtEditEmployee.Location = New System.Drawing.Point(317, 23)
        Me.txtEditEmployee.Name = "txtEditEmployee"
        Me.txtEditEmployee.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditEmployee.Properties.Appearance.Options.UseFont = True
        Me.txtEditEmployee.Size = New System.Drawing.Size(288, 22)
        Me.txtEditEmployee.TabIndex = 5
        '
        'txtEditAccessionNumber
        '
        Me.txtEditAccessionNumber.EditValue = "Accession Number"
        Me.txtEditAccessionNumber.Location = New System.Drawing.Point(9, 23)
        Me.txtEditAccessionNumber.Name = "txtEditAccessionNumber"
        Me.txtEditAccessionNumber.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditAccessionNumber.Properties.Appearance.Options.UseFont = True
        Me.txtEditAccessionNumber.Size = New System.Drawing.Size(131, 22)
        Me.txtEditAccessionNumber.TabIndex = 3
        '
        'txtEditDateTime
        '
        Me.txtEditDateTime.EditValue = "DateTime"
        Me.txtEditDateTime.Location = New System.Drawing.Point(146, 23)
        Me.txtEditDateTime.Name = "txtEditDateTime"
        Me.txtEditDateTime.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditDateTime.Properties.Appearance.Options.UseFont = True
        Me.txtEditDateTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEditDateTime.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEditDateTime.Properties.DisplayFormat.FormatString = ""
        Me.txtEditDateTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtEditDateTime.Properties.EditFormat.FormatString = ""
        Me.txtEditDateTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtEditDateTime.Properties.Mask.BeepOnError = True
        Me.txtEditDateTime.Properties.Mask.EditMask = "g"
        Me.txtEditDateTime.Size = New System.Drawing.Size(165, 22)
        Me.txtEditDateTime.TabIndex = 4
        '
        'txtEditDateOfBirth
        '
        Me.txtEditDateOfBirth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEditDateOfBirth.EditValue = "Date of birth"
        Me.txtEditDateOfBirth.Location = New System.Drawing.Point(440, 70)
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
        Me.txtEditDateOfBirth.Size = New System.Drawing.Size(165, 22)
        Me.txtEditDateOfBirth.TabIndex = 8
        '
        'toggleSwitchGender
        '
        Me.toggleSwitchGender.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toggleSwitchGender.Location = New System.Drawing.Point(619, 69)
        Me.toggleSwitchGender.Name = "toggleSwitchGender"
        Me.toggleSwitchGender.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toggleSwitchGender.Properties.Appearance.Options.UseFont = True
        Me.toggleSwitchGender.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.toggleSwitchGender.Properties.OffText = "Male"
        Me.toggleSwitchGender.Properties.OnText = "Female"
        Me.toggleSwitchGender.Size = New System.Drawing.Size(102, 23)
        Me.toggleSwitchGender.TabIndex = 9
        '
        'txtEditPlaceOfCollection
        '
        Me.txtEditPlaceOfCollection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEditPlaceOfCollection.EditValue = "Place of Collection"
        Me.txtEditPlaceOfCollection.Location = New System.Drawing.Point(619, 23)
        Me.txtEditPlaceOfCollection.Name = "txtEditPlaceOfCollection"
        Me.txtEditPlaceOfCollection.Properties.Appearance.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditPlaceOfCollection.Properties.Appearance.Options.UseFont = True
        Me.txtEditPlaceOfCollection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEditPlaceOfCollection.Size = New System.Drawing.Size(273, 22)
        Me.txtEditPlaceOfCollection.TabIndex = 6
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.Header.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPage2.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage2.Appearance.HeaderActive.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPage2.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPage2.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPage2.Appearance.HeaderDisabled.Options.UseFont = True
        Me.XtraTabPage2.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPage2.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.XtraTabPage2.Appearance.PageClient.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPage2.Appearance.PageClient.Options.UseFont = True
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(901, 461)
        Me.XtraTabPage2.Text = "Preview and Print Analysis Request"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.HeaderActive.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPage1.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPage1.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPage1.Appearance.HeaderDisabled.Options.UseFont = True
        Me.XtraTabPage1.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPage1.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.XtraTabPage1.Appearance.PageClient.Font = New System.Drawing.Font("Ubuntu", 8.25!)
        Me.XtraTabPage1.Appearance.PageClient.Options.UseFont = True
        Me.XtraTabPage1.Controls.Add(Me.GridControlEnterAssayValues)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(901, 461)
        Me.XtraTabPage1.Text = "Entering analysis values"
        '
        'GridControlEnterAssayValues
        '
        Me.GridControlEnterAssayValues.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControlEnterAssayValues.Location = New System.Drawing.Point(0, 0)
        Me.GridControlEnterAssayValues.MainView = Me.GridView1
        Me.GridControlEnterAssayValues.Name = "GridControlEnterAssayValues"
        Me.GridControlEnterAssayValues.Size = New System.Drawing.Size(901, 461)
        Me.GridControlEnterAssayValues.TabIndex = 0
        Me.GridControlEnterAssayValues.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControlEnterAssayValues
        Me.GridView1.Name = "GridView1"
        '
        'frmAnalysisRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(911, 517)
        Me.Controls.Add(Me.gcAnalysisRequest)
        Me.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmAnalysisRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.gcAnalysisRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcAnalysisRequest.ResumeLayout(False)
        Me.gcAnalysisRequest.PerformLayout()
        CType(Me.XtraTabControlPreviewAndPrintAnalysisRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.ResumeLayout(False)
        Me.XtraTabPageEditAnalysisRequest.ResumeLayout(False)
        Me.XtraTabPageEditAnalysisRequest.PerformLayout()
        CType(Me.ComboBoxEditQueryAnalytes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControlEditAnalysisRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEditRemoveEntry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditDiagnosis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditAdditionalInformation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditHospitalNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditDoctor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditPatient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditAccessionNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditDateTime.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditDateTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditDateOfBirth.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditDateOfBirth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toggleSwitchGender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditPlaceOfCollection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControlEnterAssayValues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcAnalysisRequest As DevExpress.XtraEditors.GroupControl
    Friend WithEvents XtraTabControlPreviewAndPrintAnalysisRequest As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPageEditAnalysisRequest As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtEditAccessionNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEditDateTime As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GridControlEnterAssayValues As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblDiagnosis As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAdditionalInformation As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHospitalNumber As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDoctor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGender As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateofBirth As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPatient As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPlaceofCollection As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmployee As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAccessionNumber As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEditDiagnosis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEditAdditionalInformation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEditHospitalNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEditDoctor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEditEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEditPatient As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEditEmployee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEditDateOfBirth As DevExpress.XtraEditors.DateEdit
    Friend WithEvents toggleSwitchGender As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents GridControlEditAnalysisRequest As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colAnalysisCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAnalysisName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEditRemoveEntry As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colActions As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtEditPlaceOfCollection As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEditQueryAnalytes As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblClose As DevExpress.XtraEditors.LabelControl
End Class
