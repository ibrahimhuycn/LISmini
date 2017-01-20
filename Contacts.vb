Public Class Contacts
    'THIS CLASS IS USED IN PATIENT REGISTRATION TO TEMPORARILY STORE EMAILS, MOBILE AND TELEPHONE NUMBERS AND SO ON BEFORE UPDATING THE DATABASE.
    'THIS IS A WRAPPER FOR A STRING ARRAY OF THE ABOVE MENTIONED DATA TO ACT AS A DATASOURCE FOR  frmAddPatient.GridControl1

    'AUTHOR: IBRAHIM HUSSAIN
    'SWAT INC.
    Public Sub New(ContactDetail As String, ContactType As String)
        Contact_Detail = ContactDetail
        Contact_Type = ContactType

    End Sub
    Public Property Contact_Detail() As String
    Public Property Contact_Type() As String
End Class
