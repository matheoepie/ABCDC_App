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

        public bool EquilibreEnPoids(List<Person> Equipe1, List<Person> Equipe2)
        {
            double moyennePoidsEquipe1 = 0;
            double moyennePoidsEquipe2 = 0;

            int nbDeParticipants = 0;

            //récupération du poids de chaque équipe
            foreach (Person person in Equipe1)
            {
                moyennePoidsEquipe1 += person.Weight;
                nbDeParticipants++;
            }
            foreach (Person person in Equipe2)
            {
                moyennePoidsEquipe2 += person.Weight;
                nbDeParticipants++;
            }

            bool equilibre = false;
            bool accepte = false;

            while ((equilibre == false) || (accepte = false))
            {
                if ((moyennePoidsEquipe1 >= 52 && moyennePoidsEquipe1 <= 56 && moyennePoidsEquipe2 >= 52 && moyennePoidsEquipe2 <= 56)
                || (moyennePoidsEquipe1 >= 57 && moyennePoidsEquipe1 <= 62 && moyennePoidsEquipe2 >= 57 && moyennePoidsEquipe2 <= 62)
                || (moyennePoidsEquipe1 >= 63 && moyennePoidsEquipe1 <= 68 && moyennePoidsEquipe2 >= 63 && moyennePoidsEquipe2 <= 68)
                || (moyennePoidsEquipe1 >= 69 && moyennePoidsEquipe1 <= 74 && moyennePoidsEquipe2 >= 69 && moyennePoidsEquipe2 <= 74)
                || (moyennePoidsEquipe1 >= 75 && moyennePoidsEquipe1 <= 80 && moyennePoidsEquipe2 >= 75 && moyennePoidsEquipe2 <= 80)
                || (moyennePoidsEquipe1 >= 81 && moyennePoidsEquipe1 <= 90 && moyennePoidsEquipe2 >= 81 && moyennePoidsEquipe2 <= 90)
                || (moyennePoidsEquipe1 >= 91 && moyennePoidsEquipe2 >= 91))
                {
                    //OK -- sortir
                    equilibre = true;
                }
                else
                {
                    //KO -- equilibration des équipes

                    //tri des deux équipes en fonction du poids
                    Equipe1.Sort(); 
                    Equipe2.Sort();

                    //boucle pour déplacer les participants
                    for (int cpt = 1; cpt <= nbDeParticipants; cpt++)
                    {
                        if (moyennePoidsEquipe1 > moyennePoidsEquipe2)
                        {

                        }
                        else
                        {

                        }
                    }


                    //pas equilibré mais on accepte ?
                    accepte = true;
                }
            }

            return equilibre;
        }

        public void EquilibreEnAncienneté()
        {

        }
    }
}
