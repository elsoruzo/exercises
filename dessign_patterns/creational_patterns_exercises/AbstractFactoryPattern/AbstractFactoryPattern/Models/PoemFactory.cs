namespace AbstractBookPublishingFactory.Models
{
    using System;
    public class PoemFactory : IBookFactory
    {
        public string Author;
        public string Title;
        public string Publisher;

        public IBook MakeBook()
        {
            return new Poem();
        }

        public IPublisher MakePublisher()
        {
            return new Blog();
        }
    }
}
