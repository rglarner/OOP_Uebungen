namespace LaenderTeil1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Land land = new Land
            {
                Name = "Deutschland",
                ISOCode = "DE",
                Hauptstadt = "Berlin",
                Flaeche = 357022.0,
                Einwohnerzahl = 83783942,
                Waehrung = "Euro"
            };
            Console.WriteLine($"Land: {land.Name}");
        }
    }
}
