namespace Class24;

public class Program
{
    public static void Main()
    {
        Person person = new Person();

        Console.Write("Enter your name: ");
        person.Name = Console.ReadLine();
        Console.Write("Enter your age: ");
        person.Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(person.IfLegalPerson());
    }
}