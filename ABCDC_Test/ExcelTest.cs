using NUnit.Framework;
using System.Collections.Generic;
using ABCDC_App;
using ABCDC_Lib;


namespace ABCDC_Test
{
    public class ExcelTest
    {

        public List<Person> listAdherant{ get; set; }

        [SetUp]
        public void Setup()
        {
            // Person p = new Person() { FirstName = "Lucas", LastName = "Reteau", Weight = 100, Armor="bite", Weapon = "epie"};
            //this.listAdherant.Add(p);
        }


        [Test]
        public void liste_adherant_nest_pas_vide()
        {
            Assert.IsNotEmpty(this.listAdherant);
        }
     
    }
}
