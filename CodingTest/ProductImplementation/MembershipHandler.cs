using CodingTest.Notification;
using CodingTest.ProductTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.ProductImplementation
{
    public class MembershipHandler : IMembership
    {
        private readonly MembershipType _membershipType;
        private readonly INotifier _notificationService;

        public MembershipHandler(MembershipType mt, INotifier notificationService)
        {
            _membershipType = mt;
            _notificationService = notificationService;
        }

        public void ActivateMembership(MembershipType mt)
        {
            if (_membershipType == MembershipType.Regular)
            {
                Console.WriteLine("Membership activated");
            }
            if (_membershipType == MembershipType.Premium)
            {
                Console.WriteLine("Membership upgraded to Premium");
            }
        }

        public void MakePayment()
        {
            string emailMessage = string.Empty;
            if (_membershipType == MembershipType.Regular)
            {
                Console.WriteLine("Payment made for activating membership");
                emailMessage = "Your membership is successfully activated";
            }
            if (_membershipType == MembershipType.Premium)
            {
                Console.WriteLine("Payment made for upgrading membership");
                emailMessage = "Your membership is successfully upgraded";
            }
            ActivateMembership(_membershipType);
            _notificationService.NotifyUser(emailMessage);
        }
    }
}
