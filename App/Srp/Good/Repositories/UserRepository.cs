using System;

namespace App.SRP.Good.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void SaveUser(string userName, string userEmail)
        {
            Console.WriteLine("Saving user informations in database");
        }
    }
}