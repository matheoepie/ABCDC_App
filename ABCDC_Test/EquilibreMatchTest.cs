using System;
using System.Collections.Generic;
using NUnit.Framework;
using ABCDC_Lib;

namespace ABCDC_Test
{
    class EquilibreMatchTest
    {
        //créer la liste des adhérants
        public List<Person> adherants { get; set; } = new List<Person>();

        //créer la liste des particpants
        public List<Person> participants { get; set; } = new List<Person>();

        //création des équipes
        public List<Person> Equipe1 { get; set; } = new List<Person>();
        public List<Person> Equipe2 { get; set; } = new List<Person>();

        [SetUp]
        public void Setup()
        {
            Person p = new Person();

            //récupérer la liste des adhérants
            this.adherants = p.GetListeExcel();

            //créer un nouveau participant
            p.LastName = "RETEAU";
            p.FirstName = "Lucas";
            p.BeginYear = 2018;
            p.Weight = 70;
            p.Armor = "Mailles";
            p.Weapon = "Epee";

            this.participants.Add(p);
        }

        [Test]
        public void Les_Equipes_Sont_Equilibrees_en_nombre()
        {

        }

        public void Les_Equipes_Sont_Equilibrees_en_poids()
        {

        }

        public void Les_Equipes_Sont_Equilibrees_en_anciennete()
        {

        }
    }
}
