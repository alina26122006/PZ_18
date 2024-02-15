using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_na_pare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlightTicket ticket1 = new FlightTicket(FlightTicket.TicketCategory.Economy, "3", "Астафьева Анна", new DateTime(2006, 06, 10), new DateTime(2024, 07, 13, 12, 0, 0));
            ticket1.DisplayTicketInformation();
            ticket1.DisplayTimeRemaining();
            Console.WriteLine();

            FlightTicket ticket2 = new FlightTicket(FlightTicket.TicketCategory.Business, "17", "Мухамбетова Алина", new DateTime(2006, 12, 26), new DateTime(2024, 07, 13, 12, 30, 0));
            ticket2.DisplayTicketInformation();
            ticket2.DisplayTimeRemaining();
            Console.WriteLine();

            FlightTicket ticket3 = new FlightTicket(FlightTicket.TicketCategory.Business, "18", "Сарбаева Азалия", new DateTime(2006, 07, 30), new DateTime(2024, 07, 13, 12, 30, 0));
            ticket3.DisplayTicketInformation();
            ticket3.DisplayTimeRemaining();
            Console.WriteLine();

            FlightTicket ticket4 = new FlightTicket(FlightTicket.TicketCategory.Business, "19", "Винс Елена", new DateTime(2006, 07, 10), new DateTime(2024, 07, 13, 12, 30, 0));
            ticket4.DisplayTicketInformation();
            ticket4.DisplayTimeRemaining();
            Console.WriteLine();

            FlightTicket.DisplaySoldTicketsCount();
        }
    }
}
