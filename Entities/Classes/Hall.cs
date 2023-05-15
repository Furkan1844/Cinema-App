using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class Hall : Reservation
    {
        Reservation reservation = new Reservation();
        public string hallName;
        public int hallCapasity;
        public Hall(string hallName, int hallCapasity)
        {
            this.hallName = hallName;
            this.hallCapasity = hallCapasity;
        }

        public List<int> AssignRandomSeat(int seatQuantity) //  creates random numbers and returns a list of seats indicates that not empty
        {
            Random random = new Random();

            List<int> seats = new List<int>();

            int randomNumber = random.Next(20, 50);
            for (int i = 0; i < randomNumber; i++)
            {
                int seat = random.Next(1, seatQuantity + 1);

                if (seats.Contains(seat))
                {
                    i--;
                    continue;
                }
                seats.Add(seat);
            }
            return seats;

        }

        public List<int> EmptySeats(int hallCapasity)   // takes parameter the capasity of hall and returns a list of seats which indicates that chosen seats by customer
        {
            Console.WriteLine("{0,57}", "---Empty Seats---\n");

            List<string> letters = new List<string>
            {
                "|A|", "|B|", "|C|", "|D|", "|E|", "|F|", "|G|", "|H|", "|I|", "|J|"
            };

            List<int> numbers = AssignRandomSeat(hallCapasity);    //  keeps randomly created numbers of seats which are not empty 

            int seat = 1;

            foreach (string letter in letters)  //  prints the seats weither chosen or empty in a panoramic way
            {
                Console.Write("{0,-10} {1,-15} ", "", letter);
                for (int i = 1; i <= 10; i++)
                {
                    if (numbers.Contains(seat))
                    {
                        Console.Write("{0,-5}", "|X|");
                    }
                    else
                    {
                        Console.Write("{0,-5}", seat);
                    }
                    seat++;
                }
                Console.WriteLine("\n");
            }

            int ticketQuantity = reservation.TicketQuantity();  //  uses the method "TicketQuantity()" from Reservation Class

            Console.WriteLine("\nChoose the seats : ");

            List<int> listOfSeats = new List<int>();    //  keeps the ticket numbers of seats

            for (int i = 1; i <= ticketQuantity; i++)
            {
                Console.Write("For Seat " + i + " - ");
                int numberOfSeat = Convert.ToInt32(Console.ReadLine());
                listOfSeats.Add(numberOfSeat);
            }
            Console.WriteLine("");
            return listOfSeats;
        }
    }
}
