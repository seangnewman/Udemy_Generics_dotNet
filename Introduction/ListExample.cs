using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    public static class ListExample
    {
        public static void NonGenericList()
        {
            ArrayList list = new ArrayList
            {
                new Person {FirstName = "Cody", LastName="Newman"},
                new Person {FirstName = "Connor", LastName = "Newman"},
                new object()
            };

            Console.Write((list[0] as Person).FirstName);
        }

        public static void GenericList()
        {
            var list = new List<Person>
            {
                new Person {FirstName = "Cody", LastName="Newman"},
                new Person {FirstName = "Connor", LastName = "Newman"}
            };

            Console.Write(list[0].FirstName);
        }
    }
}
