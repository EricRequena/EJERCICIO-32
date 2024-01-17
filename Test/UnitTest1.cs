using M03.UF2.Activitats;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumeroAvatarTrue()
        {
            int CharacterNum = 1;
            int MaxRang = 4;
            int LessRang = 1;

            bool result = Ejercicio_32.Rang(CharacterNum, MaxRang, LessRang);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void NumeroAvatarFalse()
        {
            int CharacterNum = 0;
            int MaxRang = 1;
            int LessRang = 4;

            bool result = Ejercicio_32.Rang(CharacterNum, MaxRang, LessRang);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void DistanciaNombreTrue()
        {
            string name = "nombre";

            bool result = Ejercicio_32.LongName(name);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void DistanciaNombreFalse()
        {
            string name = "nombrelargonombrelargonombrelargo";

            bool result = Ejercicio_32.LongName(name);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void NivelMaldatTrue()
        {
            int Evil = 1050;
            int MaxRang = 1000;
            int LessRang = 50000;

            bool result = Ejercicio_32.Rang(Evil, MaxRang, LessRang);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void NivelMaldatFalse()
        {
            int Evil = 999;
            int MaxRang = 1000;
            int LessRang = 50000;

            bool result = Ejercicio_32.Rang(Evil, MaxRang, LessRang);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void VocalsCountTrue()
        {
            string name = "Nombre";
            char[] vocalArray = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };

            bool result = Ejercicio_32.CountVocals(name, vocalArray);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void VocalsCountFalse()
        {
            string name = "Nom";
            char[] vocalArray = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };

            bool result = Ejercicio_32.CountVocals(name, vocalArray);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CaracteresEspecialesTrue()
        {
            string name = "Nom_";

            bool result = Ejercicio_32.SpecialCount(name);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CaracteresEspecialesFalse()
        {
            string name = "Nom";

            bool result = Ejercicio_32.SpecialCount(name);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void MaldatFalse()
        {
            int evilnum = 1000;
            bool ValidationVocal = false;
            int CharactersNumber = 4; 

            double result = Ejercicio_32.DamageEvil(evilnum, ValidationVocal, CharactersNumber);

            Assert.AreEqual(result, 12);
        }

        [TestMethod]
        public void MaldatTrue()
        {
            int evilnum = 1000;
            bool ValidationVocal = true;
            int CharactersNumber = 4;

            double result = Ejercicio_32.DamageEvil(evilnum, ValidationVocal, CharactersNumber);

            Assert.AreEqual(result, 250);
        }
    }
}