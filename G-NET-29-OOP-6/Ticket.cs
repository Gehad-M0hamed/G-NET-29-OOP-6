using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_29_OOP_6
{
    public abstract class Ticket
    {
        public int TicketID { get; set; }
        public string MovieTitle { get; set; }
        public double BasePrice { get; set; }
        public bool IsBooked { get; private set; }

        protected Ticket(int id, string title, double price)
        {
            TicketID = id;
            MovieTitle = title;
            BasePrice = price;
        }

        public void BookTicket() => IsBooked = true;

        public abstract double CalculateFinalPrice();

        public virtual string GetDetails() =>
            $"[Ticket #{TicketID}] {MovieTitle} | Price: {BasePrice} | Booked: {(IsBooked ? "Yes" : "No")}";
    }

    public class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }
        public StandardTicket(int id, string title, double price, string seat) : base(id, title, price) => SeatNumber = seat;

        public override double CalculateFinalPrice() => BasePrice * 1.14;
        public override string GetDetails() => base.GetDetails().Replace("| Price", $" | Standard | Seat: {SeatNumber} | Price");
    }

    public class VIPTicket : Ticket
    {
        public double LoungeFee { get; set; }
        public VIPTicket(int id, string title, double price, double fee) : base(id, title, price) => LoungeFee = fee;

        public override double CalculateFinalPrice() => (BasePrice + LoungeFee) * 1.14;
        public override string GetDetails() => base.GetDetails().Replace("| Price", $" | VIP | Fee: {LoungeFee} | Price");
    }

    public class IMAXTicket : Ticket
    {
        public IMAXTicket(int id, string title, double price) : base(id, title, price) { }
        public override double CalculateFinalPrice() => (BasePrice + 50) * 1.14;
        public override string GetDetails() => base.GetDetails().Replace("| Price", $" | IMAX | 3D: Yes | Price");
    }
}
