using System;

namespace App.Srp.Good.Validators
{
    public class UserValidator : IUserValidator
    {
        public void ValidateUserName(string userName)
        {
            Console.WriteLine("Validate name correctness");
        }

        public void ValidateUserEmail(string userEmail)
        {
            Console.WriteLine("Validate email correctness");
        }
    }
}