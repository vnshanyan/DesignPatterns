namespace AbstractFactory;

// The client code works with factories and products only through abstract types: AbstractFactory and AbstractProduct.
// This lets you pass any factory or product subclass to the client code without breaking it.

class Client
{
    public void Main()
    {
        // The client code can work with any concrete factory class.
        Console.WriteLine("Client: Testing client code with the first factory type...");
        ConcreteFactory1 factory1 = new ConcreteFactory1();
        ClientMethod(factory1);
        Console.WriteLine();

        Console.WriteLine("Client: Testing the same client code with the second factory type...");
        ConcreteFactory2 factory2 = new ConcreteFactory2();
        ClientMethod(factory2);
    }

    public void ClientMethod(IAbstractFactory factory)
    {
        var productA = factory.CreateProductA();
        var productB = factory.CreateProductB();

        Console.WriteLine(productB.UsefulFunctionB());
        Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
    }
}
