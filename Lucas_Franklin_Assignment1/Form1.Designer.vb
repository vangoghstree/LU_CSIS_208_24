<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignment1
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.txtCore = New System.Windows.Forms.TextBox()
        Me.picStudentImage = New System.Windows.Forms.PictureBox()
        CType(Me.picStudentImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(12, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(93, 3)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudent.Location = New System.Drawing.Point(9, 29)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(248, 54)
        Me.lblStudent.TabIndex = 2
        Me.lblStudent.Text = "Student - Lucas Franklin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Professor - Miranda Dyer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "03/21/2024"
        '
        'txtCore
        '
        Me.txtCore.BackColor = System.Drawing.Color.Linen
        Me.txtCore.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCore.ForeColor = System.Drawing.Color.IndianRed
        Me.txtCore.Location = New System.Drawing.Point(4, 99)
        Me.txtCore.Multiline = True
        Me.txtCore.Name = "txtCore"
        Me.txtCore.Size = New System.Drawing.Size(795, 355)
        Me.txtCore.TabIndex = 3
        Me.txtCore.TabStop = False
        Me.txtCore.Text = "But where shall wisdom be found? And where is the place of understanding? Man doe" &
    "s not know its worth, and it is not found in the land of the living. Job 28:12-1" &
    "3 ESV"
        Me.txtCore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picStudentImage
        '
        Me.picStudentImage.Image = Global.Lucas_Franklin_assignment1.My.Resources.Resources.cold_beans_stale_toast
        Me.picStudentImage.Location = New System.Drawing.Point(579, 233)
        Me.picStudentImage.Name = "picStudentImage"
        Me.picStudentImage.Size = New System.Drawing.Size(220, 221)
        Me.picStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudentImage.TabIndex = 4
        Me.picStudentImage.TabStop = False
        '
        'frmAssignment1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picStudentImage)
        Me.Controls.Add(Me.txtCore)
        Me.Controls.Add(Me.lblStudent)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "frmAssignment1"
        Me.Text = "Foundation Assignment"
        CType(Me.picStudentImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lblStudent As Label
    Friend WithEvents txtCore As TextBox
    Friend WithEvents picStudentImage As PictureBox
End Class
