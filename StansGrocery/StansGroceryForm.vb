'Alex Wheelock
'RCET 0265
'Spring 2024
'Stan's Grocery
'https://github.com/AlexWheelock/StansGrocery.git

Option Strict On
Option Explicit On
Option Compare Text
Public Class StansGroceryForm

    'List containing all of the product and their corresponding info
    Dim productList As New List(Of String)

    Sub ReadProductInfo()
        Dim products$
        Dim item() As String, location() As String, category() As String, temp() As String

        'Try to open Grocery.txt
        Try
            FileOpen(1, "..\..\Grocery.txt", OpenMode.Input)
        Catch ex As Exception
            MsgBox("Error!!!")
        End Try

        'Write the lines from Grocery.te
        Do Until EOF(1)
            products = LineInput(1)
            temp = Split(products, Chr(34))

            'Clean up the strings that are displayed to the user
            item = Split(temp(1), "$$ITM")
            location = Split(temp(3), "LOC")
            category = Split(temp(5), "%%CAT")

            'Format the products and their info into a string that is added to the list
            'Only adds the item if all information is present
            If item(1) <> "" Then
                If location(1) <> "" Then
                    If category(1) <> "" Then
                        Me.productList.Add($"{item(1)}, Aisle {location(1)}, Category: {category(1)}")
                    End If
                End If
            End If
        Loop
        RefillDisplayListBox()
        FileClose(1)
    End Sub

    Sub RefillDisplayListBox()
        For Each product As String In productList
            DisplayListBox.Items.Add(product)
        Next
    End Sub

    Sub SearchForItem()
        Dim temp() As String
        Dim search As Integer = 0

        If FilterByAisleRadioButton.Checked = True Then
            search = 1
        End If

        If FilterByCategoryRadioButton.Checked = True Then
            search = 2
        End If

        DisplayListBox.Items.Clear()

        For Each matchingProduct As String In productList
            temp = Split(matchingProduct)
            If temp(search).StartsWith(SearchTextBox.Text, StringComparison.CurrentCultureIgnoreCase) Then
                DisplayListBox.Items.Add(matchingProduct)
            End If
        Next

    End Sub

    Sub Display()

    End Sub

    'Event Handlers Below Here



    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadProductInfo()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Dim temp() As String
        Dim search As Integer = 0

        If FilterByAisleRadioButton.Checked = True Then
            search = 1
        End If

        If FilterByCategoryRadioButton.Checked = True Then
            search = 2
        End If

        DisplayListBox.Items.Clear()

        If SearchTextBox.Text <> "" Then
            For Each matchingProduct As String In productList
                temp = Split(matchingProduct)
                If temp(search).StartsWith(SearchTextBox.Text, StringComparison.CurrentCultureIgnoreCase) Then
                    DisplayListBox.Items.Add(matchingProduct)
                End If
            Next
        Else
            RefillDisplayListBox()
        End If
    End Sub

    Private Sub SearchLabel_Click(sender As Object, e As EventArgs) Handles SearchLabel.Click

    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        Display()
    End Sub

    Private Sub FilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterComboBox.SelectedIndexChanged

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchForItem()
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
        SearchForItem()
    End Sub

    Private Sub ExitTopMenuButton_Click(sender As Object, e As EventArgs) Handles ExitTopMenuButton.Click

    End Sub

    Private Sub HelpTopMenuButton_Click(sender As Object, e As EventArgs) Handles HelpTopMenuButton.Click

    End Sub

    Private Sub AboutTopMenuButton_Click(sender As Object, e As EventArgs) Handles AboutTopMenuButton.Click

    End Sub

    Private Sub MainToolTip_Popup(sender As Object, e As PopupEventArgs) Handles MainToolTip.Popup

    End Sub

    Private Sub FilterByItemRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByItemRadioButton.CheckedChanged

    End Sub
End Class
