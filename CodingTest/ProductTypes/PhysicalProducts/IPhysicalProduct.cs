using CodingTest.ProductTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.ProductTypes.PhysicalProducts
{
    public interface IPhysicalProduct : IProduct
    {
        Task GeneratePackingSlip();

        Task PayCommisionToAgent(int commisionInPercentage);
    }
}
