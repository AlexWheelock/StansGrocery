﻿'Alex Wheelock
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
                        Me.productList.Add(($"{item(1)},").PadRight(28) & ($"{location(1)},").PadRight(6) & ($"{category(1)}"))
                    End If
                End If
            End If
        Loop
        RefillDisplayListBox()
        UpdateComboBox()
        FileClose(1)
    End Sub

    Sub RefillDisplayListBox()
        Dim temp() As String

        For Each product As String In productList
            temp = Split(product, ",")
            DisplayListBox.Items.Add(temp(0))
        Next
    End Sub

    Sub UpdateComboBox()
        Dim temp() As String
        Dim filter As Integer = 0
        Dim tempList As New List(Of Integer)

        FilterComboBox.Text = ""
        FilterComboBox.Items.Clear()

        If NoneRadioButton.Checked = True Then
            filter = 0
        Else
            If FilterByAisleRadioButton.Checked = True Then
                filter = 1
            Else
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
                FilterComboBox.Sorted = False
                FilterComboBox.Items.Add(CStr(0))
                For aisle = 2 To 17
                    FilterComboBox.Items.Add(CStr(aisle))
                Next
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

        If SearchTextBox.Text <> "" Then
            For Each matchingProduct As String In productList
                temp = Split(matchingProduct)
                If temp(search).StartsWith(SearchTextBox.Text, StringComparison.CurrentCultureIgnoreCase) Then
                    DisplayListBox.Items.Add(temp(0))
                End If
            Next
        Else
            RefillDisplayListBox()
            UpdateComboBox()
        End If

        If DisplayListBox.Items.Count = 0 Then
            DisplayLabel.Text = $"Sorry, there were no matches for {SearchTextBox.Text}"
        End If

    End Sub

    Sub DisplaySelectedListBoxItem()

        For Each matchingIndex As String In productList
            If matchingIndex.StartsWith(DisplayListBox.SelectedItem.ToString()) Then
                FilterComboBox.Text = matchingIndex
            End If
        Next

    End Sub

    'Event Handlers Below Here


    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadProductInfo()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        SearchForItem()
        If SearchTextBox.Text = "zzz" Then
            Me.Close()
        End If
    End Sub

    Private Sub SearchLabel_Click(sender As Object, e As EventArgs) Handles SearchLabel.Click

    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        DisplaySelectedListBoxItem()
    End Sub

    Private Sub FilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterComboBox.SelectedIndexChanged

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchForItem()
    End Sub

    Private Sub FilterGroupBox_Enter(sender As Object, e As EventArgs) Handles FilterGroupBox.Enter

    End Sub

    Private Sub FilterByAisleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadioButton.CheckedChanged
        UpdateComboBox()
    End Sub

    Private Sub FilterByCategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByCategoryRadioButton.CheckedChanged
        UpdateComboBox()
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

    Private Sub NoneRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles NoneRadioButton.CheckedChanged
        UpdateComboBox()
    End Sub

End Class
