using NUnit.Framework;
using ABCDC_App;

namespace ABCDC_Test
{
    class ArmesFixesTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Les_Armes_Sont_Fixes_Elles_Ne_Changent_Pas_Sur_Une_Session()
        {
            var session = new Session();
            var sessionSuivante = session.Suivante();
            
            Assert.Equals(sessionSuivante.armesDesJoueurs, session.armesDesJoueurs);
        }
    }
}
