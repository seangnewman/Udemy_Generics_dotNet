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
    public class StructWrapperTests
    {
        [TestMethod()]
        public void IntTest()
        {
            StructWrapper<int> wrapper = new StructWrapper<int>(42);
            Assert.AreEqual(42, wrapper.Instance);

        }

        [TestMethod()]
        public void PointTest()
        {
            Point origin = new Point(0, 0);
            StructWrapper<Point> wrapper = new StructWrapper<Point>(origin);
            Assert.AreEqual(origin, wrapper.Instance);

        }

        [TestMethod()]
        public void DoesNotCompile()
        {

            // Contrained to value types
            //StructWrapper<string> structWrapper = new StructWrapper<string>("3");
            //StructWrapper<Person> personWrapper = new StructWrapper<Person>< Person > (new Person());

        }
    }
}