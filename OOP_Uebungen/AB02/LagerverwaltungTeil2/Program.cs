using System.Text.Json;

namespace LagerverwaltungTeil2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Artikel erstellen
            Artikel artikel = new Artikel
            {
                Name = "Produkt X",
                Beschreibung = "Ein hochwertiges Produkt",
                Preis = 9.99,
                Artikelnummer = "PX-001",
                Kategorie = "Elektronik"
            };

            // Lagerplatz mit Artikel erstellen
            Lagerplatz lagerplatz = new Lagerplatz
            {
                NameLagerplatz = "Lager A",
                MaximaleKapazitaet = 100,
                Artikel = artikel,
                AktuellerBestand = 50
            };

            Console.WriteLine($"Lagerplatz: {lagerplatz.NameLagerplatz}");
            Console.WriteLine($"Maximale Kapazität: {lagerplatz.MaximaleKapazitaet}");
            Console.WriteLine($"Artikel: {lagerplatz.Artikel.Name}");
            Console.WriteLine($"Artikelnummer: {lagerplatz.Artikel.Artikelnummer}");
            Console.WriteLine($"Beschreibung: {lagerplatz.Artikel.Beschreibung}");
            Console.WriteLine($"Kategorie: {lagerplatz.Artikel.Kategorie}");
            Console.WriteLine($"Aktueller Bestand: {lagerplatz.AktuellerBestand}");
            Console.WriteLine($"Preis pro Einheit: {lagerplatz.Artikel.Preis:F2}");
            Console.WriteLine($"Gesamtwert des Lagerplatzes: {lagerplatz.Gesamtwert:F2}");

            // Tests für ungültige Werte
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
                lagerplatz.Artikel = null; // Test für ungültigen Wert
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }

            try
            {
                lagerplatz.Artikel.Preis = -5; // Test für ungültigen Wert
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

            try
            {
                lagerplatz.Artikel.Name = ""; // Test für ungültigen Artikel-Namen
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }

            // PRO Thema: JSON
            // PRO Thema: JSON

            // JSON Serialisierung - Lagerplatz in JSON-Datei speichern
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(lagerplatz, options);
            string filePath = "lagerplatz.json";
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine($"\nLagerplatz wurde in {filePath} gespeichert.");
            Console.WriteLine($"JSON Inhalt:\n{jsonString}");

            // JSON Deserialisierung - Lagerplatz aus JSON-Datei laden
            string loadedJsonString = File.ReadAllText(filePath);
            Lagerplatz geladenerLagerplatz = JsonSerializer.Deserialize<Lagerplatz>(loadedJsonString);

            Console.WriteLine("\n--- Geladene Daten aus JSON ---");
            Console.WriteLine($"Lagerplatz: {geladenerLagerplatz.NameLagerplatz}");
            Console.WriteLine($"Maximale Kapazität: {geladenerLagerplatz.MaximaleKapazitaet}");
            Console.WriteLine($"Artikel: {geladenerLagerplatz.Artikel.Name}");
            Console.WriteLine($"Artikelnummer: {geladenerLagerplatz.Artikel.Artikelnummer}");
            Console.WriteLine($"Beschreibung: {geladenerLagerplatz.Artikel.Beschreibung}");
            Console.WriteLine($"Kategorie: {geladenerLagerplatz.Artikel.Kategorie}");
            Console.WriteLine($"Aktueller Bestand: {geladenerLagerplatz.AktuellerBestand}");
            Console.WriteLine($"Preis pro Einheit: {geladenerLagerplatz.Artikel.Preis:F2}");
            Console.WriteLine($"Gesamtwert des Lagerplatzes: {geladenerLagerplatz.Gesamtwert:F2}");
        }
    }
}
