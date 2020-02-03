using System;
using App.Extensions;
using App.SRP.Good.Notifiers;
using App.SRP.Good.Repositories;
using App.SRP.Good.Services;
using App.SRP.Good.Validators;

namespace App.SRP.Good
{
    public static class SrpGoodExample
    {
        public static void Run()
        {
            ConsoleColor.Green.WriteLine(nameof(SrpGoodExample));

            var validator = new UserValidator();
            var repository = new UserRepository();
            var notifier = new UserNotifier();
            var service = new RegisterService(validator, repository, notifier);
            service.RegisterUser("me", "me@home.com");
        }
    }
}
