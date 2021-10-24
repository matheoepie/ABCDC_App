using System;
using System.Collections.Generic;
using System.Text;

namespace ABCDC_App
{
    public class Session
    {
        public List<Person> PlayersList
        {
            get { return _playerslist; }
            set { _playerslist = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public List<Weapon> WeaponsPlayerList
        {
            get { return _weaponsPlayerList; }
            set { _weaponsPlayerList = value; }
        }

        public List<Armor> ArmorsPlayerList
        {
            get { return _armorsPlayerList; }
            set { _armorsPlayerList = value; }
        }

        public List<Partie> PartiesList
        {
            get { return _partiesList; }
            set { _partiesList = value; }
        }




        private List<Person> _playerslist;

        private DateTime _date;

        private List<Weapon> _weaponsPlayerList;

        private List<Armor> _armorsPlayerList;

        private List<Partie> _partiesList;




        public Session Suivante()
        {
            var sessionSuivante = new Session();

            return sessionSuivante;
        }
    }
}
