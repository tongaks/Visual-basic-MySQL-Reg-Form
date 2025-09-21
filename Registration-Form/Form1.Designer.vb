<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        Label6 = New Label()
        Panel1 = New Panel()
        ViewRecordBtn = New Button()
        Label22 = New Label()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        Label24 = New Label()
        Label23 = New Label()
        Label21 = New Label()
        ConfirmationChckBox = New CheckBox()
        Label20 = New Label()
        PostalCodeTxtBox = New TextBox()
        Label18 = New Label()
        Label19 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        MunicipalityCmbBox = New ComboBox()
        RegisterBtn = New Button()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        EmailTxtBox = New TextBox()
        Label8 = New Label()
        ContactNoTxtBox = New TextBox()
        SexCmbBox = New ComboBox()
        Label5 = New Label()
        SuffixCmbBox = New ComboBox()
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        FnameLbl = New Label()
        AddressTxtBox = New TextBox()
        SurnameTxtBox = New TextBox()
        MiddleNameTxtBox = New TextBox()
        FirstNameTxtBox = New TextBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label25 = New Label()
        Label26 = New Label()
        Label27 = New Label()
        ComboBox1 = New ComboBox()
        Label28 = New Label()
        Label29 = New Label()
        Label30 = New Label()
        ComboBox2 = New ComboBox()
        Label31 = New Label()
        Label32 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(154, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 25)
        Label6.TabIndex = 12
        Label6.Text = "Registration Form"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(ViewRecordBtn)
        Panel1.Controls.Add(Label22)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(-1, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(765, 58)
        Panel1.TabIndex = 34
        ' 
        ' ViewRecordBtn
        ' 
        ViewRecordBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ViewRecordBtn.BackColor = Color.DarkSalmon
        ViewRecordBtn.FlatAppearance.BorderSize = 0
        ViewRecordBtn.FlatStyle = FlatStyle.Flat
        ViewRecordBtn.Font = New Font("Segoe UI Black", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ViewRecordBtn.ForeColor = SystemColors.ControlLightLight
        ViewRecordBtn.Location = New Point(592, 13)
        ViewRecordBtn.Name = "ViewRecordBtn"
        ViewRecordBtn.Size = New Size(134, 37)
        ViewRecordBtn.TabIndex = 14
        ViewRecordBtn.Text = "RECORDS"
        ViewRecordBtn.UseVisualStyleBackColor = False
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI Black", 14.0F, FontStyle.Bold)
        Label22.ForeColor = SystemColors.ControlLightLight
        Label22.Location = New Point(13, 15)
        Label22.Name = "Label22"
        Label22.Size = New Size(147, 25)
        Label22.TabIndex = 13
        Label22.Text = "BARANGAY ID"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.Controls.Add(Label32)
        Panel2.Controls.Add(Label31)
        Panel2.Controls.Add(Label28)
        Panel2.Controls.Add(Label29)
        Panel2.Controls.Add(Label30)
        Panel2.Controls.Add(ComboBox2)
        Panel2.Controls.Add(Label25)
        Panel2.Controls.Add(Label26)
        Panel2.Controls.Add(Label27)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label24)
        Panel2.Controls.Add(Label23)
        Panel2.Controls.Add(Label21)
        Panel2.Controls.Add(ConfirmationChckBox)
        Panel2.Controls.Add(Label20)
        Panel2.Controls.Add(PostalCodeTxtBox)
        Panel2.Controls.Add(Label18)
        Panel2.Controls.Add(Label19)
        Panel2.Controls.Add(Label17)
        Panel2.Controls.Add(Label16)
        Panel2.Controls.Add(MunicipalityCmbBox)
        Panel2.Controls.Add(RegisterBtn)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(EmailTxtBox)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(ContactNoTxtBox)
        Panel2.Controls.Add(SexCmbBox)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(SuffixCmbBox)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(FnameLbl)
        Panel2.Controls.Add(AddressTxtBox)
        Panel2.Controls.Add(SurnameTxtBox)
        Panel2.Controls.Add(MiddleNameTxtBox)
        Panel2.Controls.Add(FirstNameTxtBox)
        Panel2.Location = New Point(12, 76)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(720, 486)
        Panel2.TabIndex = 35
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top
        TextBox1.BackColor = SystemColors.Window
        TextBox1.Enabled = False
        TextBox1.Location = New Point(453, 15)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(31, 23)
        TextBox1.TabIndex = 1037
        TextBox1.TabStop = False
        TextBox1.Text = "+63"
        ' 
        ' Label24
        ' 
        Label24.Anchor = AnchorStyles.Top
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = SystemColors.ControlDarkDark
        Label24.Location = New Point(205, 262)
        Label24.Name = "Label24"
        Label24.Size = New Size(70, 16)
        Label24.TabIndex = 1036
        Label24.Text = "Street name"
        ' 
        ' Label23
        ' 
        Label23.Anchor = AnchorStyles.Top
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = SystemColors.ControlDarkDark
        Label23.Location = New Point(125, 262)
        Label23.Name = "Label23"
        Label23.Size = New Size(50, 16)
        Label23.TabIndex = 1035
        Label23.Text = "Blck/Lot"
        ' 
        ' Label21
        ' 
        Label21.Anchor = AnchorStyles.Top
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Firebrick
        Label21.Location = New Point(267, 454)
        Label21.Name = "Label21"
        Label21.Size = New Size(51, 13)
        Label21.TabIndex = 1034
        Label21.Text = "Required"
        ' 
        ' ConfirmationChckBox
        ' 
        ConfirmationChckBox.Anchor = AnchorStyles.Top
        ConfirmationChckBox.AutoSize = True
        ConfirmationChckBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ConfirmationChckBox.Location = New Point(249, 429)
        ConfirmationChckBox.Name = "ConfirmationChckBox"
        ConfirmationChckBox.Size = New Size(336, 21)
        ConfirmationChckBox.TabIndex = 1018
        ConfirmationChckBox.Text = "I confirm that all details above is correct and accurate"
        ConfirmationChckBox.UseVisualStyleBackColor = True
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.Top
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.Firebrick
        Label20.Location = New Point(124, 363)
        Label20.Name = "Label20"
        Label20.Size = New Size(51, 13)
        Label20.TabIndex = 1033
        Label20.Text = "Required"
        ' 
        ' PostalCodeTxtBox
        ' 
        PostalCodeTxtBox.Anchor = AnchorStyles.Top
        PostalCodeTxtBox.Location = New Point(122, 387)
        PostalCodeTxtBox.Margin = New Padding(3, 2, 3, 2)
        PostalCodeTxtBox.Name = "PostalCodeTxtBox"
        PostalCodeTxtBox.Size = New Size(79, 23)
        PostalCodeTxtBox.TabIndex = 1016
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label18.Location = New Point(39, 389)
        Label18.Name = "Label18"
        Label18.Size = New Size(73, 17)
        Label18.TabIndex = 1032
        Label18.Text = "PostalCode"
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top
        Label19.AutoSize = True
        Label19.Location = New Point(586, 367)
        Label19.Name = "Label19"
        Label19.Size = New Size(0, 16)
        Label19.TabIndex = 1031
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label17.Location = New Point(35, 338)
        Label17.Name = "Label17"
        Label17.Size = New Size(83, 17)
        Label17.TabIndex = 1030
        Label17.Text = "Municipality"
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top
        Label16.AutoSize = True
        Label16.Location = New Point(77, 340)
        Label16.Name = "Label16"
        Label16.Size = New Size(0, 16)
        Label16.TabIndex = 1029
        ' 
        ' MunicipalityCmbBox
        ' 
        MunicipalityCmbBox.Anchor = AnchorStyles.Top
        MunicipalityCmbBox.FormattingEnabled = True
        MunicipalityCmbBox.Location = New Point(123, 336)
        MunicipalityCmbBox.Margin = New Padding(3, 2, 3, 2)
        MunicipalityCmbBox.Name = "MunicipalityCmbBox"
        MunicipalityCmbBox.Size = New Size(118, 24)
        MunicipalityCmbBox.TabIndex = 1015
        ' 
        ' RegisterBtn
        ' 
        RegisterBtn.Anchor = AnchorStyles.Top
        RegisterBtn.BackColor = Color.SteelBlue
        RegisterBtn.FlatAppearance.BorderSize = 0
        RegisterBtn.FlatStyle = FlatStyle.Flat
        RegisterBtn.Font = New Font("Segoe UI Black", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RegisterBtn.ForeColor = SystemColors.ControlLightLight
        RegisterBtn.Location = New Point(591, 429)
        RegisterBtn.Name = "RegisterBtn"
        RegisterBtn.Size = New Size(99, 39)
        RegisterBtn.TabIndex = 1019
        RegisterBtn.Text = "REGISTER"
        RegisterBtn.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Firebrick
        Label15.Location = New Point(123, 307)
        Label15.Name = "Label15"
        Label15.Size = New Size(51, 13)
        Label15.TabIndex = 1028
        Label15.Text = "Required"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Firebrick
        Label14.Location = New Point(123, 42)
        Label14.Name = "Label14"
        Label14.Size = New Size(51, 13)
        Label14.TabIndex = 1027
        Label14.Text = "Required"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Firebrick
        Label13.Location = New Point(454, 42)
        Label13.Name = "Label13"
        Label13.Size = New Size(51, 13)
        Label13.TabIndex = 1026
        Label13.Text = "Required"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Firebrick
        Label12.Location = New Point(123, 240)
        Label12.Name = "Label12"
        Label12.Size = New Size(51, 13)
        Label12.TabIndex = 1025
        Label12.Text = "Required"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Firebrick
        Label11.Location = New Point(250, 185)
        Label11.Name = "Label11"
        Label11.Size = New Size(51, 13)
        Label11.TabIndex = 1024
        Label11.Text = "Required"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Firebrick
        Label10.Location = New Point(123, 131)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 13)
        Label10.TabIndex = 1023
        Label10.Text = "Required"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label9.Location = New Point(357, 65)
        Label9.Name = "Label9"
        Label9.Size = New Size(88, 17)
        Label9.TabIndex = 1022
        Label9.Text = "Email address"
        ' 
        ' EmailTxtBox
        ' 
        EmailTxtBox.Anchor = AnchorStyles.Top
        EmailTxtBox.Location = New Point(454, 65)
        EmailTxtBox.Margin = New Padding(3, 2, 3, 2)
        EmailTxtBox.Name = "EmailTxtBox"
        EmailTxtBox.Size = New Size(219, 23)
        EmailTxtBox.TabIndex = 1012
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(367, 16)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 17)
        Label8.TabIndex = 1021
        Label8.Text = "Contact No."
        ' 
        ' ContactNoTxtBox
        ' 
        ContactNoTxtBox.Anchor = AnchorStyles.Top
        ContactNoTxtBox.Location = New Point(482, 15)
        ContactNoTxtBox.Margin = New Padding(3, 2, 3, 2)
        ContactNoTxtBox.Name = "ContactNoTxtBox"
        ContactNoTxtBox.Size = New Size(191, 23)
        ContactNoTxtBox.TabIndex = 1009
        ' 
        ' SexCmbBox
        ' 
        SexCmbBox.Anchor = AnchorStyles.Top
        SexCmbBox.FormattingEnabled = True
        SexCmbBox.Items.AddRange(New Object() {"Male", "Female"})
        SexCmbBox.Location = New Point(250, 159)
        SexCmbBox.Margin = New Padding(3, 2, 3, 2)
        SexCmbBox.Name = "SexCmbBox"
        SexCmbBox.Size = New Size(91, 24)
        SexCmbBox.TabIndex = 1006
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(77, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 17)
        Label5.TabIndex = 1017
        Label5.Text = "Suffix"
        ' 
        ' SuffixCmbBox
        ' 
        SuffixCmbBox.Anchor = AnchorStyles.Top
        SuffixCmbBox.FormattingEnabled = True
        SuffixCmbBox.Items.AddRange(New Object() {"Jr.", "Sr.", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"})
        SuffixCmbBox.Location = New Point(123, 159)
        SuffixCmbBox.Margin = New Padding(3, 2, 3, 2)
        SuffixCmbBox.Name = "SuffixCmbBox"
        SuffixCmbBox.Size = New Size(90, 24)
        SuffixCmbBox.TabIndex = 1004
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(52, 218)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 17)
        Label1.TabIndex = 1014
        Label1.Text = "Birth date"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Anchor = AnchorStyles.Top
        DateTimePicker1.Location = New Point(122, 215)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(220, 23)
        DateTimePicker1.TabIndex = 1008
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(14, 281)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 17)
        Label3.TabIndex = 1011
        Label3.Text = "Current address"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(53, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 17)
        Label4.TabIndex = 1010
        Label4.Text = "Surname"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(29, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 17)
        Label2.TabIndex = 1007
        Label2.Text = "Middle name"
        ' 
        ' FnameLbl
        ' 
        FnameLbl.Anchor = AnchorStyles.Top
        FnameLbl.AutoSize = True
        FnameLbl.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        FnameLbl.Location = New Point(45, 17)
        FnameLbl.Name = "FnameLbl"
        FnameLbl.Size = New Size(71, 17)
        FnameLbl.TabIndex = 1005
        FnameLbl.Text = "First name"
        ' 
        ' AddressTxtBox
        ' 
        AddressTxtBox.Anchor = AnchorStyles.Top
        AddressTxtBox.Location = New Point(123, 280)
        AddressTxtBox.Margin = New Padding(3, 2, 3, 2)
        AddressTxtBox.Name = "AddressTxtBox"
        AddressTxtBox.Size = New Size(534, 23)
        AddressTxtBox.TabIndex = 1013
        ' 
        ' SurnameTxtBox
        ' 
        SurnameTxtBox.Anchor = AnchorStyles.Top
        SurnameTxtBox.Location = New Point(122, 105)
        SurnameTxtBox.Margin = New Padding(3, 2, 3, 2)
        SurnameTxtBox.Name = "SurnameTxtBox"
        SurnameTxtBox.Size = New Size(219, 23)
        SurnameTxtBox.TabIndex = 1003
        ' 
        ' MiddleNameTxtBox
        ' 
        MiddleNameTxtBox.Anchor = AnchorStyles.Top
        MiddleNameTxtBox.Location = New Point(122, 64)
        MiddleNameTxtBox.Margin = New Padding(3, 2, 3, 2)
        MiddleNameTxtBox.Name = "MiddleNameTxtBox"
        MiddleNameTxtBox.Size = New Size(219, 23)
        MiddleNameTxtBox.TabIndex = 1002
        ' 
        ' FirstNameTxtBox
        ' 
        FirstNameTxtBox.Anchor = AnchorStyles.Top
        FirstNameTxtBox.Location = New Point(122, 15)
        FirstNameTxtBox.Margin = New Padding(3, 2, 3, 2)
        FirstNameTxtBox.Name = "FirstNameTxtBox"
        FirstNameTxtBox.Size = New Size(219, 23)
        FirstNameTxtBox.TabIndex = 1001
        ' 
        ' Label25
        ' 
        Label25.Anchor = AnchorStyles.Top
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label25.ForeColor = Color.Firebrick
        Label25.Location = New Point(318, 362)
        Label25.Name = "Label25"
        Label25.Size = New Size(51, 13)
        Label25.TabIndex = 1041
        Label25.Text = "Required"
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Top
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label26.Location = New Point(251, 338)
        Label26.Name = "Label26"
        Label26.Size = New Size(60, 17)
        Label26.TabIndex = 1040
        Label26.Text = "Province"
        ' 
        ' Label27
        ' 
        Label27.Anchor = AnchorStyles.Top
        Label27.AutoSize = True
        Label27.Location = New Point(293, 339)
        Label27.Name = "Label27"
        Label27.Size = New Size(0, 16)
        Label27.TabIndex = 1039
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(317, 335)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(111, 24)
        ComboBox1.TabIndex = 1038
        ' 
        ' Label28
        ' 
        Label28.Anchor = AnchorStyles.Top
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label28.ForeColor = Color.Firebrick
        Label28.Location = New Point(509, 361)
        Label28.Name = "Label28"
        Label28.Size = New Size(51, 13)
        Label28.TabIndex = 1045
        Label28.Text = "Required"
        ' 
        ' Label29
        ' 
        Label29.Anchor = AnchorStyles.Top
        Label29.AutoSize = True
        Label29.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label29.Location = New Point(442, 337)
        Label29.Name = "Label29"
        Label29.Size = New Size(64, 17)
        Label29.TabIndex = 1044
        Label29.Text = "Barangay"
        ' 
        ' Label30
        ' 
        Label30.Anchor = AnchorStyles.Top
        Label30.AutoSize = True
        Label30.Location = New Point(484, 338)
        Label30.Name = "Label30"
        Label30.Size = New Size(0, 16)
        Label30.TabIndex = 1043
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Anchor = AnchorStyles.Top
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(508, 334)
        ComboBox2.Margin = New Padding(3, 2, 3, 2)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(111, 24)
        ComboBox2.TabIndex = 1042
        ' 
        ' Label31
        ' 
        Label31.Anchor = AnchorStyles.Top
        Label31.AutoSize = True
        Label31.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label31.ForeColor = Color.Firebrick
        Label31.Location = New Point(123, 412)
        Label31.Name = "Label31"
        Label31.Size = New Size(51, 13)
        Label31.TabIndex = 1046
        Label31.Text = "Required"
        ' 
        ' Label32
        ' 
        Label32.Anchor = AnchorStyles.Top
        Label32.AutoSize = True
        Label32.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label32.Location = New Point(219, 162)
        Label32.Name = "Label32"
        Label32.Size = New Size(29, 17)
        Label32.TabIndex = 1047
        Label32.Text = "Sex"
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ButtonFace
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(747, 574)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "RegistrationForm"
        RightToLeft = RightToLeft.No
        Text = "Registration Form"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label22 As Label
    Friend WithEvents ViewRecordBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ConfirmationChckBox As CheckBox
    Friend WithEvents Label20 As Label
    Friend WithEvents PostalCodeTxtBox As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents MunicipalityCmbBox As ComboBox
    Friend WithEvents RegisterBtn As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents EmailTxtBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ContactNoTxtBox As TextBox
    Friend WithEvents SexCmbBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SuffixCmbBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FnameLbl As Label
    Friend WithEvents AddressTxtBox As TextBox
    Friend WithEvents SurnameTxtBox As TextBox
    Friend WithEvents MiddleNameTxtBox As TextBox
    Friend WithEvents FirstNameTxtBox As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label

End Class
