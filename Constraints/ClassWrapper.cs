using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    public class ClassWrapper<T>
        where T : class
    {
        private readonly T _instance;
        public T Instance  { get { return _instance; } }

        public ClassWrapper(T instance)
        {
            _instance = instance;
        }

        public bool isEqualUsingOperator(T toCheck)
        {
            return _instance == toCheck;
        }

        public bool isEqualUsingMethod(T toCheck)
        {
            return _instance.Equals(toCheck);
        }

        public void DoesNotCompile()
        {
            // These do not compile,  constraint is for reference types only
            //ClassWrapper<int> intWrapper = new ClassWrapper<int>(3);
            //ClassWrapper<Point> pointWrapper = new ClassWrapper<Point>(new Point());
        }

    }
}
