using System;
using System.Collections.Generic;
using System.Text;

namespace ABCDC_App
{
    public class Session
    {
        public List<Person> playerList
        {
            get { return _playerlist; }
            set { _playerlist = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string armesDesJoueurs
        {
            get { return _armesDesJoueurs; }
            set { _armesDesJoueurs = value; }
        }

        private List<Person> _playerlist;

        private DateTime _date;

        private string _armesDesJoueurs;


        public Session Suivante()
        {
            var sessionSuivante = new Session();

            return sessionSuivante;
        }
    }
}
