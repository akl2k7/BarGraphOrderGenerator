Imports System
Imports System.Data.SqlClient

Public Class frmSearch
    '    ''~~~~~~~~These should be added to main~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    Public udlLocation As String = "Data Source=co-gra-as03;" &
    '                                   "Initial Catalog=EPA;" &
    '                                   "Integrated Security=SSPI;" &
    '                                   "MultipleActiveResultSets=True;" ''Initial Catalog=EPA will be changed
    '   Public myConnection As New SqlConnection(udlLocation)
    Public SQLstr As String = "" '"UPDATE QTR_Def SET Closed = 'true' WHERE Quarter = '" + lastQuarter + "'"
    Public UserName As String = LCase(Environment.GetEnvironmentVariable("username").ToString)
    Public NoDate As Date = #1/1/1900#

    '    Public Sub SQLnonQuery(commandString As String)
    '        Dim myCommand = New SqlCommand(commandString, myConnection)
    '        Try
    '            myCommand.ExecuteNonQuery()
    '        Catch ex As Exception
    '            MsgBox("Error:" + vbLf + "------" + vbLf + ex.ToString)
    '        End Try
    '        '' google "parameter queries vb.net", look for the @variable stuff
    '    End Sub

    '    Public Sub SQLquery(commandString As String)
    '        Dim myCommand = New SqlCommand(commandString, myConnection)
    '        Dim drUser As SqlDataReader = myCommand.ExecuteReader
    '        drUser.Read()
    '        myCommand.Parameters.AddWithValue(@something, "value")
    '        ''=============An Example of how to use the SqlDataReader
    '        'If drUser("Security") Then 'security is a bit field inside of the username relation
    '        '    'IsSecurity = True
    '        'End If
    '        drUser.Close()
    '    End Sub
    '    ''~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Home.Location
        dtpBeforeDate.Value = Now.AddDays(1)
        dtpAfterdate.Value = noDate
    End Sub
    '    Private Sub SearchFieldChange() Handles txtbxCustName.TextChanged, txtbxCustID.TextChanged, txtbxQuoteNum.TextChanged, txtbxQuoteQty.TextChanged, txtbxQuoteWorth.TextChanged, dtpBeforeDate.ValueChanged, dtpAfterdate.ValueChanged
    '        If Not String.IsNullOrWhiteSpace(txtbxCustName.Text) And Not String.IsNullOrWhiteSpace(txtbxCustID.Text) And Not String.IsNullOrWhiteSpace(txtbxQuoteNum.Text) And Not String.IsNullOrWhiteSpace(txtbxQuoteQty.Text) And Not String.IsNullOrWhiteSpace(txtbxQuoteWorth.Text) And Not dtpBeforeDate.Value = NoDate And Not dtpAfterdate.Value = NoDate Then
    '            Dim isFirst As Boolean = True
    '            Dim SQLstring As String = "SELECT [CustName] as 'Customer Name', [CustID] as 'Customer ID', [QuoteNum] as 'Quote Number', [QuoteQty] as 'Quote Quantity', [QuoteWorth] as 'Quote Worth' FROM [table] WHERE "

    '            If Not String.IsNullOrWhiteSpace(txtbxCustName.Text) Then
    '                isFirst = False
    '                SQLstring += "[CustName] LIKE @CustName"
    '            End If

    '            If Not String.IsNullOrWhiteSpace(txtbxCustID.Text) Then
    '                If Not isFirst Then
    '                    SQLstring += " AND "
    '                End If
    '                isFirst = False
    '                SQLstring += "[CustID] LIKE @CustID"
    '            End If

    '            If Not String.IsNullOrWhiteSpace(txtbxQuoteNum.Text) Then
    '                If Not isFirst Then
    '                    SQLstring += " AND "
    '                End If
    '                isFirst = False
    '                SQLstring += "[QuoteNum] LIKE @QuoteNum"
    '            End If

    '            If Not String.IsNullOrWhiteSpace(txtbxQuoteQty.Text) Then
    '                If Not isFirst Then
    '                    SQLstring += " AND "
    '                End If
    '                isFirst = False
    '                SQLstring += "[QuoteQty] LIKE @QuoteQty"
    '            End If

    '            If Not String.IsNullOrWhiteSpace(txtbxQuoteWorth.Text) Then
    '                If Not isFirst Then
    '                    SQLstring += " AND "
    '                End If
    '                isFirst = False
    '                SQLstring += "[QuoteWorth] LIKE @QuoteWorth"
    '            End If

    '            If Not dtpAfterdate.Value = NoDate And Not dtpBeforeDate.Value = NoDate Then
    '                'date between the two dates
    '            Else 'otherwise only one of the two is valid
    '                If Not dtpAfterdate.Value = NoDate Then
    '                    'date is greater than dtpAfterdate.Value 
    '                Else
    '                    'date is less than dtpBeforeDate.Value
    '                End If
    '            End If

    '            Dim myCommand = New SqlCommand(SQLstring, myConnection)
    '            Dim drUser As SqlDataReader = myCommand.ExecuteReader
    '            myCommand.Parameters.AddWithValue(@CustName, "%" + Trim(txtbxCustName.Text) + "%")        
    '            myCommand.Parameters.AddWithValue(@CustID, "%" + Trim(txtbxCustID.Text) + "%")        
    '            myCommand.Parameters.AddWithValue(@QuoteNum, "%" + Trim(txtbxQuoteNum.Text) + "%")       
    '            myCommand.Parameters.AddWithValue(@QuoteQty, "%" + Trim(txtbxQuoteQty.Text)  + "%")      
    '            myCommand.Parameters.AddWithValue(@QuoteWorth, "%" + Trim(txtbxQuoteWorth.Text) + "%")
    '            myCommand.Parameters.AddWithValue(@DateStart, txtbxQuoteWorth.Text)
    '            myCommand.Parameters.AddWithValue(@DateEnd, txtbxQuoteWorth.Text)
    '            dgvResults.DataSource = drUser.Read
    '        End If
    '    End Sub

    Private Sub frmSearch_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Home.Size = Me.Size
        Home.Location = Me.Location
        Home.Show()
        Me.Dispose()
    End Sub

    Private Sub LastFiveDigitsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmArtwork.Size = Me.Size
        frmArtwork.Location = Me.Location
        frmArtwork.Show()
        Me.Hide()
    End Sub

    Private Sub EmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailToolStripMenuItem.Click
        frmEmail.Size = Me.Size
        frmEmail.Location = Me.Location
        frmEmail.Show()
        Me.Hide()
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        frmEmail.Size = Me.Size
        frmEmail.Location = Me.Location
        frmEmail.Show()
        Me.Hide()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Home.Size = Me.Size
        Home.Location = Me.Location
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Application.Exit()
        'fix this
        Me.Close()
    End Sub
End Class
