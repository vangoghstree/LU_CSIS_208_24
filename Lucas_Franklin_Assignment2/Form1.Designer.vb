<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBibleVerse
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
        Me.chkContact = New System.Windows.Forms.CheckBox()
        Me.btnShowVerse = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpVerseNeed = New System.Windows.Forms.GroupBox()
        Me.radCompassion = New System.Windows.Forms.RadioButton()
        Me.radPeace = New System.Windows.Forms.RadioButton()
        Me.radHope = New System.Windows.Forms.RadioButton()
        Me.radStrength = New System.Windows.Forms.RadioButton()
        Me.radComfort = New System.Windows.Forms.RadioButton()
        Me.txtVerse = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.lblVisits = New System.Windows.Forms.Label()
        Me.grpVerseNeed.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkContact
        '
        Me.chkContact.AutoSize = True
        Me.chkContact.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkContact.Location = New System.Drawing.Point(194, 346)
        Me.chkContact.Name = "chkContact"
        Me.chkContact.Size = New System.Drawing.Size(131, 18)
        Me.chkContact.TabIndex = 0
        Me.chkContact.Text = "Include Contact"
        Me.chkContact.UseVisualStyleBackColor = True
        '
        'btnShowVerse
        '
        Me.btnShowVerse.Location = New System.Drawing.Point(115, 193)
        Me.btnShowVerse.Name = "btnShowVerse"
        Me.btnShowVerse.Size = New System.Drawing.Size(73, 45)
        Me.btnShowVerse.TabIndex = 1
        Me.btnShowVerse.Text = "&Show Verse"
        Me.btnShowVerse.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(466, 346)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(597, 346)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Clos&e"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grpVerseNeed
        '
        Me.grpVerseNeed.Controls.Add(Me.radCompassion)
        Me.grpVerseNeed.Controls.Add(Me.radPeace)
        Me.grpVerseNeed.Controls.Add(Me.radHope)
        Me.grpVerseNeed.Controls.Add(Me.radStrength)
        Me.grpVerseNeed.Controls.Add(Me.radComfort)
        Me.grpVerseNeed.Location = New System.Drawing.Point(12, 12)
        Me.grpVerseNeed.Name = "grpVerseNeed"
        Me.grpVerseNeed.Size = New System.Drawing.Size(176, 175)
        Me.grpVerseNeed.TabIndex = 4
        Me.grpVerseNeed.TabStop = False
        Me.grpVerseNeed.Text = "What is the need for your Bible Verse?"
        '
        'radCompassion
        '
        Me.radCompassion.AutoSize = True
        Me.radCompassion.Location = New System.Drawing.Point(9, 135)
        Me.radCompassion.Name = "radCompassion"
        Me.radCompassion.Size = New System.Drawing.Size(82, 17)
        Me.radCompassion.TabIndex = 4
        Me.radCompassion.TabStop = True
        Me.radCompassion.Text = "Compassion"
        Me.radCompassion.UseVisualStyleBackColor = True
        '
        'radPeace
        '
        Me.radPeace.AutoSize = True
        Me.radPeace.Location = New System.Drawing.Point(9, 112)
        Me.radPeace.Name = "radPeace"
        Me.radPeace.Size = New System.Drawing.Size(56, 17)
        Me.radPeace.TabIndex = 3
        Me.radPeace.TabStop = True
        Me.radPeace.Text = "Peace"
        Me.radPeace.UseVisualStyleBackColor = True
        '
        'radHope
        '
        Me.radHope.AutoSize = True
        Me.radHope.Location = New System.Drawing.Point(9, 89)
        Me.radHope.Name = "radHope"
        Me.radHope.Size = New System.Drawing.Size(51, 17)
        Me.radHope.TabIndex = 2
        Me.radHope.TabStop = True
        Me.radHope.Text = "Hope"
        Me.radHope.UseVisualStyleBackColor = True
        '
        'radStrength
        '
        Me.radStrength.AutoSize = True
        Me.radStrength.Location = New System.Drawing.Point(9, 66)
        Me.radStrength.Name = "radStrength"
        Me.radStrength.Size = New System.Drawing.Size(65, 17)
        Me.radStrength.TabIndex = 1
        Me.radStrength.TabStop = True
        Me.radStrength.Text = "Strength"
        Me.radStrength.UseVisualStyleBackColor = True
        '
        'radComfort
        '
        Me.radComfort.AutoSize = True
        Me.radComfort.Location = New System.Drawing.Point(9, 43)
        Me.radComfort.Name = "radComfort"
        Me.radComfort.Size = New System.Drawing.Size(61, 17)
        Me.radComfort.TabIndex = 0
        Me.radComfort.TabStop = True
        Me.radComfort.Text = "Comfort"
        Me.radComfort.UseVisualStyleBackColor = True
        '
        'txtVerse
        '
        Me.txtVerse.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtVerse.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerse.Location = New System.Drawing.Point(194, 12)
        Me.txtVerse.Multiline = True
        Me.txtVerse.Name = "txtVerse"
        Me.txtVerse.Size = New System.Drawing.Size(604, 328)
        Me.txtVerse.TabIndex = 5
        Me.txtVerse.TabStop = False
        '
        'lblContact
        '
        Me.lblContact.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(190, 372)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(328, 75)
        Me.lblContact.TabIndex = 6
        Me.lblContact.Text = "Student - Lucas Franklin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Professor - Miranda Dyer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "03/30/2024"
        Me.lblContact.Visible = False
        '
        'lblCounter
        '
        Me.lblCounter.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(99, 241)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(89, 68)
        Me.lblCounter.TabIndex = 7
        Me.lblCounter.Text = "0"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVisits
        '
        Me.lblVisits.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisits.Location = New System.Drawing.Point(12, 241)
        Me.lblVisits.Name = "lblVisits"
        Me.lblVisits.Size = New System.Drawing.Size(89, 68)
        Me.lblVisits.TabIndex = 8
        Me.lblVisits.Text = "Number of Visits:"
        Me.lblVisits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBibleVerse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblVisits)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.txtVerse)
        Me.Controls.Add(Me.grpVerseNeed)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowVerse)
        Me.Controls.Add(Me.chkContact)
        Me.Name = "frmBibleVerse"
        Me.Text = "Bible Verse"
        Me.grpVerseNeed.ResumeLayout(False)
        Me.grpVerseNeed.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkContact As CheckBox
    Friend WithEvents btnShowVerse As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents grpVerseNeed As GroupBox
    Friend WithEvents radCompassion As RadioButton
    Friend WithEvents radPeace As RadioButton
    Friend WithEvents radHope As RadioButton
    Friend WithEvents radStrength As RadioButton
    Friend WithEvents radComfort As RadioButton
    Friend WithEvents txtVerse As TextBox
    Friend WithEvents lblContact As Label
    Friend WithEvents lblCounter As Label
    Friend WithEvents lblVisits As Label
End Class
