namespace AbstractBookPublishingFactory.Models
{
    using System;

    public class ResearchPaperFactory : IBookFactory
    {
        public string Author;
        public string Title;
        public string Publisher; 


        public IBook MakeBook()
        {
            return new ResearchPaper();
        }

        public IPublisher MakePublisher()
        {
            return new ScientificJournal();
        }
    }
}
