using System;

namespace App.DIP.Good.Models
{
    public class Sms : IChannel
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            Console.WriteLine($"Sending {nameof(Sms)}");
        }
    }
}