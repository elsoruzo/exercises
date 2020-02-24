namespace AbstractBookPublishingFactory.Models
{
    using System;

    public class ResearchPaper : IBook
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public ResearchPaper(string author, string title)
        {
            Author = author;
            Title = title;
            Console.WriteLine($"Made an IBook of type: {this.ToString()}.The author is: {Author} and the title is: {Title}");
        }
    }
}
