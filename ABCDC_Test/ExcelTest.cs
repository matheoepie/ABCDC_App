using NUnit.Framework;
using System.Collections.Generic;
using ABCDC_App;
using ABCDC_Lib;


namespace ABCDC_Test
{
    public class ExcelTest
    {

        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void Add_User_In_Excel_File()
        {

            List<Person> persons = ExcelMethods.AddUser();
            Assert.IsNotEmpty(persons);
            Assert.AreEqual(persons[0].LastName, "GROS");
        }
     
    }
}
