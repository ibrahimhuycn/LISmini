Imports ServerCommunications

Namespace SwatInc.Patients

    Public Class PatientInformationCommunications

        'INITIALISATIONS FOR TRACKING AND LOGGING APPLICATION EVENTS, QUERIES, EXCEPTIONS ETC..
        Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(Reflection.MethodBase.GetCurrentMethod().DeclaringType)

        ReadOnly checkValuePresence As New FieldPopulation
        ReadOnly getNextHospitalNumber As New GetNextHospitalNumber
        ReadOnly insertValues As New ExecuteInserts
        ReadOnly readDatabase As New ExecuteReads

        Public Function FetchCountryID(e As AddPatientEventArgs)

            'TASK FOR THIS FUNCTION: FETCH THE COUNTRY ID FOR THE PATIENTS' COUNTRY.

            Dim CountryID() As String = Nothing
            Dim IdCountry As Integer
            Try
                CountryID = readDatabase.ExecuteMsSQLReader("[IdCountry] as CountryID", "[dbo].[Countries]", True, String.Format("[Countries].[Country] = '{0}'", e.Country),
                                                               False, False, False, False, "CountryID")

                IdCountry = CountryID(0)    'ONLY ONE VALUE WILL BE RETUNED BY MSSQL READER IN THIS CASE AND THEREFORE, ASSIGNING ONLY INDEX 0 IS SUFFICIENT.
            Catch ex As Exception
                log.Error(ex)  'LOGGING ERROR TO DISK
                MsgBox(String.Format("An error occurred while looking up the Country ID for the patient." & vbCrLf & "Error Message: {0}" & vbCrLf & "Error Type: {1}", ex.Message, ex.GetType), vbExclamation,
                       "Patient Registration")
            End Try

            Return IdCountry
        End Function

        Public Function FetchIdIslandList(e As AddPatientEventArgs)
            Dim checkValuePresence As New FieldPopulation
            Dim getNextHospitalNumber As New GetNextHospitalNumber
            Dim insertValues As New ExecuteInserts
            Dim readDatabase As New ExecuteReads
            'TASK OF THE FUNCTION: GET THE ATOLL AND ISLAND(ATOLL AND ISLAND ID IS JUST ONE VALUE. IdIslandList) ID OF THE PATIENTS ADDRESS AND RETURN IT.

            Dim IdIslandAndAtoll As Integer
            Dim IdIslandAndAtollArray As String() = readDatabase.ExecuteMsSQLReader("[IdIslandList] AS IdIslandAndAtoll", "[dbo].[IslandList]", True, String.Format("[Island]='{0}' AND [AtollAbbrv]='{1}'", e.Island, e.Atoll), False, False, "", False, "IdIslandAndAtoll")

            'THE ARRAY RETURNED WILL HAVE ONLY ONE VALUE AND HENCE THERE IS NO NEED TO ITERATE THROUGH THE ARRAY.
            'GETTING THE 0 INDEX OF THE ARRAY TO AN INTEGER AND RETURNING THE VALUE SHOULD DO THE JOB.
            IdIslandAndAtoll = IdIslandAndAtollArray(0)
            Return IdIslandAndAtoll
        End Function

        Public Function FetchIndividualNameIDs(e As AddPatientEventArgs)

            'TASK OF THIS FUNCTION: CHECK SERVER FOR THE PRESENCE OF INDIVIDUAL NAMES. IF PRESENT, GET THEIR IDs ELSE EXECUTE AN INSERT QUERY TO ADD THE NON-EXISTANT NAMES
            'AND EXECUTE ANOTHER QUERY TO GET THE IDs.
            'THIS FUNCTION USES ServerCommunications.vb CLASS.

            'GETTING INDIVIDUAL NAMES FROM ARRAY.
            'INITIALISING ALL REQUIRED VARIABLES TO GATHER INFORMATION FROM SERVER.
            Dim i As Integer 'COUNTER VARIABLE FOR LOOP
            Dim Individual As String = ""
            Dim IsNamePresentOnServer As Integer
            Dim RetrievedIdIndividualName(e.IndividualNameCollection.Length - 1) As Integer
            Dim RowsInserted As Integer

            'USING FOR LOOP TO RETRIEVE THE VALUES
            For i = 0 To e.IndividualNameCollection.Length - 1
                RowsInserted = 0    'INITIALISE VARIABLE EVERYTIME THE QUERY IS RUN.
                Individual = e.IndividualNameCollection.GetValue(i)

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

    End Class

End Namespace