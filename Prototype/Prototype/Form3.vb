Public Class frmArtwork
    Dim caption As String
    Dim range As String
    Dim scale

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton2.Checked = True
    End Sub

    Public Sub getPartNum()
        Dim temp As Integer
        If scaleList.SelectedItems.Count > 0 Then
            temp = scaleList.SelectedItems.Item(0).Index + 1
            If temp < 10 Then
                scaleNum1.Text = 0
                scaleNum2.Text = temp.ToString.Chars(0)
            Else
                scaleNum1.Text = temp.ToString.Chars(0)
                scaleNum2.Text = temp.ToString.Chars(1)
            End If
        End If
    End Sub

    Private Sub accombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxAC.SelectedIndexChanged
        If (cmbxDC.Focused Or cmbxLevel.Focused Or cmbxTemp.Focused Or cmbxFlowRate.Focused Or cmbxPressure.Focused Or cmbxVolume.Focused Or cmbxMisc.Focused) Then
            Return
        Else
            caption = cmbxAC.SelectedItem
            cmbxDC.SelectedIndex = -1
            cmbxLevel.SelectedIndex = -1
            cmbxTemp.SelectedIndex = -1
            cmbxFlowRate.SelectedIndex = -1
            cmbxPressure.SelectedIndex = -1
            cmbxVolume.SelectedIndex = -1
            cmbxMisc.SelectedIndex = -1
            If cmbxAC.SelectedIndex < 9 Then
                captionNum1.Text = "0"
                captionNum2.Text = cmbxAC.SelectedIndex.ToString + 1
            Else
                captionNum1.Text = (cmbxAC.SelectedIndex + 1).ToString.Chars(0)
                captionNum2.Text = (cmbxAC.SelectedIndex + 1).ToString.Chars(1)
            End If
        End If
        updateScale()
    End Sub

    Private Sub dccombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxDC.SelectedIndexChanged
        If (cmbxAC.Focused Or cmbxLevel.Focused Or cmbxTemp.Focused Or cmbxFlowRate.Focused Or cmbxPressure.Focused Or cmbxVolume.Focused Or cmbxMisc.Focused) Then
            Return
        Else
            caption = cmbxDC.SelectedItem
            cmbxAC.SelectedIndex = -1
            cmbxLevel.SelectedIndex = -1
            cmbxTemp.SelectedIndex = -1
            cmbxFlowRate.SelectedIndex = -1
            cmbxPressure.SelectedIndex = -1
            cmbxVolume.SelectedIndex = -1
            cmbxMisc.SelectedIndex = -1
            Dim temp As Integer = cmbxDC.SelectedIndex + 13
            captionNum1.Text = temp.ToString.Chars(0)
            captionNum2.Text = temp.ToString.Chars(1)
        End If
        updateScale()
    End Sub

    Private Sub levelcombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxLevel.SelectedIndexChanged
        If (cmbxDC.Focused Or cmbxAC.Focused Or cmbxTemp.Focused Or cmbxFlowRate.Focused Or cmbxPressure.Focused Or cmbxVolume.Focused Or cmbxMisc.Focused) Then
            Return
        Else
            caption = cmbxLevel.SelectedItem
            cmbxDC.SelectedIndex = -1
            cmbxAC.SelectedIndex = -1
            cmbxTemp.SelectedIndex = -1
            cmbxFlowRate.SelectedIndex = -1
            cmbxPressure.SelectedIndex = -1
            cmbxVolume.SelectedIndex = -1
            cmbxMisc.SelectedIndex = -1
            If cmbxLevel.SelectedIndex = 4 Then
                captionNum1.Text = "5"
                captionNum2.Text = "2"
            ElseIf cmbxLevel.SelectedIndex = 5 Then
                captionNum1.Text = "5"
                captionNum2.Text = "3"
            Else
                Dim temp As Integer = cmbxLevel.SelectedIndex + 47
                captionNum1.Text = temp.ToString.Chars(0)
                captionNum2.Text = temp.ToString.Chars(1)
            End If
        End If
        updateScale()
    End Sub

    Private Sub tempcombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxTemp.SelectedIndexChanged
        If (cmbxDC.Focused Or cmbxLevel.Focused Or cmbxAC.Focused Or cmbxFlowRate.Focused Or cmbxPressure.Focused Or cmbxVolume.Focused Or cmbxMisc.Focused) Then
            Return
        Else
            caption = cmbxTemp.SelectedItem
            cmbxDC.SelectedIndex = -1
            cmbxLevel.SelectedIndex = -1
            cmbxAC.SelectedIndex = -1
            cmbxFlowRate.SelectedIndex = -1
            cmbxPressure.SelectedIndex = -1
            cmbxVolume.SelectedIndex = -1
            cmbxMisc.SelectedIndex = -1
            Dim temp As Integer = cmbxTemp.SelectedIndex + 22
            captionNum1.Text = temp.ToString.Chars(0)
            captionNum2.Text = temp.ToString.Chars(1)
        End If
        updateScale()
    End Sub

    Private Sub flowcombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxFlowRate.SelectedIndexChanged
        If (cmbxDC.Focused Or cmbxLevel.Focused Or cmbxTemp.Focused Or cmbxAC.Focused Or cmbxPressure.Focused Or cmbxVolume.Focused Or cmbxMisc.Focused) Then
            Return
        Else
            caption = cmbxFlowRate.SelectedItem
            cmbxDC.SelectedIndex = -1
            cmbxLevel.SelectedIndex = -1
            cmbxTemp.SelectedIndex = -1
            cmbxAC.SelectedIndex = -1
            cmbxPressure.SelectedIndex = -1
            cmbxVolume.SelectedIndex = -1
            cmbxMisc.SelectedIndex = -1
            Dim temp As Integer = cmbxFlowRate.SelectedIndex + 34
            captionNum1.Text = temp.ToString.Chars(0)
            captionNum2.Text = temp.ToString.Chars(1)
        End If
        updateScale()
    End Sub

    Private Sub pressurecombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxPressure.SelectedIndexChanged
        If (cmbxDC.Focused Or cmbxLevel.Focused Or cmbxTemp.Focused Or cmbxFlowRate.Focused Or cmbxAC.Focused Or cmbxVolume.Focused Or cmbxMisc.Focused) Then
            Return
        Else
            caption = cmbxPressure.SelectedItem
            cmbxDC.SelectedIndex = -1
            cmbxLevel.SelectedIndex = -1
            cmbxTemp.SelectedIndex = -1
            cmbxFlowRate.SelectedIndex = -1
            cmbxAC.SelectedIndex = -1
            cmbxVolume.SelectedIndex = -1
            cmbxMisc.SelectedIndex = -1
            If cmbxPressure.SelectedIndex = 5 Then
                captionNum1.Text = "5"
                captionNum2.Text = "6"
            ElseIf cmbxPressure.SelectedIndex = 9 Then
                captionNum1.Text = "7"
                captionNum2.Text = "6"
            ElseIf cmbxPressure.SelectedIndex = 10 Then
                captionNum1.Text = "7"
                captionNum2.Text = "7"
            ElseIf cmbxPressure.SelectedIndex = 11 Then
                captionNum1.Text = "7"
                captionNum2.Text = "8"
            Else
                Dim temp As Integer = cmbxPressure.SelectedIndex + 25
                captionNum1.Text = temp.ToString.Chars(0)
                captionNum2.Text = temp.ToString.Chars(1)
            End If
        End If
        updateScale()
    End Sub

    Private Sub volumecombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxVolume.SelectedIndexChanged
        If (cmbxDC.Focused Or cmbxLevel.Focused Or cmbxTemp.Focused Or cmbxFlowRate.Focused Or cmbxPressure.Focused Or cmbxAC.Focused Or cmbxMisc.Focused) Then
            Return
        Else
            caption = cmbxVolume.SelectedItem
            cmbxDC.SelectedIndex = -1
            cmbxLevel.SelectedIndex = -1
            cmbxTemp.SelectedIndex = -1
            cmbxFlowRate.SelectedIndex = -1
            cmbxPressure.SelectedIndex = -1
            cmbxAC.SelectedIndex = -1
            cmbxMisc.SelectedIndex = -1
            If cmbxVolume.SelectedIndex = 0 Then
                captionNum1.Text = "5"
                captionNum2.Text = "5"
            ElseIf cmbxVolume.SelectedIndex = 8 Then
                captionNum1.Text = "7"
                captionNum2.Text = "5"
            Else
                Dim temp As Integer = cmbxVolume.SelectedIndex + 56
                captionNum1.Text = temp.ToString.Chars(0)
                captionNum2.Text = temp.ToString.Chars(1)
            End If
        End If
        updateScale()
    End Sub

    Private Sub misccombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxMisc.SelectedIndexChanged
        If (cmbxDC.Focused Or cmbxLevel.Focused Or cmbxTemp.Focused Or cmbxFlowRate.Focused Or cmbxPressure.Focused Or cmbxVolume.Focused Or cmbxAC.Focused) Then
            Return
        Else
            caption = cmbxMisc.SelectedItem
            cmbxDC.SelectedIndex = -1
            cmbxLevel.SelectedIndex = -1
            cmbxTemp.SelectedIndex = -1
            cmbxFlowRate.SelectedIndex = -1
            cmbxPressure.SelectedIndex = -1
            cmbxVolume.SelectedIndex = -1
            cmbxAC.SelectedIndex = -1
            If cmbxMisc.SelectedIndex = 11 Then
                captionNum1.Text = "9"
                captionNum2.Text = "9"
            Else
                Dim temp As Integer = cmbxMisc.SelectedIndex + 64
                captionNum1.Text = temp.ToString.Chars(0)
                captionNum2.Text = temp.ToString.Chars(1)
            End If
        End If
        updateScale()
    End Sub

    Public Sub updateScale()
        getPartNum()
        If caption <> String.Empty Then
            captionVal.Text = caption
        End If
        If range = "plusminus" Then
            If scaleList.SelectedItems.Count > 0 Then
                startVal.Text = scale
                endVal.Text = "-"
                endVal.Text += scale
            End If
        ElseIf range = "full" Then
            If scaleList.SelectedItems.Count > 0 Then
                startVal.Text = 0
                endVal.Text = scale
            End If
        ElseIf range = "minusplus" Then
            If scaleList.SelectedItems.Count > 0 Then
                startVal.Text = "-"
                startVal.Text += scale
                endVal.Text = scale
            End If
        Else
            startVal.Text = scale
            endVal.Text = scale
        End If

    End Sub
    Private Sub scaleList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles scaleList.SelectedIndexChanged
        If scaleList.SelectedItems.Count > 0 Then
            scale = scaleList.SelectedItems.Item(0).Text
            If Not Possible(scale) Then
                MsgBox(scale + " is Not Possible With the Decimal Format " + Home.comDecimal.SelectedItem.ToString)
                Exit Sub
            End If
            updateScale()
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'refresh()
        If RadioButton1.Checked = True Then
            range = "plusminus"
            rangeNum.Text = "+/-"
            updateScale()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            range = "full"
            rangeNum.Text = "-"
            updateScale()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            range = "minusplus"
            rangeNum.Text = "-/+"
            updateScale()
        End If
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Home.Location = Me.Location
        Home.Size = Me.Size
        Home.Show()
        Me.Hide()
    End Sub

    'Used to close the application even when you're not on the main form
    Private Sub CloseForm(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        frmEmail.Size = Me.Size
        frmEmail.Location = Me.Location
        frmEmail.Show()
        Me.Hide()
    End Sub

    Private Sub rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnAC.CheckedChanged, rbtnDC.CheckedChanged, rbtnFlowRate.CheckedChanged, rbtnLevel.CheckedChanged, rbtnMisc.CheckedChanged, rbtnPressure.CheckedChanged, rbtnTemp.CheckedChanged, rbtnVolume.CheckedChanged
        captionVal.Text = ""
        captionNum1.Text = ""
        captionNum2.Text = ""
        cmbxAC.SelectedIndex = -1
        cmbxDC.SelectedIndex = -1
        cmbxFlowRate.SelectedIndex = -1
        cmbxLevel.SelectedIndex = -1
        cmbxMisc.SelectedIndex = -1
        cmbxPressure.SelectedIndex = -1
        cmbxTemp.SelectedIndex = -1
        cmbxVolume.SelectedIndex = -1

        If rbtnAC.Checked Then
            cmbxAC.Visible = True
            cmbxDC.Visible = False
            cmbxFlowRate.Visible = False
            cmbxLevel.Visible = False
            cmbxMisc.Visible = False
            cmbxPressure.Visible = False
            cmbxTemp.Visible = False
            cmbxVolume.Visible = False
        ElseIf rbtnDC.Checked Then
            cmbxAC.Visible = False
            cmbxDC.Visible = True
            cmbxFlowRate.Visible = False
            cmbxLevel.Visible = False
            cmbxMisc.Visible = False
            cmbxPressure.Visible = False
            cmbxTemp.Visible = False
            cmbxVolume.Visible = False
        ElseIf rbtnFlowRate.Checked Then
            cmbxFlowRate.Visible = True
            cmbxAC.Visible = False
            cmbxDC.Visible = False
            cmbxLevel.Visible = False
            cmbxMisc.Visible = False
            cmbxPressure.Visible = False
            cmbxTemp.Visible = False
            cmbxVolume.Visible = False
        ElseIf rbtnLevel.Checked Then
            cmbxLevel.Visible = True
            cmbxAC.Visible = False
            cmbxDC.Visible = False
            cmbxFlowRate.Visible = False
            cmbxMisc.Visible = False
            cmbxPressure.Visible = False
            cmbxTemp.Visible = False
            cmbxVolume.Visible = False
        ElseIf rbtnMisc.Checked Then
            cmbxMisc.Visible = True
            cmbxAC.Visible = False
            cmbxDC.Visible = False
            cmbxFlowRate.Visible = False
            cmbxLevel.Visible = False
            cmbxPressure.Visible = False
            cmbxTemp.Visible = False
            cmbxVolume.Visible = False
        ElseIf rbtnPressure.Checked Then
            cmbxAC.Visible = False
            cmbxDC.Visible = False
            cmbxFlowRate.Visible = False
            cmbxLevel.Visible = False
            cmbxMisc.Visible = False
            cmbxPressure.Visible = True
            cmbxTemp.Visible = False
            cmbxVolume.Visible = False
        ElseIf rbtnTemp.Checked Then
            cmbxAC.Visible = False
            cmbxDC.Visible = False
            cmbxFlowRate.Visible = False
            cmbxLevel.Visible = False
            cmbxMisc.Visible = False
            cmbxPressure.Visible = False
            cmbxTemp.Visible = True
            cmbxVolume.Visible = False
        ElseIf rbtnVolume.Checked Then
            cmbxAC.Visible = False
            cmbxDC.Visible = False
            cmbxFlowRate.Visible = False
            cmbxLevel.Visible = False
            cmbxMisc.Visible = False
            cmbxPressure.Visible = False
            cmbxTemp.Visible = False
            cmbxVolume.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'submit number to the main form
        If (Len(scaleNum1.Text) <> 0) Then
            Home.Label21.Text = scaleNum1.Text
        End If
        If (Len(scaleNum2.Text) <> 0) Then
            Home.Label22.Text = scaleNum2.Text
        End If
        If (Len(captionNum1.Text) <> 0) Then
            Home.Label28.Text = captionNum1.Text
        End If
        If (Len(captionNum2.Text) <> 0) Then
            Home.Label25.Text = captionNum2.Text
        End If
        If (Len(rangeNum.Text) <> 0) Then
            Home.Label26.Text = rangeNum.Text
        End If

        Home.Theme_Color()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
        frmCustomArt.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Function Possible(scale As String) As Boolean
        Dim selectedValue = CInt(scale)

        If Home.comDecimal.SelectedIndex = 0 Then '1
            If selectedValue > 999 Then
                Return False
            Else
                Return True
            End If
        ElseIf Home.comDecimal.SelectedIndex = 1 Then '2
            If selectedValue > 99 Then
                Return False
            Else
                Return True
            End If
        ElseIf Home.comDecimal.SelectedIndex = 2 Then '3
            If selectedValue > 9 Then
                Return False
            Else
                Return True
            End If
        Else 'Form1.comDecimal.SelectedIndex = 3 (none)
            Return True
        End If
    End Function
End Class