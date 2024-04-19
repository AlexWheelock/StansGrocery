'Alex Wheelock
'RCET 0265
'Spring 2024
'Stan's Grocery
'https://github.com/AlexWheelock/StansGrocery.git

Option Strict On
Option Explicit On

Public Class StansGroceryForm

    Sub ReadProductInfo()
        Dim products$, temp$

        Try
            FileOpen(1, "..\..\Grocery.txt", OpenMode.Input)

            Do Until EOF(1)
                For i = 1 To 10
                    Input(1, products)
                    temp &= products & ","
                    DisplayListBox.Items.Add(temp)
                Next

            Loop

            FileClose(1)
        Catch ex As Exception
            MsgBox("Error!!!")
        End Try

    End Sub


    'Event Handlers Below Here


    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadProductInfo()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

    End Sub

    Private Sub SearchLabel_Click(sender As Object, e As EventArgs) Handles SearchLabel.Click

    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged

    End Sub

    Private Sub FilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterComboBox.SelectedIndexChanged

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

    End Sub

    Private Sub FilterGroupBox_Enter(sender As Object, e As EventArgs) Handles FilterGroupBox.Enter

    End Sub

    Private Sub FilterByAisleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadioButton.CheckedChanged

    End Sub

    Private Sub FilterByCategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByCategoryRadioButton.CheckedChanged

    End Sub

    Private Sub MainContextMenuStrip_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MainContextMenuStrip.Opening

    End Sub

    Private Sub SearchContextMenuButton_Click(sender As Object, e As EventArgs) Handles SearchContextMenuButton.Click

    End Sub

    Private Sub ExitContextMenuButton_Click(sender As Object, e As EventArgs) Handles ExitContextMenuButton.Click

    End Sub

    Private Sub TopMenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles TopMenuStrip.ItemClicked

    End Sub

    Private Sub FileTopMenuButton_Click(sender As Object, e As EventArgs) Handles FileTopMenuButton.Click

    End Sub

    Private Sub SearchTopMenuButton_Click(sender As Object, e As EventArgs) Handles SearchTopMenuButton.Click

    End Sub

    Private Sub ExitTopMenuButton_Click(sender As Object, e As EventArgs) Handles ExitTopMenuButton.Click

    End Sub

    Private Sub HelpTopMenuButton_Click(sender As Object, e As EventArgs) Handles HelpTopMenuButton.Click

    End Sub

    Private Sub AboutTopMenuButton_Click(sender As Object, e As EventArgs) Handles AboutTopMenuButton.Click

    End Sub

    Private Sub MainToolTip_Popup(sender As Object, e As PopupEventArgs) Handles MainToolTip.Popup

    End Sub
End Class
