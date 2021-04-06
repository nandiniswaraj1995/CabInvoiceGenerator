using CAbInvoiceGenarator;
using System;

namespace TDDTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare : {fare}");
            Ride[] rides = { new Ride(2.0, 5), new Ride(4.0, 5),new Ride(8.0,5) };
            double totalFare = invoiceGenerator.CalculateFareForMultipleRides(rides);
            Console.WriteLine($"AveragrFare : {totalFare}");


        }
    }
}
