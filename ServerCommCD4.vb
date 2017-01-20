Imports MySql.Data.MySqlClient

'THIS CLASS WILL BE USED TO EXECUTE QUERIES FOR ALL PURPOSES.
'AUTHOR: IBRAHIM HUSSAIN
'SWAT INC
Public Class ServerCommCD4
    Implements IDisposable
    'INITIALIZING OBJECTS AND VARIALBLES REQUIRED TO EXECUTE QUERIES.
    ReadOnly MySQLCnX As New MySqlConnection()     'MYSQL CONNECTION

    Dim MySQLStatement As String            'FOR TEXT SQL QUERY
    '    Dim IsConnected As Boolean              'FOR USER FEEDBACK. OPENS AND CLOSES A CONNECTION TO SERVER IN SET INTERVALS OF TIME TO CHECK CNX STATUS.
    Dim MySQLCmd As MySqlCommand
    Dim DataReader As MySqlDataReader

    'SERVER AUTHENTICATION DETAILS
    Const DatabaseName As String = "lims"
    Const MySQLServer As String = "localhost"
    Const UserName As String = "limsclient"
    Const Password As String = "Bismillah."
    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If MySQLCnX IsNot Nothing Then
                MySQLCnX.Dispose()
            End If
            If MySQLCmd IsNot Nothing Then
                MySQLCmd.Dispose()
                MySQLCmd = Nothing
            End If
            If DataReader IsNot Nothing Then
                DataReader.Dispose()
                DataReader = Nothing
            End If
        End If
    End Sub
    Sub Finalize()
        Dispose(False)
    End Sub
    Public Sub CnxStr()
        'THIS METHOD WILL BE CALLED TO SET THE CONNECTION STRING EACH TIME A QUERY IS EXECUTED.
        MySQLCnX.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=true", MySQLServer, UserName, Password, DatabaseName)
    End Sub



    Public Function GetNextHNo()
        'GETTING LAST HOSPITAL NUMBER TO DETERMINE NEXT HOSPITAL NUMBER FOR NEW PATIENT REGISTRATION.
        Dim NextHNo As Integer
        Dim NextHnoRow As Object
        Dim PatientDataRowCount As Object
        Dim PatientRowCount As Integer

        'EXECUTE A SCALAR QUERY TO DETERMINE A COUNT OF ROWS IN THE TABLE PATIENT DATA.
        'EXECUTION OF THIS STATEMENT WILL RETURN A COUNT OF TOTAL ROWS AS THE FIELD TotalRows
        MySQLStatement = "SELECT count(*) as TotalRows FROM patientdata"
        PatientDataRowCount = ExecuteScalarQuery()

        If Not PatientDataRowCount = Nothing Then   'EXCLUDING THE POSSIBILITY OF ROW COUNT BEING NULL TO AVOID AN ERROR IN THE NEXT STEP.
            PatientRowCount = Convert.ToInt32(PatientDataRowCount)
        Else
            PatientRowCount = 0
        End If

        'RUN A SCALAR QUERY TO GET LAST HOSPITAL NUMBER+1 WHICH WILL BE THE NEXT HOSP NUMBER. THIS IS ACHIEVED BY A LIMIT CLAUSE AS BELOW. IT WILL RETURN HOSP NUMBER OF 1 RECORD STARTING FROM
        'SECOND LAST RECORD.
        'SELECT hospitalNumber+1 FROM patientdata LIMIT PatientRowCount-1,1 ASC

        Dim sqlQueryGetLastHno As String = String.Format("SELECT hospitalNumber+1 FROM patientdata LIMIT {0}, 1", PatientRowCount - 1)
        MySQLStatement = sqlQueryGetLastHno
        NextHnoRow = ExecuteScalarQuery()

        'EXCLUDING THE POSSIBILITY OF ROW COUNT BEING NULL TO AVOID AN ERROR IN THE NEXT STEP.
        If Not NextHnoRow = Nothing Then   'EXCLUDING THE POSSIBILITY OF ROW COUNT BEING NULL TO AVOID AN ERROR IN THE NEXT STEP.
            NextHNo = Convert.ToInt32(NextHnoRow)
        Else
            NextHNo = 0
        End If
        Return NextHNo

        Finalize()
        Dispose()
    End Function
    Public Function IsFieldValuePresent(DataTable As String, FieldName As String, ExpectedValue As String)

        'THIS FUNCTION CHECKS QUERIES FOR THE A PARTICULAR STRING TO CHECK WHETHER A RECORD WITH THE EXPECTED VALUE IS PRESENT BY USING
        'THE FOLLOWING QUERY.
        'SELECT COUNT(FIELDNAME) AS EXPECTEDVALUEINCIDENCE FROM DATATABLE WHERE FIELDNAME=EXPECTEDVALUE

        'VARIABLE OBJECT AND INTEGER TO STORE RETURNED EXPECTEDVALUEINCIDENCE ROW AND CONVERTED INTEGER RESPECTIVELY.
        Dim ExpectedValueIncidence As Object
        Dim ValueIncidence As Integer

        'PARSING DYNAMIC VALUES AS TEXT QUERY
        Dim ParsedDynamicQueryStr As String = String.Format("SELECT count({0}) AS ExpectedValueIncidence FROM {1} WHERE {0} = '{2}'", FieldName, DataTable, ExpectedValue)

        'SETTING PARSED STRING AS MySQLStatement
        MySQLStatement = ParsedDynamicQueryStr

        'EXECUTING SCALAR QUERY AND ASSIGNING RETURNED COUNT FIELD TO ExpectedValueIncidence OBJECT FOR CONVERSION
        ExpectedValueIncidence = ExecuteScalarQuery()
        If Not ExpectedValueIncidence = Nothing Then    'EXCLUDING THE POSSIBILITY OF COUNT BEING NULL TO AVOID AN ERROR IN THE NEXT STEP.
            ValueIncidence = Convert.ToInt32(ExpectedValueIncidence)
        End If
        Return ValueIncidence
        Finalize()
        Dispose()
    End Function
    Public Function ExecuteScalarQuery()
        Dim scalarValueField As Object = Nothing
        'CLOSING CONNECTION IF THERE IS AN ACTIVE CONNECTION
        ' If Not MySQLCnX Is Nothing Then MySQLCnX.Close()

        'SETTING THE CONNECTION STRING FOR THE CONNECTION MySQLCnX
        CnxStr()
RetryConnection:
        If Not MySQLCnX.State = 0 Then GoTo RetryConnection

        Try

            MySQLCnX.Open()     'OPENING CONNECTION
                MySQLCmd = New MySqlCommand(MySQLStatement, MySQLCnX)       'SETTING UP QUERY WITH THE CONNECTION

            'RUNNING THE QUERY AS SCALAR AND ASSIGNING THE RESULT TO OBJECT scalarValueField. 
            scalarValueField = MySQLCmd.ExecuteScalar() 'IT HAS TO BE ASSIGNED TO AN OBJECT SINCE RESULT IS RETURNED AS A COLUMN

        Catch ex As Exception
            MsgBox(String.Format("{0}  Error Code: {1}", ex.Message, ex.HResult), MsgBoxStyle.Critical, "Server Connection Failed")
        Finally
            MySQLCnX.Close()
        End Try
        Return scalarValueField
        Finalize()
        Dispose()

    End Function
    Public Function IsCnXAlive()
        Dim feedback As String = ""

        Dim IsLimsCnXAlive As Boolean = Nothing
        'PROVIDING CONNECTION STRING
        CnxStr()
        Try
            'CHECK IF CONNECTION IS OPENED BY ANOTHER FUNCTION BY USING "STATE" STATE=0 IS CLOSED.
            feedback = MySQLCnX.State.ToString
            If MySQLCnX.State = ConnectionState.Closed Then
                feedback = feedback & " " & MySQLCnX.State.ToString
                Dim a As Integer = MySQLCnX.State
                MySQLCnX.Open()     'OPEN CONNECTION
                MySQLCnX.Close()     'CLOSE CONNECTION
                IsLimsCnXAlive = True   'SET CONNECTION ALIVE STATUS

            Else
                IsLimsCnXAlive = True   'SET CONNECTION ALIVE STATUS
            End If

        Catch ex As Exception
            IsLimsCnXAlive = False  'SET CONNECTION ALIVE STATUS
        End Try
        Return IsLimsCnXAlive
        Finalize()
        Dispose()

    End Function
    Public Function ExecuteMySQLReader(Fields As String, DataTable As String, IsWhereClause As Boolean, WhereCondition As String, IsDistinct As Boolean, IsOrderBy As Boolean, OrderByField As String, IsASC As Boolean)
        'LOTS OF IMPROVEMENT IS REQUIRED FOR THIS FUNCTION TO BE TRUELY DYNAMIC

        'THIS METHOD RUNS AN SQL QUERY BY EXECUTING SQL DATA READER AND RETURNS THE COLLECTION AS A STRING ARRAY.
        'READS ONE COLUMN AT A TIME
        Dim ReadData() As String = Nothing
        Dim TempReadDataHold(1000) As String
        Dim Counter As Integer = 0


        'PARSING SQL READER STATEMENT
        Dim MySQlReaderQueryStatement As String
        If IsDistinct = True Then
            MySQlReaderQueryStatement = String.Format("{0}DISTINCT {1} FROM {2}", "SELECT ", Fields, DataTable)
        Else
            MySQlReaderQueryStatement = "SELECT "
        End If
        If IsWhereClause = True Then MySQlReaderQueryStatement = String.Format("{0} WHERE {1}", MySQlReaderQueryStatement, WhereCondition)
        If IsOrderBy = True Then
            MySQlReaderQueryStatement = String.Format("{0} ORDER BY {1}", MySQlReaderQueryStatement, OrderByField)

            If IsASC = True Then
                MySQlReaderQueryStatement = MySQlReaderQueryStatement & " ASC"
            Else
                MySQlReaderQueryStatement = MySQlReaderQueryStatement & " DESC"
            End If

        End If




        'ASSIGN PARSED TEXT QUERY TO MySQLStatement
        MySQLStatement = MySQlReaderQueryStatement

        If Not MySQLCnX Is Nothing Then MySQLCnX.Close()
        'ASSIGN CNX STRING
        CnxStr()
        Try
            MySQLCnX.Open() 'OPENING CONNECTION
            MySQLCmd = New MySqlCommand(MySQLStatement, MySQLCnX)       'SETTING UP MYSQL COMMAND
            DataReader = MySQLCmd.ExecuteReader()                       'EXECUTING DATA READER

            'DO WHILE LOOP TO GET DATA TO AN ARRAY.

            While DataReader.Read                   'TO MAKE THIS TRULY DYNAMIC, FIELDS PARAMETER HAS TO BE SPLIT USING A DELIMITER
                TempReadDataHold(Counter) = DataReader(Fields)          'TO GET SEPARATE FIELDS AND ASSIGN THEM TO ARRAYS OR DATASETS.
                Counter = Counter + 1
            End While
            DataReader.Close()
            MySQLCnX.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
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
        Finalize()
        Dispose()
    End Function

End Class
