using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBasics
{
    public class SimpleList<T>
    {
        private readonly List<T> _data = new List<T>();

        public void Add( T toAdd)
        {
            _data.Add(toAdd);
        }

        public T Get(int index)
        {
            if (index < 0 || index > _data.Count - 1)
            {
                return default(T);
            }
            return _data[index];
        }
    }
}
