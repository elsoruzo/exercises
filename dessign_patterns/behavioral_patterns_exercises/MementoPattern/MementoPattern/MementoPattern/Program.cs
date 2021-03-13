using System;
using System.Collections.Generic;
using DesignPatterns.Memento.Conceptual;
using DesignPatterns.Memento.Practical;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conceptual example");
            // Client code.
            Originator originator = new Originator("Super-duper-super-puper-super.");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            caretaker.Undo();

            Console.WriteLine();

            Console.WriteLine("Practical example");

            var momentos = new List<MementoPractical>();
            var caretakerPractical = new CaretakerPractical(momentos);

            var originatorPractical = new OriginatorPractical(new MementoPractical("AA"));

            Console.WriteLine($"Originator Current State: %s\n {originatorPractical.GetState()}");
            caretakerPractical.AddMemento(originatorPractical.CreateMemento());

            originatorPractical.SetState(new MementoPractical("BB"));
            Console.WriteLine($"Originator Current State: %s\n{ originatorPractical.GetState()}");
            caretakerPractical.AddMemento(originatorPractical.CreateMemento());

            originatorPractical.SetState(new MementoPractical("CC"));
            Console.WriteLine($"Originator Current State: %s\n{originatorPractical.GetState()}");
            caretakerPractical.AddMemento(originatorPractical.CreateMemento());

            originatorPractical.Restorememento(caretakerPractical.GetMenento(1));
            Console.WriteLine($"Restored to State: %s\n{ originatorPractical.GetState()}");

            originatorPractical.Restorememento(caretakerPractical.GetMenento(0));
            Console.WriteLine($"Restored to State: %s\n{ originatorPractical.GetState()}");
        }
    }
}
