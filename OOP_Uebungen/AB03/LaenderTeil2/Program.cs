namespace LaenderTeil2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kontinent europa = new Kontinent("Europa");
            Kontinent afrika = new Kontinent("Afrika");
            Land schweiz = new Land
            {
                Name = "Schweiz",
                ISOCode = "CH",
                Hauptstadt = "Bern",
                Flaeche = 41284,
                Einwohnerzahl = 8700000,
                Waehrung = "CHF"
            };
            Land deutschland = new Land
            {
                Name = "Deutschland",
                ISOCode = "DE",
                Hauptstadt = "Berlin",
                Flaeche = 357022,
                Einwohnerzahl = 83000000,
                Waehrung = "EUR"
            };
            Land marokko = new Land
            {
                Name = "Marokko",
                ISOCode = "MA",
                Hauptstadt = "Rabat",
                Flaeche = 446550,
                Einwohnerzahl = 36000000,
                Waehrung = "MAD"
            };
            Land aegypten = new Land
            {
                Name = "Ägypten",
                ISOCode = "EG",
                Hauptstadt = "Kairo",
                Flaeche = 1002450,
                Einwohnerzahl = 104000000,
                Waehrung = "EGP"
            };
            // Länder zu Kontinenten hinzufügen
            europa.HinzufügenLand(schweiz);
            europa.HinzufügenLand(deutschland);
            afrika.HinzufügenLand(marokko);
            afrika.HinzufügenLand(aegypten);
            // Ausgabe aller Länder in Europa
            europa.AusgabeAlleLaender();
            // Ausgabe aller Länder in Afrika
            afrika.AusgabeAlleLaender();
            // Entfernen eines Landes
            Console.WriteLine("Entferne Deutschland aus Europa:");
            if (europa.EntferneLand("DE"))
            {
                Console.WriteLine("Deutschland wurde erfolgreich entfernt.");
            }
            else
            {
                Console.WriteLine("Deutschland konnte nicht entfernt werden.");
            }
            // Ausgabe eines Landes anhand des ISO-Codes
            afrika.PrintLandByIso("MA");

        }
    }
}
