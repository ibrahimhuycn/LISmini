Imports System.Text.RegularExpressions

Namespace SwatInc.Validations

    Public Class Validate

        Public Shared Function ValidateEmail(ByVal EmailAddress As String) As Boolean
            'REGEX EMAIL ADDRESS: \b[!#$%&'*+./0-9=?_`a-z{|}~^-]+@[.0-9a-z-]+\.[a-z]{2,6}\b

            If Not EmailAddress = Nothing Then
                If EmailAddress.Contains("..com") = True Then Return False
                Return Regex.IsMatch(EmailAddress, "\b[!#$%&'*+./0-9=?_`a-z{|}~^-]+@[.0-9a-z-]+\.[a-z]{2,6}\b", RegexOptions.IgnoreCase)
            Else
                Return False
            End If
        End Function

        Public Shared Function ValidateHospitalNumber(ByVal HospitalNumber As String) As Boolean
            'SQL SERVER HAS IdIndividual(USED AS HOSPITAL NUMBER) SET AS INT WHICH IS ACCEPTABLE BETWEEN 0 AND 2147483648 EXCLUSIVELY.
            'HOSPITAL NUMBER CANNOT BE A NEGATIVE INTEGER.
            If Not HospitalNumber = Nothing Then
                Return Regex.IsMatch(HospitalNumber, "^(?:214748364[0-7]|21474836[0-3][0-9]|2147483[0-5][0-9]{2}|214748[0-2][0-9]{3}|21474[0-7][0-9]{4}|2147[0-3][0-9]{5}|214[0-6][0-9]{6}|21[0-3][0-9]{7}|20[0-9]{8}|1[0-9]{9}|[1-9][0-9]{1,8}|[1-9])$", RegexOptions.Multiline)
            Else
                Return False
            End If

        End Function

        Public Shared Function ValidateLocalLandLines(ByVal LandLine As String) As Boolean
            If Not LandLine = Nothing Then
                Return Regex.IsMatch(LandLine, "^(301|330|331|332|333|334|335|339|688|689|690|650|652|652|654|656|658|660|662|664|666|668|670|672|674|676|678|680|682|684|686)+[0-9]{4}$")
            Else
                Return False
            End If
        End Function

        Public Shared Function ValidateLocalMobileNumbers(ByVal MobileNumber As String) As Boolean
            'REGEX INTERNATIONAL MOBILE NUMBERS: ^\+?(d+[- ])?\d{10}$ OR ^(d+[- ])?\d{7}$

            If Not MobileNumber = Nothing Then
                Return If(Regex.IsMatch(MobileNumber, "^(960)+(9|7)\+?(d+[- ])?\d{6}$") Or Regex.IsMatch(MobileNumber, "^(9|7)+(d+[- ])?\d{6}$") = True, True, False)
            Else
                Return False
            End If
        End Function

        Public Shared Function ValidateNationalId(ByVal NationalId As String) As Boolean
            'USING REGEX.ISMATCH (LIKE AN INPUT MASK) TO CHECK WHETHER THE TXTINPUT AT TXTNID MATCHES THE FORMATS
            '1) A309254  NORMAL FORMAT FOR IDCARD.
            '2) BO01309254 FOR BABY WHOSE ID CARD HAS NOT BEEN MADE YET. "BO" STANDS FOR BABY OF. 01 INDICATES THAT ITS THE FIRST BABY OF THE MOTHER. AND
            '   309254 IS THE ID CARD NUMBER OF THE MOTHER.

            'USING REGEX REQUIRES Imports System.Text.RegularExpressions. REGEX STANDS FOR REGULAR EXPRESSIONS.
            If Not NationalId = Nothing Then
                Return Regex.IsMatch(NationalId, "^A[0-9]\d{5}$") Or Regex.IsMatch(NationalId, "^BO[0-9]\d{7}$")
            Else
                Return False
            End If

        End Function

    End Class

End Namespace