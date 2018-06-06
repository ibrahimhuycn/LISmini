Public Class Contacts
    'THIS CLASS IS USED IN PATIENT REGISTRATION TO TEMPORARILY STORE EMAILS, MOBILE AND TELEPHONE NUMBERS AND SO ON BEFORE UPDATING THE DATABASE.
    'THIS IS A WRAPPER FOR A STRING ARRAY OF THE ABOVE MENTIONED DATA TO ACT AS A DATASOURCE FOR  AddPatient.GridControl1

    'AUTHOR: IBRAHIM HUSSAIN
    'SWAT INC.
    Public Sub New(contactDetail As String, ContactType As String)
        Me.ContactDetail = contactDetail
        Me.ContactType = ContactType
    End Sub

    Public Property ContactDetail() As String
    Public Property ContactType() As String
End Class