namespace PrototypePattern.Models
{
    using System;
    using PrototypePattern.Models;
    using System.Linq;
    using System.Collections.Generic;

    public class CLientConfigurator
    {
        public void ConfigureGeneralGenre(IMovieCharacteristics movieCharacteristics)
        {
           movieCharacteristics.Genre.Add("SuperHero");
        }

        public void ConfigureImdbData(IMovieCharacteristics movieCharacteristics)
        {
            var resultImdb = (movieCharacteristics.Ratings as List<string>).Find(x => x.Contains("IMDB"));
            var newRatings = new List<string>();
            newRatings.Add(resultImdb);
            movieCharacteristics.Ratings = newRatings;
        }

        public void ConfigureRottenTomatoesData(IMovieCharacteristics movieCharacteristics)
        {
            var resultImdb = (movieCharacteristics.Ratings as List<string>).Find(x => x.Contains("RottenTomatoes"));
            var newRatings = new List<string>();
            newRatings.Add(resultImdb);
            movieCharacteristics.Ratings = newRatings;
        }

    }
}
