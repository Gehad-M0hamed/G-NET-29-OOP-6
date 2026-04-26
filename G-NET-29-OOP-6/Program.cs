using System;
using System.ComponentModel;
using System.Numerics;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_29_OOP_6
{
    internal class Program
    {
        //Part 01 : Theoretical Questions

        #region Q1 :
        //*is the process of exposing only what the user needs and hiding how it is implemented.
        //    Abstraction:Remote Control
        //    What an object does

        //    Encapsulation:TV Casing
        //    How data is protected
        #endregion

        #region Q2:
        // Interface:
        //     *What you can do
        //     *Defines roles & capabilities
        //     * Supports multiple inheritance
        //     *It cannot contain a constructor or data fields.
        // Abstract Class:
        //     *What you are
        //     * Defines identity & shared behavior
        //     *It only supports individual inheritance
        //     * It can contain a constructor and data fields.
        //Interface (Interface)
        #endregion

        #region Q3:
        //a) No,Appliance class is marked with the abstract keyword.In C#, abstract classes are "incomplete" and cannot be instantiated directly.
        //b)*PowerConsumption():It has no implementation(body) in the Appliance class.
        //                     abstract because every appliance has a power consumption, but the specific value is different for every device.

        //  * Status():It has a default implementation ("Standby") but can be changed.
        //              virtual because most appliances might share the same default status, but some(like WashingMachine) need to provide a different specific status.

        //  * Label():It has a full implementation that cannot be overridden.
        //             oncrete because the logic for generating a label(Brand + Power) is a shared workflow that is identical for all appliances.

        //c)"Standby",Because the Toaster class inherits from Appliance but has not override the Status() method,So That it automatically uses the default implementation found in the parent class.
        #endregion

        #region Q4:
        //a)*Partial Class:allows you to split a single class definition across multiple files — the compiler merges them into one class.
        //  *Organize large classes,Enable code generation,
        //b)Partial method :is declared in one part of a partial class and optionally implemented in another part.
        //  Deletion and Compilation: If the implementation is deleted, the code will still compile.
        //    partial method is not implemented, the compiler simply removes the call to that method entirely during compilation.

        //c)extension method lets you add new methods to an existing type without modifying its source code, without inheritance, and without recompiling.
        //    1*static class
        //    2*static method
        //    3*this on 1st param

        //d)    Log: result = 20
        //      $20.00
        #endregion

        #region Part02:
        static void Main(string[] args)
        {
            Cinema myCinema = new Cinema();
                myCinema.Open();

                // Ticket t = new Ticket(0, "Test", 100); 

                var t1 = new StandardTicket(1, "Inception", 80, "A5");
                var t2 = new VIPTicket(2, "Avengers", 200, 50);
                var t3 = new IMAXTicket(3, "Dune", 130);

                t1.BookTicket();
                t2.BookTicket();
                t3.BookTicket();

                myCinema.AddTicket(t1);
                myCinema.AddTicket(t2);
                myCinema.AddTicket(t3);
                myCinema.PrintAllTickets();

                System.Console.WriteLine("\n--- Polymorphism: Final Price per Ticket ---");
                Ticket[] ticketArray = { t1, t2, t3 };
                foreach (var t in ticketArray)
                {
                    System.Console.WriteLine($"{t.GetType().Name} => Final Price: {t.CalculateFinalPrice():F2}");
                }

                System.Console.WriteLine("\n--- Extension Method: Receipt ---");
                System.Console.WriteLine(t2.GenerateReceipt());

                System.Console.WriteLine("\n--- Extension Method: Total Revenue ---");
                double revenue = myCinema.GetTicketsList().GetTotalRevenue();
                System.Console.WriteLine($"Total Revenue: {revenue:F2}");

                myCinema.Close();
            }
        
        #endregion

      
           
    }
}


