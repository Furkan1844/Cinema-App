using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class Session
    {
        public string sessionTime;
        private Hall hall;
        private Movie movie;
        public Hall Hall
        { 
            get { return hall; } 
            set { hall = value; } 
        }
        public Movie Movie 
        {
            get { return movie; }
            set { movie = value; }
        }
        
        public Session(Movie Movie, Hall Hall, string sessionTime)
        {
            this.sessionTime = sessionTime;
            this.hall = Hall;
            this.movie = Movie;
        }

        public int GetSession(List<Session> sessionOfMovie) //  prints out the sessions of selected movie and returns the choice of session
        {
            int numberOfSession = 1;
            
            foreach (Session session in sessionOfMovie)
            {
                Console.WriteLine("{0,-3} {1,-35} {2,-35} {3,12}", numberOfSession, session.Movie.movieName, session.Hall.hallName, session.sessionTime);
                numberOfSession += 1;
            }
            
            Console.Write($"\nChoose the session(1-{sessionOfMovie.Count()}) : ");
            
            int choiceOfSession = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            while (choiceOfSession > sessionOfMovie.Count() || choiceOfSession < 1)
            {
                Console.WriteLine("Please Enter A Valid Number!\n");
                return GetSession(sessionOfMovie);
            }
            return choiceOfSession;
        }
    }
}
