using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtikelMitVererbung
{
    public class Gutschein : Artikel
    {
        // Zusätzliche Instanzvariablen für Gutschein-Artikel
        public decimal Restwert { get; private set; } // private set: nur intern änderbar
        public DateTime Ablaufdatum { get; set; } = DateTime.Today.AddYears(5);

        // Zusätzlich: Setzt den Start-Restwert
        public void SetStartRestwert(decimal betrag)
        {
            if (betrag < 0m) betrag = 0m;
            Restwert = betrag;
            Console.WriteLine("[Gutschein.SetStartRestwert] Restwert=" + Restwert.ToString("0.00") + " (Id=" + Id + ")");
        }

        // Zusätzlich: Löst einen Betrag ein (reduziert Restwert)
        public void Einlösen(decimal betrag)
        {
            if (betrag <= 0m)
            {
                Console.WriteLine("[Gutschein.Einlösen] Ungültiger Betrag " + betrag.ToString("0.00") + " (Id=" + Id + ", Rest=" + Restwert.ToString("0.00") + ")");
                return;
            }
            decimal neu = Restwert - betrag;
            if (neu < 0m) neu = 0m;
            Restwert = neu;
            Console.WriteLine("[Gutschein.Einlösen] -" + betrag.ToString("0.00") + " eingelöst (Id=" + Id + ", Rest=" + Restwert.ToString("0.00") + ")");
        }

        // Überschreibt Info-Methode
        public override void Info()
        {
            Console.WriteLine("[Gutschein.Info] Id=" + Id + ", Restwert=" + Restwert.ToString("0.00") + ", Ablauf=" + Ablaufdatum.ToString("yyyy-MM-dd") + ", Lager=" + MengeAnLager);
        }

        // Zusätzliche, statische Methode zur Ausgabe abgelaufener Gutscheine
        public static void AnzeigeAbgelaufeneGutscheine()
        {
            int count = 0;
            DateTime heute = DateTime.Today;

            foreach (Gutschein g in Artikel.AlleVonTyp<Gutschein>())
            {
                if (heute > g.Ablaufdatum)
                {
                    Console.WriteLine("[Gutschein.Abgelaufen] Id=" + g.Id + ", Rest=" + g.Restwert.ToString("0.00") + ", Ende=" + g.Ablaufdatum.ToString("yyyy-MM-dd"));
                    count = count + 1;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("[Gutschein.Abgelaufen] Keine abgelaufenen Gutscheine");
            }
        }

        // Zusätzliche, statische Methode zur Ausgabe der Summe aller offenen (nicht abgelaufenen) Gutscheine
        public static void AnzeigeSummeOffeneGutscheine()
        {
            DateTime heute = DateTime.Today;
            decimal summe = 0m;

            foreach (Gutschein g in Artikel.AlleVonTyp<Gutschein>())
            {
                if (heute <= g.Ablaufdatum)
                {
                    summe = summe + g.Restwert;
                }
            }
            Console.WriteLine("[Gutschein.SummeOffen] Summe nicht abgelaufen: " + summe.ToString("0.00"));
        }
    }
}
