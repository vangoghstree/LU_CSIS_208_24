Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmVolunteerCalculator
    'Student - Lucas Franklin
    'The purpose of this assignment is to demonstrate proficiency in Visual Basic using combo boxes, listboxes, subs, and Functions 
    'I will not use code that was never covered in class or in our textbook. If you do you must be able to explain your code when asked by the professor. Using code outside of the resources provided, it can be flagged and reported as an academic integrity violation if there is any suspicion of copying/cheating.

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Define Variables
        Dim intnumvolunteers, intnumpeopleserved, intmealcost, inttotalcost As Integer
        Dim discount As Decimal = 0.1
        Dim strmealtime, strvolunteername As String
        'Error Checking 
        If txtNumberofPeopleServed.Text = "" Then
            'messagebox
            MessageBox.Show("Please select a number of people served.")
            'focus
            txtNumberofPeopleServed.Focus()
            Return
        End If

        If txtNumberofVolunteers.Text = "" Then
            'messagebox
            MessageBox.Show("Please select a number of volunteers.")
            'focus
            txtNumberofVolunteers.Focus()
            Return
        End If

        If cboBox.SelectedIndex = -1 Then
            'messagebox
            MessageBox.Show("Please select a meal time.")
            Return
        End If
        'Assign Values
        strmealtime = cboBox.SelectedItem()
        Integer.TryParse(txtNumberofPeopleServed.Text, intnumpeopleserved)

        intmealcost = getMealCost(strmealtime)
        Integer.TryParse(txtNumberofVolunteers.Text, intnumvolunteers)
        inttotalcost = intmealcost * intnumpeopleserved
        'got an error code BC42104 'strvolunteername' is used before it has been assigned a value. A null reference exception could result at runtime.
        'so I added this:
        strvolunteername = ""

        'Apply discount to total cost if numpeopleserved is greater than 10
        If intnumpeopleserved > 10 Then
            inttotalcost *= (1 - discount)
        End If
        'Display
        lstDisplay.Items.Clear() 'Cleanup
        lstDisplay.Items.Add("Serving Time: " & strmealtime)
        lstDisplay.Items.Add("Cost per person: " & intmealcost.ToString("C"))
        lstDisplay.Items.Add("Discount: " & If(intnumpeopleserved > 10, "Yes (10%)", "No, party under 10 persons"))
        lstDisplay.Items.Add("Total cost: " & inttotalcost.ToString("C"))
        lstDisplay.Items.Add("Number of people served: " & intnumpeopleserved.ToString())
        displayNames(strvolunteername)
    End Sub
    'Sub to loop the textbox display to enter the volunteer name(s)
    Sub displayNames(ByVal strName As String)
        Dim intnumvolunteers As Integer
        Integer.TryParse(txtNumberofVolunteers.Text, intnumvolunteers)
        For i As Integer = 1 To intnumvolunteers
            Dim strvolunteerName As String = InputBox("Enter the name of volunteer #" & i & ":", "Volunteer Name")
            lstDisplay.Items.Add("Volunteer #" & i & ": " & strvolunteerName)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Cleanup
        cboBox.SelectedIndex = -1
        txtNumberofPeopleServed.Text = ""
        txtNumberofVolunteers.Text = ""
        lstDisplay.Items.Clear()
    End Sub

    Private Function getMealCost(ByVal strmealtime As String) As Integer
        'Determine the cost of each meal according to serving time
        Dim intmealcost
        Select Case strmealtime
            Case "Breakfast"
                intmealcost = 7.0
            Case "Lunch"
                intmealcost = 16.0
            Case "Dinner"
                intmealcost = 22.0
            Case Else
                intmealcost = 0.0
        End Select
        Return intmealcost
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the application
        Me.Close()
    End Sub
End Class