Public Class frmCustomArt

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim temp As String = txtbxCustNum.Text
        Home.lblCustArt.Visible = True
        Home.Label21.Text = temp.Substring(0, 1)
        Home.Label22.Text = temp.Substring(1, 1)
        Home.Label26.Text = temp.Substring(2, 1)
        Home.Label28.Text = temp.Substring(3, 1)
        Home.Label25.Text = temp.Substring(4, 1)
        Home.lblCustArt.Text = temp.Substring(5, 1)
        Home.Theme_Color()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtbxCustNum_TextChanged(sender As Object, e As EventArgs) Handles txtbxCustNum.TextChanged
        If Len(txtbxCustNum.Text) > 5 And Len(txtbxCustNum.Text) < 7 And IsNumeric(txtbxCustNum.Text) Then
            btnSubmit.Enabled = True
        Else
            btnSubmit.Enabled = False
        End If
    End Sub

    Private Sub frmCustomArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class