﻿Public Class FormMain
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub TreeViewReasons_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewReasons.AfterSelect

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
        'Включва/изключва таба със стандартите
        Debug.Print(chkListBoxReason.GetItemCheckState(3))
        Select Case chkListBoxReason.GetItemCheckState(3)
            Case 1
                Me.TabControl1.TabPages.Item("TabPage4").Enabled = True
            Case 0
                Me.TabControl1.TabPages.Item("TabPage4").Enabled = False
        End Select
    End Sub
End Class
