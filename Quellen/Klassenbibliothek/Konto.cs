namespace Klassenbibliothek
{
    public class Konto
    {
        // Eigenschaften der Klasseninstanzen
        public Kunde Kunde{ get; }
        public int Stand { get; private set; }

        // Konstruktor der Klasseninstanzen
        public Konto(Kunde kunde)
        {
            Kunde = kunde;
            Stand = 0;
        }

        // Methoden der Klasseninstanzen
        public void Einzahlen(uint betrag)
        {
            // Schreiben der Eigenschaften der Klasseninstanzen
            Stand += (int) betrag;
        }
        public void Auszahlen(uint betrag)
        {
            // Prüfen der Eigenschaften der Klasseninstanzen
            if (Stand - betrag < 0)
            {
                throw new Exception("Kontostand reicht nicht aus!");
            }
            // Schreiben der Eigenschaften der Klasseninstanzen
            Stand -= (int) betrag;
        }
        public void Überweisen(Konto anderesKonto, uint betrag)
        {
            // Erst auszahlen (schlägt evtl. fehl) ...
            Auszahlen(betrag);
            // ... und dann einzahlen
            anderesKonto.Einzahlen(betrag);
        }
    }
}
