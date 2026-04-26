using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_29_OOP_6
{

    public partial class Cinema
    {
        public void PrintAllTickets()
        {
            System.Console.WriteLine("\n--- All Tickets (from Cinema.Reporting) ---");
            foreach (var t in tickets)
                System.Console.WriteLine($"{t.GetDetails()} | Final: {t.CalculateFinalPrice():F2}");
        }

        public List<Ticket> GetTicketsList() => tickets;
    }
}
