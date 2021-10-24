using System;
using System.Collections.Generic;
using System.Text;

namespace ABCDC_App
{
    public class Person
    {
        #region Properties 

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public int BeginYear
        {
            get { return _beginYear; }
            set { _beginYear = value; }
        }

        public string Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        public string Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }

        #endregion

        #region Attributes

        private string _firstName;

        private string _lastName;

        private int _weight;

        private int _beginYear;

        private string _weapon;

        private string _armor;

        #endregion

        public Person()
        {

        }

        public List<Person> GetListeExcel()
        {
            List<Person> listAdherant = new List<Person>();

            Person paul = new Person() { FirstName = "Paul", LastName = "GROS", Weight = 134, BeginYear = 2006, Weapon = "Hache 2M", Armor = "Mailles" };
            Person louis = new Person() { FirstName = "Louis", LastName = "BLANC", Weight = 47, BeginYear = 2020, Weapon = "Dagues", Armor = "Mailles" };
            Person jm = new Person() { FirstName = "Jean-Michel", LastName = "GIRAUD", Weight = 79, BeginYear = 1987, Weapon = "Sabre", Armor = "Plaques" };
            Person theo = new Person() { FirstName = "Théophile", LastName = "PÂRIS", Weight = 102, BeginYear = 2003, Weapon = "Hallebarde", Armor = "Gambison" };

            listAdherant.Add(paul);
            listAdherant.Add(louis);
            listAdherant.Add(jm);
            listAdherant.Add(theo);

            return listAdherant;
        }

    }
}