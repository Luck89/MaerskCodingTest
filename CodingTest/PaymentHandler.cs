using CodingTest.Notification;
using CodingTest.PackingSlipGenerator;
using CodingTest.ProductImplementation;
using CodingTest.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest
{
    public class PaymentHandler
    {
        private readonly List<IProduct> _payments;

        public PaymentHandler(IPackingSlipGenerator slipService, INotifier _notifier)
        {
            _payments = new List<IProduct>();

            _payments.Add(new PhysicalProduct(slipService));
            _payments.Add(new ProductBook(slipService));
            _payments.Add(new MembershipHandler(MembershipType.Regular, _notifier));
            _payments.Add(new MembershipHandler(MembershipType.Premium, _notifier));
            _payments.Add(new VideoLearningHandler(VideoTypes.LearningToSki));
            _payments.Add(new VideoLearningHandler(VideoTypes.Others));
        }
        public void InitializePayment()
        {
            Console.WriteLine("A simple demonstration of Business Rules Engine");
            Console.WriteLine();

            if (_payments != null)
            {
                _payments.ForEach(pmt =>
                {
                    Console.WriteLine();
                    pmt.MakePayment();
                    Console.WriteLine();
                });
            }
            Console.ReadLine();
        }


    }
}
