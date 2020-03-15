namespace AbstractBookPublishingFactory
{
    using AbstractBookPublishingFactory.Models;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var poemFactory = new PoemFactory();
            poemFactory.Author = "Edgar Allan Poe";
            poemFactory.Title = "The Raven";
            poemFactory.Publisher = "The American Review";

            var researchFactory = new ResearchPaperFactory();
            researchFactory.Author = "Charles Darwin";
            researchFactory.Title = "On the Origin of Species";
            researchFactory.Publisher = "John Murray";

            ClientCode internetPortal = new ClientCode();
            Console.WriteLine("Publish POEM!");
            internetPortal.Publish(poemFactory);
            Console.WriteLine("Publish RESEARCH!");
            internetPortal.Publish(researchFactory);
        }
    }

}
