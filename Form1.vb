Public Class Form1
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnstudent_Click(sender As Object, e As EventArgs) Handles btnstudent.Click
        Dim STUDENTform As New Form2
        STUDENTform.Show()
    End Sub

    Private Sub btncourse_Click(sender As Object, e As EventArgs) Handles btncourse.Click
        Dim COURSEform As New Form3
        COURSEform.Show()
    End Sub

    Private Sub btntimetable_Click(sender As Object, e As EventArgs) Handles btntimetable.Click
        Dim TIMETABLEform As New Form4
        TIMETABLEform.Show()
    End Sub

    Private Sub btnlecturer_Click(sender As Object, e As EventArgs) Handles btnlecturer.Click
        Dim LECTURERform As New Form5
        LECTURERform.Show()
    End Sub

    Private Sub btnresults_Click(sender As Object, e As EventArgs) Handles btnresults.Click
        Dim RESUSTSform As New Form6
        RESUSTSform.Show()
    End Sub

    Private Sub btnfee_Click(sender As Object, e As EventArgs) Handles btnfee.Click
        Dim FEEform As New Form7
        FEEform.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        cExit.Existsystem()

    End Sub

    Private Sub LoginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LoginBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Loginsystem1DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Loginsystem1DataSet.login' table. You can move, or remove it, as needed.


    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs)

    End Sub
End Class
