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

        public List<Weapon> weaponsPlayerList
        {
            get { return _weaponsPlayerList; }
            set { _weaponsPlayerList = value; }
        }

        public List<Armor> armorsPlayerList
        {
            get { return _armorsPlayerList; }
            set { _armorsPlayerList = value; }
        }




        private List<Person> _playerlist;

        private DateTime _date;

        private List<Weapon> _weaponsPlayerList;

        private List<Armor> _armorsPlayerList;






        public Session Suivante()
        {
            var sessionSuivante = new Session();

            return sessionSuivante;
        }
    }
}
