﻿Public Class AnalytesRequested
    'THIS CLASS WILL BE USED TO
    '1) HOLD THE SELECTED ANALYTES FOR NEWANALYSIS REQUEST PRIOR TO THEM BEING WRITTEN TO SERVER.
    '2) LOAD ANALYTE LIST FROM SERVER AND HOLD THEM FOR EDITING.

    'TEMPORARY
    'THIS CLASS WILL BE USED TO HOLD A SMALL LIST OF ANALYTES FOR TESTING PERPOSES TEMPORARILY. THIS WILL BE AS AN EMULATION
    'FOR THE ANALYTE TABLE LIST ON SERVER BEFORE IMPLEMENTING THAT
    Public Sub New(AnalyteCode As Integer, AnalyteName As String)
        'THIS LIST WILL BE POPULATED WITH A SAMPLE LIST OF TEST AND THEIR CORRESPONDING CODES FOR TESTING.
        Me.analyteCode = AnalyteCode
        Me.analyteName = AnalyteName
    End Sub

    Private Property analyteCode As Integer
    Private Property analyteName As String
End Class