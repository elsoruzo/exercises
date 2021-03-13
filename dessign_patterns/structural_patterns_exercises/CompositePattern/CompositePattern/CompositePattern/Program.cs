using System;
using DesignPatterns.Composite.Conceptual;
using DesignPatterns.Composite.PriceCalc;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            // This way the client code can support the simple leaf
            // components...
            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:\n");
            client.ClientCode(leaf);

            // ...as well as the complex composites.
            Composite tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:\n");
            client.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode2(tree, leaf);


            Console.WriteLine("Price Calc:\n");
            ProductClient productClient = new ProductClient();


            Product product = new Product(10);
            Console.WriteLine("Client: I get a simple component:\n");
            productClient.ClientCode(product);

            // ...as well as the complex composites.
            Box box = new Box();
            Box envelop1 = new Box();
            envelop1.Add(new Product(20));
            envelop1.Add(new Product(30));
            Box envelop2 = new Box();
            envelop2.Add(new Product(50));
            box.Add(envelop1);
            box.Add(envelop2);
            Console.WriteLine("Client: Now I've got a composite tree:\n");
            productClient.ClientCode(box);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            productClient.ClientCode2(box, product);
        }
    }
}
