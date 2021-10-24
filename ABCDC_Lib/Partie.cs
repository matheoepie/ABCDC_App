using System;
using System.Collections.Generic;

namespace ABCDC_Lib
{
    public class Partie
    {

        public Session Session
        {
            get { return _session; }
            set { _session = value; }
        }


        private Session _session;


        public Partie(Session session)
        {
            this.Session = session;
            
        }

        public List<Person> GetPlayers()
        { 
            return Session.PlayersList;
        }


        
    }
}
