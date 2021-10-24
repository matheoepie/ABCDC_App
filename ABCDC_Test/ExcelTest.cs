using NUnit.Framework;
using System.Collections.Generic;
using ABCDC_App;
using System.Linq;
using ABCDC_Lib;

namespace ABCDC_Test
{
    public class ExcelTest
    {

        // Liste d'adhérant 
        public List<Person> listAdherant { get; set; } = new List<Person>();


        [SetUp]
        public void Setup()
        {
            Person paul = new Person() { FirstName = "Paul", LastName = "GROS", Weight = 134, BeginYear = 2006, Weapon = "Hache 2M", Armor = "Mailles" };
            Person louis = new Person() { FirstName = "Louis", LastName = "BLANC", Weight = 47, BeginYear = 2020, Weapon = "Dagues", Armor = "Mailles" };
            Person jm = new Person() { FirstName = "Jean-Michel", LastName = "GIRAUD", Weight = 79, BeginYear = 1987, Weapon = "Sabre", Armor = "Plaques" };
            Person theo = new Person() { FirstName = "Théophile", LastName = "PÂRIS", Weight = 102, BeginYear = 2003, Weapon = "Hallebarde", Armor = "Gambison" };

            this.listAdherant.Add(paul);
            this.listAdherant.Add(louis);
            this.listAdherant.Add(jm);
            this.listAdherant.Add(theo);

        }


        [Test]
        public void liste_adherant_nest_pas_vide()
        {
            Assert.IsNotEmpty(this.listAdherant);
        }


        [Test]
        public void premiere_et_derniere_personne_de_la_liste()
        {
            var premiere_position_de_liste_aderant = listAdherant.First().LastName;
            var derniere_position_de_liste_aderant = listAdherant.Last().LastName;

            string premier_nom_de_liste_aderant = "GROS";
            string dernier_nom_de_liste_aderant = "PÂRIS";

            Assert.AreEqual(premiere_position_de_liste_aderant, premier_nom_de_liste_aderant);
            Assert.AreEqual(derniere_position_de_liste_aderant, dernier_nom_de_liste_aderant);
        }




    }
}
