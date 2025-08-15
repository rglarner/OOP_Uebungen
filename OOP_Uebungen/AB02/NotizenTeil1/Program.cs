namespace NotizenTeil1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Erstellen einer Notiz
            Notiz notiz = new Notiz
            {
                Titel = "Kuchen essen",
                Inhalt = "Der Kuchen muss weg, hat sicher Proteine drin :-)",
                Verfasser = "Tom Tortenheimer"
            };
            // Ausgabe der Notiz
            Console.WriteLine($"Titel: {notiz.Titel}");
            Console.WriteLine($"Inhalt: {notiz.Inhalt}");
            Console.WriteLine($"Verfasser: {notiz.Verfasser}");
            Console.WriteLine($"Erstellt am: {notiz.Erstellungsdatum}");
            Console.WriteLine($"Letzte Änderung: {notiz.Aenderungsdatum}");
            // Versuch, eine ungültige Notiz zu erstellen
            try
            {
                Notiz ungültigeNotiz = new Notiz
                {
                    Titel = "", // Leerer Titel sollte eine Ausnahme auslösen
                    Inhalt = "Dies ist ein ungültiger Inhalt.",
                    Verfasser = "Ungültiger Verfasser"
                };
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
            // 2 Sekunden warten
            System.Threading.Thread.Sleep(2000);
            // Aktualisieren der Notiz
            notiz.Titel = "Kuchen essen und genießen";
            notiz.Inhalt = "Der Kuchen muss weg, aber jetzt auch genießen!";
            // Ausgabe der aktualisierten Notiz
            Console.WriteLine("\nAktualisierte Notiz:");
            Console.WriteLine($"Titel: {notiz.Titel}");
            Console.WriteLine($"Inhalt: {notiz.Inhalt}");
            Console.WriteLine($"Verfasser: {notiz.Verfasser}");
            Console.WriteLine($"Erstellt am: {notiz.Erstellungsdatum}");
            Console.WriteLine($"Letzte Änderung: {notiz.Aenderungsdatum}");

        }
    }
}
