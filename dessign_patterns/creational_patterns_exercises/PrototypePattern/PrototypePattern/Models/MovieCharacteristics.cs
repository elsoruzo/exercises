namespace PrototypePattern.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MovieCharacteristics : IMovieCharacteristics
    {
        public string MovieName { get; set; }
        public string ReleaseDate { get; set; }
        public List<string> Genre { get; set; }
        public List<string> Ratings { get; set; }

        public MovieCharacteristics()
        {
            Console.WriteLine("Defaut Constructor");
        }

        public MovieCharacteristics(string movieName, string releaseDate, List<string> genre, List<string> ratings)
        {
            this.MovieName = movieName;
            this.ReleaseDate = releaseDate;
            this.Genre = genre;
            this.Ratings = ratings;
        }

        public void GetData()
        {
            Console.WriteLine("Getting Data from External REST API");
            this.MovieName = "The Dark Knight";
            this.ReleaseDate = "2018";
            this.Genre = new List<string>();
            this.Genre.Add("Drama");
            this.Genre.Add("Thriller");
            this.Ratings = new List<string>();
            this.Ratings.Add("IMDB:9");
            this.Ratings.Add("RottenTomatoes:94%");
            this.Ratings.Add("MetaCritic:84%");
            Console.WriteLine("You have been charged 1$ for last API call.");
        }

        public override string ToString()
        {
            return GetInfoMovieDataBaseDeep();
        }

        private string GetInfoMovieDataBaseDeep()
        {
            var result = new StringBuilder();
            var nameAndDateInfo = string.Format("MovieDataBaseDeep movieName: {0}, releaseDate: {1} ", this.MovieName, this.ReleaseDate);
            result.Append(nameAndDateInfo);
            result.Append("Genres: ");
            this.Genre.ForEach(g => result.Append(g).Append(" "));
            result.Append("Ratings: ");
            this.Ratings.ForEach(g => result.Append(g).Append(" "));
            return result.ToString();
        }

        public virtual MovieCharacteristics Clone()
        {
            List<string> deepRatings = new List<string>();
            deepRatings.AddRange(this.Ratings);

            return new MovieCharacteristics(this.MovieName, this.ReleaseDate, this.Genre, deepRatings);
        }
    }
}
