using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern.Models
{
    public class MovieDataService
    {
        public IMovieCharacteristics GetData(IMovieCharacteristics movieCharacteristics)
        {
            Console.WriteLine("Getting Data from External REST API");
            movieCharacteristics.MovieName = "The Dark Knight";
            movieCharacteristics.ReleaseDate = "2018";
            movieCharacteristics.Genre = new List<string>();
            movieCharacteristics.Genre.Add("Drama");
            movieCharacteristics.Genre.Add("Thriller");
            movieCharacteristics.Ratings = new List<string>();
            movieCharacteristics.Ratings.Add("IMDB:9");
            movieCharacteristics.Ratings.Add("RottenTomatoes:94%");
            movieCharacteristics.Ratings.Add("MetaCritic:84%");
            Console.WriteLine("You have been charged 1$ for last API call.");
            return movieCharacteristics;
        }
    }
}
