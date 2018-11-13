using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    class RelationshipConstraint<TDerived, TBase>
        where TDerived:TBase
    {
        public static class Demo
        {
            public static void Works()
            {
                RelationshipConstraint<Person, IName> first = new RelationshipConstraint<Person, IName>();
                RelationshipConstraint<Employee, Person> second = new RelationshipConstraint<Employee, Person>();

            }

            public static void DoesNotCompile()
            {
                // Person does not derive from Employee
                //RelationshipConstraint<Person, Employee> first = new RelationshipConstraint<Person, Employee>();
            }
        }
    }
}
