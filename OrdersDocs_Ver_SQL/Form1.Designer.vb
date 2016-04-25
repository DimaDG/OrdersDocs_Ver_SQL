<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkListBoxReason = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TreeViewReasons = New System.Windows.Forms.TreeView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkListBoxScope = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-2, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(699, 351)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.chkListBoxScope)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TreeViewReasons)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.chkListBoxReason)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(691, 325)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Заповед"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(691, 307)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(616, 356)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOK.Location = New System.Drawing.Point(13, 356)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
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
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(37, 50)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "до:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 85)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "период на проверката:"
        '
        'chkListBoxReason
        '
        Me.chkListBoxReason.FormattingEnabled = True
        Me.chkListBoxReason.Items.AddRange(New Object() {"Проверка по жалба(и)", "Проверка по писмо(а)", "Структура, организация и дейност", "Проверка по медицински стандарти", "По Наредба за достъп /НОПДМП/", "По Наредба №34", "Проверка на РЗОК", "Проверка на НЗОК(цу)", "ДЗОД"})
        Me.chkListBoxReason.Location = New System.Drawing.Point(8, 114)
        Me.chkListBoxReason.Name = "chkListBoxReason"
        Me.chkListBoxReason.Size = New System.Drawing.Size(224, 139)
        Me.chkListBoxReason.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Вид:"
        '
        'TreeViewReasons
        '
        Me.TreeViewReasons.Location = New System.Drawing.Point(501, 23)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(503, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Основание:"
        '
        'chkListBoxScope
        '
        Me.chkListBoxScope.FormattingEnabled = True
        Me.chkListBoxScope.Items.AddRange(New Object() {"на място в ЛЗ", "по документи"})
        Me.chkListBoxScope.Location = New System.Drawing.Point(261, 114)
        Me.chkListBoxScope.Name = "chkListBoxScope"
        Me.chkListBoxScope.Size = New System.Drawing.Size(228, 34)
        Me.chkListBoxScope.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(261, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Обхват:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(697, 391)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Изготвяне на текста на заповед за проверка"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents chkListBoxScope As CheckedListBox
End Class
