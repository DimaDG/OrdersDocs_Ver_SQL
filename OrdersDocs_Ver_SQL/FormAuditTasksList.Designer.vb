<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAuditTasksList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnListOK = New System.Windows.Forms.Button()
        Me.lbOrderTasks = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Списък на задачите:"
        '
        'btnListOK
        '
        Me.btnListOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnListOK.Location = New System.Drawing.Point(779, 243)
        Me.btnListOK.Name = "btnListOK"
        Me.btnListOK.Size = New System.Drawing.Size(75, 23)
        Me.btnListOK.TabIndex = 13
        Me.btnListOK.Text = "ОК"
        Me.btnListOK.UseVisualStyleBackColor = False
        '
        'lbOrderTasks
        '
        Me.lbOrderTasks.FormattingEnabled = True
        Me.lbOrderTasks.IntegralHeight = False
        Me.lbOrderTasks.ItemHeight = 16
        Me.lbOrderTasks.Location = New System.Drawing.Point(16, 27)
        Me.lbOrderTasks.Name = "lbOrderTasks"
        Me.lbOrderTasks.Size = New System.Drawing.Size(838, 116)
        Me.lbOrderTasks.TabIndex = 14
        '
        'FormAuditTasksList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 303)
        Me.Controls.Add(Me.lbOrderTasks)
        Me.Controls.Add(Me.btnListOK)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormAuditTasksList"
        Me.Text = "Описание на задачите по заповедта"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnListOK As Button
    Friend WithEvents lbOrderTasks As ListBox
End Class
