using App.DIP.Bad.Models;

namespace App.DIP.Bad.Services
{
    // Notification a higher-level class is depending on the concrete
    // implementation of Email and Sms which are lower-level classes
    public class SenderService : ISenderService
    {
        private readonly Sms _sms;
        private readonly Email _email;

        public SenderService()
        {
            _sms = new Sms();
            _email = new Email();
        }

        public void Send()
        {
            _sms.SendSms();
            _email.SendEmail();
        }
    }
}