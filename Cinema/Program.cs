using System.Threading.Channels;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using Entities.Classes;

namespace Cinema
{
    public class Program
    {
        static void Main(string[] args)
        {
            Reservation reservation = new Reservation();

            Hall hall = new Hall(null, 0);
            Hall hall1 = new Hall("Hall 1", 100);    // objects are created from Hall class
            Hall hall2 = new Hall("Hall 2", 100);
            Hall hall3 = new Hall("Hall 3", 100);
            Hall hall4 = new Hall("Hall 4", 100);
            Hall hall5 = new Hall("Hall 5", 100);
            Hall hall6 = new Hall("Hall 6", 100);

            List<Movie> movieList = new List<Movie>();  // created a list which type is Movie

            Movie movie = new Movie(null, null, 0);
            Movie movie1 = new Movie("Once Upon a Time in America", "Drama, Crime", 251);   // objects are created from Movie class
            Movie movie2 = new Movie("Vertigo", "Mystery, Romance, Thriller", 130);
            Movie movie3 = new Movie("Mulholland Drive", "Drama, Mystery, Thriller, Film noir", 147);
            Movie movie4 = new Movie("Taxi Driver", "Drama, Crime", 114);
            Movie movie5 = new Movie("2001: A Space Odyssey", "Drama, Sci-Fi, Thriller", 141);
            Movie movie6 = new Movie("Eyes Wide Shut", "Thriller, Drama", 159);

            movieList.Add(movie1);  // objects added to the list
            movieList.Add(movie2);
            movieList.Add(movie3);
            movieList.Add(movie4);
            movieList.Add(movie5);
            movieList.Add(movie6);

            Console.WriteLine("{0,60}", "---Movies in Theaters---\n");
            Console.WriteLine(String.Format("{0,-3} {1,-35} {2,-35} {3,19}\n","","Movie Name", "Movie Genre", "Movie Length" ));

            int numberOfMovie = 1;

            foreach (Movie movieIns in movieList)
            {
                Console.WriteLine("{0,-3} {1,-35} {2,-35} {3,25}", numberOfMovie, movieIns.movieName, movieIns.movieGenre, movieIns.SetMovieLength(movieIns.MovieLength));
                numberOfMovie += 1;
            }
            
            List<Session> sessionOfMovie1 = new List<Session>();    // created a list which type is Session
            Session session = new Session(null, null, null);
            Session movie1Session1 = new Session(movie1, hall1, "10:30");   // objects are created from Session class
            Session movie1Session2 = new Session(movie1, hall1, "15:45");
            Session movie1Session3 = new Session(movie1, hall1, "21:15");
            sessionOfMovie1.Add(movie1Session1);  // objects added to the list
            sessionOfMovie1.Add(movie1Session2);
            sessionOfMovie1.Add(movie1Session3);
            List<Session> sessionOfMovie2 = new List<Session>();
            Session movie2Session1 = new Session(movie2, hall2, "10:30");
            Session movie2Session2 = new Session(movie2, hall2, "15:45");
            Session movie2Session3 = new Session(movie2, hall2, "21:15");
            sessionOfMovie2.Add(movie2Session1);
            sessionOfMovie2.Add(movie2Session2);
            sessionOfMovie2.Add(movie2Session3);
            List<Session> sessionOfMovie3 = new List<Session>();
            Session movie3Session1 = new Session(movie3, hall3, "10:30");
            Session movie3Session2 = new Session(movie3, hall3, "15:45");
            Session movie3Session3 = new Session(movie3, hall3, "21:15");
            sessionOfMovie3.Add(movie3Session1);
            sessionOfMovie3.Add(movie3Session2);
            sessionOfMovie3.Add(movie3Session3);
            List<Session> sessionOfMovie4 = new List<Session>();
            Session movie4Session1 = new Session(movie4, hall4, "10:30");
            Session movie4Session2 = new Session(movie4, hall4, "15:45");
            Session movie4Session3 = new Session(movie4, hall4, "21:15");
            sessionOfMovie4.Add(movie4Session1);
            sessionOfMovie4.Add(movie4Session2);
            sessionOfMovie4.Add(movie4Session3);
            List<Session> sessionOfMovie5 = new List<Session>();
            Session movie5Session1 = new Session(movie5, hall5, "10:30");
            Session movie5Session2 = new Session(movie5, hall5, "15:45");
            Session movie5Session3 = new Session(movie5, hall5, "21:15");
            sessionOfMovie5.Add(movie5Session1);
            sessionOfMovie5.Add(movie5Session2);
            sessionOfMovie5.Add(movie5Session3);
            List<Session> sessionOfMovie6 = new List<Session>();
            Session movie6Session1 = new Session(movie6, hall6, "10:30");
            Session movie6Session2 = new Session(movie6, hall6, "15:45");
            Session movie6Session3 = new Session(movie6, hall6, "21:15");
            sessionOfMovie6.Add(movie6Session1);
            sessionOfMovie6.Add(movie6Session2);
            sessionOfMovie6.Add(movie6Session3);

            string text = (String.Format("\n{0,-3} {1,-35} {2,-35} {3,11}\n", "", "Movie Name", "Hall Number", "Time"));

            int choiceOfMovie = movie.GetMovie(movieList);

            hall.hallName = "";
            movie.movieName = "";
            List<int> seats = new List<int>();
            
            try 
            {
                switch (choiceOfMovie)
                {
                    case 1:
                        Console.WriteLine("{0,70}", "---Sessions for " + movie1.movieName + "---");
                        Console.WriteLine(text);
                        session.GetSession(sessionOfMovie1);
                        movie.movieName = movie1.movieName;
                        hall.hallName = hall1.hallName;
                        seats = hall1.EmptySeats(hall1.hallCapasity);
                        break;
                    case 2:
                        Console.WriteLine("{0,60}", "---Sessions for " + movie2.movieName + "---");
                        Console.WriteLine(text);
                        session.GetSession(sessionOfMovie2);
                        movie.movieName = movie2.movieName;
                        hall.hallName = hall2.hallName;
                        seats = hall2.EmptySeats(hall2.hallCapasity);
                        break;
                    case 3:
                        Console.WriteLine("{0,65}", "---Sessions for " + movie3.movieName + "---");
                        Console.WriteLine(text);
                        session.GetSession(sessionOfMovie3);
                        movie.movieName = movie3.movieName;
                        hall.hallName = hall3.hallName;
                        seats = hall3.EmptySeats(hall3.hallCapasity);
                        break;
                    case 4:
                        Console.WriteLine("{0,60}", "---Sessions for " + movie4.movieName + "---");
                        Console.WriteLine(text);
                        session.GetSession(sessionOfMovie4);
                        movie.movieName = movie4.movieName;
                        hall.hallName = hall4.hallName;
                        seats = hall4.EmptySeats(hall4.hallCapasity);
                        break;
                    case 5:
                        Console.WriteLine("{0,70}", "---Sessions for " + movie5.movieName + "---");
                        Console.WriteLine(text);
                        session.GetSession(sessionOfMovie5);
                        movie.movieName = movie5.movieName;
                        hall.hallName = hall5.hallName;
                        seats = hall5.EmptySeats(hall5.hallCapasity);
                        break;
                    case 6:
                        Console.WriteLine("{0,65}", "---Sessions for " + movie6.movieName + "---");
                        Console.WriteLine(text);
                        session.GetSession(sessionOfMovie6);
                        movie.movieName = movie6.movieName;
                        hall.hallName = hall6.hallName;
                        seats = hall6.EmptySeats(hall6.hallCapasity);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.Write("Customer Name : ");
            reservation.customerName = (Console.ReadLine());
            Console.WriteLine("");

            reservation.TicketInformation(reservation.customerName, movie.movieName, hall.hallName, session.sessionTime, seats);

            
        }
    }
}