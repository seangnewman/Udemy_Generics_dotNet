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
    public class PersonListenerTests
    {
        [TestMethod()]
        public void PersonListerTest()
        {
            Person cody = new Person() { FirstName = "Cody", SecondName = "Newman" };
            Person connor = new Person() { FirstName = "Copnnor", SecondName = "Newman" };
            Person sean = new Person() { FirstName = "Sean", SecondName = "Newman" };

            PersonListener<Person> personListener = new PersonListener<Person>(cody, connor, sean);

            string[] list = personListener.List();
            Assert.AreEqual(3, list.Count());
           
        }

        [TestMethod()]
        public void EmployeeListerTest()
        {
            Employee cody = new Employee() { FirstName = "Cody", SecondName = "Newman", JobTitle = "Student"};
            Employee connor = new Employee() { FirstName = "Copnnor", SecondName = "Newman", JobTitle = "Student" };
            Employee sean = new Employee() { FirstName = "Sean", SecondName = "Newman", JobTitle = "Software Developer" };

            PersonListener<Employee> employeeListener = new PersonListener<Employee>(cody, connor, sean);

            string[] list = employeeListener.List();
            Assert.AreEqual(3, list.Count());

        }

        
        public void DoesNotCompile()
        {
            // Does not compile,  object does not deriver from Person
            //PersonListener<object> lister = new PersonListener<object>();

        }
    }
}