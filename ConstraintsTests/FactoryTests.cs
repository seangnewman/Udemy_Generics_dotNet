using Microsoft.VisualStudio.TestTools.UnitTesting;
using Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints.Tests
{
    [TestClass()]
    public class FactoryTests
    {
        [TestMethod()]
        public void CreatePersonTest()
        {
            Factory<Person> factory = new Factory<Person>();

            Assert.IsInstanceOfType(factory.Create(), typeof(Person));
            Person person = factory.Create();

            Assert.IsNull(person.FirstName);
            Assert.IsNull(person.LastName);
        }

        [TestMethod()]
        public void CreateIntTest()
        {
            Factory<int> factory = new Factory<int>();

            Assert.AreEqual(0, factory.Create());

        }

        public void DoesNotCompile()
        {
            // Factory<Video> factory = new Factory<Video>();
        }
    }

    
}