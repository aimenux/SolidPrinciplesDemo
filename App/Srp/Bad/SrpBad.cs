using App.Srp.Bad.Services;

namespace App.Srp.Bad
{
    public static class SrpBad
    {
        public static void Example()
        {
            var service = new RegisterService();
            service.RegisterUser("me", "me@home.com");
        }
    }
}
