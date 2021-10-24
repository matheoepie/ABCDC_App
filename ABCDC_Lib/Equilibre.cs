using System;
using System.Collections.Generic;
using System.Text;

namespace ABCDC_Lib
{
    public class Equilibre
    {
        public List<Person> Participants
        {
            get { return _participants; }
            set { _participants = value; }
        }

        private List<Person> _participants;

        public (List<Person>, List<Person>) EquilibreEnNombre(List<Person> Participants)
        {
            List<Person> Equipe1 = new List<Person>();
            List<Person> Equipe2 = new List<Person>();

            bool switcher = true;

            foreach(Person person in Participants)
            {
                if (switcher)
                {
                    Equipe1.Add(person);
                    switcher = false;
                } else
                {
                    Equipe2.Add(person);
                    switcher = true;
                }
            }

            return (Equipe1, Equipe2);
        }
    }
}
