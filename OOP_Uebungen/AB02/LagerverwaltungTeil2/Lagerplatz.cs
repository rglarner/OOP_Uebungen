namespace LagerverwaltungTeil2
{
    internal class Lagerplatz
    {
        private string nameLagerplatz;
        private int maximaleKapazitaet;
        private Artikel artikel;
        private int aktuellerBestand;

        // Properties mit Validierung
        public string NameLagerplatz
        {
            get { return nameLagerplatz; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // Profi Variante der Validierung statt Length <= 0
                {
                    throw new ArgumentException("Der Name des Lagerplatzes darf nicht leer sein.");
                }
                nameLagerplatz = value.Trim();
            }
        }

        public int MaximaleKapazitaet
        {
            get { return maximaleKapazitaet; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Die maximale Kapazität muss größer als 0 sein.");
                } else if (value < aktuellerBestand)
                {
                    throw new ArgumentException($"Die maximale Kapazität muss größer oder gleich dem aktuellen Bestand ({aktuellerBestand}) sein.");
                }
                maximaleKapazitaet = value;
            }
        }

        public Artikel Artikel
        {
            get { return artikel; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Der Artikel darf nicht null sein.");
                }
                artikel = value;
            }
        }

        public int AktuellerBestand
        {
            get { return aktuellerBestand; }
            set
            {
                if (value < 0 || value > maximaleKapazitaet)
                {
                    throw new ArgumentException($"Der aktuelle Bestand muss zwischen 0 und {maximaleKapazitaet} liegen.");
                }
                aktuellerBestand = value;
            }
        }

        // Berechneter Wert: Gesamtwert des Lagerplatzes
        public double Gesamtwert
        {
            get 
            { 
                if (artikel == null)
                    return 0;
                return aktuellerBestand * artikel.Preis; 
            }
        }
    }
}
