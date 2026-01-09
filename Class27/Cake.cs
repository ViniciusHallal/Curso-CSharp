namespace Class27
{
    public class Cake
    {
        public string Flavor;
        public string Filling;
        public string Coverage;
        public int Layers;
        public string Size;

        public Cake(string Flavor, string Filling, string Coverage, int Layers, string Size)
        { 
            this.Flavor = Flavor;
            this.Filling = Filling;
            this.Coverage = Coverage;
            this.Layers = Layers;
            this.Size = Size;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\n--- CAKE DETAILS ---");
            Console.WriteLine($"Flavor: {Flavor}");
            Console.WriteLine($"Filling: {Filling}");
            Console.WriteLine($"Coverage: {Coverage}");
            Console.WriteLine($"Layers: {Layers}");
            Console.WriteLine($"Size: {Size}");
        }
    }
}