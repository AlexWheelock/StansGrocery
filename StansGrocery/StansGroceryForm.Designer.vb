﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.NoneRadioButton = New System.Windows.Forms.RadioButton()
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
        Me.DisplayLabel = New System.Windows.Forms.Label()
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
        Me.DisplayListBox.Location = New System.Drawing.Point(417, 39)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(169, 303)
        Me.DisplayListBox.Sorted = True
        Me.DisplayListBox.TabIndex = 3
        '
        'FilterComboBox
        '
        Me.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FilterComboBox.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterComboBox.FormattingEnabled = True
        Me.FilterComboBox.Location = New System.Drawing.Point(11, 89)
        Me.FilterComboBox.Name = "FilterComboBox"
        Me.FilterComboBox.Size = New System.Drawing.Size(363, 21)
        Me.FilterComboBox.Sorted = True
        Me.FilterComboBox.TabIndex = 4
        '
        'FilterGroupBox
        '
        Me.FilterGroupBox.Controls.Add(Me.NoneRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.FilterByCategoryRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.FilterByAisleRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.FilterComboBox)
        Me.FilterGroupBox.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.FilterGroupBox.Location = New System.Drawing.Point(12, 73)
        Me.FilterGroupBox.Name = "FilterGroupBox"
        Me.FilterGroupBox.Size = New System.Drawing.Size(383, 117)
        Me.FilterGroupBox.TabIndex = 5
        Me.FilterGroupBox.TabStop = False
        Me.FilterGroupBox.Text = "Filter By:"
        '
        'NoneRadioButton
        '
        Me.NoneRadioButton.AutoSize = True
        Me.NoneRadioButton.Checked = True
        Me.NoneRadioButton.Location = New System.Drawing.Point(25, 20)
        Me.NoneRadioButton.Name = "NoneRadioButton"
        Me.NoneRadioButton.Size = New System.Drawing.Size(51, 17)
        Me.NoneRadioButton.TabIndex = 2
        Me.NoneRadioButton.TabStop = True
        Me.NoneRadioButton.Text = "None"
        Me.NoneRadioButton.UseVisualStyleBackColor = True
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
        Me.TopMenuStrip.Size = New System.Drawing.Size(598, 24)
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
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Location = New System.Drawing.Point(20, 216)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(58, 13)
        Me.DisplayLabel.TabIndex = 5
        Me.DisplayLabel.Text = "Blank Text"
        '
        'StansGroceryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 352)
        Me.Controls.Add(Me.DisplayLabel)
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
    Friend WithEvents NoneRadioButton As RadioButton
    Friend WithEvents DisplayLabel As Label
End Class
