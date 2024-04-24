// See https://aka.ms/new-console-template for more information

class BankAccount 
{
    private string name;
    private int accountNumber;
    private double balance;
    private double[] transaction = new double[100];
    private int transactionCount = 0;


    public BankAccount(string name, int accountNumber, double initialBalance)
    {
        name = name;
        accountNumber = accountNumber;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"\nDeposit of {amount} successful. New balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"\nWithdrawal of {amount} successful. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("\nInsufficient funds. Withdrawal failed.");
        }
    }


    public double GetBalance()
    {
        return balance;
    }

    public void ViewTransaction()
    {
        Console.WriteLine("Transaction History: ");
        for (int i = 0; i < transactionCount; i++)
        {
            Console.WriteLine(transaction[i] > 0 ? $"Deposit: {transaction[i]:C}" : $"Withdrawal: {-transaction[i]:C}");
        }
    }
}