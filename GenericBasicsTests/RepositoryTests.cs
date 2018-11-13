using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBasics.Tests
{
    [TestClass()]
    public class RepositoryTests
    {
        [TestMethod()]
        public void TestAddPerson()
        {
            Repository<Person> repository = new Repository<Person>();
            repository.Add(new Person { FirstName = "Cody", LastName = "Connor" });
            Assert.IsTrue(repository.All().Count() ==  1);

        }

        [TestMethod()]
        public void TestGetPersonByIndex()
        {
            Repository<Person> repository = new Repository<Person>();
            repository.Add(new Person { FirstName = "Connor", LastName = "Newman"});
            Person first = repository.Get(0);
            Assert.IsTrue(first != null);
            Assert.IsTrue(first.FirstName == "Connor");
            Assert.IsTrue(first.LastName == "Newman");

        }

        [TestMethod()]
        public void TestDeletePerson()
        {
            Repository<Person> repository = new Repository<Person>();
            Person person = new Person { FirstName = "Cody", LastName = "Connor" };

            repository.Add(person);
            Assert.IsTrue(repository.All().Count() == 1);
            repository.Delete(person);
            Assert.IsTrue(repository.All().Count() == 0);

             

        }

       
    }
}