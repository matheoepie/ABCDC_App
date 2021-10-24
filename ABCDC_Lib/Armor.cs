using System;
using System.Collections.Generic;

namespace ABCDC_Lib
{
    public class Armor
    {

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _name;


        public Armor()
        {
            
        }

        public List<Armor> GetArmorPlayerSession(List<Person> persons)
        {
            List<Armor> armors = new List<Armor>();

            foreach (Person person in persons)
            {
                armors.Add(new Armor() { Name = person.Armor });
            }

            return armors;
        }

    }
}
