Public Class Home
    Public SerialToPass
    Private finalPower As Integer
    Dim unselectable(15) As String

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Application.Exit()
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Public Function isUnselectable(s As String) As Boolean
        Dim isInList As Boolean = False
        If unselectable.Length > 0 Then
            For i As Integer = 0 To unselectable.Length - 1
                If unselectable(i) <> "null" Then
                    If s = unselectable(i) Then
                        isInList = True
                        Return isInList
                    Else
                        isInList = False
                    End If
                End If
            Next
        End If
        Return isInList
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles standardComModel.SelectedIndexChanged
        For i As Integer = 0 To unselectable.Length - 1
            unselectable(i) = "null"
        Next
        If stdRadio.Checked = True Then
            seriesNum.Text = "B"
            Select Case standardComModel.SelectedIndex
                Case 0
                    nextDisplayButton.Enabled = False
                    modelNum.Text = "B"
                    unselectable(0) = "Tricolor"
                    unselectable(1) = "Mixed"
                Case 1
                    nextDisplayButton.Enabled = True
                    MsgBox("You've welected a dual-display bargraph. Fill out the form completely and then click 'Next Display' to conifgure your second display")
                    modelNum.Text = "C"
                    unselectable(0) = "Tricolor"
                    unselectable(1) = "Mixed"
                    unselectable(2) = "Auxiliary Power Supply, Regulated 24 VDC"
                    unselectable(3) = "Serial Communications, Receive Only (RS-422)"
                    unselectable(4) = "Serial Communications, Receive/Transmit (RS-422)"
                    unselectable(5) = "Yes (Default)"
                Case 2
                    nextDisplayButton.Enabled = False
                    modelNum.Text = "G"
                    unselectable(0) = "Tricolor"
                    unselectable(1) = "Mixed"
                    unselectable(2) = "HI/HI"
                    unselectable(3) = "LO/LO"
                    unselectable(4) = "HI/LO"
                    unselectable(5) = "115 VAC"
                    unselectable(6) = "230 VAC"
                    unselectable(7) = "A/C"
                    unselectable(8) = "Auxiliary Power Supply, Regulated 24 VDC"
                    unselectable(9) = "Serial Communications, Receive Only (RS-422)"
                    unselectable(10) = "Serial Communications, Receive/Transmit (RS-422)"
                Case 3
                    nextDisplayButton.Enabled = True
                    MsgBox("You've welected a dual-display bargraph. Fill out the form completely and then click 'Next Display' to conifgure your second display")
                    modelNum.Text = "H"
                    unselectable(0) = "Tricolor"
                    unselectable(1) = "Mixed"
                    unselectable(2) = "HI/HI"
                    unselectable(3) = "LO/LO"
                    unselectable(4) = "HI/LO"
                    unselectable(5) = "115 VAC"
                    unselectable(6) = "230 VAC"
                    unselectable(7) = "A/C"
                    unselectable(8) = "Auxiliary Power Supply, Regulated 24 VDC"
                    unselectable(9) = "Serial Communications, Receive Only (RS-422)"
                    unselectable(10) = "Serial Communications, Receive/Transmit (RS-422)"
                Case 4
                    nextDisplayButton.Enabled = False
                    modelNum.Text = "J"
                    unselectable(0) = "Tricolor"
                    unselectable(1) = "Mixed"
                Case 5
                    nextDisplayButton.Enabled = False
                    modelNum.Text = "K"
                    unselectable(0) = "Tricolor"
                Case 6
                    nextDisplayButton.Enabled = False
                    modelNum.Text = "L"
                    unselectable(0) = "Tricolor"
                    unselectable(1) = "Mixed"
                Case 7
                    nextDisplayButton.Enabled = True
                    MsgBox("You've welected a dual-display bargraph. Fill out the form completely and then click 'Next Display' to conifgure your second display")
                    modelNum.Text = "M"
                Case 8
                    nextDisplayButton.Enabled = False
                    modelNum.Text = "O"
                Case 9
                    nextDisplayButton.Enabled = False
                    modelNum.Text = "S"
                Case 10
                    nextDisplayButton.Enabled = False
                    modelNum.Text = "T"
                Case 11
                    nextDisplayButton.Enabled = False
                    modelNum.Text = "U"
                Case 12
                    nextDisplayButton.Enabled = False
                    modelNum.Text = "V"
                Case 13
                    nextDisplayButton.Enabled = False
                    modelNum.Text = "W"
                    unselectable(0) = "Horizontal"
                    unselectable(0) = "Tricolor"
                Case 14
                    nextDisplayButton.Enabled = True
                    MsgBox("You've welected a dual-display bargraph. Fill out the form completely and then click 'Next Display' to conifgure your second display")
                    modelNum.Text = "X"
            End Select
        End If

        Theme_Color()

        ' If comModel.Text.Chars(1) = "B" Then
        'comBarColor.Items.Remove("Amber")
        'End If
    End Sub

    Private Sub barTitle_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub comOrientation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comOrientation.SelectedIndexChanged
        If isUnselectable(comOrientation.Text) Then
            comOrientation.SelectedIndex = -1
            MsgBox("Option Unavailable With This Model")
        Else
            If comOrientation.SelectedIndex <> -1 Then
                orientationNum.Text = comOrientation.Text.Chars(0)
            End If
        End If
    End Sub

    Private Sub comBarColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBarColor.SelectedIndexChanged
        If isUnselectable(comBarColor.Text) Then
            comBarColor.SelectedIndex = -1
            MsgBox("Option Unavailable With This Model")
        Else
            If comBarColor.Text = "Mixed" Then
                barColorNum.Text = "S"
            ElseIf comBarColor.SelectedIndex <> -1 Then
                barColorNum.Text = comBarColor.Text.Chars(0)
            End If
        End If

    End Sub

    Private Sub comDigColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comDigColor.SelectedIndexChanged
        If comDigColor.Text = "None" Then
            digColorNum.Text = "X"
        ElseIf comDigColor.SelectedIndex <> -1 Then
            digColorNum.Text = comDigColor.Text.Chars(0)
        End If
    End Sub

    Private Sub comSTPColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSTPTcolor.SelectedIndexChanged
        If comSTPTcolor.Text = "None" Then
            stptNum.Text = "X"
        ElseIf comSTPTcolor.SelectedIndex <> -1 Then
            stptNum.Text = comSTPTcolor.Text.Chars(0)
        End If
    End Sub

    Private Sub comAlarmSetPoint_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comAlarmSetPoint.SelectedIndexChanged
        If isUnselectable(comAlarmSetPoint.Text) Then
            comAlarmSetPoint.SelectedIndex = -1
            MsgBox("Option Unavailable With This Model")
        Else
            If comAlarmSetPoint.Text = "HI/LO" Then
                alarmNum.Text = "A"
            ElseIf comAlarmSetPoint.Text = "None" Then
                alarmNum.Text = "X"
            ElseIf comAlarmSetPoint.SelectedIndex <> -1 Then
                alarmNum.Text = comAlarmSetPoint.Text.Chars(0)
            End If
        End If
    End Sub

    Private Sub comSwitches_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSwitches.SelectedIndexChanged
        If isUnselectable(comSwitches.Text) Then
            comSwitches.SelectedIndex = -1
            MsgBox("Option Unavailable With This Model")
        Else
            If comSwitches.Text = "None" Then
                switchesNum.Text = "X"
            Else
                switchesNum.Text = "Y"
            End If
        End If
    End Sub

    Private Sub comConformal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comConformal.SelectedIndexChanged
        Dim temp As String
        If comConformal.SelectedIndex = 0 Then
            temp = "X"
        ElseIf comConformal.SelectedIndex = 1 Then
            temp = "Y"
        ElseIf comConformal.SelectedIndex = 2 Then
            temp = "B"
        ElseIf comConformal.SelectedIndex = 3 Then
            temp = "E"
        ElseIf comConformal.SelectedIndex = 4 Then
            temp = "S"
        Else
            temp = "X"
        End If
        conformalNum.Text = temp
    End Sub

    Private Sub comPower_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPower.SelectedIndexChanged
        If isUnselectable(comPower.Text) Then
            comPower.SelectedIndex = -1
            MsgBox("Option Unavailable With This Model")
        Else
            Select Case comPower.SelectedIndex
                Case 0
                    powerNum.Text = "1"
                    finalPower = 24359652
                Case 1
                    powerNum.Text = "2"
                    finalPower = 24359662
                Case 2
                    powerNum.Text = "5"
                    finalPower = 243596
                Case 3
                    powerNum.Text = "6"
                    finalPower = 243596
                Case 4
                    powerNum.Text = "4"
                    finalPower = 243596
                Case Else
                    powerNum.Text = "8"
                    finalPower = 243596
            End Select
        End If
        Theme_Color()
    End Sub

    Private Sub comSignalUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSignalUnits.SelectedIndexChanged
        If isUnselectable(comSignalUnits.Text) Then
            comSignalUnits.SelectedIndex = -1
            MsgBox("Option Unavailable With This Model")
        Else
            Select Case comSignalUnits.SelectedIndex
                Case 0
                    unitsNum.Text = "A"
                Case 1
                    unitsNum.Text = "B"
                Case 2
                    unitsNum.Text = "C"
                Case 3
                    unitsNum.Text = "F"
                Case 4
                    unitsNum.Text = "M"
                Case 5
                    unitsNum.Text = "U"
                Case 6
                    unitsNum.Text = "V"
                Case 7
                    unitsNum.Text = "O"
            End Select
        End If
    End Sub

    Private Sub comSignalType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSignalType.SelectedIndexChanged
        If isUnselectable(comSignalType.Text) Then
            comSignalType.SelectedIndex = -1
            MsgBox("Option Unavailable With This Model")
        Else
            If comSignalType.SelectedIndex <> -1 Then
                typeNum.Text = comSignalType.Text.Chars(0)
            End If
        End If
    End Sub

    Private Sub comDecimal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comDecimal.SelectedIndexChanged
        Select Case comDecimal.SelectedIndex
            Case 0
                decimalNum.Text = "1"
            Case 1
                decimalNum.Text = "2"
            Case 2
                decimalNum.Text = "3"
            Case 3
                decimalNum.Text = "X"
        End Select
    End Sub

    Private Sub comOptionBoard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comOptionBoard.SelectedIndexChanged
        If isUnselectable(comOptionBoard.Text) Then
            comOptionBoard.SelectedIndex = -1
            MsgBox("Option Unavailable With This Model")
        Else
            Select Case comOptionBoard.SelectedIndex
                Case 0
                    optionNum.Text = "1"
                Case 1
                    optionNum.Text = "2"
                Case 2
                    optionNum.Text = "3"
                Case 3
                    optionNum.Text = "4"
                Case 4
                    optionNum.Text = "5"
                Case 5
                    optionNum.Text = "7"
                Case 6
                    optionNum.Text = "A"
                Case 7
                    optionNum.Text = "B"
                Case 8
                    optionNum.Text = "S"
                Case 9
                    optionNum.Text = "X"
            End Select
        End If
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBarStart.SelectedIndexChanged
        Select Case comBarStart.SelectedIndex
            Case 0
                startNum.Text = "B"
            Case 1
                startNum.Text = "C"
            Case 2
                startNum.Text = "T"
            Case 3
                startNum.Text = "O"
            Case 4
                startNum.Text = "1"
            Case 5
                startNum.Text = "3"
            Case 6
                startNum.Text = "5"
        End Select
    End Sub

    Private Sub ComboBox17_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSignalLinearity.SelectedIndexChanged
        Select Case comSignalLinearity.SelectedIndex
            Case 0
                linearityNum.Text = "L"
            Case 1
                linearityNum.Text = "Q"
            Case 2
                linearityNum.Text = "X"
        End Select
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Form3.Size = Me.Size
        'Form3.Location = Me.Location
        frmArtwork.Show()
        'Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        standardComModel.SelectedIndex = -1
        nuclearComModel.SelectedIndex = -1
        comQual.SelectedIndex = -1
        comOrientation.SelectedIndex = -1
        comBarColor.SelectedIndex = -1
        comDigColor.SelectedIndex = -1
        comDecimal.SelectedIndex = -1
        comSTPTcolor.SelectedIndex = -1
        comAlarmSetPoint.SelectedIndex = -1
        comSwitches.SelectedIndex = -1
        comBarStart.SelectedIndex = -1
        comPower.SelectedIndex = -1
        comSignalUnits.SelectedIndex = -1
        comSignalType.SelectedIndex = -1
        comConformal.SelectedIndex = -1
        comOptionBoard.SelectedIndex = -1
        comSignalLinearity.SelectedIndex = -1
        seriesNum.Text = "0"
        modelNum.Text = "0"
        optionNum.Text = "0"
        powerNum.Text = "0"
        decimalNum.Text = "0"
        digColorNum.Text = "0"
        barColorNum.Text = "0"
        orientationNum.Text = "0"
        stptNum.Text = "0"
        alarmNum.Text = "0"
        switchesNum.Text = "0"
        conformalNum.Text = "0"
        unitsNum.Text = "0"
        typeNum.Text = "0"
        startNum.Text = "0"
        linearityNum.Text = "0"
        Label21.Text = "0"
        Label22.Text = "0"
        Label25.Text = "0"
        Label26.Text = "0"
        Label28.Text = "0"
        stdRadio.Checked = False
        nucRadio.Checked = False
        'part color reset
        seriesNum.ForeColor = SystemColors.ControlText
        powerNum.ForeColor = SystemColors.ControlText
        modelNum.ForeColor = SystemColors.ControlText
        orientationNum.ForeColor = SystemColors.ControlText
        barColorNum.ForeColor = SystemColors.ControlText
        digColorNum.ForeColor = SystemColors.ControlText
        decimalNum.ForeColor = SystemColors.ControlText
        stptNum.ForeColor = SystemColors.ControlText
        alarmNum.ForeColor = SystemColors.ControlText
        switchesNum.ForeColor = SystemColors.ControlText
        unitsNum.ForeColor = SystemColors.ControlText
        typeNum.ForeColor = SystemColors.ControlText
        linearityNum.ForeColor = SystemColors.ControlText
        optionNum.ForeColor = SystemColors.ControlText
        startNum.ForeColor = SystemColors.ControlText
        conformalNum.ForeColor = SystemColors.ControlText
        Label21.ForeColor = SystemColors.ControlText
        Label22.ForeColor = SystemColors.ControlText
        Label25.ForeColor = SystemColors.ControlText
        Label26.ForeColor = SystemColors.ControlText
        Label28.ForeColor = SystemColors.ControlText
        lblCustArt.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comQual.Enabled = False
        nuclearComModel.Visible = False
        standardComModel.Visible = False
    End Sub

    Private Sub LastFiveDigitsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmArtwork.Size = Me.Size
        frmArtwork.Location = Me.Location
        frmArtwork.Show()
        Me.Hide()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        frmSearch.Size = Me.Size
        frmSearch.Location = Me.Location
        frmSearch.Show()
        Me.Hide()
    End Sub

    Private Sub EmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailToolStripMenuItem.Click
        frmEmail.Size = Me.Size
        frmEmail.Location = Me.Location
        frmEmail.Show()
        Me.Hide()
    End Sub

    Function getSerial()
        SerialToPass = seriesNum.Text
        SerialToPass += modelNum.Text
        SerialToPass += orientationNum.Text
        SerialToPass += barColorNum.Text
        SerialToPass += digColorNum.Text
        SerialToPass += decimalNum.Text
        SerialToPass += stptNum.Text
        SerialToPass += alarmNum.Text
        SerialToPass += switchesNum.Text
        SerialToPass += powerNum.Text
        SerialToPass += unitsNum.Text
        SerialToPass += typeNum.Text
        SerialToPass += linearityNum.Text
        SerialToPass += optionNum.Text
        SerialToPass += startNum.Text
        SerialToPass += conformalNum.Text
        SerialToPass += Label21.Text
        SerialToPass += Label22.Text
        SerialToPass += Label26.Text
        SerialToPass += Label28.Text
        SerialToPass += Label25.Text

        Return SerialToPass
    End Function

    Private Sub CreateFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateFormToolStripMenuItem.Click

        getSerial()
        frmEmail.Size = Me.Size
        frmEmail.Location = Me.Location
        frmEmail.Show()
        Me.Hide()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Function Theme_Color()
        Select Case GlobalVariables.ThemeColor
            Case "Default"
                Me.BackColor = SystemColors.Control
                Me.ForeColor = SystemColors.ControlText
                Me.MenuStrip1.BackColor = SystemColors.Control
                Me.GroupBox1.ForeColor = SystemColors.ControlText
                Me.GroupBox2.ForeColor = SystemColors.ControlText
                Me.GroupBox3.ForeColor = SystemColors.ControlText
                Me.GroupBox1.BackColor = SystemColors.Control
                Me.GroupBox2.BackColor = SystemColors.Control
                Me.GroupBox3.BackColor = SystemColors.Control
                Me.FileToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.EditToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.ViewToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.NavigationToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.ExportToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.Label18.ForeColor = SystemColors.ControlText
                Me.Label1.ForeColor = SystemColors.ControlText
                Me.Label2.ForeColor = SystemColors.ControlText
                Me.Label3.ForeColor = SystemColors.ControlText
                Me.Label4.ForeColor = SystemColors.ControlText
                Me.Label5.ForeColor = SystemColors.ControlText
                Me.Label6.ForeColor = SystemColors.ControlText
                Me.Label7.ForeColor = SystemColors.ControlText
                Me.Label8.ForeColor = SystemColors.ControlText
                Me.Label9.ForeColor = SystemColors.ControlText
                Me.Label10.ForeColor = SystemColors.ControlText
                Me.Label11.ForeColor = SystemColors.ControlText
                Me.Label12.ForeColor = SystemColors.ControlText
                Me.Label14.ForeColor = SystemColors.ControlText
                Me.Label15.ForeColor = SystemColors.ControlText
                Me.Label16.ForeColor = SystemColors.ControlText
                Me.Label17.ForeColor = SystemColors.ControlText
                Me.comQual.ForeColor = SystemColors.ControlText
                Me.standardComModel.ForeColor = SystemColors.ControlText
                Me.comOrientation.ForeColor = SystemColors.ControlText
                Me.comBarColor.ForeColor = SystemColors.ControlText
                Me.comDigColor.ForeColor = SystemColors.ControlText
                Me.comSTPTcolor.ForeColor = SystemColors.ControlText
                Me.comAlarmSetPoint.ForeColor = SystemColors.ControlText
                Me.comSwitches.ForeColor = SystemColors.ControlText
                Me.comConformal.ForeColor = SystemColors.ControlText
                Me.comPower.ForeColor = SystemColors.ControlText
                Me.comDecimal.ForeColor = SystemColors.ControlText
                Me.comSignalType.ForeColor = SystemColors.ControlText
                Me.comSignalUnits.ForeColor = SystemColors.ControlText
                Me.comOptionBoard.ForeColor = SystemColors.ControlText
                Me.comBarStart.ForeColor = SystemColors.ControlText
                Me.comSignalLinearity.ForeColor = SystemColors.ControlText
                Me.comQual.BackColor = SystemColors.Control
                Me.nuclearComModel.ForeColor = SystemColors.ControlText
                Me.nuclearComModel.BackColor = SystemColors.Window
                Me.standardComModel.BackColor = SystemColors.Control
                Me.comOrientation.BackColor = SystemColors.Control
                Me.comBarColor.BackColor = SystemColors.Control
                Me.comDigColor.BackColor = SystemColors.Control
                Me.comSTPTcolor.BackColor = SystemColors.Control
                Me.comAlarmSetPoint.BackColor = SystemColors.Control
                Me.comSwitches.BackColor = SystemColors.Control
                Me.comConformal.BackColor = SystemColors.Control
                Me.comPower.BackColor = SystemColors.Control
                Me.comDecimal.BackColor = SystemColors.Control
                Me.comSignalType.BackColor = SystemColors.Control
                Me.comSignalUnits.BackColor = SystemColors.Control
                Me.comOptionBoard.BackColor = SystemColors.Control
                Me.comBarStart.BackColor = SystemColors.Control
                Me.comSignalLinearity.BackColor = SystemColors.Control
                If (powerNum.Text <> "0") Then
                    powerNum.ForeColor = SystemColors.ControlText
                End If
                If (seriesNum.Text <> "0") Then
                    seriesNum.ForeColor = SystemColors.ControlText
                End If
                If (modelNum.Text <> "0") Then
                    modelNum.ForeColor = SystemColors.ControlText
                End If
                If (orientationNum.Text <> "0") Then
                    orientationNum.ForeColor = SystemColors.ControlText
                End If
                If (barColorNum.Text <> "0") Then
                    barColorNum.ForeColor = SystemColors.ControlText
                End If
                If (digColorNum.Text <> "0") Then
                    digColorNum.ForeColor = SystemColors.ControlText
                End If
                If (decimalNum.Text <> "0") Then
                    decimalNum.ForeColor = SystemColors.ControlText
                End If
                If (stptNum.Text <> "0") Then
                    stptNum.ForeColor = SystemColors.ControlText
                End If
                If (alarmNum.Text <> "0") Then
                    alarmNum.ForeColor = SystemColors.ControlText
                End If
                If (switchesNum.Text <> "0") Then
                    switchesNum.ForeColor = SystemColors.ControlText
                End If
                If (unitsNum.Text <> "0") Then
                    unitsNum.ForeColor = SystemColors.ControlText
                End If
                If (typeNum.Text <> "0") Then
                    typeNum.ForeColor = SystemColors.ControlText
                End If
                If (linearityNum.Text <> "0") Then
                    linearityNum.ForeColor = SystemColors.ControlText
                End If
                If (optionNum.Text <> "0") Then
                    optionNum.ForeColor = SystemColors.ControlText
                End If
                If (startNum.Text <> "0") Then
                    startNum.ForeColor = SystemColors.ControlText
                End If
                If (conformalNum.Text <> "0") Then
                    conformalNum.ForeColor = SystemColors.ControlText
                End If
                If (Label21.Text <> "0") Then
                    Label21.ForeColor = SystemColors.ControlText
                End If
                If (Label22.Text <> "0") Then
                    Label22.ForeColor = SystemColors.ControlText
                End If
                If (Label26.Text <> "0") Then
                    Label26.ForeColor = SystemColors.ControlText
                End If
                If (Label28.Text <> "0") Then
                    Label28.ForeColor = SystemColors.ControlText
                End If
                If (Label25.Text <> "0") Then
                    Label25.ForeColor = SystemColors.ControlText
                End If
                If (lblCustArt.Text <> "0") Then
                    lblCustArt.ForeColor = SystemColors.ControlText
                End If

                'form2
                Form2.BackColor = SystemColors.Control
                Form2.ListBox1.BackColor = SystemColors.Window
                Form2.ListBox1.ForeColor = SystemColors.ControlText
                Form2.Label1.ForeColor = SystemColors.ControlText

                'form3 artwork
                frmArtwork.BackColor = SystemColors.Control
                frmArtwork.grpbxCaption.BackColor = SystemColors.Control
                frmArtwork.GroupBox2.BackColor = SystemColors.Control
                frmArtwork.GroupBox3.BackColor = SystemColors.Control
                frmArtwork.grpbxCaption.ForeColor = SystemColors.ControlText
                frmArtwork.GroupBox2.ForeColor = SystemColors.ControlText
                frmArtwork.GroupBox3.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxMisc.BackColor = SystemColors.Window
                frmArtwork.cmbxMisc.ForeColor = SystemColors.ControlText
                frmArtwork.scaleList.BackColor = SystemColors.Window
                frmArtwork.scaleList.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxAC.BackColor = SystemColors.Window
                frmArtwork.cmbxAC.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxDC.BackColor = SystemColors.Window
                frmArtwork.cmbxDC.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxFlowRate.BackColor = SystemColors.Window
                frmArtwork.cmbxFlowRate.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxLevel.BackColor = SystemColors.Window
                frmArtwork.cmbxLevel.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxPressure.BackColor = SystemColors.Window
                frmArtwork.cmbxPressure.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxTemp.BackColor = SystemColors.Window
                frmArtwork.cmbxTemp.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxVolume.BackColor = SystemColors.Window
                frmArtwork.cmbxVolume.ForeColor = SystemColors.ControlText
                frmArtwork.Button4.ForeColor = SystemColors.ControlText

                'form email
                frmEmail.BackColor = SystemColors.Control
                frmEmail.MenuStrip1.BackColor = SystemColors.Control
                frmEmail.MenuStrip1.ForeColor = SystemColors.ControlText
                frmEmail.lblCustomerEmailAddress.ForeColor = SystemColors.ControlText
                frmEmail.lblEmployeeEmail.ForeColor = SystemColors.ControlText
                frmEmail.lblEmailSubject.ForeColor = SystemColors.ControlText
                frmEmail.lblEmailBody.ForeColor = SystemColors.ControlText
                frmEmail.txtbxCustomerEmailAddress.BackColor = SystemColors.Window
                frmEmail.txtbxCustomerEmailAddress.ForeColor = SystemColors.ControlText
                frmEmail.txtbxEmployeeEmail.BackColor = SystemColors.Window
                frmEmail.txtbxEmployeeEmail.ForeColor = SystemColors.ControlText
                frmEmail.txtbxEmailSubject.BackColor = SystemColors.Window
                frmEmail.txtbxEmailSubject.ForeColor = SystemColors.ControlText
                frmEmail.rtxtbxEmailBody.BackColor = SystemColors.Window
                frmEmail.rtxtbxEmailBody.ForeColor = SystemColors.ControlText

                'form search
                frmSearch.BackColor = SystemColors.Control
                frmSearch.MenuStrip1.BackColor = SystemColors.Control
                frmSearch.MenuStrip1.ForeColor = SystemColors.ControlText
                frmSearch.grpbxSearchOptions.BackColor = SystemColors.Control
                frmSearch.grpbxSearchOptions.ForeColor = SystemColors.ControlText
                frmSearch.btnSearch.ForeColor = SystemColors.ControlText
                frmSearch.txtbxCustID.BackColor = SystemColors.Window
                frmSearch.txtbxCustID.ForeColor = SystemColors.ControlText
                frmSearch.txtbxCustName.BackColor = SystemColors.Window
                frmSearch.txtbxCustName.ForeColor = SystemColors.ControlText
                frmSearch.txtbxQuoteNum.BackColor = SystemColors.Window
                frmSearch.txtbxQuoteNum.ForeColor = SystemColors.ControlText
                frmSearch.txtbxQuoteQty.BackColor = SystemColors.Window
                frmSearch.txtbxQuoteQty.ForeColor = SystemColors.ControlText
                frmSearch.txtbxQuoteWorth.BackColor = SystemColors.Window
                frmSearch.txtbxQuoteWorth.ForeColor = SystemColors.ControlText

                'form custom art
                frmCustomArt.BackColor = SystemColors.Control
                frmCustomArt.Label1.ForeColor = SystemColors.ControlText
                frmCustomArt.txtbxCustNum.BackColor = SystemColors.Window
                frmCustomArt.txtbxCustNum.ForeColor = SystemColors.ControlText

                'form sales
                frmSales.BackColor = SystemColors.Control
                frmSales.ForeColor = SystemColors.ControlText
                frmSales.txtbxCompAssem.BackColor = SystemColors.Window
                frmSales.finalAssemNum.BackColor = SystemColors.Window
                frmSales.txtbxManual.BackColor = SystemColors.Window
                frmSales.txtbxScaleNuber.BackColor = SystemColors.Window

            Case "GrayRed"
                Me.GroupBox1.ForeColor = SystemColors.ControlText
                Me.GroupBox2.ForeColor = SystemColors.ControlText
                Me.GroupBox3.ForeColor = SystemColors.ControlText
                Me.GroupBox1.BackColor = Color.DarkRed
                Me.GroupBox2.BackColor = Color.DarkRed
                Me.GroupBox3.BackColor = Color.DarkRed
                Me.BackColor = SystemColors.ControlDarkDark
                Me.MenuStrip1.BackColor = SystemColors.ControlDark
                Me.FileToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.EditToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.ViewToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.NavigationToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.ExportToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.Label1.ForeColor = Color.NavajoWhite
                Me.Label2.ForeColor = Color.NavajoWhite
                Me.Label3.ForeColor = Color.NavajoWhite
                Me.Label4.ForeColor = Color.NavajoWhite
                Me.Label5.ForeColor = Color.NavajoWhite
                Me.Label6.ForeColor = Color.NavajoWhite
                Me.Label7.ForeColor = Color.NavajoWhite
                Me.Label8.ForeColor = Color.NavajoWhite
                Me.Label9.ForeColor = Color.NavajoWhite
                Me.Label10.ForeColor = Color.NavajoWhite
                Me.Label11.ForeColor = Color.NavajoWhite
                Me.Label12.ForeColor = Color.NavajoWhite
                Me.Label14.ForeColor = Color.NavajoWhite
                Me.Label15.ForeColor = Color.NavajoWhite
                Me.Label16.ForeColor = Color.NavajoWhite
                Me.Label17.ForeColor = Color.NavajoWhite
                Me.Label18.ForeColor = Color.NavajoWhite
                Me.comQual.ForeColor = Color.NavajoWhite
                Me.standardComModel.ForeColor = Color.NavajoWhite
                Me.comOrientation.ForeColor = Color.NavajoWhite
                Me.comBarColor.ForeColor = Color.NavajoWhite
                Me.comDigColor.ForeColor = Color.NavajoWhite
                Me.comSTPTcolor.ForeColor = Color.NavajoWhite
                Me.comAlarmSetPoint.ForeColor = Color.NavajoWhite
                Me.comSwitches.ForeColor = Color.NavajoWhite
                Me.comConformal.ForeColor = Color.NavajoWhite
                Me.comPower.ForeColor = Color.NavajoWhite
                Me.comDecimal.ForeColor = Color.NavajoWhite
                Me.comSignalType.ForeColor = Color.NavajoWhite
                Me.comSignalUnits.ForeColor = Color.NavajoWhite
                Me.comOptionBoard.ForeColor = Color.NavajoWhite
                Me.comBarStart.ForeColor = Color.NavajoWhite
                Me.comSignalLinearity.ForeColor = Color.NavajoWhite
                Me.comQual.BackColor = SystemColors.ControlDarkDark
                Me.nuclearComModel.ForeColor = Color.NavajoWhite
                Me.nuclearComModel.BackColor = SystemColors.ControlDarkDark
                Me.standardComModel.BackColor = SystemColors.ControlDarkDark
                Me.comOrientation.BackColor = SystemColors.ControlDarkDark
                Me.comBarColor.BackColor = SystemColors.ControlDarkDark
                Me.comDigColor.BackColor = SystemColors.ControlDarkDark
                Me.comSTPTcolor.BackColor = SystemColors.ControlDarkDark
                Me.comAlarmSetPoint.BackColor = SystemColors.ControlDarkDark
                Me.comSwitches.BackColor = SystemColors.ControlDarkDark
                Me.comConformal.BackColor = SystemColors.ControlDarkDark
                Me.comPower.BackColor = SystemColors.ControlDarkDark
                Me.comDecimal.BackColor = SystemColors.ControlDarkDark
                Me.comSignalType.BackColor = SystemColors.ControlDarkDark
                Me.comSignalUnits.BackColor = SystemColors.ControlDarkDark
                Me.comOptionBoard.BackColor = SystemColors.ControlDarkDark
                Me.comBarStart.BackColor = SystemColors.ControlDarkDark
                Me.comSignalLinearity.BackColor = SystemColors.ControlDarkDark
                If (powerNum.Text <> "0") Then
                    powerNum.ForeColor = Color.DarkRed
                End If
                If (seriesNum.Text <> "0") Then
                    seriesNum.ForeColor = Color.DarkRed
                End If
                If (modelNum.Text <> "0") Then
                    modelNum.ForeColor = Color.DarkRed
                End If
                If (orientationNum.Text <> "0") Then
                    orientationNum.ForeColor = Color.DarkRed
                End If
                If (barColorNum.Text <> "0") Then
                    barColorNum.ForeColor = Color.DarkRed
                End If
                If (digColorNum.Text <> "0") Then
                    digColorNum.ForeColor = Color.DarkRed
                End If
                If (decimalNum.Text <> "0") Then
                    decimalNum.ForeColor = Color.DarkRed
                End If
                If (stptNum.Text <> "0") Then
                    stptNum.ForeColor = Color.DarkRed
                End If
                If (alarmNum.Text <> "0") Then
                    alarmNum.ForeColor = Color.DarkRed
                End If
                If (switchesNum.Text <> "0") Then
                    switchesNum.ForeColor = Color.DarkRed
                End If
                If (unitsNum.Text <> "0") Then
                    unitsNum.ForeColor = Color.DarkRed
                End If
                If (typeNum.Text <> "0") Then
                    typeNum.ForeColor = Color.DarkRed
                End If
                If (linearityNum.Text <> "0") Then
                    linearityNum.ForeColor = Color.DarkRed
                End If
                If (optionNum.Text <> "0") Then
                    optionNum.ForeColor = Color.DarkRed
                End If
                If (startNum.Text <> "0") Then
                    startNum.ForeColor = Color.DarkRed
                End If
                If (conformalNum.Text <> "0") Then
                    conformalNum.ForeColor = Color.DarkRed
                End If
                If (Label21.Text <> "0") Then
                    Label21.ForeColor = Color.DarkRed
                End If
                If (Label22.Text <> "0") Then
                    Label22.ForeColor = Color.DarkRed
                End If
                If (Label26.Text <> "0") Then
                    Label26.ForeColor = Color.DarkRed
                End If
                If (Label28.Text <> "0") Then
                    Label28.ForeColor = Color.DarkRed
                End If
                If (Label25.Text <> "0") Then
                    Label25.ForeColor = Color.DarkRed
                End If
                If (lblCustArt.Text <> "0") Then
                    lblCustArt.ForeColor = Color.DarkRed
                End If

                'form2
                Form2.BackColor = SystemColors.ControlDarkDark
                Form2.ListBox1.BackColor = Color.DarkRed
                Form2.ListBox1.ForeColor = Color.NavajoWhite
                Form2.Label1.ForeColor = Color.NavajoWhite

                'form3
                frmArtwork.BackColor = SystemColors.ControlDarkDark
                frmArtwork.grpbxCaption.BackColor = Color.DarkRed
                frmArtwork.GroupBox2.BackColor = Color.DarkRed
                frmArtwork.GroupBox3.BackColor = SystemColors.ControlDarkDark
                frmArtwork.grpbxCaption.ForeColor = Color.NavajoWhite
                frmArtwork.GroupBox2.ForeColor = Color.NavajoWhite
                frmArtwork.GroupBox3.ForeColor = Color.NavajoWhite
                frmArtwork.cmbxMisc.BackColor = SystemColors.ControlDarkDark
                frmArtwork.cmbxMisc.ForeColor = Color.NavajoWhite
                frmArtwork.scaleList.BackColor = SystemColors.ControlDark
                frmArtwork.scaleList.ForeColor = Color.NavajoWhite
                frmArtwork.cmbxAC.BackColor = SystemColors.ControlDarkDark
                frmArtwork.cmbxAC.ForeColor = Color.NavajoWhite
                frmArtwork.cmbxDC.BackColor = SystemColors.ControlDarkDark
                frmArtwork.cmbxDC.ForeColor = Color.NavajoWhite
                frmArtwork.cmbxFlowRate.BackColor = SystemColors.ControlDarkDark
                frmArtwork.cmbxFlowRate.ForeColor = Color.NavajoWhite
                frmArtwork.cmbxLevel.BackColor = SystemColors.ControlDarkDark
                frmArtwork.cmbxLevel.ForeColor = Color.NavajoWhite
                frmArtwork.cmbxPressure.BackColor = SystemColors.ControlDarkDark
                frmArtwork.cmbxPressure.ForeColor = Color.NavajoWhite
                frmArtwork.cmbxTemp.BackColor = SystemColors.ControlDarkDark
                frmArtwork.cmbxTemp.ForeColor = Color.NavajoWhite
                frmArtwork.cmbxVolume.BackColor = SystemColors.ControlDarkDark
                frmArtwork.cmbxVolume.ForeColor = Color.NavajoWhite
                frmArtwork.Button4.ForeColor = SystemColors.ControlText

                'form email
                frmEmail.BackColor = SystemColors.ControlDarkDark
                frmEmail.MenuStrip1.BackColor = SystemColors.ControlDark
                frmEmail.MenuStrip1.ForeColor = SystemColors.ControlText
                frmEmail.lblCustomerEmailAddress.ForeColor = Color.NavajoWhite
                frmEmail.lblEmployeeEmail.ForeColor = Color.NavajoWhite
                frmEmail.lblEmailSubject.ForeColor = Color.NavajoWhite
                frmEmail.lblEmailBody.ForeColor = Color.NavajoWhite
                frmEmail.txtbxCustomerEmailAddress.BackColor = Color.DarkRed
                frmEmail.txtbxCustomerEmailAddress.ForeColor = Color.NavajoWhite
                frmEmail.txtbxEmployeeEmail.BackColor = Color.DarkRed
                frmEmail.txtbxEmployeeEmail.ForeColor = Color.NavajoWhite
                frmEmail.txtbxEmailSubject.BackColor = Color.DarkRed
                frmEmail.txtbxEmailSubject.ForeColor = Color.NavajoWhite
                frmEmail.rtxtbxEmailBody.BackColor = Color.DarkRed
                frmEmail.rtxtbxEmailBody.ForeColor = Color.NavajoWhite

                'form search
                frmSearch.BackColor = SystemColors.ControlDarkDark
                frmSearch.MenuStrip1.BackColor = SystemColors.ControlDark
                frmSearch.MenuStrip1.ForeColor = SystemColors.ControlText
                frmSearch.grpbxSearchOptions.BackColor = Color.DarkRed
                frmSearch.grpbxSearchOptions.ForeColor = Color.NavajoWhite
                frmSearch.btnSearch.ForeColor = SystemColors.ControlText
                frmSearch.txtbxCustID.BackColor = SystemColors.ControlDarkDark
                frmSearch.txtbxCustID.ForeColor = Color.NavajoWhite
                frmSearch.txtbxCustName.BackColor = SystemColors.ControlDarkDark
                frmSearch.txtbxCustName.ForeColor = Color.NavajoWhite
                frmSearch.txtbxQuoteNum.BackColor = SystemColors.ControlDarkDark
                frmSearch.txtbxQuoteNum.ForeColor = Color.NavajoWhite
                frmSearch.txtbxQuoteQty.BackColor = SystemColors.ControlDarkDark
                frmSearch.txtbxQuoteQty.ForeColor = Color.NavajoWhite
                frmSearch.txtbxQuoteWorth.BackColor = SystemColors.ControlDarkDark
                frmSearch.txtbxQuoteWorth.ForeColor = Color.NavajoWhite

                'form custom art
                frmCustomArt.BackColor = SystemColors.ControlDarkDark
                frmCustomArt.Label1.ForeColor = Color.NavajoWhite
                frmCustomArt.txtbxCustNum.BackColor = Color.DarkRed
                frmCustomArt.txtbxCustNum.ForeColor = Color.NavajoWhite

                'form sales
                frmSales.BackColor = SystemColors.Control
                frmSales.ForeColor = SystemColors.ControlText
                frmSales.txtbxCompAssem.BackColor = SystemColors.Window
                frmSales.finalAssemNum.BackColor = SystemColors.Window
                frmSales.txtbxManual.BackColor = SystemColors.Window
                frmSales.txtbxScaleNuber.BackColor = SystemColors.Window

            Case "TealOrange"
                Me.GroupBox1.ForeColor = SystemColors.ControlText
                Me.GroupBox2.ForeColor = SystemColors.ControlText
                Me.GroupBox3.ForeColor = SystemColors.ControlText
                Me.GroupBox1.BackColor = Color.Gold
                Me.GroupBox2.BackColor = Color.Gold
                Me.GroupBox3.BackColor = Color.Gold
                Me.BackColor = Color.Teal
                Me.MenuStrip1.BackColor = Color.DarkSlateGray
                Me.FileToolStripMenuItem.ForeColor = Color.Orange
                Me.EditToolStripMenuItem.ForeColor = Color.Orange
                Me.ViewToolStripMenuItem.ForeColor = Color.Orange
                Me.NavigationToolStripMenuItem.ForeColor = Color.Orange
                Me.ExportToolStripMenuItem.ForeColor = Color.Orange
                Me.Label1.ForeColor = SystemColors.ControlText
                Me.Label2.ForeColor = SystemColors.ControlText
                Me.Label3.ForeColor = SystemColors.ControlText
                Me.Label4.ForeColor = SystemColors.ControlText
                Me.Label5.ForeColor = SystemColors.ControlText
                Me.Label6.ForeColor = SystemColors.ControlText
                Me.Label7.ForeColor = SystemColors.ControlText
                Me.Label8.ForeColor = SystemColors.ControlText
                Me.Label9.ForeColor = SystemColors.ControlText
                Me.Label10.ForeColor = SystemColors.ControlText
                Me.Label11.ForeColor = SystemColors.ControlText
                Me.Label12.ForeColor = SystemColors.ControlText
                Me.Label14.ForeColor = SystemColors.ControlText
                Me.Label15.ForeColor = SystemColors.ControlText
                Me.Label16.ForeColor = SystemColors.ControlText
                Me.Label17.ForeColor = SystemColors.ControlText
                Me.Label18.ForeColor = Color.Orange
                Me.comQual.ForeColor = Color.Orange
                Me.standardComModel.ForeColor = Color.Orange
                Me.comOrientation.ForeColor = Color.Orange
                Me.comBarColor.ForeColor = Color.Orange
                Me.comDigColor.ForeColor = Color.Orange
                Me.comSTPTcolor.ForeColor = Color.Orange
                Me.comAlarmSetPoint.ForeColor = Color.Orange
                Me.comSwitches.ForeColor = Color.Orange
                Me.comConformal.ForeColor = Color.Orange
                Me.comPower.ForeColor = Color.Orange
                Me.comDecimal.ForeColor = Color.Orange
                Me.comSignalType.ForeColor = Color.Orange
                Me.comSignalUnits.ForeColor = Color.Orange
                Me.comOptionBoard.ForeColor = Color.Orange
                Me.comBarStart.ForeColor = Color.Orange
                Me.comSignalLinearity.ForeColor = Color.Orange
                Me.comQual.BackColor = Color.DarkSlateGray
                Me.nuclearComModel.ForeColor = Color.Orange
                Me.nuclearComModel.BackColor = Color.DarkSlateGray
                Me.standardComModel.BackColor = Color.DarkSlateGray
                Me.comOrientation.BackColor = Color.DarkSlateGray
                Me.comBarColor.BackColor = Color.DarkSlateGray
                Me.comDigColor.BackColor = Color.DarkSlateGray
                Me.comSTPTcolor.BackColor = Color.DarkSlateGray
                Me.comAlarmSetPoint.BackColor = Color.DarkSlateGray
                Me.comSwitches.BackColor = Color.DarkSlateGray
                Me.comConformal.BackColor = Color.DarkSlateGray
                Me.comPower.BackColor = Color.DarkSlateGray
                Me.comDecimal.BackColor = Color.DarkSlateGray
                Me.comSignalType.BackColor = Color.DarkSlateGray
                Me.comSignalUnits.BackColor = Color.DarkSlateGray
                Me.comOptionBoard.BackColor = Color.DarkSlateGray
                Me.comBarStart.BackColor = Color.DarkSlateGray
                Me.comSignalLinearity.BackColor = Color.DarkSlateGray
                If (powerNum.Text <> "0") Then
                    powerNum.ForeColor = Color.Orange
                End If
                If (seriesNum.Text <> "0") Then
                    seriesNum.ForeColor = Color.Orange
                End If
                If (modelNum.Text <> "0") Then
                    modelNum.ForeColor = Color.Orange
                End If
                If (orientationNum.Text <> "0") Then
                    orientationNum.ForeColor = Color.Orange
                End If
                If (barColorNum.Text <> "0") Then
                    barColorNum.ForeColor = Color.Orange
                End If
                If (digColorNum.Text <> "0") Then
                    digColorNum.ForeColor = Color.Orange
                End If
                If (decimalNum.Text <> "0") Then
                    decimalNum.ForeColor = Color.Orange
                End If
                If (stptNum.Text <> "0") Then
                    stptNum.ForeColor = Color.Orange
                End If
                If (alarmNum.Text <> "0") Then
                    alarmNum.ForeColor = Color.Orange
                End If
                If (switchesNum.Text <> "0") Then
                    switchesNum.ForeColor = Color.Orange
                End If
                If (unitsNum.Text <> "0") Then
                    unitsNum.ForeColor = Color.Orange
                End If
                If (typeNum.Text <> "0") Then
                    typeNum.ForeColor = Color.Orange
                End If
                If (linearityNum.Text <> "0") Then
                    linearityNum.ForeColor = Color.Orange
                End If
                If (optionNum.Text <> "0") Then
                    optionNum.ForeColor = Color.Orange
                End If
                If (startNum.Text <> "0") Then
                    startNum.ForeColor = Color.Orange
                End If
                If (conformalNum.Text <> "0") Then
                    conformalNum.ForeColor = Color.Orange
                End If
                If (Label21.Text <> "0") Then
                    Label21.ForeColor = Color.Orange
                End If
                If (Label22.Text <> "0") Then
                    Label22.ForeColor = Color.Orange
                End If
                If (Label26.Text <> "0") Then
                    Label26.ForeColor = Color.Orange
                End If
                If (Label28.Text <> "0") Then
                    Label28.ForeColor = Color.Orange
                End If
                If (Label25.Text <> "0") Then
                    Label25.ForeColor = Color.Orange
                End If
                If (lblCustArt.Text <> "0") Then
                    lblCustArt.ForeColor = Color.Orange
                End If

                'form2
                Form2.BackColor = Color.Teal
                Form2.ListBox1.BackColor = Color.Gold
                Form2.ListBox1.ForeColor = Color.DarkSlateGray
                Form2.Label1.ForeColor = Color.Orange

                'form3
                frmArtwork.BackColor = Color.Teal
                frmArtwork.grpbxCaption.BackColor = Color.Gold
                frmArtwork.GroupBox2.BackColor = Color.Gold
                frmArtwork.GroupBox3.BackColor = Color.Teal
                frmArtwork.grpbxCaption.ForeColor = Color.DarkSlateGray
                frmArtwork.GroupBox2.ForeColor = Color.DarkSlateGray
                frmArtwork.GroupBox3.ForeColor = Color.Orange
                frmArtwork.cmbxMisc.BackColor = Color.Teal
                frmArtwork.cmbxMisc.ForeColor = Color.Orange
                frmArtwork.scaleList.BackColor = Color.DarkSlateGray
                frmArtwork.scaleList.ForeColor = Color.Orange
                frmArtwork.cmbxAC.BackColor = Color.Teal
                frmArtwork.cmbxAC.ForeColor = Color.Orange
                frmArtwork.cmbxDC.BackColor = Color.Teal
                frmArtwork.cmbxDC.ForeColor = Color.Orange
                frmArtwork.cmbxFlowRate.BackColor = Color.Teal
                frmArtwork.cmbxFlowRate.ForeColor = Color.Orange
                frmArtwork.cmbxLevel.BackColor = Color.Teal
                frmArtwork.cmbxLevel.ForeColor = Color.Orange
                frmArtwork.cmbxPressure.BackColor = Color.Teal
                frmArtwork.cmbxPressure.ForeColor = Color.Orange
                frmArtwork.cmbxTemp.BackColor = Color.Teal
                frmArtwork.cmbxTemp.ForeColor = Color.Orange
                frmArtwork.cmbxVolume.BackColor = Color.Teal
                frmArtwork.cmbxVolume.ForeColor = Color.Orange
                frmArtwork.Button4.ForeColor = SystemColors.ControlText

                'form email
                frmEmail.BackColor = Color.Teal
                frmEmail.MenuStrip1.BackColor = Color.DarkSlateGray
                frmEmail.MenuStrip1.ForeColor = Color.Orange
                frmEmail.lblCustomerEmailAddress.ForeColor = Color.Orange
                frmEmail.lblEmployeeEmail.ForeColor = Color.Orange
                frmEmail.lblEmailSubject.ForeColor = Color.Orange
                frmEmail.lblEmailBody.ForeColor = Color.Orange
                frmEmail.txtbxCustomerEmailAddress.BackColor = Color.Gold
                frmEmail.txtbxCustomerEmailAddress.ForeColor = Color.DarkSlateGray
                frmEmail.txtbxEmployeeEmail.BackColor = Color.Gold
                frmEmail.txtbxEmployeeEmail.ForeColor = Color.DarkSlateGray
                frmEmail.txtbxEmailSubject.BackColor = Color.Gold
                frmEmail.txtbxEmailSubject.ForeColor = Color.DarkSlateGray
                frmEmail.rtxtbxEmailBody.BackColor = Color.Gold
                frmEmail.rtxtbxEmailBody.ForeColor = Color.DarkSlateGray

                'form search
                frmSearch.BackColor = Color.Teal
                frmSearch.MenuStrip1.BackColor = Color.DarkSlateGray
                frmSearch.MenuStrip1.ForeColor = Color.Orange
                frmSearch.grpbxSearchOptions.BackColor = Color.Gold
                frmSearch.grpbxSearchOptions.ForeColor = Color.Teal
                frmSearch.btnSearch.ForeColor = SystemColors.ControlText
                frmSearch.txtbxCustID.BackColor = Color.DarkSlateGray
                frmSearch.txtbxCustID.ForeColor = Color.Orange
                frmSearch.txtbxCustName.BackColor = Color.DarkSlateGray
                frmSearch.txtbxCustName.ForeColor = Color.Orange
                frmSearch.txtbxQuoteNum.BackColor = Color.DarkSlateGray
                frmSearch.txtbxQuoteNum.ForeColor = Color.Orange
                frmSearch.txtbxQuoteQty.BackColor = Color.DarkSlateGray
                frmSearch.txtbxQuoteQty.ForeColor = Color.Orange
                frmSearch.txtbxQuoteWorth.BackColor = Color.DarkSlateGray
                frmSearch.txtbxQuoteWorth.ForeColor = Color.Orange

                'form custom art
                frmCustomArt.BackColor = Color.Teal
                frmCustomArt.Label1.ForeColor = Color.Orange
                frmCustomArt.txtbxCustNum.BackColor = Color.Gold
                frmCustomArt.txtbxCustNum.ForeColor = Color.DarkSlateGray

                'form sales
                frmSales.BackColor = SystemColors.Control
                frmSales.ForeColor = SystemColors.ControlText
                frmSales.txtbxCompAssem.BackColor = SystemColors.Window
                frmSales.finalAssemNum.BackColor = SystemColors.Window
                frmSales.txtbxManual.BackColor = SystemColors.Window
                frmSales.txtbxScaleNuber.BackColor = SystemColors.Window

            Case "MintWhite"
                'form1
                Me.GroupBox1.ForeColor = SystemColors.HighlightText
                Me.GroupBox2.ForeColor = SystemColors.HighlightText
                Me.Button5.ForeColor = Color.Black
                Me.GroupBox3.ForeColor = SystemColors.HighlightText
                Me.GroupBox1.BackColor = Color.FromArgb(170, 210, 110)
                Me.GroupBox2.BackColor = Color.FromArgb(170, 210, 110)
                Me.GroupBox3.BackColor = Color.FromArgb(170, 210, 110)
                Me.BackColor = Color.FromArgb(200, 210, 185)
                Me.MenuStrip1.BackColor = Color.FromArgb(200, 220, 165)
                Me.FileToolStripMenuItem.ForeColor = Color.White
                Me.EditToolStripMenuItem.ForeColor = Color.White
                Me.ViewToolStripMenuItem.ForeColor = Color.White
                Me.NavigationToolStripMenuItem.ForeColor = Color.White
                Me.ExportToolStripMenuItem.ForeColor = Color.White
                Me.Label1.ForeColor = SystemColors.HighlightText
                Me.Label2.ForeColor = SystemColors.HighlightText
                Me.Label3.ForeColor = SystemColors.HighlightText
                Me.Label4.ForeColor = SystemColors.HighlightText
                Me.Label5.ForeColor = SystemColors.HighlightText
                Me.Label6.ForeColor = SystemColors.HighlightText
                Me.Label7.ForeColor = SystemColors.HighlightText
                Me.Label8.ForeColor = SystemColors.HighlightText
                Me.Label9.ForeColor = SystemColors.HighlightText
                Me.Label10.ForeColor = SystemColors.HighlightText
                Me.Label11.ForeColor = SystemColors.HighlightText
                Me.Label12.ForeColor = SystemColors.HighlightText
                Me.Label14.ForeColor = SystemColors.HighlightText
                Me.Label15.ForeColor = SystemColors.HighlightText
                Me.Label16.ForeColor = SystemColors.HighlightText
                Me.Label17.ForeColor = SystemColors.HighlightText
                Me.Label18.ForeColor = Color.White
                Me.comQual.ForeColor = Color.White
                Me.standardComModel.ForeColor = Color.White
                Me.comOrientation.ForeColor = Color.White
                Me.comBarColor.ForeColor = Color.White
                Me.comDigColor.ForeColor = Color.White
                Me.comSTPTcolor.ForeColor = Color.White
                Me.comAlarmSetPoint.ForeColor = Color.White
                Me.comSwitches.ForeColor = Color.White
                Me.comConformal.ForeColor = Color.White
                Me.comPower.ForeColor = Color.White
                Me.comDecimal.ForeColor = Color.White
                Me.comSignalType.ForeColor = Color.White
                Me.comSignalUnits.ForeColor = Color.White
                Me.comOptionBoard.ForeColor = Color.White
                Me.comBarStart.ForeColor = Color.White
                Me.comSignalLinearity.ForeColor = Color.White
                Me.comQual.BackColor = Color.FromArgb(180, 190, 170)
                Me.nuclearComModel.ForeColor = Color.White
                Me.nuclearComModel.BackColor = Color.FromArgb(180, 190, 170)
                Me.standardComModel.BackColor = Color.FromArgb(180, 190, 170)
                Me.comOrientation.BackColor = Color.FromArgb(180, 190, 170)
                Me.comBarColor.BackColor = Color.FromArgb(180, 190, 170)
                Me.comDigColor.BackColor = Color.FromArgb(180, 190, 170)
                Me.comSTPTcolor.BackColor = Color.FromArgb(180, 190, 170)
                Me.comAlarmSetPoint.BackColor = Color.FromArgb(180, 190, 170)
                Me.comSwitches.BackColor = Color.FromArgb(180, 190, 170)
                Me.comConformal.BackColor = Color.FromArgb(180, 190, 170)
                Me.comPower.BackColor = Color.FromArgb(180, 190, 170)
                Me.comDecimal.BackColor = Color.FromArgb(180, 190, 170)
                Me.comSignalType.BackColor = Color.FromArgb(180, 190, 170)
                Me.comSignalUnits.BackColor = Color.FromArgb(180, 190, 170)
                Me.comOptionBoard.BackColor = Color.FromArgb(180, 190, 170)
                Me.comBarStart.BackColor = Color.FromArgb(180, 190, 170)
                Me.comSignalLinearity.BackColor = Color.FromArgb(180, 190, 170)
                If (powerNum.Text <> "0") Then
                    powerNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (seriesNum.Text <> "0") Then
                    seriesNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (modelNum.Text <> "0") Then
                    modelNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (orientationNum.Text <> "0") Then
                    orientationNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (barColorNum.Text <> "0") Then
                    barColorNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (digColorNum.Text <> "0") Then
                    digColorNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (decimalNum.Text <> "0") Then
                    decimalNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (stptNum.Text <> "0") Then
                    stptNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (alarmNum.Text <> "0") Then
                    alarmNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (switchesNum.Text <> "0") Then
                    switchesNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (unitsNum.Text <> "0") Then
                    unitsNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (typeNum.Text <> "0") Then
                    typeNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (linearityNum.Text <> "0") Then
                    linearityNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (optionNum.Text <> "0") Then
                    optionNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (startNum.Text <> "0") Then
                    startNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (conformalNum.Text <> "0") Then
                    conformalNum.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (Label21.Text <> "0") Then
                    Label21.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (Label22.Text <> "0") Then
                    Label22.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (Label26.Text <> "0") Then
                    Label26.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (Label28.Text <> "0") Then
                    Label28.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (Label25.Text <> "0") Then
                    Label25.ForeColor = Color.FromArgb(75, 120, 0)
                End If
                If (lblCustArt.Text <> "0") Then
                    lblCustArt.ForeColor = Color.FromArgb(75, 120, 0)
                End If

                'form2
                Form2.BackColor = Color.FromArgb(200, 210, 185)
                Form2.ListBox1.BackColor = Color.FromArgb(170, 210, 110)
                Form2.ListBox1.ForeColor = Color.White
                Form2.Label1.ForeColor = Color.White

                'form3
                frmArtwork.BackColor = Color.FromArgb(200, 210, 185)
                frmArtwork.grpbxCaption.BackColor = Color.FromArgb(170, 210, 110)
                frmArtwork.GroupBox2.BackColor = Color.FromArgb(170, 210, 110)
                frmArtwork.GroupBox3.BackColor = Color.FromArgb(200, 210, 185)
                frmArtwork.grpbxCaption.ForeColor = Color.White
                frmArtwork.GroupBox2.ForeColor = Color.White
                frmArtwork.GroupBox3.ForeColor = Color.FromArgb(75, 120, 0)
                frmArtwork.cmbxMisc.BackColor = Color.FromArgb(200, 210, 185)
                frmArtwork.cmbxMisc.ForeColor = Color.White
                frmArtwork.scaleList.BackColor = Color.FromArgb(200, 220, 165)
                frmArtwork.scaleList.ForeColor = Color.White
                frmArtwork.cmbxAC.BackColor = Color.FromArgb(200, 210, 185)
                frmArtwork.cmbxAC.ForeColor = Color.White
                frmArtwork.cmbxDC.BackColor = Color.FromArgb(200, 210, 185)
                frmArtwork.cmbxDC.ForeColor = Color.White
                frmArtwork.cmbxFlowRate.BackColor = Color.FromArgb(200, 210, 185)
                frmArtwork.cmbxFlowRate.ForeColor = Color.White
                frmArtwork.cmbxLevel.BackColor = Color.FromArgb(200, 210, 185)
                frmArtwork.cmbxLevel.ForeColor = Color.White
                frmArtwork.cmbxPressure.BackColor = Color.FromArgb(200, 210, 185)
                frmArtwork.cmbxPressure.ForeColor = Color.White
                frmArtwork.cmbxTemp.BackColor = Color.FromArgb(200, 210, 185)
                frmArtwork.cmbxTemp.ForeColor = Color.White
                frmArtwork.cmbxVolume.BackColor = Color.FromArgb(200, 210, 185)
                frmArtwork.cmbxVolume.ForeColor = Color.White
                frmArtwork.Button4.ForeColor = SystemColors.ControlText

                'form email
                frmEmail.BackColor = Color.FromArgb(200, 210, 185)
                frmEmail.MenuStrip1.BackColor = Color.FromArgb(200, 220, 165)
                frmEmail.MenuStrip1.ForeColor = Color.White
                frmEmail.lblCustomerEmailAddress.ForeColor = Color.FromArgb(75, 120, 0)
                frmEmail.lblEmployeeEmail.ForeColor = Color.FromArgb(75, 120, 0)
                frmEmail.lblEmailSubject.ForeColor = Color.FromArgb(75, 120, 0)
                frmEmail.lblEmailBody.ForeColor = Color.FromArgb(75, 120, 0)
                frmEmail.txtbxCustomerEmailAddress.BackColor = Color.FromArgb(170, 210, 110)
                frmEmail.txtbxCustomerEmailAddress.ForeColor = Color.White
                frmEmail.txtbxEmployeeEmail.BackColor = Color.FromArgb(170, 210, 110)
                frmEmail.txtbxEmployeeEmail.ForeColor = Color.White
                frmEmail.txtbxEmailSubject.BackColor = Color.FromArgb(170, 210, 110)
                frmEmail.txtbxEmailSubject.ForeColor = Color.White
                frmEmail.rtxtbxEmailBody.BackColor = Color.FromArgb(170, 210, 110)
                frmEmail.rtxtbxEmailBody.ForeColor = Color.White

                'form search
                frmSearch.BackColor = Color.FromArgb(200, 210, 185)
                frmSearch.MenuStrip1.BackColor = Color.FromArgb(200, 220, 165)
                frmSearch.MenuStrip1.ForeColor = Color.White
                frmSearch.grpbxSearchOptions.BackColor = Color.FromArgb(170, 210, 110)
                frmSearch.grpbxSearchOptions.ForeColor = Color.FromArgb(75, 120, 0)
                frmSearch.btnSearch.ForeColor = SystemColors.ControlText
                frmSearch.txtbxCustID.BackColor = Color.FromArgb(200, 220, 165)
                frmSearch.txtbxCustID.ForeColor = Color.White
                frmSearch.txtbxCustName.BackColor = Color.FromArgb(200, 220, 165)
                frmSearch.txtbxCustName.ForeColor = Color.White
                frmSearch.txtbxQuoteNum.BackColor = Color.FromArgb(200, 220, 165)
                frmSearch.txtbxQuoteNum.ForeColor = Color.White
                frmSearch.txtbxQuoteQty.BackColor = Color.FromArgb(200, 220, 165)
                frmSearch.txtbxQuoteQty.ForeColor = Color.White
                frmSearch.txtbxQuoteWorth.BackColor = Color.FromArgb(200, 220, 165)
                frmSearch.txtbxQuoteWorth.ForeColor = Color.White

                'form custom art
                frmCustomArt.BackColor = Color.FromArgb(200, 210, 185)
                frmCustomArt.Label1.ForeColor = Color.White
                frmCustomArt.txtbxCustNum.BackColor = Color.FromArgb(200, 220, 165)
                frmCustomArt.txtbxCustNum.ForeColor = Color.White

                'form sales
                frmSales.BackColor = SystemColors.Control
                frmSales.ForeColor = SystemColors.ControlText
                frmSales.txtbxCompAssem.BackColor = SystemColors.Window
                frmSales.finalAssemNum.BackColor = SystemColors.Window
                frmSales.txtbxManual.BackColor = SystemColors.Window
                frmSales.txtbxScaleNuber.BackColor = SystemColors.Window

            Case "BluePurple"
                Me.GroupBox1.ForeColor = SystemColors.ControlText
                Me.GroupBox2.ForeColor = SystemColors.ControlText
                Me.GroupBox3.ForeColor = SystemColors.ControlText
                Me.GroupBox1.BackColor = Color.LightSteelBlue
                Me.GroupBox2.BackColor = Color.LightSteelBlue
                Me.GroupBox3.BackColor = Color.LightSteelBlue
                Me.BackColor = Color.Silver
                Me.MenuStrip1.BackColor = Color.RosyBrown
                Me.FileToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.EditToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.ViewToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.NavigationToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.ExportToolStripMenuItem.ForeColor = SystemColors.ControlText
                Me.Label1.ForeColor = SystemColors.ControlText
                Me.Label2.ForeColor = SystemColors.ControlText
                Me.Label3.ForeColor = SystemColors.ControlText
                Me.Label4.ForeColor = SystemColors.ControlText
                Me.Label5.ForeColor = SystemColors.ControlText
                Me.Label6.ForeColor = SystemColors.ControlText
                Me.Label7.ForeColor = SystemColors.ControlText
                Me.Label8.ForeColor = SystemColors.ControlText
                Me.Label9.ForeColor = SystemColors.ControlText
                Me.Label10.ForeColor = SystemColors.ControlText
                Me.Label11.ForeColor = SystemColors.ControlText
                Me.Label12.ForeColor = SystemColors.ControlText
                Me.Label14.ForeColor = SystemColors.ControlText
                Me.Label15.ForeColor = SystemColors.ControlText
                Me.Label16.ForeColor = SystemColors.ControlText
                Me.Label17.ForeColor = SystemColors.ControlText
                Me.Label18.ForeColor = SystemColors.ControlText
                Me.comQual.ForeColor = SystemColors.ControlText
                Me.standardComModel.ForeColor = SystemColors.ControlText
                Me.comOrientation.ForeColor = SystemColors.ControlText
                Me.comBarColor.ForeColor = SystemColors.ControlText
                Me.comDigColor.ForeColor = SystemColors.ControlText
                Me.comSTPTcolor.ForeColor = SystemColors.ControlText
                Me.comAlarmSetPoint.ForeColor = SystemColors.ControlText
                Me.comSwitches.ForeColor = SystemColors.ControlText
                Me.comConformal.ForeColor = SystemColors.ControlText
                Me.comPower.ForeColor = SystemColors.ControlText
                Me.comDecimal.ForeColor = SystemColors.ControlText
                Me.comSignalType.ForeColor = SystemColors.ControlText
                Me.comSignalUnits.ForeColor = SystemColors.ControlText
                Me.comOptionBoard.ForeColor = SystemColors.ControlText
                Me.comBarStart.ForeColor = SystemColors.ControlText
                Me.comSignalLinearity.ForeColor = SystemColors.ControlText
                Me.comQual.BackColor = Color.Silver
                Me.nuclearComModel.ForeColor = SystemColors.ControlText
                Me.nuclearComModel.BackColor = Color.Silver
                Me.standardComModel.BackColor = Color.Silver
                Me.comOrientation.BackColor = Color.Silver
                Me.comBarColor.BackColor = Color.Silver
                Me.comDigColor.BackColor = Color.Silver
                Me.comSTPTcolor.BackColor = Color.Silver
                Me.comAlarmSetPoint.BackColor = Color.Silver
                Me.comSwitches.BackColor = Color.Silver
                Me.comConformal.BackColor = Color.Silver
                Me.comPower.BackColor = Color.Silver
                Me.comDecimal.BackColor = Color.Silver
                Me.comSignalType.BackColor = Color.Silver
                Me.comSignalUnits.BackColor = Color.Silver
                Me.comOptionBoard.BackColor = Color.Silver
                Me.comBarStart.BackColor = Color.Silver
                Me.comSignalLinearity.BackColor = Color.Silver
                If (powerNum.Text <> "0") Then
                    powerNum.ForeColor = Color.DarkBlue
                End If
                If (seriesNum.Text <> "0") Then
                    seriesNum.ForeColor = Color.DarkBlue
                End If
                If (modelNum.Text <> "0") Then
                    modelNum.ForeColor = Color.DarkBlue
                End If
                If (orientationNum.Text <> "0") Then
                    orientationNum.ForeColor = Color.DarkBlue
                End If
                If (barColorNum.Text <> "0") Then
                    barColorNum.ForeColor = Color.DarkBlue
                End If
                If (digColorNum.Text <> "0") Then
                    digColorNum.ForeColor = Color.DarkBlue
                End If
                If (decimalNum.Text <> "0") Then
                    decimalNum.ForeColor = Color.DarkBlue
                End If
                If (stptNum.Text <> "0") Then
                    stptNum.ForeColor = Color.DarkBlue
                End If
                If (alarmNum.Text <> "0") Then
                    alarmNum.ForeColor = Color.DarkBlue
                End If
                If (switchesNum.Text <> "0") Then
                    switchesNum.ForeColor = Color.DarkBlue
                End If
                If (unitsNum.Text <> "0") Then
                    unitsNum.ForeColor = Color.DarkBlue
                End If
                If (typeNum.Text <> "0") Then
                    typeNum.ForeColor = Color.DarkBlue
                End If
                If (linearityNum.Text <> "0") Then
                    linearityNum.ForeColor = Color.DarkBlue
                End If
                If (optionNum.Text <> "0") Then
                    optionNum.ForeColor = Color.DarkBlue
                End If
                If (startNum.Text <> "0") Then
                    startNum.ForeColor = Color.DarkBlue
                End If
                If (conformalNum.Text <> "0") Then
                    conformalNum.ForeColor = Color.DarkBlue
                End If
                If (Label21.Text <> "0") Then
                    Label21.ForeColor = Color.DarkBlue
                End If
                If (Label22.Text <> "0") Then
                    Label22.ForeColor = Color.DarkBlue
                End If
                If (Label26.Text <> "0") Then
                    Label26.ForeColor = Color.DarkBlue
                End If
                If (Label28.Text <> "0") Then
                    Label28.ForeColor = Color.DarkBlue
                End If
                If (Label25.Text <> "0") Then
                    Label25.ForeColor = Color.DarkBlue
                End If
                If (lblCustArt.Text <> "0") Then
                    lblCustArt.ForeColor = Color.DarkBlue
                End If

                'form2
                Form2.BackColor = Color.Silver
                Form2.ListBox1.BackColor = Color.LightSteelBlue
                Form2.ListBox1.ForeColor = SystemColors.ControlText
                Form2.Label1.ForeColor = SystemColors.ControlText

                'form3 artwork
                frmArtwork.BackColor = Color.Silver
                frmArtwork.grpbxCaption.BackColor = Color.LightSteelBlue
                frmArtwork.GroupBox2.BackColor = Color.LightSteelBlue
                frmArtwork.GroupBox3.BackColor = Color.Silver
                frmArtwork.grpbxCaption.ForeColor = SystemColors.ControlText
                frmArtwork.GroupBox2.ForeColor = SystemColors.ControlText
                frmArtwork.GroupBox3.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxMisc.BackColor = Color.Silver
                frmArtwork.cmbxMisc.ForeColor = SystemColors.ControlText
                frmArtwork.scaleList.BackColor = Color.RosyBrown
                frmArtwork.scaleList.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxAC.BackColor = Color.Silver
                frmArtwork.cmbxAC.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxDC.BackColor = Color.Silver
                frmArtwork.cmbxDC.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxFlowRate.BackColor = Color.Silver
                frmArtwork.cmbxFlowRate.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxLevel.BackColor = Color.Silver
                frmArtwork.cmbxLevel.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxPressure.BackColor = Color.Silver
                frmArtwork.cmbxPressure.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxTemp.BackColor = Color.Silver
                frmArtwork.cmbxTemp.ForeColor = SystemColors.ControlText
                frmArtwork.cmbxVolume.BackColor = Color.Silver
                frmArtwork.cmbxVolume.ForeColor = SystemColors.ControlText
                frmArtwork.Button4.ForeColor = SystemColors.ControlText

                'form email
                frmEmail.BackColor = Color.Silver
                frmEmail.MenuStrip1.BackColor = Color.RosyBrown
                frmEmail.MenuStrip1.ForeColor = SystemColors.ControlText
                frmEmail.lblCustomerEmailAddress.ForeColor = SystemColors.ControlText
                frmEmail.lblEmployeeEmail.ForeColor = SystemColors.ControlText
                frmEmail.lblEmailSubject.ForeColor = SystemColors.ControlText
                frmEmail.lblEmailBody.ForeColor = SystemColors.ControlText
                frmEmail.txtbxCustomerEmailAddress.BackColor = Color.LightSteelBlue
                frmEmail.txtbxCustomerEmailAddress.ForeColor = SystemColors.ControlText
                frmEmail.txtbxEmployeeEmail.BackColor = Color.LightSteelBlue
                frmEmail.txtbxEmployeeEmail.ForeColor = SystemColors.ControlText
                frmEmail.txtbxEmailSubject.BackColor = Color.LightSteelBlue
                frmEmail.txtbxEmailSubject.ForeColor = SystemColors.ControlText
                frmEmail.rtxtbxEmailBody.BackColor = Color.LightSteelBlue
                frmEmail.rtxtbxEmailBody.ForeColor = SystemColors.ControlText

                'form search
                frmSearch.BackColor = Color.Silver
                frmSearch.MenuStrip1.BackColor = Color.RosyBrown
                frmSearch.MenuStrip1.ForeColor = SystemColors.ControlText
                frmSearch.grpbxSearchOptions.BackColor = Color.LightSteelBlue
                frmSearch.grpbxSearchOptions.ForeColor = SystemColors.ControlText
                frmSearch.btnSearch.ForeColor = SystemColors.ControlText
                frmSearch.txtbxCustID.BackColor = Color.RosyBrown
                frmSearch.txtbxCustID.ForeColor = SystemColors.ControlText
                frmSearch.txtbxCustName.BackColor = Color.RosyBrown
                frmSearch.txtbxCustName.ForeColor = SystemColors.ControlText
                frmSearch.txtbxQuoteNum.BackColor = Color.RosyBrown
                frmSearch.txtbxQuoteNum.ForeColor = SystemColors.ControlText
                frmSearch.txtbxQuoteQty.BackColor = Color.RosyBrown
                frmSearch.txtbxQuoteQty.ForeColor = SystemColors.ControlText
                frmSearch.txtbxQuoteWorth.BackColor = Color.RosyBrown
                frmSearch.txtbxQuoteWorth.ForeColor = SystemColors.ControlText

                'form custom art
                frmCustomArt.BackColor = Color.Silver
                frmCustomArt.Label1.ForeColor = SystemColors.ControlText
                frmCustomArt.txtbxCustNum.BackColor = Color.LightSteelBlue
                frmCustomArt.txtbxCustNum.ForeColor = SystemColors.ControlText

                'form sales
                frmSales.BackColor = Color.Silver
                frmSales.txtbxCompAssem.BackColor = Color.LightSteelBlue
                frmSales.finalAssemNum.BackColor = Color.LightSteelBlue
                frmSales.txtbxManual.BackColor = Color.LightSteelBlue
                frmSales.txtbxScaleNuber.BackColor = Color.LightSteelBlue
        End Select
    End Function


    Private Sub DefaultToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        GlobalVariables.ThemeColor = "Default"
        Theme_Color()
    End Sub

    Private Sub GrayRedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrayRedToolStripMenuItem.Click
        GlobalVariables.ThemeColor = "GrayRed"
        Theme_Color()
    End Sub

    Private Sub TealOrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TealOrangeToolStripMenuItem.Click
        GlobalVariables.ThemeColor = "TealOrange"
        Theme_Color()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmArtwork.Show()
        Theme_Color()
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        frmEmail.Size = Me.Size
        frmEmail.Location = Me.Location
        frmEmail.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmSearch.Size = Me.Size
        frmSearch.Location = Me.Location
        frmSearch.Show()
        Me.Hide()
    End Sub

    Private Sub stdRadio_CheckedChanged(sender As Object, e As EventArgs) Handles stdRadio.CheckedChanged
        If stdRadio.Checked = True Then
            nucRadio.Checked = False
            standardComModel.Visible = True
            nuclearComModel.Visible = False
            comQual.Enabled = False
            seriesNum.Text = "0"
            modelNum.Text = "0"
            comQual.SelectedIndex = -1
        End If
        If nucRadio.Checked = True Then
            stdRadio.Checked = False
            nuclearComModel.Visible = True
            standardComModel.Visible = False
            comQual.Enabled = True
            seriesNum.Text = "0"
            modelNum.Text = "0"
        End If
    End Sub

    Private Sub nuclearComModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nuclearComModel.SelectedIndexChanged
        SalesFormToolStripMenuItem.Enabled = True
        If nucRadio.Checked = True Then
            Select Case nuclearComModel.SelectedIndex
                Case 0
                    modelNum.Text = "B"
                Case 1
                    modelNum.Text = "C"
                Case 2
                    modelNum.Text = "G"
                Case 3
                    modelNum.Text = "H"
                Case 4
                    modelNum.Text = "J"
                Case 5
                    modelNum.Text = "L"
                Case 6
                    modelNum.Text = "M"
                Case 7
                    modelNum.Text = "O"
                Case 8
                    modelNum.Text = "T"
                Case 9
                    modelNum.Text = "V"
                Case 10
                    modelNum.Text = "X"
            End Select
        End If

    End Sub

    Private Sub comQual_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comQual.SelectedIndexChanged
        If nucRadio.Checked = True Then
            Select Case comQual.SelectedIndex
                Case 0
                    seriesNum.Text = "Q"
                Case 1
                    seriesNum.Text = "T"
            End Select
        End If
    End Sub

    Private Sub nucRadio_CheckedChanged(sender As Object, e As EventArgs) Handles nucRadio.CheckedChanged
        If stdRadio.Checked = True Then
            nucRadio.Checked = False
            standardComModel.Visible = True
            nuclearComModel.Visible = False
            comQual.Enabled = False
            comQual.SelectedIndex = -1
            seriesNum.Text = "0"
            modelNum.Text = "0"
        End If
        If nucRadio.Checked = True Then
            stdRadio.Checked = False
            nuclearComModel.Visible = True
            standardComModel.Visible = False
            comQual.Enabled = True
            seriesNum.Text = "0"
            modelNum.Text = "0"
        End If
    End Sub

    Private Sub MintWhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MintWhiteToolStripMenuItem.Click
        GlobalVariables.ThemeColor = "MintWhite"
        Theme_Color()
    End Sub

    Private Sub SalesFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesFormToolStripMenuItem.Click
        frmSales.Location = Me.Location
        frmSales.Show()
        Me.Hide()
        Theme_Color()
    End Sub

    Private Sub CopyPartNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyPartNumberToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(getSerial())
    End Sub

    Private Sub BluePurpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BluePurpleToolStripMenuItem.Click
        GlobalVariables.ThemeColor = "BluePurple"
        Theme_Color()
    End Sub

    Private Sub nextDisplayButton_Click(sender As Object, e As EventArgs) Handles nextDisplayButton.Click
        If standardComModel.SelectedIndex = -1 Or _
            nuclearComModel.SelectedIndex = -1 Or _
            comQual.SelectedIndex = -1 Or _
            comOrientation.SelectedIndex = -1 Or _
            comBarColor.SelectedIndex = -1 Or _
            comDigColor.SelectedIndex = -1 Or _
            comDecimal.SelectedIndex = -1 Or _
            comSTPTcolor.SelectedIndex = -1 Or _
            comAlarmSetPoint.SelectedIndex = -1 Or _
            comSwitches.SelectedIndex = -1 Or _
            comBarStart.SelectedIndex = -1 Or _
            comPower.SelectedIndex = -1 Or _
            comSignalUnits.SelectedIndex = -1 Or _
            comSignalType.SelectedIndex = -1 Or _
            comConformal.SelectedIndex = -1 Or _
            comOptionBoard.SelectedIndex = -1 Or _
            comSignalLinearity.SelectedIndex = -1 Then
            MsgBox("Please finish this display before continuing")
        Else
            Me.Hide()
        End If
    End Sub
End Class

Public Class GlobalVariables
    Public Shared ThemeColor As String = "Default"
End Class
