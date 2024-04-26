using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbibliothek
{
    abstract class KundeAbstrakt
    {
        // Definition einer abstrakten Methode
        public abstract string SageHallo();

        // Verwendung der abstrakten Methode
        public static void Demo(KundeAbstrakt kunde)
        {
            Console.WriteLine(kunde.SageHallo());
        }
    }
}
