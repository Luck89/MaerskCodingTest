using CodingTest.ProductImplementation;
using CodingTest.ProductTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest
{
    public class PaymentHandler
    {
        private List<IProduct> _payments;

        public PaymentHandler()
        {
            _payments = new List<IProduct>();
            _payments.Add(new PhysicalProduct());
            _payments.Add(new ProductBook());
        }
        public void InitializePayment()
        {

            Console.WriteLine("A simple demonstration of Business Rules Engine");

        }


    }
}
