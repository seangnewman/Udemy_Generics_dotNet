using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    public class NameLister<T>
        where T:IName
    {
        private readonly T[] _members;

        public NameLister(params T[] members)
        {
            _members = members;
        }

        public string[] List()
        {
            List<string> result = new List<string>();

            foreach (T member in _members)
            {
                result.Add($"{member.FirstName} {member.LastName}");
            }

            return result.ToArray();
        }
    }
}
