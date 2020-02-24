namespace AbstractBookPublishingFactory.Models
{
    using System;
    public class PoemFactory : IBookFactory
    {
        private string _author;
        private string _title;
        private string _publisher;
        public PoemFactory(string author, string title, string publisher)
        {
            this._author = author;
            this._title = author;
            this._publisher = publisher;
            Console.WriteLine($"Made an IBookFactory of type: {this.ToString()}. aurthor: {author} title: {author} publisher: {publisher}");
        }

        public IBook MakeBook()
        {
            return new Poem(author: _author, title: _title);
        }

        public IPublisher MakePublisher()
        {
            return new Blog(name: _publisher);
        }
    }
}
