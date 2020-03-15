namespace PrototypePattern.Models
{
    using System.Collections.Generic;
    public interface IMovieCharacteristics
    {
        string MovieName { get; set; }
        string ReleaseDate { get; set; }
        List<string> Genre { get; set; }
        List<string> Ratings { get; set; }
        MovieCharacteristics Clone();
        void GetData();
        string ToString();
    }
}