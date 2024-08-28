Public Class frmDatabase
    'Database Programming Assignment Week 7
    'Student - Lucas Franklin
    'The purpose of this assignment is to demonstrate proficiency in Visual Basic using databases
    'I will not use code that was never covered in class or in our textbook. If you do you must be able to explain your code when asked by the professor. Using code outside of the resources provided, it can be flagged and reported as an academic integrity violation if there is any suspicion of copying/cheating.
    Private Sub GamesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GamesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.GamesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.GaloreDataSet)
            MessageBox.Show("Changes Saved.", "Data Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub frmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GaloreDataSet.Games' table. You can move, or remove it, as needed.
        Me.GamesTableAdapter.Fill(Me.GaloreDataSet.Games)
        'Set listbox to not have a selection
        lstFilters.SelectedItem = -1
    End Sub

    Private Sub lstFilters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFilters.SelectedIndexChanged
        'Assign a variable for the selected filter
        Dim selectedFilter As String = lstFilters.SelectedItem.ToString()
        'Select Case to load the selected filter
        Select Case selectedFilter
            Case "1 Games for the Wii"
                'Load for Filter 1
                Me.GamesTableAdapter.FillByPlatformWII(Me.GaloreDataSet.Games)
            Case "2 New Games"
                'Load for Filter 2
                Me.GamesTableAdapter.FillByNEW(Me.GaloreDataSet.Games)
            Case "3 Used Games"
                'Load for Filter 3
                Me.GamesTableAdapter.FillByUSED(Me.GaloreDataSet.Games)
            Case "4 Price is less than $30"
                'Load for Filter 4
                Me.GamesTableAdapter.FillByPriceLess30(Me.GaloreDataSet.Games)
            Case "5 Rating is NOT Mature"
                'Load for Filter 5
                Me.GamesTableAdapter.FillByRatingNOTMature(Me.GaloreDataSet.Games)
        End Select
    End Sub
End Class