namespace AbstractBookPublishingFactory
{
    using AbstractBookPublishingFactory.Models;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Create a PoemFactory, generating a Poem book type and a Blog publisher type.
            var poemFactory = new PoemFactory(author: "Edgar Allan Poe",
                            title: "The Raven",
                            publisher: "The American Review");

            // Create a ResearchPaperFactory, generating a ResearchPaper book type
            // and a ScientificJournal publisher type.
            var researchFactory  = new ResearchPaperFactory(author: "Charles Darwin",
                                     title: "On the Origin of Species",
                                     publisher: "John Murray");
            ClientCode internetPortal = new ClientCode();
            Console.WriteLine("Publish POEM!");
            internetPortal.Publish(poemFactory);
            Console.WriteLine("Publish RESEARCH!");
            internetPortal.Publish(researchFactory);
        }
    }

}
