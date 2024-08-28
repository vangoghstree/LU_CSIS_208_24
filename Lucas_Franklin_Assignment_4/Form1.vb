Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmVolunteerCalculator
    'String Manipulation And Arrays Programming Assignment Week 4
    'Student - Lucas Franklin
    'The purpose of this assignment is to demonstrate proficiency in Visual Basic using string manipulation and arrays
    'I will not use code that was never covered in class or in our textbook. If you do you must be able to explain your code when asked by the professor. Using code outside of the resources provided, it can be flagged and reported as an academic integrity violation if there is any suspicion of copying/cheating.
    Private Sub frmVolunteerCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Define Variables
        Static missionHours(4) As Integer
        'Define the array values using the label titles entered into the design of the form
        Dim missionNames() As String =
            {lblMission1Title.Text,
            lblMission2Title.Text,
            lblMission3Title.Text,
            lblMission4Title.Text}

        'Cleanup
        'Clear the donation totals listbox:
        lstTotals.Items.Clear()
        'Load in Mission names to the list Missions box:
        For i As Integer = 0 To (missionNames.Count - 1)
            lstMissions.Items.Add(missionNames(i))
        Next
        'Define the date and your name
        Dim strDateofHoursDonated As String =
            InputBox("Please enter the date that the hours are being recorded on", "Date")
        Dim strNameofPersonRecordingHours As String =
            InputBox("Please enter the name of the person recording the hours on: " & strDateofHoursDonated, "Name")
        lstTotals.Items.Add("Mission Hours Recording for Date of: " & strDateofHoursDonated)
        lstTotals.Items.Add("Recorded by: " & strNameofPersonRecordingHours)

    End Sub



    Private Sub btnAddVolunteerHours_Click(sender As Object, e As EventArgs) Handles btnAddVolunteerHours.Click
        Dim strLastName As String
        Dim inthoursadded As Integer
        Static missionHours(4) As Integer

        ' Parse the entered hours to the inthoursadded variable
        If Not Integer.TryParse(txthoursworked.Text, inthoursadded) Then
            ' If the entered hours are not a valid number, display an error message and return
            MessageBox.Show("Please enter a valid number of hours.", "Error")
            Return
        End If

        If lstMissions.SelectedIndex = -1 Then
            ' If no mission is selected, display an error message and return
            MessageBox.Show("Please select a mission from the mission options.", "Error")
            Return
        End If

        Select Case lstMissions.SelectedIndex
            Case 0
                missionHours(0) += inthoursadded
            Case 1
                missionHours(1) += inthoursadded
            Case 2
                missionHours(2) += inthoursadded
            Case 3
                missionHours(3) += inthoursadded
            Case Else
                ' If no mission is selected, display an error message and return
                MessageBox.Show("Please select a mission from the mission options.", "Error")
                Return
        End Select

        Dim missionName As String = lstMissions.SelectedItem.ToString()
        Dim lastName As String = getLastName(strLastName)

        lstTotals.Items.Add(lastName & ": " & inthoursadded.ToString() & " hours for " & missionName)


        lblMission1.Text = missionHours(0)
        lblMission2.Text = missionHours(1)
        lblMission3.Text = missionHours(2)
        lblMission4.Text = missionHours(3)

        'Cleanup
        txthoursworked.Text = ""
        lstMissions.ClearSelected()
    End Sub
    Private Function getLastName(ByVal strLastName As String) As String
        Dim strname As String = InputBox("Please enter the volunteer's name", "Volunteer Name")
        'Last Name substring
        'Grab the position of the "space" in between the First and Last Name
        Dim intindexsub As Integer = strname.IndexOf(" ")
        'Display from after the space the end of the input from the box:
        Dim strNamesubstring As String = strname.Substring(intindexsub + 1)
        Return strNamesubstring
    End Function
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the application
        Me.Close()
    End Sub
End Class