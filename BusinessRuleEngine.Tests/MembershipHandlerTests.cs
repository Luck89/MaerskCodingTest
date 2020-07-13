using CodingTest.Notification;
using CodingTest.ProductImplementation;
using CodingTest.ProductTypes;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BusinessRuleEngine.Tests
{
    public class MembershipHandlerTests
    {
        [Fact]
        public void ActivateMembershipMustActivateMembership()
        {
            var mockNotifier = new Mock<INotifier>();
            MembershipHandler membership = new MembershipHandler(MembershipType.Regular, mockNotifier.Object);
            membership.ActivateMembership(MembershipType.Regular);
            return;
        }
    }
}
