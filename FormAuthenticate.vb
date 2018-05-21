Imports SwatIncNotifications

Public Class FormAuthenticate
    'PENDING TASKS.
    'Use SwatIncCrypto to check whether user provided password and Hash retrieved from server match.

    Dim isUsernameEntered As Boolean
    Dim isPasswordEntered As Boolean
    Dim isUserAuthenticated As Boolean

    Private Sub Authenticate_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'CENTER LOGIN FORM ONTO THE PARENT FORM, frmLisMini
        ParentCenter()
    End Sub

    Private Sub UserName_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles UserName.GotFocus
        'Clearing default text on GotFocus
        If UserName.Text = "Username" Then
            UserName.Text = ""
        Else
            UserName.SelectAll()
        End If

    End Sub

    Private Sub Password_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Password.GotFocus
        'Clearing password field of default text

        If Password.Text = "Password" Then
            Password.Text = ""
        Else
            Password.SelectAll()

        End If
    End Sub

    Private Sub Password_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Password.LostFocus
        'Initialize IS_PASSWORD_ENTERED variable
        isPasswordEntered = False

        'Check whether password was entered.
        If Password.Text = "" Or Password.Text = "Password" Then
            isPasswordEntered = False
            Password.Text = "Password"
        Else
            isPasswordEntered = True
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
        isUserAuthenticated = True
        Return isUserAuthenticated
    End Function

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        On Error Resume Next
        Application.Exit()
        Environment.Exit(1)
    End Sub

    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles LogIn.Click

        AuthenticateUser()
        If isUserAuthenticated = True Then
            'Enabling Parent ribbon
            frmLisMini.EnableRibbon(True)
            Dim notify As New frmNotification
            notify.ShowNotification(NotificationMessage:="User authenticated successfully!",
                NotificationTitle:="Authentication",
                NotficationPNG_IconName:="GreenTick",
                Heading:="Welcome USERNAME")
            'frmNotification.Show()
            Close()
            Dispose()
        End If
    End Sub

    Private Sub UserName_LostFocus(sender As Object, e As EventArgs) Handles UserName.LostFocus
        '1) Giving feedback on whether username was entered.
        '2) Setting default text if field is empty on lost focus.

        'Initialize IS_USERNAME_ENTERED variable as False
        isUsernameEntered = False

        If UserName.Text = "" Or UserName.Text = "Username" Then
            isUsernameEntered = False
            UserName.Text = "Username"
        Else
            isUsernameEntered = True
        End If
    End Sub

End Class