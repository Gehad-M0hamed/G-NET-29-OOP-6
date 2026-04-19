using System.ComponentModel;
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











        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
}


