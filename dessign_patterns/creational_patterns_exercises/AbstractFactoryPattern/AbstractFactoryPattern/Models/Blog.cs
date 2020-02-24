namespace AbstractBookPublishingFactory.Models
{
    using System;
    public class Blog : IPublisher
    {
        public string Name { get; set; }
        public Blog(string name)
        {
            Name = name;
            Console.WriteLine($"Made an IPublisher of type: {this.ToString()}. Publisher Name is: {Name}.");
        }
    }
}
