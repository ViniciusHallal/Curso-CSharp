namespace Class25;

public class BankTerminal
{
    BankOperations bank = new BankOperations();
   
    public void Start()
    {
        int option;
        do
        {
            Menu();
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                option = -1;
            }

            switch (option)

            {
                case 1:
                    bank.Deposit();
                    break;

                case 2:
                    bank.Withdraw();
                    break;

                case 3:
                    bank.CheckBalance();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("\nExiting the program. Thank you for using our services!");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("\nInvalid option selected. Please try again.");
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                    break;
            }
        } while (option != 4);
    }

    public void Menu()
    {
        Console.Clear();
        Console.WriteLine("---------- BANK MENU ----------\n");
        Console.WriteLine("1 - Deposit");
        Console.WriteLine("2 - Withdraw");
        Console.WriteLine("3 - Check Balance");
        Console.WriteLine("4 - Exit");
        Console.Write("\nSelect an option (1-4): ");
    }
}