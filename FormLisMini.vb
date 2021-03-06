﻿<Assembly: log4net.Config.XmlConfigurator(Watch:=True)>

Public Class FormLisMini

    'INITIALISATIONS FOR TRACKING AND LOGGING APPLICATION EVENTS, QUERIES, EXCEPTIONS ETC..
    Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(Reflection.MethodBase.GetCurrentMethod().DeclaringType)

    Public AlreadyActiveNotificationsMonitor As Integer = 0 'VARIABLE FOR DETERMING NUMBER OF ACTIVE NOFIFICATION WINDOWS ON

    'SCREEN. THIS IS TO ADJUST VERTICAL POSITION OF THE NOTIFICATIONS SO THAT ALL CAN BE SEEN ON SCREEN.
    Public IsRelocateNotification As Boolean = False 'DETERMINES WHETHER NOTIFICATION NEEDS TO BE RELOCATED FROM DEFAULT POSITION.

    Private Sub FormLisMini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disable Ribbon. Will be enabled after Authentication.
        EnableRibbon(False)

        LoadLoginScreen()
        log.Info("Form LisMini loaded!")
    End Sub

    Private Sub ButtonExit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExit.ItemClick
        On Error Resume Next
        Application.Exit()
        Environment.Exit(1)
    End Sub

    Public Sub EnableRibbon(ByVal RibbonIsEnabled As Boolean)
        If RibbonIsEnabled = True Then
            RibbonControlLisMini.Enabled = True
        ElseIf RibbonIsEnabled = False Then
            RibbonControlLisMini.Enabled = False
        End If
    End Sub

    Private Sub ButtonLogOut_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLogOut.ItemClick
        'Verify whether user wants to logout
        'Logout User, Close any and all open child forms, Disable ribbon, Display loginScreen

        Dim IsIntentionLogOut As Integer = MsgBox("Would you like to logout?", vbYesNo, "Confirm logout")   '6 = Yes, 7 = No

        'checking user response
        If IsIntentionLogOut = 6 Then
            'PENDING: log the user logout TimeStamp to database

            'Closing All open forms except Me(MdiParent)
            My.Application.OpenForms.Cast(Of Form)() _
              .Except({Me}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())

            'Disable Ribbon
            EnableRibbon(False)

            'Display loginScreen
            LoadLoginScreen()
        End If

    End Sub

    Public Sub LoadLoginScreen()

        'Opens Login Screen
        Dim Authenticate As New FormAuthenticate() With {.MdiParent = Me}
        Authenticate.Show()
    End Sub

    Public Sub AddNewPatient()

        'Opens form for new Patient Data Entry
        Dim NewPatient As New FormAddPatient() With {.MdiParent = Me}
        NewPatient.Show()
    End Sub

    Public Sub NewAR()
        Dim AR As New FormAnalysisRequest() With {.MdiParent = Me}
        AR.Show()
    End Sub

    Private Sub ButtonNewPatient_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewPatient.ItemClick
        log.Info("Showing new patient entry form...")
        AddNewPatient()
    End Sub

    Private Sub ButtonNewAr_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewAr.ItemClick
        NewAR()
    End Sub

End Class