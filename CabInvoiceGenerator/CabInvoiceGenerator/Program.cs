using CAbInvoiceGenarator;
using System;

namespace TDDTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RideRepository repo = new RideRepository();
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare : {fare}");
            Ride[] rides = { new Ride(2.0, 5), new Ride(4.0, 5),new Ride(8.0,5) };
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
           Console.WriteLine($"TotalFare : {summary.totalFare}");
            InvoiceSummary sum = invoiceGenerator.GetInvoiceSummary("101");
            Console.WriteLine("userId : "+101+" number of rides :"+sum.numberOfRides +"  average Fare : "+sum.averageFare+"  Total Fare "+sum.totalFare);

        }
    }

}
