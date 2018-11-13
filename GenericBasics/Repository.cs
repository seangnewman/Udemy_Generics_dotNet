using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBasics
{
    public class Repository<T>
    {
        private readonly List<T> _data = new List<T>();

        public void Add( T toAdd)
        {
            _data.Add(toAdd);
        }

        public void Delete( T toDelete)
        {
            _data.Remove(toDelete);
        }

        public IEnumerable<T> All()
        {
            return _data;
        }

        public T Get(int index)
        {
            return _data[index];
        }

    }
}
