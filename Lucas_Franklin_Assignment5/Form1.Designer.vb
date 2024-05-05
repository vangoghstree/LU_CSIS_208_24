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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCreateFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAscend = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescend = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.lblMembersTitle = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuSort})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1018, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(133, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCreateFile, Me.mnuAddMember, Me.mnuDeleteMember})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuCreateFile
        '
        Me.mnuCreateFile.Name = "mnuCreateFile"
        Me.mnuCreateFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCreateFile.Size = New System.Drawing.Size(196, 22)
        Me.mnuCreateFile.Text = "Create File"
        '
        'mnuAddMember
        '
        Me.mnuAddMember.Name = "mnuAddMember"
        Me.mnuAddMember.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.mnuAddMember.Size = New System.Drawing.Size(196, 22)
        Me.mnuAddMember.Text = "Add Member"
        '
        'mnuDeleteMember
        '
        Me.mnuDeleteMember.Name = "mnuDeleteMember"
        Me.mnuDeleteMember.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuDeleteMember.Size = New System.Drawing.Size(196, 22)
        Me.mnuDeleteMember.Text = "Delete Member"
        '
        'mnuSort
        '
        Me.mnuSort.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAscend, Me.mnuDescend})
        Me.mnuSort.Name = "mnuSort"
        Me.mnuSort.Size = New System.Drawing.Size(40, 20)
        Me.mnuSort.Text = "&Sort"
        '
        'mnuAscend
        '
        Me.mnuAscend.Name = "mnuAscend"
        Me.mnuAscend.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAscend.Size = New System.Drawing.Size(180, 22)
        Me.mnuAscend.Text = "Ascend"
        '
        'mnuDescend
        '
        Me.mnuDescend.Name = "mnuDescend"
        Me.mnuDescend.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuDescend.Size = New System.Drawing.Size(180, 22)
        Me.mnuDescend.Text = "Descend"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(363, 469)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(94, 31)
        Me.lblCount.TabIndex = 1
        Me.lblCount.Text = "Count"
        '
        'lstMembers
        '
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.ItemHeight = 23
        Me.lstMembers.Location = New System.Drawing.Point(12, 63)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.Size = New System.Drawing.Size(994, 395)
        Me.lstMembers.TabIndex = 2
        '
        'lblMembersTitle
        '
        Me.lblMembersTitle.AutoSize = True
        Me.lblMembersTitle.Font = New System.Drawing.Font("Courier New", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembersTitle.Location = New System.Drawing.Point(412, 24)
        Me.lblMembersTitle.Name = "lblMembersTitle"
        Me.lblMembersTitle.Size = New System.Drawing.Size(148, 36)
        Me.lblMembersTitle.TabIndex = 3
        Me.lblMembersTitle.Text = "Members"
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(524, 469)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(100, 31)
        Me.txtCount.TabIndex = 4
        Me.txtCount.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1018, 562)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.lblMembersTitle)
        Me.Controls.Add(Me.lstMembers)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents lblCount As Label
    Friend WithEvents lstMembers As ListBox
    Friend WithEvents lblMembersTitle As Label
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents txtCount As TextBox
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuCreateFile As ToolStripMenuItem
    Friend WithEvents mnuAddMember As ToolStripMenuItem
    Friend WithEvents mnuDeleteMember As ToolStripMenuItem
    Friend WithEvents mnuSort As ToolStripMenuItem
    Friend WithEvents mnuAscend As ToolStripMenuItem
    Friend WithEvents mnuDescend As ToolStripMenuItem
End Class
