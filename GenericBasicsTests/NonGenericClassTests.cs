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
    public class SwapValuesTests
    {
        [TestMethod()]
        public void TestSwapWithInteger()
        {
            int first = 23;
            int second = 42;

            NonGenericClass.Swap(ref first, ref second);

            Assert.AreEqual(42, first);
            Assert.AreEqual(23, second);

        }

        [TestMethod()]
        public void TestSwapWithString()
        {
            string first = "Cody";
            string second = "Connor";

            NonGenericClass.Swap(ref first, ref second);

            Assert.AreEqual("Connor", first);
            Assert.AreEqual("Cody", second);

        }

        [TestMethod()]
        public void TestSwapWithObject()
        {
            object first = new object();
            object second = new object();

            object saveFirst = first;
            object saveSecond = second;

            NonGenericClass.Swap(ref first, ref second);

            Assert.AreEqual(saveSecond, first);
            Assert.AreEqual(saveFirst, second);

        }
    }
}