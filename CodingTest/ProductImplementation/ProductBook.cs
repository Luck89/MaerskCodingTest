using CodingTest.PackingSlipGenerator;
using CodingTest.ProductTypes.PhysicalProducts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.ProductImplementation
{
    public class ProductBook : IBook
    {
        private readonly IPackingSlipGenerator _printService;
        public ProductBook(IPackingSlipGenerator printService)
        {
            _printService = printService;
        }
        public void GeneratePackingSlipForRoyaltyDepartment()
        {
            _printService.GeneratePackingSlip(PackingSlipDestination.RoyaltyDepartment);
        }

        public void GeneratePackingSlipForShipping()
        {
            _printService.GeneratePackingSlip(PackingSlipDestination.Shipping);
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
