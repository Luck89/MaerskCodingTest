using CodingTest;
using CodingTest.Notification;
using CodingTest.PackingSlipGenerator;
using CodingTest.ProductTypes;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BusinessRuleEngine.Tests
{
    public class PaymentHandlerTests : IClassFixture<PaymentHandlerFixture>
    {
        private PaymentHandlerFixture _fixture;
        public PaymentHandlerTests(PaymentHandlerFixture fixture)
        {
            _fixture = fixture;

            _fixture.mockNotifier = new Mock<INotifier>();
            _fixture.mockSlipGenerator = new Mock<IPackingSlipGenerator>();
            _fixture.mockProducts = new Mock<List<IProduct>>();
            _fixture._paymentHandler = new PaymentHandler(_fixture.mockSlipGenerator.Object, _fixture.mockNotifier.Object);
        }

        [Fact]
        public void InitializePaymentMustInitializePayments()
        {
            _fixture._paymentHandler.InitializePayment();
            return;
        }
    }

    public class PaymentHandlerFixture
    {
        public PaymentHandler _paymentHandler;
        public Mock<IPackingSlipGenerator> mockSlipGenerator;
        public Mock<INotifier> mockNotifier;
        public Mock<List<IProduct>> mockProducts;
    }
}
