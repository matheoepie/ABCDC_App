using System;
using System.Collections.Generic;
using NUnit.Framework;
using ABCDC_Lib;

namespace ABCDC_Test
{
    class EquilibreMatchTest
    {
        //Liste des joueurs
        public List<Person> Participants { get; set; } = new List<Person>();

        //création des équipes
        public List<Person> Equipe1 { get; set; } = new List<Person>();
        public List<Person> Equipe2 { get; set; } = new List<Person>();

        public Equilibre equilibre;

        [SetUp]
        public void Setup()
        {
            Person p = new Person();

            this.equilibre = new Equilibre();

            //récupérer la liste des adhérants dans l'équipe 1
            this.Participants = p.GetListeExcel();

            //créer un nouveau participant
            p.LastName = "RETEAU";
            p.FirstName = "Lucas";
            p.BeginYear = 2018;
            p.Weight = 70;
            p.Armor = "Mailles";
            p.Weapon = "Epee";

            //puis l'ajouter à l'équipe 2
            this.Participants.Add(p);

        }

        [Test]
        public void Les_Equipes_Sont_Equilibrees_en_nombre()
        {
            (List<Person>, List<Person>) equipes = equilibre.EquilibreEnNombre(Participants);

            Equipe1 = equipes.Item1;
            Equipe2 = equipes.Item2;

            Assert.AreEqual(Equipe1.Count, Equipe2.Count, 1);
        }

        public void Les_Equipes_Sont_Equilibrees_en_poids()
        {
            bool equilibree = equilibre.EquilibreEnPoids(Equipe1, Equipe2);

            Assert.AreEqual(equilibree, true);
        }

        public void Les_Equipes_Sont_Equilibrees_en_anciennete()
        {

        }
    }
}
