Namespace SwatInc.Patients

    Public Class AddPatientEventArgs
        Inherits EventArgs

        Enum PatientSex
            M
            F
            O
            U
        End Enum

        'VARIABLES FOR ADDING PATIENT ADDRESS
        Public Property Address As String

        Public Property Atoll As String
        Public Property Country As String
        Public Property Dob As Date
        Public Property FinalPatientName As String
        Public Property HospitalNumber As Integer
        Public Property IdCountry As Integer
        Public Property IdIndivdualNames As Integer()
        Public Property IdIslandAndAtoll As Integer
        Property IdPatientGender As Integer    '0 = MALE, 1 = FEMALE, 3 = OTHER, 4 = UNKNOWN
        Public Property IndividualNameCollection As String()
        Public Property Island As String

        'VARIABLES FOR TEMPORARY STORAGE OF PERSONAL DATA FOR ADDING NEW PATIENTS.
        Public Property NationalId As String

        'VARIALBLES TO UPDATE LBLSUMMARY DISPLAY
        Public Property NextHospitalNumber As Integer

        'VARIABLE TO STORE NUMBER OF INDIVIDUAL NAMES IN THE FULL NAME. THIS SERVES AS NUMBER OF ITEMS IN THE STRING ARRAY PatientName
        Public Property NumberIndividualNames As Integer

        Public Property PatientAge As String
        Public Property PatientGender As String     'String representation of gender
    End Class

End Namespace