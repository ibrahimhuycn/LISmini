
Public Class frmNotification

    'TODO: IMPLEMENT A WAY TO FADE OUT THE NOTIFICATION AS IT CLOSES. IT'S WEIRD JUST CLOSING ALL OF A SUDDEN.
    'THIS FORM WILL BE USED TO SHOW NOTIFICATIONS WHICH DO NOT REQUITRE USER INTERACTION.
    'AUTHOR: IBRAHIM HUSSAIN
    'SWAT INC

    Dim WithEvents AnimationControl As New Timer   'TO CONTROL THE WAY NOTIFICATION SHOWS UP.
    Dim i As Integer = 0                            'COUNTER FOR LOOP USED FOR NOTIFICATION SHOW UP ANIMATION.
    Dim WithEvents LifeTime As New Timer           'TIMER WHICH HANDLES AUTOMATIC CLOSING OF NOTIFICATION. 

    Private AlreadyActiveNotificationsNO As Integer = 1 'THIS VARIABLE DETERMINES WHETHER THERE ARE ANY PREVIOUS NOTIFICATIONS

    'THE CURRENT NOTIFICATION POPPED UP. THIS ALLOWS ADJUSTING THE LOCATION OF THE NOTIFICATION WNINDOW SO THAT BOTH THE 
    'NOTIFICATIONS CAN BE SEEN ON SCREEN.

    'VARIABLES TO STORE SCREEN DIAMENTIONS
    Dim NotificationLocation As New Point
    Dim POINT_X As Integer
    Dim POINT_Y As Integer
    Private Shared Sub ScreenDiametions(ByRef POINT_X As Integer, ByRef POINT_Y As Integer)

        'GETTING SCREEN WIDTH AND HEIGHT TO DETERMINE THE LOCATION FOR NOTIFICATION.
        POINT_X = Screen.PrimaryScreen.Bounds.Width
        POINT_Y = Screen.PrimaryScreen.Bounds.Height

    End Sub
    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        RegisterNotification(False)
        Close()
    End Sub
    Sub ShowNotification(ByVal NotificationMessage As String, ByVal NotificationTitle As String, ByVal LifeTimeInMilliseconds As Integer)

        RegisterNotification(True)

        ScreenDiametions(POINT_X, POINT_Y)

        'SETTING LOCATION RELATIVE TO SCREEN SIZE (POINT_X - 500, POINT_Y)
        NotificationLocation.X = POINT_X - 500
        NotificationLocation.Y = POINT_Y


        NotificationUI.Text = NotificationTitle
        lblNotificationMessage.Text = NotificationMessage
        ' NotificationIcon.Image = icon


        Location = NotificationLocation     'SETTING INITIAL LOCATION OF NOTIFICATION FORM.
        AnimationControl.Interval = 100     'SETTING INTERVAL FOR ANMATION.

        LifeTime.Interval = LifeTimeInMilliseconds
        LifeTime.Enabled = True
        LifeTime.Start()
        AnimationControl.Enabled = True
        AnimationControl.Start()

        Show()

    End Sub

    Private Sub LifeTime_Tick(sender As Object, e As EventArgs) Handles LifeTime.Tick

        'THIS EVEN IS RAISED WHEN A SPECIFIED TIME HAS ELAPSED AND NOTIFICATION SHOULD CLOSE ON THIS TICK.
        RegisterNotification(False)
        LifeTime.Stop()
        LifeTime.Enabled = False

        Close()

    End Sub

    Private Sub AnimationControl_Tick(sender As Object, e As EventArgs) Handles AnimationControl.Tick

        ScreenDiametions(POINT_X, POINT_Y)
        NotificationLocation.X = POINT_X - 450
        Do Until i = (200 + AlreadyActiveNotificationsNO)
            NotificationLocation.Y = POINT_Y - i
            Location = NotificationLocation
            i = i + 1
        Loop
        AnimationControl.Stop()
        AnimationControl.Enabled = False
        i = 0
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
    End Sub

    Private Sub NotificationIcon_Click(sender As Object, e As EventArgs) Handles NotificationIcon.Click
        Dim Notify As New frmNotification
        Notify.ShowNotification("Hello, This is a notification.", "Test Notification", 3000)
    End Sub
    Sub RegisterNotification(ByVal IsLoading As Boolean)
        Dim ErrorCount As Integer = 0
        Try
            If IsLoading = True Then
                frmLisMini.AlreadyActiveNotificationsNO += 100
            ElseIf IsLoading = False Then
                frmLisMini.AlreadyActiveNotificationsNO -= 100
            End If

        Catch ex As Exception
            MsgBox(String.Format("{0}{1}Error setting notification location.", ex.Message, vbCrLf))
            ErrorCount = 1
        Finally
            If ErrorCount = 1 Then
                AlreadyActiveNotificationsNO = 1
            Else
                AlreadyActiveNotificationsNO = frmLisMini.AlreadyActiveNotificationsNO
            End If
        End Try
    End Sub
End Class