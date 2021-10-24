using System;
using System.Collections.Generic;
using System.Text;

namespace ABCDC_App
{
    public class Session
    {
<<<<<<< HEAD
        public string ListMatch
        {
            get { return _listMatch; }
            set { _listMatch = value; }
=======
        public List<Person> PlayersList
        {
            get { return _playerslist; }
            set { _playerslist = value; }
>>>>>>> 397c6cf30d19c97fb66659bd94d2b30231da6fac
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

<<<<<<< HEAD
=======



        private List<Person> _playerslist;
>>>>>>> 397c6cf30d19c97fb66659bd94d2b30231da6fac

        private string _listMatch;
        
        private DateTime _date;

        private List<Weapon> _weaponsPlayerList;

        private List<Armor> _armorsPlayerList;

        private List<Partie> _partiesList;





        public void addPlayer(Person person)
        {
            this.PlayersList.Add(person);
        }



        public void removePlayer(string firstname, string lastname)
        {
            this.PlayersList.RemoveAll(x => x.FirstName == firstname && x.LastName == lastname);
        }



        public Session Suivante()
        {
            var sessionSuivante = new Session();

            return sessionSuivante;
        }
    }
}
