using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerverwaltungTeil1
{
    internal class Lagerplatz
    {
        private string nameLagerplatz;
        private int maximaleKapazitaet;
        private string nameProdukt;
        private int aktuellerBestand;
        private double preisProEinheit;

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

        public string NameProdukt
        {
            get { return nameProdukt; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Der Name des Produkts darf nicht leer sein.");
                }
                nameProdukt = value.Trim(); // Profi Variante, welche Leerzeichen am Anfang und Ende entfernt
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

        public double PreisProEinheit
        {
            get { return preisProEinheit; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Der Preis pro Einheit muss größer oder gleich 0 sein.");
                }
                preisProEinheit = value;
            }
        }

        // Berechneter Wert: Gesamtwert des Lagerplatzes
        public double Gesamtwert
        {
            get { return aktuellerBestand * preisProEinheit; }
        }
    }
}
