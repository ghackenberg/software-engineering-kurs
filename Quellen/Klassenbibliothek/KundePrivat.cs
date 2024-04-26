using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbibliothek
{
    class KundePrivat : KundeAbstrakt
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public KundePrivat(string vorname, string nachname) {
            Vorname = vorname;
            Nachname = nachname;
        }

        // Überschreibung der abstrakten Methode
        public override string SageHallo()
        {
            return $"Hallo {Vorname}!";
        }

        // Indirekter Aufruf der abstrakten Methode
        public static void Demo()
        {
            var kunde = new KundePrivat("Max", "Muster");

            KundeAbstrakt.Demo(kunde);
        }
    }
}
