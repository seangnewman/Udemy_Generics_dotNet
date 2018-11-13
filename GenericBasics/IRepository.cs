using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBasics
{
    public interface IRepository<T>
    {

         void Add(T toAdd);



        void Delete(T toDelete);



        IEnumerable<T> All();



        T Get(int index);
        

    }
}
