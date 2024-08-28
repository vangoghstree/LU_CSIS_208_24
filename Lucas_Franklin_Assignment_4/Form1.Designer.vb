<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVolunteerCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblMission1 = New System.Windows.Forms.Label()
        Me.btnAddVolunteerHours = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblMission2 = New System.Windows.Forms.Label()
        Me.lblMission3 = New System.Windows.Forms.Label()
        Me.lblMission4 = New System.Windows.Forms.Label()
        Me.lblMission1Title = New System.Windows.Forms.Label()
        Me.lstTotals = New System.Windows.Forms.ListBox()
        Me.lblMission2Title = New System.Windows.Forms.Label()
        Me.lblMission3Title = New System.Windows.Forms.Label()
        Me.lblMission4Title = New System.Windows.Forms.Label()
        Me.lblProjectTitle = New System.Windows.Forms.Label()
        Me.txthoursworked = New System.Windows.Forms.TextBox()
        Me.lblHoursWorked = New System.Windows.Forms.Label()
        Me.lblMissionOptions = New System.Windows.Forms.Label()
        Me.lstMissions = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblMission1
        '
        Me.lblMission1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMission1.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMission1.Location = New System.Drawing.Point(1117, 129)
        Me.lblMission1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMission1.Name = "lblMission1"
        Me.lblMission1.Size = New System.Drawing.Size(326, 58)
        Me.lblMission1.TabIndex = 4
        Me.lblMission1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddVolunteerHours
        '
        Me.btnAddVolunteerHours.Location = New System.Drawing.Point(83, 478)
        Me.btnAddVolunteerHours.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnAddVolunteerHours.Name = "btnAddVolunteerHours"
        Me.btnAddVolunteerHours.Size = New System.Drawing.Size(184, 89)
        Me.btnAddVolunteerHours.TabIndex = 2
        Me.btnAddVolunteerHours.Text = "&Add Volunteer Hours"
        Me.btnAddVolunteerHours.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(603, 584)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(162, 41)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Clos&e"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblMission2
        '
        Me.lblMission2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMission2.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMission2.Location = New System.Drawing.Point(1117, 241)
        Me.lblMission2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMission2.Name = "lblMission2"
        Me.lblMission2.Size = New System.Drawing.Size(326, 58)
        Me.lblMission2.TabIndex = 5
        Me.lblMission2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMission3
        '
        Me.lblMission3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMission3.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMission3.Location = New System.Drawing.Point(1117, 357)
        Me.lblMission3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMission3.Name = "lblMission3"
        Me.lblMission3.Size = New System.Drawing.Size(326, 58)
        Me.lblMission3.TabIndex = 6
        Me.lblMission3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMission4
        '
        Me.lblMission4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMission4.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMission4.Location = New System.Drawing.Point(1117, 475)
        Me.lblMission4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMission4.Name = "lblMission4"
        Me.lblMission4.Size = New System.Drawing.Size(326, 58)
        Me.lblMission4.TabIndex = 7
        Me.lblMission4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMission1Title
        '
        Me.lblMission1Title.Font = New System.Drawing.Font("Courier New", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMission1Title.Location = New System.Drawing.Point(1117, 67)
        Me.lblMission1Title.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMission1Title.Name = "lblMission1Title"
        Me.lblMission1Title.Size = New System.Drawing.Size(326, 62)
        Me.lblMission1Title.TabIndex = 8
        Me.lblMission1Title.Text = "Food Bank of the Rockies"
        Me.lblMission1Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstTotals
        '
        Me.lstTotals.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lstTotals.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTotals.HorizontalScrollbar = True
        Me.lstTotals.ItemHeight = 23
        Me.lstTotals.Location = New System.Drawing.Point(353, 57)
        Me.lstTotals.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.lstTotals.Name = "lstTotals"
        Me.lstTotals.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstTotals.Size = New System.Drawing.Size(752, 510)
        Me.lstTotals.TabIndex = 11
        Me.lstTotals.TabStop = False
        '
        'lblMission2Title
        '
        Me.lblMission2Title.Font = New System.Drawing.Font("Courier New", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMission2Title.Location = New System.Drawing.Point(1117, 188)
        Me.lblMission2Title.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMission2Title.Name = "lblMission2Title"
        Me.lblMission2Title.Size = New System.Drawing.Size(326, 58)
        Me.lblMission2Title.TabIndex = 9
        Me.lblMission2Title.Text = "The Assistance Fund"
        Me.lblMission2Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMission3Title
        '
        Me.lblMission3Title.Font = New System.Drawing.Font("Courier New", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMission3Title.Location = New System.Drawing.Point(1117, 299)
        Me.lblMission3Title.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMission3Title.Name = "lblMission3Title"
        Me.lblMission3Title.Size = New System.Drawing.Size(326, 58)
        Me.lblMission3Title.TabIndex = 10
        Me.lblMission3Title.Text = "Native American Heritage Association"
        Me.lblMission3Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMission4Title
        '
        Me.lblMission4Title.Font = New System.Drawing.Font("Courier New", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMission4Title.Location = New System.Drawing.Point(1117, 417)
        Me.lblMission4Title.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMission4Title.Name = "lblMission4Title"
        Me.lblMission4Title.Size = New System.Drawing.Size(326, 58)
        Me.lblMission4Title.TabIndex = 11
        Me.lblMission4Title.Text = "Goodwill of Southwestern Pennsylvania" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMission4Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProjectTitle
        '
        Me.lblProjectTitle.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectTitle.Location = New System.Drawing.Point(468, 9)
        Me.lblProjectTitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblProjectTitle.Name = "lblProjectTitle"
        Me.lblProjectTitle.Size = New System.Drawing.Size(330, 62)
        Me.lblProjectTitle.TabIndex = 16
        Me.lblProjectTitle.Text = "Mission Hours"
        Me.lblProjectTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txthoursworked
        '
        Me.txthoursworked.Location = New System.Drawing.Point(67, 115)
        Me.txthoursworked.Name = "txthoursworked"
        Me.txthoursworked.Size = New System.Drawing.Size(221, 31)
        Me.txthoursworked.TabIndex = 0
        '
        'lblHoursWorked
        '
        Me.lblHoursWorked.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursWorked.Location = New System.Drawing.Point(15, 64)
        Me.lblHoursWorked.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblHoursWorked.Name = "lblHoursWorked"
        Me.lblHoursWorked.Size = New System.Drawing.Size(330, 62)
        Me.lblHoursWorked.TabIndex = 18
        Me.lblHoursWorked.Text = "Hours Worked:"
        Me.lblHoursWorked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMissionOptions
        '
        Me.lblMissionOptions.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissionOptions.Location = New System.Drawing.Point(11, 162)
        Me.lblMissionOptions.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMissionOptions.Name = "lblMissionOptions"
        Me.lblMissionOptions.Size = New System.Drawing.Size(330, 62)
        Me.lblMissionOptions.TabIndex = 19
        Me.lblMissionOptions.Text = "Mission Options:"
        Me.lblMissionOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstMissions
        '
        Me.lstMissions.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lstMissions.FormattingEnabled = True
        Me.lstMissions.ItemHeight = 23
        Me.lstMissions.Location = New System.Drawing.Point(15, 211)
        Me.lstMissions.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.lstMissions.Name = "lstMissions"
        Me.lstMissions.Size = New System.Drawing.Size(326, 257)
        Me.lstMissions.TabIndex = 1
        '
        'frmVolunteerCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1576, 643)
        Me.Controls.Add(Me.txthoursworked)
        Me.Controls.Add(Me.lblHoursWorked)
        Me.Controls.Add(Me.lblMission4Title)
        Me.Controls.Add(Me.lblMission3Title)
        Me.Controls.Add(Me.lstTotals)
        Me.Controls.Add(Me.lblMission4)
        Me.Controls.Add(Me.lblMission3)
        Me.Controls.Add(Me.lblMission2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddVolunteerHours)
        Me.Controls.Add(Me.lstMissions)
        Me.Controls.Add(Me.lblMission1)
        Me.Controls.Add(Me.lblMission2Title)
        Me.Controls.Add(Me.lblMission1Title)
        Me.Controls.Add(Me.lblProjectTitle)
        Me.Controls.Add(Me.lblMissionOptions)
        Me.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmVolunteerCalculator"
        Me.Text = "Volunteer Hours Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMission1 As Label
    Friend WithEvents btnAddVolunteerHours As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblMission2 As Label
    Friend WithEvents lblMission3 As Label
    Friend WithEvents lblMission4 As Label
    Friend WithEvents lblMission1Title As Label
    Friend WithEvents lstTotals As ListBox
    Friend WithEvents lblMission2Title As Label
    Friend WithEvents lblMission3Title As Label
    Friend WithEvents lblMission4Title As Label
    Friend WithEvents lblProjectTitle As Label
    Friend WithEvents txthoursworked As TextBox
    Friend WithEvents lblHoursWorked As Label
    Friend WithEvents lblMissionOptions As Label
    Friend WithEvents lstMissions As ListBox
End Class
