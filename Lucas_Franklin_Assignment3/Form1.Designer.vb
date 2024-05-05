<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVolunteerCalculator
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
        Me.lblNumberofPeopleServed = New System.Windows.Forms.Label()
        Me.lblNumberofvolunteers = New System.Windows.Forms.Label()
        Me.cboBox = New System.Windows.Forms.ComboBox()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtNumberofPeopleServed = New System.Windows.Forms.TextBox()
        Me.txtNumberofVolunteers = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNumberofPeopleServed
        '
        Me.lblNumberofPeopleServed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumberofPeopleServed.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberofPeopleServed.Location = New System.Drawing.Point(3, 9)
        Me.lblNumberofPeopleServed.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblNumberofPeopleServed.Name = "lblNumberofPeopleServed"
        Me.lblNumberofPeopleServed.Size = New System.Drawing.Size(220, 71)
        Me.lblNumberofPeopleServed.TabIndex = 0
        Me.lblNumberofPeopleServed.Text = "Number of People Served"
        Me.lblNumberofPeopleServed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumberofvolunteers
        '
        Me.lblNumberofvolunteers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumberofvolunteers.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberofvolunteers.Location = New System.Drawing.Point(235, 9)
        Me.lblNumberofvolunteers.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblNumberofvolunteers.Name = "lblNumberofvolunteers"
        Me.lblNumberofvolunteers.Size = New System.Drawing.Size(220, 71)
        Me.lblNumberofvolunteers.TabIndex = 1
        Me.lblNumberofvolunteers.Text = "Number of volunteers"
        Me.lblNumberofvolunteers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboBox
        '
        Me.cboBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cboBox.FormattingEnabled = True
        Me.cboBox.Items.AddRange(New Object() {"Breakfast", "Lunch", "Dinner"})
        Me.cboBox.Location = New System.Drawing.Point(133, 159)
        Me.cboBox.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.cboBox.Name = "cboBox"
        Me.cboBox.Size = New System.Drawing.Size(220, 31)
        Me.cboBox.TabIndex = 2
        '
        'lstDisplay
        '
        Me.lstDisplay.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 23
        Me.lstDisplay.Location = New System.Drawing.Point(15, 233)
        Me.lstDisplay.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(679, 257)
        Me.lstDisplay.TabIndex = 3
        Me.lstDisplay.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(706, 233)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(162, 41)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(706, 284)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(162, 41)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Clos&e"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(706, 335)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(162, 41)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Cle&ar"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtNumberofPeopleServed
        '
        Me.txtNumberofPeopleServed.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNumberofPeopleServed.Location = New System.Drawing.Point(3, 85)
        Me.txtNumberofPeopleServed.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtNumberofPeopleServed.MinimumSize = New System.Drawing.Size(4, 50)
        Me.txtNumberofPeopleServed.Name = "txtNumberofPeopleServed"
        Me.txtNumberofPeopleServed.Size = New System.Drawing.Size(220, 31)
        Me.txtNumberofPeopleServed.TabIndex = 7
        '
        'txtNumberofVolunteers
        '
        Me.txtNumberofVolunteers.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNumberofVolunteers.Location = New System.Drawing.Point(235, 85)
        Me.txtNumberofVolunteers.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtNumberofVolunteers.Name = "txtNumberofVolunteers"
        Me.txtNumberofVolunteers.Size = New System.Drawing.Size(220, 31)
        Me.txtNumberofVolunteers.TabIndex = 8
        '
        'frmVolunteerCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 496)
        Me.Controls.Add(Me.txtNumberofVolunteers)
        Me.Controls.Add(Me.txtNumberofPeopleServed)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.cboBox)
        Me.Controls.Add(Me.lblNumberofvolunteers)
        Me.Controls.Add(Me.lblNumberofPeopleServed)
        Me.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmVolunteerCalculator"
        Me.Text = "Volunteer Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumberofPeopleServed As Label
    Friend WithEvents lblNumberofvolunteers As Label
    Friend WithEvents cboBox As ComboBox
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtNumberofPeopleServed As TextBox
    Friend WithEvents txtNumberofVolunteers As TextBox
End Class
