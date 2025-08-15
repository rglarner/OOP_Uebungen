using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotizenTeil2
{
    internal class Notizsammlung
    {
        public string Name { get; set; }
        private List<Notiz> notizen;

        public Notizsammlung(string name)
        {
            Name = name;
            notizen = new List<Notiz>();
        }
        // Wird benötigt, damit die Notizsammlung serialisiert werden kann
        public List<Notiz> Notizen
        {
            get { return notizen; }
        }
        public void NotizHinzufuegen(Notiz notiz)
        {
            notizen.Add(notiz);
        }

        public bool NotizEntfernen(string titel)
        {
            foreach (var notiz in notizen)
            {
                if (notiz.Titel == titel)
                {
                    notizen.Remove(notiz);
                    return true;
                }
            }
            return false;
        }

        public void AlleNotizenAusgeben()
        {
            Console.WriteLine($"Notizsammlung: {Name}");
            foreach (var notiz in notizen)
            {
                Console.WriteLine(notiz.ToString());
            }
        }

        public void NotizSuchenUndAusgeben(string titel)
        {
            foreach (var notiz in notizen)
            {
                if (notiz.Titel == titel)
                {
                    Console.WriteLine(notiz.ToString());
                    return;
                }
            }
            Console.WriteLine($"Notiz mit Titel '{titel}' nicht gefunden.");
        }

        public int AlteNotizenLoeschen(DateTime stichtag)
        {
            // PRO: Lösung mit LINQ statt Schleife
            int geloescht = notizen.RemoveAll(n => n.Erstellungsdatum < stichtag);
            return geloescht;
        }

        public void NotizenSortiertNachDatumAusgeben()
        {
            Console.WriteLine($"Notizsammlung: {Name} (sortiert nach Datum)");
            var sortierteNotizen = notizen.OrderBy(n => n.Erstellungsdatum);
            foreach (var notiz in sortierteNotizen)
            {
                Console.WriteLine(notiz.ToString());
            }
        }
    }
}
