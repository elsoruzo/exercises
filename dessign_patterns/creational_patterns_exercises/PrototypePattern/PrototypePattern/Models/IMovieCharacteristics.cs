namespace PrototypePattern.Models
{
    using System.Collections.Generic;
    public interface IMovieCharacteristics
    {
        string MovieName { get; set; }
        string ReleaseDate { get; set; }
        IList<string> Genre { get; set; }
        IList<string> Ratings { get; set; }
        MovieCharacteristics Clone();
        void GetData();
        string ToString();
    }
}