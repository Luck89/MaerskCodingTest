using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Notification
{
    public interface INotifier
    {
        void NotifyUser(string emailContent);
    }
}
