using System;
using System.Collections.Generic;
using System.Text;
using ABCDC_App;

namespace ABCDC_Lib
{
    class Match
    {
        public string playerList
        {
            get { return _playerlist; }
            set { _playerlist = value; }
        }

        public DateTime DateHeure
        {
            get { return _dateHeure; }
            set { _dateHeure = value; }
        }

        private string _playerlist;

        private DateTime _dateHeure;

        public void CreerEquipe(List<Person> persons, List<Person> members)
        {
            //création des listes d'équipes
            List<Person> equipe1 = new List<Person>();
            List<Person> equipe2 = new List<Person>();

            List<Person> equipeMatch = new List<Person>();

            //initialisation des variables
            int nbDeJoueursTotal = persons.Count + members.Count;
            int moyenneDeJoueurs = (int)Math.Round((double)nbDeJoueursTotal / 2);

            int nbDeJoueursEquipe1 = 0;
            double poidsDesJoueursEquipe1 = 0;
            double moyenneDePoidsEquipe1 = 0;

            int nbDeJoueursEquipe2 = 0;
            double poidsDesJoueursEquipe2 = 0;
            double moyenneDePoidsEquipe2 = 0;

            int ancienneteDesJoueurs;

            //récupération du poids total des participants
            foreach(Person item in persons)
            {
                poidsDesJoueursEquipe1 += item.Weight;
                //puis insertion du joueurs dans une des deux equipes
                if (nbDeJoueursEquipe1 <= moyenneDeJoueurs)
                {
                    equipe1.Add(item);

                    nbDeJoueursEquipe1++;

                //si nb de joueurs max dans l'équipe atteint, alors on insère dans l'autre équipe
                }
                else
                {
                    poidsDesJoueursEquipe2 += item.Weight;
                    equipe2.Add(item);

                    nbDeJoueursEquipe2++;
                }
            }
            //idem
            foreach (Person item in members)
            {
                //si l'équipe 1 n'a pas assez de joueurs, on y ajoute certains adhérents
                if (nbDeJoueursEquipe1 <= moyenneDeJoueurs)
                {
                    poidsDesJoueursEquipe1 += item.Weight;
                    equipe1.Add(item);

                    nbDeJoueursEquipe1++;

                //puis tout le reste dans l'équipe 2
                } else
                {
                    poidsDesJoueursEquipe2 += item.Weight;
                    equipe2.Add(item);

                    nbDeJoueursEquipe2++;
                }
                
            }

            //déterminer une moyenne de poids
            moyenneDePoidsEquipe1 = poidsDesJoueursEquipe1 / nbDeJoueursEquipe1;
            moyenneDePoidsEquipe2 = poidsDesJoueursEquipe2 / nbDeJoueursEquipe2;
            
            //Si les équipes sont triées en nombre et en poids, alors c'est OK
            if ((moyenneDePoidsEquipe1>=52 && moyenneDePoidsEquipe1<=56 && moyenneDePoidsEquipe2>=52 && moyenneDePoidsEquipe2<=56)
                || (moyenneDePoidsEquipe1>=57 && moyenneDePoidsEquipe1<=62 && moyenneDePoidsEquipe2>=57 && moyenneDePoidsEquipe2<=62)
                || (moyenneDePoidsEquipe1>=63 && moyenneDePoidsEquipe1<=68 && moyenneDePoidsEquipe2>=63 && moyenneDePoidsEquipe2<=68)
                || (moyenneDePoidsEquipe1>=69 && moyenneDePoidsEquipe1<=74 && moyenneDePoidsEquipe2>=69 && moyenneDePoidsEquipe2<=74)
                || (moyenneDePoidsEquipe1>=75 && moyenneDePoidsEquipe1<=80 && moyenneDePoidsEquipe2>=75 && moyenneDePoidsEquipe2<=80)
                || (moyenneDePoidsEquipe1>=81 && moyenneDePoidsEquipe1<=90 && moyenneDePoidsEquipe2>=81 && moyenneDePoidsEquipe2<=90)
                || (moyenneDePoidsEquipe1>=91 && moyenneDePoidsEquipe2>=91))
            {
                //OK
            }
            //Sinon, on tri les équipes en fonction du poids --> utiliser Sort(); ??
            else
            {
                //définir le 'Comparison' ???
                //Comparison<Person> comparison = new Comparison<double>(moyenneDePoidsEquipe1, moyenneDePoidsEquipe2);


                //equipe1.Sort(Comparison<Person> comparison);
            }

        }
    }
}
