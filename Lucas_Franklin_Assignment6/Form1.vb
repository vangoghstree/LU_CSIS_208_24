Public Class frmBudgetCalculator
    'Classes and Objects Programming Assignment Week 6
    'Student - Lucas Franklin
    'The purpose of this assignment is to demonstrate proficiency in Visual Basic to implement a budget application.
    'I will Not use code that was never covered in class Or in our textbook. If you do you must be able To explain your code When asked by the professor. Using code outside of the resources provided, it can be flagged And reported as an academic integrity violation If there Is any suspicion Of copying/cheating.

    'Call Calculator class to manage the budget calculations.
    Dim budget As New Calculator()
    Private Sub frmBudgetCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Assign variable to store the initial balance entered by the user.
        Dim initialBalance As Decimal
        'Prompt the user to enter the starting balance and continue prompting until a valid value is entered.
        Do
            Dim input As String = InputBox("Enter the starting balance for your Account:", "Starting Balance")
            If input = "" Then
                MessageBox.Show("Please enter a valid starting balance.")
                txtAmount.Focus()
            Else
                If Decimal.TryParse(input, initialBalance) Then
                    Exit Do
                Else
                    MessageBox.Show("Please enter a valid starting balance.")
                    txtAmount.Focus()
                End If
            End If
        Loop
        'Set the initial balance in the Calculator
        budget.SetBalance(initialBalance)
        'Display InitialBalance in the balance text box.
        txtTotal.Text = initialBalance.ToString("C")
        'Display Starting Text in the listboxes
        lstExpenses.Items.Add("---Current Month Expenses---")
        lstIncome.Items.Add("---Current Month Income---")
    End Sub

    Private Sub btnEnterIncome_Click(sender As Object, e As EventArgs) Handles btnEnterIncome.Click
        'Variable to store the income amount.
        Dim amount As Decimal
        'Check if the amount entered is a valid decimal value.
        If Decimal.TryParse(txtAmount.Text, amount) Then
            'Prompt the user to enter a description for the income.
            Dim description As String
            'Error check: Loop until a description is entered.
            Do
                description = InputBox("Enter the description for the income:", "Income Description")
                If String.IsNullOrEmpty(description) Then
                    MessageBox.Show("Please enter a valid description.", "Error")
                End If
            Loop While String.IsNullOrEmpty(description)
            'Add the income to the balance in the Calculator class.
            budget.AddIncome(amount, description)
            'Update the balance text box with the new balance.
            txtTotal.Text = budget.GetBalance().ToString("C")
            'Display a message to the user confirming the income recorded.
            MessageBox.Show($"Income of {amount.ToString("C")} recorded for {description}.")
            'Display the value with the description to the listbox
            lstIncome.Items.Add(Decimal.Parse(txtAmount.Text).ToString("C") & ": " & description)
            'Error check; If the account is negative give an error message then continue
            If budget.GetBalance() < 0 Then
                MessageBox.Show("Account total is negative.")
            End If
            'Clear the amount text box.
            txtAmount.Clear()
        Else
            'Display an error message if the amount entered is not valid.
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub

    Private Sub btnEnterExpenses_Click(sender As Object, e As EventArgs) Handles btnEnterExpenses.Click
        'Variable to store the income amount.
        Dim amount As Decimal
        'Check if the amount entered is a valid decimal value.
        If Decimal.TryParse(txtAmount.Text, amount) Then
            'Prompt the user to enter a description for the income.
            Dim description As String
            'Error check: Loop until a description is entered.
            Do
                description = InputBox("Enter the description for the income:", "Expense Description")
                If String.IsNullOrEmpty(description) Then
                    MessageBox.Show("Please enter a valid description.", "Error")
                End If
            Loop While String.IsNullOrEmpty(description)
            'Calculate the balance after subtracting the expense.
            Dim balanceAfterExpense As Decimal = budget.GetBalance() - amount
            'Subtract the expense from the balance in the Calculator class.
            budget.SubtractExpense(amount, description)
            'Update the balance text box with the new balance.
            txtTotal.Text = budget.GetBalance().ToString("C")
            'Display a message to the user confirming the expense recorded.
            MessageBox.Show($"Expense of {amount.ToString("C")} recorded for {description}.")
            'Display the value with the description to the listbox
            lstExpenses.Items.Add(Decimal.Parse(txtAmount.Text).ToString("C") & ": " & description)
            'Error check; If the account is negative give an error message then continue
            If budget.GetBalance() < 0 Then
                MessageBox.Show("Account total is negative.")
            End If
            'Clear the amount text box.
            txtAmount.Clear()
        Else
            'Display an error message if the amount entered is not valid.
            MessageBox.Show("Please enter a valid amount.")
            txtAmount.Focus()
        End If
    End Sub
End Class
