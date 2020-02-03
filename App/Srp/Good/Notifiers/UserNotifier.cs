using System;

namespace App.SRP.Good.Notifiers
{
    public class UserNotifier : IUserNotifier
    {
        public void NotifyUser(string userName, string userEmail)
        {
            Console.WriteLine("Sending email to user to confirm registration");
        }
    }
}