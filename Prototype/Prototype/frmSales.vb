Imports System.Data.OleDb

Public Class frmSales
    Private Sub frmSales_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Location = Me.Location
        Home.Show()
        Me.Dispose()
    End Sub

    Public Function getSQL(model As String, code As String) As String
        Dim sql As String = "SELECT Final_Assembly_Number FROM FNLASSY WHERE Model = '" + model + "'AND Code = '" + code + "'"
        Return sql
    End Function

    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCompAssem()
        PopulateScaleBox()
        PopulateManuals()
        Dim codeString As String
        Dim selectedModel As String = Trim(Home.standardComModel.SelectedItem.ToString)
        Dim sql As String

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\FNLASSY.accdb;Persist Security Info=True"
        Dim finalTable As New DataTable()

        Select Case selectedModel
            Case "BS101P", "BJ101P"
                codeString = Home.alarmNum.Text
                sql = getSQL(selectedModel, codeString)
                Dim adapter = New OleDbDataAdapter(sql, connectionString)
                adapter.Fill(finalTable)

                If finalTable.Rows.Count > 0 Then
                    finalAssemNum.Text = finalTable.Rows(0).Item(0).ToString
                End If
            Case "BB101P", "BK051P"
                codeString = Home.powerNum.Text + Home.optionNum.Text
                sql = getSQL(selectedModel, codeString)
                Dim adapter = New OleDbDataAdapter(sql, connectionString)
                adapter.Fill(finalTable)

                If finalTable.Rows.Count > 0 Then
                    finalAssemNum.Text = finalTable.Rows(0).Item(0).ToString
                End If
            Case "BL101P", "BL202P"
                codeString = Home.optionNum.Text + Home.conformalNum.Text
                sql = getSQL(selectedModel, codeString)
                Dim adapter = New OleDbDataAdapter(sql, connectionString)
                adapter.Fill(finalTable)

                If finalTable.Rows.Count > 0 Then
                    finalAssemNum.Text = finalTable.Rows(0).Item(0).ToString
                End If
            Case "BT033P"
                codeString = Home.orientationNum.Text + Home.digColorNum.Text + Home.stptNum.Text + Home.conformalNum.Text
                sql = getSQL(selectedModel, codeString)
                Dim adapter = New OleDbDataAdapter(sql, connectionString)
                adapter.Fill(finalTable)

                If finalTable.Rows.Count > 0 Then
                    finalAssemNum.Text = finalTable.Rows(0).Item(0).ToString
                End If
            Case "BT071P"
                codeString = Home.powerNum.Text + Home.switchesNum.Text + Home.optionNum.Text
                sql = getSQL(selectedModel, codeString)
                Dim adapter = New OleDbDataAdapter(sql, connectionString)
                adapter.Fill(finalTable)

                If finalTable.Rows.Count > 0 Then
                    finalAssemNum.Text = finalTable.Rows(0).Item(0).ToString
                End If
            Case "BTW71P", "BWO51P"
                codeString = Home.powerNum.Text + Home.conformalNum.Text
                sql = getSQL(selectedModel, codeString)
                Dim adapter = New OleDbDataAdapter(sql, connectionString)
                adapter.Fill(finalTable)

                If finalTable.Rows.Count > 0 Then
                    finalAssemNum.Text = finalTable.Rows(0).Item(0).ToString
                End If
        End Select
    End Sub

    Private Sub COMPDISPBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.COMPDISPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Compln_DisplayDataSet)
    End Sub

    Private Sub PopulateCompAssem()
        Dim Model As String
        If Not String.IsNullOrWhiteSpace(Trim(Home.comOrientation.SelectedItem.ToString.Substring(0, 1))) Then
            Model = Trim(Home.standardComModel.SelectedItem.ToString) + Trim(Home.comOrientation.SelectedItem.ToString.Substring(0, 1))
        Else
            Model = Trim(Home.standardComModel.SelectedItem.ToString)
        End If

        Dim Code As String = Home.barColorNum.Text + Home.digColorNum.Text + Home.stptNum.Text

        Dim SQL_Query As String = "SELECT Completion_Assembly_Number FROM COMPDISP WHERE Model = '" + Model + "' AND Code = '" + Code + "'"
        Dim MyConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Compln_Display.accdb;Persist Security Info=True"
        Dim MyDataAdapter = New OleDbDataAdapter(SQL_Query, MyConnectionString)
        Dim TempTable As New DataTable()

        MyDataAdapter.Fill(TempTable)
        TempTable.Locale = System.Globalization.CultureInfo.InvariantCulture

        If TempTable.Rows.Count > 0 Then
            txtbxCompAssem.Text = TempTable.Rows(0).Item(0).ToString
        Else
            txtbxCompAssem.Text = "N/A"
        End If
    End Sub

    Private Sub PopulateScaleBox()
        Dim Model As String
        If Not String.IsNullOrWhiteSpace(Trim(Home.comOrientation.SelectedItem.ToString.Substring(0, 1))) Then
            Model = Trim(Home.standardComModel.SelectedItem.ToString) + Trim(Home.comOrientation.SelectedItem.ToString.Substring(0, 1))
        Else
            Model = Trim(Home.standardComModel.SelectedItem.ToString)
        End If

        Dim Code As String = Home.barColorNum.Text + Home.digColorNum.Text + Home.stptNum.Text + Home.switchesNum.Text
        Dim SQL_Query As String = "SELECT scale FROM FinalScale WHERE Model = '" + Model + "' AND Code = '" + Code + "'"
        Dim MyConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\ScaleStuff.accdb;Persist Security Info=True"
        Dim MyDataAdapter = New OleDbDataAdapter(SQL_Query, MyConnectionString)
        Dim TempTable As New DataTable()

        MyDataAdapter.Fill(TempTable)
        TempTable.Locale = System.Globalization.CultureInfo.InvariantCulture

        If TempTable.Rows.Count > 0 Then
            txtbxScaleNuber.Text = TempTable.Rows(0).Item(0).ToString
        Else
            txtbxScaleNuber.Text = "N/A"
        End If
    End Sub


    Private Sub PopulateManuals()
        Dim Model As String = Trim(Home.standardComModel.SelectedItem.ToString) + Trim(Home.comOrientation.SelectedItem.ToString.Substring(0, 1))

        Dim SQL_Query As String = "SELECT manual FROM manuals WHERE model = '" + Model + "'"
        Dim MyConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Manuals.accdb;Persist Security Info=True"
        Dim MyDataAdapter = New OleDbDataAdapter(SQL_Query, MyConnectionString)
        Dim TempTable As New DataTable()

        MyDataAdapter.Fill(TempTable)
        TempTable.Locale = System.Globalization.CultureInfo.InvariantCulture

        If TempTable.Rows.Count > 0 Then
            txtbxManual.Text = TempTable.Rows(0).Item(0).ToString
        Else
            txtbxManual.Text = "N/A"
        End If
    End Sub
End Class