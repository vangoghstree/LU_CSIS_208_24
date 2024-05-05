Public Class Calculator
    ' Private field to store the balance.
    Private balance As Decimal

    ' Method to set the initial balance.
    Public Sub SetBalance(initialBalance As Decimal)
        balance = initialBalance
    End Sub

    ' Method to get the current balance.
    Public ReadOnly Property GetBalance() As Decimal
        Get
            Return balance
        End Get
    End Property

    ' Method to add income to the balance.
    Public Sub AddIncome(amount As Decimal, description As String)
        balance += amount
    End Sub

    ' Method to subtract expenses from the balance.
    Public Sub SubtractExpense(amount As Decimal, description As String)
        balance -= amount
    End Sub
End Class
