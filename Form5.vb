Public Class Form5
    Private Sub LecturerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LecturerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CLASSDataSet)

    End Sub

    Private Sub LecturerBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles LecturerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LecturerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CLASSDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CLASSDataSet.Lecturer' table. You can move, or remove it, as needed.
        Me.LecturerTableAdapter.Fill(Me.CLASSDataSet.Lecturer)

    End Sub
End Class