namespace Class27;

public class Program
{
    public static void Main()
    {
        Cake cakeChocolate = new Cake("Chocolate", "Coconut", "Chocolate", 3, "Medium");
        Cake cakeLemon = new Cake("Lemon", "White Chocolate", "Lemon", 2, "Small");

        cakeChocolate.ShowInfo();
        cakeLemon.ShowInfo();
    }
}