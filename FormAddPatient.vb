Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors.Controls
Imports LISmini.ErrorCodes.MeaningfulErrorCodes
Imports ServerCommunications
Imports SwatIncNotifications

Public Class FormAddPatient

    'TODO: IMPLEMENT A WAY TO ENTER PASSPORT NUMBER FOR FORIGNERS.
    'MOVE SERVER CONNECTION STATUS CHECKING FUNCTION TO MAIN FORM.
    Dim WithEvents ConnectionMonitor As New Timers.Timer

    Const connectionMonitorInterval As Integer = 3000

    Dim isServerConnectionAvailable As Boolean

    'Variables to move the form by grabbing GroupControl "gcAnalysisRequest"
    Dim dragAnalysisRequest As Boolean

    Dim mousePositionX As Integer
    Dim mousePositionY As Integer

    'SERVER OBJECT INITIALISATION FOR EXECUTING QUERIES
    ReadOnly lisConnectionCheck As New MsSqlConnectionStatus

    ReadOnly getNextHospitalNumber As New GetNextHospitalNumber
    ReadOnly readDatabase As New ExecuteReads
    ReadOnly checkValuePresence As New FieldPopulation
    ReadOnly insertValues As New ExecuteInserts

    'VARIABLE TO STORE NUMBER OF INDIVIDUAL NAMES IN THE FULL NAME. THIS SERVES AS NUMBER OF ITEMS IN THE STRING ARRAY PatientName
    Public numberIndividualNames As Integer

    'VARIABLES FOR TEMPORARY STORAGE OF PERSONAL DATA FOR ADDING NEW PATIENTS.
    Dim nationalId As String

    Dim hospitalNumber As Integer
    Dim individualNameCollection() As String
    Dim gender As Integer   '0 = MALE, 1 = FEMALE, 3 = OTHER, 4 = UNKNOWN
    Dim dob As Date

    Dim isNationalIdValid As Boolean   'BOOLEAN STORING WHETHER USER ENTERED IDCARD NUMBER IS VALID
    Dim isHospitalNumberValid As Boolean    'BOOLEAN STORING WHETHER USER ENTERED HOSPITAL NUMBER NUMBER IS VALID

    'QUERIES SERVER FOR PRESENCE OF THE ID AT TXTNID LOST FOCUS EVENT.
    Dim isNidRegistered As Integer   '0 = NOT PRESENT  1=PRESENT (REGISTERED)

    'DELIMITER FOR SEPARATING INDIVIDUAL NAMES
    Const delimiter As String = " "

    'VARIALBLES TO UPDATE LBLSUMMARY DISPLAY
    Dim nextHospitalNumber As Integer

    Dim finalPatientName As String
    Dim patientAge As String
    Dim PatientGender As String

    'VARIABLES FOR ADDING PATIENT ADDRESS
    Dim address As String

    Dim island As String
    Dim atoll As String
    Dim country As String

    'VARIABLES AND INITIALISATIONS FOR CONTACT DETAILS PAGE
    ReadOnly patientContacts As New List(Of Contacts)()

    'INITIALISATIONS FOR TRACKING AND LOGGING APPLICATION EVENTS, QUERIES, EXCEPTIONS ETC..
    Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(Reflection.MethodBase.GetCurrentMethod().DeclaringType)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'INITIALIZING A TO MONITOR CONNECTION STATUS BY CALLING COM HANDLERS' ISCNXALIVE FUNCTION
        ConnectionMonitor.Interval = connectionMonitorInterval
        ConnectionMonitor.Enabled = True

        'SETTING GENERIC LIST AS A DATASOURCE FOR GRIDCONTROLADDCONTACT
        GridControlAddContact.DataSource = patientContacts

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
        nextHospitalNumber = getNextHospitalNumber.GetNextHNo()        'QUERYING
        UpdateSummaryDisplay()                       'UPDATING THE LABEL

        'SETTING FOCUS TO TEXT BOX TXTNID
        TextEditNid.Focus()
    End Sub

    Private Sub TextEditPatientName_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextEditPatientName.EditValueChanged

        'INDIVIDUAL NAMES ARE REQUIRED TO BE ALL CAPITALS. THIS WOULD AVOID DUBLICATE INDIVIDUAL NAMES IN BIG AND LITTLE LETTERS.
        'ON EDITVALUECHANGED: ALL TEXT IN THE TEXTBOX IS SET TO UPPER I.E. CAPITALS
        TextEditPatientName.Text = TextEditPatientName.Text.ToUpper

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

    Private Sub TextEditPatientName_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TextEditPatientName.LostFocus

        Dim IndividualNameCollection_Temp() As String
        Dim INameCounter As Integer = 0
        If TextEditPatientName.Text = "" Then
            'IGNORE IF THE FIELD IS EMPTY
        Else

            'SPLITTING FULL NAME INTO INDIVIDUAL NAMES, & GETTING RID OF ANY MULTIPLE SPACES IN BETWEEN THE NAMES.
            Dim ExcludingMultipleSpaces() As String = TextEditPatientName.Text.Split(delimiter)

            'EXCLUDING MULTIPLE SPACES BETWEEN INDIVIDUAL NAMES, IF ANY AND DISPLAYING REMAINDER IN THE TEXTBOX txtPatientName
            Try
                TextEditPatientName.Text = Nothing
                For Each IndividualName In ExcludingMultipleSpaces
                    If Not IndividualName = "" Then
                        TextEditPatientName.Text = String.Format("{0} {1}", TextEditPatientName.Text, IndividualName)
                    End If
                Next
            Catch ex As Exception
                log.Error(ex)  'LOGGING ERROR TO DISK
                MsgBox(ex.Message)
            End Try

            'TRIM THE NAME SO THAT THERE ARE NO SPACES AT THE BEGINNING OR THE END. THIS WILL BE DONE ON THE SERVER SIDE TOO, TO AVOID DUBLICATE INDIVIDUAL NAMES
            'WITH SPACES JUST INCASE THIS STEP IS MISSED IN THE SOFTWARE CODING.
            TextEditPatientName.Text = Trim(TextEditPatientName.Text)

            'SET PatientName ARRAY LENGTH AND ASSIGN INDIVIDUAL NAMES TO THE STRING ARRAY PatientName
            IndividualNameCollection_Temp = TextEditPatientName.Text.Split(delimiter)
            numberIndividualNames = IndividualNameCollection_Temp.Length
            ReDim individualNameCollection(numberIndividualNames - 1)

            For Each IndividualName In IndividualNameCollection_Temp

                individualNameCollection(INameCounter) = IndividualName
                INameCounter = INameCounter + 1

            Next

            'UPDATING PATIENT DETAILS SUMMARY LABEL WITH NAME
            finalPatientName = TextEditPatientName.Text
            UpdateSummaryDisplay()

            'CHECKING TO SEE WHETHER ALL FIELDS ARE COMPLETE
            PesonalInfoNextEnabledStatusHandler()

        End If

    End Sub

    Private Sub ComboBoxEditGender_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxEditGender.LostFocus
        'CHECKING TO SEE WHETHER ALL FIELDS ARE COMPLETE
        PesonalInfoNextEnabledStatusHandler()

        'UPDATING PATIENT DETAILS DISPLAY LABEL
        'COMBOBOX INDEXES 0 = MALE 1 = FEMALE 2 = OTHER  3 = UNKNOWN
        If ComboBoxEditGender.SelectedIndex = 0 Then
            PatientGender = "M"
        ElseIf ComboBoxEditGender.SelectedIndex = 1 Then
            PatientGender = "F"
        ElseIf ComboBoxEditGender.SelectedIndex = 2 Then
            PatientGender = "O"
        ElseIf ComboBoxEditGender.SelectedIndex = 3 Then
            PatientGender = "U"

        End If
        UpdateSummaryDisplay()

    End Sub

    Private Sub TextEditDateOfBirth_LostFocus(sender As Object, e As EventArgs) Handles TextEditDateOfBirth.LostFocus
        'CALCULATING AGE TO BE DISPLAYED AS A VERIFICATION THAT CORRECT DOB WAS ENTERED

        If TextEditDateOfBirth.Text = "" Or TextEditDateOfBirth.Text = Nothing Then
            'IGNORE
        Else
            Dim Dob As Date = Convert.ToDateTime(TextEditDateOfBirth.Text)
            CalculateAge(Dob)
        End If

        'CHECKING TO SEE WHETHER ALL FIELDS ARE COMPLETE
        PesonalInfoNextEnabledStatusHandler()
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

    Private Sub SimpleButtonPersonalInfoNext_Click(sender As Object, e As EventArgs) Handles SimpleButtonPersonalInfoNext.Click

        Try
            'CLEAR TEMP STORE VARIABLES FOR PERSONAL DATA ASSUMING THAT THEY MIGHT HAVE PREVIOUSLY ASSIGNED VALUES INCASE USER COMES BACK TO PERSONAL INFO PAGE
            'FOR EDITING DATA ENTERED.
            nationalId = Nothing
            'PatientName = Nothing
            gender = Nothing
            dob = Nothing
            hospitalNumber = Nothing

            'VALIDATE(PREFERRABLY VALIDATE INDIVIDUAL FIELDS ON THEIR RESPECTIVE LOSTFOCUS EVENTS) AND ASSIGN TO VARIABLES DECLARED AT THE BEGINNING.
            nationalId = TextEditNid.Text
            hospitalNumber = TextEditHospitalNumber.Text
            'VALUES FOR THE ARRAY IndividualNameCollection IS ASSIGNED ON LOST FOCUS EVENT OF THE TXTPATENTNAME OBJECT.
            gender = ComboBoxEditGender.SelectedIndex

            dob = TextEditDateOfBirth.Text

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

    Private Sub SimpleButtonBack_Click(sender As Object, e As EventArgs) Handles SimpleButtonBack.Click

        'ASSUMING THAT USER HAS TO EDIT SOME DATA AT PERSONAL INFORMATION XTAB
        xTabPagePersonalInfo.PageEnabled = True
        xTabPagePersonalInfo.Select()
        xTabPageAddress.PageEnabled = False
        xTabPageContactInfo.PageEnabled = False

    End Sub

    Private Sub TextEditNid_Validating(sender As Object, e As CancelEventArgs) Handles TextEditNid.Validating

        'USING REGEX.ISMATCH (LIKE AN INPUT MASK) TO CHECK WHETHER THE TXTINPUT AT TXTNID MATCHES THE FORMATS
        '1) A309254  NORMAL FORMAT FOR IDCARD.
        '2) BO01309254 FOR BABY WHOSE ID CARD HAS NOT BEEN MADE YET. "BO" STANDS FOR BABY OF. 01 INDICATES THAT ITS THE FIRST BABY OF THE MOTHER. AND
        '   309254 IS THE ID CARD NUMBER OF THE MOTHER.

        'USING REGEX REQUIRES Imports System.Text.RegularExpressions. REGEX STANDS FOR REGULAR EXPRESSIONS.
        isNationalIdValid = Regex.IsMatch(TextEditNid.Text, "^A[0-9]\d{5}$") Or Regex.IsMatch(TextEditNid.Text, "^BO[0-9]\d{7}$")

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

    Private Sub CalculateAge(dob As Date)

        Dim AgeYears As Integer
        Dim AgeMonths As Integer
        Dim AgeDays As Integer

        Try

            'A NEONATES' AGE HAS TO BE REPORTED IN MONTHS OR EVEN DAYS.

            AgeYears = Math.Floor(DateDiff(DateInterval.Day, DateValue(dob), Now()) / 365.25)
            AgeMonths = Math.Floor(DateDiff(DateInterval.Day, DateValue(dob), Now()) / 30.4375)
            AgeDays = Math.Floor(DateDiff(DateInterval.Day, DateValue(dob), Now()))

            If AgeYears = 0 And AgeMonths = 0 Then
                patientAge = AgeDays & " D"
            ElseIf AgeYears = 0 And AgeMonths > 0 Then

                Dim RemainingDays As Integer = AgeDays - (AgeMonths * 30.4375)
                patientAge = String.Format("{0} M {1} D", AgeMonths, RemainingDays)
            ElseIf AgeYears > 0 Then
                patientAge = AgeYears & " Y"

            End If

            'UPDATING PATIENT DETAILS DISPLAY LABEL
            UpdateSummaryDisplay()
        Catch ex As Exception
            log.Error(ex)  'LOGGING ERROR TO DISK
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub UpdateSummaryDisplay()
        LabelSummary.Text = String.Format("#{0}, {1}, {2}/{3}", nextHospitalNumber, finalPatientName, patientAge, PatientGender)
    End Sub

    Private Sub TextEditAddress_LostFocus(sender As Object, e As EventArgs) Handles TextEditAddress.LostFocus
        If Not TextEditAddress.Text = "" Then
            ActivateAddressNext()
            TextEditAddress.Text = TextEditAddress.Text.ToUpper
        End If

    End Sub

    Private Sub ComboBoxIsland_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxIsland.LostFocus
        If Not ComboBoxIsland.Text = "" Then ActivateAddressNext()

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
            ActivateAddressNext()
        End If
    End Sub

    Private Sub ComboBoxEditCountry_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxEditCountry.LostFocus
        If Not ComboBoxEditCountry.Text = "" Then ActivateAddressNext()
    End Sub

    Private Sub ActivateAddressNext()
        If TextEditAddress.Text = "" Or ComboBoxIsland.Text = "" Or ComboBoxEditAtoll.Text = "" Or ComboBoxEditCountry.Text = "" Then
            'IGNORE
        Else
            SimpleButtonAddressNext.Enabled = True 'IF ALL THE FIELDS ARE COMPLETED, ACTIVATE NEXT BUTTON.
            address = TextEditAddress.Text
            island = ComboBoxIsland.Text
            atoll = ComboBoxEditAtoll.Text
            country = ComboBoxEditCountry.Text
        End If
    End Sub

    Private Sub SimpleButtonAddressNext_Click(sender As Object, e As EventArgs) Handles SimpleButtonAddressNext.Click
        ActivateAddressNext()
        xTabPageContactInfo.PageEnabled = True
        xTabPageContactInfo.Focus()
        xTabPageAddress.PageEnabled = False
    End Sub

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

    Private Sub SimpleButtonRemoveRemove_Click(sender As Object, e As EventArgs) Handles SimpleButtonRemove.Click
        'REMOVE SELECTED ROWS RECORDS FROM GRIDVIEWADDCONTACT
        Try
            GridViewAddContact.DeleteSelectedRows()
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

    Private Sub TextEditHospitalNumber_LostFocus(sender As Object, e As EventArgs) Handles TextEditHospitalNumber.LostFocus
        TextEditHospitalNumber.DoValidate()
        PesonalInfoNextEnabledStatusHandler()
    End Sub

    Private Sub TextEditHospitalNumber_Validating(sender As Object, e As CancelEventArgs) Handles TextEditHospitalNumber.Validating

        'VALIDATING HOSPITAL NUMBER
        Try
            'SQL SERVER HAS IdIndividual(USED AS HOSPITAL NUMBER) SET AS INT WHICH IS ACCEPTABLE BETWEEN 0 AND 2147483648 EXCLUSIVELY.
            'HOSPITAL NUMBER CANNOT BE A NEGATIVE INTEGER.
            isHospitalNumberValid = Regex.IsMatch(TextEditHospitalNumber.Text, "^(?:214748364[0-7]|21474836[0-3][0-9]|2147483[0-5][0-9]{2}|214748[0-2][0-9]{3}|21474[0-7][0-9]{4}|2147[0-3][0-9]{5}|214[0-6][0-9]{6}|21[0-3][0-9]{7}|20[0-9]{8}|1[0-9]{9}|[1-9][0-9]{1,8}|[1-9])$", RegexOptions.Multiline)
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

    Private Sub TextEditHospitalNumber_InvalidValue(sender As Object, e As InvalidValueExceptionEventArgs) Handles TextEditHospitalNumber.InvalidValue
        'DISPLAYING A TOOLTIP ON THE CROSS ICON TO HELP CORRECT THE ERROR
        e.ErrorText = "Invalid Hospital Number" & vbCrLf & "Valid between 1 and 2147483648"
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
        'REGEX INTERNATIONAL MOBILE NUMBERS: ^\+?(d+[- ])?\d{10}$ OR ^(d+[- ])?\d{7}$
        'REGEX EMAIL ADDRESS: \b[!#$%&'*+./0-9=?_`a-z{|}~^-]+@[.0-9a-z-]+\.[a-z]{2,6}\b

        Dim DetectValidateMobileNumberOptionZero As Boolean = Regex.IsMatch(TextEditContactDetail.Text, "^9|7\+?(d+[- ])?\d{9}$")
        Dim DetectValidateMobileNumberOptionOne As Boolean = Regex.IsMatch(TextEditContactDetail.Text, "^9|7(d+[- ])?\d{6}$")
        Dim DetectValidateHomePhone As Boolean = Regex.IsMatch(TextEditContactDetail.Text, "^(301|330|331|332|333|334|335|339|688|689|690|650|652|652|654|656|658|660|662|664|666|668|670|672|674|676|678|680|682|684|686)+[0-9]{4}$")
        Dim DetectValidateEmail As Boolean = Regex.IsMatch(TextEditContactDetail.Text, "\b[!#$%&'*+./0-9=?_`a-z{|}~^-]+@[.0-9a-z-]+\.[a-z]{2,6}\b", RegexOptions.IgnoreCase)

        Try
            If DetectValidateMobileNumberOptionZero = True Or DetectValidateMobileNumberOptionOne = True Then
                ComboBoxEditContactType.SelectedIndex = 0
            ElseIf DetectValidateHomePhone = True Then
                ComboBoxEditContactType.SelectedIndex = 2
            ElseIf DetectValidateEmail = True Then
                ComboBoxEditContactType.SelectedIndex = 3
            Else
                'DISPLAYING CROSS ICON TO INDICATE THAT THE ENTRY IS INVALID
                e.Cancel = True
                TextEditContactDetail.ToolTipTitle = "Contact Detail"
                TextEditContactDetail.ToolTip = "Enter an email or a phone number."
            End If
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

    Private Sub SimpleButtonSave_Click(sender As Object, e As EventArgs) Handles SimpleButtonSave.Click

        Dim Notify As New frmNotification
        Dim RowsInsertedIndividual As Integer = Nothing
        Dim RowsInsertedNameHandler As Integer = Nothing
        Dim IdIndividualNameArrayLength As Integer
        Dim NameHandlerInsertStatement As String = ""

        Dim TotalRowsInsertedForNewPTEntry As Integer = Nothing
        Dim ExpectedNoRowInsertForNewPTEntry As Integer = Nothing

        '1)GATHERING DATA
        Dim PatientEntryStep As Integer = Nothing   'FOR ERROR HANDLING
        Dim IdIndivdualNames() As Integer = FetchIndividualNameIDs()         'i) INSERT NONEXISTING NAMES AND GET ALL IDs FOR INDIVIDUAL NAMES OF PATIENT
        Dim IdIslandAndAtoll As Integer = FetchIdIslandList()
        Dim IdCountry As Integer = FetchCountryID()

        '2) INSERTING DATA INTO DBO.INDIVIDUALS & NAMEHANDLER
        Try
            'INSERTING DATA INTO DBO.INDIVIDUALS
            PatientEntryStep = 0
            RowsInsertedIndividual = insertValues.NonQueryINSERT(Table:="[dbo].[Individuals]",
                                         InsertValues:=String.Format("('{0}',N'{1}',N'{2}','{3}','{4}','{5}','{6}','{7}')", hospitalNumber, nationalId, dob, address, 1, IdIslandAndAtoll, IdCountry, gender),
                                         Fields:="([Idindividual],[NidCardNumber],[dob],[Address],[IsAlive],[IdIsland],[IdCountry],[IdGender])")
            If RowsInsertedIndividual = 1 Then

                TotalRowsInsertedForNewPTEntry += RowsInsertedIndividual

                ExpectedNoRowInsertForNewPTEntry = 1
                PatientEntryStep = 1

                'INSERTING DATA INTO DBO.NAMEHANDLER
                'i) PARSE INSERT VALUES FOR INSERT QUERY
                IdIndividualNameArrayLength = IdIndivdualNames.Length
                For i = 0 To (IdIndividualNameArrayLength - 1)
                    If i = 0 Then
                        NameHandlerInsertStatement = String.Format("({0},{1},{2})", hospitalNumber, i, IdIndivdualNames(i))
                    ElseIf i > 0 Then
                        NameHandlerInsertStatement = NameHandlerInsertStatement & String.Format(", ({0},{1},{2})", hospitalNumber, i, IdIndivdualNames(i))
                    End If
                Next
                PatientEntryStep = 2

                'ii)EXECUTE INSERT STATEMENT
                RowsInsertedNameHandler = insertValues.NonQueryINSERT(Table:="[dbo].[NameHandler]",
                                              InsertValues:=NameHandlerInsertStatement,
                                              Fields:=String.Format("({0}, {1}, {2})", "[IdIndividual]", "[SortOrder]", "[IdIndividualName]"))
                PatientEntryStep = 3

                'SAVING CONTACT DETAILS TO SERVER | SKIPPING THIS STEP IF NO CONTACT DETAILS ARE ENTERED.
                Dim statusContactDetailsEntry As Integer = ParseAndInsertContactDetails()
                If (statusContactDetailsEntry = ValidOperationSkip) Or (statusContactDetailsEntry = OperationCompletedSuccessfully) Then
                Else
                    log.Error("Cannot save contact details to server.")
                End If
                log.Info("Successfully created new patient!")
                Notify.ShowNotification("Patient registration successful!", "Patient Registration", "PatientRegistration", "Successful Registration")
                Close()
                Dispose()
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

    Private Function FetchIndividualNameIDs()
        'TASK OF THIS FUNCTION: CHECK SERVER FOR THE PRESENCE OF INDIVIDUAL NAMES. IF PRESENT, GET THEIR IDs ELSE EXECUTE AN INSERT QUERY TO ADD THE NON-EXISTANT NAMES
        'AND EXECUTE ANOTHER QUERY TO GET THE IDs.
        'THIS FUNCTION USES ServerCommunications.vb CLASS.

        'GETTING INDIVIDUAL NAMES FROM ARRAY.
        'INITIALISING ALL REQUIRED VARIABLES TO GATHER INFORMATION FROM SERVER.
        Dim i As Integer 'COUNTER VARIABLE FOR LOOP
        Dim ArrayLength As Integer = individualNameCollection.Length   'GETTING ARRAY LENGTH FOR ARRAY HOLDING INDIVIDUAL NAMES
        Dim Individual As String = ""
        Dim IsNamePresentOnServer As Integer
        Dim RetrievedIdIndividualName(ArrayLength - 1) As Integer
        Dim RowsInserted As Integer

        'USING FOR LOOP TO RETRIEVE THE VALUES
        For i = 0 To ArrayLength - 1
            RowsInserted = 0    'INITIALISE VARIABLE EVERYTIME THE QUERY IS RUN.
            Individual = individualNameCollection.GetValue(i)

            'CHECK WHETHER THE INDIVIDUAL NAME IS PRESENT IN THE SERVER. [dbo].[IndividualNames]. THE FOLLOWING QUERY RETURNS THE NUMBER OF TIMES THE EXPECTED VALUE IS PRESENT ON SERVER
            'USING SQL COUNT FUNCTION.
            'THE COLUMN [dbo].[IndividualNames].[Individual] is a UNIQUE FIELD WHICH MEANS THAT THE RESULT WOULD EITHER BE 1 OR 0 INDICATING PRESENCE OR ABSENCE OF THE NAME ON SERVER.

RetryForID: 'FETCHING ID INDIVIDUAL AFTER INSERTING THE INDIVIDUAL NAME TO SERVER.

            IsNamePresentOnServer = checkValuePresence.IsFieldValuePresent("[dbo].[IndividualNames]", "Individual", Individual)
            'IF FIELD IS PRESENT, GET THE IdIndividualName and store it in the an array " Dim IdIndividualNameStore(ArrayLength -1) As Integer".
            'The length of the array would be The number of individual names in the Patient name MINUS ONE

            If IsNamePresentOnServer = 1 Then
                'ONLY THE ID IdIndividual IS RETURNED AND THEREFORE ONLY ONE FIELD WILL BE PRESENT IN THE ARRAY "RetrievedID()". TAKE THE VALUE AT INDEX 0 AND ASSIGN IT TO "RetrievedIdIndividualName"
                Dim RetrievedID() As String = readDatabase.ExecuteMsSQLReader("[IdindividualName] AS IName", "[dbo].[IndividualNames]", True, String.Format("[Individual] = '{0}'", Individual), False, False, "", False, "IName")
                RetrievedIdIndividualName(i) = RetrievedID(0)
            ElseIf IsNamePresentOnServer = 0 Then
                'EXECUTING ExecuteNonQuery TO ADD THE NAME TO SERVER
                RowsInserted = insertValues.NonQueryINSERT("[dbo].[IndividualNames]", String.Format("(N'{0}')", Individual), "([Individual])")
                If RowsInserted = 1 Then
                    GoTo RetryForID
                ElseIf Not RowsInserted = 1 Then
                    MsgBox(String.Format("Error inserting patient name to server.{0}Number of Rows Inserted: {1}", vbCrLf, RowsInserted), vbInformation, "Patient Registration")
                End If
            Else
                MsgBox("An Error occurred while checking for the presence of IndividualNames on server!", vbCritical,)
            End If
        Next
        Return RetrievedIdIndividualName
    End Function

    Private Function FetchIdIslandList()
        'TASK OF THE FUNCTION: GET THE ATOLL AND ISLAND(ATOLL AND ISLAND ID IS JUST ONE VALUE. IdIslandList) ID OF THE PATIENTS ADDRESS AND RETURN IT.

        Dim IdIslandAndAtoll As Integer
        Dim IdIslandAndAtollArray As String() = readDatabase.ExecuteMsSQLReader("[IdIslandList] AS IdIslandAndAtoll", "[dbo].[IslandList]", True, String.Format("[Island]='{0}' AND [AtollAbbrv]='{1}'", island, atoll), False, False, "", False, "IdIslandAndAtoll")

        'THE ARRAY RETURNED WILL HAVE ONLY ONE VALUE AND HENCE THERE IS NO NEED TO ITERATE THROUGH THE ARRAY.
        'GETTING THE 0 INDEX OF THE ARRAY TO AN INTEGER AND RETURNING THE VALUE SHOULD DO THE JOB.
        IdIslandAndAtoll = IdIslandAndAtollArray(0)
        Return IdIslandAndAtoll
    End Function

    Private Function FetchCountryID()

        'TASK FOR THIS FUNCTION: FETCH THE COUNTRY ID FOR THE PATIENTS' COUNTRY.

        Dim CountryID() As String = Nothing
        Dim IdCountry As Integer
        Try
            CountryID = readDatabase.ExecuteMsSQLReader("[IdCountry] as CountryID", "[dbo].[Countries]", True, String.Format("[Countries].[Country] = '{0}'", country),
                                                           False, False, False, False, "CountryID")

            IdCountry = CountryID(0)    'ONLY ONE VALUE WILL BE RETUNED BY MSSQL READER IN THIS CASE AND THEREFORE, ASSIGNING ONLY INDEX 0 IS SUFFICIENT.
        Catch ex As Exception
            log.Error(ex)  'LOGGING ERROR TO DISK
            MsgBox(String.Format("An error occurred while looking up the Country ID for the patient." & vbCrLf & "Error Message: {0}" & vbCrLf & "Error Type: {1}", ex.Message, ex.GetType), vbExclamation,
                   "Patient Registration")
        End Try

        Return IdCountry
    End Function

    Function ParseAndInsertContactDetails()
        'TASK: FETCHING CONTACT DETAILS FROM ARRAY LIST AND ADD THEM TO SERVER.
        '[GETTING CONTACT DETAILS FROM THE CLASS CONTACTS.VB]

        ' VARIBLES FETCHING CONTACT DETAILS FROM ARRAY LIST
        Dim j As Integer = 0  'COUNTER FOR THE LOOP
        Dim ListLength As Integer = patientContacts.Count
        Dim Contact As String
        Dim IdContactType As Integer = Nothing
        Dim Type As String = ""
        Dim ContactsInsertStatement As String = Nothing
        Dim RowsInserted As Integer

        'IF NO CONTACT DETAILS ARE ENTERED, SKIP INSERTING CONTACT DETAILS.
        If Not ListLength = 0 Then
            '1) FETCH THE DETAILS.
            For j = 0 To ListLength - 1
                Contact = patientContacts.Item(j).contactDetail.ToString
                Type = patientContacts.Item(j).contactType

                If Type = "Mobile" Then
                    IdContactType = 1
                ElseIf Type = "Office" Then
                    IdContactType = 2
                ElseIf Type = "Office" Then
                    IdContactType = 2
                ElseIf Type = "Home" Then
                    IdContactType = 3
                ElseIf Type = "Email" Then
                    IdContactType = 4
                Else
                    MsgBox("Invalid Contact Type selected.", vbExclamation, "Patient Registration")
                End If

                '2) PARSING CONTACT DETAILS AS PART OF AN INSERT STATEMENT.
                If j = 0 Then
                    ContactsInsertStatement = String.Format("({0}, {1}, '{2}')", hospitalNumber, IdContactType, Contact)
                ElseIf j > 0 Then
                    ContactsInsertStatement += String.Format(", ({0}, {1}, '{2}')", hospitalNumber, IdContactType, Contact)
                End If

                '3) TRY ADDING THE CONTACT DETAILS TO SERVER.
                If j = ListLength - 1 Then

                    Try
                        'CHECK WHETHER CONTACT TYPE IS A VALID TYPE BY CHECKING WHETHER THE TYPE EXISTS ON SERVER AND FETCH IdContactType TO BE INSERTED INTO CONTACTS TABLE . THIS IS NOT DONE FOR NOW.
                        'THIS PART WILL BE HARDCODED IN SOFTWARE AS FOLLOWS.
                        '1= Mobile 2= Office 3= Home 4 = Email

                        'EXECUTE COMMAND.EXECUTENONQUERY TO INSERY THE CONTACTS.
                        RowsInserted = insertValues.NonQueryINSERT("[dbo].[Contacts]", ContactsInsertStatement)
                    Catch ex As Exception

                        log.Error(ex)  'LOGGING ERROR TO DISK
                        MsgBox(String.Format("An error adding patient contact details to server. Error message: {0}" & vbCrLf & "Error Type: {1}", ex.Message, ex.GetType.ToString), vbInformation, "Patient Registration")
                    End Try

                End If
            Next

            log.Info("Return value from ParseAndInsertContactDetails: " & OperationCompletedSuccessfully.ToString)
            Return OperationCompletedSuccessfully
        Else
            log.Info("Return value from ParseAndInsertContactDetails: " & ValidOperationSkip.ToString)
            Return ValidOperationSkip
        End If

    End Function

End Class