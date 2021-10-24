using NUnit.Framework;
using ABCDC_App;

namespace ABCDC_Test
{
    class ArmesFixesTest
    {
        [Test]
        public void Les_Armes_Sont_Fixes_Elles_Ne_Changent_Pas_Sur_Une_Session()
        {
            var session = new Session();
<<<<<<< HEAD
            var sessionSuivante = session.Suivante();
            
            Assert.Equals(sessionSuivante.armesDesJoueurs, session.armesDesJoueurs);
=======

            var sessionSuivante = session.Suivante();
            Assert.Equals(sessionSuivante.WeaponsPlayerList, session.WeaponsPlayerList);
>>>>>>> 397c6cf30d19c97fb66659bd94d2b30231da6fac
        }
    }
}
