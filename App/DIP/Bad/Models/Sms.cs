using System;

namespace App.DIP.Bad.Models
{
    public class Sms
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSms()
        {
            Console.WriteLine($"Sending {nameof(Sms)}");
        }
    }
}
