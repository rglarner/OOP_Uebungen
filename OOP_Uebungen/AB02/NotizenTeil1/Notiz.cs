using System.ComponentModel.DataAnnotations;

namespace NotizenTeil1
{
    internal class Notiz
    {
        private string titel;
        private string inhalt;
        private string verfasser;
        private DateTime erstellungsdatum = DateTime.Now;
        private DateTime aenderungsdatum = DateTime.Now;

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
                // Änderungsdatum aktualisieren wenn Titel geändert wird
                aenderungsdatum = DateTime.Now;
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
                // Änderungsdatum aktualisieren wenn Inhalt geändert wird
                aenderungsdatum = DateTime.Now;
            }
        }

        public string Verfasser
        {
            get { return verfasser; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Der Verfasser darf nicht leer sein.");
                }
                verfasser = value;
            }
        }

        // Erstellungsdatum ist read-only - wird automatisch beim Erstellen gesetzt
        public DateTime Erstellungsdatum
        {
            get { return erstellungsdatum; }
        }

        // Änderungsdatum ist read-only - wird automatisch bei Änderungen aktualisiert
        public DateTime Aenderungsdatum
        {
            get { return aenderungsdatum; }
        }
    }
}