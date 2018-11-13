using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBasics
{
    public static class Validators
    {

        public static IEnumerable<Func<Person, bool>> GetPersonValidators()
        {
            var result = new List<Func<Person, bool>>();

            result.Add(person => !string.IsNullOrEmpty(person.FirstName));
            result.Add(person => !string.IsNullOrEmpty(person.LastName));

            return result;
        }
    }
}
