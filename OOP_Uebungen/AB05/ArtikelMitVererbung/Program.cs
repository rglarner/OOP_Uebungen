namespace ArtikelMitVererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Non-Food
            NonFood bohrmaschine = new NonFood();
            bohrmaschine.Id = "NF-001";
            bohrmaschine.Name = "Bohrmaschine";
            bohrmaschine.Beschreibung = "18V Akkubohrer";
            bohrmaschine.Preis = 129.90m;
            bohrmaschine.Einheit = "Stk";
            bohrmaschine.Garantie = true;
            bohrmaschine.LagerZugang(10);
            bohrmaschine.Verkaufen(1);

            // Food (gestern abgelaufen)
            Food joghurt = new Food();
            joghurt.Id = "FD-001";
            joghurt.Name = "Joghurt Erdbeer";
            joghurt.Beschreibung = "Becher 150g";
            joghurt.Preis = 1.20m;
            joghurt.Einheit = "Stk";
            joghurt.Ablaufdatum = DateTime.Today.AddDays(-1);
            joghurt.LagerZugang(5);
            joghurt.Verkaufen(1);
            Food.AusgabeAbgelaufen();

            // Gutscheine
            Gutschein g1 = new Gutschein();
            g1.Id = "GC-100";
            g1.Name = "Gutschein Filiale";
            g1.Beschreibung = "Kaufhaus Muster";
            g1.Einheit = "Stk";
            g1.LagerZugang(1); // optional, falls Stückzählung erwünscht
            g1.SetStartRestwert(100m);
            g1.Einlösen(25m);

            Gutschein g2 = new Gutschein();
            g2.Id = "GC-101";
            g2.Name = "Gutschein Online";
            g2.Beschreibung = "Online Shop";
            g2.Einheit = "Stk";
            g2.SetStartRestwert(50m);

            Gutschein.AnzeigeAbgelaufeneGutscheine();
            Gutschein.AnzeigeSummeOffeneGutscheine();

            // Polymorphie-Demo
            List<Artikel> artikel = new List<Artikel>();
            artikel.Add(bohrmaschine);
            artikel.Add(joghurt);
            artikel.Add(g1);
            artikel.Add(g2);

            for (int i = 0; i < artikel.Count; i++)
            {
                artikel[i].Info();
            }

            Console.WriteLine("[Program.Ende] Demo abgeschlossen");
        }
    }
}
