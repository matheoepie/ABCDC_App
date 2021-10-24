using System;
using System.Collections.Generic;

namespace ABCDC_App
{
    public class Weapon
    {

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _name;

        

        public Weapon()
        {
           
        }


        public List<Weapon> GetWeaponPlayerSession(List<Person> persons)
        {
            List<Weapon> weapons = new List<Weapon>();

            foreach (Person person in persons)
            {
                weapons.Add(new Weapon() { Name = person.Weapon }) ;
            }

            return weapons;
        }

    }
}
