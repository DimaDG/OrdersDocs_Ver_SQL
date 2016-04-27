Public Class FormMain
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub lbStandards_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbStandards.SelectedIndexChanged
        'Показва в кутийката броя избрани стандарти от списъка
        tbCountSelectedStandards.Clear()
        tbCountSelectedStandards.Text = lbStandards.SelectedItems.Count.ToString
    End Sub

    Private Sub chkB_StandardsFullSet_CheckedChanged(sender As Object, e As EventArgs) Handles chkB_StandardsFullSet.CheckedChanged
        'Включва/изключва възможността за избор от сипсъка със стандартите
        Select Case chkB_StandardsFullSet.Checked
            Case True
                lbStandards.Enabled = False
            Case False
                lbStandards.Enabled = True
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbStandards.ClearSelected()
    End Sub

    Private Sub chkListBoxReason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkListBoxReason.SelectedIndexChanged
        'Debug.WriteLine("------------------------------------")
        'Debug.WriteLine(chkListBoxReason.Items(3).ToString & " -- " & CType(chkListBoxReason.GetItemChecked(3), String))
        'Debug.WriteLine(chkListBoxReason.Items(6).ToString & " -- " & CType(chkListBoxReason.GetItemChecked(6), String))
        'Debug.WriteLine(chkListBoxReason.Items(8).ToString & " -- " & CType(chkListBoxReason.GetItemChecked(8), String))
        '---------------------------------------
        '!!!За да работи правилно трябва CheckOnClick property на контролата да бъде True!!!
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

    Private Sub TreeViewReasons_AfterSelect(sender As Object, e As TreeViewEventArgs)
        'За да се извлече пълният текст от избраното ниво на "Основание"
        Debug.WriteLine("--------------------------------")
        Debug.WriteLine(FormAuditTasksList.TreeViewReasons.SelectedNode.FullPath)
    End Sub

    Private Sub TreeViewReasons_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)
        FormAuditTasksList.TreeViewReasons.ExpandAll()
    End Sub

    Private Sub TreeViewReasons_AfterCheck(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub btnTasksListEdit_Click(sender As Object, e As EventArgs) Handles btnTasksListEdit.Click
        FormAuditTasksList.Show()
    End Sub
End Class
