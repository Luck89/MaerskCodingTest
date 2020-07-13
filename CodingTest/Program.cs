using System;
using CodingTest.Notification;
using CodingTest.PackingSlipGenerator;
using Microsoft.Extensions.DependencyInjection;

namespace CodingTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            //Service configuration setup for dependency injection
            serviceCollection.AddTransient<INotifier, EmailNotifier>();
            serviceCollection.AddTransient<IPackingSlipGenerator, PackingSlpGenerator>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            // This is where dependency is injected and the instance is created
            PaymentHandler ph = ActivatorUtilities.CreateInstance<PaymentHandler>(serviceProvider);

            ph.InitializePayment();
        }
    }
}
