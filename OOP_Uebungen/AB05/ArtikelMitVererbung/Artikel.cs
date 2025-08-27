using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtikelMitVererbung
{
    public class Artikel
    {
        // Zentrale Liste aller Artikel
        private static List<Artikel> alle = new List<Artikel>();

        // Basis-Eigenschaften
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Beschreibung { get; set; } = "";
        public decimal Preis { get; set; }
        public string Einheit { get; set; } = "Stk";
        public int MengeAnLager { get; private set; }

        // Konstruktor registriert automatisch
        public Artikel()
        {
            alle.Add(this);
            Console.WriteLine($"[Artikel.Konstruktor] Erstellt: Typ=" + this.GetType().Name + " (AnzahlUnterschiedlicherArtikel=" + alle.Count + ")");
        }

        // Lagerzugang (erhöht Menge)
        public void LagerZugang(int menge)
        {
            if (menge <= 0)
            {
                Console.WriteLine("[Artikel.LagerZugang] Ungültige Menge " + menge + " (Id=" + Id + ")");
                return;
            }
            MengeAnLager = MengeAnLager + menge;
            Console.WriteLine("[Artikel.LagerZugang] +" + menge + " (Id=" + Id + ", Lager=" + MengeAnLager + ")");
        }

        // Verkauf (reduziert Menge)
        public virtual void Verkaufen(int menge)
        {
            if (menge <= 0)
            {
                Console.WriteLine("[Artikel.Verkaufen] Ungültige Menge " + menge + " (Id=" + Id + ", Lager=" + MengeAnLager + ")");
                return;
            }
            if (MengeAnLager < menge)
            {
                Console.WriteLine("[Artikel.Verkaufen] Nicht genug Lager: " + MengeAnLager + " < " + menge + " (Id=" + Id + ")");
                return;
            }
            MengeAnLager = MengeAnLager - menge;
            Console.WriteLine("[Artikel.Verkaufen] -" + menge + " verkauft (Id=" + Id + ", Lager=" + MengeAnLager + ")");
        }

        // Info-Ausgabe (überschreibbar)
        public virtual void Info()
        {
            Console.WriteLine("[Artikel.Info] " + Name + " (Id=" + Id + ", " + Preis.ToString("0.00") + "/" + Einheit + ", Lager=" + MengeAnLager + ")");
        }

        // Gefilterter Zugriff ohne LINQ
        public static List<T> AlleVonTyp<T>() where T : Artikel
        {
            List<T> result = new List<T>();
            for (int i = 0; i < alle.Count; i++)
            {
                Artikel a = alle[i];
                if (a is T)
                {
                    result.Add((T)a);
                }
            }
            return result;
        }
    }
}
