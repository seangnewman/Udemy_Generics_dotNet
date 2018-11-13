using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    public class Person:IName
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public string LastName => SecondName;


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
                return false;

            if (obj.GetType() != GetType())
                return false;
            Person other = (Person)obj;
            return FirstName == other.FirstName && SecondName == other.SecondName;
        }

        public override int GetHashCode()
        {
            return ( (FirstName != null ? FirstName.GetHashCode() : 0)*397 ) ^
                (LastName != null? LastName.GetHashCode():0);
        }

        public static bool operator ==(Person a, Person b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (((object)a == null) || ((object)b == null))
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(Person a, Person b)
        {
            return !(a == b);
        }
    }
}
