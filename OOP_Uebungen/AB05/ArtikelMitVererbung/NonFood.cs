using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtikelMitVererbung
{
    public class NonFood : Artikel
    {
        // Zusätzliche Instanzvariablen für NonFood-Artikel
        public bool Garantie { get; set; }
        public static int GarantiedauerMonate { get; set; } = 24; // Klassenvariable
        public DateTime? Garantieende { get; private set; }

        // Überschreibt Verkaufen-Methode
        public override void Verkaufen(int menge)
        {
            if (Garantie && menge > 0)
            {
                Garantieende = DateTime.Today.AddMonths(GarantiedauerMonate);
            }

            string endeText = (Garantieende.HasValue ? Garantieende.Value.ToString("yyyy-MM-dd") : "n/a");
            Console.WriteLine("[NonFood.Verkaufen] GarantieEnde=" + endeText + " (Id=" + Id + ")");
            base.Verkaufen(menge);
        }

        // Überschreibt Info-Methode
        public override void Info()
        {
            string endeText = (Garantieende.HasValue ? Garantieende.Value.ToString("yyyy-MM-dd") : "n/a");
            Console.WriteLine("[NonFood.Info] Id=" + Id + ", Garantie=" + (Garantie ? "ja" : "nein") + ", Ende=" + endeText + ", Lager=" + MengeAnLager);
        }
    }
}
