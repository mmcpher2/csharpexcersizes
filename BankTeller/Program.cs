using System;

namespace BankTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the database interface
            DatabaseInterface db = new DatabaseInterface();

            // Check/create the Account table
            db.CheckAccountTable();

            int choice;

            do
            {
                // Show the main menu by invoking the static method
                choice = MainMenu.Show();

                switch (choice)
                {
                    // Menu option 1: Adding account
                    case 1:
                        // Ask user to input customer name
                        string CustomerName = Console.ReadLine();

                        // Insert customer account into database
                        db.Insert($@"
                            INSERT INTO Account
                            (Id, Customer, Balance)
                            VALUES
                            (null, '{CustomerName}', 0)
                        ");
                        break;

                    // Menu option 2: Deposit money
                    case 2:
                        // Ask user to input deposit amount
                        double DepositAmount = int.Parse(Console.ReadLine());

                        // Logic here

                        break;

                    // Menu option 3: Withdraw money
                    case 3:

                    // Menu option 4: Show account balance
                    case 4:
                }
                // Menue option 5: EXIT
            } while (choice != 5);
        }
    }
}
