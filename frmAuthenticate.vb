Public Class frmAuthenticate
    'PENDING TASKS.
    'Use swatinccrypto to check whether user provided password and Hash retrived from server match.


    Dim IS_USERNAME_ENTERED As Boolean
    Dim IS_PASSWORD_ENTERED As Boolean
    Dim IS_USER_AUTHENTICATED As Boolean

    Private Sub frmAuthenticate_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'CENTER LOGIN FORM ONTO THE PARENT FORM, frmLisMini
        ParentCenter()
    End Sub

    Private Sub txtUserName_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtUserName.GotFocus
        'Clearing default text on gotfocus
        If txtUserName.Text = "Username" Then
            txtUserName.Text = ""
        Else
            txtUserName.SelectAll()
        End If

    End Sub



    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtPassword.GotFocus
        'Clearing password field of default text

        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
        Else
            txtPassword.SelectAll()

        End If
    End Sub

    Private Sub txtPassword_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtPassword.LostFocus
        'Initialise IS_PASSWORD_ENTERED variable
        IS_PASSWORD_ENTERED = False

        'Check whether password was entered.
        If txtPassword.Text = "" Or txtPassword.Text = "Password" Then
            IS_PASSWORD_ENTERED = False
            txtPassword.Text = "Password"
        Else
            IS_PASSWORD_ENTERED = True
        End If

    End Sub

    Public Sub ParentCenter()
        Dim ParentWidth As Single = (frmLisMini.ClientSize.Width - Width) / 2
        Dim ParentHeight As Single = ((frmLisMini.ClientSize.Height - Height) / 2) - 100
        SetBounds(ParentWidth, ParentHeight, Width, Height)
        MdiParent = frmLisMini
    End Sub
    Function AuthenticateUser()

        'After authentication
        IS_USER_AUTHENTICATED = True
        Return IS_USER_AUTHENTICATED
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        On Error Resume Next
        Application.Exit()
        Environment.Exit(1)
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        AuthenticateUser()
        If IS_USER_AUTHENTICATED = True Then
            'Enabling Parent ribbon
            frmLisMini.EnableRibbon(True)
            'frmNotification.ShowNotification("User authenticated successfully!" & vbCrLf & "Welcome", "Authentication")
            frmNotification.Show()
            Close()
            Dispose()
        End If
    End Sub

    Private Sub txtUserName_LostFocus(sender As Object, e As EventArgs) Handles txtUserName.LostFocus
        '1) Giving feednack on whether username was entered.
        '2) Setting default text if field is empty on lost focus.

        'Initialise IS_USERNAME_ENTERED variable as False
        IS_USERNAME_ENTERED = False

        If txtUserName.Text = "" Or txtUserName.Text = "Username" Then
            IS_USERNAME_ENTERED = False
            txtUserName.Text = "Username"
        Else
            IS_USERNAME_ENTERED = True
        End If
    End Sub
End Class