using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    public class PersonListener<T>
        where T: Person
    {
        private readonly T[] _members;

        public PersonListener(params T[] members)
        {
            _members = members;
        }

        public string[] List()
        {
            List<string> result = new List<string>();

            foreach (var member in _members)
            {
                result.Add($"{member.FirstName} {member.SecondName}");
            }

            return result.ToArray();
        }
    }
}
