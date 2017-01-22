Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors.Controls

Public Class frmAddPatient

    'Variables to move the form by grabbing GroupControl "gcAnalysisRequest"
    Dim DRAG_ANALYSIS_REQUEST As Boolean
    Dim MOUSE_POSITION_X As Integer
    Dim MOUSE_POSITION_Y As Integer

    'SERVER OBJECT INITIALISATION FOR EXECUTING QUERIES
    ReadOnly MsSQLComHandler As New ServerCommunications()


    'TIMER TO INITIATE PERIODIC CHECKS TO SEE WHETHER CONNECTION TO SERVER IS AVAILABLE
    Dim WithEvents CnxMonitor As New Timers.Timer

    'VARIABLE TO STORE NUMBER OF INDIVIDUAL NAMES IN THE FULL NAME. THIS SERVES AS NUMBER OF ITEMS IN THE STRING ARRAY PatientName
    Public NumberIndividualNames As Integer

    'VARIABLES FOR TEMPORARY STORAGE OF PERSONAL DATA FOR ADDING NEW PATIENTS.
    Dim Nid As String
    Dim HospitalNumber As Integer
    Dim IndividualNameCollection() As String
    Dim Gender As Integer   '0 = MALE, 1 = FEMALE, 3 = OTHER, 4 = UNKNOWN
    Dim Dob As Date

    Dim IsNidValid As Boolean   'BOOLEAN STORING WHETHER USER ENTERED IDCARD NUMBER IS VALID
    Dim IsHospitalNumberValid As Boolean    'BOOLEAN STORING WHETHER USER ENTERED HOSPITAL NUMBER NUMBER IS VALID

    'QUERIES SERVER FOR PRESENCE OF THE ID AT TXTNID LOST FOCUS EVENT.
    Dim IsNidRegistered As Integer   '0 = NOT PRESENT  1=PRESENT (REGISTERED)


    'DELIMITER FOR SEPARATING INDIVIDUAL NAMES 
    Const Delimiter As String = " "

    'VARIALBLES TO UPDATE LBLSUMMARY DISPLAY
    Dim NextHospitalNumber As Integer
    Dim FinalPatientName As String
    Dim patientAge As String
    Dim PatientGender As String

    'VARIABLES FOR ADDING PATIENT ADDRESS
    Dim Address As String
    Dim Island As String
    Dim Atoll As String
    Dim Country As String

    'VARIABLES AND INITIALISATIONS FOR CONTACT DETAILS PAGE
    ReadOnly PatientContacts As New List(Of Contacts)()
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'INITIALIZING A TO MONITOR CONNECTION STATUS BY CALLING COM HANDLERS' ISCNXALIVE FUNCTION

        CnxMonitor.Interval = 5000
        CnxMonitor.Enabled = True

        'SETTING GEMERIC LIST AS A DATASOURCE FOR GRIDCONTROLADDCONTACT
        GridControlAddContact.DataSource = PatientContacts


    End Sub
    Private Sub frmAddPatient_Load(sender As Object, e As EventArgs) Handles Me.Load

        'DISABLING CONTROLS TO ENFORCE STANDARDISED WORKFLOW.
        'CONTROLS ARE ENABLED ON REQUIRMENT.
        xTabPagePersonalInfo.Select()
        xTabPageAddress.PageEnabled = False
        xTabPageContactInfo.PageEnabled = True
        btnPersonalInfoNext.Enabled = False
        btnAddressNext.Enabled = False
        lblBackContactInfo.Enabled = False

        'AUTOMATIC "VALIDATING" EVENT IS RAISED ON LOST FOCUS EVENT OF A CONTROL. THIS FIELD REQUIRES VALIDATION ON "EDIT VALUE CHANGED" EVENT
        'SO, "CAUSE VALIDATION" IS DISABLED. VALIDATING EVENT IS RAISED MANUALLY BY CALLING txtNidDoValidate()
        txtNid.CausesValidation = False

        'RENAMING GrpPatientDetails.Text AS 
        ' 'ADD NEW PATIENT: PERSONAL INFORMATION'        SINCE THE TABPAGE SELECTED AS DEFAULT IS THE PERSONAL INFO ENTRY PAGE.
        If xTabAddPatientRecords.SelectedTabPage.Text = xTabPagePersonalInfo.Text Then
            GrpPatientDetails.Text = "ADD NEW PATIENT: PERSONAL INFORMATION"
        End If

        'QUERYING FOR HOSPITAL NUMBER TO BE GIVEN TO NEXT PATIENT & UPDATING PATIENT DETAILS DISPLAY LABEL
        NextHospitalNumber = MsSQLComHandler.GetNextHNo()        'QUERYING
        UpdateSummaryDisplay()                       'UPDATING THE LABEL

        'SETTING FOCUS TO TEXT BOX TXTNID
        txtNid.Focus()
    End Sub
    Private Sub txtPatientName_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPatientName.EditValueChanged
        'INDIVIDUAL NAMES ARE REQUIRED TO BE ALL CAPITALS. THIS WOULD AVOID DUBLICATE INDIVIDUAL NAMES IN BIG AND LITTLE LETTERS.
        'ON EDITVALUECHANGED: ALL TEXT IN THE TEXTBOX IS SET TO UPPER I.E. CAPITALS
        txtPatientName.Text = txtPatientName.Text.ToUpper

    End Sub
    Private Sub btnPesonalInfoNextEnabledStatusHandler()
        If txtNid.Text = "" Or txtPatientName.Text = "" Or cboGender.Text = "" Or txtEditDateOfBirth.Text = "" Or txtEditHospitalNumber.Text = "" _
           Or IsNidValid = False Or IsHospitalNumberValid = False Then
            'btnPersonalInfoNext STAYS DISABLED AS LONG AS ANY OF THE FIELDS ARE EMPTY. ALL FIELDS ARE REQUIRED.
            btnPersonalInfoNext.Enabled = False
        Else
            btnPersonalInfoNext.Enabled = True
        End If

    End Sub
    Private Sub txtNid_LostFocus(sender As Object, e As EventArgs) Handles txtNid.LostFocus

        If Not txtNid.Text = "" Then
            'National ID may be entered with a lower case "a". Eg: a309254 while it should be like "A309254"
            txtNid.Text = Trim(txtNid.Text)
            txtNid.Text = txtNid.Text.ToUpper

            'VALIDATE National ID Card Number
            txtNid.DoValidate()

            'CHECKING TO SEE WHETHER ALL FIELDS ARE COMPLETE
            btnPesonalInfoNextEnabledStatusHandler()

        End If
    End Sub
    Private Sub txtPatientName_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtPatientName.LostFocus

        Dim IndividualNameCollection_Temp() As String
        Dim INameCounter As Integer = 0
        If txtPatientName.Text = "" Then
            'IGNORE IF THE FIELD IS EMPTY
        Else

            'SPLITTING FULL NAME INTO INDIVIDUAL NAMES, & GETTING RID OF ANY MULTIPLE SPACES IN BETWEEN THE NAMES.
            Dim ExcludingMultipleSpaces() As String = txtPatientName.Text.Split(Delimiter)

            'EXCLUDING MULTIPLE SPACES BETWEEN INDIVIDUAL NAMES, IF ANY AND DISPLAYING REMAINDER IN THE TEXTBOX txtPatientName
            Try
                txtPatientName.Text = Nothing
                For Each IndividualName In ExcludingMultipleSpaces
                    If Not IndividualName = "" Then
                        txtPatientName.Text = String.Format("{0} {1}", txtPatientName.Text, IndividualName)
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'TRIM THE NAME SO THAT THERE ARE NO SPACES AT THE BEGINNING OR THE END. THIS WILL BE DONE ON THE SERVER SIDE TOO, TO AVOID DUBLICATE INDIVIDUAL NAMES
            'WITH SPACES JUST INCASE THIS STEP IS MISSED IN THE SOFTWARE CODING.
            txtPatientName.Text = Trim(txtPatientName.Text)

            'SET PatientName ARRAY LENGTH AND ASSIGN INDIVIDUAL NAMES TO THE STRING ARRAY PatientName
            IndividualNameCollection_Temp = txtPatientName.Text.Split(Delimiter)
            NumberIndividualNames = IndividualNameCollection_Temp.Length
            ReDim IndividualNameCollection(NumberIndividualNames - 1)

            For Each IndividualName In IndividualNameCollection_Temp

                IndividualNameCollection(INameCounter) = IndividualName
                INameCounter = INameCounter + 1

            Next


            'UPDATING PATIENT DETAILS SUMMARY LABEL WITH NAME
            FinalPatientName = txtPatientName.Text
            UpdateSummaryDisplay()

            'CHECKING TO SEE WHETHER ALL FIELDS ARE COMPLETE
            btnPesonalInfoNextEnabledStatusHandler()

        End If

    End Sub
    Private Sub cboGender_LostFocus(sender As Object, e As EventArgs) Handles cboGender.LostFocus
        'CHECKING TO SEE WHETHER ALL FIELDS ARE COMPLETE
        btnPesonalInfoNextEnabledStatusHandler()

        'UPDATING PATIENT DETAILS DISPLAY LABEL
        'COMBOBOX INDEXES 0 = MALE 1 = FEMALE 2 = OTHER  3 = UNKNOWN
        If cboGender.SelectedIndex = 0 Then
            PatientGender = "M"
        ElseIf cboGender.SelectedIndex = 1 Then
            PatientGender = "F"
        ElseIf cboGender.SelectedIndex = 2
            PatientGender = "O"
        ElseIf cboGender.SelectedIndex = 3
            PatientGender = "U"

        End If
        UpdateSummaryDisplay()

    End Sub
    Private Sub txtEditDateOfBirth_LostFocus(sender As Object, e As EventArgs) Handles txtEditDateOfBirth.LostFocus
        'CALCULATING AGE TO BE DISPLAYED AS A VERIFICATION THAT CORRECT DOB WAS ENTERED


        If txtEditDateOfBirth.Text = "" Or txtEditDateOfBirth.Text = Nothing Then
            'IGNORE
        Else
            Dim Dob As Date = Convert.ToDateTime(txtEditDateOfBirth.Text)
            CalculateAge(Dob)
        End If



        'CHECKING TO SEE WHETHER ALL FIELDS ARE COMPLETE
        btnPesonalInfoNextEnabledStatusHandler()
    End Sub
    Private Sub xTabAddPatientRecords_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xTabAddPatientRecords.SelectedPageChanged
        'RENAMING GrpPatientDetails.Text ACCORING TO THE XTABPAGE SELECTED.
        '       "ADD NEW PATIENT: PERSONAL INFORMATION"
        '       "ADD NEW PATIENT: ADDRESS"
        '       "ADD NEW PATIENT: CONTACT DETAILS"

        If xTabAddPatientRecords.SelectedTabPage.Text = xTabPagePersonalInfo.Text Then
            GrpPatientDetails.Text = "ADD NEW PATIENT: PERSONAL INFORMATION"
        ElseIf xTabAddPatientRecords.SelectedTabPage.Text = xTabPageAddress.Text Then
            GrpPatientDetails.Text = "ADD NEW PATIENT: ADDRESS"
        ElseIf xTabAddPatientRecords.SelectedTabPage.Text = xTabPageContactInfo.Text Then
            GrpPatientDetails.Text = "ADD NEW PATIENT: CONTACT DETAILS"

        End If
    End Sub
    Private Sub btnPersonalInfoNext_Click(sender As Object, e As EventArgs) Handles btnPersonalInfoNext.Click

        Try
            'CLEAR TEMP STORE VARIABLES FOR PERSONAL DATA ASSUMING THAT THEY MIGHT HAVE PREVIOUSLY ASSIGNED VALUES INCASE USER COMES BACK TO PERSONAL INFO PAGE
            'FOR EDITING DATA ENTERED.
            Nid = Nothing
            'PatientName = Nothing
            Gender = Nothing
            Dob = Nothing
            HospitalNumber = Nothing

            'VALIDATE(PREFERRABLY VALIDATE INDIVIDUAL FIELDS ON THEIR RESPECTIVE LOSTFOCUS EVENTS) AND ASSIGN TO VARIABLES DECLARED AT THE BEGINNING.
            Nid = txtNid.Text
            HospitalNumber = txtEditHospitalNumber.Text
            'VALUES FOR THE ARRAY IndividualNameCollection IS ASSIGNED ON LOST FOCUS EVENT OF THE TXTPATENTNAME OBJECT. 
            Gender = cboGender.SelectedIndex

            Dob = txtEditDateOfBirth.Text

            'ENABLE AND SET FOCUS TO xTabPageAddress
            xTabPageAddress.PageEnabled = True

            xTabPageAddress.Select()
            txtAddress.Focus()
            xTabPagePersonalInfo.PageEnabled = False
            xTabPageContactInfo.PageEnabled = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'FETCH ATOLL DATA FROM SERVER BY EXECUTING A DATAREADER FOR THE ADDRESS TAB
        cboAtoll.Properties.Items.Clear()
        Dim AtollList() As String = MsSQLComHandler.ExecuteMsSQLReader("AtollAbbrv", "islandlist", False, "", True, True, "AtollAbbrv", True)

        For Each Atoll In AtollList         'ADDING ATOLL LIST TO COMBOBOX LIST ITEM
            cboAtoll.Properties.Items.Add(Atoll)
        Next
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'ASSUMING THAT USER HAS TO EDIT SOME DATA AT PERSONAL INFORMATION XTAB
        xTabPagePersonalInfo.PageEnabled = True
        xTabPagePersonalInfo.Select()
        xTabPageAddress.PageEnabled = False
        xTabPageContactInfo.PageEnabled = False

    End Sub
    Private Sub txtNid_Validating(sender As Object, e As CancelEventArgs) Handles txtNid.Validating

        'USING REGEX.ISMATCH (LIKE AN INPUT MASK) TO CHECK WHETHER THE TXTINPUT AT TXTNID MATCHES THE FORMATS
        '1) A309254  NORMAL FORMAT FOR IDCARD.
        '2) BO01309254 FOR BABY WHOSE ID CARD HAS NOT BEEN MADE YET. "BO" STANDS FOR BABY OF. 01 INDICATES THAT ITS THE FIRST BABY OF THE MOTHER. AND
        '   309254 IS THE ID CARD NUMBER OF THE MOTHER.

        'USING REGEX REQUIRES Imports System.Text.RegularExpressions. REGEX STANDS FOR REGULAR EXPRESSIONS.
        IsNidValid = Regex.IsMatch(txtNid.Text, "^A[0-9]\d{5}$") Or Regex.IsMatch(txtNid.Text, "^BO[0-9]\d{7}$")

        'USER FEEDBACK FOR INVALID IDCARD NUMBER ENTRIES IS GIVEN BY DISPLAYING A RED CROSS ICON WITH TOOLTIP 
        If IsNidValid = True Then
            txtNid.ShowToolTips = False
            'CHECKING SERVER FOR THE PRESENCE OF THE ID CARD NUMBER WHICH WOULD INDICATE THAT THE PATIENT IS ALREADY REGISTERED.
            IsNidRegistered = MsSQLComHandler.IsFieldValuePresent("Individuals", "NidCardNumber", txtNid.Text)
            If IsNidRegistered = 0 Then
                'IGNORE
            ElseIf IsNidRegistered = 1 Then
                MsgBox("Patient is already registered! Do you want to edit patient data?", vbYesNo, "Registered Patient")
                txtNid.Text = ""
                txtNid.Focus()
            ElseIf IsNidRegistered > 1 Then
                MsgBox("Dublicate records exist for this patient! Please contact systems administrator immediately.", vbCritical, "Warning")
            End If
        Else
            e.Cancel = True
            txtNid.ShowToolTips = True                          'SETTING UP A TOOLTIP.
            txtNid.ToolTipTitle = "Invalid ID Card Number"
            txtNid.ToolTip = "Format: A012345 or BO01012345"

        End If

    End Sub
    Private Sub txtNid_InvalidValue(sender As Object, e As InvalidValueExceptionEventArgs) Handles txtNid.InvalidValue
        e.ErrorText = "Invalid ID Card Number" & vbCrLf & "Format: A012345 or BO01012345"
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
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub UpdateSummaryDisplay()
        lblSummary.Text = String.Format("#{0}, {1}, {2}/{3}", NextHospitalNumber, FinalPatientName, patientAge, PatientGender)
    End Sub
    Private Sub CnXMonitor_Tick(sender As Object, e As EventArgs) Handles CnxMonitor.Elapsed
        Try

            MsSQLComHandler.IsServerAccessAvailable()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtAddress_LostFocus(sender As Object, e As EventArgs) Handles txtAddress.LostFocus
        If Not txtAddress.Text = "" Then
            ActivateAddressNext()
            txtAddress.Text = txtAddress.Text.ToUpper
        End If

    End Sub

    Private Sub txtIsland_LostFocus(sender As Object, e As EventArgs) Handles cboIsland.LostFocus
        If Not cboIsland.Text = "" Then ActivateAddressNext()

    End Sub

    Private Sub txtAtoll_LostFocus(sender As Object, e As EventArgs) Handles cboAtoll.LostFocus

        Dim Island As String
        cboIsland.Properties.Items.Clear()

        If Not cboAtoll.Text = "" Then
            Dim IslandList() As String = MsSQLComHandler.ExecuteMsSQLReader("island", "islandlist", True, String.Format("AtollAbbrv = '{0}'", cboAtoll.Text), True, True, "island", True)
            For Each Island In IslandList
                cboIsland.Properties.Items.Add(Island)
            Next
            ActivateAddressNext()
        End If
    End Sub

    Private Sub cboCountry_LostFocus(sender As Object, e As EventArgs) Handles cboCountry.LostFocus
        If Not cboCountry.Text = "" Then ActivateAddressNext()
    End Sub
    Private Sub ActivateAddressNext()
        If txtAddress.Text = "" Or cboIsland.Text = "" Or cboAtoll.Text = "" Or cboCountry.Text = "" Then
            'IGNORE
        Else
            btnAddressNext.Enabled = True 'IF ALL THE FIELDS ARE COMPLETED, ACTIVATE NEXT BUTTON.
            Address = txtAddress.Text
            Island = cboIsland.Text
            Atoll = cboAtoll.Text
            Country = cboCountry.Text
        End If
    End Sub

    Private Sub btnAddressNext_Click(sender As Object, e As EventArgs) Handles btnAddressNext.Click
        ActivateAddressNext()
        xTabPageContactInfo.PageEnabled = True
        xTabPageContactInfo.Focus()
        xTabPageAddress.PageEnabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        'GRIDVIEW REQUIRES TO BE BOUND TO SOME SORTA DATA SOURCE FOR IT TO HAVE EVEN THE MOST BASIC FUNCTION
        'MAKE A WRAPPER TO WRAP A STRING ARRAY TO STORE CONTACT AND CORRESPONG CONTACT UNTIL THEY ARE WRITTEN TO SERVER.
        'THIS STEP WILL BE IMPLEMENTED IN A NEW CLASS.

        PatientContacts.Add(New Contacts(txtContactDetail.Text, cboContactType.Text))
        GridControlAddContact.DataSource = Nothing
        GridControlAddContact.DataSource = PatientContacts

        'THIS WRAPPED DATA STRING ARRAY WILL BE ASSIGNED TO THE GRIDCONTROL.DATASOURCE PROPERTY.
        'EVERYTIME THE STRING ARRAY CHANGES. DATASOURCE NEEDS TO UNASSIGNED AND THEN ASSIGNED TO GRIDCONTROL TO DISPLAY THE
        'CHANGES. THIS NEEDS TO BE IMPROVED GREATLY.



        'VALIDATE THE CONTACT DETAILS USING REGEX
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'REMOVE SELECTED ROWS RECORDS FROM GRIDVIEWADDCONTACT
        Try
            GridViewAddContact.DeleteSelectedRows()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GrpPatientDetails_MouseDown(sender As Object, e As MouseEventArgs) Handles GrpPatientDetails.MouseDown
        'DRAG_ANALYSIS_REQUEST handles an IF CONDITION at mouse move event. If DRAG_ANALYSIS_REQUEST is true, 
        ' and if mouse button.left is down, form is moved with cursor
        If e.Button = MouseButtons.Left Then
            DRAG_ANALYSIS_REQUEST = True
            MOUSE_POSITION_X = Cursor.Position.X - Me.Left
            MOUSE_POSITION_Y = Cursor.Position.Y - Me.Top
        End If
    End Sub

    Private Sub GrpPatientDetails_MouseMove(sender As Object, e As MouseEventArgs) Handles GrpPatientDetails.MouseMove
        If DRAG_ANALYSIS_REQUEST = True Then
            Top = Cursor.Position.Y - MOUSE_POSITION_Y
            Left = Cursor.Position.X - MOUSE_POSITION_X
        End If
    End Sub

    Private Sub GrpPatientDetails_MouseUp(sender As Object, e As MouseEventArgs) Handles GrpPatientDetails.MouseUp
        'Setting Drag Analysis Request as false on MouseUp event prevents the form being moved when the user is not
        'holding the mouse down.
        DRAG_ANALYSIS_REQUEST = False
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Close()
    End Sub

    Private Sub txtEditHospitalNumber_LostFocus(sender As Object, e As EventArgs) Handles txtEditHospitalNumber.LostFocus
        txtEditHospitalNumber.DoValidate()
        btnPesonalInfoNextEnabledStatusHandler()
    End Sub

    Private Sub txtEditHospitalNumber_Validating(sender As Object, e As CancelEventArgs) Handles txtEditHospitalNumber.Validating

        'VALIDATING HOSPITAL NUMBER
        Try
            'SQL SERVER HAS IdIndividual(USED AS HOSPITAL NUMBER) SET AS INT WHICH IS ACCEPTABLE BETWEEN 0 AND 2147483648 EXCLUSIVELY.
            'HOSPITAL NUMBER CANNOT BE A NEGATIVE INTEGER.
            IsHospitalNumberValid = Regex.IsMatch(txtEditHospitalNumber.Text, "^(?:214748364[0-7]|21474836[0-3][0-9]|2147483[0-5][0-9]{2}|214748[0-2][0-9]{3}|21474[0-7][0-9]{4}|2147[0-3][0-9]{5}|214[0-6][0-9]{6}|21[0-3][0-9]{7}|20[0-9]{8}|1[0-9]{9}|[1-9][0-9]{1,8}|[1-9])$", RegexOptions.Multiline)
        Catch ex As ArgumentException
            MsgBox(ex.Message)
        Finally
            If IsHospitalNumberValid = False Then
                'SHOWING AN ICON INDICATING THAT THE VALUE ENTERED IS INVALID
                e.Cancel = True
                'TEXTBOX TOOLTIP HELP FOR THE CORRECT ENTRY
                txtEditHospitalNumber.ToolTipTitle = "Invalid Hospital Number"
                txtEditHospitalNumber.ToolTip = "Valid between 1 and 2147483648"
            End If
        End Try


    End Sub
    Private Sub txtEditHospitalNumber_InvalidValue(sender As Object, e As InvalidValueExceptionEventArgs) Handles txtEditHospitalNumber.InvalidValue
        'DISPLAYING A TOOLTIP ON THE CROSS ICON TO HELP CORRECT THE ERROR
        e.ErrorText = "Invalid Hospital Number" & vbCrLf & "Valid between 1 and 2147483648"
    End Sub

    Private Sub txtContactDetail_LostFocus(sender As Object, e As EventArgs) Handles txtContactDetail.LostFocus
        'INITAILIZING VALIDATION. THIS WOULD RAISE THE EVENT "VALIDATING" WHICH WOULD HAVE THE CODE TO VALIDATE THE 
        'USER ENTRY
        txtContactDetail.DoValidate()
    End Sub

    Private Sub txtContactDetail_Validating(sender As Object, e As CancelEventArgs) Handles txtContactDetail.Validating
        'INITIALISING VARIABLES

        Dim DetectValidateMobileNumberOptionZero As Boolean = False
        Dim DetectValidateMobileNumberOptionOne As Boolean = False
        Dim DetectValidateHomePhone As Boolean = False
        Dim DetectValidateEmail As Boolean = False

        'INITAILIZING COMBOBOX "cboContactType" AS NOTHING
        cboContactType.EditValue = ""

        'VALIDATING DATA ENTRY TO THE TEXTBOX "txtContactDetail"
        'IN ADDITION TO VALIDATION, THIS CODE SEGMENT WILL ALSO BE USED TO AUTO DETECT MOBILE NUMBER AND EMAIL ADDRESS AND SELECT THE 
        'APPROPRIATE INDEX FOR THE COMBOBOX "cboContactType"
        'REGEX INTERNATIONAL MOBILE NUMBERS: ^\+?(d+[- ])?\d{10}$ OR ^(d+[- ])?\d{7}$
        'REGEX EMAIL ADDRESS: \b[!#$%&'*+./0-9=?_`a-z{|}~^-]+@[.0-9a-z-]+\.[a-z]{2,6}\b

        DetectValidateMobileNumberOptionZero = Regex.IsMatch(txtContactDetail.Text, "^9|7\+?(d+[- ])?\d{9}$")
        DetectValidateMobileNumberOptionOne = Regex.IsMatch(txtContactDetail.Text, "^9|7(d+[- ])?\d{6}$")
        DetectValidateHomePhone = Regex.IsMatch(txtContactDetail.Text, "^(\+[1-9][0-9]*(\([0-9]*\)|-[0-9]*-))?[0]?[1-9][0-9\- ]*$")
        DetectValidateEmail = Regex.IsMatch(txtContactDetail.Text, "\b[!#$%&'*+./0-9=?_`a-z{|}~^-]+@[.0-9a-z-]+\.[a-z]{2,6}\b", RegexOptions.IgnoreCase)

        Try
            If DetectValidateMobileNumberOptionZero = True Or DetectValidateMobileNumberOptionOne = True Then
                cboContactType.SelectedIndex = 0
            ElseIf DetectValidateHomePhone = True Then
                cboContactType.SelectedIndex = 2
            ElseIf DetectValidateEmail = True Then
                cboContactType.SelectedIndex = 3
            Else
                'DISPLAYING CROSS ICON TO INDICATE THAT THE ENTRY IS INVALID
                e.Cancel = True
                txtContactDetail.ToolTipTitle = "Contact Detail"
                txtContactDetail.ToolTip = "Enter an email or a phone number."
            End If


        Catch ex As Exception
            'DSPLAYING ERRORS.., IF ANY
            MsgBox(ex.Message)
        Finally
            If e.Cancel = False Then
                'IF REGEX VALIDATED AND DETECTED THE ENTRY AS CONTACT, ADD BUTTON IS FOCUSED.
                btnAdd.Focus()
            End If
        End Try
    End Sub

    Private Sub txtContactDetail_InvalidValue(sender As Object, e As InvalidValueExceptionEventArgs) Handles txtContactDetail.InvalidValue
        'DISPLAYING A TOOLTIP ON THE CROSS ICON TO HELP CORRECT THE ERROR
        e.ErrorText = "Invalid Contact" & vbCrLf & "Enter an Email or phone number."
    End Sub
End Class