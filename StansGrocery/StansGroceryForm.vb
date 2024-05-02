'Alex Wheelock
'RCET 0265
'Spring 2024
'Stan's Grocery
'https://github.com/AlexWheelock/StansGrocery.git

Option Strict On
Option Explicit On
Option Compare Text
Imports System.CodeDom.Compiler

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

        'Write the lines from Grocery.txt file
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
                        Me.productList.Add(($"{item(1)},").PadRight(28) & ($"{location(1)},").PadRight(6) & ($"{category(1)}"))
                    End If
                End If
            End If
        Loop
        'closes the file, fills the DisplayListBox and FilterComboBox with the products in productList
        FileClose(1)
        RefillDisplayListBox()
        UpdateComboBox()
    End Sub

    'Fills DisplayListBox with each item, and only the item
    Sub RefillDisplayListBox()
        Dim temp() As String

        DisplayListBox.Items.Clear()

        For Each product As String In productList
            temp = Split(product, ",")
            If Not DisplayListBox.Items.Contains(temp(0)) Then
                DisplayListBox.Items.Add(temp(0))
            End If
        Next
    End Sub

    'Updates FilterComboBox with items needed to be included
    Sub UpdateComboBox()
        Dim temp() As String
        Dim filter As Integer = 0
        Dim tempList As New List(Of Integer)
        Dim count As Integer = 0
        Dim selectIndex As Boolean = False

        FilterComboBox.Text = ""
        FilterComboBox.Items.Clear()

        'NoneRadioButton makes the combobox be filled with each item, and its aisle and category
        If NoneRadioButton.Checked = True Then
            filter = 0
        Else
            'AisleRadioButton makes the combobox be filled with only the aisle numbers in descending order
            If FilterByAisleRadioButton.Checked = True Then
                filter = 1
            Else
                'CategoryRadioButton makes the combobox be filled with only the categories
                If FilterByCategoryRadioButton.Checked = True Then
                    filter = 2
                End If
            End If
        End If

        If filter = 0 Then
            FilterComboBox.Sorted = True
            For Each filteredItem As String In productList
                FilterComboBox.Items.Add(filteredItem)
            Next
        Else
            If filter = 1 Then
                'It is not sorted when filtered by aisle, since the sorted list will be in an incorrect order
                FilterComboBox.Sorted = False

                For aisle = 17 To 2 Step -1
                    FilterComboBox.Items.Add(CStr(aisle))
                Next
                FilterComboBox.Items.Add(CStr(0))
            Else
                FilterComboBox.Sorted = True
                For Each filteredItem As String In productList
                    temp = Split(filteredItem, ",")
                    If Not FilterComboBox.Items.Contains((temp(filter)).TrimStart) Then
                        FilterComboBox.Items.Add((temp(filter)).TrimStart)
                    End If
                Next
            End If
        End If
    End Sub

    'Searches through productList for items matching SearchTextBox.text
    Sub SearchForItem()
        Dim temp() As String

        DisplayListBox.Items.Clear()
        NoneRadioButton.Checked = True

        If SearchTextBox.Text <> "" Then
            For Each matchingProduct As String In productList
                temp = Split(matchingProduct, ",")
                If temp(0).StartsWith(SearchTextBox.Text, StringComparison.CurrentCultureIgnoreCase) Then
                    DisplayListBox.Items.Add(temp(0))
                End If
            Next
            'Determines whether or not there were matches
            If DisplayListBox.Items.Count = 0 Then
                UpdateDisplayLabel(True, False)
            Else
                DisplayListBox.SelectedIndex = 0
                UpdateDisplayLabel(True, True, False)
            End If
        Else
            'No matches found, reset and state that there are no matches
            RefillDisplayListBox()
            UpdateComboBox()
            DisplayLabel.Text = "Please enter a product name to search for"
        End If
    End Sub

    'Determines the filter, based on the selected radiobutton
    Sub SelectedAisleOrCategory()
        Dim temp() As String
        Dim filter As Integer = 0

        If FilterByAisleRadioButton.Checked = True Then
            filter = 1
        End If

        If FilterByCategoryRadioButton.Checked = True Then
            filter = 2
        End If

        If filter = 0 Then
        Else
            'A filter is selected, display only the items of the selected filter
            DisplayListBox.Items.Clear()

            For Each matchingFilter As String In productList
                temp = Split(matchingFilter, ",")
                If temp(filter).TrimStart.StartsWith(CStr(FilterComboBox.SelectedItem)) Then
                    DisplayListBox.Items.Add(temp(0))
                End If
            Next
        End If
    End Sub

    'Updates DisplayLabel
    Sub UpdateDisplayLabel(search As Boolean, Optional goodSearch As Boolean = False, Optional displayBox As Boolean = False)
        Dim temp() As String

        DisplayLabel.Visible = True
        DisplayLabel.Text = ""

        'Determines whether or not it is updating from a changed SelectedIndex from the DisplayListbox or FilterComboBox, or from a search
        If search Then
            If goodSearch Then
                temp = Split(FilterComboBox.Text, ",")
                DisplayLabel.Text = $"{temp(0).TrimStart} is on Aisle #{temp(1).TrimStart}, in the {temp(2).TrimStart} section"
            Else
                If DisplayLabel.Text = "" Then
                    DisplayLabel.Text = $"Sorry, there were no matches for {Chr(34)}{SearchTextBox.Text}{Chr(34)}"
                End If
            End If
        Else
            'Updating from a changed selectedindex
            If displayBox Then
                For Each matchingProduct As String In productList
                    temp = Split(matchingProduct, ",")
                    If temp(0).StartsWith(CStr(DisplayListBox.SelectedItem)) Then
                        DisplayLabel.Text = $"{temp(0).TrimStart} is on Aisle #{temp(1).TrimStart}, in the {temp(2).TrimStart} section"
                    End If
                Next
            Else
                temp = Split(FilterComboBox.Text, ",")
                DisplayLabel.Text = $"{temp(0).TrimStart} is on Aisle #{temp(1).TrimStart}, in the {temp(2).TrimStart} section"
            End If
        End If
    End Sub

    'The text for the msgbox that pops-up when the about button is pressed
    Sub AboutForm()
        MsgBox($"Welcome to Stan's Grocery!" & vbCrLf _
               & vbCrLf _
               & "Here at Stan's Grocery, we not only have the best employees and freshest produce, but we also have the best Windows Form. To get started, you can search for a product name, and click the search button to find the location and category of the product that you are looking for. You can also scroll through the full list of products available using the list-box on the right-hand side of the form, or by using the drop-down combo-box. If you wish to view individual categories, or aisles; you may do so using by selecting the corresponding aisle and category radio buttons, and scrolling through the combo-box. When you select an item from either the combo-box or the list-box, the product name, aisle #, and category will be displayed. To exit this form, you may click the exit button in either the top menu strip under " & {Chr(34)} & "file" & {Chr(34)} & ", the context menu, or by typing " & {Chr(34)} & "zzz" & {Chr(34)} & " into the search bar.")
    End Sub


    'Event Handlers Below This Point==========================================================================================================================================================================================================


    'Loads the product information from the Grocery.Txt file upon starting the form
    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadProductInfo()
    End Sub

    'Closes the form when "zzz" is typed into SearchTextBox
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text = "zzz" Then
            Me.Close()
        End If
    End Sub

    'Determines whether or not it should update the SelectedIndex of DisplayListBox, or simply update the filter for the DisplayListBox based on the selected aisle or category
    Private Sub FilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterComboBox.SelectedIndexChanged
        If NoneRadioButton.Checked Then
            SearchTextBox.Text = ""
            RefillDisplayListBox()
            DisplayListBox.SelectedIndex = FilterComboBox.SelectedIndex
        Else
            SelectedAisleOrCategory()
        End If
    End Sub

    'Searches for the item corresponding to SearchTextBox.text in productList
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchForItem()
    End Sub

    'When the FilterByAisleRadioButton is selected, it updates FilterComboBox drop-down contents
    Private Sub FilterByAisleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadioButton.CheckedChanged
        UpdateComboBox()
        RefillDisplayListBox()
    End Sub

    'When the FilterByCategoryRadioButton is selected, it updates FilterComboBox drop-down contents
    Private Sub FilterByCategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByCategoryRadioButton.CheckedChanged
        UpdateComboBox()
        RefillDisplayListBox()
    End Sub

    'Searches for item in SearchTextBox
    'Search button in the context menu
    Private Sub SearchContextMenuButton_Click(sender As Object, e As EventArgs) Handles SearchContextMenuButton.Click
        SearchForItem()
    End Sub

    'Closes the form
    'Exit button in the context menu
    Private Sub ExitContextMenuButton_Click(sender As Object, e As EventArgs) Handles ExitContextMenuButton.Click
        Me.Close()
    End Sub

    'Searches for item in SearchTextBox
    'Search button in the top menu strip
    Private Sub SearchTopMenuButton_Click(sender As Object, e As EventArgs) Handles SearchTopMenuButton.Click
        SearchForItem()
    End Sub

    'Closes the form
    'Exit button the top menu strip
    Private Sub ExitTopMenuButton_Click(sender As Object, e As EventArgs) Handles ExitTopMenuButton.Click
        Me.Close()
    End Sub

    'Displays a message box with information on the form 
    'Located in the top menu strip
    Private Sub AboutTopMenuButton_Click(sender As Object, e As EventArgs) Handles AboutTopMenuButton.Click
        AboutForm()
    End Sub

    'When the NoneCategoryRadioButton is selected, it updates FilterComboBox drop-down contents
    Private Sub NoneRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles NoneRadioButton.CheckedChanged
        UpdateComboBox()
        RefillDisplayListBox()
    End Sub

    'If there is no filter and the SelectedIndex of the DisplayListBox changes, then it determines the index of FilterComboBox that matches
    'the DisplayListBox selected item. This had to be done in order for it to work at all times, when the indexes were different, such as a search.
    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        Dim index As Integer = 0
        Dim temp() As String
        If NoneRadioButton.Checked Then
            temp = Split(CStr(DisplayListBox.SelectedItem))
            index = FilterComboBox.FindString(temp(0))
            If index <> -1 Then
                FilterComboBox.SelectedIndex = index
            End If
        End If
        UpdateDisplayLabel(False, False, True)
    End Sub
End Class
