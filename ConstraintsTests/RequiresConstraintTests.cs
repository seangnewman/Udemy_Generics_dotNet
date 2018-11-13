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
    public class RequiresConstraintTests
    {
        [TestMethod()]
        public void IntegerConstructionTest()
        {
            RequiresConstraint<int> requiresConstraint = new RequiresConstraint<int>();

            Assert.AreEqual(0, requiresConstraint.Create());
        }

        [TestMethod()]
        public void PersonConstructionTest()
        {
            RequiresConstraint<Person> requiresConstraint = new RequiresConstraint<Person>();

            Assert.IsInstanceOfType( requiresConstraint, typeof(Person));
        }

        [TestMethod()]
        public void DoesNotCompile()
        {
            //RequiresConstraint<Video> requiresConstraint = new RequiresConstraint<Video>();
             
        }
    }
}