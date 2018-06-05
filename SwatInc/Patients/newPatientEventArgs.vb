Namespace SwatInc.Patients

    Public Class NewPatientEventArgs
        Inherits EventArgs

        'VARIABLE TO STORE NUMBER OF INDIVIDUAL NAMES IN THE FULL NAME. THIS SERVES AS NUMBER OF ITEMS IN THE STRING ARRAY PatientName
        Public numberIndividualNames As Integer

        'VARIABLES FOR TEMPORARY STORAGE OF PERSONAL DATA FOR ADDING NEW PATIENTS.
        Public nationalId As String

        Public hospitalNumber As Integer
        Public individualNameCollection() As String
        Public gender As Integer    '0 = MALE, 1 = FEMALE, 3 = OTHER, 4 = UNKNOWN
        Public dob As Date

        'VARIABLES FOR ADDING PATIENT ADDRESS
        Public address As String

        Public island As String
        Public atoll As String
        Public country As String

        'VARIALBLES TO UPDATE LBLSUMMARY DISPLAY
        Public nextHospitalNumber As Integer

        Public finalPatientName As String
        Public patientAge As String
        Public PatientGender As String

        'VARIABLES AND INITIALISATIONS FOR CONTACT DETAILS PAGE
        ReadOnly patientContacts As New List(Of Contacts)()

    End Class

End Namespace