namespace PrototypePattern.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MovieCharacteristics : IMovieCharacteristics
    {
        public string MovieName { get; set; }
        public string ReleaseDate { get; set; }
        public IList<string> Genre { get; set; }
        public IList<string> Ratings { get; set; }

        public MovieCharacteristics()
        {
            Console.WriteLine("Defaut Constructor");
        }

        public MovieCharacteristics(string movieName, string releaseDate, IList<string> genre, IList<string> ratings)
        {
            this.MovieName = movieName;
            this.ReleaseDate = releaseDate;
            this.Genre = genre;
            this.Ratings = ratings;
        }

        public void GetData()
        {
            var movieDataService = new MovieDataService();
            var movieData = movieDataService.GetData(this);
            this.MovieName = movieData.MovieName;
            this.ReleaseDate = movieData.ReleaseDate;
            this.Genre = movieData.Genre;
            this.Ratings = movieData.Ratings;
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
            (this.Genre as List<string>).ForEach(g => result.Append(g).Append(" "));
            result.Append("Ratings: ");
            (this.Ratings as List<string>).ForEach(g => result.Append(g).Append(" "));
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
