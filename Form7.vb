Public Class Form7
    Private Sub FeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CLASSDataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CLASSDataSet.Fees' table. You can move, or remove it, as needed.
        Me.FeesTableAdapter.Fill(Me.CLASSDataSet.Fees)

    End Sub
End Class