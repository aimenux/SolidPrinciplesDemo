using System;

namespace App.Srp.Bad.Services
{
    public class RegisterService : IRegisterService
    {
        public void RegisterUser(string userName, string userEmail)
        {
            ValidateUserName(userName);
            ValidateUserEmail(userEmail);
            SaveUser(userName, userEmail);
            NotifyUser(userName, userEmail);
        }

        private static void ValidateUserName(string userName)
        {
            Console.WriteLine("Validate name correctness");
        }

        private static void ValidateUserEmail(string userEmail)
        {
            Console.WriteLine("Validate email correctness");
        }

        private static void SaveUser(string userName, string userEmail)
        {
            Console.WriteLine("Saving user informations in database");
        }

        private static void NotifyUser(string userName, string userEmail)
        {
            Console.WriteLine("Sending email to user to confirm registration");
        }
    }
}
