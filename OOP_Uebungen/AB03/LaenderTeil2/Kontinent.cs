using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaenderTeil2
{
    internal class Kontinent
    {
        private readonly List<Land> laender = new();

        public string Name { get; }

        public Kontinent(string name)
        {
            if (name.Length <= 0)
            {
                throw new ArgumentException("Name darf nicht leer sein.", nameof(name));
            }
            Name = name;
        }

        public bool HinzufügenLand(Land land)
        {
            if (land.ISOCode.Length <= 0)
            {
                Console.WriteLine("Land besitzt keinen gültigen ISO-Code und wird nicht hinzugefügt.");
                return false;
            }
            laender.Add(land);
            return true;
        }

        public bool EntferneLand(string isoCode)
        {
            if (isoCode.Length <= 0)
            {
                Console.WriteLine("Kein gültiger ISO-Code zum Entfernen angegeben.");
                return false;
            }

            foreach (var land in laender)
            {
                if (land.ISOCode == isoCode)
                {
                    laender.Remove(land);
                    return true;
                }
            }
            Console.WriteLine($"Kein Land mit ISO-Code {isoCode} gefunden.");
            return false;
        }

        public void AusgabeAlleLaender()
        {
            if (laender.Count == 0)
            {
                Console.WriteLine("Keine Länder vorhanden.");
                return;
            }

            Console.WriteLine($"Länder in {Name}:");
            foreach (var land in laender)
            {
                land.Ausgabe();
            }
        }

        public void PrintLandByIso(string isoCode)
        {
            if (isoCode.Length <= 0)
            {
                Console.WriteLine("Kein gültiger ISO-Code angegeben.");
                return;
            }

            foreach (var land in laender)
            {
                if (land.ISOCode == isoCode)
                {
                    Console.WriteLine($"Land {isoCode} gefunden:");
                    land.Ausgabe();
                    return;
                }
            }
            Console.WriteLine($"Land mit ISO-Code {isoCode} wurde nicht gefunden.");
        }
    }
}
