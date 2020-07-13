using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.PackingSlipGenerator
{
    public class PackingSlpGenerator : IPackingSlipGenerator
    {
        public void GeneratePackingSlip(PackingSlipDestination _packingSlipDestination)
        {
            if (_packingSlipDestination == PackingSlipDestination.RoyaltyDepartment)
            {
                Console.WriteLine("Duplicate packing slip generated for Royalty Department");
            }
            if (_packingSlipDestination == PackingSlipDestination.Shipping)
            {
                Console.WriteLine("Packing slip generated for Shipping Department");
            }
        }
    }
}
