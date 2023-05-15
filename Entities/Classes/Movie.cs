using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading  .Tasks;

namespace Entities.Classes
{
    public class Movie
    {
        public string movieName;
        public string movieGenre;
        private int movieLength;
        public int MovieLength
        {
            get { return movieLength; }
            set { movieLength = value; }
        }

        public Movie(string movieName, string movieGenre, int movieLength)
        {
            this.movieName = movieName;
            this.movieGenre = movieGenre;
            this.movieLength = movieLength;
            SetMovieLength(movieLength);
        }
        public string SetMovieLength(int length)
        {
            int hours = length / 60;
            int minutes = length % 60;
            return hours + " hours " + minutes + " minutes";
        }
        public int GetMovie(List<Movie> movieList)
        {
            Console.Write($"\nChoose the movie(1-{movieList.Count()}) : ");
            int choiceOfMovie = Convert.ToInt32(Console.ReadLine());
            while (choiceOfMovie < 0 || choiceOfMovie > movieList.Count())
            {
                Console.WriteLine("Please Enter A Valid Number!");
                return GetMovie(movieList);
            }
            return choiceOfMovie;
            
        }
    }
    
}
