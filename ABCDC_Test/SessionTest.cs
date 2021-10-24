using System;
using System.Collections.Generic;
using ABCDC_App;
using NUnit.Framework;

namespace ABCDC_Test
{
    public class SessionTest
    {
        // Liste d'adhérant a mettre dans la session de jeu 
        public List<Person> listJoueurSession{ get; set; } = new List<Person>();

        public List<Weapon> listWeaponSession{ get; set; } = new List<Weapon>();

        public List<Armor> listArmorSession{ get; set; } = new List<Armor>();


        [SetUp]
        public void Setup()
        {
            Person p = new Person();
            Weapon w = new Weapon();
            Armor a = new Armor();


            // GetListeExcel retourne la liste des personnes du fichier excel
            this.listJoueurSession = p.GetListeExcel();

            // GetWeaponPlayerSession permet de reccuperer toutes les armes des joueurs dans la session
            this.listWeaponSession = w.GetWeaponPlayerSession(this.listJoueurSession);

            // GetArmorPlayerSession permet de reccuperer toutes les armures des joueurs dans la session
            this.listArmorSession = a.GetArmorPlayerSession(this.listJoueurSession);


        }


        [Test]
        public void tous_les_joueurs_de_la_session_sont_inscrit()
        {
            Session session = new Session() { weaponsPlayerList = this.listWeaponSession, armorsPlayerList = this.listArmorSession, Date = DateTime.Now, playerList = this.listJoueurSession };

            // Verrifier que les listes ne sont pas vide
            Assert.IsNotEmpty(session.armorsPlayerList);
            Assert.IsNotEmpty(session.weaponsPlayerList);
            Assert.IsNotEmpty(session.playerList);
        }





    }
}
