namespace Klassenbibliothek
{
    public class Kunde
    {
        // Les- und schreibbare Eigenschaften der Klasseninstanzen
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        // Nur lesbare Eigenschaften der Klasseninstanzen
        public DateTime Geburtstag { get; }

        // Konstruktor der Klasseninstanzen
        public Kunde(string vorname, string nachname, DateTime geburtstag)
        {
            // Schreibe Eigenschaften der Klasseninstanzen
            Vorname = vorname;
            Nachname = nachname;
            Geburtstag = geburtstag;
        }

        // Methode der Klasseninstanzen
        public TimeSpan Alter()
        {
            // Lese Eigenschaften der Klasseninstanzen
            return DateTime.Now - Geburtstag;
        }
    }
}

