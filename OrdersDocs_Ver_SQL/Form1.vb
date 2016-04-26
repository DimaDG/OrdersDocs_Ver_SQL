Public Class FormMain
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub TreeViewReasons_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewReasons.AfterSelect

    End Sub

    Private Sub lbStandards_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbStandards.SelectedIndexChanged
        tbCountSelectedStandards.Clear()
        'Debug.Print("избрани стандарти " & lbStandards.SelectedItems.Count)
        tbCountSelectedStandards.Text = lbStandards.SelectedItems.Count.ToString
    End Sub
End Class
