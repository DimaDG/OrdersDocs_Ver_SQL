Public Class FormMain
    'Обработва кликването върху бутона Cancel
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'обработва събитията след кликване в списъка със стандартите
    Private Sub lbStandards_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbStandards.SelectedIndexChanged
        'Показва в кутийката броя избрани стандарти от списъка
        tbCountSelectedStandards.Clear()
        tbCountSelectedStandards.Text = lbStandards.SelectedItems.Count.ToString
    End Sub
    'обработва натискането на бутона за избор на всички стандарти
    Private Sub chkB_StandardsFullSet_CheckedChanged(sender As Object, e As EventArgs) Handles chkB_StandardsFullSet.CheckedChanged
        'Включва/изключва възможността за избор от списъка със стандартите
        Select Case chkB_StandardsFullSet.Checked
            Case True
                lbStandards.Enabled = False
            Case False
                lbStandards.Enabled = True
        End Select
    End Sub
    'обработва натискането на бутона за изчистване всички избрани стандарти
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbStandards.ClearSelected()
    End Sub
    'обработва кликване и промяна в индекса на Вид заповед
    Private Sub chkListBoxReason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkListBoxReason.SelectedIndexChanged
        'Вкл/ изкл таба "Жалби и писма"
        Select Case chkListBoxReason.GetItemChecked(0) 'Or chkListBoxReason.GetItemChecked(1)
            Case True
                'Me.TabControl1.TabPages.Item(4).Enabled = True
                Me.tbComplaintsList.Enabled = True
                Me.Label4.Enabled = True
            Case False
                'Me.TabControl1.TabPages.Item(4).Enabled = False
                Me.tbComplaintsList.Enabled = False
                Me.Label4.Enabled = False
        End Select
        Select Case chkListBoxReason.GetItemChecked(1)
            Case True
                'Me.TabControl1.TabPages.Item(4).Enabled = True
                Me.grbLetters.Enabled = True
            Case False
                'Me.TabControl1.TabPages.Item(4).Enabled = False
                Me.grbLetters.Enabled = False
        End Select



        '---------------------------------------
        '!!!За да работи правилно трябва CheckOnClick property на контролата да бъде True!!!
        'по подразбиране е първо прави селект и про второ кликване - чек
        '---------------------------------------
        'Включва/изключва таба със стандартите
        Select Case chkListBoxReason.GetItemChecked(3)
            Case True
                Me.TabControl1.TabPages.Item(3).Enabled = True
            Case False
                Me.TabControl1.TabPages.Item(3).Enabled = False
        End Select
        'Включва/изключва контролите за избор на РЗОК
        Select Case chkListBoxReason.GetItemChecked(6)
            Case True
                Me.gbRZOK.Enabled = True
            Case False
                Me.gbRZOK.Enabled = False
        End Select
        'Включва/изключва контролите за избор на ДЗОФ
        Select Case chkListBoxReason.GetItemChecked(8)
            Case True
                Me.gbDZOF.Enabled = True
            Case False
                Me.gbDZOF.Enabled = False
        End Select
    End Sub
    'обработва извличането на пълния стринг на текста за Основание за проверката
    '!!!да се пренесе в FormAuditTasksList, където се намира списъка!!!
    Private Sub TreeViewReasons_AfterSelect(sender As Object, e As TreeViewEventArgs)
        'За да се извлече пълният текст от избраното ниво на "Основание"
        Debug.WriteLine("--------------------------------")
        Debug.WriteLine(FormAuditTasksList.TreeViewReasons.SelectedNode.FullPath)
    End Sub
    'извиква форма FormAuditTasksList след натискане на бутона за редакция на задачите
    Private Sub btnTasksListEdit_Click(sender As Object, e As EventArgs) Handles btnTasksListEdit.Click
        FormAuditTasksList.Show()
    End Sub
    'създаване на обект AuditTasks като ArrayList
    Public objAuditTasks As New ArrayList
    'Метод за съхраняване на №, задача(текст) и основанието за извършване по заповед
    Public Sub CreateNewAuditTask(number As String, text As String, reason As String)
        'Деклариране на AuditTask обект
        Dim objNewAuditTask As AuditTask
        'Създаване на нова задача
        objNewAuditTask.Number = number
        objNewAuditTask.Text = text
        objNewAuditTask.Reason = reason
        'добавяне на новата задача към списъка
        objAuditTasks.Add(objNewAuditTask)
    End Sub

End Class
