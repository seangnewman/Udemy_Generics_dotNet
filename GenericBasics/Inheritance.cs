using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBasics
{

    public abstract class BaseClass<T>
    {

    }

    public class NonGenericChild : BaseClass<int>
    {

    }

    public class GenericChild<T> : BaseClass<T>
    {

    }

    public class GenericChildWithAdditionalType<TAdditional> : BaseClass<string>
    {

    }

    public class ComplexBaseClass<TDiagram, TSchema>
    {

    }

    public class OneTypeSpecified<TSchema>: ComplexBaseClass<WireDiagram, TSchema>
    {

    }

    public class BothTypesSpecified: ComplexBaseClass<WireDiagram, NormalSchema>
    {

    }

}

