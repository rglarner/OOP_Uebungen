namespace LagerverwaltungTeil2
{
    internal class Artikel
    {
        private string name;
        private string beschreibung;
        private double preis;
        private string artikelnummer;
        private string kategorie;

        // Properties mit Validierung
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Der Name des Artikels darf nicht leer sein.");
                }
                name = value.Trim();
            }
        }

        public string Beschreibung
        {
            get { return beschreibung; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Die Beschreibung darf nicht leer sein.");
                }
                beschreibung = value.Trim();
            }
        }

        public double Preis
        {
            get { return preis; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Der Preis muss größer oder gleich 0 sein.");
                }
                preis = value;
            }
        }

        public string Artikelnummer
        {
            get { return artikelnummer; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Die Artikelnummer darf nicht leer sein.");
                }
                artikelnummer = value.Trim();
            }
        }

        public string Kategorie
        {
            get { return kategorie; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Die Kategorie darf nicht leer sein.");
                }
                kategorie = value.Trim();
            }
        }
    }
}