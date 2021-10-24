using System;
using System.Collections.Generic;
using ABCDC_App;
using NUnit.Framework;

namespace ABCDC_Test
{
    public class SessionTest
    {
        // Liste d'adhérant a mettre dans la session de jeu 
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
    }
}
