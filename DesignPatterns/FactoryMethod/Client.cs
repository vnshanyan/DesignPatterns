namespace FactoryMethod;

class Client()
{
    public void Main()
    {
        Console.WriteLine("App: Launched with the ConcreteCreator1.");
        ConcreteCreator1 concreteCreator1 = new ConcreteCreator1();
        ClientCode(concreteCreator1);

        Console.WriteLine("");

        Console.WriteLine("App: Launched with the ConcreteCreator2.");
        ConcreteCreator2 concreteCreator2 = new ConcreteCreator2();
        ClientCode(concreteCreator2);
    }

    // The client code works with an instance of a concrete creator, albeit through its base interface. As long as the client keeps working with
    // the creator via the base interface, you can pass it any creator's subclass.

    public void ClientCode(Creator creator)
    {
        Console.WriteLine("Client: I'm not aware of the creator's class, but it still works.\n" + creator.SomeOperation());
    }
}
