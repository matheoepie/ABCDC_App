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

        public List<String> weaponsPlayerList
        {
            get { return _weaponsPlayerList; }
            set { _weaponsPlayerList = value; }
        }

        public List<String> armorsPlayerList
        {
            get { return _armorsPlayerList; }
            set { _armorsPlayerList = value; }
        }




        private List<Person> _playerlist;

        private DateTime _date;

        private List<String> _weaponsPlayerList;

        private List<String> _armorsPlayerList;






        public Session Suivante()
        {
            var sessionSuivante = new Session();

            return sessionSuivante;
        }
    }
}
