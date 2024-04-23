class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the CODED Banking Application ");

        Console.WriteLine();


        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your account number: ");
        int accountNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter your initial deposit: ");
        double initialDeposit = double.Parse(Console.ReadLine());

        BankAccount account = new BankAccount(name, accountNumber, initialDeposit);
        Console.WriteLine("\nAccount setup successful!");

        string choice;
        do
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Deposit ");
            Console.WriteLine("2. Withdraw ");
            Console.WriteLine("3. View Balance ");
            Console.WriteLine("4. Exit ");
            Console.Write("Please select a number: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("\nEnter deposit amount: ");
                    double depositAmount = double.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;
                case "2":
                    Console.Write("\nEnter withdrawal amount: ");
                    double withdrawalAmount = double.Parse(Console.ReadLine());
                    account.Withdraw(withdrawalAmount);
                    break;
                case "3":
                    Console.WriteLine($"\nYour current balance is: {account.GetBalance()}");
                    break;

                case "4":
                    Console.WriteLine("\nThank you for using CODED Banking Application. Goodbye!");

                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    break;
            }
        } while (choice != "4");
    }
}
