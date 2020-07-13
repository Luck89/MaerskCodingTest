using CodingTest.ProductTypes.PhysicalProducts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.ProductImplementation
{
    public class PhysicalProduct : IPhysicalProduct
    {
        public void GeneratePackingSlipForShipping()
        {
            Console.WriteLine("Packing slip generated for shipping for Physical product");
        }

        public void MakePayment()
        {
            Console.WriteLine("Payment made for Physical Product.");
            GeneratePackingSlipForShipping();
            PayCommisionToAgent(10);
        }

        public void PayCommisionToAgent(int commisionInPercentage)
        {
            Console.WriteLine(commisionInPercentage + "% commision paid to agent for Physical product.");
        }
    }
}
