namespace LaenderTeil2
{
    internal class Land
    {
        private string name;
        private string isoCode;
        private string hauptstadt;
        private double flaeche;
        private int einwohnerzahl;
        private string waehrung;

        public string Name
        {
            get => name;
            set
            {
                if (value.Length <= 0)
                    throw new ArgumentException("Der Name des Landes darf nicht leer sein.");
                name = value;
            }
        }

        public string ISOCode
        {
            get => isoCode;
            set
            {
                if (value.Length != 2)
                    throw new ArgumentException("Der ISO-Code muss genau 2 Zeichen lang sein.");
                isoCode = value;
            }
        }

        public string Hauptstadt
        {
            get => hauptstadt;
            set
            {
                if (value.Length <= 0)
                    throw new ArgumentException("Die Hauptstadt darf nicht leer sein.");
                hauptstadt = value;
            }
        }

        public double Flaeche
        {
            get => flaeche;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Die Fläche muss größer als 0 sein.");
                flaeche = value;
            }
        }

        public int Einwohnerzahl
        {
            get => einwohnerzahl;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Die Einwohnerzahl muss größer oder gleich 0 sein.");
                einwohnerzahl = value;
            }
        }

        public string Waehrung
        {
            get => waehrung;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Die Währung darf nicht leer sein.");
                waehrung = value;
            }
        }
        // Ausgabe aller Eigenschaften des Landes
        public void Ausgabe()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ISO-Code: {ISOCode}");
            Console.WriteLine($"Hauptstadt: {Hauptstadt}");
            Console.WriteLine($"Fläche: {Flaeche} km²");
            Console.WriteLine($"Einwohnerzahl: {Einwohnerzahl}");
            Console.WriteLine($"Währung: {Waehrung}");
            Console.WriteLine();
        }
    }
}
