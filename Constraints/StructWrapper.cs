using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    public class StructWrapper<T>
        where T : struct
    {
        private readonly T _instance;

        public StructWrapper( T instance)
        {
            _instance = instance;
        }

        public T Instance { get { return Instance; } }
    }
}
