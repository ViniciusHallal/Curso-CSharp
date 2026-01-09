namespace Class24
{
    public class Person
    {
        //1. Atributos
        public string Name;
        public int Age;

        //2. Metodos
        public string IfLegalPerson()
        {
            if (Age >= 18)
            {
                return $"\nHello {Name}! You are a legal person.";
            }
            else
            {
                return $"\nHello {Name}! You are not a legal person.";
            }
        }
    }
}
