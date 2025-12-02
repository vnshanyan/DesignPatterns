using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod;

internal class ConcreteProduct1 : IProduct
{
    public string Operation()
    {
        return "{Result of ConcreteProduct1}";
    }
}
