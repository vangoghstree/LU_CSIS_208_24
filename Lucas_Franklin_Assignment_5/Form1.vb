Imports System.Drawing.Text

Public Class Form1
    'Sequential Access and Files Programming Assignment Week 5
    'Student - Lucas Franklin
    'The purpose of this assignment is to demonstrate proficiency in Visual Basic using files to add and delete records from files, demonstrating how to utilize a menu, and demonstrating the ability to sort records in a file and create files.
    'I will not use code that was never covered in class or in our textbook. If you do you must be able to explain your code when asked by the professor. Using code outside of the resources provided, it can be flagged and reported as an academic integrity violation if there is any suspicion of copying/cheating.

    Dim strfilename As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strloadfilename As String = InputBox("Enter a name of a file to load")
        If strloadfilename <> "" Then
            strfilename = strloadfilename & ".txt"
            If IO.File.Exists(strfilename) Then
                lstMembers.DataSource = IO.File.ReadAllLines(strfilename)
                txtCount.Text = lstMembers.Items.Count()
                lstMembers.SelectedIndex = -1
            Else
                MessageBox.Show("File does not exist.", "Error")
                MessageBox.Show("File not found. Save a member to to this list to create a new file with the selected name or select Create File from the menu.", "Error")
            End If
            'Refresh
            Updatelst()
        Else
            'Error check if no file name is entered
            MessageBox.Show("No file name entered.", "Error")
            Return
        End If
    End Sub
    Private Sub mnuCreateFile_Click(sender As Object, e As EventArgs) Handles mnuCreateFile.Click
        'Get file name
        Dim strnewname As String = InputBox("Enter a name for your new file")
        'error check
        If strnewname = "" Then
            MessageBox.Show("Please enter a valid file name.", "Error")
            Return
        End If
        'Assign global variable
        strfilename = strnewname & ".txt"
        'check if file exists
        If IO.File.Exists(strfilename) Then
            MessageBox.Show("File already exists.", "Error")
            Return
        End If
        'if it doesn't exist then create it
        Dim sw As IO.StreamWriter = IO.File.CreateText(strfilename)
        sw.Close()
        'Display the file
        strfilename = strnewname
        'Refresh
        Updatelst()
    End Sub
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuAscend_Click(sender As Object, e As EventArgs) Handles mnuAscend.Click
        Dim ascendquery = From item In IO.File.ReadAllLines(strfilename)
                          Order By item Ascending
                          Select item

        lstMembers.DataSource = ascendquery.ToList()
    End Sub

    Private Sub mnuDescend_Click(sender As Object, e As EventArgs) Handles mnuDescend.Click
        Dim descendquery = From item In IO.File.ReadAllLines(strfilename)
                           Order By item Descending
                           Select item

        lstMembers.DataSource = descendquery.ToList()
    End Sub

    Private Sub mnuAddMember_Click(sender As Object, e As EventArgs) Handles mnuAddMember.Click
        Dim strnewname As String = InputBox("Enter a new item")
        'Error Checking
        If strnewname = "" Then
            MessageBox.Show("Please enter a valid item name.", "Error")
            Return
        End If
        Dim sw As IO.StreamWriter = IO.File.AppendText(strfilename)
        sw.WriteLine(strnewname)
        sw.Close()
        'Refresh
        Updatelst()
    End Sub

    Private Sub mnuDeleteMember_Click(sender As Object, e As EventArgs) Handles mnuDeleteMember.Click
        'Error Checking:Make sure an item is selected
        If lstMembers.SelectedIndex = -1 Then
            MessageBox.Show("Please select an item first, then try Delete Member again.", "Error")
            Return
        End If
        Dim strdelete As String = lstMembers.SelectedItem

        Dim deletequery = From item In IO.File.ReadAllLines(strfilename)
                          Where item <> strdelete
                          Select item

        IO.File.WriteAllLines(strfilename, deletequery)
        'Refresh
        Updatelst()
    End Sub

    Private Sub Updatelst()
        If IO.File.Exists(strfilename) Then
            lstMembers.DataSource = IO.File.ReadAllLines(strfilename)
            txtCount.Text = lstMembers.Items.Count()
            lstMembers.SelectedIndex = -1
        Else
            Return
        End If
    End Sub
End Class
