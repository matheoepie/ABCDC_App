using System;
using System.Collections.Generic;
using System.Linq;
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

            int nbDeParticipantsEquipe1 = Equipe1.Count;
            int nbDeParticipantsEquipe2 = Equipe2.Count;

            int nbDeParticipants = nbDeParticipantsEquipe1 + nbDeParticipantsEquipe2;

            bool equilibre = false;

            //récupération du poids de chaque équipe
            foreach (Person person in Equipe1)
            {
                moyennePoidsEquipe1 += person.Weight;
            }
            foreach (Person person in Equipe2)
            {
                moyennePoidsEquipe2 += person.Weight;
            }


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


                //boucle pour déplacer les participants
                int cpt = 0;
                while (equilibre == false || cpt != nbDeParticipants - 1)
                {
                    //tri des deux équipes en fonction du poids
                    Equipe1.OrderByDescending(o => o.Weight).ToList();
                    Equipe2.OrderByDescending(o => o.Weight).ToList();

                    if (moyennePoidsEquipe1 > moyennePoidsEquipe2)
                    {
                        //déplace le plus lourd de l'équipe1 vers l'équipe2
                        Equipe2.Add(Equipe1[cpt]);
                        Equipe1.Remove(Equipe1[cpt]);

                        //déplace le moins lourd de l'équipe2 vers l'équipe1
                        Equipe1.Add(Equipe2[nbDeParticipantsEquipe2 - 1]);
                        Equipe2.Remove(Equipe2[nbDeParticipantsEquipe2 - 1]);
                    }
                    else
                    {
                        //déplace le moins lourd de l'équipe1 vers l'équipe2
                        Equipe2.Add(Equipe1[nbDeParticipantsEquipe1 - 1]);
                        Equipe1.Remove(Equipe1[nbDeParticipantsEquipe1 - 1]);

                        //déplace le plus lourd de l'équipe2 vers l'équipe1
                        Equipe1.Add(Equipe2[cpt]);
                        Equipe2.Remove(Equipe2[cpt]);
                    }

                    if ((moyennePoidsEquipe1 >= 52 && moyennePoidsEquipe1 <= 56 && moyennePoidsEquipe2 >= 52 && moyennePoidsEquipe2 <= 56)
                    || (moyennePoidsEquipe1 >= 57 && moyennePoidsEquipe1 <= 62 && moyennePoidsEquipe2 >= 57 && moyennePoidsEquipe2 <= 62)
                    || (moyennePoidsEquipe1 >= 63 && moyennePoidsEquipe1 <= 68 && moyennePoidsEquipe2 >= 63 && moyennePoidsEquipe2 <= 68)
                    || (moyennePoidsEquipe1 >= 69 && moyennePoidsEquipe1 <= 74 && moyennePoidsEquipe2 >= 69 && moyennePoidsEquipe2 <= 74)
                    || (moyennePoidsEquipe1 >= 75 && moyennePoidsEquipe1 <= 80 && moyennePoidsEquipe2 >= 75 && moyennePoidsEquipe2 <= 80)
                    || (moyennePoidsEquipe1 >= 81 && moyennePoidsEquipe1 <= 90 && moyennePoidsEquipe2 >= 81 && moyennePoidsEquipe2 <= 90)
                    || (moyennePoidsEquipe1 >= 91 && moyennePoidsEquipe2 >= 91))
                    {
                        equilibre = true;
                    }

                    cpt++;
                }
            }

            return equilibre;
        }

        public void EquilibreEnAncienneté()
        {

        }
    }
}
