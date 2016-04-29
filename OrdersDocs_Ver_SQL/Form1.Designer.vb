<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("частична")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("пълна")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Планова", New System.Windows.Forms.TreeNode() {TreeNode35, TreeNode36})
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("по случай (казус)")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("частична")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("пълна")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("тематична", New System.Windows.Forms.TreeNode() {TreeNode39, TreeNode40})
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("самосезиране", New System.Windows.Forms.TreeNode() {TreeNode38, TreeNode41})
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("по случай (казус)")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("частична")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("пълна")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("тематична", New System.Windows.Forms.TreeNode() {TreeNode44, TreeNode45})
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("по сигнал", New System.Windows.Forms.TreeNode() {TreeNode43, TreeNode46})
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Извънредна", New System.Windows.Forms.TreeNode() {TreeNode42, TreeNode47})
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("планова")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("извънредна")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Повторна", New System.Windows.Forms.TreeNode() {TreeNode49, TreeNode50})
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.chbCorruption = New System.Windows.Forms.CheckBox()
        Me.btnTasksListEdit = New System.Windows.Forms.Button()
        Me.TreeViewReasons = New System.Windows.Forms.TreeView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.nlTasksCount = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbScope = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clbMode = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkListBoxReason = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gbDZOF = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbPHIF = New System.Windows.Forms.ComboBox()
        Me.tbPHIF_Address = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbRZOK = New System.Windows.Forms.GroupBox()
        Me.tbRegRHIF_Address = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbRegHIF = New System.Windows.Forms.ComboBox()
        Me.btnObjectsListEdit = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbObjectID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbAuditObject = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbDomain = New System.Windows.Forms.ComboBox()
        Me.cbPlace = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cbMainSign = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbApproving = New System.Windows.Forms.ListBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbTeamMembers = New System.Windows.Forms.ListBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbHeadName = New System.Windows.Forms.ComboBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.chkB_StandardsFullSet = New System.Windows.Forms.CheckBox()
        Me.lbStandards = New System.Windows.Forms.ListBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbCountSelectedStandards = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.grbLetters = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbAuthority4 = New System.Windows.Forms.ComboBox()
        Me.tbLetter4 = New System.Windows.Forms.TextBox()
        Me.cbAuthority3 = New System.Windows.Forms.ComboBox()
        Me.tbLetter3 = New System.Windows.Forms.TextBox()
        Me.cbAuthority2 = New System.Windows.Forms.ComboBox()
        Me.tbLetter2 = New System.Windows.Forms.TextBox()
        Me.cbAuthority1 = New System.Windows.Forms.ComboBox()
        Me.tbLetter1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbComplaintsList = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.nlTasksCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbDZOF.SuspendLayout()
        Me.gbRZOK.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.grbLetters.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(-3, -1)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1030, 442)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.chbCorruption)
        Me.TabPage1.Controls.Add(Me.btnTasksListEdit)
        Me.TabPage1.Controls.Add(Me.TreeViewReasons)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.nlTasksCount)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.cbScope)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.clbMode)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.chkListBoxReason)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1022, 413)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Заповед"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(371, 10)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(255, 17)
        Me.Label24.TabIndex = 18
        Me.Label24.Text = "Основание (причина) за проверката:"
        '
        'chbCorruption
        '
        Me.chbCorruption.AutoSize = True
        Me.chbCorruption.BackColor = System.Drawing.Color.Red
        Me.chbCorruption.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chbCorruption.ForeColor = System.Drawing.Color.White
        Me.chbCorruption.Location = New System.Drawing.Point(821, 370)
        Me.chbCorruption.Name = "chbCorruption"
        Me.chbCorruption.Size = New System.Drawing.Size(177, 21)
        Me.chbCorruption.TabIndex = 16
        Me.chbCorruption.Text = "проверка за корупция"
        Me.chbCorruption.UseVisualStyleBackColor = False
        '
        'btnTasksListEdit
        '
        Me.btnTasksListEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTasksListEdit.Enabled = False
        Me.btnTasksListEdit.Location = New System.Drawing.Point(15, 312)
        Me.btnTasksListEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTasksListEdit.Name = "btnTasksListEdit"
        Me.btnTasksListEdit.Size = New System.Drawing.Size(179, 28)
        Me.btnTasksListEdit.TabIndex = 15
        Me.btnTasksListEdit.Text = "Списък на задачите"
        Me.btnTasksListEdit.UseVisualStyleBackColor = False
        '
        'TreeViewReasons
        '
        Me.TreeViewReasons.BackColor = System.Drawing.Color.White
        Me.TreeViewReasons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeViewReasons.Location = New System.Drawing.Point(375, 35)
        Me.TreeViewReasons.Margin = New System.Windows.Forms.Padding(4)
        Me.TreeViewReasons.Name = "TreeViewReasons"
        TreeNode35.ForeColor = System.Drawing.Color.Red
        TreeNode35.Name = "Node3"
        TreeNode35.Text = "частична"
        TreeNode36.ForeColor = System.Drawing.Color.Red
        TreeNode36.Name = "Node5"
        TreeNode36.Text = "пълна"
        TreeNode37.ForeColor = System.Drawing.Color.Blue
        TreeNode37.Name = "Node0"
        TreeNode37.Text = "Планова"
        TreeNode38.ForeColor = System.Drawing.Color.Red
        TreeNode38.Name = "Node8"
        TreeNode38.Text = "по случай (казус)"
        TreeNode39.ForeColor = System.Drawing.Color.Red
        TreeNode39.Name = "Node10"
        TreeNode39.Text = "частична"
        TreeNode40.ForeColor = System.Drawing.Color.Red
        TreeNode40.Name = "Node11"
        TreeNode40.Text = "пълна"
        TreeNode41.ForeColor = System.Drawing.Color.Black
        TreeNode41.Name = "Node9"
        TreeNode41.Text = "тематична"
        TreeNode42.Name = "Node6"
        TreeNode42.Text = "самосезиране"
        TreeNode43.ForeColor = System.Drawing.Color.Red
        TreeNode43.Name = "Node12"
        TreeNode43.Text = "по случай (казус)"
        TreeNode44.ForeColor = System.Drawing.Color.Red
        TreeNode44.Name = "Node14"
        TreeNode44.Text = "частична"
        TreeNode45.ForeColor = System.Drawing.Color.Red
        TreeNode45.Name = "Node15"
        TreeNode45.Text = "пълна"
        TreeNode46.Name = "Node13"
        TreeNode46.Text = "тематична"
        TreeNode47.Name = "Node7"
        TreeNode47.Text = "по сигнал"
        TreeNode48.ForeColor = System.Drawing.Color.Blue
        TreeNode48.Name = "Node1"
        TreeNode48.Text = "Извънредна"
        TreeNode49.ForeColor = System.Drawing.Color.Red
        TreeNode49.Name = "Node16"
        TreeNode49.Text = "планова"
        TreeNode50.ForeColor = System.Drawing.Color.Red
        TreeNode50.Name = "Node17"
        TreeNode50.Text = "извънредна"
        TreeNode51.ForeColor = System.Drawing.Color.Blue
        TreeNode51.Name = "Node2"
        TreeNode51.Text = "Повторна"
        Me.TreeViewReasons.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode37, TreeNode48, TreeNode51})
        Me.TreeViewReasons.ShowNodeToolTips = True
        Me.TreeViewReasons.Size = New System.Drawing.Size(253, 344)
        Me.TreeViewReasons.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 256)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(163, 17)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Задача № в заповедта:"
        '
        'nlTasksCount
        '
        Me.nlTasksCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nlTasksCount.Enabled = False
        Me.nlTasksCount.Location = New System.Drawing.Point(15, 280)
        Me.nlTasksCount.Margin = New System.Windows.Forms.Padding(4)
        Me.nlTasksCount.Name = "nlTasksCount"
        Me.nlTasksCount.Size = New System.Drawing.Size(179, 22)
        Me.nlTasksCount.TabIndex = 13
        Me.nlTasksCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(670, 274)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Обхват:"
        '
        'cbScope
        '
        Me.cbScope.FormattingEnabled = True
        Me.cbScope.Items.AddRange(New Object() {"само в един обект", "в няколко обекта (проследяване на случай)"})
        Me.cbScope.Location = New System.Drawing.Point(670, 298)
        Me.cbScope.Margin = New System.Windows.Forms.Padding(4)
        Me.cbScope.Name = "cbScope"
        Me.cbScope.Size = New System.Drawing.Size(328, 24)
        Me.cbScope.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 126)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Начин на проверката:"
        '
        'clbMode
        '
        Me.clbMode.CheckOnClick = True
        Me.clbMode.FormattingEnabled = True
        Me.clbMode.Items.AddRange(New Object() {"на място", "по документи"})
        Me.clbMode.Location = New System.Drawing.Point(15, 144)
        Me.clbMode.Margin = New System.Windows.Forms.Padding(4)
        Me.clbMode.Name = "clbMode"
        Me.clbMode.Size = New System.Drawing.Size(177, 55)
        Me.clbMode.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(670, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Вид на задачите:"
        '
        'chkListBoxReason
        '
        Me.chkListBoxReason.CheckOnClick = True
        Me.chkListBoxReason.FormattingEnabled = True
        Me.chkListBoxReason.Items.AddRange(New Object() {"Проверка по жалба(и)", "Проверка по писмо(а)", "Структура, организация и дейност", "Проверка по медицински стандарти", "По Наредба за достъп /НОПДМП/", "По Наредба №34", "Проверка на РЗОК", "Проверка на НЗОК(цу)", "ДДЗО"})
        Me.chkListBoxReason.Location = New System.Drawing.Point(670, 35)
        Me.chkListBoxReason.Margin = New System.Windows.Forms.Padding(4)
        Me.chkListBoxReason.Name = "chkListBoxReason"
        Me.chkListBoxReason.Size = New System.Drawing.Size(328, 174)
        Me.chkListBoxReason.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(331, 105)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "период на проверката:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(49, 71)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "до:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(49, 28)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "от:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gbDZOF)
        Me.TabPage2.Controls.Add(Me.gbRZOK)
        Me.TabPage2.Controls.Add(Me.btnObjectsListEdit)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.tbObjectID)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.tbAddress)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.lbAuditObject)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.cbDomain)
        Me.TabPage2.Controls.Add(Me.cbPlace)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1022, 413)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Обект"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gbDZOF
        '
        Me.gbDZOF.Controls.Add(Me.Label13)
        Me.gbDZOF.Controls.Add(Me.cbPHIF)
        Me.gbDZOF.Controls.Add(Me.tbPHIF_Address)
        Me.gbDZOF.Controls.Add(Me.Label14)
        Me.gbDZOF.Enabled = False
        Me.gbDZOF.Location = New System.Drawing.Point(13, 320)
        Me.gbDZOF.Margin = New System.Windows.Forms.Padding(4)
        Me.gbDZOF.Name = "gbDZOF"
        Me.gbDZOF.Padding = New System.Windows.Forms.Padding(4)
        Me.gbDZOF.Size = New System.Drawing.Size(723, 79)
        Me.gbDZOF.TabIndex = 21
        Me.gbDZOF.TabStop = False
        Me.gbDZOF.Text = "ДЗО"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 20)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Дружество за ДЗО:"
        '
        'cbPHIF
        '
        Me.cbPHIF.FormattingEnabled = True
        Me.cbPHIF.Location = New System.Drawing.Point(161, 15)
        Me.cbPHIF.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPHIF.Name = "cbPHIF"
        Me.cbPHIF.Size = New System.Drawing.Size(535, 24)
        Me.cbPHIF.TabIndex = 13
        '
        'tbPHIF_Address
        '
        Me.tbPHIF_Address.Location = New System.Drawing.Point(161, 49)
        Me.tbPHIF_Address.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPHIF_Address.Name = "tbPHIF_Address"
        Me.tbPHIF_Address.Size = New System.Drawing.Size(535, 22)
        Me.tbPHIF_Address.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 54)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 17)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Адрес на ДДЗО:"
        '
        'gbRZOK
        '
        Me.gbRZOK.Controls.Add(Me.tbRegRHIF_Address)
        Me.gbRZOK.Controls.Add(Me.Label12)
        Me.gbRZOK.Controls.Add(Me.Label15)
        Me.gbRZOK.Controls.Add(Me.cbRegHIF)
        Me.gbRZOK.Enabled = False
        Me.gbRZOK.Location = New System.Drawing.Point(13, 226)
        Me.gbRZOK.Margin = New System.Windows.Forms.Padding(4)
        Me.gbRZOK.Name = "gbRZOK"
        Me.gbRZOK.Padding = New System.Windows.Forms.Padding(4)
        Me.gbRZOK.Size = New System.Drawing.Size(723, 86)
        Me.gbRZOK.TabIndex = 20
        Me.gbRZOK.TabStop = False
        Me.gbRZOK.Text = "РЗОК"
        '
        'tbRegRHIF_Address
        '
        Me.tbRegRHIF_Address.Location = New System.Drawing.Point(133, 57)
        Me.tbRegRHIF_Address.Margin = New System.Windows.Forms.Padding(4)
        Me.tbRegRHIF_Address.Name = "tbRegRHIF_Address"
        Me.tbRegRHIF_Address.Size = New System.Drawing.Size(563, 22)
        Me.tbRegRHIF_Address.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(73, 27)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 17)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "РЗОК:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 62)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 17)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Адрес на РЗОК:"
        '
        'cbRegHIF
        '
        Me.cbRegHIF.FormattingEnabled = True
        Me.cbRegHIF.Items.AddRange(New Object() {"Благоевград", "Бургас", "Варна", "Велико Търново", "Видин", "Враца", "Габрово", "Добрич", "Кърджали", "Кюстендил", "Ловеч", "Монтана", "Пазарджик", "Перник", "Плевен", "Пловдив", "Разград", "Русе", "Силистра", "Сливен", "Смолян", "София", "София (столица)", "Стара Загора", "Търговище", "Хасково", "Шумен", "Ямбол"})
        Me.cbRegHIF.Location = New System.Drawing.Point(133, 22)
        Me.cbRegHIF.Margin = New System.Windows.Forms.Padding(4)
        Me.cbRegHIF.Name = "cbRegHIF"
        Me.cbRegHIF.Size = New System.Drawing.Size(231, 24)
        Me.cbRegHIF.TabIndex = 11
        '
        'btnObjectsListEdit
        '
        Me.btnObjectsListEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnObjectsListEdit.Location = New System.Drawing.Point(11, 85)
        Me.btnObjectsListEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnObjectsListEdit.Name = "btnObjectsListEdit"
        Me.btnObjectsListEdit.Size = New System.Drawing.Size(153, 47)
        Me.btnObjectsListEdit.TabIndex = 19
        Me.btnObjectsListEdit.Text = "Редакция на списъка"
        Me.btnObjectsListEdit.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(396, 204)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "ЕИК по БУЛСТАТ:"
        '
        'tbObjectID
        '
        Me.tbObjectID.Location = New System.Drawing.Point(539, 201)
        Me.tbObjectID.Margin = New System.Windows.Forms.Padding(4)
        Me.tbObjectID.Name = "tbObjectID"
        Me.tbObjectID.Size = New System.Drawing.Size(196, 22)
        Me.tbObjectID.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 172)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Адрес на обекта:"
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(172, 167)
        Me.tbAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(564, 22)
        Me.tbAddress.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 42)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Обект на проверката:"
        '
        'lbAuditObject
        '
        Me.lbAuditObject.FormattingEnabled = True
        Me.lbAuditObject.ItemHeight = 16
        Me.lbAuditObject.Location = New System.Drawing.Point(172, 42)
        Me.lbAuditObject.Margin = New System.Windows.Forms.Padding(4)
        Me.lbAuditObject.Name = "lbAuditObject"
        Me.lbAuditObject.Size = New System.Drawing.Size(564, 116)
        Me.lbAuditObject.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(468, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Област:"
        '
        'cbDomain
        '
        Me.cbDomain.FormattingEnabled = True
        Me.cbDomain.Location = New System.Drawing.Point(539, 7)
        Me.cbDomain.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDomain.Name = "cbDomain"
        Me.cbDomain.Size = New System.Drawing.Size(197, 24)
        Me.cbDomain.TabIndex = 3
        '
        'cbPlace
        '
        Me.cbPlace.FormattingEnabled = True
        Me.cbPlace.Location = New System.Drawing.Point(172, 7)
        Me.cbPlace.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPlace.Name = "cbPlace"
        Me.cbPlace.Size = New System.Drawing.Size(271, 24)
        Me.cbPlace.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 12)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Населено място:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cbMainSign)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.lbApproving)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.lbTeamMembers)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.cbHeadName)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1022, 413)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Екип"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cbMainSign
        '
        Me.cbMainSign.AutoSize = True
        Me.cbMainSign.Location = New System.Drawing.Point(189, 369)
        Me.cbMainSign.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMainSign.Name = "cbMainSign"
        Me.cbMainSign.Size = New System.Drawing.Size(322, 21)
        Me.cbMainSign.TabIndex = 6
        Me.cbMainSign.Text = "Ще се подпише от Зам.Директора на ИАМО"
        Me.cbMainSign.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(32, 245)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(139, 17)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Ще се съгласува от:"
        '
        'lbApproving
        '
        Me.lbApproving.FormattingEnabled = True
        Me.lbApproving.ItemHeight = 16
        Me.lbApproving.Location = New System.Drawing.Point(189, 245)
        Me.lbApproving.Margin = New System.Windows.Forms.Padding(4)
        Me.lbApproving.Name = "lbApproving"
        Me.lbApproving.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbApproving.Size = New System.Drawing.Size(529, 116)
        Me.lbApproving.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 55)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(163, 17)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Членове на комисията:"
        '
        'lbTeamMembers
        '
        Me.lbTeamMembers.FormattingEnabled = True
        Me.lbTeamMembers.ItemHeight = 16
        Me.lbTeamMembers.Location = New System.Drawing.Point(189, 55)
        Me.lbTeamMembers.Margin = New System.Windows.Forms.Padding(4)
        Me.lbTeamMembers.Name = "lbTeamMembers"
        Me.lbTeamMembers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbTeamMembers.Size = New System.Drawing.Size(529, 180)
        Me.lbTeamMembers.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(77, 12)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 17)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Председател:"
        '
        'cbHeadName
        '
        Me.cbHeadName.FormattingEnabled = True
        Me.cbHeadName.Location = New System.Drawing.Point(189, 7)
        Me.cbHeadName.Margin = New System.Windows.Forms.Padding(4)
        Me.cbHeadName.Name = "cbHeadName"
        Me.cbHeadName.Size = New System.Drawing.Size(529, 24)
        Me.cbHeadName.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.chkB_StandardsFullSet)
        Me.TabPage4.Controls.Add(Me.lbStandards)
        Me.TabPage4.Controls.Add(Me.Label21)
        Me.TabPage4.Controls.Add(Me.tbCountSelectedStandards)
        Me.TabPage4.Controls.Add(Me.btnClear)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Enabled = False
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1022, 413)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Стандарти"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'chkB_StandardsFullSet
        '
        Me.chkB_StandardsFullSet.AutoSize = True
        Me.chkB_StandardsFullSet.BackColor = System.Drawing.Color.Red
        Me.chkB_StandardsFullSet.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkB_StandardsFullSet.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkB_StandardsFullSet.Location = New System.Drawing.Point(160, 373)
        Me.chkB_StandardsFullSet.Margin = New System.Windows.Forms.Padding(4)
        Me.chkB_StandardsFullSet.Name = "chkB_StandardsFullSet"
        Me.chkB_StandardsFullSet.Size = New System.Drawing.Size(359, 21)
        Me.chkB_StandardsFullSet.TabIndex = 8
        Me.chkB_StandardsFullSet.Text = "Всички стандарти съгласно регистрацията на ЛЗ"
        Me.chkB_StandardsFullSet.UseVisualStyleBackColor = False
        '
        'lbStandards
        '
        Me.lbStandards.FormattingEnabled = True
        Me.lbStandards.ItemHeight = 16
        Me.lbStandards.Items.AddRange(New Object() {"АКУШЕРСТВО И ГИНЕКОЛОГИЯ", "АНЕСТЕЗИЯ И ИНТЕНЗИВНО ЛЕЧЕНИЕ", "АСИСТИРАНА РЕПРОДУКЦИЯ", "ВИРУСОЛОГИЯ", "ВЪТРЕШНИ БОЛЕСТИ", "ГАСТРОЕНТЕРОЛОГИЯ", "ГРЪДНА ХИРУРГИЯ", "ДЕТСКА ДЕНТАЛНА МЕДИЦИНА", "ДИАЛИЗНО ЛЕЧЕНИЕ", "ЕНДОКРИНОЛОГИЯ И БОЛЕСТИ НА ОБМЯНАТА", "ИМУНОЛОГИЧНА ПОДГОТОВКА ПРИ ТРАНСПЛАНТАЦИЯ НА ОРГАНИ, ТЪКАНИ И КЛЕТКИ", "ИНФЕКЦИОЗНИ БОЛЕСТИ", "КАРДИОЛОГИЯ", "КАРДИОХИРУРГИЯ", "КЛИНИЧНА АЛЕРГОЛОГИЯ", "КЛИНИЧНА ИМУНОЛОГИЯ", "КЛИНИЧНА ЛАБОРАТОРИЯ", "КЛИНИЧНА ПАТОЛОГИЯ", "КЛИНИЧНА ТОКСИКОЛОГИЯ", "КЛИНИЧНА ХЕМАТОЛОГИЯ", "КОЖНИ И ВЕНЕРИЧЕСКИ БОЛЕСТИ", "ЛИЦЕВО-ЧЕЛЮСТНА ХИРУРГИЯ", "ЛЪЧЕЛЕЧЕНИЕ", "МЕДИКО-ТЕХНИЧЕСКИ СТАНДАРТ ПО ЗЪБОТЕХНИКА", "МЕДИЦИНСКА ГЕНЕТИКА", "МЕДИЦИНСКА ОНКОЛОГИЯ", "МЕДИЦИНСКА ПАРАЗИТОЛОГИЯ", "МИКРОБИОЛОГИЯ", "НЕВРОХИРУРГИЯ", "НЕОНАТОЛОГИЯ", "НЕРВНИ БОЛЕСТИ", "НЕФРОЛОГИЯ", "НУКЛЕАРНА МЕДИЦИНА", "ОБРАЗНА ДИАГНОСТИКА", "ОБЩА МЕДИЦИНСКА ПРАКТИКА", "ОБЩИ МЕДИЦИНСКИ СТАНДАРТИ ПО ХИРУРГИЯ", "ОРАЛНА ХИРУРГИЯ", "ОРТОДОНТИЯ", "ОРТОПЕДИЯ И ТРАВМАТОЛОГИЯ", "ОЧНИ БОЛЕСТИ", "ПЕДИАТРИЯ", "ПЛАСТИЧНО-ВЪЗСТАНОВИТЕЛНА И ЕСТЕТИЧНА ХИРУРГИЯ", "ПНЕВМОЛОГИЯ И ФТИЗИАТРИЯ", "ПРЕВЕНЦИЯ И КОНТРОЛ НА ВЪТРЕБОЛНИЧНИТЕ ИНФЕКЦИИ", "ПРОФЕСИОНАЛНИ БОЛЕСТИ", "ПСИХИАТРИЯ", "РЕВМАТОЛОГИЯ", "СПЕШНА МЕДИЦИНА", "ТРАНСФУЗИОННА ХЕМАТОЛОГИЯ", "УРОЛОГИЯ", "УШНО-НОСНО-ГЪРЛЕНИ БОЛЕСТИ", "ФИЗИКАЛНА И РЕХАБИЛИТАЦИОННА МЕДИЦИНА"})
        Me.lbStandards.Location = New System.Drawing.Point(160, 17)
        Me.lbStandards.Margin = New System.Windows.Forms.Padding(4)
        Me.lbStandards.Name = "lbStandards"
        Me.lbStandards.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbStandards.Size = New System.Drawing.Size(576, 340)
        Me.lbStandards.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 52)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(103, 17)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "брой избрани:"
        '
        'tbCountSelectedStandards
        '
        Me.tbCountSelectedStandards.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbCountSelectedStandards.ForeColor = System.Drawing.Color.Red
        Me.tbCountSelectedStandards.Location = New System.Drawing.Point(13, 75)
        Me.tbCountSelectedStandards.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCountSelectedStandards.Name = "tbCountSelectedStandards"
        Me.tbCountSelectedStandards.Size = New System.Drawing.Size(104, 22)
        Me.tbCountSelectedStandards.TabIndex = 5
        Me.tbCountSelectedStandards.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(13, 129)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 28)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Изчистване"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(13, 17)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(133, 17)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Списък стандарти:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.grbLetters)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.tbComplaintsList)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1022, 413)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Жалби и писма"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'grbLetters
        '
        Me.grbLetters.Controls.Add(Me.Label23)
        Me.grbLetters.Controls.Add(Me.Label22)
        Me.grbLetters.Controls.Add(Me.cbAuthority4)
        Me.grbLetters.Controls.Add(Me.tbLetter4)
        Me.grbLetters.Controls.Add(Me.cbAuthority3)
        Me.grbLetters.Controls.Add(Me.tbLetter3)
        Me.grbLetters.Controls.Add(Me.cbAuthority2)
        Me.grbLetters.Controls.Add(Me.tbLetter2)
        Me.grbLetters.Controls.Add(Me.cbAuthority1)
        Me.grbLetters.Controls.Add(Me.tbLetter1)
        Me.grbLetters.Enabled = False
        Me.grbLetters.Location = New System.Drawing.Point(15, 65)
        Me.grbLetters.Margin = New System.Windows.Forms.Padding(4)
        Me.grbLetters.Name = "grbLetters"
        Me.grbLetters.Padding = New System.Windows.Forms.Padding(4)
        Me.grbLetters.Size = New System.Drawing.Size(723, 303)
        Me.grbLetters.TabIndex = 2
        Me.grbLetters.TabStop = False
        Me.grbLetters.Text = "Списък на свързани със случая писма от институции:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(294, 55)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(215, 17)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "наименование на институцята:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 55)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 17)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "вх. №/дата:"
        '
        'cbAuthority4
        '
        Me.cbAuthority4.FormattingEnabled = True
        Me.cbAuthority4.Location = New System.Drawing.Point(294, 260)
        Me.cbAuthority4.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAuthority4.Name = "cbAuthority4"
        Me.cbAuthority4.Size = New System.Drawing.Size(392, 24)
        Me.cbAuthority4.TabIndex = 7
        '
        'tbLetter4
        '
        Me.tbLetter4.Location = New System.Drawing.Point(8, 261)
        Me.tbLetter4.Margin = New System.Windows.Forms.Padding(4)
        Me.tbLetter4.Name = "tbLetter4"
        Me.tbLetter4.Size = New System.Drawing.Size(268, 22)
        Me.tbLetter4.TabIndex = 6
        '
        'cbAuthority3
        '
        Me.cbAuthority3.FormattingEnabled = True
        Me.cbAuthority3.Location = New System.Drawing.Point(294, 204)
        Me.cbAuthority3.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAuthority3.Name = "cbAuthority3"
        Me.cbAuthority3.Size = New System.Drawing.Size(392, 24)
        Me.cbAuthority3.TabIndex = 5
        '
        'tbLetter3
        '
        Me.tbLetter3.Location = New System.Drawing.Point(8, 205)
        Me.tbLetter3.Margin = New System.Windows.Forms.Padding(4)
        Me.tbLetter3.Name = "tbLetter3"
        Me.tbLetter3.Size = New System.Drawing.Size(268, 22)
        Me.tbLetter3.TabIndex = 4
        '
        'cbAuthority2
        '
        Me.cbAuthority2.FormattingEnabled = True
        Me.cbAuthority2.Location = New System.Drawing.Point(294, 148)
        Me.cbAuthority2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAuthority2.Name = "cbAuthority2"
        Me.cbAuthority2.Size = New System.Drawing.Size(392, 24)
        Me.cbAuthority2.TabIndex = 3
        '
        'tbLetter2
        '
        Me.tbLetter2.Location = New System.Drawing.Point(8, 149)
        Me.tbLetter2.Margin = New System.Windows.Forms.Padding(4)
        Me.tbLetter2.Name = "tbLetter2"
        Me.tbLetter2.Size = New System.Drawing.Size(268, 22)
        Me.tbLetter2.TabIndex = 2
        '
        'cbAuthority1
        '
        Me.cbAuthority1.FormattingEnabled = True
        Me.cbAuthority1.Location = New System.Drawing.Point(294, 92)
        Me.cbAuthority1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAuthority1.Name = "cbAuthority1"
        Me.cbAuthority1.Size = New System.Drawing.Size(392, 24)
        Me.cbAuthority1.TabIndex = 1
        '
        'tbLetter1
        '
        Me.tbLetter1.Location = New System.Drawing.Point(8, 93)
        Me.tbLetter1.Margin = New System.Windows.Forms.Padding(4)
        Me.tbLetter1.Name = "tbLetter1"
        Me.tbLetter1.Size = New System.Drawing.Size(268, 22)
        Me.tbLetter1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(15, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Списък на жалбите свързани със случая:"
        '
        'tbComplaintsList
        '
        Me.tbComplaintsList.AllowDrop = True
        Me.tbComplaintsList.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbComplaintsList.Enabled = False
        Me.tbComplaintsList.Location = New System.Drawing.Point(15, 33)
        Me.tbComplaintsList.Margin = New System.Windows.Forms.Padding(4)
        Me.tbComplaintsList.Name = "tbComplaintsList"
        Me.tbComplaintsList.Size = New System.Drawing.Size(721, 22)
        Me.tbComplaintsList.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(139, 448)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOK.Location = New System.Drawing.Point(3, 448)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 28)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1043, 481)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Изготвяне на текст на заповед за проверка"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.nlTasksCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gbDZOF.ResumeLayout(False)
        Me.gbDZOF.PerformLayout()
        Me.gbRZOK.ResumeLayout(False)
        Me.gbRZOK.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.grbLetters.ResumeLayout(False)
        Me.grbLetters.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkListBoxReason As CheckedListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents clbMode As CheckedListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents cbPlace As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbDomain As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbAuditObject As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbObjectID As TextBox
    Friend WithEvents cbScope As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tbPHIF_Address As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbPHIF As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbRegRHIF_Address As TextBox
    Friend WithEvents cbRegHIF As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lbTeamMembers As ListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbHeadName As ComboBox
    Friend WithEvents btnTasksListEdit As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents nlTasksCount As NumericUpDown
    Friend WithEvents btnObjectsListEdit As Button
    Friend WithEvents cbMainSign As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents lbApproving As ListBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents tbCountSelectedStandards As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lbStandards As ListBox
    Friend WithEvents chkB_StandardsFullSet As CheckBox
    Friend WithEvents gbDZOF As GroupBox
    Friend WithEvents gbRZOK As GroupBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents tbComplaintsList As TextBox
    Friend WithEvents grbLetters As GroupBox
    Friend WithEvents cbAuthority4 As ComboBox
    Friend WithEvents tbLetter4 As TextBox
    Friend WithEvents cbAuthority3 As ComboBox
    Friend WithEvents tbLetter3 As TextBox
    Friend WithEvents cbAuthority2 As ComboBox
    Friend WithEvents tbLetter2 As TextBox
    Friend WithEvents cbAuthority1 As ComboBox
    Friend WithEvents tbLetter1 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents chbCorruption As CheckBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TreeViewReasons As TreeView
End Class
