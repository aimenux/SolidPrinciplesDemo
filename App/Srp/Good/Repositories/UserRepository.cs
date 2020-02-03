using System;

namespace App.Srp.Good.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void SaveUser(string userName, string userEmail)
        {
            Console.WriteLine("Saving user informations in database");
        }
    }
}