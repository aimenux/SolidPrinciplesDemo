using System;
using App.Extensions;
using App.Srp.Bad.Services;

namespace App.Srp.Bad
{
    public static class SrpBadExample
    {
        public static void Run()
        {
            ConsoleColor.Red.WriteLine(nameof(SrpBadExample));

            var service = new RegisterService();
            service.RegisterUser("me", "me@home.com");
        }
    }
}
