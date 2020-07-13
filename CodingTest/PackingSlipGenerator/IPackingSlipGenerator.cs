using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.PackingSlipGenerator
{
    public interface IPackingSlipGenerator
    {
        void GeneratePackingSlip(PackingSlipDestination _packingSlipDestination);
    }

    public enum PackingSlipDestination
    {
        Shipping = 1,
        RoyaltyDepartment = 2
    }
}
