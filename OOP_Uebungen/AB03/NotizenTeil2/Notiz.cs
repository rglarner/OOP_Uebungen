using System.ComponentModel.DataAnnotations;

namespace NotizenTeil2
{
    internal class Notiz
    {
        private string titel;
        private string inhalt;
        private string verfasser;
        private string ge�ndertVon;
        private DateTime aenderungsdatum;
        private DateTime erstellungsdatum;
        private bool istAmErstellen = true; // Flag, um zu erkennen, ob die Notiz gerade erstellt wird

        // Konstruktor, der den Verfasser und Ge�ndertVon setzt
        public Notiz(string titel, string inhalt, string verfasser)
        {
            Titel = titel; // Validierung des Titels
            Inhalt = inhalt; // Validierung des Inhalts
            this.verfasser = verfasser;
            this.ge�ndertVon = verfasser;
            // �nderungsdatum wird auf Erstellungsdatum gesetzt
            aenderungsdatum = DateTime.Now;
            erstellungsdatum = DateTime.Now;
            istAmErstellen = false; // Notiz ist jetzt nicht mehr im Erstellungsmodus
        }
        // Properties mit Validierung
        public string Titel
        {
            get { return titel; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Der Titel darf nicht leer sein.");
                }
                titel = value;
                // �nderungsdatum aktualisieren wenn Titel ge�ndert wird
                aenderungsdatum = DateTime.Now;
                if(!istAmErstellen)
                {
                    // PRO: Benutzename wird vom System ausgelesen und als geaendertVon gesetzt
                    this.ge�ndertVon = Environment.UserName;
                }
            }
        }

        public string Inhalt
        {
            get { return inhalt; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Der Inhalt darf nicht leer sein.");
                }
                inhalt = value;
                // �nderungsdatum aktualisieren wenn Inhalt ge�ndert wird
                aenderungsdatum = DateTime.Now;
                if(!istAmErstellen)
                {
                    // PRO: Benutzename wird vom System ausgelesen und als geaendertVon gesetzt
                    this.ge�ndertVon = Environment.UserName;
                }
            }
        }

        // Verfasser ist read-only - wird beim Erstellen gesetzt
        public string Verfasser
        {
            get { return verfasser; }
        }
        // Ge�ndert von ist read-only - wird automatisch beim Erstellen gesetzt
        public string GeaendertVon
        {
            get { return ge�ndertVon; }
        }

        // Erstellungsdatum ist read-only - wird automatisch beim Erstellen gesetzt
        public DateTime Erstellungsdatum
        {
            get { return erstellungsdatum; }
        }

        // �nderungsdatum ist read-only - wird automatisch bei �nderungen aktualisiert
        public DateTime Aenderungsdatum
        {
            get { return aenderungsdatum; }
        }
        // Methode zum Aktualisieren des Titels und Inhalts
        public void AktualisiereNotiz(string neuerTitel, string neuerInhalt, string geaendertVon)
        {
            Titel = neuerTitel; // Validierung des neuen Titels
            Inhalt = neuerInhalt; // Validierung des neuen Inhalts
            this.ge�ndertVon = geaendertVon; // Ge�ndert von aktualisieren
            // PRO: Benutzename wird vom System ausgelesen und als geaendertVon gesetzt
            this.ge�ndertVon = Environment.UserName;
            aenderungsdatum = DateTime.Now; // �nderungsdatum aktualisieren
        }
        // ToString-Methode f�r die Ausgabe der Notiz
        public override string ToString()
        {
            return $"Titel: {Titel}, Inhalt: {Inhalt}, Verfasser: {Verfasser}, Ge�ndert von: {GeaendertVon}, " +
                   $"Erstellt am: {Erstellungsdatum}, Ge�ndert am: {Aenderungsdatum}";
        }
    }
}