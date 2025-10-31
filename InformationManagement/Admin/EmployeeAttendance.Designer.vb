<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeAttendance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Regular_Hours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Over_Time_Hours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Absences = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(192, 197)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1532, 663)
        Me.Panel1.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly"})
        Me.ComboBox1.Location = New System.Drawing.Point(1097, 40)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(217, 28)
        Me.ComboBox1.TabIndex = 6
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Employee, Me.Position, Me.Regular_Hours, Me.Over_Time_Hours, Me.Absences, Me.Status})
        Me.DataGridView1.Location = New System.Drawing.Point(177, 100)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1002, 47)
        Me.DataGridView1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Employee Attendance Report"
        '
        'Employee
        '
        Me.Employee.HeaderText = "Employee"
        Me.Employee.MinimumWidth = 6
        Me.Employee.Name = "Employee"
        Me.Employee.Width = 200
        '
        'Position
        '
        Me.Position.HeaderText = "Position"
        Me.Position.MinimumWidth = 6
        Me.Position.Name = "Position"
        Me.Position.Width = 150
        '
        'Regular_Hours
        '
        Me.Regular_Hours.HeaderText = "Regular Hours"
        Me.Regular_Hours.MinimumWidth = 6
        Me.Regular_Hours.Name = "Regular_Hours"
        Me.Regular_Hours.Width = 150
        '
        'Over_Time_Hours
        '
        Me.Over_Time_Hours.HeaderText = "Over Time Hourse"
        Me.Over_Time_Hours.MinimumWidth = 6
        Me.Over_Time_Hours.Name = "Over_Time_Hours"
        Me.Over_Time_Hours.Width = 150
        '
        'Absences
        '
        Me.Absences.HeaderText = "Abesences"
        Me.Absences.MinimumWidth = 6
        Me.Absences.Name = "Absences"
        Me.Absences.Width = 150
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.Width = 150
        '
        'EmployeeAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1501, 810)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EmployeeAttendance"
        Me.Tag = ""
        Me.Text = "Employee Attendance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Employee As DataGridViewTextBoxColumn
    Friend WithEvents Position As DataGridViewTextBoxColumn
    Friend WithEvents Regular_Hours As DataGridViewTextBoxColumn
    Friend WithEvents Over_Time_Hours As DataGridViewTextBoxColumn
    Friend WithEvents Absences As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
End Class
