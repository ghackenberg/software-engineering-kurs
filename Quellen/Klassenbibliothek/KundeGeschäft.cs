using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbibliothek
{
    class KundeGeschäft : KundeAbstrakt
    {
        public string Name { get; set; }

        public KundeGeschäft(string name) {
            Name = name;
        }

        // Überschreibung der abstrakten Methode
        public override string SageHallo()
        {
            return $"Hallo {Name}";
        }

        // Indirekter Aufruf der abstrakten Methode
        public static void Demo()
        {
            var kunde = new KundeGeschäft("FH OÖ");

            KundeAbstrakt.Demo(kunde);
        }
    }
}
