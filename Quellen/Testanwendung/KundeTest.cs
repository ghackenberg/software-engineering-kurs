using Klassenbibliothek;

namespace Testanwendung
{
    [TestClass]
    public class KundeTest
    {
        [TestMethod]
        public void KonstruktorTest()
        {
            var kunde = new Kunde("Georg", "Hackenberg", new DateTime(2010, 5, 15));

            Assert.IsTrue(kunde.Vorname.Equals("Georg"));
            Assert.IsTrue(kunde.Nachname.Equals("Hackenberg"));
            Assert.IsTrue(kunde.Geburtstag.Equals(new DateTime(2010, 5, 15)));
        }

        [TestMethod]
        public void AlterTest()
        {
            var kunde = new Kunde("Georg", "Hackenberg", new DateTime(2010, 5, 15));
            var alter = kunde.Alter();

            Assert.IsTrue(alter.TotalDays / 365 > 10);
        }
    }
}