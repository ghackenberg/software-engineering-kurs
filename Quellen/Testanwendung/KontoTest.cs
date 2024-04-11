using Klassenbibliothek;

namespace Testanwendung
{
    [TestClass]
    public class KontoTest
    {
        [TestMethod]
        public void KonstruktorTest()
        {
            var kunde = new Kunde("Georg", "Hackenberg", new DateTime(2010, 5, 15));
            var konto = new Konto(kunde);

            Assert.IsTrue(konto.Kunde == kunde);
            Assert.IsTrue(konto.Stand == 0);
        }

        [TestMethod]
        public void EinzahlenTest()
        {
            var kunde = new Kunde("Georg", "Hackenberg", new DateTime(2010, 5, 15));
            var konto = new Konto(kunde);

            konto.Einzahlen(5);

            Assert.IsTrue(konto.Stand == 5);
        }

        [TestMethod]
        public void AuszahlenTest()
        {
            var kunde = new Kunde("Georg", "Hackenberg", new DateTime(2010, 5, 15));
            var konto = new Konto(kunde);

            konto.Einzahlen(10);
            konto.Auszahlen(5);

            Assert.IsTrue(konto.Stand == 5);
        }

        [TestMethod]
        public void ÜberweisenTest()
        {
            var kundeA = new Kunde("Georg", "Hackenberg", new DateTime(2010, 5, 15));
            var kontoA = new Konto(kundeA);

            var kundeB = new Kunde("Max", "Muster", new DateTime(2015, 8, 21));
            var kontoB = new Konto(kundeB);

            kontoA.Einzahlen(10);
            kontoA.Überweisen(kontoB, 5);

            Assert.IsTrue(kontoA.Stand == 5);
            Assert.IsTrue(kontoB.Stand == 5);
        }
    }
}