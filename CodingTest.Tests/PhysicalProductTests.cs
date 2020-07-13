using CodingTest.PackingSlipGenerator;
using CodingTest.ProductImplementation;
using CodingTest.ProductTypes.PhysicalProducts;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingTest.Tests
{
    public class PhysicalProductTests : IClassFixture<PhysicalProductFixture>
    {
        private PhysicalProductFixture _fixture;

        public PhysicalProductTests(PhysicalProductFixture fixture)
        {
            _fixture = fixture;

            _fixture.mockSlipGenerator = new Mock<IPackingSlipGenerator>();

            _fixture.physicalProduct = new Mock<IPhysicalProduct>(_fixture.mockSlipGenerator.Object);
        }

        [Fact]
        public void GeneratePackingSlipForShippingMustGenerateSlip()
        {
            _fixture.physicalProduct.Verify(x => x.GeneratePackingSlipForShipping(), Times.AtLeastOnce);
        }
    }

    public class PhysicalProductFixture
    {
        public Mock<IPhysicalProduct> physicalProduct;
        public Mock<IPackingSlipGenerator> mockSlipGenerator;
    }
}
