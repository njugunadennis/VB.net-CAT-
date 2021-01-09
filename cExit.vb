Public Class cExit
    Public Shared Function Existsystem()
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Comfirm you want to Exit", "Class management system",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Function


End Class
