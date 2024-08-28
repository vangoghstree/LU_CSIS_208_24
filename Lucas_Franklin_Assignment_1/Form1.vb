Public Class frmAssignment1
    'CONTROLS AND EVENTS PROGRAMMING ASSIGNMENT Week 1
    'The purpose of this assignment is to demonstrate basic proficiency in Visual Basic to use as a foundation for the rest of this  CSIS 208 course. The core objects used are pictures, textboxes, & labels.
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Update button changes txt.Core on push
        txtCore.Text = "I will not use code that was never covered in class or in our textbook. If you
do you must be able to explain your code when asked by the professor. Using code
outside of the resources provided, it can be flagged and reported as an academic
integrity violation if there is any suspicion of copying/cheating."
        'Update button changes frmAssignment1's Background Color
        'I originally tried to use "frmAssignment1.BackColor = Color.Bisque" but the error list recomended replacing the form name with "Me"
        Me.BackColor = Color.Bisque
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Quit button closes the application
        Close()
    End Sub

    Private Sub frmAssignment1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
