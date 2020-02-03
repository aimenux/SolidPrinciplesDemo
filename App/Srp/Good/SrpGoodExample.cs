using System;
using App.Extensions;
using App.Srp.Good.Notifiers;
using App.Srp.Good.Repositories;
using App.Srp.Good.Services;
using App.Srp.Good.Validators;

namespace App.Srp.Good
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
