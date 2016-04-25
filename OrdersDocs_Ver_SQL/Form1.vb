Public Class FormMain
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub TreeViewReasons_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewReasons.AfterSelect

    End Sub

    Private Sub chkLBStandards_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkLBStandards.SelectedIndexChanged
        Me.tbCountSelectedStandards.Clear()
        Me.tbCountSelectedStandards.Text = CType(chkLBStandards.CheckedItems.Count, String)
    End Sub
End Class
