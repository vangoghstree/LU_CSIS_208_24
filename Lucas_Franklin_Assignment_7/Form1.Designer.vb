<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabase
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
        Dim lblIDLabel As System.Windows.Forms.Label
        Dim lblTitleLabel As System.Windows.Forms.Label
        Dim lblPlatformLabel As System.Windows.Forms.Label
        Dim lblRatingLabel As System.Windows.Forms.Label
        Dim lblPriceLabel As System.Windows.Forms.Label
        Dim lblNewUsedLabel As System.Windows.Forms.Label
        Dim lblQuantityLabel As System.Windows.Forms.Label
        Dim lblFiltersLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatabase))
        Me.GamesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.GamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GaloreDataSet = New Lucas_Franklin_Assignment_7.GaloreDataSet()
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
        Me.GamesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtIDTextBox = New System.Windows.Forms.TextBox()
        Me.txtTitleTextBox = New System.Windows.Forms.TextBox()
        Me.txtPlatformTextBox = New System.Windows.Forms.TextBox()
        Me.txtRatingTextBox = New System.Windows.Forms.TextBox()
        Me.txtPriceTextBox = New System.Windows.Forms.TextBox()
        Me.txtNewUsedTextBox = New System.Windows.Forms.TextBox()
        Me.txtQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.lstFilters = New System.Windows.Forms.ListBox()
        Me.GamesTableAdapter = New Lucas_Franklin_Assignment_7.GaloreDataSetTableAdapters.GamesTableAdapter()
        Me.TableAdapterManager = New Lucas_Franklin_Assignment_7.GaloreDataSetTableAdapters.TableAdapterManager()
        lblIDLabel = New System.Windows.Forms.Label()
        lblTitleLabel = New System.Windows.Forms.Label()
        lblPlatformLabel = New System.Windows.Forms.Label()
        lblRatingLabel = New System.Windows.Forms.Label()
        lblPriceLabel = New System.Windows.Forms.Label()
        lblNewUsedLabel = New System.Windows.Forms.Label()
        lblQuantityLabel = New System.Windows.Forms.Label()
        lblFiltersLabel = New System.Windows.Forms.Label()
        CType(Me.GamesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GamesBindingNavigator.SuspendLayout()
        CType(Me.GamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GaloreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIDLabel
        '
        lblIDLabel.AutoSize = True
        lblIDLabel.Location = New System.Drawing.Point(12, 446)
        lblIDLabel.Name = "lblIDLabel"
        lblIDLabel.Size = New System.Drawing.Size(100, 49)
        lblIDLabel.TabIndex = 1
        lblIDLabel.Text = "ID:"
        '
        'lblTitleLabel
        '
        lblTitleLabel.AutoSize = True
        lblTitleLabel.Location = New System.Drawing.Point(12, 508)
        lblTitleLabel.Name = "lblTitleLabel"
        lblTitleLabel.Size = New System.Drawing.Size(178, 49)
        lblTitleLabel.TabIndex = 3
        lblTitleLabel.Text = "Title:"
        '
        'lblPlatformLabel
        '
        lblPlatformLabel.AutoSize = True
        lblPlatformLabel.Location = New System.Drawing.Point(12, 570)
        lblPlatformLabel.Name = "lblPlatformLabel"
        lblPlatformLabel.Size = New System.Drawing.Size(256, 49)
        lblPlatformLabel.TabIndex = 5
        lblPlatformLabel.Text = "Platform:"
        '
        'lblRatingLabel
        '
        lblRatingLabel.AutoSize = True
        lblRatingLabel.Location = New System.Drawing.Point(12, 632)
        lblRatingLabel.Name = "lblRatingLabel"
        lblRatingLabel.Size = New System.Drawing.Size(204, 49)
        lblRatingLabel.TabIndex = 7
        lblRatingLabel.Text = "Rating:"
        '
        'lblPriceLabel
        '
        lblPriceLabel.AutoSize = True
        lblPriceLabel.Location = New System.Drawing.Point(12, 694)
        lblPriceLabel.Name = "lblPriceLabel"
        lblPriceLabel.Size = New System.Drawing.Size(178, 49)
        lblPriceLabel.TabIndex = 9
        lblPriceLabel.Text = "Price:"
        '
        'lblNewUsedLabel
        '
        lblNewUsedLabel.AutoSize = True
        lblNewUsedLabel.Location = New System.Drawing.Point(12, 756)
        lblNewUsedLabel.Name = "lblNewUsedLabel"
        lblNewUsedLabel.Size = New System.Drawing.Size(256, 49)
        lblNewUsedLabel.TabIndex = 11
        lblNewUsedLabel.Text = "New Used:"
        '
        'lblQuantityLabel
        '
        lblQuantityLabel.AutoSize = True
        lblQuantityLabel.Location = New System.Drawing.Point(12, 818)
        lblQuantityLabel.Name = "lblQuantityLabel"
        lblQuantityLabel.Size = New System.Drawing.Size(256, 49)
        lblQuantityLabel.TabIndex = 13
        lblQuantityLabel.Text = "Quantity:"
        '
        'lblFiltersLabel
        '
        lblFiltersLabel.AutoSize = True
        lblFiltersLabel.Location = New System.Drawing.Point(24, 176)
        lblFiltersLabel.Name = "lblFiltersLabel"
        lblFiltersLabel.Size = New System.Drawing.Size(230, 49)
        lblFiltersLabel.TabIndex = 16
        lblFiltersLabel.Text = "Filters:"
        '
        'GamesBindingNavigator
        '
        Me.GamesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GamesBindingNavigator.BindingSource = Me.GamesBindingSource
        Me.GamesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GamesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GamesBindingNavigator.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.GamesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GamesBindingNavigatorSaveItem})
        Me.GamesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GamesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GamesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GamesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GamesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GamesBindingNavigator.Name = "GamesBindingNavigator"
        Me.GamesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GamesBindingNavigator.Size = New System.Drawing.Size(1733, 42)
        Me.GamesBindingNavigator.TabIndex = 0
        Me.GamesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(46, 36)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'GamesBindingSource
        '
        Me.GamesBindingSource.DataMember = "Games"
        Me.GamesBindingSource.DataSource = Me.GaloreDataSet
        '
        'GaloreDataSet
        '
        Me.GaloreDataSet.DataSetName = "GaloreDataSet"
        Me.GaloreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(70, 36)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(46, 36)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(46, 36)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(46, 36)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 42)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 39)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 42)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(46, 36)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(46, 36)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 42)
        '
        'GamesBindingNavigatorSaveItem
        '
        Me.GamesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GamesBindingNavigatorSaveItem.Image = CType(resources.GetObject("GamesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GamesBindingNavigatorSaveItem.Name = "GamesBindingNavigatorSaveItem"
        Me.GamesBindingNavigatorSaveItem.Size = New System.Drawing.Size(46, 36)
        Me.GamesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtIDTextBox
        '
        Me.txtIDTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GamesBindingSource, "ID", True))
        Me.txtIDTextBox.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtIDTextBox.Location = New System.Drawing.Point(274, 443)
        Me.txtIDTextBox.Name = "txtIDTextBox"
        Me.txtIDTextBox.Size = New System.Drawing.Size(1447, 56)
        Me.txtIDTextBox.TabIndex = 2
        '
        'txtTitleTextBox
        '
        Me.txtTitleTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GamesBindingSource, "Title", True))
        Me.txtTitleTextBox.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtTitleTextBox.Location = New System.Drawing.Point(274, 505)
        Me.txtTitleTextBox.Name = "txtTitleTextBox"
        Me.txtTitleTextBox.Size = New System.Drawing.Size(1447, 56)
        Me.txtTitleTextBox.TabIndex = 4
        '
        'txtPlatformTextBox
        '
        Me.txtPlatformTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtPlatformTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GamesBindingSource, "Platform", True))
        Me.txtPlatformTextBox.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtPlatformTextBox.Location = New System.Drawing.Point(274, 567)
        Me.txtPlatformTextBox.Name = "txtPlatformTextBox"
        Me.txtPlatformTextBox.Size = New System.Drawing.Size(1447, 56)
        Me.txtPlatformTextBox.TabIndex = 6
        '
        'txtRatingTextBox
        '
        Me.txtRatingTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtRatingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GamesBindingSource, "Rating", True))
        Me.txtRatingTextBox.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtRatingTextBox.Location = New System.Drawing.Point(274, 629)
        Me.txtRatingTextBox.Name = "txtRatingTextBox"
        Me.txtRatingTextBox.Size = New System.Drawing.Size(1447, 56)
        Me.txtRatingTextBox.TabIndex = 8
        '
        'txtPriceTextBox
        '
        Me.txtPriceTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GamesBindingSource, "Price", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtPriceTextBox.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtPriceTextBox.Location = New System.Drawing.Point(274, 691)
        Me.txtPriceTextBox.Name = "txtPriceTextBox"
        Me.txtPriceTextBox.Size = New System.Drawing.Size(1447, 56)
        Me.txtPriceTextBox.TabIndex = 10
        '
        'txtNewUsedTextBox
        '
        Me.txtNewUsedTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtNewUsedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GamesBindingSource, "NewUsed", True))
        Me.txtNewUsedTextBox.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtNewUsedTextBox.Location = New System.Drawing.Point(274, 753)
        Me.txtNewUsedTextBox.Name = "txtNewUsedTextBox"
        Me.txtNewUsedTextBox.Size = New System.Drawing.Size(1447, 56)
        Me.txtNewUsedTextBox.TabIndex = 12
        '
        'txtQuantityTextBox
        '
        Me.txtQuantityTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GamesBindingSource, "Quantity", True))
        Me.txtQuantityTextBox.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtQuantityTextBox.Location = New System.Drawing.Point(274, 815)
        Me.txtQuantityTextBox.Name = "txtQuantityTextBox"
        Me.txtQuantityTextBox.Size = New System.Drawing.Size(1447, 56)
        Me.txtQuantityTextBox.TabIndex = 14
        '
        'lstFilters
        '
        Me.lstFilters.BackColor = System.Drawing.SystemColors.MenuText
        Me.lstFilters.ForeColor = System.Drawing.Color.ForestGreen
        Me.lstFilters.FormattingEnabled = True
        Me.lstFilters.ItemHeight = 49
        Me.lstFilters.Items.AddRange(New Object() {"1 Games for the Wii", "2 New Games", "3 Used Games", "4 Price is less than $30", "5 Rating is NOT Mature"})
        Me.lstFilters.Location = New System.Drawing.Point(274, 76)
        Me.lstFilters.Name = "lstFilters"
        Me.lstFilters.Size = New System.Drawing.Size(1447, 249)
        Me.lstFilters.TabIndex = 17
        '
        'GamesTableAdapter
        '
        Me.GamesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GamesTableAdapter = Me.GamesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Lucas_Franklin_Assignment_7.GaloreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(26.0!, 49.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.Lucas_Franklin_Assignment_7.My.Resources.Resources.Matrix
        Me.ClientSize = New System.Drawing.Size(1733, 882)
        Me.Controls.Add(Me.lstFilters)
        Me.Controls.Add(lblFiltersLabel)
        Me.Controls.Add(lblIDLabel)
        Me.Controls.Add(Me.txtIDTextBox)
        Me.Controls.Add(lblTitleLabel)
        Me.Controls.Add(Me.txtTitleTextBox)
        Me.Controls.Add(lblPlatformLabel)
        Me.Controls.Add(Me.txtPlatformTextBox)
        Me.Controls.Add(lblRatingLabel)
        Me.Controls.Add(Me.txtRatingTextBox)
        Me.Controls.Add(lblPriceLabel)
        Me.Controls.Add(Me.txtPriceTextBox)
        Me.Controls.Add(lblNewUsedLabel)
        Me.Controls.Add(Me.txtNewUsedTextBox)
        Me.Controls.Add(lblQuantityLabel)
        Me.Controls.Add(Me.txtQuantityTextBox)
        Me.Controls.Add(Me.GamesBindingNavigator)
        Me.Font = New System.Drawing.Font("Courier New", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.ForestGreen
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmDatabase"
        Me.Text = "Databases"
        CType(Me.GamesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GamesBindingNavigator.ResumeLayout(False)
        Me.GamesBindingNavigator.PerformLayout()
        CType(Me.GamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GaloreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GaloreDataSet As GaloreDataSet
    Friend WithEvents GamesBindingSource As BindingSource
    Friend WithEvents GamesTableAdapter As GaloreDataSetTableAdapters.GamesTableAdapter
    Friend WithEvents TableAdapterManager As GaloreDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GamesBindingNavigator As BindingNavigator
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
    Friend WithEvents GamesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtIDTextBox As TextBox
    Friend WithEvents txtTitleTextBox As TextBox
    Friend WithEvents txtPlatformTextBox As TextBox
    Friend WithEvents txtRatingTextBox As TextBox
    Friend WithEvents txtPriceTextBox As TextBox
    Friend WithEvents txtNewUsedTextBox As TextBox
    Friend WithEvents txtQuantityTextBox As TextBox
    Friend WithEvents lstFilters As ListBox
End Class
