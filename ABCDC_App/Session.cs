using System;
using System.Collections.Generic;
using System.Text;

namespace ABCDC_App
{
    public class Session
    {
        public string ListMatch
        {
            get { return _listMatch; }
            set { _listMatch = value; }
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


        private string _listMatch;
        
        private DateTime _date;

        private string _armesDesJoueurs;


        public Session Suivante()
        {
            var sessionSuivante = new Session();

            return sessionSuivante;
        }
    }
}
