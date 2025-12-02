using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod;

internal class ConcreteProduct2 : IProduct
{
    public string Operation()
    {
        return "{Result of ConcreteProduct2}";
    }
}
