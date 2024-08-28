<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBudgetCalculator
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
        Me.lstIncome = New System.Windows.Forms.ListBox()
        Me.lstExpenses = New System.Windows.Forms.ListBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnEnterIncome = New System.Windows.Forms.Button()
        Me.btnEnterExpenses = New System.Windows.Forms.Button()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstIncome
        '
        Me.lstIncome.Font = New System.Drawing.Font("Courier New", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstIncome.FormattingEnabled = True
        Me.lstIncome.HorizontalScrollbar = True
        Me.lstIncome.ItemHeight = 41
        Me.lstIncome.Location = New System.Drawing.Point(12, 32)
        Me.lstIncome.Name = "lstIncome"
        Me.lstIncome.Size = New System.Drawing.Size(515, 701)
        Me.lstIncome.TabIndex = 0
        Me.lstIncome.TabStop = False
        '
        'lstExpenses
        '
        Me.lstExpenses.Font = New System.Drawing.Font("Courier New", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstExpenses.FormattingEnabled = True
        Me.lstExpenses.HorizontalScrollbar = True
        Me.lstExpenses.ItemHeight = 41
        Me.lstExpenses.Location = New System.Drawing.Point(842, 32)
        Me.lstExpenses.Name = "lstExpenses"
        Me.lstExpenses.Size = New System.Drawing.Size(515, 701)
        Me.lstExpenses.TabIndex = 1
        Me.lstExpenses.TabStop = False
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(538, 69)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(298, 56)
        Me.txtAmount.TabIndex = 2
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(538, 735)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(298, 56)
        Me.txtTotal.TabIndex = 3
        Me.txtTotal.TabStop = False
        '
        'btnEnterIncome
        '
        Me.btnEnterIncome.Location = New System.Drawing.Point(538, 272)
        Me.btnEnterIncome.Name = "btnEnterIncome"
        Me.btnEnterIncome.Size = New System.Drawing.Size(298, 150)
        Me.btnEnterIncome.TabIndex = 4
        Me.btnEnterIncome.Text = "Enter &Income"
        Me.btnEnterIncome.UseVisualStyleBackColor = True
        '
        'btnEnterExpenses
        '
        Me.btnEnterExpenses.Location = New System.Drawing.Point(538, 463)
        Me.btnEnterExpenses.Name = "btnEnterExpenses"
        Me.btnEnterExpenses.Size = New System.Drawing.Size(298, 150)
        Me.btnEnterExpenses.TabIndex = 5
        Me.btnEnterExpenses.Text = "Enter &Expenses"
        Me.btnEnterExpenses.UseVisualStyleBackColor = True
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(600, 20)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(176, 46)
        Me.lblAmount.TabIndex = 6
        Me.lblAmount.Text = "Amount"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(615, 686)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(150, 46)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total"
        '
        'frmBudgetCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(26.0!, 46.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BackgroundImage = Global.Lucas_Franklin_Assignment_6.My.Resources.Resources.Matrix
        Me.ClientSize = New System.Drawing.Size(1371, 800)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.btnEnterExpenses)
        Me.Controls.Add(Me.btnEnterIncome)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lstExpenses)
        Me.Controls.Add(Me.lstIncome)
        Me.Font = New System.Drawing.Font("Courier New", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBudgetCalculator"
        Me.Text = "Budget Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstIncome As ListBox
    Friend WithEvents lstExpenses As ListBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnEnterIncome As Button
    Friend WithEvents btnEnterExpenses As Button
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblTotal As Label
End Class
