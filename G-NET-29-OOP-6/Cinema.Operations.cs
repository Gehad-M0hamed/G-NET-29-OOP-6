using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_29_OOP_6
{

    public partial class Cinema
    {
        private List<Ticket> tickets = new List<Ticket>();

        public void AddTicket(Ticket ticket) => tickets.Add(ticket);

        public void Open() => System.Console.WriteLine("=== Cinema Opened ===");
        public void Close() => System.Console.WriteLine("\n=== Cinema Closed ===");
    }
}
