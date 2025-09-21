Imports System.Data.OleDb
Imports System.Drawing.Drawing2D
Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Windows.Win32.System


Public Class RegistrationForm
    Dim ConnectionString As String
    Dim CurrentUser As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CurrentPath As String = Directory.GetCurrentDirectory()
        Dim DirInfo As New DirectoryInfo(CurrentPath)


        ' move 4 up para tumutok sa parent dir ng project
        For i As Integer = 1 To 4
            If DirInfo.Parent IsNot Nothing Then
                DirInfo = DirInfo.Parent
            Else
                Exit For
            End If
        Next

        'ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & DirInfo.FullName & "\MSAccess\OOPact.accdb ;Persist Security Info=False;"
        ConnectionString = "server=localhost;user=root;database=registrationform;port=3306;password=washer22456;"
        LoadMunicipalityDB()
    End Sub

    Private Sub ClearAllTextBox()
        FirstNameTxtBox.Clear()
        MiddleNameTxtBox.Clear()
        SurnameTxtBox.Clear()
        SuffixCmbBox.Text = ""
        SexCmbBox.Text = ""
        AddressTxtBox.Clear()
        MunicipalityCmbBox.Text = ""
        PostalCodeTxtBox.Clear()
        ContactNoTxtBox.Clear()
        EmailTxtBox.Clear()
    End Sub


    ' crud Functions
    Private Sub AddRecord(ByVal lname As String, ByVal fname As String, ByVal mname As String, ByVal suffix As String, ByVal sex As String, ByVal contactno As String, ByVal emailaddr As String, ByVal birthdate As String, ByVal address As String, ByVal municipality As String, ByVal postalCode As String)
        Dim conn As MySql.Data.MySqlClient.MySqlConnection
        Dim cmd As MySql.Data.MySqlClient.MySqlCommand

        Try
            conn = New MySql.Data.MySqlClient.MySqlConnection(ConnectionString)
            conn.Open()

            Dim sql As String = "INSERT INTO `registrationform`.`registration_form` (LastName, FirstName, MiddleName, Suffix, Sex, ContactNo, EmailAddress, BirthDate, AddressIn, Municipality, PostalCode) VALUES (@lname, @fname, @mname, @suffix, @sex, @contactno, @email, @birthdate, @addr, @muni, @postc)"

            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@lname", lname)
            cmd.Parameters.AddWithValue("@fname", fname)
            cmd.Parameters.AddWithValue("@mname", mname)
            cmd.Parameters.AddWithValue("@suffix", suffix)
            cmd.Parameters.AddWithValue("@sex", sex)
            cmd.Parameters.AddWithValue("@contactno", contactno)
            cmd.Parameters.AddWithValue("@email", emailaddr)
            cmd.Parameters.AddWithValue("@birthdate", birthdate)
            cmd.Parameters.AddWithValue("@addr", address)
            cmd.Parameters.AddWithValue("@muni", municipality)
            cmd.Parameters.AddWithValue("@postc", postalCode)

            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MsgBox("Record Added Successfully!", MsgBoxStyle.Information, "Success")
            Else
                MessageBox.Show("Failed to Add Record.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = System.Data.ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub LoadMunicipalityDB()
        Dim conn As New MySqlConnection(ConnectionString)
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim sql = "SELECT municipality_name FROM table_municipality ORDER BY municipality_name ASC"
            cmd = New MySqlCommand(sql, conn)
            reader = cmd.ExecuteReader

            While reader.Read()
                Dim municipality As String = If(IsDBNull(reader("municipality_name")), "NULL", reader("municipality_name"))
                MunicipalityCmbBox.Items.Add(municipality)
            End While

        Catch ex As Exception
            MsgBox("Error connecting to database: " & ex.Message)
        End Try
    End Sub


    Private Sub LetterOnly_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NumberOnly_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub



    Private Sub ContactNoLimit(sender As Object, e As EventArgs)
        If ContactNoTxtBox.TextLength >= 11 Then
            ContactNoTxtBox.Text = ContactNoTxtBox.Text.Remove(ContactNoTxtBox.TextLength - 1)
            ContactNoTxtBox.Select(ContactNoTxtBox.TextLength, 1)
        End If
    End Sub



    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs)
        If Not ValidateRequiredFields() Then
            Exit Sub
        End If

        Dim firstName = FirstNameTxtBox.Text
        Dim middleName = If(MiddleNameTxtBox.Text = "", "N/A", MiddleNameTxtBox.Text)
        Dim surName = SurnameTxtBox.Text
        Dim suffix = If(SuffixCmbBox.Text = "", "N/A", SuffixCmbBox.Text)
        Dim sex = SexCmbBox.Text

        Dim contactNo = ContactNoTxtBox.Text
        Dim emailAddr = If(EmailTxtBox.Text = "", "N/A", EmailTxtBox.Text)

        Dim birthDate = DateTimePicker1.Value
        Dim birthDateFix = birthDate.ToString("M/d/yyyy")

        Dim address = AddressTxtBox.Text
        Dim municipality = MunicipalityCmbBox.Text
        Dim postalCode = If(PostalCodeTxtBox.Text = "", "N/A", PostalCodeTxtBox.Text)

        AddRecord(surName, firstName, middleName, suffix, sex, contactNo, emailAddr, birthDateFix, address, municipality, postalCode)
        ClearAllTextBox()

        Dim res = MsgBox("Would you like to see the records?", MsgBoxStyle.YesNoCancel, "Notice")
        If res = MsgBoxResult.Yes Then
            Form2.Show(Me)
        End If
    End Sub

    Private Sub ConfirmationChckBox_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If ConfirmationChckBox.Checked = False Then
                ConfirmationChckBox.Checked = True
            Else
                ConfirmationChckBox.Checked = False
            End If
        End If
    End Sub

    Private Function ValidateRequiredFields() As Boolean

        If String.IsNullOrWhiteSpace(FirstNameTxtBox.Text) Then
            MsgBox("Name is required.", MsgBoxStyle.Critical, "Notice")
            FirstNameTxtBox.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(SurnameTxtBox.Text) Then
            MsgBox("Surname is required.", MsgBoxStyle.Critical, "Notice")
            SurnameTxtBox.Focus()
            Return False
        End If

        If (String.IsNullOrWhiteSpace(SexCmbBox.Text)) Then
            MsgBox("Sex orienation is required.", MsgBoxStyle.Critical, "Notice")
            SexCmbBox.Focus()
            Return False
        End If

        If ((Integer.Parse(Date.Now.ToString("yyyy"))) - Integer.Parse(DateTimePicker1.Value.Year.ToString)) < 18 Then
            MsgBox("Age must be greater than 18 years old.", MsgBoxStyle.Critical, "Notice")
            Return False
        End If

        If ContactNoTxtBox.Text = "" Then
            MsgBox("Contact No. is required.", MsgBoxStyle.Critical, "Notice")
            ContactNoTxtBox.Focus()
            Return False
        ElseIf ContactNoTxtBox.TextLength < 10 Then
            MsgBox("Contact No. is less than 10 digits.", MsgBoxStyle.Critical, "Notice")
            ContactNoTxtBox.Focus()
            Return False
        ElseIf ContactNoTxtBox.Text.Chars(0) <> "9" Then
            MsgBox("First digit must be a '9'.", MsgBoxStyle.Critical, "Notice")
            ContactNoTxtBox.Focus()
            Return False
        End If

        If Not String.IsNullOrWhiteSpace(EmailTxtBox.Text) Then
            Dim atSignIndex = EmailTxtBox.Text.IndexOf("@")
            If (atSignIndex = -1) Then
                MsgBox("E-Mail Address is invalid.", MsgBoxStyle.Critical, "Notice")
                EmailTxtBox.Focus()
                Return False
            End If

            Dim lastPart As String = EmailTxtBox.Text.Substring(atSignIndex)
            If Not lastPart.Contains(".") Then
                MsgBox("E-Mail Address is invalid.", MsgBoxStyle.Critical, "Notice")
                EmailTxtBox.Focus()
                Return False
            End If
        End If

        If String.IsNullOrWhiteSpace(AddressTxtBox.Text) Then
            MsgBox("Present Address is required.", MsgBoxStyle.Critical, "Notice")
            AddressTxtBox.Focus()
            Return False
        End If

        If (String.IsNullOrWhiteSpace(MunicipalityCmbBox.Text)) Then
            MsgBox("Municipality is required.", MsgBoxStyle.Critical, "Notice")
            MunicipalityCmbBox.Focus()
            Return False
        End If

        If Not ConfirmationChckBox.Checked Then
            MsgBox("Please confirm that all information above is correct.", MsgBoxStyle.Critical, "Notice")
            ConfirmationChckBox.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub ViewRecordBtn_Click(sender As Object, e As EventArgs) Handles ViewRecordBtn.Click
        Form2.Show()
    End Sub

    Private Sub SexCmbBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub TextBox_Limit(sender As Object, e As EventArgs)
        Dim caller = DirectCast(sender, TextBox)
        If caller.TextLength > 255 Then
            MsgBox("Limit reached.")
            caller.Text = caller.Text.Remove(caller.TextLength - 1)
            caller.Select(caller.TextLength, 1)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
