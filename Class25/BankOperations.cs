namespace Class25;

public class BankOperations
{
    decimal balance = 0;

    public void Deposit()
    {
        Console.Clear();
        Console.WriteLine("---------- DEPOSIT ----------");
        Console.Write("\nEnter amount to deposit: ");
        decimal amountToDeposit = Convert.ToDecimal(Console.ReadLine());
        if(amountToDeposit <= 0)
        {
            Console.WriteLine("\nDeposit amount must be greater than zero.");
            Console.Write("\nPress any key to return to the menu...");
            Console.ReadKey();
            return;
        }

        balance += amountToDeposit;
        Console.WriteLine($"\nSuccessfully deposited {amountToDeposit:C}. New balance is: {balance:C}");

        Console.Write("\nPress any key to return to the menu...");
        Console.ReadKey();
    }

    public void Withdraw()
    {
        Console.Clear();
        Console.WriteLine("---------- WITHDRAW ----------");
        Console.Write("\nEnter amount to withdraw: ");
        decimal amountToWithDraw = Convert.ToDecimal(Console.ReadLine());

        if(amountToWithDraw > balance)
        {
            Console.WriteLine("\nInsufficient funds for this withdraw.");
            Console.Write("\nPress any key to return to the menu...");
            Console.ReadKey();
        } else
        {
            balance -= amountToWithDraw;
            Console.WriteLine($"\nSuccessfully withdrew {amountToWithDraw:C}. New balance is: {balance:C}");

            Console.Write("\nPress any key to return to the menu...");
            Console.ReadKey();
        }

    }
    public void CheckBalance()
    {
        Console.Clear();
        Console.WriteLine("---------- CURRENT BALANCE ----------");
        Console.WriteLine($"\nYour current balance is: {balance:C}");
        Console.Write("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
}