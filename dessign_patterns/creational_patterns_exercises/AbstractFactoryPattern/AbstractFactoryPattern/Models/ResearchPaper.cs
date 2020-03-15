namespace AbstractBookPublishingFactory.Models
{
    using System;

    public class ResearchPaper : IBook
    {
        public string Author { get; set; }
        public string Title { get; set; }
    }
}
