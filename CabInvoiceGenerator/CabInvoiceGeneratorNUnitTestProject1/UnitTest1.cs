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
            Assert.AreEqual(expectedSummary.averageFare, summary.averageFare);
            Assert.AreEqual(expectedSummary.totalFare, summary.totalFare);
            Assert.AreEqual(expectedSummary.numberOfRides, summary.numberOfRides);

        }

    }
}