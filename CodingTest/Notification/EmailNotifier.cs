using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Notification
{
    public class EmailNotifier : INotifier
    {
        public void NotifyUser(string emailContent)
        {
            Console.WriteLine("User notified via Email!");
        }
    }
}
