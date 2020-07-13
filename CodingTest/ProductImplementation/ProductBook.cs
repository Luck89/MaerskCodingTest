using CodingTest.ProductTypes.PhysicalProducts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.ProductImplementation
{
    public class ProductBook : IBook
    {
        public void GeneratePackingSlipForRoyaltyDepartment()
        {
            Console.WriteLine("Packing slip generated for the Royalty department for the purchase of the book");
        }

        public void GeneratePackingSlipForShipping()
        {
            Console.WriteLine("Packing slip generated for shipping of book");
        }

        public void MakePayment()
        {
            Console.WriteLine("Payment made for Book.");
            GeneratePackingSlipForShipping();
            GeneratePackingSlipForRoyaltyDepartment();
            PayCommisionToAgent(10);
        }

        public void PayCommisionToAgent(int commisionInPercentage)
        {
            Console.WriteLine(commisionInPercentage + "% commision paid to agent for the book.");
        }
    }
}
