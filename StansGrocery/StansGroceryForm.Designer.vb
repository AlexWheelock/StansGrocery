<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StansGroceryForm
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
        Me.components = New System.ComponentModel.Container()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.FilterComboBox = New System.Windows.Forms.ComboBox()
        Me.FilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.FilterByCategoryRadioButton = New System.Windows.Forms.RadioButton()
        Me.FilterByAisleRadioButton = New System.Windows.Forms.RadioButton()
        Me.MainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchContextMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitContextMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileTopMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchTopMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitTopMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.FilterByItemRadioButton = New System.Windows.Forms.RadioButton()
        Me.ItemLabel = New System.Windows.Forms.Label()
        Me.AisleNumberLabel = New System.Windows.Forms.Label()
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.FilterGroupBox.SuspendLayout()
        Me.MainContextMenuStrip.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(79, 36)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(229, 20)
        Me.SearchTextBox.TabIndex = 0
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(29, 39)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(44, 13)
        Me.SearchLabel.TabIndex = 1
        Me.SearchLabel.Text = "Search:"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(314, 34)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(59, 23)
        Me.SearchButton.TabIndex = 2
        Me.SearchButton.Text = "&Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'DisplayListBox
        '
        Me.DisplayListBox.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.Location = New System.Drawing.Point(23, 218)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(363, 212)
        Me.DisplayListBox.Sorted = True
        Me.DisplayListBox.TabIndex = 3
        '
        'FilterComboBox
        '
        Me.FilterComboBox.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterComboBox.FormattingEnabled = True
        Me.FilterComboBox.Location = New System.Drawing.Point(23, 168)
        Me.FilterComboBox.Name = "FilterComboBox"
        Me.FilterComboBox.Size = New System.Drawing.Size(363, 21)
        Me.FilterComboBox.TabIndex = 4
        '
        'FilterGroupBox
        '
        Me.FilterGroupBox.Controls.Add(Me.FilterByItemRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.FilterByCategoryRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.FilterByAisleRadioButton)
        Me.FilterGroupBox.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.FilterGroupBox.Location = New System.Drawing.Point(33, 73)
        Me.FilterGroupBox.Name = "FilterGroupBox"
        Me.FilterGroupBox.Size = New System.Drawing.Size(341, 89)
        Me.FilterGroupBox.TabIndex = 5
        Me.FilterGroupBox.TabStop = False
        Me.FilterGroupBox.Text = "Filter By:"
        '
        'FilterByCategoryRadioButton
        '
        Me.FilterByCategoryRadioButton.AutoSize = True
        Me.FilterByCategoryRadioButton.Location = New System.Drawing.Point(25, 66)
        Me.FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton"
        Me.FilterByCategoryRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.FilterByCategoryRadioButton.TabIndex = 1
        Me.FilterByCategoryRadioButton.Text = "Category"
        Me.FilterByCategoryRadioButton.UseVisualStyleBackColor = True
        '
        'FilterByAisleRadioButton
        '
        Me.FilterByAisleRadioButton.AutoSize = True
        Me.FilterByAisleRadioButton.Location = New System.Drawing.Point(25, 43)
        Me.FilterByAisleRadioButton.Name = "FilterByAisleRadioButton"
        Me.FilterByAisleRadioButton.Size = New System.Drawing.Size(47, 17)
        Me.FilterByAisleRadioButton.TabIndex = 0
        Me.FilterByAisleRadioButton.Text = "Aisle"
        Me.FilterByAisleRadioButton.UseVisualStyleBackColor = True
        '
        'MainContextMenuStrip
        '
        Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchContextMenuButton, Me.ExitContextMenuButton})
        Me.MainContextMenuStrip.Name = "MainContextMenuStrip"
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(110, 48)
        '
        'SearchContextMenuButton
        '
        Me.SearchContextMenuButton.Name = "SearchContextMenuButton"
        Me.SearchContextMenuButton.Size = New System.Drawing.Size(109, 22)
        Me.SearchContextMenuButton.Text = "&Search"
        '
        'ExitContextMenuButton
        '
        Me.ExitContextMenuButton.Name = "ExitContextMenuButton"
        Me.ExitContextMenuButton.Size = New System.Drawing.Size(109, 22)
        Me.ExitContextMenuButton.Text = "E&xit"
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenuButton, Me.HelpTopMenuButton})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(407, 24)
        Me.TopMenuStrip.TabIndex = 7
        Me.TopMenuStrip.Text = "MenuStrip"
        '
        'FileTopMenuButton
        '
        Me.FileTopMenuButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchTopMenuButton, Me.ExitTopMenuButton})
        Me.FileTopMenuButton.Name = "FileTopMenuButton"
        Me.FileTopMenuButton.Size = New System.Drawing.Size(37, 20)
        Me.FileTopMenuButton.Text = "&File"
        '
        'SearchTopMenuButton
        '
        Me.SearchTopMenuButton.Name = "SearchTopMenuButton"
        Me.SearchTopMenuButton.Size = New System.Drawing.Size(109, 22)
        Me.SearchTopMenuButton.Text = "&Search"
        '
        'ExitTopMenuButton
        '
        Me.ExitTopMenuButton.Name = "ExitTopMenuButton"
        Me.ExitTopMenuButton.Size = New System.Drawing.Size(109, 22)
        Me.ExitTopMenuButton.Text = "E&xit"
        '
        'HelpTopMenuButton
        '
        Me.HelpTopMenuButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTopMenuButton})
        Me.HelpTopMenuButton.Name = "HelpTopMenuButton"
        Me.HelpTopMenuButton.Size = New System.Drawing.Size(44, 20)
        Me.HelpTopMenuButton.Text = "&Help"
        '
        'AboutTopMenuButton
        '
        Me.AboutTopMenuButton.Name = "AboutTopMenuButton"
        Me.AboutTopMenuButton.Size = New System.Drawing.Size(107, 22)
        Me.AboutTopMenuButton.Text = "&About"
        '
        'MainToolTip
        '
        '
        'FilterByItemRadioButton
        '
        Me.FilterByItemRadioButton.AutoSize = True
        Me.FilterByItemRadioButton.Checked = True
        Me.FilterByItemRadioButton.Location = New System.Drawing.Point(25, 20)
        Me.FilterByItemRadioButton.Name = "FilterByItemRadioButton"
        Me.FilterByItemRadioButton.Size = New System.Drawing.Size(45, 17)
        Me.FilterByItemRadioButton.TabIndex = 2
        Me.FilterByItemRadioButton.TabStop = True
        Me.FilterByItemRadioButton.Text = "Item"
        Me.FilterByItemRadioButton.UseVisualStyleBackColor = True
        '
        'ItemLabel
        '
        Me.ItemLabel.AutoSize = True
        Me.ItemLabel.Location = New System.Drawing.Point(20, 202)
        Me.ItemLabel.Name = "ItemLabel"
        Me.ItemLabel.Size = New System.Drawing.Size(30, 13)
        Me.ItemLabel.TabIndex = 8
        Me.ItemLabel.Text = "Item:"
        '
        'AisleNumberLabel
        '
        Me.AisleNumberLabel.AutoSize = True
        Me.AisleNumberLabel.Location = New System.Drawing.Point(199, 202)
        Me.AisleNumberLabel.Name = "AisleNumberLabel"
        Me.AisleNumberLabel.Size = New System.Drawing.Size(39, 13)
        Me.AisleNumberLabel.TabIndex = 9
        Me.AisleNumberLabel.Text = "Aisle#:"
        '
        'CategoryLabel
        '
        Me.CategoryLabel.AutoSize = True
        Me.CategoryLabel.Location = New System.Drawing.Point(244, 202)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(52, 13)
        Me.CategoryLabel.TabIndex = 10
        Me.CategoryLabel.Text = "Category:"
        '
        'StansGroceryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 442)
        Me.Controls.Add(Me.CategoryLabel)
        Me.Controls.Add(Me.AisleNumberLabel)
        Me.Controls.Add(Me.ItemLabel)
        Me.Controls.Add(Me.FilterComboBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchLabel)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.FilterGroupBox)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "StansGroceryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stan's Grocery"
        Me.FilterGroupBox.ResumeLayout(False)
        Me.FilterGroupBox.PerformLayout()
        Me.MainContextMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchLabel As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents FilterComboBox As ComboBox
    Friend WithEvents FilterGroupBox As GroupBox
    Friend WithEvents FilterByCategoryRadioButton As RadioButton
    Friend WithEvents FilterByAisleRadioButton As RadioButton
    Friend WithEvents MainContextMenuStrip As ContextMenuStrip
    Friend WithEvents SearchContextMenuButton As ToolStripMenuItem
    Friend WithEvents ExitContextMenuButton As ToolStripMenuItem
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileTopMenuButton As ToolStripMenuItem
    Friend WithEvents SearchTopMenuButton As ToolStripMenuItem
    Friend WithEvents ExitTopMenuButton As ToolStripMenuItem
    Friend WithEvents HelpTopMenuButton As ToolStripMenuItem
    Friend WithEvents AboutTopMenuButton As ToolStripMenuItem
    Friend WithEvents MainToolTip As ToolTip
    Friend WithEvents FilterByItemRadioButton As RadioButton
    Friend WithEvents ItemLabel As Label
    Friend WithEvents AisleNumberLabel As Label
    Friend WithEvents CategoryLabel As Label
End Class
