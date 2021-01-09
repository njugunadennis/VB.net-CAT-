Public Class Form4
    Private Sub TimetableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TimetableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TimetableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CLASSDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CLASSDataSet.Timetable' table. You can move, or remove it, as needed.
        Me.TimetableTableAdapter.Fill(Me.CLASSDataSet.Timetable)

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Me.TimetableBindingSource.AddNew()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Me.TimetableBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Me.TimetableBindingSource.MoveNext()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        Me.TimetableBindingSource.MovePrevious()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Comfirm you want to Exit", "Class management system",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class