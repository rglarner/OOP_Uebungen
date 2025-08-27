using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtikelMitVererbung
{
    public class Food : Artikel
    {
        // Zusätzliche Instanzvariable für Food-Artikel
        public DateTime Ablaufdatum { get; set; }

        // Überschreibt Info-Methode
        public override void Info()
        {
            Console.WriteLine("[Food.Info] Id=" + Id + ", Ablauf=" + Ablaufdatum.ToString("yyyy-MM-dd") + ", Lager=" + MengeAnLager);
        }

        // Zusätzliche, statische Methode zur Ausgabe abgelaufener Food-Artikel
        public static void AusgabeAbgelaufen()
        {
            int count = 0;
            DateTime heute = DateTime.Today;

            foreach (Food f in Artikel.AlleVonTyp<Food>())
            {
                if (heute > f.Ablaufdatum)
                {
                    Console.WriteLine("[Food.AusgabeAbgelaufen] Abgelaufen: Id=" + f.Id + ", Name=" + f.Name + ", bis=" + f.Ablaufdatum.ToString("yyyy-MM-dd"));
                    count = count + 1;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("[Food.AusgabeAbgelaufen] Keine abgelaufenen Food-Artikel");
            }
        }
    }
}
