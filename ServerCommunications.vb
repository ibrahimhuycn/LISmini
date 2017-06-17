Imports System.Data.SqlClient

'THIS CLASS WILL BE USED TO EXECUTE QUERIES FOR ALL PURPOSES.(MSSQL SERVER)
'AUTHOR: IBRAHIM HUSSAIN
'SWAT INC
Public Class ServerCommunications
    Implements IDisposable
    'INITIALIZING OBJECTS AND VARIALBLES REQUIRED TO EXECUTE QUERIES.
    ReadOnly MsSQLCnx As New SqlConnection
    ReadOnly MsSQLCnxCheck As New SqlConnection

    Dim MsSQLStatement As String 'FOR TEXT SQL QUERY
    Dim MsSQLCmd As SqlCommand
    Dim DataReader As SqlDataReader
    Dim Transection As SqlTransaction

    Dim RowsEffected As Integer = Nothing 'TO GET THE NUMBER OF ROWS EFFECTED EXECUTING NON-QUERY

    'CONNECTIONSTRING OPTIONAL VARIABLES

    Const MsSQLAttachDbFileName As String = "C:\Users\ibrah\OneDrive\Documents\Visual Studio 2015\Projects\LISmini\LISmini\Database\lismini.mdf"  'CAN BE CHANGED IF AND WHEN DATABASE FILE LOCATION IS CHANGED.
    Public Sub Dispose() Implements IDisposable.Dispose
        If MsSQLCnx IsNot Nothing Then
            MsSQLCnx.Dispose()
        End If
        If MsSQLCnxCheck IsNot Nothing Then
            MsSQLCnxCheck.Dispose()
        End If
        If MsSQLCmd IsNot Nothing Then
            MsSQLCmd.Dispose()
            MsSQLCmd = Nothing
        End If
        If DataReader IsNot Nothing Then
            DataReader.Dispose()
            DataReader = Nothing
        End If
        If Transection IsNot Nothing Then
            Transection.Dispose()
            Transection = Nothing
        End If
    End Sub

    Public Sub CnxStr()
        'THIS METHOD WILL BE CALLED TO SET THE CONNECTION STRING EACH TIME A QUERY IS EXECUTED.
        MsSQLCnx.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & MsSQLAttachDbFileName & ";Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True"
    End Sub
    Public Function GetNextHNo()
        'GETTING LAST HOSPITAL NUMBER TO DETERMINE NEXT HOSPITAL NUMBER FOR NEW PATIENT REGISTRATION.
        Dim NextHNo As Integer
        Dim NextHnoRow As Object
        ' Dim PatientDataRowCount As Object
        Dim PatientRowCount As Integer

        'EXECUTE A SCALAR QUERY TO DETERMINE A COUNT OF ROWS IN THE TABLE PATIENT DATA.
        'EXECUTION OF THIS STATEMENT WILL RETURN A COUNT OF TOTAL ROWS AS THE FIELD TotalRows
        MsSQLStatement = "SELECT count(*) as TotalRows FROM Individuals"    'dbo.Individuals.Idindividual is used as Hospital Number
        Dim PatientDataRowCount As Object = ExecuteScalarQuery()

        'SINCE PatientDataRowCount IS RETURNED AS A ROW(OBJECT), THE VALUE NEEDS TO BE CONVERTED TO AN INTEGER BEFORE IT CAN BE USED.
        If Not PatientDataRowCount = Nothing Then   'EXCLUDING THE POSSIBILITY OF ROW COUNT BEING NULL TO AVOID AN ERROR IN THE NEXT STEP.
            PatientRowCount = Convert.ToInt32(PatientDataRowCount)
        Else
            PatientRowCount = 0
        End If

        If PatientRowCount = 0 Then
            NextHNo = 0
        Else
            'RUN A SCALAR QUERY TO GET LAST HOSPITAL NUMBER+1 WHICH WILL BE THE NEXT HOSP NUMBER. THIS IS ACHIEVED BY A OFFSET, FETCH NEXT CLAUSE AS BELOW. 
            Dim sqlQueryGetNextHno As String = String.Format("SELECT (dbo.Individuals.IdIndividual + 1) as NextHNo" +
                                                        " From dbo.Individuals" +
                                                        " ORDER BY dbo.Individuals.IdIndividual" +
                                                        " OFFSET {0} ROWS" +
                                                        " FETCH NEXT 1 ROWS ONLY;", PatientRowCount - 1)
            MsSQLStatement = sqlQueryGetNextHno
            NextHnoRow = ExecuteScalarQuery()

            'EXCLUDING THE POSSIBILITY OF ROW COUNT BEING NULL TO AVOID AN ERROR IN THE NEXT STEP.
            If Not NextHnoRow = Nothing Then   'EXCLUDING THE POSSIBILITY OF ROW COUNT BEING NULL TO AVOID AN ERROR IN THE NEXT STEP.
                NextHNo = Convert.ToInt32(NextHnoRow)
            Else
                NextHNo = 0
            End If
        End If


        Return NextHNo
    End Function
    Public Function ExecuteScalarQuery()
        Dim scalarValueField As Object = Nothing

        'SETTING THE CONNECTION STRING FOR THE CONNECTION MsSQLCnX
        CnxStr()

        Using MsSQLCmd As New SqlCommand(MsSQLStatement, MsSQLCnx)       'SETTING UP QUERY WITH THE CONNECTION
            Try
                MsSQLCnx.Open()     'OPENING CONNECTION
                'RUNNING THE QUERY AS SCALAR AND ASSIGNING THE RESULT TO OBJECT scalarValueField. 
                scalarValueField = MsSQLCmd.ExecuteScalar() 'IT HAS TO BE ASSIGNED TO AN OBJECT SINCE RESULT IS RETURNED AS A COLUMN
                MsSQLCnx.Close()

            Catch ex As Exception
                MsgBox(String.Format("{0}  Error Code: {1}", ex.Message, ex.HResult), MsgBoxStyle.Critical, "Server Connection Failed")

            Finally
                MsSQLCnx.Close()
                MsSQLCnx.Dispose()
            End Try
        End Using

        Return scalarValueField

    End Function
    Public Function IsFieldValuePresent(DataTable As String, FieldName As String, ExpectedValue As String)

        'THIS FUNCTION QUERIES FOR THE A PARTICULAR STRING TO CHECK WHETHER A RECORD WITH THE EXPECTED VALUE IS PRESENT BY USING
        'THE FOLLOWING QUERY.
        'SELECT COUNT(FIELDNAME) AS EXPECTEDVALUEINCIDENCE FROM DATATABLE WHERE FIELDNAME=EXPECTEDVALUE

        'VARIABLE OBJECT AND INTEGER TO STORE RETURNED EXPECTEDVALUEINCIDENCE ROW AND CONVERTED INTEGER RESPECTIVELY.

        Dim ValueIncidence As Integer

        'PARSING DYNAMIC VALUES AS TEXT QUERY
        Dim ParsedDynamicQueryStr As String = String.Format("SELECT count({0}) AS ExpectedValueIncidence FROM {1} WHERE {0} = '{2}'", FieldName, DataTable, ExpectedValue)

        'SETTING PARSED STRING AS MySQLStatement
        MsSQLStatement = ParsedDynamicQueryStr

        'EXECUTING SCALAR QUERY AND ASSIGNING RETURNED COUNT FIELD TO ExpectedValueIncidence OBJECT FOR CONVERSION
        Dim ExpectedValueIncidence As Object = ExecuteScalarQuery()
        If Not ExpectedValueIncidence = Nothing Then    'EXCLUDING THE POSSIBILITY OF COUNT BEING NULL TO AVOID AN ERROR IN THE NEXT STEP.
            ValueIncidence = Convert.ToInt32(ExpectedValueIncidence)
        End If
        Return ValueIncidence

    End Function
    Public Function IsServerAccessAvailable()
        'A SEPARATE INSTANCE OF CONNECTION STRING USED TO CHECK WHETHER DATABASE IS AVALIABLE
        MsSQLCnxCheck.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & MsSQLAttachDbFileName & ";Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True"

        Dim feedback As String = ""
        Dim IsLimsCnXAvailable As Boolean = Nothing
        'PROVIDING CONNECTION STRING
        Try
            'CHECK IF CONNECTION IS OPENED BY ANOTHER FUNCTION BY USING "STATE" STATE=0 IS CLOSED.
            feedback = MsSQLCnxCheck.State.ToString
            If MsSQLCnxCheck.State.value__ = 0 Then
                feedback = String.Format("{0} {1}", feedback, MsSQLCnxCheck.State)
                MsSQLCnxCheck.Open()     'OPEN CONNECTION
                MsSQLCnxCheck.Close()     'CLOSE CONNECTION
                MsSQLCnxCheck.Dispose()      'DISPOSING CONNECTION
                IsLimsCnXAvailable = True   'SET CONNECTION ALIVE STATUS

            Else
                IsLimsCnXAvailable = True   'SET CONNECTION ALIVE STATUS
            End If

        Catch ex As Exception
            IsLimsCnXAvailable = False  'SET CONNECTION ALIVE STATUS
        End Try
        Return IsLimsCnXAvailable

    End Function
    Public Function ExecuteMsSQLReader(Field As String, DataTable As String, IsWhereClause As Boolean, WhereCondition As String, IsDistinct As Boolean, IsOrderBy As Boolean, OrderByField As String, IsASC As Boolean, Optional RenamedField As String = Nothing)
        'LOTS OF IMPROVEMENT IS REQUIRED FOR THIS FUNCTION TO BE TRUELY DYNAMIC

        'THIS METHOD RUNS AN SQL QUERY BY EXECUTING SQL DATA READER AND RETURNS THE COLLECTION AS A STRING ARRAY.
        'READS ONE COLUMN AT A TIME

        Dim ReadData() As String = Nothing
        ' Dim TempReadDataHold(QueryRowCount) As String   'Declare this after getting a count of total number of rows The query returns. Use ExecuteScalarQuery Function to get the RowCount.
        Dim Counter As Integer = 0


        'PARSING SQL READER STATEMENT
        Dim MsSQlReaderQueryStatement As String
        If IsDistinct = True Then
            MsSQlReaderQueryStatement = String.Format("{0}DISTINCT {1} FROM {2}", "Select ", Field, DataTable)
        Else
            MsSQlReaderQueryStatement = String.Format("SELECT {0} FROM {1}", Field, DataTable)
        End If
        If IsWhereClause = True Then MsSQlReaderQueryStatement = String.Format("{0} WHERE {1}", MsSQlReaderQueryStatement, WhereCondition)

        'THIS STEP NEEDS TO BE IMPLEMENTED BEFORE "ORDER BY" CLAUSE OF THE SQL STATEMENT PARSED, OTHERWISE THE COUNT(*) FROM STATEMENT WILL THOW AN EXCEPTION.

        'PARSE A QUERY TO COUNT THE TOTAL NUMBER OF ROWS RETURNED FROM THE QUERY.
        'TOTAL NUMBER OF ROWS IS DETERMINED USING THE FUNCTION "Public Function ExecuteScalarQuery()" AND THE QUERY. " "SELECT COUNT(*) AS TotalRows FROM (" & MsSQlReaderQueryStatement &") AS TotalRows ""
        Dim DetermineRowCount As String = String.Format("SELECT COUNT(*) AS TotalRows FROM ({0}) AS TotalRows ", MsSQlReaderQueryStatement)
        MsSQLStatement = DetermineRowCount
        Dim QueryRowCount As Integer = ExecuteScalarQuery()

        Dim TempReadDataHold(QueryRowCount) As String
        If IsOrderBy = True Then
            MsSQlReaderQueryStatement = String.Format("{0} ORDER BY {1}", MsSQlReaderQueryStatement, OrderByField)

            If IsASC = True Then
                MsSQlReaderQueryStatement = MsSQlReaderQueryStatement & " ASC"
            Else
                MsSQlReaderQueryStatement = MsSQlReaderQueryStatement & " DESC"
            End If

        End If

        'ASSIGN PARSED TEXT QUERY TO MySQLStatement
        MsSQLStatement = MsSQlReaderQueryStatement

        'CHECKING WHETHER THE RETURNED FIELD IS RENAMED USING SQL "AS" STATEMENT. IF SO THE NEW NAME NEEDS TO BE ASSIGNED AS THE FIELD NAME TO BE READ BY THE DATA READER.
        'THIS IS IMPLEMENTED AS FOLLOWS.
        If Not RenamedField = Nothing Then Field = RenamedField

        If Not MsSQLCnx Is Nothing Then MsSQLCnx.Close()
        'ASSIGN CNX STRING
        CnxStr()
        Try
            Using MsSQLCmd As New SqlCommand(MsSQLStatement, MsSQLCnx)      'SETTING UP MYSQL COMMAND
                MsSQLCnx.Open() 'OPENING CONNECTION
                DataReader = MsSQLCmd.ExecuteReader()                       'EXECUTING DATA READER

                While DataReader.Read                   'TO MAKE THIS TRULY DYNAMIC, FIELDS PARAMETER HAS TO BE SPLIT USING A DELIMITER
                    TempReadDataHold(Counter) = DataReader(Field)          'TO GET SEPARATE FIELDS AND ASSIGN THEM TO ARRAYS OR DATASETS.
                    Counter = Counter + 1
                End While
                DataReader.Close()
                MsSQLCnx.Close()

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            DataReader.Close()
            MsSQLCnx.Close()

            ReDim ReadData(Counter - 1)
            Counter = 0                 'RESETING THE PREVIOUS COUNTER FOR ANOTHER ARRAY.
            For Each ArrayPosition In TempReadDataHold
                If ArrayPosition = "" Then
                    'IGNORE
                Else
                    ReadData(Counter) = ArrayPosition
                    Counter = Counter + 1
                End If
            Next
        End Try
        Return ReadData
    End Function
    Public Function NonQueryINSERT(Table As String, InsertValues As String, Optional Fields As String = Nothing)
        'INITIALISATIONS
        RowsEffected = Nothing
        Dim MsSqlCmdStatement As String = Nothing

        'PARSE THE QUERY
        ' ************IMPORTANT NOTE: FIELDS AND INSERTVALUES SHOULD BE PROPERLY FORMATTED
        'WITH COMMAS AND BREAKETS AS FOLLOWS       *********************

        'INSERT INTO table
        '(field1, field2, ... )
        'VALUES
        '(InsertValue1, InsertValue2, ... ),
        '(InsertValue1, InsertValue2, ... ),
        '...;

        If Not Fields = Nothing Then
            MsSqlCmdStatement = String.Format("INSERT INTO {0} {1} VALUES {2}", Table, Fields, InsertValues)
        ElseIf Fields = Nothing Then
            MsSqlCmdStatement = String.Format("INSERT INTO {0} VALUES {1}", Table, InsertValues)
        End If


        Using MsSQLCnx

            'EXECUTING INSERT STATEMENTS
            If Not MsSQLCnx Is Nothing Then MsSQLCnx.Close() 'TRYING TO CLOSE THE CONNECTION IF ONE EXISTS.
            'ASSIGN CNX STRING

            CnxStr()
            MsSQLCnx.Open()
            MsSQLCmd = MsSQLCnx.CreateCommand() 'CREATS AND RETURNS SQL COMMAND OBJECT ASSOCIATED WITH THE SQLCONNECTION
            Transection = MsSQLCnx.BeginTransaction("InsertQuery")  'INITIALIZE A LOCAL TRANSECTION NAMED "InsertQuery".

            'MUST ASSIGN BOTH TRANSACTION OBJECT AND CONNECTION
            'TO COMMAND OBJECT FOR A PENDING LOCAL TRANSACTION
            MsSQLCmd.Connection = MsSQLCnx
            MsSQLCmd.Transaction = Transection

            Try
                MsSQLCmd.CommandText = MsSqlCmdStatement

                RowsEffected = MsSQLCmd.ExecuteNonQuery()

                'ATTEMPT TO COMMIT THE TRANSECTION
                Transection.Commit()
            Catch ex As Exception
                MsgBox(String.Format("Commit exception type: {0}" & vbCrLf & "Message {1}", ex.GetType, ex.Message), vbInformation, "Transections")

                'ATTEMPT TO ROLL BACK THE TRANSECTION
                Try
                    Transection.Rollback()
                Catch exRollingBack As Exception
                    MsgBox(String.Format("Rollback exception type: {0}" & vbCrLf & "Message: {1}", exRollingBack.GetType, exRollingBack.Message), vbCritical, "Transections")
                End Try

            Finally
                MsSQLCnx.Close()
            End Try

        End Using



        'EXECUTING UPDATE STATEMENTS

        'EXECUTING DELETE STATEMENTS
        Return RowsEffected
    End Function
End Class
