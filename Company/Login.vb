Public Class Login
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Dim form2 = New CompanyList()
        AddHandler form2.Closed, Sub(s, args) Me.Close()
        form2.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim objCompany As New clsCompany()

        Dim intCompanyId As Integer

        intCompanyId = objCompany.AuthenticateUser(txtUserName.Text, txtPassword.Text)

        If intCompanyId = 0 Then
            MessageBox.Show("Invalid UserName or Password")
            Return
        Else
            Me.Hide()
            Dim form2 = New CustomerList()
            AddHandler form2.Closed, Sub(s, args) Me.Close()
            form2.lblCompanyId.Text = intCompanyId
            form2.Show()
        End If
    End Sub

End Class