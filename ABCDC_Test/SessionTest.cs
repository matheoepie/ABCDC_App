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

            // GetWeaponPlayerSession permet de
            // reccuperer toutes les armes des joueurs dans la session
            this.listWeaponSession = w.GetWeaponPlayerSession(this.listJoueurSession);

            // GetArmorPlayerSession permet de
            // reccuperer toutes les armures des joueurs dans la session
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

            // Verrifier que la premiere arme est bien egale a la premiere ligne du tableau excel
            Assert.AreEqual(session.weaponsPlayerList[0].Name, "Hache 2M");

            // Verifier que la permiere armure est bien egale a la premiere ligne du tableau excel
            Assert.AreEqual(session.armorsPlayerList[0].Name, "Mailles");

        }


        [Test]
        public void un_joueur_quitte_la_session_entre_deux_parties()
        {
            // Creation de la session de jeu 
            Session session = new Session() {
                weaponsPlayerList = this.listWeaponSession,
                armorsPlayerList = this.listArmorSession,
                Date = DateTime.Now,
                playerList = this.listJoueurSession,
                partieList = new List<Partie>,
            };

            // Création d'une nouvelle partie
            Partie p1 = new Partie(session.playerList);

            // Ajouter la partie dans la liste des partie de la sessions
            session.partieList.Add(p1);


            // Suppréssion d'un joueur de la sessions
            session.playerList.RemoveAll(x => x.LastName == "BLANC" && x.FirstName == "Louis");

            // Création d'une seconde partie
            Partie p2 = new Partie(session.playerList);
            session.partieList.Add(p2);

            // Verrification de la liste de joueur de la
            // partie n°1 n'est pas egale a celle de la partie n°2
            Assert.AreNotEqual(session.partieList[0].getPlayers(), session.partieList[1].getPlayers());

        }

    }
}
