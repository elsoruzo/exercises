namespace AbstractBookPublishingFactory.Models
{
    using System;
    public class Poem : IBook
    {
        public string Author { get; set; }
        public string Title { get; set; }

    }
}
