using App.Srp.Good.Notifiers;
using App.Srp.Good.Repositories;
using App.Srp.Good.Services;
using App.Srp.Good.Validators;

namespace App.Srp.Good
{
    public static class SrpGood
    {
        public static void Example()
        {
            var validator = new UserValidator();
            var repository = new UserRepository();
            var notifier = new UserNotifier();
            var service = new RegisterService(validator, repository, notifier);
            service.RegisterUser("me", "me@home.com");
        }
    }
}
