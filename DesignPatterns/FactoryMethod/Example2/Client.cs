using System.Diagnostics;

namespace DesignPatterns.FactoryMethod.Example2
{
    public class Client
    {
        public string ClientCode(Creator creator)
        {
            Debug.WriteLine("Client: I'm not aware of the creator's class, but it still works.\n" + creator.SomeOperation());
            return creator.SomeOperation();
        }
    }
}
