<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAuditTasksList
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TreeViewReasons = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tblPannel = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(541, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Основание (причина) за проверката:"
        '
        'TreeViewReasons
        '
        Me.TreeViewReasons.BackColor = System.Drawing.SystemColors.Control
        Me.TreeViewReasons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeViewReasons.Location = New System.Drawing.Point(544, 26)
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
        Me.TreeViewReasons.Size = New System.Drawing.Size(190, 280)
        Me.TreeViewReasons.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Списък на задачите:"
        '
        'tblPannel
        '
        Me.tblPannel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tblPannel.ColumnCount = 3
        Me.tblPannel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblPannel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tblPannel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tblPannel.Location = New System.Drawing.Point(15, 26)
        Me.tblPannel.Name = "tblPannel"
        Me.tblPannel.RowCount = 4
        Me.tblPannel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblPannel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblPannel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblPannel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblPannel.Size = New System.Drawing.Size(488, 100)
        Me.tblPannel.TabIndex = 13
        '
        'FormAuditTasksList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 393)
        Me.Controls.Add(Me.tblPannel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TreeViewReasons)
        Me.Name = "FormAuditTasksList"
        Me.Text = "FormAuditTasksList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents TreeViewReasons As TreeView
    Friend WithEvents Label1 As Label
    Friend WithEvents tblPannel As TableLayoutPanel
End Class
