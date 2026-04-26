using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_29_OOP_6
{
    public static class TicketExtensions
    {
        public static string GenerateReceipt(this Ticket t)
        {
            return $"\n========= RECEIPT =========\n" +
                   $"Movie  : {t.MovieTitle}\n" +
                   $"Type   : {t.GetType().Name.Replace("Ticket", "")}\n" +
                   $"Price  : {t.BasePrice}\n" +
                   $"Final  : {t.CalculateFinalPrice():F2}\n" +
                   $"Status : {(t.IsBooked ? "Booked" : "Available")}\n" +
                   $"============================";
        }

        public static double GetTotalRevenue(this List<Ticket> ticketList)
        {
            double total = 0;
            foreach (var t in ticketList)
                if (t.IsBooked) total += t.CalculateFinalPrice();
            return total;
        }
    }
}
