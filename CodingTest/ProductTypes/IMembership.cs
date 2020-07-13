using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.ProductTypes
{
    public interface IMembership: IProduct
    {
        Task NotifyUserViaEmail(MembershipType mt);
        Task ActivateMembership(MembershipType mt);
        Task UpgradeMembership(MembershipType mt);
    }

    public enum MembershipType
    {
        Regular = 1,
        Premium = 2
    }
}
