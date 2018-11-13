using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class People : IEnumerable<Person>
    {
        private readonly Person[] _people;

        public People(params Person[] people)
        {
            _people = people;
        }


        public IEnumerator<Person> GetEnumerator()
        {
            return ((IEnumerable<Person>)_people).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
