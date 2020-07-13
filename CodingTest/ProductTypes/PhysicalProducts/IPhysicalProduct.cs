using CodingTest.ProductTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.ProductTypes.PhysicalProducts
{
    public interface IPhysicalProduct : IProduct
    {
        void GeneratePackingSlipForShipping();

        void PayCommisionToAgent(int commisionInPercentage);
    }
}
