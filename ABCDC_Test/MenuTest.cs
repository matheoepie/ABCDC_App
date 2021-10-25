using ABCDC_Lib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABCDC_Test
{
    class MenuTest
    {
        List<Person> listeDeParticipant = new List<Person>();
        Person paul = new Person() { FirstName = "Paul", LastName = "GROS", Weight = 134, BeginYear = 2006, Weapon = "Hache 2M", Armor = "Mailles" };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Ajout_nouveaux_participant() 
        {
            
            listeDeParticipant = Menu.AddUser(this.listeDeParticipant, this.paul);
            Assert.IsNotNull(listeDeParticipant);
            
        }

    }
}
