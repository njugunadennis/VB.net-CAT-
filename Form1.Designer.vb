<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btntimetable = New System.Windows.Forms.Button()
        Me.btncourse = New System.Windows.Forms.Button()
        Me.btnstudent = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnfee = New System.Windows.Forms.Button()
        Me.btnresults = New System.Windows.Forms.Button()
        Me.btnlecturer = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnhelp = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Loginsystem1DataSet = New CLASS_PROJECT.loginsystem1DataSet()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New CLASS_PROJECT.loginsystem1DataSetTableAdapters.loginTableAdapter()
        Me.TableAdapterManager = New CLASS_PROJECT.loginsystem1DataSetTableAdapters.TableAdapterManager()
        Me.LoginBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LoginBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.LoginDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Loginsystem1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoginBindingNavigator.SuspendLayout()
        CType(Me.LoginDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1044, 77)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLASS MANAGEMENT SYSTEM"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btntimetable)
        Me.Panel1.Controls.Add(Me.btncourse)
        Me.Panel1.Controls.Add(Me.btnstudent)
        Me.Panel1.Location = New System.Drawing.Point(41, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 323)
        Me.Panel1.TabIndex = 1
        '
        'btntimetable
        '
        Me.btntimetable.AutoSize = True
        Me.btntimetable.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btntimetable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntimetable.Location = New System.Drawing.Point(53, 202)
        Me.btntimetable.Name = "btntimetable"
        Me.btntimetable.Size = New System.Drawing.Size(145, 59)
        Me.btntimetable.TabIndex = 2
        Me.btntimetable.Text = "TIMETABLE"
        Me.btntimetable.UseVisualStyleBackColor = False
        '
        'btncourse
        '
        Me.btncourse.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btncourse.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncourse.Location = New System.Drawing.Point(53, 105)
        Me.btncourse.Name = "btncourse"
        Me.btncourse.Size = New System.Drawing.Size(145, 60)
        Me.btncourse.TabIndex = 1
        Me.btncourse.Text = "COURSES"
        Me.btncourse.UseVisualStyleBackColor = False
        '
        'btnstudent
        '
        Me.btnstudent.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnstudent.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstudent.Location = New System.Drawing.Point(53, 23)
        Me.btnstudent.Name = "btnstudent"
        Me.btnstudent.Size = New System.Drawing.Size(145, 53)
        Me.btnstudent.TabIndex = 0
        Me.btnstudent.Text = "STUDENTS"
        Me.btnstudent.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnfee)
        Me.Panel2.Controls.Add(Me.btnresults)
        Me.Panel2.Controls.Add(Me.btnlecturer)
        Me.Panel2.Location = New System.Drawing.Point(761, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(245, 323)
        Me.Panel2.TabIndex = 2
        '
        'btnfee
        '
        Me.btnfee.AutoSize = True
        Me.btnfee.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnfee.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfee.Location = New System.Drawing.Point(68, 204)
        Me.btnfee.Name = "btnfee"
        Me.btnfee.Size = New System.Drawing.Size(141, 57)
        Me.btnfee.TabIndex = 3
        Me.btnfee.Text = "FEE"
        Me.btnfee.UseVisualStyleBackColor = False
        '
        'btnresults
        '
        Me.btnresults.AutoSize = True
        Me.btnresults.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnresults.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresults.Location = New System.Drawing.Point(68, 107)
        Me.btnresults.Name = "btnresults"
        Me.btnresults.Size = New System.Drawing.Size(141, 66)
        Me.btnresults.TabIndex = 2
        Me.btnresults.Text = "RESULTS"
        Me.btnresults.UseVisualStyleBackColor = False
        '
        'btnlecturer
        '
        Me.btnlecturer.AutoSize = True
        Me.btnlecturer.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnlecturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlecturer.Location = New System.Drawing.Point(65, 25)
        Me.btnlecturer.Name = "btnlecturer"
        Me.btnlecturer.Size = New System.Drawing.Size(144, 59)
        Me.btnlecturer.TabIndex = 1
        Me.btnlecturer.Text = "LECTURER"
        Me.btnlecturer.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btnhelp)
        Me.Panel3.Location = New System.Drawing.Point(331, 180)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(373, 252)
        Me.Panel3.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ravie", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, -5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "WELCOME"
        '
        'btnhelp
        '
        Me.btnhelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp.Location = New System.Drawing.Point(94, 208)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(127, 41)
        Me.btnhelp.TabIndex = 2
        Me.btnhelp.Text = "HELP?"
        Me.btnhelp.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnexit.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(746, 476)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(149, 54)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'Loginsystem1DataSet
        '
        Me.Loginsystem1DataSet.DataSetName = "loginsystem1DataSet"
        Me.Loginsystem1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "login"
        Me.LoginBindingSource.DataSource = Me.Loginsystem1DataSet
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.loginTableAdapter = Me.LoginTableAdapter
        Me.TableAdapterManager.UpdateOrder = CLASS_PROJECT.loginsystem1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LoginBindingNavigator
        '
        Me.LoginBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LoginBindingNavigator.BindingSource = Me.LoginBindingSource
        Me.LoginBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LoginBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LoginBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LoginBindingNavigatorSaveItem})
        Me.LoginBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LoginBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LoginBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LoginBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LoginBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LoginBindingNavigator.Name = "LoginBindingNavigator"
        Me.LoginBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LoginBindingNavigator.Size = New System.Drawing.Size(1184, 25)
        Me.LoginBindingNavigator.TabIndex = 5
        Me.LoginBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'LoginBindingNavigatorSaveItem
        '
        Me.LoginBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LoginBindingNavigatorSaveItem.Image = CType(resources.GetObject("LoginBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LoginBindingNavigatorSaveItem.Name = "LoginBindingNavigatorSaveItem"
        Me.LoginBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LoginBindingNavigatorSaveItem.Text = "Save Data"
        '
        'LoginDataGridView
        '
        Me.LoginDataGridView.AutoGenerateColumns = False
        Me.LoginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LoginDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.LoginDataGridView.DataSource = Me.LoginBindingSource
        Me.LoginDataGridView.Location = New System.Drawing.Point(292, 426)
        Me.LoginDataGridView.Name = "LoginDataGridView"
        Me.LoginDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.LoginDataGridView.TabIndex = 6
        Me.LoginDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn1.HeaderText = "username"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn2.HeaderText = "password"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Admin"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Admin"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(370, 215)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1184, 710)
        Me.Controls.Add(Me.LoginDataGridView)
        Me.Controls.Add(Me.LoginBindingNavigator)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CLASS MANAGEMENT SYSTEM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Loginsystem1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoginBindingNavigator.ResumeLayout(False)
        Me.LoginBindingNavigator.PerformLayout()
        CType(Me.LoginDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btntimetable As Button
    Friend WithEvents btncourse As Button
    Friend WithEvents btnstudent As Button
    Friend WithEvents btnfee As Button
    Friend WithEvents btnresults As Button
    Friend WithEvents btnlecturer As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnhelp As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents Loginsystem1DataSet As loginsystem1DataSet
    Friend WithEvents LoginBindingSource As BindingSource
    Friend WithEvents LoginTableAdapter As loginsystem1DataSetTableAdapters.loginTableAdapter
    Friend WithEvents TableAdapterManager As loginsystem1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents LoginBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents LoginBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents LoginDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
