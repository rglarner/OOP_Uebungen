namespace LagerverwaltungTeil1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lagerplatz lagerplatz = new Lagerplatz
            {
                NameLagerplatz = "Lager A",
                MaximaleKapazitaet = 100,
                NameProdukt = "Produkt X",
                AktuellerBestand = 50,
                PreisProEinheit = 9.99
            };
            Console.WriteLine($"Lagerplatz: {lagerplatz.NameLagerplatz}");
            Console.WriteLine($"Maximale Kapazität: {lagerplatz.MaximaleKapazitaet}");
            Console.WriteLine($"Produkt: {lagerplatz.NameProdukt}");
            Console.WriteLine($"Aktueller Bestand: {lagerplatz.AktuellerBestand}");
            Console.WriteLine($"Preis pro Einheit: {lagerplatz.PreisProEinheit:C}");
            Console.WriteLine($"Gesamtwert des Lagerplatzes: {lagerplatz.Gesamtwert:C}");
            try
            {
                lagerplatz.AktuellerBestand = 120; // Test für ungültigen Wert
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
            try
            {
                lagerplatz.MaximaleKapazitaet = 30; // Test für ungültigen Wert
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
            try
            {
                lagerplatz.NameProdukt = ""; // Test für ungültigen Wert
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
            try
            {
                lagerplatz.PreisProEinheit = -5; // Test für ungültigen Wert
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
            try
            {
                lagerplatz.NameLagerplatz = ""; // Test für ungültigen Wert
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
        }
    }
}
