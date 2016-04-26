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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("частична")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("пълна")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Планова", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("по случай (казус)")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("частична")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("пълна")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("тематична", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("самосезиране", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("по случай (казус)")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("частична")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("пълна")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("тематична", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("по сигнал", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Извънредна", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("планова")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("извънредна")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Повторна", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16})
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnTasksListEdit = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.nlTasksCount = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbScope = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clbMode = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TreeViewReasons = New System.Windows.Forms.TreeView()
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
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(-2, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(569, 359)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnTasksListEdit)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.nlTasksCount)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.cbScope)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.clbMode)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TreeViewReasons)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.chkListBoxReason)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(561, 333)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Заповед"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnTasksListEdit
        '
        Me.btnTasksListEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTasksListEdit.Location = New System.Drawing.Point(238, 216)
        Me.btnTasksListEdit.Name = "btnTasksListEdit"
        Me.btnTasksListEdit.Size = New System.Drawing.Size(134, 23)
        Me.btnTasksListEdit.TabIndex = 15
        Me.btnTasksListEdit.Text = "Списък на задачите"
        Me.btnTasksListEdit.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(238, 171)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(138, 13)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Брой задачи в заповедта:"
        '
        'nlTasksCount
        '
        Me.nlTasksCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nlTasksCount.Location = New System.Drawing.Point(238, 190)
        Me.nlTasksCount.Name = "nlTasksCount"
        Me.nlTasksCount.Size = New System.Drawing.Size(134, 20)
        Me.nlTasksCount.TabIndex = 13
        Me.nlTasksCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nlTasksCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 260)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Обхват:"
        '
        'cbScope
        '
        Me.cbScope.FormattingEnabled = True
        Me.cbScope.Items.AddRange(New Object() {"само едно ЛЗ", "няколко ЛЗ (проследяване на случай)"})
        Me.cbScope.Location = New System.Drawing.Point(8, 279)
        Me.cbScope.Name = "cbScope"
        Me.cbScope.Size = New System.Drawing.Size(224, 21)
        Me.cbScope.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Начин на проверката:"
        '
        'clbMode
        '
        Me.clbMode.CheckOnClick = True
        Me.clbMode.FormattingEnabled = True
        Me.clbMode.Items.AddRange(New Object() {"на място в ЛЗ", "по документи"})
        Me.clbMode.Location = New System.Drawing.Point(238, 114)
        Me.clbMode.Name = "clbMode"
        Me.clbMode.Size = New System.Drawing.Size(138, 34)
        Me.clbMode.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(379, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Основание:"
        '
        'TreeViewReasons
        '
        Me.TreeViewReasons.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeViewReasons.CheckBoxes = True
        Me.TreeViewReasons.Location = New System.Drawing.Point(382, 20)
        Me.TreeViewReasons.Name = "TreeViewReasons"
        TreeNode1.ForeColor = System.Drawing.Color.Red
        TreeNode1.Name = "Node3"
        TreeNode1.Text = "частична"
        TreeNode2.ForeColor = System.Drawing.Color.Red
        TreeNode2.Name = "Node5"
        TreeNode2.Text = "пълна"
        TreeNode3.ForeColor = System.Drawing.Color.Blue
        TreeNode3.Name = "Node0"
        TreeNode3.Text = "Планова"
        TreeNode4.ForeColor = System.Drawing.Color.Red
        TreeNode4.Name = "Node8"
        TreeNode4.Text = "по случай (казус)"
        TreeNode5.ForeColor = System.Drawing.Color.Red
        TreeNode5.Name = "Node10"
        TreeNode5.Text = "частична"
        TreeNode6.ForeColor = System.Drawing.Color.Red
        TreeNode6.Name = "Node11"
        TreeNode6.Text = "пълна"
        TreeNode7.ForeColor = System.Drawing.Color.Black
        TreeNode7.Name = "Node9"
        TreeNode7.Text = "тематична"
        TreeNode8.Name = "Node6"
        TreeNode8.Text = "самосезиране"
        TreeNode9.ForeColor = System.Drawing.Color.Red
        TreeNode9.Name = "Node12"
        TreeNode9.Text = "по случай (казус)"
        TreeNode10.ForeColor = System.Drawing.Color.Red
        TreeNode10.Name = "Node14"
        TreeNode10.Text = "частична"
        TreeNode11.ForeColor = System.Drawing.Color.Red
        TreeNode11.Name = "Node15"
        TreeNode11.Text = "пълна"
        TreeNode12.Name = "Node13"
        TreeNode12.Text = "тематична"
        TreeNode13.Name = "Node7"
        TreeNode13.Text = "по сигнал"
        TreeNode14.ForeColor = System.Drawing.Color.Blue
        TreeNode14.Name = "Node1"
        TreeNode14.Text = "Извънредна"
        TreeNode15.ForeColor = System.Drawing.Color.Red
        TreeNode15.Name = "Node16"
        TreeNode15.Text = "планова"
        TreeNode16.ForeColor = System.Drawing.Color.Red
        TreeNode16.Name = "Node17"
        TreeNode16.Text = "извънредна"
        TreeNode17.ForeColor = System.Drawing.Color.Blue
        TreeNode17.Name = "Node2"
        TreeNode17.Text = "Повторна"
        Me.TreeViewReasons.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode14, TreeNode17})
        Me.TreeViewReasons.ShowNodeToolTips = True
        Me.TreeViewReasons.Size = New System.Drawing.Size(172, 280)
        Me.TreeViewReasons.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Вид:"
        '
        'chkListBoxReason
        '
        Me.chkListBoxReason.CheckOnClick = True
        Me.chkListBoxReason.FormattingEnabled = True
        Me.chkListBoxReason.Items.AddRange(New Object() {"Проверка по жалба(и)", "Проверка по писмо(а)", "Структура, организация и дейност", "Проверка по медицински стандарти", "По Наредба за достъп /НОПДМП/", "По Наредба №34", "Проверка на РЗОК", "Проверка на НЗОК(цу)", "ДДЗО"})
        Me.chkListBoxReason.Location = New System.Drawing.Point(8, 114)
        Me.chkListBoxReason.Name = "chkListBoxReason"
        Me.chkListBoxReason.Size = New System.Drawing.Size(224, 139)
        Me.chkListBoxReason.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 85)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "период на проверката:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(37, 58)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "до:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(37, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(561, 333)
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
        Me.gbDZOF.Location = New System.Drawing.Point(10, 260)
        Me.gbDZOF.Name = "gbDZOF"
        Me.gbDZOF.Size = New System.Drawing.Size(528, 64)
        Me.gbDZOF.TabIndex = 21
        Me.gbDZOF.TabStop = False
        Me.gbDZOF.Text = "ДЗО"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Дружество за ДЗО:"
        '
        'cbPHIF
        '
        Me.cbPHIF.FormattingEnabled = True
        Me.cbPHIF.Location = New System.Drawing.Point(121, 12)
        Me.cbPHIF.Name = "cbPHIF"
        Me.cbPHIF.Size = New System.Drawing.Size(402, 21)
        Me.cbPHIF.TabIndex = 13
        '
        'tbPHIF_Address
        '
        Me.tbPHIF_Address.Location = New System.Drawing.Point(121, 40)
        Me.tbPHIF_Address.Name = "tbPHIF_Address"
        Me.tbPHIF_Address.Size = New System.Drawing.Size(402, 20)
        Me.tbPHIF_Address.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 13)
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
        Me.gbRZOK.Location = New System.Drawing.Point(10, 184)
        Me.gbRZOK.Name = "gbRZOK"
        Me.gbRZOK.Size = New System.Drawing.Size(528, 70)
        Me.gbRZOK.TabIndex = 20
        Me.gbRZOK.TabStop = False
        Me.gbRZOK.Text = "РЗОК"
        '
        'tbRegRHIF_Address
        '
        Me.tbRegRHIF_Address.Location = New System.Drawing.Point(100, 46)
        Me.tbRegRHIF_Address.Name = "tbRegRHIF_Address"
        Me.tbRegRHIF_Address.Size = New System.Drawing.Size(423, 20)
        Me.tbRegRHIF_Address.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(55, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "РЗОК:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Адрес на РЗОК:"
        '
        'cbRegHIF
        '
        Me.cbRegHIF.FormattingEnabled = True
        Me.cbRegHIF.Items.AddRange(New Object() {"Благоевград", "Бургас", "Варна", "Велико Търново", "Видин", "Враца", "Габрово", "Добрич", "Кърджали", "Кюстендил", "Ловеч", "Монтана", "Пазарджик", "Перник", "Плевен", "Пловдив", "Разград", "Русе", "Силистра", "Сливен", "Смолян", "София", "София (столица)", "Стара Загора", "Търговище", "Хасково", "Шумен", "Ямбол"})
        Me.cbRegHIF.Location = New System.Drawing.Point(100, 18)
        Me.cbRegHIF.Name = "cbRegHIF"
        Me.cbRegHIF.Size = New System.Drawing.Size(174, 21)
        Me.cbRegHIF.TabIndex = 11
        '
        'btnObjectsListEdit
        '
        Me.btnObjectsListEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnObjectsListEdit.Location = New System.Drawing.Point(8, 69)
        Me.btnObjectsListEdit.Name = "btnObjectsListEdit"
        Me.btnObjectsListEdit.Size = New System.Drawing.Size(115, 38)
        Me.btnObjectsListEdit.TabIndex = 19
        Me.btnObjectsListEdit.Text = "Редакция на списъка"
        Me.btnObjectsListEdit.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(297, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "ЕИК по БУЛСТАТ:"
        '
        'tbObjectID
        '
        Me.tbObjectID.Location = New System.Drawing.Point(404, 163)
        Me.tbObjectID.Name = "tbObjectID"
        Me.tbObjectID.Size = New System.Drawing.Size(148, 20)
        Me.tbObjectID.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Адрес на обекта:"
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(129, 136)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(424, 20)
        Me.tbAddress.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Обект на проверката:"
        '
        'lbAuditObject
        '
        Me.lbAuditObject.FormattingEnabled = True
        Me.lbAuditObject.Location = New System.Drawing.Point(129, 34)
        Me.lbAuditObject.Name = "lbAuditObject"
        Me.lbAuditObject.Size = New System.Drawing.Size(424, 95)
        Me.lbAuditObject.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(351, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Област:"
        '
        'cbDomain
        '
        Me.cbDomain.FormattingEnabled = True
        Me.cbDomain.Location = New System.Drawing.Point(404, 6)
        Me.cbDomain.Name = "cbDomain"
        Me.cbDomain.Size = New System.Drawing.Size(149, 21)
        Me.cbDomain.TabIndex = 3
        '
        'cbPlace
        '
        Me.cbPlace.FormattingEnabled = True
        Me.cbPlace.Location = New System.Drawing.Point(129, 6)
        Me.cbPlace.Name = "cbPlace"
        Me.cbPlace.Size = New System.Drawing.Size(204, 21)
        Me.cbPlace.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
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
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(561, 333)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Екип"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cbMainSign
        '
        Me.cbMainSign.AutoSize = True
        Me.cbMainSign.Location = New System.Drawing.Point(142, 300)
        Me.cbMainSign.Name = "cbMainSign"
        Me.cbMainSign.Size = New System.Drawing.Size(251, 17)
        Me.cbMainSign.TabIndex = 6
        Me.cbMainSign.Text = "Ще се подпише от Зам.Директора на ИАМО"
        Me.cbMainSign.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(24, 199)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Ще се съгласува от:"
        '
        'lbApproving
        '
        Me.lbApproving.FormattingEnabled = True
        Me.lbApproving.Location = New System.Drawing.Point(142, 199)
        Me.lbApproving.Name = "lbApproving"
        Me.lbApproving.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbApproving.Size = New System.Drawing.Size(347, 95)
        Me.lbApproving.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Членове на комисията:"
        '
        'lbTeamMembers
        '
        Me.lbTeamMembers.FormattingEnabled = True
        Me.lbTeamMembers.Location = New System.Drawing.Point(142, 45)
        Me.lbTeamMembers.Name = "lbTeamMembers"
        Me.lbTeamMembers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbTeamMembers.Size = New System.Drawing.Size(347, 147)
        Me.lbTeamMembers.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(58, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Председател:"
        '
        'cbHeadName
        '
        Me.cbHeadName.FormattingEnabled = True
        Me.cbHeadName.Location = New System.Drawing.Point(142, 6)
        Me.cbHeadName.Name = "cbHeadName"
        Me.cbHeadName.Size = New System.Drawing.Size(347, 21)
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
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(561, 333)
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
        Me.chkB_StandardsFullSet.Location = New System.Drawing.Point(13, 297)
        Me.chkB_StandardsFullSet.Name = "chkB_StandardsFullSet"
        Me.chkB_StandardsFullSet.Size = New System.Drawing.Size(279, 17)
        Me.chkB_StandardsFullSet.TabIndex = 8
        Me.chkB_StandardsFullSet.Text = "Всички стандарти съгласно регистрацията на ЛЗ"
        Me.chkB_StandardsFullSet.UseVisualStyleBackColor = False
        '
        'lbStandards
        '
        Me.lbStandards.FormattingEnabled = True
        Me.lbStandards.Items.AddRange(New Object() {"АКУШЕРСТВО И ГИНЕКОЛОГИЯ", "АНЕСТЕЗИЯ И ИНТЕНЗИВНО ЛЕЧЕНИЕ", "АСИСТИРАНА РЕПРОДУКЦИЯ", "ВИРУСОЛОГИЯ", "ВЪТРЕШНИ БОЛЕСТИ", "ГАСТРОЕНТЕРОЛОГИЯ", "ГРЪДНА ХИРУРГИЯ", "ДЕТСКА ДЕНТАЛНА МЕДИЦИНА", "ДИАЛИЗНО ЛЕЧЕНИЕ", "ЕНДОКРИНОЛОГИЯ И БОЛЕСТИ НА ОБМЯНАТА", "ИМУНОЛОГИЧНА ПОДГОТОВКА ПРИ ТРАНСПЛАНТАЦИЯ НА ОРГАНИ, ТЪКАНИ И КЛЕТКИ", "ИНФЕКЦИОЗНИ БОЛЕСТИ", "КАРДИОЛОГИЯ", "КАРДИОХИРУРГИЯ", "КЛИНИЧНА АЛЕРГОЛОГИЯ", "КЛИНИЧНА ИМУНОЛОГИЯ", "КЛИНИЧНА ЛАБОРАТОРИЯ", "КЛИНИЧНА ПАТОЛОГИЯ", "КЛИНИЧНА ТОКСИКОЛОГИЯ", "КЛИНИЧНА ХЕМАТОЛОГИЯ", "КОЖНИ И ВЕНЕРИЧЕСКИ БОЛЕСТИ", "ЛИЦЕВО-ЧЕЛЮСТНА ХИРУРГИЯ", "ЛЪЧЕЛЕЧЕНИЕ", "МЕДИКО-ТЕХНИЧЕСКИ СТАНДАРТ ПО ЗЪБОТЕХНИКА", "МЕДИЦИНСКА ГЕНЕТИКА", "МЕДИЦИНСКА ОНКОЛОГИЯ", "МЕДИЦИНСКА ПАРАЗИТОЛОГИЯ", "МИКРОБИОЛОГИЯ", "НЕВРОХИРУРГИЯ", "НЕОНАТОЛОГИЯ", "НЕРВНИ БОЛЕСТИ", "НЕФРОЛОГИЯ", "НУКЛЕАРНА МЕДИЦИНА", "ОБРАЗНА ДИАГНОСТИКА", "ОБЩА МЕДИЦИНСКА ПРАКТИКА", "ОБЩИ МЕДИЦИНСКИ СТАНДАРТИ ПО ХИРУРГИЯ", "ОРАЛНА ХИРУРГИЯ", "ОРТОДОНТИЯ", "ОРТОПЕДИЯ И ТРАВМАТОЛОГИЯ", "ОЧНИ БОЛЕСТИ", "ПЕДИАТРИЯ", "ПЛАСТИЧНО-ВЪЗСТАНОВИТЕЛНА И ЕСТЕТИЧНА ХИРУРГИЯ", "ПНЕВМОЛОГИЯ И ФТИЗИАТРИЯ", "ПРЕВЕНЦИЯ И КОНТРОЛ НА ВЪТРЕБОЛНИЧНИТЕ ИНФЕКЦИИ", "ПРОФЕСИОНАЛНИ БОЛЕСТИ", "ПСИХИАТРИЯ", "РЕВМАТОЛОГИЯ", "СПЕШНА МЕДИЦИНА", "ТРАНСФУЗИОННА ХЕМАТОЛОГИЯ", "УРОЛОГИЯ", "УШНО-НОСНО-ГЪРЛЕНИ БОЛЕСТИ", "ФИЗИКАЛНА И РЕХАБИЛИТАЦИОННА МЕДИЦИНА"})
        Me.lbStandards.Location = New System.Drawing.Point(120, 14)
        Me.lbStandards.Name = "lbStandards"
        Me.lbStandards.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbStandards.Size = New System.Drawing.Size(433, 277)
        Me.lbStandards.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(10, 42)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 13)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "брой избрани:"
        '
        'tbCountSelectedStandards
        '
        Me.tbCountSelectedStandards.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbCountSelectedStandards.ForeColor = System.Drawing.Color.Red
        Me.tbCountSelectedStandards.Location = New System.Drawing.Point(10, 61)
        Me.tbCountSelectedStandards.Name = "tbCountSelectedStandards"
        Me.tbCountSelectedStandards.Size = New System.Drawing.Size(79, 20)
        Me.tbCountSelectedStandards.TabIndex = 5
        Me.tbCountSelectedStandards.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(10, 105)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Изчистване"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 14)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Списък стандарти:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(488, 364)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOK.Location = New System.Drawing.Point(2, 364)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(567, 391)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.TabControl1)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents TreeViewReasons As TreeView
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
End Class
