using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.ProductTypes.PhysicalProducts
{
    public interface IBook : IPhysicalProduct
    {
        Task GeneratePackingSlipForRoyaltyDepartment();
    }
}
