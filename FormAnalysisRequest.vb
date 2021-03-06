﻿Public Class FormAnalysisRequest

    'Variables to move the form by grabbing GroupControl "gcAnalysisRequest"
    Dim DRAG_ANALYSIS_REQUEST As Boolean

    Dim MOUSE_POSITION_X As Integer
    Dim MOUSE_POSITION_Y As Integer

    'INITIALISING TEMP ANALYTE LIST, SAMPLE LIST ITEMS WILL BE ADDED ON FORM PUBLIC SUB NEW
    ReadOnly TempListAnalytes As New List(Of AnalytesRequested)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TempListAnalytes.Clear()
        TempListAnalytes.Add(New AnalytesRequested(1701, "Hb/PCV"))
        TempListAnalytes.Add(New AnalytesRequested(1703, "TLC"))
        TempListAnalytes.Add(New AnalytesRequested(1704, "DLC"))
        TempListAnalytes.Add(New AnalytesRequested(1705, "ESR"))
        TempListAnalytes.Add(New AnalytesRequested(1706, "Total RBC Count"))
        TempListAnalytes.Add(New AnalytesRequested(1707, "Reticulocyte Count"))
        TempListAnalytes.Add(New AnalytesRequested(1709, "Platelet Count"))
        TempListAnalytes.Add(New AnalytesRequested(1710, "Absolute Eosinphil Count"))
        TempListAnalytes.Add(New AnalytesRequested(1711, "Haemoparasites"))
        TempListAnalytes.Add(New AnalytesRequested(1713, "Complete Haemogram"))
        TempListAnalytes.Add(New AnalytesRequested(1712, "Blood Picture"))
        TempListAnalytes.Add(New AnalytesRequested(1714, "Osmotic Fragility"))
        TempListAnalytes.Add(New AnalytesRequested(1715, "Sickling Test"))
        TempListAnalytes.Add(New AnalytesRequested(1716, "Serum Iron"))
        TempListAnalytes.Add(New AnalytesRequested(1717, "Total Iron Binding Capacity"))
        TempListAnalytes.Add(New AnalytesRequested(1718, "Serum Ferritin"))
        TempListAnalytes.Add(New AnalytesRequested(1719, "Glucose-6-Phosphate Dehydrogenase (Qualitative)"))
        TempListAnalytes.Add(New AnalytesRequested(1720, "Glucose-6-Phosphate Dehydrogenase (Quantative)"))
        TempListAnalytes.Add(New AnalytesRequested(1721, "Blood Grouping & Rh Typing"))
        TempListAnalytes.Add(New AnalytesRequested(1722, "Direct Coombs Test"))

    End Sub

    Private Sub GcAnalysisRequest_MouseDown(sender As Object, e As MouseEventArgs) Handles gcAnalysisRequest.MouseDown

        'DRAG_ANALYSIS_REQUEST handles an IF CONDITION at mouse move event. If DRAG_ANALYSIS_REQUEST is true,
        ' and if mouse button.left is down, form is moved with cursor
        If e.Button = MouseButtons.Left Then
            DRAG_ANALYSIS_REQUEST = True
            MOUSE_POSITION_X = Cursor.Position.X - Me.Left
            MOUSE_POSITION_Y = Cursor.Position.Y - Me.Top
        End If

    End Sub

    Private Sub GcAnalysisRequest_DoubleClick(sender As Object, e As EventArgs) Handles gcAnalysisRequest.DoubleClick

        If WindowState = FormWindowState.Normal Then
            WindowState = 2 'Maximaized
            LabelClose.Visible = False
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = 0
            LabelClose.Visible = True
        End If

    End Sub

    Private Sub GcAnalysisRequest_MouseMove(sender As Object, e As MouseEventArgs) Handles gcAnalysisRequest.MouseMove

        If DRAG_ANALYSIS_REQUEST = True Then
            Top = Cursor.Position.Y - MOUSE_POSITION_Y
            Left = Cursor.Position.X - MOUSE_POSITION_X
        End If

    End Sub

    Private Sub GcAnalysisRequest_MouseUp(sender As Object, e As MouseEventArgs) Handles gcAnalysisRequest.MouseUp
        'Setting Drag Analysis Request as false on MouseUp event prevents the form being moved when the user is not
        'holding the mouse down.
        DRAG_ANALYSIS_REQUEST = False
    End Sub

    Private Sub LabelClose_Click(sender As Object, e As EventArgs) Handles LabelClose.Click
        Close()
    End Sub

End Class