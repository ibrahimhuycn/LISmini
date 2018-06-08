Imports ServerCommunications
Imports SwatIncNotifications
Imports LISmini.ErrorCodes.MeaningfulErrorAndEventCodes

Namespace SwatInc.Patients

    Public Class AddPatients

        'INITIALISATIONS FOR TRACKING AND LOGGING APPLICATION EVENTS, QUERIES, EXCEPTIONS ETC..
        Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(Reflection.MethodBase.GetCurrentMethod().DeclaringType)

        Enum ContactType
            Mobile = 1
            Office = 2
            Home = 3
            Email = 4
        End Enum

        Public Function ContactDetailsInserted(sender As Object, ByVal executeInserts As ExecuteInserts, e As AddPatientEventArgs, f As ContactsEventAgrs) As Boolean

            Dim ContactsInsertStatement As String = Nothing
            Dim RowsInserted As Integer

            'IF NO CONTACT DETAILS ARE ENTERED, SKIP INSERTING CONTACT DETAILS.
            If Not f.contactDetailsList.Count = 0 Then
                ContactsInsertStatement = ParseContactsInsertStatement(e, f)
                Try

                    'TODO: CHECK WHETHER CONTACT TYPE IS A VALID TYPE BY CHECKING WHETHER THE TYPE EXISTS ON SERVER AND FETCH IdContactType TO BE INSERTED INTO CONTACTS TABLE . THIS IS NOT DONE FOR NOW.
                    'ii)EXECUTE INSERT STATEMENT
                    RowsInserted = executeInserts.NonQueryINSERT(Table:="[dbo].[Contacts]",
                                                  InsertValues:=ContactsInsertStatement,
                                                  Fields:=String.Format("({0}, {1}, {2})", "[IdIndividual]", "[IdContactType]", "[Value]"))
                Catch ex As Exception

                    log.Error(ex)  'LOGGING ERROR TO DISK
                    MsgBox(String.Format("An error adding patient contact details to server. Error message: {0}" & vbCrLf & "Error Type: {1}", ex.Message, ex.GetType.ToString), vbInformation, "Patient Registration")
                    Return False
                End Try

                log.Info("Process from ContactDetailsInserted: " & OperationCompletedSuccessfully.ToString)
                log.Info("All contacts rows successfully inserted: " & (If(RowsInserted = f.contactDetailsList.Count, True, False)).ToString)
                Return If(RowsInserted = f.contactDetailsList.Count, True, False)
            Else
                log.Info("Process from ContactDetailsInserted: " & ValidOperationSkip.ToString)
                Return True
            End If

        End Function

        Public Function IndividualInserted(sender As Object, ByVal executeInserts As ExecuteInserts, e As AddPatientEventArgs) As Boolean
            Dim rowsInserted As Integer = 0
            Try
                rowsInserted = executeInserts.NonQueryINSERT(Table:="[dbo].[Individuals]",
                             InsertValues:=String.Format("('{0}',N'{1}',N'{2}','{3}','{4}','{5}','{6}','{7}')", e.HospitalNumber, e.NationalId, e.Dob, e.Address, 1, e.IdIslandAndAtoll, e.IdCountry, e.IdPatientGender),
                             Fields:="([Idindividual],[NidCardNumber],[dob],[Address],[IsAlive],[IdIsland],[IdCountry],[IdGender])")
            Catch ex As Exception
                log.Error(ex)
                Dim notify As New frmNotification
                notify.ShowNotification(ex.Message, "Patient Registration Error", "PatientSavingError", "Patient Registration")
            End Try
            Return If(rowsInserted = 1, True, False)
        End Function

        Public Function NameHandlerValuesInserted(sender As Object, ByVal executeInserts As ExecuteInserts, e As AddPatientEventArgs) As Boolean
            'INSERTING DATA INTO DBO.NAMEHANDLER
            Dim rowsInserted As Integer = 0
            Dim NameHandlerInsertStatement As String = ParseNameHandlerInsertStatement(e)
            Try
                'ii)EXECUTE INSERT STATEMENT
                rowsInserted = executeInserts.NonQueryINSERT(Table:="[dbo].[NameHandler]",
                                              InsertValues:=NameHandlerInsertStatement,
                                              Fields:=String.Format("({0}, {1}, {2})", "[IdIndividual]", "[SortOrder]", "[IdIndividualName]"))
            Catch ex As Exception
                log.Error(ex)
                Dim notify As New frmNotification
                notify.ShowNotification(ex.Message, "Patient Registration Error", "PatientSavingError", "Patient Registration")
            End Try
            Return If(rowsInserted = (e.IdIndivdualNames.Length), True, False)
        End Function

        Private Function GetIdContactType(ByVal contactType As String) As Integer
            '1= Mobile 2= Office 3= Home 4 = Email
            Try
                Return ([Enum].Parse(GetType(ContactType), contactType))
            Catch ex As Exception
                log.Error(ex)
                Throw New ArgumentException("Enum ContactType does not have the member: " & contactType)
            End Try

        End Function

        Private Function ParseContactsInsertStatement(e As AddPatientEventArgs, f As ContactsEventAgrs) As String
            Dim contact As String = Nothing
            Dim type As String
            Dim IdContactType As Integer = Nothing

            '2) PARSING CONTACT DETAILS AS PART OF AN INSERT STATEMENT.
            Dim InsertStatement As String = Nothing
            For j = 0 To f.contactDetailsList.Count - 1
                contact = f.contactDetailsList.Item(j).ContactDetail.ToString
                type = f.contactDetailsList.Item(j).ContactType

                IdContactType = GetIdContactType(type)

                If j = 0 Then
                    InsertStatement = String.Format("({0}, {1}, '{2}')", e.HospitalNumber, IdContactType, contact)
                ElseIf j > 0 Then
                    InsertStatement += String.Format(", ({0}, {1}, '{2}')", e.HospitalNumber, IdContactType, contact)
                End If
            Next

            Return InsertStatement
        End Function

        Private Function ParseNameHandlerInsertStatement(e As AddPatientEventArgs) As String
            'i) PARSE INSERT VALUES FOR INSERT QUERY
            Dim InsertStatement As String = ""

            For IndividualNameSortOrder = 0 To (e.IdIndivdualNames.Length - 1)
                If IndividualNameSortOrder = 0 Then
                    InsertStatement = String.Format("({0},{1},{2})", e.HospitalNumber, IndividualNameSortOrder, e.IdIndivdualNames(IndividualNameSortOrder))
                ElseIf IndividualNameSortOrder > 0 Then
                    InsertStatement = InsertStatement & String.Format(", ({0},{1},{2})", e.HospitalNumber, IndividualNameSortOrder, e.IdIndivdualNames(IndividualNameSortOrder))
                End If
            Next
            Return InsertStatement
        End Function

    End Class

End Namespace