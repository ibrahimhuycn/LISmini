Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports LISmini.SwatInc.Mathematics.PreSetCalculations
Imports LISmini.SwatInc.Patients
Imports LISmini.SwatInc.Validations.Validate
Imports ServerCommunications
Imports SwatIncNotifications

Public Class FormAddPatient

    'TODO: IMPLEMENT A WAY TO ENTER PASSPORT NUMBER FOR FORIGNERS.
    'MOVE SERVER CONNECTION STATUS CHECKING FUNCTION TO MAIN FORM.
    Dim WithEvents ConnectionMonitor As New Timers.Timer

    'VARIABLE TO STORE NUMBER OF INDIVIDUAL NAMES IN THE FULL NAME. THIS SERVES AS NUMBER OF ITEMS IN THE STRING ARRAY PatientName

    Const connectionMonitorInterval As Integer = 3000

    'DELIMITER FOR SEPARATING INDIVIDUAL NAMES
    Const delimiter As String = " "

    'INITIALISATIONS FOR TRACKING AND LOGGING APPLICATION EVENTS, QUERIES, EXCEPTIONS ETC..
    Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(Reflection.MethodBase.GetCurrentMethod().DeclaringType)

    ReadOnly addIndividual As New AddPatients
    ReadOnly checkValuePresence As New FieldPopulation
    ReadOnly executeInserts As New ExecuteInserts
    ReadOnly getNextHospitalNumber As New GetNextHospitalNumber

    'SERVER OBJECT INITIALISATION FOR EXECUTING QUERIES
    ReadOnly lisConnectionCheck As New MsSqlConnectionStatus

    'VARIABLES AND INITIALISATIONS FOR CONTACT DETAILS PAGE
    ReadOnly patientContacts As New List(Of Contacts)()

    ReadOnly patientInformationCommunications As New PatientInformationCommunications
    ReadOnly readDatabase As New ExecuteReads

    'Variables to move the form by grabbing GroupControl "gcAnalysisRequest"
    Dim dragAnalysisRequest As Boolean

    Dim isHospitalNumberValid As Boolean
    Dim isNationalIdValid As Boolean

    'QUERIES SERVER FOR PRESENCE OF THE ID AT TXTNID LOST FOCUS EVENT.
    Dim isNidRegistered As Integer

    Dim isServerConnectionAvailable As Boolean
    Dim mousePositionX As Integer
    Dim mousePositionY As Integer

    'VARIABLES FOR TEMPORARY STORAGE OF PERSONAL DATA FOR ADDING NEW PATIENTS.

    'BOOLEAN STORING WHETHER USER ENTERED IDCARD NUMBER IS VALID
    'BOOLEAN STORING WHETHER USER ENTERED HOSPITAL NUMBER NUMBER IS VALID

    '0 = NOT PRESENT  1=PRESENT (REGISTERED)
    Dim personalInformation As New AddPatientEventArgs

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'INITIALIZING A TO MONITOR CONNECTION STATUS BY CALLING COM HANDLERS' ISCNXALIVE FUNCTION
        ConnectionMonitor.Interval = connectionMonitorInterval
        ConnectionMonitor.Enabled = True

        'SETTING GENERIC LIST AS A DATASOURCE FOR GRIDCONTROLADDCONTACT
        GridControlAddContact.DataSource = patientContacts
    End Sub

    Public Delegate Sub SummaryDisplayUpdatingEventHandler(sender As Object, patientInformation As AddPatientEventArgs)

    Public Event SummaryDisplayUpdating As SummaryDisplayUpdatingEventHandler

    Enum PatientSex
        M
        F
        O
        U
    End Enum

    Private Sub ActivateAddressNext()
        If Not (TextEditAddress.Text = "" Or ComboBoxIsland.Text = "" Or ComboBoxEditAtoll.Text = "" Or ComboBoxEditCountry.Text = "") Then
            SimpleButtonAddressNext.Enabled = True 'IF ALL THE FIELDS ARE COMPLETED, ACTIVATE NEXT BUTTON.
        Else
            'IGNORE
        End If
        RaiseEvent SummaryDisplayUpdating(Me, personalInformation)
    End Sub

    Private Sub AddPatient_Load(sender As Object, e As EventArgs) Handles Me.Load

        'DISABLING CONTROLS TO ENFORCE STANDARDISED WORKFLOW.
        'CONTROLS ARE ENABLED ON REQUIRMENT.
        xTabPagePersonalInfo.Select()
        xTabPageAddress.PageEnabled = False
        xTabPageContactInfo.PageEnabled = False
        SimpleButtonPersonalInfoNext.Enabled = False
        SimpleButtonAddressNext.Enabled = False
        SimpleButtonBackContactInfo.Enabled = False

        'AUTOMATIC "VALIDATING" EVENT IS RAISED ON LOST FOCUS EVENT OF A CONTROL. THIS FIELD REQUIRES VALIDATION ON "EDIT VALUE CHANGED" EVENT
        'SO, "CAUSE VALIDATION" IS DISABLED. VALIDATING EVENT IS RAISED MANUALLY BY CALLING txtNidDoValidate()
        TextEditNid.CausesValidation = False

        'RENAMING GrpPatientDetails.Text AS
        ' 'ADD NEW PATIENT: PERSONAL INFORMATION'        SINCE THE TABPAGE SELECTED AS DEFAULT IS THE PERSONAL INFO ENTRY PAGE.
        If xTabAddPatientRecords.SelectedTabPage.Text = xTabPagePersonalInfo.Text Then
            GroupPatientDetails.Text = "ADD NEW PATIENT: PERSONAL INFORMATION"
        End If

        'QUERYING FOR HOSPITAL NUMBER TO BE GIVEN TO NEXT PATIENT & UPDATING PATIENT DETAILS DISPLAY LABEL
        personalInformation.NextHospitalNumber = getNextHospitalNumber.GetNextHNo()        'QUERYING
        RaiseEvent SummaryDisplayUpdating(Me, personalInformation)                      'UPDATING THE LABEL

        'SETTING FOCUS TO TEXT BOX TXTNID
        TextEditNid.Focus()
    End Sub

    Private Sub ComboBoxEditAtoll_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxEditAtoll.LostFocus
        'TODO PERFORMANCE: CHANGE THE DATABASE STRUCTURE TO INCLUDE SAPARATE TABLES FOR ATOLLS AND ISLANDS
        'CHANGE THE QUERY SO THAT THE QUERY UTILIZES IdAtolls TO GET THE LIST OF ISLANDS FOR THE PARTICULAR ATOLL RATHER THAN USING A STRING LIKE NOW.
        Dim Island As String
        ComboBoxIsland.Properties.Items.Clear()

        If Not ComboBoxEditAtoll.Text = "" Then
            Dim IslandList() As String = readDatabase.ExecuteMsSQLReader("island", "islandlist", True, String.Format("AtollAbbrv = '{0}'", ComboBoxEditAtoll.Text), True, True, "island", True)
            For Each Island In IslandList
                ComboBoxIsland.Properties.Items.Add(Island)
            Next
            personalInformation.Atoll = ComboBoxEditAtoll.Text
            ActivateAddressNext()
        End If
    End Sub

    Private Sub ComboBoxEditCountry_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxEditCountry.LostFocus
        If Not ComboBoxEditCountry.Text = "" Then
            personalInformation.Country = ComboBoxEditCountry.Text
            ActivateAddressNext()
        End If

    End Sub

    Private Sub ComboBoxEditGender_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxEditGender.LostFocus
        'CHECKING TO SEE WHETHER ALL FIELDS ARE COMPLETE
        PesonalInfoNextEnabledStatusHandler()
        personalInformation.PatientGender = (CType(ComboBoxEditGender.SelectedIndex, PatientSex)).ToString
        personalInformation.IdPatientGender = [Enum].Parse(GetType(PatientSex), personalInformation.IdPatientGender)
        RaiseEvent SummaryDisplayUpdating(Me, personalInformation)                      'UPDATING THE LABEL

    End Sub

    Private Sub ComboBoxIsland_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxIsland.LostFocus
        If Not ComboBoxIsland.Text = "" Then
            personalInformation.Island = ComboBoxIsland.Text
            ActivateAddressNext()
        End If

    End Sub

    Private Sub ConnectionMonitor_Tick(sender As Object, e As EventArgs) Handles ConnectionMonitor.Elapsed
        isServerConnectionAvailable = Nothing
        Try
            If lisConnectionCheck.IsServerAccessAvailable() = True Then
                isServerConnectionAvailable = True
            Else
                isServerConnectionAvailable = False

            End If
        Catch ex As Exception
            log.Error(ex)  'LOGGING ERROR TO DISK
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GetAgeFromDob(dob As Date)

        Try
            personalInformation.PatientAge = CalculateAge(dob)

            'UPDATING PATIENT DETAILS DISPLAY LABEL
            RaiseEvent SummaryDisplayUpdating(Me, personalInformation)                      'UPDATING THE LABEL
        Catch ex As Exception
            log.Error(ex)  'LOGGING ERROR TO DISK
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GroupPatientDetails_MouseDown(sender As Object, e As MouseEventArgs) Handles GroupPatientDetails.MouseDown
        'DRAG_ANALYSIS_REQUEST handles an IF CONDITION at mouse move event. If DRAG_ANALYSIS_REQUEST is true,
        ' and if mouse button.left is down, form is moved with cursor
        If e.Button = MouseButtons.Left Then
            dragAnalysisRequest = True
            mousePositionX = Cursor.Position.X - Me.Left
            mousePositionY = Cursor.Position.Y - Me.Top
        End If
    End Sub

    Private Sub GroupPatientDetails_MouseMove(sender As Object, e As MouseEventArgs) Handles GroupPatientDetails.MouseMove
        If dragAnalysisRequest = True Then
            Top = Cursor.Position.Y - mousePositionY
            Left = Cursor.Position.X - mousePositionX
        End If
    End Sub

    Private Sub GroupPatientDetails_MouseUp(sender As Object, e As MouseEventArgs) Handles GroupPatientDetails.MouseUp
        'Setting Drag Analysis Request as false on MouseUp event prevents the form being moved when the user is not
        'holding the mouse down.
        dragAnalysisRequest = False
    End Sub

    Private Sub LabelblClose_Click(sender As Object, e As EventArgs) Handles LabelClose.Click
        Close()
    End Sub

    Private Sub MakeNotePatientInformation()

        personalInformation.NationalId = TextEditNid.Text
        personalInformation.HospitalNumber = TextEditHospitalNumber.Text
        personalInformation.Dob = TextEditDateOfBirth.Text

    End Sub

    Private Sub PesonalInfoNextEnabledStatusHandler()
        If TextEditNid.Text = "" Or TextEditPatientName.Text = "" Or ComboBoxEditGender.Text = "" Or TextEditDateOfBirth.Text = "" Or TextEditHospitalNumber.Text = "" _
           Or isNationalIdValid = False Or isHospitalNumberValid = False Then
            'btnPersonalInfoNext STAYS DISABLED AS LONG AS ANY OF THE FIELDS ARE EMPTY. ALL FIELDS ARE REQUIRED.
            SimpleButtonPersonalInfoNext.Enabled = False
        Else
            SimpleButtonPersonalInfoNext.Enabled = True
        End If

    End Sub

    Private Function RemoveMultipleSpacesInPatientName(rawName As String) As String
        Dim PatientNameMultipleSpacesRemoved As String = Nothing
        'SPLITTING FULL NAME INTO INDIVIDUAL NAMES, & GETTING RID OF ANY MULTIPLE SPACES IN BETWEEN THE NAMES.
        Dim ExcludingMultipleSpaces() As String = rawName.Split(delimiter)

        'EXCLUDING MULTIPLE SPACES BETWEEN INDIVIDUAL NAMES
        Try
            TextEditPatientName.Text = Nothing
            For Each IndividualName In ExcludingMultipleSpaces
                If Not IndividualName = "" Then
                    PatientNameMultipleSpacesRemoved = String.Format("{0} {1}", PatientNameMultipleSpacesRemoved, IndividualName)
                End If
            Next
        Catch ex As Exception
            log.Error(ex)  'LOGGING ERROR TO DISK
            MsgBox(ex.Message)
        End Try
        Return PatientNameMultipleSpacesRemoved
    End Function

    Private Sub SimpleButtonAdd_Click(sender As Object, e As EventArgs) Handles SimpleButtonAdd.Click

        'GRIDVIEW REQUIRES TO BE BOUND TO SOME SORTA DATA SOURCE FOR IT TO HAVE EVEN THE MOST BASIC FUNCTION
        'MAKE A WRAPPER TO WRAP A STRING ARRAY TO STORE CONTACT AND CORRESPONG CONTACT DETAIL UNTIL THEY ARE WRITTEN TO SERVER.
        'THIS STEP WILL BE IMPLEMENTED IN A NEW CLASS.

        patientContacts.Add(New Contacts(TextEditContactDetail.Text, ComboBoxEditContactType.Text))
        GridControlAddContact.DataSource = Nothing
        GridControlAddContact.DataSource = patientContacts

        'GETTING "txtContactDetail" BACK ON FOCUS FOR NEXT ENTRY
        TextEditContactDetail.Focus()
        TextEditContactDetail.SelectAll()

        'THIS WRAPPED DATA STRING ARRAY WILL BE ASSIGNED TO THE GRIDCONTROL.DATASOURCE PROPERTY.
        'EVERYTIME THE STRING ARRAY CHANGES. DATASOURCE NEEDS TO UNASSIGNED AND THEN ASSIGNED TO GRIDCONTROL TO DISPLAY THE
        'CHANGES. THIS NEEDS TO BE IMPROVED GREATLY.

        'VALIDATE THE CONTACT DETAILS USING REGEX
    End Sub

    Private Sub SimpleButtonAddressNext_Click(sender As Object, e As EventArgs) Handles SimpleButtonAddressNext.Click
        xTabPageContactInfo.PageEnabled = True
        xTabPageContactInfo.Focus()
        xTabPageAddress.PageEnabled = False
    End Sub

    Private Sub SimpleButtonBack_Click(sender As Object, e As EventArgs) Handles SimpleButtonBack.Click

        'ASSUMING THAT USER HAS TO EDIT SOME DATA AT PERSONAL INFORMATION XTAB
        xTabPagePersonalInfo.PageEnabled = True
        xTabPagePersonalInfo.Select()
        xTabPageAddress.PageEnabled = False
        xTabPageContactInfo.PageEnabled = False

    End Sub

    Private Sub SimpleButtonPersonalInfoNext_Click(sender As Object, e As EventArgs) Handles SimpleButtonPersonalInfoNext.Click

        Try
            MakeNotePatientInformation()

            'ENABLE AND SET FOCUS TO xTabPageAddress
            xTabPageAddress.PageEnabled = True

            xTabPageAddress.Select()
            TextEditAddress.Focus()
            xTabPagePersonalInfo.PageEnabled = False
            xTabPageContactInfo.PageEnabled = False
        Catch ex As Exception
            log.Error(ex)  'LOGGING ERROR TO DISK
            MsgBox(ex.Message)
        End Try

        'FETCH ATOLL DATA FROM SERVER BY EXECUTING A DATAREADER FOR THE ADDRESS TAB
        ComboBoxEditAtoll.Properties.Items.Clear()
        Dim AtollList() As String = readDatabase.ExecuteMsSQLReader("AtollAbbrv", "islandlist", False, "", True, True, "AtollAbbrv", True)

        For Each atoll In AtollList         'ADDING ATOLL LIST TO COMBOBOX LIST ITEM
            ComboBoxEditAtoll.Properties.Items.Add(atoll)
        Next
    End Sub

    Private Sub SimpleButtonRemoveRemove_Click(sender As Object, e As EventArgs) Handles SimpleButtonRemove.Click
        'REMOVE SELECTED ROWS RECORDS FROM GRIDVIEWADDCONTACT
        Try
            GridViewAddContact.DeleteSelectedRows()
        Catch ex As Exception
            log.Error(ex)  'LOGGING ERROR TO DISK
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SimpleButtonSave_Click(sender As Object, e As EventArgs) Handles SimpleButtonSave.Click

        Dim Notify As New frmNotification
        '1)GATHERING DATA
        personalInformation.IdIndividualNames = patientInformationCommunications.FetchIndividualNameIDs(personalInformation)         'i) INSERT NONEXISTING NAMES AND GET ALL IDs FOR INDIVIDUAL NAMES OF PATIENT
        personalInformation.IdIslandAndAtoll = patientInformationCommunications.FetchIdIslandList(personalInformation)
        personalInformation.IdCountry = patientInformationCommunications.FetchCountryID(personalInformation)

        '2) INSERTING DATA INTO DBO.INDIVIDUALS & NAMEHANDLER
        Try
            'INSERTING DATA INTO DBO.INDIVIDUALS
            If (addIndividual.IndividualInserted(Me, executeInserts, personalInformation)) = True Then

                'i) INSERTING DATA INTO DBO.NAMEHANDLER
                If (addIndividual.NameHandlerValuesInserted(Me, executeInserts, personalInformation)) = True Then

                    'SAVING CONTACT DETAILS TO SERVER | SKIPPING THIS STEP IF NO CONTACT DETAILS ARE ENTERED.
                    Dim contactEventAgrs As New ContactsEventAgrs() With {.contactDetailsList = patientContacts}
                    Dim statusContactDetailsEntry As Boolean = addIndividual.ContactDetailsInserted(Me, executeInserts, personalInformation, contactEventAgrs)
                    If statusContactDetailsEntry = True Then
                        log.Info("Successfully created new patient!")
                        Notify.ShowNotification("Patient registration successful!", "Patient Registration", "PatientRegistration", "Successful Registration")
                        Close()
                        Dispose()
                    Else
                        log.Error("Cannot save contact details to server.")
                    End If

                End If
            Else
                'VARIABLE RowsInsertedIndividual SHOULD BE 1 IF THERE IS NO ERROR.
                '1) CHECK FOR CONNECTION WITH SERVER. IF NOT CONNECTED, DISPLAY AN ERROR MESSAGE SAYING, SERVER CONNECTION FAILED, RETRY NEW PATIENT ENTRY.
                If isServerConnectionAvailable = False Then

                    'INITIALISING AN INSTANCE OF THE NOTIFICATION FORM TO PROVIDE NOTOFICATIONS.

                    'SHOWING A POP UP NOTIFICATION
                    Notify.ShowNotification(NotificationMessage:="Server connection could not be established.",
                        NotificationTitle:="Server Communications",
                        NotficationPNG_IconName:="DatabaseDisconnected",
                        Heading:="Connection Failure!")
                End If

            End If
        Catch ex As Exception
            log.Error(ex)  'LOGGING ERROR TO DISK
            MsgBox(String.Format("{0}{1}", ex.Message, vbCrLf))
        End Try
    End Sub

    Private Sub TextEditAddress_LostFocus(sender As Object, e As EventArgs) Handles TextEditAddress.LostFocus
        If Not TextEditAddress.Text = "" Then
            TextEditAddress.Text = TextEditAddress.Text.ToUpper
            personalInformation.Address = TextEditAddress.Text
            ActivateAddressNext()
        End If

    End Sub

    Private Sub TextEditContactDetail_InvalidValue(sender As Object, e As InvalidValueExceptionEventArgs) Handles TextEditContactDetail.InvalidValue
        'DISPLAYING A TOOLTIP ON THE CROSS ICON TO HELP CORRECT THE ERROR
        e.ErrorText = "Invalid Contact" & vbCrLf & "Enter an Email or phone number."

        'INITIALISING AN INSTANCE OF THE NOTIFICATION FORM TO PROVIDE NOTOFICATIONS.
        Dim Notify As New frmNotification

        'SHOWING A POP UP NOTIFICATION
        Notify.ShowNotification(NotificationMessage:="Invalid contact.Enter a valid Email or phone number.",
            NotificationTitle:="New Patient Entry",
            NotficationPNG_IconName:="LanTech",
            Heading:="Invalid Contact Details !")
    End Sub

    Private Sub TextEditContactDetail_LostFocus(sender As Object, e As EventArgs) Handles TextEditContactDetail.LostFocus
        'INITAILIZING VALIDATION. THIS WOULD RAISE THE EVENT "VALIDATING" WHICH WOULD HAVE THE CODE TO VALIDATE THE
        'USER ENTRY
        TextEditContactDetail.DoValidate()
    End Sub

    Private Sub TextEditContactDetail_Validating(sender As Object, e As CancelEventArgs) Handles TextEditContactDetail.Validating
        'INITAILIZING COMBOBOX "cboContactType" AS NOTHING
        ComboBoxEditContactType.EditValue = ""

        'INITIALISING VARIABLES

        'VALIDATING DATA ENTRY TO THE TEXTBOX "txtContactDetail"
        'IN ADDITION TO VALIDATION, THIS CODE SEGMENT WILL ALSO BE USED TO AUTO DETECT MOBILE NUMBER AND EMAIL ADDRESS AND SELECT THE
        'APPROPRIATE INDEX FOR THE COMBOBOX "cboContactType"
        Try
            Select Case True
                Case ValidateLocalMobileNumbers(TextEditContactDetail.Text)
                    ComboBoxEditContactType.SelectedIndex = 0

                Case ValidateLocalLandLines(TextEditContactDetail.Text)
                    ComboBoxEditContactType.SelectedIndex = 2

                Case ValidateEmail(TextEditContactDetail.Text)
                    ComboBoxEditContactType.SelectedIndex = 3

                Case Else
                    'DISPLAYING CROSS ICON TO INDICATE THAT THE ENTRY IS INVALID
                    e.Cancel = True
                    TextEditContactDetail.ToolTipTitle = "Contact Detail"
                    TextEditContactDetail.ToolTip = "Enter an email or a phone number."

            End Select
        Catch ex As Exception
            'DSPLAYING ERRORS., IF ANY
            log.Error(ex)  'LOGGING ERROR TO DISK
            MsgBox(ex.Message)
        Finally
            If e.Cancel = False Then
                'IF REGEX VALIDATED AND DETECTED THE ENTRY AS CONTACT, ADD BUTTON IS FOCUSED.
                SimpleButtonAdd.Focus()
            End If
        End Try
    End Sub

    Private Sub TextEditDateOfBirth_LostFocus(sender As Object, e As EventArgs) Handles TextEditDateOfBirth.LostFocus
        'CALCULATING AGE TO BE DISPLAYED AS A VERIFICATION THAT CORRECT DOB WAS ENTERED

        If TextEditDateOfBirth.Text = "" Or TextEditDateOfBirth.Text = Nothing Then
            'IGNORE
        Else
            Dim Dob As Date = Convert.ToDateTime(TextEditDateOfBirth.Text)
            GetAgeFromDob(Dob)
        End If

        'CHECKING TO SEE WHETHER ALL FIELDS ARE COMPLETE
        PesonalInfoNextEnabledStatusHandler()
    End Sub

    Private Sub TextEditHospitalNumber_InvalidValue(sender As Object, e As InvalidValueExceptionEventArgs) Handles TextEditHospitalNumber.InvalidValue
        'DISPLAYING A TOOLTIP ON THE CROSS ICON TO HELP CORRECT THE ERROR
        e.ErrorText = "Invalid Hospital Number" & vbCrLf & "Valid between 1 and 2147483648"
    End Sub

    Private Sub TextEditHospitalNumber_LostFocus(sender As Object, e As EventArgs) Handles TextEditHospitalNumber.LostFocus
        TextEditHospitalNumber.DoValidate()
        PesonalInfoNextEnabledStatusHandler()
    End Sub

    Private Sub TextEditHospitalNumber_Validating(sender As Object, e As CancelEventArgs) Handles TextEditHospitalNumber.Validating

        Try
            isHospitalNumberValid = ValidateHospitalNumber(TextEditHospitalNumber.Text)
        Catch ex As ArgumentException
            log.Error(ex)  'LOGGING ERROR TO DISK
            MsgBox(ex.Message)
        Finally
            If isHospitalNumberValid = False Then
                'SHOWING AN ICON INDICATING THAT THE VALUE ENTERED IS INVALID
                e.Cancel = True
                'TEXTBOX TOOLTIP HELP FOR THE CORRECT ENTRY
                TextEditHospitalNumber.ToolTipTitle = "Invalid Hospital Number"
                TextEditHospitalNumber.ToolTip = "Valid between 1 and 2147483648"

                'INITIALISING AN INSTANCE OF THE NOTIFICATION FORM TO PROVIDE NOTOFICATIONS.
                Dim Notify As New frmNotification

                'SHOWING A POP UP NOTIFICATION
                Notify.ShowNotification(NotificationMessage:="Invalid Hospital Number. Valid between 1 and 2147483648",
                    NotificationTitle:="New Patient Entry",
                    NotficationPNG_IconName:="LanTech",
                    Heading:="Invalid Hospital Number !")
            End If
        End Try

    End Sub

    Private Sub TextEditNid_InvalidValue(sender As Object, e As InvalidValueExceptionEventArgs) Handles TextEditNid.InvalidValue
        e.ErrorText = "Invalid ID Card Number" & vbCrLf & "Format: A012345 or BO01012345"

        'INITIALISING AN INSTANCE OF THE NOTIFICATION FORM TO PROVIDE NOTOFICATIONS.
        Dim Notify As New frmNotification

        'SHOWING A POP UP NOTIFICATION
        Notify.ShowNotification(NotificationMessage:="Invalid ID Card Number. Correct format: A012345 or BO01012345",
        NotificationTitle:="New Patient Entry",
        NotficationPNG_IconName:="LanTech",
        Heading:="Invalid ID !")
        'TextEditNid.SelectAll()
    End Sub

    Private Sub TextEditNid_LostFocus(sender As Object, e As EventArgs) Handles TextEditNid.LostFocus

        If Not TextEditNid.Text = "" Then
            'National ID may be entered with a lower case "a". Eg: a309254 while it should be like "A309254"
            TextEditNid.Text = Trim(TextEditNid.Text)
            TextEditNid.Text = TextEditNid.Text.ToUpper

            'VALIDATE National ID Card Number
            TextEditNid.DoValidate()

            'CHECKING TO SEE WHETHER ALL FIELDS ARE COMPLETE
            PesonalInfoNextEnabledStatusHandler()

        End If
    End Sub

    Private Sub TextEditNid_Validating(sender As Object, e As CancelEventArgs) Handles TextEditNid.Validating

        isNationalIdValid = ValidateNationalId(TextEditNid.Text)

        'USER FEEDBACK FOR INVALID IDCARD NUMBER ENTRIES IS GIVEN BY DISPLAYING A RED CROSS ICON WITH TOOLTIP
        If isNationalIdValid = True Then
            TextEditNid.ShowToolTips = False
            'CHECKING SERVER FOR THE PRESENCE OF THE ID CARD NUMBER WHICH WOULD INDICATE THAT THE PATIENT IS ALREADY REGISTERED.
            isNidRegistered = checkValuePresence.IsFieldValuePresent("Individuals", "NidCardNumber", TextEditNid.Text)
            If isNidRegistered = 0 Then
                'IGNORE
            ElseIf isNidRegistered = 1 Then
                MsgBox("Patient is already registered! Do you want to edit patient data?", vbYesNo, "Registered Patient")
                TextEditNid.Text = ""
                TextEditNid.Focus()
            ElseIf isNidRegistered > 1 Then
                MsgBox("Duplicate records exist for this patient! Please contact systems administrator immediately.", vbCritical, "Warning")
            End If
        Else
            e.Cancel = True
            TextEditNid.ShowToolTips = True                          'SETTING UP A TOOLTIP.
            TextEditNid.ToolTipTitle = "Invalid ID Card Number"
            TextEditNid.ToolTip = "Format: A012345 or BO01012345"

        End If

    End Sub

    Private Sub TextEditPatientName_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextEditPatientName.EditValueChanged

        'INDIVIDUAL NAMES ARE REQUIRED TO BE ALL CAPITALS. THIS WOULD AVOID DUBLICATE INDIVIDUAL NAMES IN BIG AND LITTLE LETTERS.
        'ON EDITVALUECHANGED: ALL TEXT IN THE TEXTBOX IS SET TO UPPER I.E. CAPITALS
        TextEditPatientName.Text = TextEditPatientName.Text.ToUpper

    End Sub

    Private Sub TextEditPatientName_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TextEditPatientName.LostFocus

        If Not TextEditPatientName.Text = "" Then
            'SPLITTING FULL NAME INTO INDIVIDUAL NAMES & GETTING RID OF ANY MULTIPLE SPACES IN BETWEEN THE NAMES. TRIM THE RETURN TO REMOVE TRAILING SPACES
            TextEditPatientName.Text = Trim(RemoveMultipleSpacesInPatientName(TextEditPatientName.Text))

            'SET PatientName ARRAY LENGTH AND ASSIGN INDIVIDUAL NAMES TO THE STRING ARRAY PatientName
            personalInformation.IndividualNameCollection() = TextEditPatientName.Text.Split(delimiter)
            'Todo: remove the following after checking for dependencies. It's a property and can be accessed anytime. Does not have to be assigned to a variable.
            personalInformation.NumberIndividualNames = personalInformation.IndividualNameCollection.Length

            'UPDATING PATIENT DETAILS SUMMARY LABEL WITH NAME
            personalInformation.FinalPatientName = TextEditPatientName.Text
            RaiseEvent SummaryDisplayUpdating(Me, personalInformation)                      'UPDATING THE LABEL

            'CHECKING TO SEE WHETHER ALL FIELDS ARE COMPLETE
            PesonalInfoNextEnabledStatusHandler()
        Else
            'IGNORE IF THE FIELD IS EMPTY
        End If

    End Sub

    Private Sub UpdateSummaryDisplay(sender As Object, e As AddPatientEventArgs) Handles Me.SummaryDisplayUpdating
        LabelSummary.Text = String.Format("[#{0}],[{1}], [{2}/{3}], [{4}  {5}. {6}], [{7}]", e.NextHospitalNumber, e.FinalPatientName, e.PatientAge, e.PatientGender, e.Address, e.Atoll, e.Island, e.Country)
    End Sub

    Private Sub XTabAddPatientRecords_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xTabAddPatientRecords.SelectedPageChanged
        'RENAMING GrpPatientDetails.Text ACCORING TO THE XTABPAGE SELECTED.
        '       "ADD NEW PATIENT: PERSONAL INFORMATION"
        '       "ADD NEW PATIENT: ADDRESS"
        '       "ADD NEW PATIENT: CONTACT DETAILS"

        If xTabAddPatientRecords.SelectedTabPage.Text = xTabPagePersonalInfo.Text Then
            GroupPatientDetails.Text = "ADD NEW PATIENT: PERSONAL INFORMATION"
        ElseIf xTabAddPatientRecords.SelectedTabPage.Text = xTabPageAddress.Text Then
            GroupPatientDetails.Text = "ADD NEW PATIENT: ADDRESS"
        ElseIf xTabAddPatientRecords.SelectedTabPage.Text = xTabPageContactInfo.Text Then
            GroupPatientDetails.Text = "ADD NEW PATIENT: CONTACT DETAILS"

        End If
    End Sub

End Class