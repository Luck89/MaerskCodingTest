using CodingTest.Notification;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BusinessRuleEngine.Tests
{
    public class NotificationTests
    {
        [Fact]
        public void NotifyUserMustNotifyUser()
        {
            var notification = new EmailNotifier();
            notification.NotifyUser("Test Message");
            return;
        }
    }
}
