using System.Text.Json;

namespace NotizenTeil2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sammlung erstellen
            Notizsammlung sammlung = new Notizsammlung("Meine Notizen");
            // Notizen hinzufügen
            sammlung.NotizHinzufuegen(new Notiz("Einkaufsliste", "Milch, Brot, Eier", "Max Mustermann"));
            sammlung.NotizHinzufuegen(new Notiz("Urlaubsplanung", "Reise nach Italien", "Max Mustermann"));
            // Alle Notizen ausgeben
            sammlung.AlleNotizenAusgeben();
            // Notiz suchen und ausgeben
            sammlung.NotizSuchenUndAusgeben("Einkaufsliste");
            // Notiz aktualisieren
            Notiz notiz = new Notiz("Einkaufsliste", "Milch, Brot, Eier, Butter", "Max Mustermann");
            notiz.AktualisiereNotiz("Einkaufsliste", "Milch, Brot, Eier, Butter", "Max Mustermann");
            sammlung.NotizHinzufuegen(notiz);
            // Notiz aktualisieren und erneut ausgeben
            sammlung.NotizSuchenUndAusgeben("Einkaufsliste");
            // Alte Notizen löschen
            DateTime stichtag = DateTime.Now.AddDays(-30); // Beispiel: Notizen älter als 30 Tage löschen
            int geloeschteAnzahl = sammlung.AlteNotizenLoeschen(stichtag);
            Console.WriteLine($"Anzahl der gelöschten Notizen: {geloeschteAnzahl}");
            // Notizen sortiert nach Datum ausgeben
            sammlung.NotizenSortiertNachDatumAusgeben();
            // Notiz entfernen
            bool entfernt = sammlung.NotizEntfernen("Einkaufsliste");
            if (entfernt)
            {
                Console.WriteLine("Notiz wurde entfernt.");
            }
            else
            {
                Console.WriteLine("Notiz nicht gefunden.");
            }
            // Alle Notizen erneut ausgeben
            sammlung.AlleNotizenAusgeben();

            // PRO Thema JSON
            Console.WriteLine("\n=== JSON Serialisierung ===");
            // JSON Serialisierung - Notizsammlung in JSON-Datei speichern
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(sammlung, options);
            string filePath = "notizsammlung.json";
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine($"\nNotizsammlung wurde in {filePath} gespeichert.");
            Console.WriteLine($"JSON Inhalt:\n{jsonString}");

            // JSON Deserialisierung - Notizsammlung aus JSON-Datei laden
            string loadedJsonString = File.ReadAllText(filePath);
            Notizsammlung geladenesammlung = JsonSerializer.Deserialize<Notizsammlung>(loadedJsonString);

            Console.WriteLine("\n--- Geladene Daten aus JSON ---");
            Console.WriteLine($"Sammlung: {geladenesammlung.Name}");
            geladenesammlung.AlleNotizenAusgeben();
        }
    }
}
