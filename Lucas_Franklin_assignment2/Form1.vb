Public Class frmBibleVerse
    Private Sub btnShowVerse_Click(sender As Object, e As EventArgs) Handles btnShowVerse.Click
        'VARIABLES AND DECISIONS PROGAMMING ASSIGNMENT
        'Student - Lucas Franklin
        'The purpose of this assignment is to demonstrate proficiency in Visual Basic

        'I will not use code that was never covered in class or in our textbook. If you do you must be able to explain your code when asked by the professor.
        'Using code outside of the resources provided, it can be flagged and reported as an academic integrity violation if there is any suspicion of copying/cheating.

        'Define Variable
        Static intclickamount As Integer = 0
        'Assign Values
        Dim selectedVerse As String = ""
        Select Case True
            Case radComfort.Checked
                selectedVerse = "God is our refuge and strength, a very present help in trouble. -Psalm 46:1"
            Case radStrength.Checked
                selectedVerse = "Fear not, for I am with you; be not dismayed, for I am your God; I will strengthen you, I will help you, I will uphold you with my righteous right hand. -Isaiah 41:10"
            Case radHope.Checked
                selectedVerse = "For I know the plans I have for you, declares the Lord, plans for welfare and not for evil, to give you a future and a hope. -Jeremiah 29:11"
            Case radPeace.Checked
                selectedVerse = "Peace I leave with you; my peace I give to you. Not as the world gives do I give to you. Let not your hearts be troubled, neither let them be afraid. -John 14:27"
            Case radCompassion.Checked
                selectedVerse = "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life. -John 3:16"
            Case Else
                MessageBox.Show("Please select a verse need.")
                grpVerseNeed.Focus()
                Return
        End Select

        'Calculate
        txtVerse.Text = selectedVerse
        intclickamount += 1
        'Display
        lblCounter.Text = intclickamount
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Cleanup
        txtVerse.Clear()
        radComfort.Checked = False
        radStrength.Checked = False
        radHope.Checked = False
        radPeace.Checked = False
        radCompassion.Checked = False
        lblContact.Visible = False
        chkContact.Checked = False
        lblCounter.Text = 0
    End Sub

    Private Sub chkContact_CheckedChanged(sender As Object, e As EventArgs) Handles chkContact.CheckedChanged
        If chkContact.Checked Then
            lblContact.Visible = True ' Show the label
        Else
            lblContact.Visible = False ' Hide the label
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Cleanup
        Me.Close()
    End Sub
End Class
