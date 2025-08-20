using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    internal class Ticket
    {
        private static int nextId = 1;      // einmal pro Klasse, nicht pro Objekt
        public int Id { get; }              // read-only
        public string Titel { get; set; }   // Eigenschaft der Klasse

        public Ticket(string titel) // Konstruktor der Klasse
        {
            Id = nextId;    // aktuellen Wert vergeben
            nextId++;       // und für das nächste Objekt erhöhen
            Titel = titel;
        }
    }
}
