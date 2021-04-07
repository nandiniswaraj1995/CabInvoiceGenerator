using NUnit.Framework;
using CAbInvoiceGenarator;
using System;

namespace CabInvoiceGeneratorNUnitTestProject1
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
        [Test]
        public void GivenMultipleRideShouldReturnInvoiceSummary()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(4.0, 5), new Ride(8.0, 5) };
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(3, 155);
            Assert.AreEqual(expectedSummary, summary);
          
        }
        [Test]
        public void GivenMultipleRideShouldReturnInvoiceSummaryInDetails()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(4.0, 5), new Ride(8.0, 5) };
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(3, 155);
            Assert.AreEqual(expectedSummary.GetHashCode(), summary.GetHashCode());
            

        }
        [Test]
        public void GivenUserIdShouldReturnInvoiceSummaryIn()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            RideRepository repo = new RideRepository();
            Ride[] rides = { new Ride(2.0, 5), new Ride(4.0, 5), new Ride(8.0, 5) };
            InvoiceSummary summary1 = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary summary = invoiceGenerator.GetInvoiceSummary("101");
            InvoiceSummary expectedSummary = new InvoiceSummary(3,155);
            Assert.AreEqual(expectedSummary.GetHashCode(),summary.GetHashCode());


        }

    }
}