using System;
using System.Collections.Generic;
using ABCDC_Lib;
using NUnit.Framework;

namespace ABCDC_Test
{
    public class SessionTest
    {
        // Liste d'adhérant a mettre dans la session de jeu 
        public List<Person> listJoueurSession{ get; set; } = new List<Person>();

        public List<Weapon> listWeaponSession{ get; set; } = new List<Weapon>();

        public List<Armor> listArmorSession{ get; set; } = new List<Armor>();

        public Session session;


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




            // Session
            this.session = new Session()
            {
                WeaponsPlayerList = this.listWeaponSession,
                ArmorsPlayerList = this.listArmorSession,
                Date = DateTime.Now,
                PlayersList = this.listJoueurSession,
                PartiesList = new List<Partie>(),
            };



        }


        [Test]
        public void tous_les_joueurs_de_la_session_sont_inscrit()
        {

            // Verrifier que les listes ne sont pas vide
            Assert.IsNotEmpty(session.ArmorsPlayerList);
            Assert.IsNotEmpty(session.WeaponsPlayerList);
            Assert.IsNotEmpty(session.PlayersList);

            // Verrifier que la premiere arme est bien egale a la premiere ligne du tableau excel
            Assert.AreEqual(session.WeaponsPlayerList[0].Name, "Hache 2M");

            // Verifier que la permiere armure est bien egale a la premiere ligne du tableau excel
            Assert.AreEqual(session.ArmorsPlayerList[0].Name, "Mailles");

        }


        [Test]
        public void un_joueur_quitte_et_rejoin_la_session_entre_deux_parties()
        {
            
            // Création d'une nouvelle partie
            Partie p1 = new Partie(session);
            session.PartiesList.Add(p1);

            // Création du Hashage de la liste de joueurs pour la premiere partie
            HashSet<Person> hashPlayersListP1 = new HashSet<Person>(p1.GetPlayers());



            // Suppréssion d'un joueur de la sessions
            session.removePlayer("Louis", "BLANC");



            // Création d'une seconde partie
            Partie p2 = new Partie(session);
            session.PartiesList.Add(p2);

            // Création du Hashage de la liste de joueurs pour la deuxieme partie
            HashSet<Person> hashPlayersListP2 = new HashSet<Person>(p2.GetPlayers());


            // Test 1 :

            // Verrification de la liste de joueur de la
            // partie n°1 n'est pas egale a celle de la partie n°2 grâce au hashage
            // et que la 2 eme partie compte bien 3 joueur

            Assert.AreNotEqual(hashPlayersListP1, hashPlayersListP2);
            Assert.AreEqual(p2.GetPlayers().Count, 3);


            
            // Ajout d'un nouveau participant
            session.addPlayer(new Person() { FirstName = "Jean", LastName = "MANGE", Weight = 142, BeginYear = 2009, Weapon = "Hache 2M", Armor = "Mailles" });


            // Création d'une derniere partie
            Partie p3 = new Partie(session);
            session.PartiesList.Add(p3);


            // Test 2 :

            // Verrification que la 3 eme parti compte 4 joueurs
            // Derniere personne arrivé est egale a Jean MANGE

            Assert.AreEqual(p3.GetPlayers().Count, 4);
            Assert.AreEqual(p3.GetPlayers().Find(x => x.LastName == "MANGE").LastName, "MANGE");

        }

    }
}
