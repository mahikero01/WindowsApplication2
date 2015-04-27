Public Class Form1
    Private strFriends(4) As String

    Private Sub lstFriends_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFriends.SelectedIndexChanged

    End Sub

    Private Sub btnArrayElement_Click(sender As Object, e As EventArgs) Handles btnArrayElement.Click
        ClearList()

        Dim strFriends(4) As String

        strFriends(0) = "Wendy"
        strFriends(1) = "Harriet"
        strFriends(2) = "Jay"
        strFriends(3) = "Michelle"
        strFriends(4) = "Richard"

        lstFriends.Items.Add(strFriends(0))

    End Sub

    Private Sub ClearList()
        lstFriends.Items.Clear()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strFriends(0) = "Wendy"
        strFriends(1) = "Harriet"
        strFriends(2) = "Jay"
        strFriends(3) = "Michelle"
        strFriends(4) = "Richard"
    End Sub

    Private Sub btnEnumerateArray_Click(sender As Object, e As EventArgs) Handles btnEnumerateArray.Click
        ClearList()

        For Each strName As String In strFriends
            lstFriends.Items.Add(strName)
        Next
    End Sub

    Private Sub btnArrayAsParameters_Click(sender As Object, e As EventArgs) Handles btnArrayAsParameters.Click
        ClearList()
        AddItemsToList(strFriends)
    End Sub

    Private Sub AddItemsToList(ByVal arrayList() As String)
        For Each strName As String In arrayList
            lstFriends.Items.Add("[" & strName & "]")
        Next
    End Sub

    Private Sub btnMoreArrayParameters_Click(sender As Object, e As EventArgs) Handles btnMoreArrayParameters.Click
        'Clear the list
        ClearList()
        'Declare an array
        Dim strMoreFriends(1) As String
        'Populate the array
        strMoreFriends(0) = "Elaine"
        strMoreFriends(1) = "Debra"
        'List your friends
        AddItemsToList(strFriends)
        AddItemsToList(strMoreFriends)
    End Sub

    Private Sub btnSortarrays_Click(sender As Object, e As EventArgs) Handles btnSortarrays.Click
        ClearList()
        Array.Sort(strFriends)
        AddItemsToList(strFriends)
    End Sub

    
    Private Sub btnReversingAnArray_Click(sender As Object, e As EventArgs) Handles btnReversingAnArray.Click
        ClearList()
        Array.Reverse(strFriends)
        AddItemsToList(strFriends)
    End Sub

    Private Sub btnInitializingArraysWithValues_Click(sender As Object, e As EventArgs) Handles btnInitializingArraysWithValues.Click
        ClearList()
        Dim strMyFriends() As String = {"Elaine", "Richard", "Debra", "Wendy", "Harrier"}

        ReDim Preserve strMyFriends(6)
        strMyFriends(5) = "Lane"
        strMyFriends(6) = "Joel"
        AddItemsToList(strMyFriends)



    End Sub
End Class
