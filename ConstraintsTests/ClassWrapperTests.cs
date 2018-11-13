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
    public class ClassWrapperTests
    {
        [TestMethod()]
        public void StringTest()
        {
            const string name = "Cody";
            ClassWrapper<string> wrapper = new ClassWrapper<string>(name);
            Assert.AreEqual(wrapper.Instance, name);
            Assert.IsTrue(wrapper.isEqualUsingMethod(name));
            Assert.IsTrue(wrapper.isEqualUsingOperator(name));
        }

        [TestMethod()]
        public void BookTest()
        {
            Book book = new Book { Title = "Walden Two" };

            ClassWrapper<Book> wrapper = new ClassWrapper<Book>(book);
            Assert.AreEqual(wrapper.Instance, book);

            Book anotherBook = new Book { Title = "Walden Two" };
            Assert.AreNotEqual(wrapper.Instance, anotherBook);
        }

        [TestMethod()]
        public void PersonEqualityTest()
        {
            Person cody = new Person { FirstName = "Cody", SecondName = "Newman" };
            Person anotherCody = new Person { FirstName = "Cody", SecondName = "Newman" };

            // Using equals method works since we've overridden Equals on person
            Assert.IsTrue(cody.Equals(anotherCody));
            //Assert.IsTrue(cody == anotherCody);
        }

        [TestMethod()]
        public void PersonTest()
        {
            Person Connor = new Person { FirstName = "Connor", SecondName = "Newman" };
            ClassWrapper<Person> wrapper = new ClassWrapper<Person>(Connor);
            Assert.AreEqual(wrapper.Instance, Connor);

            Person anotherConnor = new Person { FirstName = "Connor", SecondName = "Newman" };
            Console.WriteLine(anotherConnor.FirstName);
            Console.WriteLine(Connor.FirstName);
            Console.WriteLine(anotherConnor.LastName);
            Console.WriteLine(Connor.LastName);
            Assert.IsTrue(wrapper.isEqualUsingMethod(anotherConnor));

            //Never use the == to test for equality
            Assert.IsFalse(wrapper.isEqualUsingOperator(anotherConnor));
        }

        [TestMethod()]
        public void isEqualUsingMethodTest()
        {
            Assert.Fail();
        }
    }
}