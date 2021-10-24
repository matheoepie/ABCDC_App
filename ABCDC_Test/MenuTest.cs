
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

            
            Person louis = new Person() { FirstName = "Louis", LastName = "BLANC", Weight = 47, BeginYear = 2020, Weapon = "Dagues", Armor = "Mailles" };
            Person jm = new Person() { FirstName = "Jean-Michel", LastName = "GIRAUD", Weight = 79, BeginYear = 1987, Weapon = "Sabre", Armor = "Plaques" };
            Person theo = new Person() { FirstName = "Théophile", LastName = "PÂRIS", Weight = 102, BeginYear = 2003, Weapon = "Hallebarde", Armor = "Gambison" };


            /*this.listeDeParticipant.Add(paul);
            this.listeDeParticipant.Add(louis);
            this.listeDeParticipant.Add(jm);
            this.listeDeParticipant.Add(theo);*/
        }

        [Test]
        public void Ajout_nouveaux_participant() 
        {
            
            listeDeParticipant = Menu.AddUser(this.listeDeParticipant, this.paul);
            Assert.IsNotNull(listeDeParticipant);
            
        }

    }
}
