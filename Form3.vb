Public Class Form3
    Private Sub CoursesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CoursesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CoursesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CLASSDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CLASSDataSet.Courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.CLASSDataSet.Courses)

    End Sub
End Class