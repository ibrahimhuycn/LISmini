Public Class frmNotification

    'THIS FORM WILL BE USED TO SHOW NOTIFICATIONS WHICH DO NOT REQUITRE USER INTERACTION.
    'AUTHOR: IBRAHIM HUSSAIN
    'SWAT INC

    Dim WithEvents AnimationControl As New Timer   'TO CONTROL THE WAY NOTIFICATION SHOWS UP.
    Dim i As Integer = 0                            'COUNTER FOR LOOP USED FOR NOTIFICATION SHOW UP ANIMATION.
    Dim WithEvents LifeTime As New Timer           'TIMER WHICH HANDLES AUTOMATIC CLOSING OF NOTIFICATION. 
    Dim TicksCount As Integer = 0

    Private AlreadyActiveNotificationsNO As Integer = 1 'THIS VARIABLE DETERMINES WHETHER THERE ARE ANY PREVIOUS NOTIFICATIONS
    Private Const NotificationWindowRelocationFactor As Integer = 96 'VERTICAL DISPLACEMENT OF THE NOTIFICATION OF THE NOTIFICATION POPUP IN THE PRESENCE OF 
    'ANOTHER POPUP TO AVOID OVERLAP OF NOTIFICATION POPUP WINDOWS.

    Private Const LifeTimeInMilliseconds As Integer = 1  'THIS IS THE INTERVAL OF THE TIMER WHICH COUNTS DOWN TO CLOSE THE NOTIFICATION.

    Dim IsLocationDefault As Boolean = False 'IF THIS IS TRUE THE NOTIFICATION POPUP WINDOW WILL SET frmLisMini.IsRelocateNofitication to FALSE WHILE UNLOADING THE NOTIFICATION
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
    Public Sub ShowNotification(ByVal NotificationMessage As String, ByVal NotificationTitle As String, ByVal NotficationPNG_IconName As String, Optional ByVal Heading As String = "")
        RegisterNotification(True)

        ScreenDiametions(POINT_X, POINT_Y)

        'SETTING LOCATION RELATIVE TO SCREEN SIZE (POINT_X - 500, POINT_Y)
        NotificationLocation.X = POINT_X - 500
        NotificationLocation.Y = POINT_Y


        NotificationUI.Text = NotificationTitle
        lblNotificationMessage.Text = NotificationMessage
        lblHeading.Text = Heading

        NotificationIcon.Image = Image.FromFile(GetImagePath(NotficationPNG_IconName))


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

        If TicksCount >= 100 Then   'FADING OUT OF THE NOTIFICATION STARTS WHEN THE TIMER TICKS UPTO 100
            If Opacity > 0 Then
                Opacity -= 0.01     'WHEN THE NOTIFICATION IS TRANSPARENT, ITS UNLOADED.
            Else
                RegisterNotification(False)     'NOTIFYING THAT THE NOTIFICATION POP UP  IS UNLOADING.
                LifeTime.Stop()
                LifeTime.Enabled = False
                Close()
            End If

        Else
            TicksCount += 1
        End If

    End Sub

    Private Sub AnimationControl_Tick(sender As Object, e As EventArgs) Handles AnimationControl.Tick

        ScreenDiametions(POINT_X, POINT_Y)
        NotificationLocation.X = POINT_X - 450
        Do Until i = (200 + (AlreadyActiveNotificationsNO * NotificationWindowRelocationFactor))
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
        Notify.ShowNotification(NotificationMessage:="Hello, This is a notification.",
            NotificationTitle:="Test Notification",
            NotficationPNG_IconName:="LanTech",
            Heading:="Testing")
    End Sub
    Sub RegisterNotification(ByVal IsLoading As Boolean)

        'THIS SUB STILL HAVE SOME BUGS TO FIX. ADD COMMENTS
        Dim ErrorCount As Integer = 0

        Try

            If IsLoading = True Then    'WHEN LOADING A NOTIFICATION
                If frmLisMini.IsRelocateNofitication = False Then 'THIS VARIABLE BEING FALSE MEANS THAT THERE IS NO WINDOW AT DEFAULT POSITION
                    frmLisMini.IsRelocateNofitication = True
                    IsLocationDefault = True
                Else
                    frmLisMini.AlreadyActiveNotificationsMonitor += 1
                End If

            ElseIf IsLoading = False Then   'WHEN UNLOADING A NOTIFICATION

                If IsLocationDefault = True Then        'IF THE NOTIFICATION AT THE DEFAULT LOCATION IS UNLOADING, NEXT NOTIFICATION WILL NOT BE RELOCATED.
                    frmLisMini.IsRelocateNofitication = False
                    frmLisMini.AlreadyActiveNotificationsMonitor = 0 'IF NOTIFICATION AT DEFAULT LOCATION HAS UNLOADED, THEN NEXT NOTIFICATION SHOULD APPEAR AT DEFAULT LOCATION AND HENCE THIS VARIABLE 
                    'SHOULD RESET.

                Else
                    If frmLisMini.AlreadyActiveNotificationsMonitor >= 1 Then
                        frmLisMini.AlreadyActiveNotificationsMonitor -= 1
                    Else
                        frmLisMini.AlreadyActiveNotificationsMonitor = 0
                    End If
                End If

            End If


        Catch ex As Exception
            MsgBox(String.Format("{0}{1}Error setting notification location.", ex.Message, vbCrLf))
            ErrorCount = 1
        Finally
            If ErrorCount = 1 Then
                AlreadyActiveNotificationsNO = 1
            Else
                AlreadyActiveNotificationsNO = frmLisMini.AlreadyActiveNotificationsMonitor
            End If
        End Try
    End Sub
    Function DetermineFeasibleAmountNotifications()
        'THIS IS NOT IMPLEMENTED YET.
        'PURPOSE: THIS FUNCTION DETERMINES THE NUMBER OF WINDOWS THAT CAN BE DISPLAYED VERTICALLY ON THE OUTPUT SCREEN WITHOUT THEM OVERLAPPING
        'AND RETURNS THE NUMBER.
        Dim FeasibleAmount As Integer

        Return FeasibleAmount
    End Function
    Function GetImagePath(ImageName As String)
        'PURPOSE: PROVIDE COMPLETE PATH FOR A PNG TO BE DISPLAYED AS NOTIFICATION ICON WHEN THIS FUNCTION IS PROVIDED WITH THE IMAGE NAME. THIS AVOIDS HAVING TO CHANGE IMAGE PATH FROM EVERY SINGLE 
        'REFERENCE POINT INCASE THE PATH CHANGES.
        'ALL IMAGES ARE STORED IN A SINGLE DIRECTORY REFFERED TO AS "ImagerRootDir". THE PROVIDED "ImageName As String" IS CONCENCATED AS "ImagePath As String" AND RETURNED.

        Const ImagerRootDir As String = "C:\Users\ibrah\OneDrive\Documents\Visual Studio 2015\Projects\LISmini\LISmini\Resources\"
        Dim ImagePath As String = String.Format("{0}{1}.PNG", ImagerRootDir, ImageName)

        Return ImagePath
    End Function
End Class