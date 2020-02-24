namespace AbstractBookPublishingFactory.Models
{
    using System;
    public class ScientificJournal : IPublisher
    {
        public string Name { get; set; }
        public ScientificJournal(string name)
        {
            Name = name;
            Console.WriteLine($"Made an IPublisher of type: {this.ToString()}. Publisher Name is: {Name}.");
        }
    }
}
