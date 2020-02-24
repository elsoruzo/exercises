namespace AbstractBookPublishingFactory.Models
{
    using System;

    public class ResearchPaperFactory : IBookFactory
    {
        private string _author;
        private string _title;
        private string _publisher; 

        public ResearchPaperFactory(string author, string title, string publisher)
        {
            this._author = author;
            this._title = title;
            this._publisher = publisher;
            Console.WriteLine($"Made an IBookFactory of type: {this.ToString()}. aurthor: {author} title: {author} publisher: {publisher}");
        }

        public IBook MakeBook()
        {
            return new ResearchPaper(author: _author, title: _title);
        }

        public IPublisher MakePublisher()
        {
            return new ScientificJournal(name: _publisher);
        }
    }
}
