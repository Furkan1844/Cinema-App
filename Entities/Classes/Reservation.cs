using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class Reservation
    {
        public string customerName;
        public int seatNumber;
        private Session session;
        public Session Session
        {
            get { return session; }
            set { session = value; }
        }
        public int TicketQuantity()
        {
            Console.Write("Number of Ticket : ");
            int numberOfTicket = Convert.ToInt32(Console.ReadLine());
            return numberOfTicket;
        }

        public void TicketInformation(string customerName, string movieName, string hallName, string sessionTime, List<int> seats)
        {
            Console.WriteLine("{0,40}{1,-50}", "", $"Customer Name : \"{customerName}\"");
            Console.WriteLine("{0,40}{1,-50}", "", $"Movie Name : \"{movieName}\"");
            Console.WriteLine("{0,40}{1,-50}", "", $"Hall Name : \"{hallName}\"");
            Console.WriteLine("{0,40}{1,-50}", "", $"At \"{sessionTime}\" o'clock");
            Console.Write("{0,40}{1,-5}", "", $"Seats : ");
            foreach ( int seat in seats)
            {
                Console.Write($"\"{seat}\", ");
            }
        }
    }
}
