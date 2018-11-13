using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    public class Factory<T>
        where T : new()
    {
        public T Create()
            
        {
            return new T();
        }
    }
}
