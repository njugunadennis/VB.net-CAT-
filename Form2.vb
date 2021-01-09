Public Class Form2
    Private Sub StudentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CLASSDataSet)

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Me.StudentsBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        Me.StudentsBindingSource.MovePrevious()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Comfirm you want to Exit", "Class management system",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Me.StudentsBindingSource.AddNew()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Me.StudentsBindingSource.MoveNext()
    End Sub
End Class










