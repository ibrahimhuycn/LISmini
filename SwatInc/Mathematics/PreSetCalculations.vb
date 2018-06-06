Namespace SwatInc.Mathematics

    Public Class PreSetCalculations

        'Initializing log4net logger for this class and getting class name from reflection
        Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(Reflection.MethodBase.GetCurrentMethod().DeclaringType)

        Public Shared Function CalculateAge(dob As Date) As String
            'THIS FUNCTION CALCULATES AGE WHEN DOB IS PROVIDED.
            'RETURNS CALCULATED AGE AS A STRING

            'NOTE: IF AGE IS LESS THAN A YEAR, AGE IS RETURNED IN MONTHS AND DAYS. IF AGE IS LESS THAN A MONTH THEN, AGE IS RETURNED IN DAYS
            'WITH THE UNITS. AND HENCE, IT RETURNS A STRING
            Dim AgeYears As Integer
            Dim AgeMonths As Integer
            Dim AgeDays As Integer

            Dim CalculatedAge As String = ""

            Try

                'A NEONATES' AGE HAS TO BE REPORTED IN MONTHS OR EVEN DAYS.

                AgeYears = Math.Floor(DateDiff(DateInterval.Day, DateValue(dob), Now()) / 365.25)
                AgeMonths = Math.Floor(DateDiff(DateInterval.Day, DateValue(dob), Now()) / 30.4375)
                AgeDays = Math.Floor(DateDiff(DateInterval.Day, DateValue(dob), Now()))

                If AgeYears = 0 And AgeMonths = 0 Then
                    CalculatedAge = AgeDays & " D"
                ElseIf AgeYears = 0 And AgeMonths > 0 Then

                    Dim RemainingDays As Integer = AgeDays - (AgeMonths * 30.4375)
                    CalculatedAge = String.Format("{0} M {1} D", AgeMonths, RemainingDays)
                ElseIf AgeYears > 0 Then
                    CalculatedAge = AgeYears & " Y"

                End If
            Catch ex As Exception
                log.Error(ex.Message & vbCrLf & ex.StackTrace)
                MsgBox(ex.Message)
            End Try
            log.Debug("Returned calculated Age: " & CalculatedAge)
            Return CalculatedAge
        End Function

    End Class

End Namespace